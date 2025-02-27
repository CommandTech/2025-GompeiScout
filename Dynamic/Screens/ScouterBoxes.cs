using ScoutingCodeRedo.Static;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ScoutingCodeRedo.Dynamic
{
    internal partial class ScouterBoxes : Form
    {
        readonly Dictionary<int, string> DefenseEquality = new()
        {
            { 0, "None" },
            { 1, "1 Station" },
            { 2, "2 Stations" },
            { 3, "Chasing" },
            { 4, "Counter" },
            { 9, "Scouter Error" }
        };
        readonly Dictionary<int, string> AvoidanceEquality = new()
        {
            { 0, "None" },
            { 1, "1 Station" },
            { 2, "2 Stations" },
            { 3, "Chasing" },
            { 4, "Counter" },
            { 9, "Scouter Error" }
        };
        public ScouterBoxes()
        {
            InitializeComponent();

            updateScreen.Enabled = true;
        }

        private void UpdateScreen(object sender, EventArgs e)
        {
            int redScore = 0;
            int blueScore = 0;
            for (int i = 0; i < 6; i++)
            {
                int o = BackgroundCode.Robots[i].ScouterBox;
                switch (BackgroundCode.Robots[i].Current_Mode)
                {
                    case RobotState.ROBOT_MODE.Auto:
                        InAutoMode(i, o);
                        break;
                    case RobotState.ROBOT_MODE.Teleop:
                        InTeleopMode(i, o);
                        break;
                    case RobotState.ROBOT_MODE.Defense:
                        InDefenseMode(i, o);
                        break;
                    case RobotState.ROBOT_MODE.Surfacing:
                        InSurfacingMode(i, o);
                        break;
                }

                if (i < 3)
                {
                    redScore += BackgroundCode.Robots[i].PointsScored;
                }
                else
                {
                    blueScore += BackgroundCode.Robots[i].PointsScored;
                }
            }

            ((Label)this.Controls.Find($"lblRedScore", true)[0]).Text = redScore.ToString();
            ((Label)this.Controls.Find($"lblBlueScore", true)[0]).Text = blueScore.ToString();
        }

        private void InAutoMode(int Box_Number, int ScouterBox)
        {
            //Leave
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position0", true)[0]).Text = "Leave:";
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position0", true)[0]).Visible = true;

            if (BackgroundCode.Robots[Box_Number].Leave == RobotState.LEAVE.Y)
            {
                ((Label)this.Controls.Find($"lbl{ScouterBox}Position0Value", true)[0]).ForeColor = System.Drawing.Color.Green;
                ((Label)this.Controls.Find($"lbl{ScouterBox}Position0Value", true)[0]).BackColor = System.Drawing.Color.Green;
            }
            else if (BackgroundCode.Robots[Box_Number].Leave == RobotState.LEAVE.N)
            {
                ((Label)this.Controls.Find($"lbl{ScouterBox}Position0Value", true)[0]).ForeColor = System.Drawing.Color.Red;
                ((Label)this.Controls.Find($"lbl{ScouterBox}Position0Value", true)[0]).BackColor = System.Drawing.Color.Red;
            }
            else
            {
                ((Label)this.Controls.Find($"lbl{ScouterBox}Position0Value", true)[0]).ForeColor = System.Drawing.Color.Yellow;
                ((Label)this.Controls.Find($"lbl{ScouterBox}Position0Value", true)[0]).BackColor = System.Drawing.Color.Yellow;
            }
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position0Value", true)[0]).Visible = true;

            //Near Far
            if (BackgroundCode.Robots[Box_Number].DelNearFar)
            {
                ((Label)this.Controls.Find($"lbl{ScouterBox}Position1", true)[0]).Text = "Far Side";
            }
            else
            {
                ((Label)this.Controls.Find($"lbl{ScouterBox}Position1", true)[0]).Text = "Near Side";
            }
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position1", true)[0]).Visible = true;

            //Coral
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position2", true)[0]).Text = "Coral:";
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position2", true)[0]).Visible = true;
            if (BackgroundCode.Robots[Box_Number].hasCoral == 1)
            {
                ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Value", true)[0]).ForeColor = System.Drawing.Color.Green;
                ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Value", true)[0]).BackColor = System.Drawing.Color.Green;
            }
            else
            {
                ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Value", true)[0]).ForeColor = System.Drawing.Color.Red;
                ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Value", true)[0]).BackColor = System.Drawing.Color.Red;
            }
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Value", true)[0]).Visible = true;

            ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Source", true)[0]).Text = BackgroundCode.Robots[Box_Number].lastCoralAcqLoc;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Source", true)[0]).Visible = true;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Source", true)[0]).ForeColor = System.Drawing.Color.Yellow;

            ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Des", true)[0]).Text = BackgroundCode.Robots[Box_Number].lastCoralLoc;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Des", true)[0]).Visible = true;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Des", true)[0]).ForeColor = System.Drawing.Color.Yellow;

            //Algae
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3", true)[0]).Text = "Algae:";
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3", true)[0]).Visible = true;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3", true)[0]).ForeColor = BackgroundCode.Robots[Box_Number].DisFlag ? System.Drawing.Color.Yellow : System.Drawing.Color.White;
            if (BackgroundCode.Robots[Box_Number].hasAlgae == 1)
            {
                ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Value", true)[0]).ForeColor = System.Drawing.Color.Green;
                ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Value", true)[0]).BackColor = System.Drawing.Color.Green;
            }
            else
            {
                ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Value", true)[0]).ForeColor = System.Drawing.Color.Red;
                ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Value", true)[0]).BackColor = System.Drawing.Color.Red;
            }
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Value", true)[0]).Visible = true;

            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Source", true)[0]).Text = BackgroundCode.Robots[Box_Number].lastAlgaeAcqLoc;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Source", true)[0]).Visible = true;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Source", true)[0]).ForeColor = System.Drawing.Color.Yellow;

            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Des", true)[0]).Text = BackgroundCode.Robots[Box_Number].lastAlgaeLoc;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Des", true)[0]).Visible = true;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Des", true)[0]).ForeColor = System.Drawing.Color.Yellow;

            //Attempt
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position4", true)[0]).Text = "End State:";
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position4", true)[0]).Visible = false;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position4Value", true)[0]).Text = BackgroundCode.Robots[Box_Number].End_State.ToString();
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position4Value", true)[0]).Visible = false;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position4Value", true)[0]).ForeColor = System.Drawing.Color.Yellow;

            //Starting Location
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position5", true)[0]).Text = "Start:";
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position5", true)[0]).Visible = true;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position5Value", true)[0]).Text = BackgroundCode.Robots[Box_Number].Starting_Location.ToString();
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position5Value", true)[0]).Visible = true;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position5Value", true)[0]).ForeColor = System.Drawing.Color.Yellow;

            //Defense Effectiveness
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position7", true)[0]).Text = "Eff:";
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position7", true)[0]).Visible = false;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position7Value", true)[0]).Text = BackgroundCode.Robots[Box_Number].Def_Eff.ToString();
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position7Value", true)[0]).Visible = false;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position7Value", true)[0]).ForeColor = System.Drawing.Color.Yellow;

            //Avoidance Rating
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position8", true)[0]).Text = "Avoid:";
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position8", true)[0]).Visible = false;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position8Value", true)[0]).Text = BackgroundCode.Robots[Box_Number].Avo_Rat.ToString();
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position8Value", true)[0]).Visible = false;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position8Value", true)[0]).ForeColor = System.Drawing.Color.Yellow;

            //End State
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position11", true)[0]).Text = "Attempt:";
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position11", true)[0]).Visible = false;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position11Value", true)[0]).Text = BackgroundCode.Robots[Box_Number].Cage_Attempt.ToString();
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position11Value", true)[0]).Visible = false;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position11Value", true)[0]).ForeColor = System.Drawing.Color.Yellow;

            //Robot Strategy
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position12", true)[0]).Text = "Strat:";
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position12", true)[0]).Visible = false;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position12Value", true)[0]).Text = BackgroundCode.Robots[Box_Number].GetStrat().ToString();
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position12Value", true)[0]).Visible = false;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position12Value", true)[0]).ForeColor = System.Drawing.Color.Yellow;
        }
        private void InTeleopMode(int Box_Number, int ScouterBox)
        {
            //Leave
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position0", true)[0]).Text = "Leave:";
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position0", true)[0]).Visible = false;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position0Value", true)[0]).Visible = false;

            //Near Far
            if (BackgroundCode.Robots[Box_Number].DelNearFar)
            {
                ((Label)this.Controls.Find($"lbl{ScouterBox}Position1", true)[0]).Text = "Far Side";
            }
            else
            {
                ((Label)this.Controls.Find($"lbl{ScouterBox}Position1", true)[0]).Text = "Near Side";
            }
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position1", true)[0]).Visible = true;

            //Coral
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position2", true)[0]).Text = "Coral:";
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position2", true)[0]).Visible = true;
            if (BackgroundCode.Robots[Box_Number].hasCoral == 1)
            {
                ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Value", true)[0]).ForeColor = System.Drawing.Color.Green;
                ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Value", true)[0]).BackColor = System.Drawing.Color.Green;
            }
            else
            {
                ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Value", true)[0]).ForeColor = System.Drawing.Color.Red;
                ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Value", true)[0]).BackColor = System.Drawing.Color.Red;
            }
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Value", true)[0]).Visible = true;

            ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Source", true)[0]).Text = BackgroundCode.Robots[Box_Number].lastCoralAcqLoc;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Source", true)[0]).Visible = true;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Source", true)[0]).ForeColor = System.Drawing.Color.Yellow;

            ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Des", true)[0]).Text = BackgroundCode.Robots[Box_Number].lastCoralLoc;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Des", true)[0]).Visible = true;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Des", true)[0]).ForeColor = System.Drawing.Color.Yellow;

            //Algae
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3", true)[0]).Text = "Algae:";
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3", true)[0]).Visible = true;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3", true)[0]).ForeColor = BackgroundCode.Robots[Box_Number].DisFlag ? System.Drawing.Color.Yellow : System.Drawing.Color.White;
            if (BackgroundCode.Robots[Box_Number].hasAlgae == 1)
            {
                ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Value", true)[0]).ForeColor = System.Drawing.Color.Green;
                ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Value", true)[0]).BackColor = System.Drawing.Color.Green;
            }
            else
            {
                ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Value", true)[0]).ForeColor = System.Drawing.Color.Red;
                ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Value", true)[0]).BackColor = System.Drawing.Color.Red;
            }
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Value", true)[0]).Visible = true;

            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Source", true)[0]).Text = BackgroundCode.Robots[Box_Number].lastAlgaeAcqLoc;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Source", true)[0]).Visible = true;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Source", true)[0]).ForeColor = System.Drawing.Color.Yellow;

            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Des", true)[0]).Text = BackgroundCode.Robots[Box_Number].lastAlgaeLoc;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Des", true)[0]).Visible = true;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Des", true)[0]).ForeColor = System.Drawing.Color.Yellow;

            //Attempt
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position4", true)[0]).Text = "End State:";
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position4", true)[0]).Visible = false;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position4Value", true)[0]).Text = BackgroundCode.Robots[Box_Number].End_State.ToString();
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position4Value", true)[0]).Visible = false;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position4Value", true)[0]).ForeColor = System.Drawing.Color.Yellow;

            //Defense Rating
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position5", true)[0]).Text = "Def:";
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position5", true)[0]).Visible = false;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position5Value", true)[0]).Text = BackgroundCode.Robots[Box_Number].Def_Rat.ToString();
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position5Value", true)[0]).Visible = false;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position5Value", true)[0]).ForeColor = System.Drawing.Color.Yellow;

            //Defense Effectiveness
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position7", true)[0]).Text = "Eff:";
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position7", true)[0]).Visible = false;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position7Value", true)[0]).Text = BackgroundCode.Robots[Box_Number].Def_Eff.ToString();
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position7Value", true)[0]).Visible = false;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position7Value", true)[0]).ForeColor = System.Drawing.Color.Yellow;

            //Avoidance Rating
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position8", true)[0]).Text = "Avoid:";
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position8", true)[0]).Visible = false;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position8Value", true)[0]).Text = BackgroundCode.Robots[Box_Number].Avo_Rat.ToString();
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position8Value", true)[0]).Visible = false;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position8Value", true)[0]).ForeColor = System.Drawing.Color.Yellow;

            //End State
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position11", true)[0]).Text = "Attempt:";
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position11", true)[0]).Visible = false;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position11Value", true)[0]).Text = BackgroundCode.Robots[Box_Number].Cage_Attempt.ToString();
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position11Value", true)[0]).Visible = false;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position11Value", true)[0]).ForeColor = System.Drawing.Color.Yellow;

            //Robot Strategy
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position12", true)[0]).Text = "Strat:";
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position12", true)[0]).Visible = false;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position12Value", true)[0]).Text = BackgroundCode.Robots[Box_Number].GetStrat().ToString();
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position12Value", true)[0]).Visible = false;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position12Value", true)[0]).ForeColor = System.Drawing.Color.Yellow;
        }
        private void InDefenseMode(int Box_Number, int ScouterBox)
        {
            //Defense Timer
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position0", true)[0]).Text = BackgroundCode.Robots[Box_Number].DefTime_StopWatch.Elapsed.ToString(@"m\:ss\.fff");

            ((Label)this.Controls.Find($"lbl{ScouterBox}Position0", true)[0]).Visible = true;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position0Value", true)[0]).Visible = false;

            //Near Far
            if (BackgroundCode.Robots[Box_Number].DelNearFar)
            {
                ((Label)this.Controls.Find($"lbl{ScouterBox}Position1", true)[0]).Text = "Far Side";
            }
            else
            {
                ((Label)this.Controls.Find($"lbl{ScouterBox}Position1", true)[0]).Text = "Near Side";
            }
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position1", true)[0]).Visible = true;

            //Coral
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position2", true)[0]).Text = "Coral:";
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position2", true)[0]).Visible = true;
            if (BackgroundCode.Robots[Box_Number].hasCoral == 1)
            {
                ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Value", true)[0]).ForeColor = System.Drawing.Color.Green;
                ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Value", true)[0]).BackColor = System.Drawing.Color.Green;
            }
            else
            {
                ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Value", true)[0]).ForeColor = System.Drawing.Color.Red;
                ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Value", true)[0]).BackColor = System.Drawing.Color.Red;
            }
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Value", true)[0]).Visible = true;

            ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Source", true)[0]).Text = BackgroundCode.Robots[Box_Number].lastCoralAcqLoc;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Source", true)[0]).Visible = true;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Source", true)[0]).ForeColor = System.Drawing.Color.Yellow;

            ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Des", true)[0]).Text = BackgroundCode.Robots[Box_Number].lastCoralLoc;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Des", true)[0]).Visible = true;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Des", true)[0]).ForeColor = System.Drawing.Color.Yellow;

            //Algae
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3", true)[0]).Text = "Algae:";
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3", true)[0]).Visible = true;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3", true)[0]).ForeColor = BackgroundCode.Robots[Box_Number].DisFlag ? System.Drawing.Color.Yellow : System.Drawing.Color.White;
            if (BackgroundCode.Robots[Box_Number].hasAlgae == 1)
            {
                ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Value", true)[0]).ForeColor = System.Drawing.Color.Green;
                ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Value", true)[0]).BackColor = System.Drawing.Color.Green;
            }
            else
            {
                ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Value", true)[0]).ForeColor = System.Drawing.Color.Red;
                ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Value", true)[0]).BackColor = System.Drawing.Color.Red;
            }
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Value", true)[0]).Visible = true;

            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Source", true)[0]).Text = BackgroundCode.Robots[Box_Number].lastAlgaeAcqLoc;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Source", true)[0]).Visible = true;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Source", true)[0]).ForeColor = System.Drawing.Color.Yellow;

            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Des", true)[0]).Text = BackgroundCode.Robots[Box_Number].lastAlgaeLoc;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Des", true)[0]).Visible = true;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Des", true)[0]).ForeColor = System.Drawing.Color.Yellow;

            //Attempt
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position4", true)[0]).Text = "End State:";
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position4", true)[0]).Visible = false;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position4Value", true)[0]).Text = BackgroundCode.Robots[Box_Number].End_State.ToString();
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position4Value", true)[0]).Visible = false;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position4Value", true)[0]).ForeColor = System.Drawing.Color.Yellow;

            //Defense Rating
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position5", true)[0]).Text = "Def:";
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position5", true)[0]).Visible = false;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position5Value", true)[0]).Text = BackgroundCode.Robots[Box_Number].Def_Rat.ToString();
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position5Value", true)[0]).Visible = false;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position5Value", true)[0]).ForeColor = System.Drawing.Color.Yellow;

            //Defense Effectiveness
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position7", true)[0]).Text = "Eff:";
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position7", true)[0]).Visible = false;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position7Value", true)[0]).Text = BackgroundCode.Robots[Box_Number].Def_Eff.ToString();
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position7Value", true)[0]).Visible = false;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position7Value", true)[0]).ForeColor = System.Drawing.Color.Yellow;

            //Avoidance Rating
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position8", true)[0]).Text = "Avoid:";
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position8", true)[0]).Visible = false;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position8Value", true)[0]).Text = BackgroundCode.Robots[Box_Number].Avo_Rat.ToString();
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position8Value", true)[0]).Visible = false;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position8Value", true)[0]).ForeColor = System.Drawing.Color.Yellow;

            //End State
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position11", true)[0]).Text = "Attempt:";
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position11", true)[0]).Visible = false;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position11Value", true)[0]).Text = BackgroundCode.Robots[Box_Number].Cage_Attempt.ToString();
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position11Value", true)[0]).Visible = false;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position11Value", true)[0]).ForeColor = System.Drawing.Color.Yellow;

            //Robot Strategy
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position12", true)[0]).Text = "Strat:";
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position12", true)[0]).Visible = false;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position12Value", true)[0]).Text = BackgroundCode.Robots[Box_Number].GetStrat().ToString();
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position12Value", true)[0]).Visible = false;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position12Value", true)[0]).ForeColor = System.Drawing.Color.Yellow;
        }
        private void InSurfacingMode(int Box_Number, int ScouterBox)
        {
            //Climb Timer
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position0", true)[0]).Text = BackgroundCode.Robots[Box_Number].ClimbT_StopWatch.Elapsed.ToString(@"m\:ss\.fff");
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position0", true)[0]).Visible = true;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position0Value", true)[0]).Visible = false;

            //Near Far
            if (BackgroundCode.Robots[Box_Number].DelNearFar)
            {
                ((Label)this.Controls.Find($"lbl{ScouterBox}Position1", true)[0]).Text = "Far Side";
            }
            else
            {
                ((Label)this.Controls.Find($"lbl{ScouterBox}Position1", true)[0]).Text = "Near Side";
            }
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position1", true)[0]).Visible = false;

            //Coral
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position2", true)[0]).Text = "Coral:";
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position2", true)[0]).Visible = true;
            if (BackgroundCode.Robots[Box_Number].hasCoral == 1)
            {
                ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Value", true)[0]).ForeColor = System.Drawing.Color.Green;
                ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Value", true)[0]).BackColor = System.Drawing.Color.Green;
            }
            else
            {
                ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Value", true)[0]).ForeColor = System.Drawing.Color.Red;
                ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Value", true)[0]).BackColor = System.Drawing.Color.Red;
            }
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Value", true)[0]).Visible = true;

            ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Source", true)[0]).Text = BackgroundCode.Robots[Box_Number].lastCoralAcqLoc;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Source", true)[0]).Visible = true;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Source", true)[0]).ForeColor = System.Drawing.Color.Yellow;

            ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Des", true)[0]).Text = BackgroundCode.Robots[Box_Number].lastCoralLoc;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Des", true)[0]).Visible = true;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Des", true)[0]).ForeColor = System.Drawing.Color.Yellow;

            //Algae
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3", true)[0]).Text = "Algae:";
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3", true)[0]).Visible = true;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3", true)[0]).ForeColor = BackgroundCode.Robots[Box_Number].DisFlag ? System.Drawing.Color.Yellow : System.Drawing.Color.White;
            if (BackgroundCode.Robots[Box_Number].hasAlgae == 1)
            {
                ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Value", true)[0]).ForeColor = System.Drawing.Color.Green;
                ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Value", true)[0]).BackColor = System.Drawing.Color.Green;
            }
            else
            {
                ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Value", true)[0]).ForeColor = System.Drawing.Color.Red;
                ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Value", true)[0]).BackColor = System.Drawing.Color.Red;
            }
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Value", true)[0]).Visible = true;

            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Source", true)[0]).Text = BackgroundCode.Robots[Box_Number].lastAlgaeAcqLoc;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Source", true)[0]).Visible = true;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Source", true)[0]).ForeColor = System.Drawing.Color.Yellow;

            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Des", true)[0]).Text = BackgroundCode.Robots[Box_Number].lastAlgaeLoc;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Des", true)[0]).Visible = true;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Des", true)[0]).ForeColor = System.Drawing.Color.Yellow;

            //Attempt
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position4", true)[0]).Text = "End State:";
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position4", true)[0]).Visible = true;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position4Value", true)[0]).Text = BackgroundCode.Robots[Box_Number].End_State.ToString();
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position4Value", true)[0]).Visible = true;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position4Value", true)[0]).ForeColor = System.Drawing.Color.Yellow;

            //Defense Rating
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position5", true)[0]).Text = "Def:";
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position5", true)[0]).Visible = true;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position5Value", true)[0]).Text = DefenseEquality[BackgroundCode.Robots[Box_Number].Def_Rat];
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position5Value", true)[0]).Visible = BackgroundCode.Robots[Box_Number].Def_Rat != 9;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position5Value", true)[0]).ForeColor = System.Drawing.Color.Yellow;

            //Defense Effectiveness
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position7", true)[0]).Text = "Eff:";
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position7", true)[0]).Visible = BackgroundCode.Robots[Box_Number].Def_Rat != 9 && BackgroundCode.Robots[Box_Number].Def_Rat != 0;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position7Value", true)[0]).Text = BackgroundCode.Robots[Box_Number].Def_Eff.ToString();
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position7Value", true)[0]).Visible = BackgroundCode.Robots[Box_Number].Def_Eff != 9 && BackgroundCode.Robots[Box_Number].Def_Rat != 9 && BackgroundCode.Robots[Box_Number].Def_Rat != 0;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position7Value", true)[0]).ForeColor = System.Drawing.Color.Yellow;

            //Avoidance Rating
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position8", true)[0]).Text = "Avoid:";
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position8", true)[0]).Visible = true;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position8Value", true)[0]).Text = AvoidanceEquality[BackgroundCode.Robots[Box_Number].Avo_Rat];
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position8Value", true)[0]).Visible = BackgroundCode.Robots[Box_Number].Avo_Rat != 9;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position8Value", true)[0]).ForeColor = System.Drawing.Color.Yellow;

            //End State
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position11", true)[0]).Text = "Attempt:";
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position11", true)[0]).Visible = true;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position11Value", true)[0]).Text = BackgroundCode.Robots[Box_Number].Cage_Attempt.ToString();
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position11Value", true)[0]).Visible = true;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position11Value", true)[0]).ForeColor = System.Drawing.Color.Yellow;

            //Robot Strategy
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position12", true)[0]).Text = "Strat:";
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position12", true)[0]).Visible = true;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position12Value", true)[0]).Text = BackgroundCode.Robots[Box_Number].GetStrat().ToString();
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position12Value", true)[0]).Visible = true;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position12Value", true)[0]).ForeColor = System.Drawing.Color.Yellow;
        }
    }
}
