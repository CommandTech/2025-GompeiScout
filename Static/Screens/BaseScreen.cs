using ScoutingCodeRedo.Dynamic;
using ScoutingCodeRedo.Properties;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Windows.Forms;

namespace ScoutingCodeRedo.Static
{
    public partial class BaseScreen : Form
    {

        private bool initializing = true;
        BackgroundCode bgc;

        public string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
        public string projectBaseDirectory;
        public string iniPath;
        public INIFile iniFile;

        bool wasPractice = false;
        public BaseScreen()
        {
            InitializeComponent();
            this.lblkey.Text = "";
            bgc = new BackgroundCode();

            projectBaseDirectory = System.IO.Path.GetFullPath(System.IO.Path.Combine(baseDirectory, @"..\..\"));
            iniPath = System.IO.Path.Combine(projectBaseDirectory, "config.ini");
            iniFile = new INIFile(iniPath);

            timerJoysticks.Enabled = true;

            if (iniFile.Read("MatchData", "event", "") != null || iniFile.Read("MatchData", "event", "") != "")
            {
                DialogResult loadPrevData = MessageBox.Show("Do you want to load previous data?", "Please Confirm", MessageBoxButtons.YesNo);
                if (loadPrevData == DialogResult.Yes)
                {
                    loadData();
                }
            }

            UpdateJoysticks();

            initializing = false;
        }

        private void JoyStickReader(object sender, EventArgs e)
        {
            if (!initializing)
            {
                UpdateScreen();

                //Loop through all connected gamepads
                for (int gamepad_ctr = 0; gamepad_ctr < BackgroundCode.gamePads.Length; gamepad_ctr++)
                {
                    BackgroundCode.controllers.readStick(BackgroundCode.gamePads, gamepad_ctr);
                }

                // Loop through all Scouters/Robots
                for (int robot_ctr = 0; robot_ctr < BackgroundCode.Robots.Length; robot_ctr++)
                {
                    BackgroundCode.Robots[robot_ctr] = BackgroundCode.controllers.getRobotState(robot_ctr);  //Initialize all six robots
                }

                if (Settings.Default.practiceMode)
                {
                    if (!wasPractice)
                    {
                        UpdateJoysticks();
                    }

                    for (int i = 1; i < BackgroundCode.gamePads.Length; i++)
                    {
                        BackgroundCode.gamePads[i] = null;
                    }

                    if (BackgroundCode.Robots[0].prevScouterError != BackgroundCode.Robots[0].ScouterError)
                    {
                        BackgroundCode.soundCue.Play();
                        BackgroundCode.Robots[0].prevScouterError = BackgroundCode.Robots[0].ScouterError;
                    }
                    wasPractice = true;
                }
                else
                {
                    if (wasPractice)
                    {
                        UpdateJoysticks();
                    }
                    wasPractice = false;
                    BackgroundCode.soundCue.Dispose();
                }
            }
        }

        public static void UpdateJoysticks()
        {
            BackgroundCode.controllers.getGamePads();
            BackgroundCode.gamePads = BackgroundCode.controllers.getGamePads();
        }
        private void UpdateScreen()
        {
            for (int i = 0; i < 6; i++)
            {
                ((Label)this.Controls.Find($"lbl{i}ScoutName", true)[0]).Text = BackgroundCode.Robots[BackgroundCode.Robots[i].ScouterBox]._ScouterName.ToString();
                ((Label)this.Controls.Find($"lbl{i}ScoutName", true)[0]).Visible = (i == 0) || !Settings.Default.practiceMode;
                ((Label)this.Controls.Find($"lbl{i}MatchEvent", true)[0]).Text = BackgroundCode.Robots[BackgroundCode.Robots[i].ScouterBox].match_event.ToString();
                ((Label)this.Controls.Find($"lbl{i}MatchEvent", true)[0]).Visible = (i == 0) || !Settings.Default.practiceMode;
                ((Label)this.Controls.Find($"lbl{i}ModeValue", true)[0]).Text = BackgroundCode.Robots[BackgroundCode.Robots[i].ScouterBox].Current_Mode.ToString() + " Mode";
                ((Label)this.Controls.Find($"lbl{i}ModeValue", true)[0]).Visible = (i == 0) || !Settings.Default.practiceMode;

                ((Label)this.Controls.Find($"lbl{i}TeamName", true)[0]).Visible = (i == 0) || !Settings.Default.practiceMode;
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult confirmExit = MessageBox.Show("Are you sure you want to exit?", "Please Confirm", MessageBoxButtons.YesNo);
            if (confirmExit == DialogResult.Yes)
            {
                if (Settings.Default.loadedEvent != null || Settings.Default.manualMatchList != null)
                {
                    confirmExit = MessageBox.Show("Do you want to save the current data?", "Please Confirm", MessageBoxButtons.YesNo);
                    if (confirmExit == DialogResult.Yes)
                    {
                        saveData();
                    }
                }

                BackgroundCode.seasonframework.Database.Connection.Close();
                Environment.Exit(0);
            }
        }
        public void saveData()
        {
            if ((Settings.Default.loadedEvent != null || Settings.Default.manualMatchList != null) && Settings.Default.currentMatch != 0)
            {
                try
                {
                    // Write data to INI file
                    if (Settings.Default.loadedEvent == null)
                    {
                        iniFile.Write("MatchData", "event", "manualEvent");
                    }
                    else
                    {
                        iniFile.Write("MatchData", "event", Settings.Default.loadedEvent);
                    }
                    iniFile.Write("MatchData", "match_number", Settings.Default.currentMatch.ToString());
                    iniFile.Write("MatchData", "redRight", Settings.Default.redRight.ToString());
                    iniFile.Write("MatchData", "teamPrio", string.Join(",", Settings.Default.teamPrio));
                    string scouterNames = "";
                    string scouterLocations = "";
                    foreach (var robot in BackgroundCode.Robots)
                    {
                        if (scouterNames.Length != 0)
                        {
                            scouterNames = scouterNames + ",";
                        }
                        scouterNames = scouterNames + robot._ScouterName;

                        if (scouterLocations.Length != 0)
                        {
                            scouterLocations = scouterLocations + ",";
                        }
                        scouterLocations = scouterLocations + robot.ScouterBox;
                    }
                    iniFile.Write("MatchData", "scouterNames", scouterNames);
                    iniFile.Write("MatchData", "scouterLocations", scouterLocations);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving data: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("No data to save.");
            }
        }
        private void loadData()
        {
            try
            {
                comboBoxSelectRegional.Items.Add(iniFile.Read("MatchData", "event", "Please press the Load Events Button..."));
                comboBoxSelectRegional.SelectedItem = iniFile.Read("MatchData", "event", "Please press the Load Events Button...");
                Settings.Default.currentMatch = int.Parse(iniFile.Read("MatchData", "match_number", "")) - 1;
                Settings.Default.redRight = bool.Parse(iniFile.Read("MatchData", "redRight", ""));
                var teamPrioList = new List<string>(iniFile.Read("MatchData", "teamPrio", "").Split(','));
                Settings.Default.teamPrio = new StringCollection();
                Settings.Default.teamPrio.AddRange(teamPrioList.ToArray());


                List<string> scouterNames = new List<string>(iniFile.Read("MatchData", "scouterNames", "").Split(','));
                List<string> scouterLocations = new List<string>(iniFile.Read("MatchData", "scouterLocations", "").Split(','));

                for (int i = 0; i < 6; i++)
                {
                    BackgroundCode.Robots[i]._ScouterName = (RobotState.SCOUTER_NAME)Enum.Parse(typeof(RobotState.SCOUTER_NAME), scouterNames[i]);
                    BackgroundCode.Robots[i].ScouterBox = int.Parse(scouterLocations[i]);
                }

                BackgroundCode.seasonframework.Database.Connection.Close();
                if (comboBoxSelectRegional.SelectedItem.ToString() == "manualEvent")
                {
                    BuildInitialDatabase(true);
                }
                else
                {
                    BuildInitialDatabase(false);
                }

                btnpopulateForEvent_Click(null, null);
            }
            catch(Exception e)
            {
                MessageBox.Show("Could not load data.", "Error: " + e);
            }

        }
        private void btnInitialDBLoad_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to load The Blue Alliance data?", "Please Confirm", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                BackgroundCode.seasonframework.Database.Connection.Close();
                BuildInitialDatabase(false);
                //  Logic for setting left/right and near/far based on side of field scouters are sitting on
                DialogResult red = MessageBox.Show("Is the Red Alliance on your right?", "Please Confirm", MessageBoxButtons.YesNo);
                Settings.Default.redRight = (red == DialogResult.Yes);

                Log("SQL start time is " + DateTime.Now.TimeOfDay);
            }
            else
            {
                DialogResult manualMatches = MessageBox.Show("Do you want to load manual matches?", "Please Confirm", MessageBoxButtons.YesNo);
                if (manualMatches == DialogResult.Yes)
                {
                    Log("Loading manual matches.");
                    loadManualMatches();
                    comboBoxSelectRegional.Items.Clear();
                    comboBoxSelectRegional.Items.Add("manualEvent");
                    comboBoxSelectRegional.SelectedItem = "manualEvent";
                }
            }
        }

        private void btnNextMatch_Click(object sender, EventArgs e)
        {
            List<string> ScoutList = new List<string>();
            if (cbxEndMatch.Checked)
            {
                cbxEndMatch.Checked = false;
                if (Settings.Default.currentMatch == bgc.InMemoryMatchList.Count)
                {
                    MessageBox.Show("You are at the last match.");
                    Settings.Default.currentMatch--;
                }
                else
                {
                    for (int i = 0; i < 6; i++)
                    {
                        DynamicResponses.transactToDatabase(BackgroundCode.Robots[BackgroundCode.Robots[i].ScouterBox], "EndMatch");
                    }

                    nextMatch();
                }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("All unsaved data will be lost.  Continue?", "Next Match", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes && Settings.Default.currentMatch != bgc.InMemoryMatchList.Count)
                {
                    nextMatch();
                }
                else if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show("You are at the last match.");
                    Settings.Default.currentMatch--;
                }
            }

            UpdateJoysticks();
        }

        private void nextMatch()
        {
            Settings.Default.currentMatch++;
            loadMatch();
        }

        private void btnPrevMatch_Click(object sender, EventArgs e)
        {
            if (Settings.Default.currentMatch == 0)
            {
                MessageBox.Show("You are at the first match.");
            }
            else
            {
                Settings.Default.currentMatch--;
                loadMatch();
            }
        }

        private void loadMatch()
        {
            DynamicResponses.resetValues();
            this.lblMatch.Text = $"{Settings.Default.currentMatch}/{bgc.UnSortedMatchList.Count}";
            List<string> teamPrioList = null;
            if (Settings.Default.teamPrio != null)
            {
                teamPrioList = Settings.Default.teamPrio.Cast<string>().ToList();
            }

            SetTeamNameAndColor(this.lbl0TeamName, BackgroundCode.Robots[BackgroundCode.Robots[0].ScouterBox], bgc.InMemoryMatchList[Settings.Default.currentMatch - 1].redteam1, teamPrioList);
            SetTeamNameAndColor(this.lbl1TeamName, BackgroundCode.Robots[BackgroundCode.Robots[1].ScouterBox], bgc.InMemoryMatchList[Settings.Default.currentMatch - 1].redteam2, teamPrioList);
            SetTeamNameAndColor(this.lbl2TeamName, BackgroundCode.Robots[BackgroundCode.Robots[2].ScouterBox], bgc.InMemoryMatchList[Settings.Default.currentMatch - 1].redteam3, teamPrioList);
            SetTeamNameAndColor(this.lbl3TeamName, BackgroundCode.Robots[BackgroundCode.Robots[3].ScouterBox], bgc.InMemoryMatchList[Settings.Default.currentMatch - 1].blueteam1, teamPrioList);
            SetTeamNameAndColor(this.lbl4TeamName, BackgroundCode.Robots[BackgroundCode.Robots[4].ScouterBox], bgc.InMemoryMatchList[Settings.Default.currentMatch - 1].blueteam2, teamPrioList);
            SetTeamNameAndColor(this.lbl5TeamName, BackgroundCode.Robots[BackgroundCode.Robots[5].ScouterBox], bgc.InMemoryMatchList[Settings.Default.currentMatch - 1].blueteam3, teamPrioList);
        }
        void SetTeamNameAndColor(Label label, RobotState robot, string teamName, List<string> teamPrioList)
        {
            label.Text = robot.TeamName = teamName;
            if (teamPrioList != null)
            {
                label.ForeColor = teamPrioList.Contains(teamName.Replace("frc", "").Trim()) ? Color.White : Color.Orange;
            }
            else
            {
                label.ForeColor = Color.Orange;
            }
        }

        private void resetValues()
        {

        }

        private async void btnpopulateForEvent_Click(object sender, EventArgs e)
        {
            if (sender != null)
            {
                Settings.Default.currentMatch = 0;
            }
            bgc.UnSortedMatchList.Clear();
            bgc.InMemoryMatchList.Clear();
            if (Settings.Default.manualMatchList != null)
            {
                for (int i = 0; i < Settings.Default.manualMatchList.Count; i++)
                {
                    Match matchData = new Match();

                    matchData.match_number = i;
                    matchData.redteam1 = "frc" + Settings.Default.manualMatchList[i][0];
                    matchData.redteam2 = "frc" + Settings.Default.manualMatchList[i][1];
                    matchData.redteam3 = "frc" + Settings.Default.manualMatchList[i][2];
                    matchData.blueteam1 = "frc" + Settings.Default.manualMatchList[i][3];
                    matchData.blueteam2 = "frc" + Settings.Default.manualMatchList[i][4];
                    matchData.blueteam3 = "frc" + Settings.Default.manualMatchList[i][5];

                    bgc.UnSortedMatchList.Add(matchData);
                    bgc.InMemoryMatchList.Add(matchData);
                }
            }
            else if (this.comboBoxSelectRegional.Text == "Please press the Load Events Button...")
            {
                MessageBox.Show("You must load an event first.", "Not Ready to Get Matches");
                return;
            }
            else
            {
                Settings.Default.loadedEvent = comboBoxSelectRegional.SelectedItem.ToString();
                regional = Settings.Default.loadedEvent.TrimStart('[');
                int index = regional.IndexOf(",");
                if (index > 0) regional = regional.Substring(0, index);

                string uri = $"https://www.thebluealliance.com/api/v3/event/{DateTime.Now.Year}{regional}/teams?X-TBA-Auth-Key={Settings.Default.API_Key}";

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
                        Log("Received " + JSONteams.Count + " teams for " + regional + ".");

                        var teamquery = from b in BackgroundCode.seasonframework.Teamset
                                        orderby b.team_key
                                        select b;

                        // Clear the existing team list
                        BackgroundCode.teamlist.Clear();

                        foreach (var item in JSONteams)
                        {
                            BackgroundCode.teamlist.Add(item.team_number);
                        }
                        Log("Teams -> " + string.Join(", ", JSONteams.Select(item => item.team_number)));

                        using (var db = new SeasonContext())
                        {
                            var teamNumber = BackgroundCode.Robots[0].TeamName;
                            var result = db.Teamset.FirstOrDefault(b => b.team_key == teamNumber);
                            if (result == null)
                            {
                                //Recording a list of teams to the database
                                JSONteams = (List<TeamSummary>)Newtonsoft.Json.JsonConvert.DeserializeObject(responseFromServer, typeof(List<TeamSummary>));

                                dynamic objt = Newtonsoft.Json.JsonConvert.DeserializeObject(responseFromServer);

                                var team_key = "0";
                                for (int i = 0; i < JSONteams.Count; i++)
                                {
                                    team_key = objt[i].key;
                                    var result2 = db.Teamset.FirstOrDefault(b => b.team_key == team_key);
                                    if (result2 == null)
                                    {
                                        TeamSummary team_record = new TeamSummary();
                                        team_record.team_key = objt[i].key;
                                        team_record.team_number = objt[i].team_number;
                                        team_record.event_key = regional;
                                        team_record.nickname = objt[i].nickname;

                                        //Save changes
                                        BackgroundCode.seasonframework.Teamset.Add(team_record);
                                        BackgroundCode.seasonframework.SaveChanges();
                                    }
                                }
                            }
                        }
                    }
                    catch (HttpRequestException e2)
                    {
                        Log("Request error: " + e2.Message);
                    }
                }

                string matchesuri = $"https://www.thebluealliance.com/api/v3/event/{DateTime.Now.Year}{regional}/matches?X-TBA-Auth-Key={Settings.Default.API_Key}";

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
                        BackgroundCode.MatchNumbers.Clear();

                        for (int i = 0; i < JSONmatches.Count; i++)
                        {
                            if (JSONmatches[i].comp_level == "qm")
                            {
                                Match match_record = new Match();

                                MatchCount++;
                                BackgroundCode.MatchNumbers.Add(MatchCount);
                                bgc.InMemoryMatchList.Add(JSONmatches[i]);

                                dynamic alliances = obj[i].alliances;
                                dynamic bluealliance = alliances.blue;
                                dynamic redalliance = alliances.red;

                                dynamic blueteamsobj = bluealliance.team_keys;
                                dynamic redteamsobj = redalliance.team_keys;

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
                                BackgroundCode.seasonframework.Matchset.Add(match_record);
                            }
                        }
                        Log($"{bgc.UnSortedMatchList.Count} matches");

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
        public void Log(string m)
        {
            //cross-thread Logging
            Func<int> del = delegate ()
            {
                this.lblkey.Text = this.lblkey.Text + m + System.Environment.NewLine;
                lstLog.TopIndex = lstLog.Items.Add(m + System.Environment.NewLine);
                return 0;
            };
            try
            {
                Invoke(del);
            }
            catch { }
        }

        private void btnFunctions_Click(object sender, EventArgs e)
        {
            FunctionsForm frm = new FunctionsForm();
            frm.Show();
        }
    }
}
