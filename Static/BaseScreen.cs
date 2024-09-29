﻿using ScoutingCodeRedo.Dynamic;
using ScoutingCodeRedo.Properties;
using ScoutingCodeRedo.Static.GamePadFolder;
using SharpDX.XInput;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

                if (cbxPractice.Checked)
                {
                    Settings.Default.practiceMode = true;
                    UpdateJoysticks();

                    for (int i = 1; i < BackgroundCode.gamePads.Length; i++)
                    {
                        BackgroundCode.gamePads[i] = null;

                        Console.WriteLine(BackgroundCode.gamePads.Length);
                    }
                }
                else
                {
                    Settings.Default.practiceMode = false;
                }
            }
        }

        private void UpdateJoysticks()
        {
            BackgroundCode.controllers.getGamePads();
            BackgroundCode.gamePads = BackgroundCode.controllers.getGamePads();
        }
        private void UpdateScreen()
        {
            for (int i = 0; i < 6; i++)
            {
                ((Label)this.Controls.Find($"lbl{i}ScoutName", true)[0]).Text = BackgroundCode.Robots[i]._ScouterName.ToString();
                ((Label)this.Controls.Find($"lbl{i}ScoutName", true)[0]).Visible = (i == 0) || !Settings.Default.practiceMode;
                ((Label)this.Controls.Find($"lbl{i}MatchEvent", true)[0]).Text = BackgroundCode.Robots[i].match_event.ToString();
                ((Label)this.Controls.Find($"lbl{i}MatchEvent", true)[0]).Visible = (i == 0) || !Settings.Default.practiceMode;
                ((Label)this.Controls.Find($"lbl{i}ModeValue", true)[0]).Text = BackgroundCode.Robots[i].Current_Mode.ToString() + " Mode";
                ((Label)this.Controls.Find($"lbl{i}ModeValue", true)[0]).Visible = (i == 0) || !Settings.Default.practiceMode;

                ((Label)this.Controls.Find($"lbl{i}TeamName", true)[0]).Visible = (i == 0) || !Settings.Default.practiceMode;
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult confirmExit = MessageBox.Show("Are you sure you want to exit?", "Please Confirm", MessageBoxButtons.YesNo);
            if (confirmExit == DialogResult.Yes)
            {
                if (Settings.Default.loadedEvent != null)
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
            if (Settings.Default.loadedEvent != null && Settings.Default.currentMatch != 0)
            {
                try
                {
                    // Write data to INI file
                    iniFile.Write("MatchData", "event", Settings.Default.loadedEvent);
                    iniFile.Write("MatchData", "match_number", Settings.Default.currentMatch.ToString());
                    iniFile.Write("MatchData", "redRight", Settings.Default.redRight.ToString());
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

                BuildInitialDatabase();

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
                BuildInitialDatabase();
                //  Logic for setting left/right and near/far based on side of field scouters are sitting on
                DialogResult red = MessageBox.Show("Is the Red Alliance on your right?", "Please Confirm", MessageBoxButtons.YesNo);
                Settings.Default.redRight = (red == DialogResult.Yes);

                Log("SQL start time is " + DateTime.Now.TimeOfDay);
            }
            else
            {
                MessageBox.Show("The Blue Alliance data was not loaded", "", MessageBoxButtons.OK);
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
                else
                {
                    MessageBox.Show("You are at the last match.");
                    Settings.Default.currentMatch--;
                }
            }

            UpdateJoysticks();
        }

        private void nextMatch()
        {
            for (int i = 0; i < 6; i++)
            {
                DynamicResponses.transactToDatabase(BackgroundCode.Robots[i], "EndMatch");
            }

            Settings.Default.currentMatch++;
            this.lblMatch.Text = (Settings.Default.currentMatch).ToString();
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
            SetTeamNameAndColor(this.lbl0TeamName, BackgroundCode.Robots[0], bgc.InMemoryMatchList[Settings.Default.currentMatch - 1].redteam1, Settings.Default.teamPrio);
            SetTeamNameAndColor(this.lbl1TeamName, BackgroundCode.Robots[1], bgc.InMemoryMatchList[Settings.Default.currentMatch - 1].redteam2, Settings.Default.teamPrio);
            SetTeamNameAndColor(this.lbl2TeamName, BackgroundCode.Robots[2], bgc.InMemoryMatchList[Settings.Default.currentMatch - 1].redteam3, Settings.Default.teamPrio);
            SetTeamNameAndColor(this.lbl3TeamName, BackgroundCode.Robots[3], bgc.InMemoryMatchList[Settings.Default.currentMatch - 1].blueteam1, Settings.Default.teamPrio);
            SetTeamNameAndColor(this.lbl4TeamName, BackgroundCode.Robots[4], bgc.InMemoryMatchList[Settings.Default.currentMatch - 1].blueteam2, Settings.Default.teamPrio);
            SetTeamNameAndColor(this.lbl5TeamName, BackgroundCode.Robots[5], bgc.InMemoryMatchList[Settings.Default.currentMatch - 1].blueteam3, Settings.Default.teamPrio);
        }
        void SetTeamNameAndColor(Label label, RobotState robot, string teamName, List<string> teamPrioList)
        {
            label.Text = robot.TeamName = teamName;
            if (teamPrioList != null)
            {
                label.ForeColor = teamPrioList.Contains(teamName.Replace("frc", "").Trim()) ? Color.Blue : Color.Orange;
            }
            else
            {
                label.ForeColor = Color.Orange;
            }
        }

        private async void btnpopulateForEvent_Click(object sender, EventArgs e)
        {
            if (Settings.Default.manualMatchList != null)
            {
                // Clear the existing team list
                bgc.InMemoryMatchList.Clear();

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
        private void Priority_Click(object sender, EventArgs e)
        {
            PriorityForm frm = new PriorityForm();
            frm.Show();
        }
        private void btnUpdateDB_Click(object sender, EventArgs e)
        {
            if (Settings.Default.DBExists)
            {
                UpdateDatabase frm = new UpdateDatabase(bgc.teamlist, bgc.MatchNumbers);
                frm.Show();
            }
            else
            {
                MessageBox.Show("Please load The Blue Aliance to create the database or create the database in a different way");
            }
        }
        private void btnRefreshControllers_Click(object sender, EventArgs e)
        {
            UpdateJoysticks();
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
