using ScoutingCodeRedo.Dynamic;
using ScoutingCodeRedo.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Windows.Forms;
using T250DynoScout_v2024;

namespace ScoutingCodeRedo.Static
{
    public partial class BaseScreen : Form
    {

        public static RobotState[] rs;   //Objects for storing Match State
        BackgroundCode bgc;
        public BaseScreen()
        {
            InitializeComponent();
            this.lblkey.Text = "";
            bgc = new BackgroundCode();
            Label[] scoutNameLabels = { lbl0ScoutName, lbl1ScoutName, lbl2ScoutName, lbl3ScoutName, lbl4ScoutName, lbl5ScoutName };

            for (int i = 0; i < 6; i++)
            {
                BackgroundCode.Robots[i] = new RobotState
                {
                    ScouterBox = i,
                    _ScouterName = RobotState.SCOUTER_NAME.Scouter1 + i,
                    color = i < 3 ? "Red" : "Blue"
                };
                scoutNameLabels[i].Text = BackgroundCode.Robots[i]._ScouterName.ToString();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void btnInitialDBLoad_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to load The Blue Alliance data?", "Please Confirm", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                BuildInitialDatabase();
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("The Blue Alliance data was not loaded", "", MessageBoxButtons.OK);
            }

            //  Logic for setting left/right and near/far based on side of field scouters are sitting on
            DialogResult red = MessageBox.Show("Is the Red Alliance on your right?", "Please Confirm", MessageBoxButtons.YesNo);
            if (red == DialogResult.Yes)
            {
                Properties.Settings.Default.redRight = true;
            }
            else
            {
                Properties.Settings.Default.redRight = false;
            }

            Log("SQL start time is " + DateTime.Now.TimeOfDay);
        }

        private void btnNextMatch_Click(object sender, EventArgs e)
        {
            List<string> ScoutList = new List<string>();
            if (cbxEndMatch.Checked)
            {
                cbxEndMatch.Checked = false;
                if (currentmatch == bgc.InMemoryMatchList.Count)
                {
                    MessageBox.Show("You are at the last match.");
                    currentmatch--;
                }
                else
                {
                    nextMatch();
                }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("All unsaved data will be lost.  Continue?", "Next Match", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes && currentmatch != bgc.InMemoryMatchList.Count)
                {
                    nextMatch();
                }
                else
                {
                    MessageBox.Show("You are at the last match.");
                    currentmatch--;
                }
            }
        }

        private void nextMatch()
        {
            currentmatch++;
            this.lblMatch.Text = (currentmatch).ToString();
            loadMatch();
        }

        private void btnPrevMatch_Click(object sender, EventArgs e)
        {
            if (currentmatch == 0)
            {
                MessageBox.Show("You are at the first match.");
            }
            else
            {
                currentmatch--;
                loadMatch();
            }
        }

        private void loadMatch()
        {
            this.lbl0TeamName.Text = BackgroundCode.Robots[0].TeamName = bgc.InMemoryMatchList[currentmatch - 1].redteam1;
            this.lbl1TeamName.Text = BackgroundCode.Robots[1].TeamName = bgc.InMemoryMatchList[currentmatch - 1].redteam2;
            this.lbl2TeamName.Text = BackgroundCode.Robots[2].TeamName = bgc.InMemoryMatchList[currentmatch - 1].redteam3;
            this.lbl3TeamName.Text = BackgroundCode.Robots[3].TeamName = bgc.InMemoryMatchList[currentmatch - 1].blueteam1;
            this.lbl4TeamName.Text = BackgroundCode.Robots[4].TeamName = bgc.InMemoryMatchList[currentmatch - 1].blueteam2;
            this.lbl5TeamName.Text = BackgroundCode.Robots[5].TeamName = bgc.InMemoryMatchList[currentmatch - 1].blueteam3;
        } 

        private async void btnpopulateForEvent_Click(object sender, EventArgs e)
        {
            if (this.comboBoxSelectRegional.Text == "Please press the Load Events Button...")
            {
                MessageBox.Show("You must load an event first.", "Not Ready to Get Matches");
                return;
            }
            else
            {
                eventcode = comboBoxSelectRegional.SelectedItem.ToString();
                eventcode = eventcode.TrimStart('[');
                regional = eventcode;
                int index = eventcode.IndexOf(",");
                if (index > 0) eventcode = eventcode.Substring(0, index);

                string uri = $"https://www.thebluealliance.com/api/v3/event/{DateTime.Now.Year}{eventcode}/teams?X-TBA-Auth-Key={Settings.Default.API_Key}";

                using (HttpClient client = new HttpClient())
                {
                    try
                    {
                        HttpResponseMessage response = await client.GetAsync(uri);
                        response.EnsureSuccessStatusCode(); // Throw if not a success code.

                        string responseFromServer = await response.Content.ReadAsStringAsync();
                        //Log("Response from Server -> " + responseFromServer);
                        //Console.Write(responseFromServer);

                        List<TeamSummary> JSONteams = Newtonsoft.Json.JsonConvert.DeserializeObject<List<TeamSummary>>(responseFromServer);
                        //Log("Received " + JSONteams.Count + " teams for " + eventcode + ".");

                        // Clear the existing team list
                        bgc.teamlist.Clear();

                        foreach (var item in JSONteams)
                        {
                            //Log("Team -> " + item.team_number);
                            bgc.teamlist.Add(item.team_number);
                        }
                    }
                    catch (HttpRequestException e2)
                    {
                        Log("Request error: " + e2.Message);
                    }
                }

                string matchesuri = $"https://www.thebluealliance.com/api/v3/event/{DateTime.Now.Year}{eventcode}/matches?X-TBA-Auth-Key={Settings.Default.API_Key}";

                using (HttpClient client = new HttpClient())
                {
                    try
                    {
                        HttpResponseMessage response = await client.GetAsync(matchesuri);
                        response.EnsureSuccessStatusCode(); // Throw if not a success code.

                        string responseFromServer = await response.Content.ReadAsStringAsync();
                        //Log("Response from Server -> " + responseFromServer);
                        //Console.Write(responseFromServer);

                        List<Match> JSONmatches = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Match>>(responseFromServer);
                        dynamic obj = Newtonsoft.Json.JsonConvert.DeserializeObject(responseFromServer);

                        int MatchCount = 0;
                        bgc.MatchNumbers.Clear();

                        for (int i = 0; i < JSONmatches.Count; i++)
                        {
                            if (JSONmatches[i].comp_level == "qm")
                            {
                                Match match_record = new Match();

                                MatchCount++;
                                bgc.MatchNumbers.Add(MatchCount);
                                bgc.InMemoryMatchList.Add(JSONmatches[i]);

                                dynamic alliances = obj[i].alliances;
                                dynamic bluealliance = alliances.blue;
                                dynamic redalliance = alliances.red;

                                dynamic blueteamsobj = bluealliance.team_keys;
                                dynamic redteamsobj = redalliance.team_keys;

                                string blue1 = blueteamsobj[0];
                                string blue2 = blueteamsobj[1];
                                string blue3 = blueteamsobj[2];
                                string red1 = redteamsobj[0];
                                string red2 = redteamsobj[1];
                                string red3 = redteamsobj[2];

                                match_record.match_number = (int)obj[i].match_number;

                                match_record.set_number = obj[i].match_number;

                                match_record.key = obj[i].key;
                                match_record.comp_level = obj[i].comp_level;
                                match_record.event_key = obj[i].event_key;
                                match_record.blueteam1 = blueteamsobj[0];
                                match_record.blueteam2 = blueteamsobj[1];
                                match_record.blueteam3 = blueteamsobj[2];
                                match_record.redteam1 = redteamsobj[0];
                                match_record.redteam2 = redteamsobj[1];
                                match_record.redteam3 = redteamsobj[2];

                                //Console.Write(match_record);
                                bgc.UnSortedMatchList.Add(match_record);
                            }
                        }

                    }
                    catch (HttpRequestException e2)
                    {
                        Log("Request error: " + e2.Message);
                    }
                }

                bgc.InMemoryMatchList = bgc.UnSortedMatchList.OrderBy(o => o.match_number).ToList();
            }
            nextMatch();
        }
        private void SwapScouters_Click(object sender, EventArgs e)
        {
            SwapScouters frm = new SwapScouters();
            frm.Show();
        }
        private void btnUpdateDB_Click(object sender, EventArgs e)
        {
            UpdateDatabase frm = new UpdateDatabase(bgc.teamlist, bgc.MatchNumbers);
            frm.Show();
            //if (DBExists)
            //{
            //    UpdateDatabase frm = new UpdateDatabase(bgc.teamlist, bgc.MatchNumbers);
            //    frm.Show();
            //}
            //else
            //{
            //    MessageBox.Show("Please load The Blue Aliance to create the database or create the database in a different way");
            //}
        }
        public void Log(string m)
        {
            //cross-thread Logging
            Func<int> del = delegate ()
            {
                this.lblkey.Text = this.lblkey.Text + m + System.Environment.NewLine;
                lstLog.TopIndex = lstLog.Items.Add(m + System.Environment.NewLine);
                return 0;
            };
            Invoke(del);
        }
    }
}
