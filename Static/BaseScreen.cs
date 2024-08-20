using ScoutingCodeRedo.Dynamic;
using ScoutingCodeRedo.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Windows.Forms;

namespace ScoutingCodeRedo.Static
{
    public partial class BaseScreen : Form
    {

        BackgroundCode bgc;
        public BaseScreen()
        {
            InitializeComponent();
            this.lblkey.Text = "";
            bgc = new BackgroundCode();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
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
                nextMatch();
                //for (int i = 0; i <= 5; i++)
                //{
                //    using (var db = new SeasonContext())
                //    {
                //        var teamNumber = bgc.Robots[i].TeamName;
                //        var result = db.Teamset.FirstOrDefault(b => b.team_key == teamNumber);

                //        var activityresult = db.ActivitySet.FirstOrDefault(a => a.Team == teamNumber && a.Match == currentmatch + 1 && a.RecordType == "EndMatch");
                //    }
                //}
                cbxEndMatch.Checked = false;
                if (currentmatch == bgc.InMemoryMatchList.Count)
                {
                    MessageBox.Show("You are at the last match.");
                    currentmatch--;
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
                        Log("cringe5");
                        HttpResponseMessage response = await client.GetAsync(uri);
                        response.EnsureSuccessStatusCode(); // Throw if not a success code.

                        string responseFromServer = await response.Content.ReadAsStringAsync();
                        Log("Response from Server -> " + responseFromServer);

                        List<TeamSummary> JSONteams = Newtonsoft.Json.JsonConvert.DeserializeObject<List<TeamSummary>>(responseFromServer);
                        Log("Received " + JSONteams.Count + " teams for " + eventcode + ".");

                        // Clear the existing team list
                        bgc.teamlist.Clear();

                        foreach (var item in JSONteams)
                        {
                            Log("Team -> " + item.team_number);
                            bgc.teamlist.Add(item.team_number);
                        }
                    }
                    catch (HttpRequestException e2)
                    {
                        Log("Request error: " + e2.Message);
                    }
                }
            }
            nextMatch();
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
