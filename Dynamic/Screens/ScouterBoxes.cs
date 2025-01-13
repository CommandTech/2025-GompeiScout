﻿using ScoutingCodeRedo.Properties;
using ScoutingCodeRedo.Static;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ScoutingCodeRedo.Dynamic
{
    internal partial class ScouterBoxes : Form
    {
        Dictionary<int, string> DefenseEquality = new Dictionary<int, string>
        {
            { 0, "None" },
            { 1, "1 Station" },
            { 2, "2 Stations" },
            { 3, "Chasing" },
            { 9, "Scouter Error" }
        };
        public ScouterBoxes()
        {
            InitializeComponent();

            updateScreen.Enabled = true;
        }

        private void UpdateScreen(object sender, EventArgs e)
        {
            for (int i = 0; i < BackgroundCode.gamePads.Length; i++)
            {
                int o = BackgroundCode.Robots[i].ScouterBox;
                switch (BackgroundCode.Robots[BackgroundCode.Robots[i].ScouterBox].Current_Mode)
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
            }
        }

        private void InAutoMode(int Box_Number, int ScouterBox)
        {
            //Leave
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position0", true)[0]).Text = "Leave:";
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position0", true)[0]).Visible = (ScouterBox == 0) || !Settings.Default.practiceMode;

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
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position0Value", true)[0]).Visible = (ScouterBox == 0) || !Settings.Default.practiceMode;

            //Near Far
            if (BackgroundCode.Robots[Box_Number].Near_Far)
            {
                ((Label)this.Controls.Find($"lbl{ScouterBox}Position1", true)[0]).Text = "Far Side";
            }
            else
            {
                ((Label)this.Controls.Find($"lbl{ScouterBox}Position1", true)[0]).Text = "Near Side";
            }
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position1", true)[0]).Visible = (ScouterBox == 0) || !Settings.Default.practiceMode;

            //Coral
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position2", true)[0]).Text = "Coral:";
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position2", true)[0]).Visible = (ScouterBox == 0) || !Settings.Default.practiceMode;
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
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Value", true)[0]).Visible = (ScouterBox == 0) || !Settings.Default.practiceMode;

            ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Source", true)[0]).Text = BackgroundCode.Robots[Box_Number].lastCoralAcqLoc;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Source", true)[0]).Visible = (ScouterBox == 0) || !Settings.Default.practiceMode;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Source", true)[0]).ForeColor = System.Drawing.Color.Yellow;

            ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Des", true)[0]).Text = BackgroundCode.Robots[Box_Number].lastCoralLoc;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Des", true)[0]).Visible = (ScouterBox == 0) || !Settings.Default.practiceMode;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Des", true)[0]).ForeColor = System.Drawing.Color.Yellow;

            //Algae
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3", true)[0]).Text = "Algae:";
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3", true)[0]).Visible = (ScouterBox == 0) || !Settings.Default.practiceMode;
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
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Value", true)[0]).Visible = (ScouterBox == 0) || !Settings.Default.practiceMode;

            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Source", true)[0]).Text = BackgroundCode.Robots[Box_Number].lastAlgaeAcqLoc;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Source", true)[0]).Visible = (ScouterBox == 0) || !Settings.Default.practiceMode;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Source", true)[0]).ForeColor = System.Drawing.Color.Yellow;

            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Des", true)[0]).Text = BackgroundCode.Robots[Box_Number].lastAlgaeLoc;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Des", true)[0]).Visible = (ScouterBox == 0) || !Settings.Default.practiceMode;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Des", true)[0]).ForeColor = System.Drawing.Color.Yellow;

            //Attempt
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position4", true)[0]).Text = "Attempt:";
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position4", true)[0]).Visible = false;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position4Value", true)[0]).Text = BackgroundCode.Robots[Box_Number].Cage_Attempt.ToString();
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position4Value", true)[0]).Visible = false;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position4Value", true)[0]).ForeColor = System.Drawing.Color.Yellow;

            //Starting Location
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position5", true)[0]).Text = "Start:";
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position5", true)[0]).Visible = true;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position5Value", true)[0]).Text = BackgroundCode.Robots[Box_Number].Starting_Location.ToString();
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position5Value", true)[0]).Visible = true;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position5Value", true)[0]).ForeColor = System.Drawing.Color.Yellow;

            //Driver Rating
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position6", true)[0]).Text = "Driver:";
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position6", true)[0]).Visible = false;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position6Value", true)[0]).Text = BackgroundCode.Robots[Box_Number].Dri_Rat.ToString();
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position6Value", true)[0]).Visible = false;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position6Value", true)[0]).ForeColor = System.Drawing.Color.Yellow;

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

            //Algae Rating
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position9", true)[0]).Text = "Algae:";
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position9", true)[0]).Visible = false;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position9Value", true)[0]).Text = BackgroundCode.Robots[Box_Number].Alg_Rat.ToString();
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position9Value", true)[0]).Visible = false;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position9Value", true)[0]).ForeColor = System.Drawing.Color.Yellow;

            //Coral Rating
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position10", true)[0]).Text = "Coral:";
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position10", true)[0]).Visible = false;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position10Value", true)[0]).Text = BackgroundCode.Robots[Box_Number].Cor_Rat.ToString();
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position10Value", true)[0]).Visible = false;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position10Value", true)[0]).ForeColor = System.Drawing.Color.Yellow;
        }
        private void InTeleopMode(int Box_Number, int ScouterBox)
        {
            //Leave
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position0", true)[0]).Text = "Leave:";
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position0", true)[0]).Visible = false;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position0Value", true)[0]).Visible = false;

            //Near Far
            if (BackgroundCode.Robots[Box_Number].Near_Far)
            {
                ((Label)this.Controls.Find($"lbl{ScouterBox}Position1", true)[0]).Text = "Far Side";
            }
            else
            {
                ((Label)this.Controls.Find($"lbl{ScouterBox}Position1", true)[0]).Text = "Near Side";
            }
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position1", true)[0]).Visible = (ScouterBox == 0) || !Settings.Default.practiceMode;

            //Coral
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position2", true)[0]).Text = "Coral:";
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position2", true)[0]).Visible = (ScouterBox == 0) || !Settings.Default.practiceMode;
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
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Value", true)[0]).Visible = (ScouterBox == 0) || !Settings.Default.practiceMode;

            ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Source", true)[0]).Text = BackgroundCode.Robots[Box_Number].lastCoralAcqLoc;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Source", true)[0]).Visible = (ScouterBox == 0) || !Settings.Default.practiceMode;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Source", true)[0]).ForeColor = System.Drawing.Color.Yellow;

            ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Des", true)[0]).Text = BackgroundCode.Robots[Box_Number].lastCoralLoc;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Des", true)[0]).Visible = (ScouterBox == 0) || !Settings.Default.practiceMode;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Des", true)[0]).ForeColor = System.Drawing.Color.Yellow;

            //Algae
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3", true)[0]).Text = "Algae:";
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3", true)[0]).Visible = (ScouterBox == 0) || !Settings.Default.practiceMode;
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
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Value", true)[0]).Visible = (ScouterBox == 0) || !Settings.Default.practiceMode;

            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Source", true)[0]).Text = BackgroundCode.Robots[Box_Number].lastAlgaeAcqLoc;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Source", true)[0]).Visible = (ScouterBox == 0) || !Settings.Default.practiceMode;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Source", true)[0]).ForeColor = System.Drawing.Color.Yellow;

            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Des", true)[0]).Text = BackgroundCode.Robots[Box_Number].lastAlgaeLoc;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Des", true)[0]).Visible = (ScouterBox == 0) || !Settings.Default.practiceMode;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Des", true)[0]).ForeColor = System.Drawing.Color.Yellow;

            //Attempt
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position4", true)[0]).Text = "Attempt:";
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position4", true)[0]).Visible = false;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position4Value", true)[0]).Text = BackgroundCode.Robots[Box_Number].Cage_Attempt.ToString();
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position4Value", true)[0]).Visible = false;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position4Value", true)[0]).ForeColor = System.Drawing.Color.Yellow;

            //Defense Rating
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position5", true)[0]).Text = "Def:";
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position5", true)[0]).Visible = false;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position5Value", true)[0]).Text = BackgroundCode.Robots[Box_Number].Def_Rat.ToString();
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position5Value", true)[0]).Visible = false;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position5Value", true)[0]).ForeColor = System.Drawing.Color.Yellow;

            //Driver Rating
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position6", true)[0]).Text = "Driver:";
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position6", true)[0]).Visible = false;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position6Value", true)[0]).Text = BackgroundCode.Robots[Box_Number].Dri_Rat.ToString();
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position6Value", true)[0]).Visible = false;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position6Value", true)[0]).ForeColor = System.Drawing.Color.Yellow;

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

            //Algae Rating
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position9", true)[0]).Text = "Algae:";
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position9", true)[0]).Visible = false;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position9Value", true)[0]).Text = BackgroundCode.Robots[Box_Number].Alg_Rat.ToString();
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position9Value", true)[0]).Visible = false;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position9Value", true)[0]).ForeColor = System.Drawing.Color.Yellow;

            //Coral Rating
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position10", true)[0]).Text = "Coral:";
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position10", true)[0]).Visible = false;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position10Value", true)[0]).Text = BackgroundCode.Robots[Box_Number].Cor_Rat.ToString();
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position10Value", true)[0]).Visible = false;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position10Value", true)[0]).ForeColor = System.Drawing.Color.Yellow;
        }
        private void InDefenseMode(int Box_Number, int ScouterBox)
        {
            //Defense Timer
            BackgroundCode.Robots[Box_Number].DefTimeDouble = BackgroundCode.Robots[Box_Number].DefTime_StopWatch.Elapsed.TotalSeconds;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position0", true)[0]).Text = BackgroundCode.Robots[Box_Number].DefTimeDouble.ToString();
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position0", true)[0]).Visible = true;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position0Value", true)[0]).Visible = false;

            //Near Far
            if (BackgroundCode.Robots[Box_Number].Near_Far)
            {
                ((Label)this.Controls.Find($"lbl{ScouterBox}Position1", true)[0]).Text = "Far Side";
            }
            else
            {
                ((Label)this.Controls.Find($"lbl{ScouterBox}Position1", true)[0]).Text = "Near Side";
            }
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position1", true)[0]).Visible = (ScouterBox == 0) || !Settings.Default.practiceMode;

            //Coral
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position2", true)[0]).Text = "Coral:";
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position2", true)[0]).Visible = (ScouterBox == 0) || !Settings.Default.practiceMode;
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
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Value", true)[0]).Visible = (ScouterBox == 0) || !Settings.Default.practiceMode;

            ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Source", true)[0]).Text = BackgroundCode.Robots[Box_Number].lastCoralAcqLoc;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Source", true)[0]).Visible = (ScouterBox == 0) || !Settings.Default.practiceMode;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Source", true)[0]).ForeColor = System.Drawing.Color.Yellow;

            ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Des", true)[0]).Text = BackgroundCode.Robots[Box_Number].lastCoralLoc;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Des", true)[0]).Visible = (ScouterBox == 0) || !Settings.Default.practiceMode;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Des", true)[0]).ForeColor = System.Drawing.Color.Yellow;

            //Algae
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3", true)[0]).Text = "Algae:";
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3", true)[0]).Visible = (ScouterBox == 0) || !Settings.Default.practiceMode;
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
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Value", true)[0]).Visible = (ScouterBox == 0) || !Settings.Default.practiceMode;

            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Source", true)[0]).Text = BackgroundCode.Robots[Box_Number].lastAlgaeAcqLoc;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Source", true)[0]).Visible = (ScouterBox == 0) || !Settings.Default.practiceMode;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Source", true)[0]).ForeColor = System.Drawing.Color.Yellow;

            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Des", true)[0]).Text = BackgroundCode.Robots[Box_Number].lastAlgaeLoc;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Des", true)[0]).Visible = (ScouterBox == 0) || !Settings.Default.practiceMode;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Des", true)[0]).ForeColor = System.Drawing.Color.Yellow;

            //Attempt
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position4", true)[0]).Text = "Attempt:";
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position4", true)[0]).Visible = false;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position4Value", true)[0]).Text = BackgroundCode.Robots[Box_Number].Cage_Attempt.ToString();
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position4Value", true)[0]).Visible = false;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position4Value", true)[0]).ForeColor = System.Drawing.Color.Yellow;

            //Defense Rating
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position5", true)[0]).Text = "Def:";
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position5", true)[0]).Visible = false;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position5Value", true)[0]).Text = BackgroundCode.Robots[Box_Number].Def_Rat.ToString();
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position5Value", true)[0]).Visible = false;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position5Value", true)[0]).ForeColor = System.Drawing.Color.Yellow;

            //Driver Rating
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position6", true)[0]).Text = "Driver:";
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position6", true)[0]).Visible = false;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position6Value", true)[0]).Text = BackgroundCode.Robots[Box_Number].Dri_Rat.ToString();
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position6Value", true)[0]).Visible = false;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position6Value", true)[0]).ForeColor = System.Drawing.Color.Yellow;

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

            //Algae Rating
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position9", true)[0]).Text = "Algae:";
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position9", true)[0]).Visible = false;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position9Value", true)[0]).Text = BackgroundCode.Robots[Box_Number].Alg_Rat.ToString();
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position9Value", true)[0]).Visible = false;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position9Value", true)[0]).ForeColor = System.Drawing.Color.Yellow;

            //Coral Rating
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position10", true)[0]).Text = "Coral:";
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position10", true)[0]).Visible = false;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position10Value", true)[0]).Text = BackgroundCode.Robots[Box_Number].Cor_Rat.ToString();
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position10Value", true)[0]).Visible = false;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position10Value", true)[0]).ForeColor = System.Drawing.Color.Yellow;
        }
        private void InSurfacingMode(int Box_Number, int ScouterBox)
        {
            //Climb Timer
            BackgroundCode.Robots[Box_Number].ClimbTDouble = BackgroundCode.Robots[Box_Number].ClimbT_StopWatch.Elapsed.TotalSeconds;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position0", true)[0]).Text = BackgroundCode.Robots[Box_Number].ClimbTDouble.ToString();
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position0", true)[0]).Visible = true;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position0Value", true)[0]).Visible = false;

            //Near Far
            if (BackgroundCode.Robots[Box_Number].Near_Far)
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
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position2", true)[0]).Visible = (ScouterBox == 0) || !Settings.Default.practiceMode;
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
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Value", true)[0]).Visible = (ScouterBox == 0) || !Settings.Default.practiceMode;

            ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Source", true)[0]).Text = BackgroundCode.Robots[Box_Number].lastCoralAcqLoc;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Source", true)[0]).Visible = (ScouterBox == 0) || !Settings.Default.practiceMode;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Source", true)[0]).ForeColor = System.Drawing.Color.Yellow;

            ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Des", true)[0]).Text = BackgroundCode.Robots[Box_Number].lastCoralLoc;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Des", true)[0]).Visible = (ScouterBox == 0) || !Settings.Default.practiceMode;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Des", true)[0]).ForeColor = System.Drawing.Color.Yellow;

            //Algae
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3", true)[0]).Text = "Algae:";
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3", true)[0]).Visible = (ScouterBox == 0) || !Settings.Default.practiceMode;
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
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Value", true)[0]).Visible = (ScouterBox == 0) || !Settings.Default.practiceMode;

            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Source", true)[0]).Text = BackgroundCode.Robots[Box_Number].lastAlgaeAcqLoc;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Source", true)[0]).Visible = (ScouterBox == 0) || !Settings.Default.practiceMode;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Source", true)[0]).ForeColor = System.Drawing.Color.Yellow;

            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Des", true)[0]).Text = BackgroundCode.Robots[Box_Number].lastAlgaeLoc;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Des", true)[0]).Visible = (ScouterBox == 0) || !Settings.Default.practiceMode;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Des", true)[0]).ForeColor = System.Drawing.Color.Yellow;

            //Attempt
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position4", true)[0]).Text = "Attempt:";
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position4", true)[0]).Visible = true;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position4Value", true)[0]).Text = BackgroundCode.Robots[Box_Number].Cage_Attempt.ToString();
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position4Value", true)[0]).Visible = true;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position4Value", true)[0]).ForeColor = System.Drawing.Color.Yellow;

            //Defense Rating
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position5", true)[0]).Text = "Def:";
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position5", true)[0]).Visible = true;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position5Value", true)[0]).Text = DefenseEquality[BackgroundCode.Robots[Box_Number].Def_Rat];
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position5Value", true)[0]).Visible = BackgroundCode.Robots[Box_Number].Def_Rat != 9;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position5Value", true)[0]).ForeColor = System.Drawing.Color.Yellow;

            //Driver Rating
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position6", true)[0]).Text = "Driver:";
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position6", true)[0]).Visible = true;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position6Value", true)[0]).Text = BackgroundCode.Robots[Box_Number].Dri_Rat.ToString();
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position6Value", true)[0]).Visible = BackgroundCode.Robots[Box_Number].Dri_Rat != 9;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position6Value", true)[0]).ForeColor = System.Drawing.Color.Yellow;

            //Defense Effectiveness
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position7", true)[0]).Text = "Eff:";
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position7", true)[0]).Visible = BackgroundCode.Robots[Box_Number].Def_Rat != 9 && BackgroundCode.Robots[Box_Number].Def_Rat != 0;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position7Value", true)[0]).Text = BackgroundCode.Robots[Box_Number].Def_Eff.ToString();
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position7Value", true)[0]).Visible = BackgroundCode.Robots[Box_Number].Def_Eff != 9 && BackgroundCode.Robots[Box_Number].Def_Rat != 9 && BackgroundCode.Robots[Box_Number].Def_Rat != 0;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position7Value", true)[0]).ForeColor = System.Drawing.Color.Yellow;

            //Avoidance Rating
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position8", true)[0]).Text = "Avoid:";
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position8", true)[0]).Visible = true;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position8Value", true)[0]).Text = BackgroundCode.Robots[Box_Number].Avo_Rat.ToString();
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position8Value", true)[0]).Visible = BackgroundCode.Robots[Box_Number].Avo_Rat != 9;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position8Value", true)[0]).ForeColor = System.Drawing.Color.Yellow;

            //Algae Rating
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position9", true)[0]).Text = "Algae:";
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position9", true)[0]).Visible = true;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position9Value", true)[0]).Text = BackgroundCode.Robots[Box_Number].Alg_Rat.ToString();
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position9Value", true)[0]).Visible = BackgroundCode.Robots[Box_Number].Alg_Rat != 9;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position9Value", true)[0]).ForeColor = System.Drawing.Color.Yellow;

            //Coral Rating
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position10", true)[0]).Text = "Coral:";
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position10", true)[0]).Visible = true;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position10Value", true)[0]).Text = BackgroundCode.Robots[Box_Number].Cor_Rat.ToString();
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position10Value", true)[0]).Visible = BackgroundCode.Robots[Box_Number].Cor_Rat != 9;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position10Value", true)[0]).ForeColor = System.Drawing.Color.Yellow;
        }
    }
}
