using ScoutingCodeRedo.Dynamic;
using ScoutingCodeRedo.Properties;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net.Http;
using System.Windows.Forms;

namespace ScoutingCodeRedo.Static
{
    public partial class BaseScreen : Form
    {

        private readonly bool initializing = true;
        readonly BackgroundCode bgc;

        public string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
        public string projectBaseDirectory;
        public string iniPath;
        public INIFile iniFile;

        bool wasPractice = false;
        public BaseScreen()
        {
            //Initialization of the screen
            InitializeComponent();
            //Scales the screen to the resolution of the display
            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.btnInitialDBLoad.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            //Initialization of the background variables
            bgc = new BackgroundCode();

            //Sets the base directory for the ini file
            projectBaseDirectory = System.IO.Path.GetFullPath(System.IO.Path.Combine(baseDirectory, @"..\..\"));
            iniPath = System.IO.Path.Combine(projectBaseDirectory, "config.ini");
            iniFile = new INIFile(iniPath);

            //timerJoysticks updates every 20 ms
            timerJoysticks.Enabled = true;

            //If there is previous data, ask if the user wants to load it
            if (iniFile.Read("MatchData", "event", "") != null || iniFile.Read("MatchData", "event", "") != "")
            {
                DialogResult loadPrevData = MessageBox.Show("Do you want to load previous data?", "Please Confirm", MessageBoxButtons.YesNo);
                if (loadPrevData == DialogResult.Yes)
                {
                    LoadData();
                }
            }

            //Grabs all connected joysticks
            UpdateJoysticks();

            //Turns off initialization
            initializing = false;
        }

        private void JoyStickReader(object sender, EventArgs e)
        {
            //Checks if the program is initializing
            if (!initializing)
            {
                //Updates the screen with the current data
                UpdateScreen();

                //Loop through all connected gamepads
                for (int gamepad_ctr = 0; gamepad_ctr < BackgroundCode.gamePads.Length; gamepad_ctr++)
                {
                    BackgroundCode.controllers.ReadStick(BackgroundCode.gamePads, gamepad_ctr);
                }

                // Loop through all Scouters/Robots
                for (int robot_ctr = 0; robot_ctr < BackgroundCode.Robots.Length; robot_ctr++)
                {
                    BackgroundCode.Robots[robot_ctr] = BackgroundCode.controllers.GetRobotState(robot_ctr);  //Initialize all six robots
                }

                //If the program is in practice mode
                if (Settings.Default.practiceMode)
                {
                    //Checks if it was just not in practice mode
                    if (!wasPractice)
                    {
                        //Updates the joysticks
                        UpdateJoysticks();
                    }

                    //Changes gamepads 1 to 5 to null
                    for (int i = 1; i < BackgroundCode.gamePads.Length; i++)
                    {
                        BackgroundCode.gamePads[i] = null;
                    }

                    //If the scouter error increases, play the sound
                    if (BackgroundCode.Robots[0].prevScouterError != BackgroundCode.Robots[0].ScouterError)
                    {
                        BackgroundCode.soundCue.Play();
                        BackgroundCode.Robots[0].prevScouterError = BackgroundCode.Robots[0].ScouterError;
                    }
                    //Sets that it was in practice mode
                    wasPractice = true;
                }
                else
                {
                    //If it was just in practice mode
                    if (wasPractice)
                    {
                        //Update joysticks
                        UpdateJoysticks();
                    }
                    //Sets that it was not in practice mode
                    wasPractice = false;
                    //Removes the sound player
                    BackgroundCode.soundCue.Dispose();
                }
            }
        }

        public static void UpdateJoysticks()
        {
            //Updates the list of currently connected gamepads
            BackgroundCode.gamePads = BackgroundCode.controllers.GetGamePads();
        }
        private void UpdateScreen()
        {
            //Loops through all 6 boxes to update the text to be based on the RobotState
            for (int i = 0; i < 6; i++)
            {
                ((Label)this.Controls.Find($"lbl{BackgroundCode.Robots[i].ScouterBox}ScoutName", true)[0]).Text = BackgroundCode.Robots[i].GetScouterName().ToString();
                ((Label)this.Controls.Find($"lbl{BackgroundCode.Robots[i].ScouterBox}ScoutName", true)[0]).Visible = (i < BackgroundCode.gamePads.Length) || !Settings.Default.practiceMode;
                ((Label)this.Controls.Find($"lbl{BackgroundCode.Robots[i].ScouterBox}MatchEvent", true)[0]).Text = BackgroundCode.Robots[i].Match_event.ToString();
                ((Label)this.Controls.Find($"lbl{BackgroundCode.Robots[i].ScouterBox}MatchEvent", true)[0]).Visible = (i < BackgroundCode.gamePads.Length) || !Settings.Default.practiceMode;
                ((Label)this.Controls.Find($"lbl{BackgroundCode.Robots[i].ScouterBox}ModeValue", true)[0]).Text = BackgroundCode.Robots[i].Current_Mode.ToString() + " Mode";
                ((Label)this.Controls.Find($"lbl{BackgroundCode.Robots[i].ScouterBox}ModeValue", true)[0]).Visible = (i < BackgroundCode.gamePads.Length) || !Settings.Default.practiceMode;

                ((Label)this.Controls.Find($"lbl{BackgroundCode.Robots[i].ScouterBox}TeamName", true)[0]).Visible = (i < BackgroundCode.gamePads.Length) || !Settings.Default.practiceMode;
            }
        }
        private void BtnExit_Click(object sender, EventArgs e)
        {
            //Makes sure the user wants to exit
            DialogResult confirmExit = MessageBox.Show("Are you sure you want to exit?", "Please Confirm", MessageBoxButtons.YesNo);
            if (confirmExit == DialogResult.Yes)
            {
                //If the event is loaded or manual matches are loaded, ask if the user wants to save the data
                if (Settings.Default.loadedEvent != null || Settings.Default.manualMatchList != null)
                {
                    confirmExit = MessageBox.Show("Do you want to save the current data?", "Please Confirm", MessageBoxButtons.YesNo);
                    if (confirmExit == DialogResult.Yes)
                    {
                        //Save the data
                        SaveData();
                    }
                }

                //Close the connection then exit
                BackgroundCode.seasonframework.Database.Connection.Close();
                Environment.Exit(0);
            }
        }
        public void SaveData()
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
                            scouterNames += ",";
                        }
                        scouterNames += robot.GetScouterName();

                        if (scouterLocations.Length != 0)
                        {
                            scouterLocations += ",";
                        }
                        scouterLocations += robot.ScouterBox;
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
        private void LoadData()
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

                BtnpopulateForEvent_Click(null, null);
            }
            catch (Exception e)
            {
                MessageBox.Show("Could not load data.", "Error: " + e);
            }

        }
        private void BtnInitialDBLoad_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to load The Blue Alliance data?", "Please Confirm", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                BackgroundCode.seasonframework.Database.Connection.Close();
                BuildInitialDatabase(false);
                SetRedRight();

                Log("SQL start time is " + DateTime.Now.TimeOfDay);
            }
            else
            {
                DialogResult manualMatches = MessageBox.Show("Do you want to load manual matches?", "Please Confirm", MessageBoxButtons.YesNo);
                if (manualMatches == DialogResult.Yes)
                {
                    SetRedRight();
                    Log("Loading manual matches.");
                    LoadManualMatches();
                    comboBoxSelectRegional.Items.Clear();
                    comboBoxSelectRegional.Items.Add("manualEvent");
                    comboBoxSelectRegional.SelectedItem = "manualEvent";
                    BtnpopulateForEvent_Click(null, null);
                }
            }
        }
        private void SetRedRight()
        {
            //  Logic for setting left/right and near/far based on side of field scouters are sitting on
            DialogResult red = MessageBox.Show("Is the Red Alliance on your right?", "Please Confirm", MessageBoxButtons.YesNo);
            Settings.Default.redRight = (red == DialogResult.Yes);
        }

        private void BtnNextMatch_Click(object sender, EventArgs e)
        {
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
                        DynamicResponses.TransactToDatabase(BackgroundCode.Robots[BackgroundCode.Robots[i].ScouterBox], "EndMatch", false);
                    }

                    NextMatch();
                }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("All unsaved data will be lost.  Continue?", "Next Match", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes && Settings.Default.currentMatch != bgc.InMemoryMatchList.Count)
                {
                    NextMatch();
                }
                else if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show("You are at the last match.");
                    Settings.Default.currentMatch--;
                }
            }
        }

        private void NextMatch()
        {
            Settings.Default.currentMatch++;
            LoadMatch();
        }

        private void BtnPrevMatch_Click(object sender, EventArgs e)
        {
            if (Settings.Default.currentMatch == 0)
            {
                MessageBox.Show("You are at the first match.");
            }
            else
            {
                Settings.Default.currentMatch--;
                LoadMatch();
            }
        }

        private void LoadMatch()
        {
            DynamicResponses.ResetValues();
            this.lblMatch.Text = $"{Settings.Default.currentMatch}/{bgc.UnSortedMatchList.Count}";
            List<string> teamPrioList = null;
            if (Settings.Default.teamPrio != null)
            {
                teamPrioList = Settings.Default.teamPrio.Cast<string>().ToList();
            }

            SetTeamNameAndColor(this.lbl0TeamName, BackgroundCode.Robots[0], bgc.InMemoryMatchList[Settings.Default.currentMatch - 1].Redteam1, teamPrioList);
            SetTeamNameAndColor(this.lbl1TeamName, BackgroundCode.Robots[1], bgc.InMemoryMatchList[Settings.Default.currentMatch - 1].Redteam2, teamPrioList);
            SetTeamNameAndColor(this.lbl2TeamName, BackgroundCode.Robots[2], bgc.InMemoryMatchList[Settings.Default.currentMatch - 1].Redteam3, teamPrioList);
            SetTeamNameAndColor(this.lbl3TeamName, BackgroundCode.Robots[3], bgc.InMemoryMatchList[Settings.Default.currentMatch - 1].Blueteam1, teamPrioList);
            SetTeamNameAndColor(this.lbl4TeamName, BackgroundCode.Robots[4], bgc.InMemoryMatchList[Settings.Default.currentMatch - 1].Blueteam2, teamPrioList);
            SetTeamNameAndColor(this.lbl5TeamName, BackgroundCode.Robots[5], bgc.InMemoryMatchList[Settings.Default.currentMatch - 1].Blueteam3, teamPrioList);
        }
        void SetTeamNameAndColor(Label label, RobotState robot, string teamName, List<string> teamPrioList)
        {
            if (Settings.Default.practiceMode)
            {
                label.Text = robot.TeamName = bgc.InMemoryMatchList[Settings.Default.currentMatch - 1].Redteam1;
            }
            else
            {
                label.Text = robot.TeamName = teamName;
            }

            if (teamPrioList != null)
            {
                label.ForeColor = teamPrioList.Contains(label.Text.Replace("frc", "").Trim()) ? Color.White : Color.Orange;
            }
            else
            {
                label.ForeColor = Color.Orange;
            }

        }

        private async void BtnpopulateForEvent_Click(object sender, EventArgs e)
        {
            if (sender != null)
            {
                Settings.Default.currentMatch = 0;
            }
            bgc.UnSortedMatchList.Clear();
            bgc.InMemoryMatchList.Clear();
            if (Settings.Default.manualMatchList != null)
            {
                List<string> manualTeams = new List<string>();

                for (int i = 0; i < Settings.Default.manualMatchList.Count; i++)
                {
                    Match matchData = new Match
                    {
                        Match_number = i,
                        Set_number = i,
                        Key = "manualevent",
                        Comp_level = "qm",
                        Event_key = "manualevent",

                        Redteam1 = "frc" + Settings.Default.manualMatchList[i][0],
                        Redteam2 = "frc" + Settings.Default.manualMatchList[i][1],
                        Redteam3 = "frc" + Settings.Default.manualMatchList[i][2],
                        Blueteam1 = "frc" + Settings.Default.manualMatchList[i][3],
                        Blueteam2 = "frc" + Settings.Default.manualMatchList[i][4],
                        Blueteam3 = "frc" + Settings.Default.manualMatchList[i][5]
                    };

                    bgc.UnSortedMatchList.Add(matchData);
                    bgc.InMemoryMatchList.Add(matchData);
                    BackgroundCode.seasonframework.Matchset.Add(matchData);
                    BackgroundCode.seasonframework.SaveChanges();

                    BackgroundCode.MatchNumbers.Add(i + 1);

                    for (int j = 0; j < Settings.Default.manualMatchList[i].Count; j++)
                    {
                        if (!manualTeams.Contains(Settings.Default.manualMatchList[i][j]))
                        {
                            manualTeams.Add(Settings.Default.manualMatchList[i][j]);
                        }
                    }
                }

                foreach (var team in manualTeams)
                {
                    TeamSummary teamData = new TeamSummary
                    {
                        Team_key = "frc" + team,
                        Team_number = team,
                        Event_key = "manualevent",
                        Nickname = "manualevent"
                    };
                    BackgroundCode.seasonframework.Teamset.Add(teamData);
                    BackgroundCode.seasonframework.SaveChanges();

                    BackgroundCode.teamlist.Add(team);
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
                                        orderby b.Team_key
                                        select b;

                        // Clear the existing team list
                        BackgroundCode.teamlist.Clear();

                        foreach (var item in JSONteams)
                        {
                            BackgroundCode.teamlist.Add(item.Team_number);
                        }
                        Log("Teams -> " + string.Join(", ", JSONteams.Select(item => item.Team_number)));

                        using (var db = new SeasonContext())
                        {
                            var teamNumber = BackgroundCode.Robots[0].TeamName;
                            var result = db.Teamset.FirstOrDefault(b => b.Team_key == teamNumber);
                            if (result == null)
                            {
                                //Recording a list of teams to the database
                                JSONteams = (List<TeamSummary>)Newtonsoft.Json.JsonConvert.DeserializeObject(responseFromServer, typeof(List<TeamSummary>));

                                dynamic objt = Newtonsoft.Json.JsonConvert.DeserializeObject(responseFromServer);

                                var team_key = "0";
                                for (int i = 0; i < JSONteams.Count; i++)
                                {
                                    team_key = objt[i].key;
                                    var result2 = db.Teamset.FirstOrDefault(b => b.Team_key == team_key);
                                    if (result2 == null)
                                    {
                                        TeamSummary team_record = new TeamSummary
                                        {
                                            Team_key = objt[i].key,
                                            Team_number = objt[i].team_number,
                                            Event_key = regional,
                                            Nickname = objt[i].nickname
                                        };

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
                            if (JSONmatches[i].Comp_level == "qm")
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

                                match_record.Match_number = (int)obj[i].match_number;

                                match_record.Set_number = obj[i].match_number;

                                match_record.Key = obj[i].key;
                                match_record.Comp_level = obj[i].comp_level;
                                match_record.Event_key = obj[i].event_key;
                                match_record.Blueteam1 = blueteamsobj[0];
                                match_record.Blueteam2 = blueteamsobj[1];
                                match_record.Blueteam3 = blueteamsobj[2];
                                match_record.Redteam1 = redteamsobj[0];
                                match_record.Redteam2 = redteamsobj[1];
                                match_record.Redteam3 = redteamsobj[2];

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

                bgc.InMemoryMatchList = bgc.UnSortedMatchList.OrderBy(o => o.Match_number).ToList();
            }
            NextMatch();
        }
        public void Log(string m)
        {
            //cross-thread Logging
            Func<int> del = delegate ()
            {
                bgc.print.UpdateLbl(m);
                lstLog.TopIndex = lstLog.Items.Add(m + System.Environment.NewLine);
                return 0;
            };
            try
            {
                Invoke(del);
            }
            catch { }
        }

        private void BtnFunctions_Click(object sender, EventArgs e)
        {
            FunctionsForm frm = new FunctionsForm();
            frm.Show();
        }
    }
}
