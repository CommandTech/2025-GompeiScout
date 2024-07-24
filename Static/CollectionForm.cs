using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Net;
using SharpDX.DirectInput;
using ScoutingCodeRedo.Dynamic;

namespace ScoutingCodeRedo.Static
{
    public partial class MainScreen : Form
    {
        //Definitions for Xbox Controllers
        DirectInput Input = new DirectInput();
        GamePad[] gamePads;

        public static RobotState[] Robots = new RobotState[6];                            //Contains the state of each Scout's match tracking
        Controllers controllers = new Controllers();                        //Array of six Xbox controllers 
        Utilities utilities = new Utilities();                              //Instantiate the Utilities class
        //Lists for storing regional/qualifying events, teams attending and matches between teams       
        List<string> teamlist = new List<string>();                         //The list of teams for the event selected
        List<KeyValuePair<string, string>> event_list = new List<KeyValuePair<string, string>>();   //Contains the list of event codes and names
        public List<Match> InMemoryMatchList = new List<Match>();           //The list of all the matches at the selected event.
        List<Match> UnSortedMatchList = new List<Match>();                  //This is just the list of all matches, not yet sorted
        List<int> MatchNumbers = new List<int>();

        Activity activity_record = new Activity();                          //This is the activity for one Acquire/Scoring cycle.  We also save when an Event Activity is selected.       
        SeasonContext seasonframework = new SeasonContext();                //This is the context, meaning the entire database structure supporting this application.

        public string eventcode;                                            //The event code of the selected event
        public static int currentmatch = 0;                                               //The match number currently selected and being tracked
        public string regional;

        //Name: MainScreen()
        //Purpose: Initialize the actual form with the six tracking boxes
        //public MainScreen()
        //{
        //    InitializeComponent();

        //    //Initializing Controllers found
        //    controllers.getGamePads();
        //    gamePads = controllers.getGamePads();
        //    timerJoysticks.Enabled = true;
        //}

        //Name: Log()
        //Purpose: This is the log method we use to write activity to the debugging log field on the screen (makes it much easier to know what's going on!)
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
                RobotState.Red_Right = true;

            }
            else
            {
                RobotState.Red_Right = false;
            }

            Log("SQL start time is " + DateTime.Now.TimeOfDay);
        }

        // #EndMatch
        private void btnNextMatch_Click(object sender, EventArgs e)
        {
            List<string> ScoutList = new List<string>();
            if (cbxEndMatch.Checked)
            {
                this.lblMatch.Text = (currentmatch + 1).ToString();
                for (int i = 0; i <= 5; i++)
                {
                    int prevmatchcheck = 0;
                    using (var db = new SeasonContext())
                    {
                        var teamNumber = Robots[i].TeamName;
                        var result = db.Teamset.FirstOrDefault(b => b.team_key == teamNumber);

                        var activityresult = db.ActivitySet.FirstOrDefault(a => a.Team == teamNumber && a.Match == currentmatch + 1 && a.RecordType == "EndMatch");
                        if (activityresult != null)
                        {
                            prevmatchcheck = 1;
                        }
                        else
                        {
                            prevmatchcheck = 0;
                        }
                    }

                    if (Robots[i]._ScouterName != RobotState.SCOUTER_NAME.Select_Name && Robots[i].NoSho == false)
                    {
                        activity_record.Team = Robots[i].TeamName;
                        activity_record.Match = Robots[i].Current_Match;
                        activity_record.Time = DateTime.Now;
                        activity_record.Mode = Robots[i].Current_Mode.ToString();
                        Robots[i].Current_Mode = RobotState.ROBOT_MODE.Auto;
                        activity_record.ScouterName = Robots[i].getScouterName(RobotState.SCOUTER_NAME.Select_Name).ToString();
                        activity_record.RecordType = "EndMatch";
                        activity_record.match_event = "-";
                        activity_record.Leave = Robots[i].Leave;
                        if (Robots[i].Acq_Loc_Temp != "Select" && Robots[i].Acq_Loc_Temp != "Pre")
                        {
                            activity_record.AcqLoc = Robots[i].Acq_Loc_Temp;
                        }
                        else
                        {
                            activity_record.AcqLoc = "-";
                        }
                        activity_record.AcqCenter = 0;
                        activity_record.AcqDis = 0;
                        activity_record.AcqDrp = 0;
                        activity_record.DelOrig = "-";
                        activity_record.DelDest = "-";
                        activity_record.DelMiss = 0;

                        if (Robots[i] == Robots[0])
                        {
                            activity_record.DriveSta = "red0";
                        }
                        else if (Robots[i] == Robots[1])
                        {
                            activity_record.DriveSta = "red1";
                        }
                        else if (Robots[i] == Robots[2])
                        {
                            activity_record.DriveSta = "red2";
                        }
                        else if (Robots[i] == Robots[3])
                        {
                            activity_record.DriveSta = "blue0";
                        }
                        else if (Robots[i] == Robots[4])
                        {
                            activity_record.DriveSta = "blue1";
                        }
                        else if (Robots[i] == Robots[5])
                        {
                            activity_record.DriveSta = "blue2";
                        }

                        if (Robots[i].App_Strat == RobotState.APP_STRAT.Select)
                        {
                            activity_record.Strategy = "Z";
                            Robots[i].ScouterError = Robots[i].ScouterError + 10;
                        }
                        else
                        {
                            activity_record.Strategy = Robots[i].App_Strat.ToString();
                        }

                        if (Robots[i].Robot_Set == RobotState.ROBOT_SET.Select)
                        {
                            activity_record.RobotSta = "Z";
                        }
                        else
                        {
                            activity_record.RobotSta = Robots[i].Robot_Set.ToString();
                        }

                        if (Robots[i].HP_Amp == RobotState.HP_AMP.Select)
                        {
                            activity_record.HPAmp = "Z";
                        }
                        else
                        {
                            activity_record.HPAmp = Robots[i].HP_Amp.ToString();
                        }

                        if (Robots[i].Stage_Stat == RobotState.STAGE_STAT.Select)
                        {
                            activity_record.StageStat = "Z";
                            Robots[i].ScouterError = Robots[i].ScouterError + 10;
                        }
                        else if (Robots[i].Stage_Stat == RobotState.STAGE_STAT.Onstage)
                        {
                            activity_record.StageStat = "On";
                        }
                        else if (Robots[i].Stage_Stat == RobotState.STAGE_STAT.Elsewhere)
                        {
                            activity_record.StageStat = "Else";
                        }
                        else if (Robots[i].Stage_Stat == RobotState.STAGE_STAT.Park)
                        {
                            activity_record.StageStat = "Park";
                        }

                        if (Robots[i].Stage_Loc == RobotState.STAGE_LOC.Select)
                        {
                            if (Robots[i].Stage_Stat != RobotState.STAGE_STAT.Onstage)
                            {
                                activity_record.StageLoc = "A";
                            }
                            else
                            {
                                activity_record.StageLoc = "Z";
                                Robots[i].ScouterError = Robots[i].ScouterError + 10;
                            }
                        }
                        else
                        {
                            activity_record.StageLoc = Robots[i].Stage_Loc.ToString();
                        }

                        if (Robots[i].Stage_Stat == RobotState.STAGE_STAT.Onstage)
                        {
                            activity_record.StageAtt = 1;
                        }
                        else if (Robots[i].Stage_Stat == RobotState.STAGE_STAT.Park)
                        {
                            if (Robots[i].Stage_Att == RobotState.STAGE_ATT.Select)
                            {
                                activity_record.StageAtt = 10;
                                Robots[i].ScouterError = Robots[i].ScouterError + 10;
                            }
                            else if (Robots[i].Stage_Att == RobotState.STAGE_ATT.Y)
                            {
                                activity_record.StageAtt = -1;
                            }
                            else if (Robots[i].Stage_Att == RobotState.STAGE_ATT.N)
                            {
                                activity_record.StageAtt = 0;
                            }
                        }
                        else if (Robots[i].Stage_Stat == RobotState.STAGE_STAT.Elsewhere)
                        {
                            if (Robots[i].Stage_Att == RobotState.STAGE_ATT.Select)
                            {
                                activity_record.StageAtt = 10;
                                Robots[i].ScouterError = Robots[i].ScouterError + 10;
                            }
                            else if (Robots[i].Stage_Att == RobotState.STAGE_ATT.Y)
                            {
                                activity_record.StageAtt = -1;
                            }
                            else if (Robots[i].Stage_Att == RobotState.STAGE_ATT.N)
                            {
                                activity_record.StageAtt = 0;
                            }
                        }
                        else if (Robots[i].Stage_Stat == RobotState.STAGE_STAT.Select)
                        {
                            activity_record.StageAtt = 9;
                        }

                        // Harmony
                        if (Robots[i].Stage_Stat != RobotState.STAGE_STAT.Onstage)
                        {
                            activity_record.Harmony = 9;
                        }
                        else if (Robots[i].Harm == 10)
                        {
                            activity_record.Harmony = Robots[i].Harm;
                            Robots[i].ScouterError = Robots[i].ScouterError + 10;
                        }
                        else
                        {
                            activity_record.Harmony = Robots[i].Harm;
                        }

                        // Spot lit
                        if (Robots[i].Stage_Stat != RobotState.STAGE_STAT.Onstage)
                        {
                            activity_record.Spotlit = 9;
                        }
                        else if (Robots[i].Lit == RobotState.LIT.Select)
                        {
                            activity_record.Spotlit = 10;
                            Robots[i].ScouterError = Robots[i].ScouterError + 10;
                        }
                        else if (Robots[i].Lit == RobotState.LIT.Y)
                        {
                            activity_record.Spotlit = 1;
                        }
                        else if (Robots[i].Lit == RobotState.LIT.N)
                        {
                            activity_record.Spotlit = 0;
                        }

                        if (Robots[i].Stage_Stat == RobotState.STAGE_STAT.Onstage ||
                            ((Robots[i].Stage_Stat == RobotState.STAGE_STAT.Park || Robots[i].Stage_Stat == RobotState.STAGE_STAT.Elsewhere) && 
                            Robots[i].Stage_Att == RobotState.STAGE_ATT.Y))
                        {
                            Robots[i].ClimbTDouble = Robots[i].ClimbT_StopWatch.Elapsed.TotalSeconds;
                            activity_record.ClimbT = Robots[i].ClimbTDouble;
                        }
                        else
                        {
                            activity_record.ClimbT = 0;
                        }
                        Robots[i].AllyTDouble = Robots[i].AllyT_StopWatch.Elapsed.TotalSeconds;
                        Robots[i].OpptTDouble = Robots[i].OpptT_StopWatch.Elapsed.TotalSeconds;
                        Robots[i].NeutTDouble = Robots[i].NeutT_StopWatch.Elapsed.TotalSeconds;
                        activity_record.OZTime = Robots[i].OpptTDouble;
                        activity_record.AZTime = Robots[i].AllyTDouble;
                        activity_record.NZTime = Robots[i].NeutTDouble;
                        activity_record.Mics = Robots[i].Mic;
                        if (Robots[i].HP_Amp == RobotState.HP_AMP.N)
                        {
                            activity_record.Mics = 9;
                        }
                        else if (Robots[i].Mic == 10)
                        {
                            Robots[i].ScouterError = Robots[i].ScouterError + 10;
                        }

                        activity_record.Defense = Robots[i].Def_Rat;
                        if (Robots[i].Def_Rat == 10)
                        {
                            Robots[i].ScouterError = Robots[i].ScouterError + 10;
                        }
                        activity_record.Avoidance = Robots[i].Avo_Rat;
                        if (Robots[i].Avo_Rat == 10)
                        {
                            Robots[i].ScouterError = Robots[i].ScouterError + 10;
                        }

                        activity_record.ScouterError = Robots[i].ScouterError;

                        //Save changes
                        seasonframework.ActivitySet.Add(activity_record);
                        seasonframework.SaveChanges();
                    }
                    else if (Robots[i].NoSho == true)
                    {
                        activity_record.Team = Robots[i].TeamName;
                        activity_record.Match = Robots[i].Current_Match;
                        activity_record.Time = DateTime.Now;
                        activity_record.Mode = Robots[i].Current_Mode.ToString();
                        Robots[i].Current_Mode = RobotState.ROBOT_MODE.Auto;
                        activity_record.ScouterName = Robots[i].getScouterName(RobotState.SCOUTER_NAME.Select_Name).ToString();
                        activity_record.RecordType = "EndMatch";
                        activity_record.match_event = "-";
                        activity_record.Leave = 0;
                        activity_record.AcqLoc = "-";
                        activity_record.AcqCenter = 0;
                        activity_record.AcqDis = 0;
                        activity_record.AcqDrp = 0;
                        activity_record.DelMiss = 0;
                        activity_record.DelOrig = "-";
                        activity_record.DelDest = "-";

                        if (Robots[i] == Robots[0])
                        {
                            activity_record.DriveSta = "red0";
                        }
                        else if (Robots[i] == Robots[1])
                        {
                            activity_record.DriveSta = "red1";
                        }
                        else if (Robots[i] == Robots[2])
                        {
                            activity_record.DriveSta = "red2";
                        }
                        else if (Robots[i] == Robots[3])
                        {
                            activity_record.DriveSta = "blue0";
                        }
                        else if (Robots[i] == Robots[4])
                        {
                            activity_record.DriveSta = "blue1";
                        }
                        else if (Robots[i] == Robots[5])
                        {
                            activity_record.DriveSta = "blue2";
                        }

                        activity_record.RobotSta = "-";

                        if (Robots[i].HP_Amp == RobotState.HP_AMP.Select)
                        {
                            activity_record.HPAmp = "Z";
                        }
                        else
                        {
                            activity_record.HPAmp = Robots[i].HP_Amp.ToString();
                        }

                        activity_record.StageStat = "-";
                        activity_record.StageAtt = 9;
                        activity_record.StageLoc = "-";
                        activity_record.Harmony = 9;
                        activity_record.Spotlit = 9;
                        activity_record.ClimbT = 0;
                        activity_record.OZTime = 0;
                        activity_record.AZTime = 0;
                        activity_record.NZTime = 0;
                        activity_record.Mics = Robots[i].Mic;

                        if (Robots[i].HP_Amp == RobotState.HP_AMP.N)
                        {
                            activity_record.Mics = 9;
                        }
                        else if (Robots[i].Mic == 10)
                        {
                            Robots[i].ScouterError = Robots[i].ScouterError + 10;
                        }

                        activity_record.Defense = 9;
                        activity_record.Avoidance = 9;
                        activity_record.Strategy = "-";
                        activity_record.ScouterError = Robots[i].ScouterError;

                        seasonframework.ActivitySet.Add(activity_record);
                        seasonframework.SaveChanges();
                    }
                    cbxEndMatch.Checked = false;
                }

                //reset values
                for (int i = 0; i <= 5; i++)
                {
                    Robots[i].match_event = RobotState.MATCHEVENT_NAME.Match_Event;
                    Robots[i].Current_Mode = RobotState.ROBOT_MODE.Auto;
                    Robots[i].AUTO = true;
                    Robots[i].NoSho = false;
                    Robots[i].ScouterError = 0;
                    Robots[i].Leave = 0;
                    Robots[i].Acq_Loc = "Select";
                    Robots[i].Acq_Center = 0;
                    Robots[i].Acq_Loc_Temp = "Pre";
                    Robots[i].Flag = 0;
                    Robots[i].Del_Dest = RobotState.DEL_DEST.Select;
                    Robots[i].Drive_Sta = "Select";
                    Robots[i].Robot_Set = RobotState.ROBOT_SET.Select;
                    Robots[i].HP_Amp = RobotState.HP_AMP.Select;
                    Robots[i].Stage_Stat = RobotState.STAGE_STAT.Select;
                    Robots[i].Stage_Att = RobotState.STAGE_ATT.Select;
                    Robots[i].Stage_Loc = RobotState.STAGE_LOC.Select;
                    Robots[i].Harm = 10;
                    Robots[i].Lit = RobotState.LIT.Select;
                    Robots[i].ClimbT_StopWatch.Reset();
                    Robots[i].AllyT_StopWatch.Reset();
                    Robots[i].OpptT_StopWatch.Reset();
                    Robots[i].NeutT_StopWatch.Reset();
                    Robots[i].ClimbTDouble = 0;
                    Robots[i].AllyTDouble = 0;
                    Robots[i].OpptTDouble = 0;
                    Robots[i].NeutTDouble = 0;
                    Robots[i].Def_Rat = 10;
                    Robots[i].Avo_Rat = 10;
                    Robots[i].App_Strat = RobotState.APP_STRAT.Select;
                    Robots[i].Mic = 10;
                    Robots[i].Current_Loc = RobotState.CURRENT_LOC.Select;
                }
                currentmatch++;

                if (currentmatch == InMemoryMatchList.Count) 
                { 
                    MessageBox.Show("You are at the last match.");
                    currentmatch--;

                }
                else if (currentmatch != InMemoryMatchList.Count)
                {
                    //#Session0
                    this.lbl0TeamName.Text = Robots[0].TeamName = InMemoryMatchList[currentmatch].redteam1;
                    this.lbl1TeamName.Text = Robots[1].TeamName = InMemoryMatchList[currentmatch].redteam2;
                    this.lbl2TeamName.Text = Robots[2].TeamName = InMemoryMatchList[currentmatch].redteam3;
                    this.lbl3TeamName.Text = Robots[3].TeamName = InMemoryMatchList[currentmatch].blueteam1;
                    this.lbl4TeamName.Text = Robots[4].TeamName = InMemoryMatchList[currentmatch].blueteam2;
                    this.lbl5TeamName.Text = Robots[5].TeamName = InMemoryMatchList[currentmatch].blueteam3;
                    this.lblMatch.Text = (currentmatch + 1).ToString();

                    Robots[0].Desired_Mode = Robots[1].Desired_Mode = Robots[2].Desired_Mode = Robots[3].Desired_Mode = Robots[4].Desired_Mode = Robots[5].Desired_Mode = RobotState.ROBOT_MODE.Auto;
                    Robots[0].Current_Mode = Robots[1].Current_Mode = Robots[2].Current_Mode = Robots[3].Current_Mode = Robots[4].Current_Mode = Robots[5].Current_Mode = RobotState.ROBOT_MODE.Auto;
                }

                for (int i = 0; i < Robots.Length; i++)
                {
                    ScoutList.Add(Robots[i].getScouterName(RobotState.SCOUTER_NAME.Select_Name).ToString());
                }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("All unsaved data will be lost.  Continue?", "Next Match", MessageBoxButtons.YesNo);
                currentmatch++;
                if (dialogResult == DialogResult.Yes && currentmatch != InMemoryMatchList.Count)
                {
                    //#Session0
                    this.lbl0TeamName.Text = Robots[0].TeamName = InMemoryMatchList[currentmatch].redteam1;
                    this.lbl1TeamName.Text = Robots[1].TeamName = InMemoryMatchList[currentmatch].redteam2;
                    this.lbl2TeamName.Text = Robots[2].TeamName = InMemoryMatchList[currentmatch].redteam3;
                    this.lbl3TeamName.Text = Robots[3].TeamName = InMemoryMatchList[currentmatch].blueteam1;
                    this.lbl4TeamName.Text = Robots[4].TeamName = InMemoryMatchList[currentmatch].blueteam2;
                    this.lbl5TeamName.Text = Robots[5].TeamName = InMemoryMatchList[currentmatch].blueteam3;
                    this.lblMatch.Text = (currentmatch + 1).ToString();

                    Robots[0].Desired_Mode = Robots[1].Desired_Mode = Robots[2].Desired_Mode = Robots[3].Desired_Mode = Robots[4].Desired_Mode = Robots[5].Desired_Mode = RobotState.ROBOT_MODE.Auto;
                    Robots[0].Current_Mode = Robots[1].Current_Mode = Robots[2].Current_Mode = Robots[3].Current_Mode = Robots[4].Current_Mode = Robots[5].Current_Mode = RobotState.ROBOT_MODE.Auto;

                    //reset values
                    for (int i = 0; i <= 5; i++)
                    {
                        Robots[i].match_event = RobotState.MATCHEVENT_NAME.Match_Event;
                        Robots[i].Current_Mode = RobotState.ROBOT_MODE.Auto;
                        Robots[i].AUTO = true;
                        Robots[i].NoSho = false;
                        Robots[i].TransactionCheck = false;
                        Robots[i].ScouterError = 0;
                        Robots[i].Leave = 0;
                        Robots[i].Acq_Loc = "Select";
                        Robots[i].Acq_Center = 0;
                        Robots[i].Acq_Loc_Temp = "Pre";
                        Robots[i].Flag = 0;
                        Robots[i].Del_Dest = RobotState.DEL_DEST.Select;
                        Robots[i].Drive_Sta = "Select";
                        Robots[i].Robot_Set = RobotState.ROBOT_SET.Select;
                        Robots[i].HP_Amp = RobotState.HP_AMP.Select;
                        Robots[i].Stage_Stat = RobotState.STAGE_STAT.Select;
                        Robots[i].Stage_Att = RobotState.STAGE_ATT.Select;
                        Robots[i].Stage_Loc = RobotState.STAGE_LOC.Select;
                        Robots[i].Harm = 9;
                        Robots[i].Lit = RobotState.LIT.Select;
                        Robots[i].ClimbT_StopWatch.Reset();
                        Robots[i].AllyT_StopWatch.Reset();
                        Robots[i].OpptT_StopWatch.Reset();
                        Robots[i].NeutT_StopWatch.Reset();
                        Robots[i].ClimbTDouble = 0;
                        Robots[i].AllyTDouble = 0;
                        Robots[i].NeutTDouble = 0;
                        Robots[i].OpptTDouble = 0;
                        Robots[i].Def_Rat = 9;
                        Robots[i].Avo_Rat = 9;
                        Robots[i].App_Strat = RobotState.APP_STRAT.Select;
                        Robots[i].Mic = 9;
                        Robots[i].Current_Loc = RobotState.CURRENT_LOC.Select;
                    }
                }
                else
                {
                    MessageBox.Show("You are at the last match.");
                    currentmatch--;
                }
            }
        }

        private void btnPreviousMatch_Click(object sender, EventArgs e)
        {
            if (currentmatch == 0)
                MessageBox.Show("You are at the first match.");
            else
            {
                currentmatch--;
                this.lbl0TeamName.Text = Robots[0].TeamName = InMemoryMatchList[currentmatch].redteam1;
                this.lbl1TeamName.Text = Robots[1].TeamName = InMemoryMatchList[currentmatch].redteam2;
                this.lbl2TeamName.Text = Robots[2].TeamName = InMemoryMatchList[currentmatch].redteam3;
                this.lbl3TeamName.Text = Robots[3].TeamName = InMemoryMatchList[currentmatch].blueteam1;
                this.lbl4TeamName.Text = Robots[4].TeamName = InMemoryMatchList[currentmatch].blueteam2;
                this.lbl5TeamName.Text = Robots[5].TeamName = InMemoryMatchList[currentmatch].blueteam3;
                this.lblMatch.Text = (currentmatch + 1).ToString();
            }
            for (int i = 0; i <= 5; i++)
            {
                Robots[i].match_event = RobotState.MATCHEVENT_NAME.Match_Event;
                Robots[i].Current_Mode = RobotState.ROBOT_MODE.Auto;
                Robots[i].AUTO = true;
                Robots[i].NoSho = false;
                Robots[i].TransactionCheck = false;
                Robots[i].ScouterError = 0;
                Robots[i].Leave = 0;
                Robots[i].Acq_Loc = "Select";
                Robots[i].Acq_Center = 0;
                Robots[i].Acq_Loc_Temp = "Pre";
                Robots[i].Flag = 0;
                Robots[i].Del_Dest = RobotState.DEL_DEST.Select;
                Robots[i].Drive_Sta = "Select";
                Robots[i].Robot_Set = RobotState.ROBOT_SET.Select;
                Robots[i].HP_Amp = RobotState.HP_AMP.Select;
                Robots[i].Stage_Stat = RobotState.STAGE_STAT.Select;
                Robots[i].Stage_Att = RobotState.STAGE_ATT.Select;
                Robots[i].Stage_Loc = RobotState.STAGE_LOC.Select;
                Robots[i].Harm = 9;
                Robots[i].Lit = RobotState.LIT.Select;
                Robots[i].ClimbT_StopWatch.Reset();
                Robots[i].AllyT_StopWatch.Reset();
                Robots[i].OpptT_StopWatch.Reset();
                Robots[i].NeutT_StopWatch.Reset();
                Robots[i].ClimbTDouble = 0;
                Robots[i].AllyTDouble = 0;
                Robots[i].NeutTDouble = 0;
                Robots[i].OpptTDouble = 0;
                Robots[i].Def_Rat = 9;
                Robots[i].Avo_Rat = 9;
                Robots[i].App_Strat = RobotState.APP_STRAT.Select;
                Robots[i].Mic = 9;
                Robots[i].Current_Loc = RobotState.CURRENT_LOC.Select;
            }
        }

        private void btnpopulateForEvent_Click(object sender, EventArgs e)
        {
            if (this.comboBoxSelectRegional.Text == "Please press the Load Events Button...")
            {
                MessageBox.Show("You must load an event first.", "Not Ready to Get Matches");
            }
            else
            {
                seasonframework.Database.ExecuteSqlCommand("DELETE FROM [Matches]");
                UnSortedMatchList.Clear();

                List<Match> JSONmatches;

                System.Net.WebRequest req;

                //First get the teams from the Blue Alliance API
                Log("Opening Web Connection...");

                WebClient client = new WebClient(); //one WebClient to rule them all

                Log("Event -> " + comboBoxSelectRegional.SelectedItem);

                eventcode = comboBoxSelectRegional.SelectedItem.ToString();

                //eventcode = "njfla";  //#Training

                eventcode = eventcode.TrimStart('[');
                regional = eventcode;
                int index = eventcode.IndexOf(",");
                if (index > 0) eventcode = eventcode.Substring(0, index);

                Log("Event Code -> " + eventcode);

                //#AuthKey
                string uri = "http://www.thebluealliance.com/api/v3/event/2024" + eventcode + "/teams?X-TBA-Auth-Key=" + Properties.Settings.Default.API_Key;

                req = WebRequest.Create(uri);

                HttpWebResponse response = (HttpWebResponse)req.GetResponse();
                Stream dataStream = response.GetResponseStream();
                //Open the stream using a StreamReader for easy access.
                StreamReader reader = new StreamReader(dataStream);
                //Read the content. 
                string responseFromServer = reader.ReadToEnd();
                //Display the content.
                Log("Response from Server -> " + responseFromServer);
                //Cleanup the streams and the response.

                List<TeamSummary> JSONteams = (List<TeamSummary>)Newtonsoft.Json.JsonConvert.DeserializeObject(responseFromServer, typeof(List<TeamSummary>));

                Log("Received " + JSONteams.Count + " teams for " + eventcode + ".");

                reader.Close();
                dataStream.Close();
                response.Close();

                //SeasonContext seasonframework = new SeasonContext();

                var teamquery = from b in seasonframework.Teamset
                                orderby b.team_key
                                select b;
                teamlist.Clear();

                foreach (var item in JSONteams)
                {
                    Log("Team -> " + item.team_number);
                    teamlist.Add(item.team_number);
                }

                using (var db = new SeasonContext())
                {
                    var teamNumber = Robots[0].TeamName;
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
                                team_record.event_key = eventcode;
                                team_record.nickname = objt[i].nickname;

                                //Save changes
                                seasonframework.Teamset.Add(team_record);
                                seasonframework.SaveChanges();
                            }
                        }
                    }
                }

                //Need to update UI team field now that we have the teams!

                //Get the matches from the Blue Alliance API

                //#AuthKey
                uri = "http://www.thebluealliance.com/api/v3/event/2024" + eventcode + "/matches?X-TBA-Auth-Key=" + Properties.Settings.Default.API_Key;

                try
                {
                    req = WebRequest.Create(uri);
                    response = (HttpWebResponse)req.GetResponse();

                    using (var resp = req.GetResponse())
                    {
                        using (var responseStream = response.GetResponseStream())
                        {
                            dataStream = response.GetResponseStream();
                            //Open the stream using a StreamReader for easy access.
                            reader = new StreamReader(dataStream);

                            //Read the content. 
                            responseFromServer = reader.ReadToEnd();

                            //Display the content.
                            Log("Response from Server -> " + responseFromServer);
                            //Cleanup the streams and the response.

                            //Get root objects

                            JSONmatches = (List<Match>)Newtonsoft.Json.JsonConvert.DeserializeObject(responseFromServer, typeof(List<Match>));

                            if (JSONmatches.Count == 0)
                            {
                                MessageBox.Show("Sorry, but there is no match data currently available for the event you selected.");
                            }
                            else
                            {
                                Log("Received " + JSONmatches.Count + " matches for " + eventcode + ".");

                                //Fill the Matches Table

                                JSONmatches = (List<Match>)Newtonsoft.Json.JsonConvert.DeserializeObject(responseFromServer, typeof(List<Match>));

                                dynamic obj = Newtonsoft.Json.JsonConvert.DeserializeObject(responseFromServer);

                                Log("Saving " + JSONmatches.Count + " matches to database.");

                                int MatchCount = 0;
                                MatchNumbers.Clear();

                                for (int i = 0; i < JSONmatches.Count; i++)
                                {
                                  

                                    // #Playoffs to download playoff matches and alliances
                                    //if (obj[i].comp_level == "qf")
                                    dynamic PostTimeDynamic = obj[i].post_result_time;
                                    string PostTime = PostTimeDynamic;
                                    if (obj[i].comp_level == "qm")
                                    {   
                                        
                                        MatchCount++;
                                        MatchNumbers.Add(MatchCount);

                                        Match match_record = new Match();

                                        dynamic MatchNumberDynamic = obj[i].match_number;
                                        int MatchNumber = MatchNumberDynamic;

                                        dynamic alliances = obj[i].alliances;
                                        dynamic bluealliance = alliances.blue;
                                        dynamic redalliance = alliances.red;
                                        dynamic scorebreakdown = obj[i].score_breakdown;

                                        dynamic blueteamsobj = bluealliance.team_keys;
                                        dynamic redteamsobj = redalliance.team_keys;

                                        string blue1 = blueteamsobj[0];
                                        string blue2 = blueteamsobj[1];
                                        string blue3 = blueteamsobj[2];
                                        string red1 = redteamsobj[0];
                                        string red2 = redteamsobj[1];
                                        string red3 = redteamsobj[2];

                                        RobotState.blue0 = blueteamsobj[0];
                                        RobotState.blue1 = blueteamsobj[1];
                                        RobotState.blue2 = blueteamsobj[2];
                                        RobotState.red0 = redteamsobj[0];
                                        RobotState.red1 = redteamsobj[1];
                                        RobotState.red2 = redteamsobj[2];

                                        //Record List of matches
                                        match_record.match_number = (int)obj[i].match_number;

                                        // #Playoffs
                                        // Next line is if qf
                                        //match_record.set_number = obj[i].set_number;

                                        //Next line is if qm
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

                                        UnSortedMatchList.Add(match_record);
                                        seasonframework.Matchset.Add(match_record);
                                        seasonframework.SaveChanges();

                                    }
                                    
                                }

                                DialogResult dialogResult = MessageBox.Show("Do you want to start at match 1", "Please Confirm", MessageBoxButtons.YesNo);
                                if (dialogResult == DialogResult.Yes)
                                {
                                    currentmatch = 0;
                                }

                                //Populate screen with first match

                                InMemoryMatchList = UnSortedMatchList.OrderBy(o => o.match_number).ToList();

                                // #Session0
                                this.lbl0TeamName.Text = Robots[0].TeamName = InMemoryMatchList[currentmatch].redteam1;
                                this.lbl1TeamName.Text = Robots[1].TeamName = InMemoryMatchList[currentmatch].redteam2;
                                this.lbl2TeamName.Text = Robots[2].TeamName = InMemoryMatchList[currentmatch].redteam3;
                                this.lbl3TeamName.Text = Robots[3].TeamName = InMemoryMatchList[currentmatch].blueteam1;
                                this.lbl4TeamName.Text = Robots[4].TeamName = InMemoryMatchList[currentmatch].blueteam2;
                                this.lbl5TeamName.Text = Robots[5].TeamName = InMemoryMatchList[currentmatch].blueteam3;
                                Robots[0].color = "Blue";
                                Robots[1].color = "Blue";
                                Robots[2].color = "Blue";
                                Robots[3].color = "Red";
                                Robots[4].color = "Red";
                                Robots[5].color = "Red";
                                this.lblMatch.Text = (currentmatch + 1).ToString();
                                this.lblkey.Text = InMemoryMatchList[currentmatch].key;

                            }

                            reader.Close();
                            dataStream.Close();
                            response.Close();
                        }
                    }
                }
                catch (WebException ex)
                {
                    if (ex.Status == WebExceptionStatus.ProtocolError &&
                        ex.Response != null)
                    {
                        var resp = (HttpWebResponse)ex.Response;
                        if ((resp.StatusCode == HttpStatusCode.NotFound))
                        {
                            MessageBox.Show("Sorry, but there is no match data currently available for the event you selected.");
                        }
                        else
                        {
                            MessageBox.Show("Sorry, something went very wrong!");
                        }
                    }
                }
            }
        }
        private void btnUpdateDB_Click(object sender, EventArgs e)
        {
            if (DBExists)
            {
                UpdateDatabase frm = new UpdateDatabase(teamlist, MatchNumbers);
                frm.Show();
            }
            else
            {
                MessageBox.Show("Please load The Blue Aliance to create the database or create the database in a different way");
            }
        }

        private void SwapScouters_Click(object sender, EventArgs e)
        {
            ScouterAssignment frm = new ScouterAssignment();
            frm.Show();
        }

        private void lbl1ModeValue_Click(object sender, EventArgs e)
        {

        }
    }
}