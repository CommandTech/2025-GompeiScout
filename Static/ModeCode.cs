using System;
using System.Windows.Forms;
using System.Diagnostics;
using ScoutingCodeRedo.Dynamic;

namespace ScoutingCodeRedo.Static
{
    public partial class MainScreen : Form
    {

        private bool initializing = true;

        private void JoyStickReader(object sender, EventArgs e)
        {
            // Loop through all connected gamepads
            for (int gamepad_ctr = 0; gamepad_ctr < gamePads.Length; gamepad_ctr++) controllers.readStick(gamePads, gamepad_ctr);   //Initialize all six controllers

            // Loop through all Scouters/Robots
            for (int robot_ctr = 0; robot_ctr < Robots.Length; robot_ctr++)
            {
                Robots[robot_ctr] = controllers.getRobotState(robot_ctr);  //Initialize all six robots

                if (initializing == true) Robots[robot_ctr].OpptT_StopWatch = new Stopwatch();
                if (initializing == true) Robots[robot_ctr].NeutT_StopWatch = new Stopwatch();
                if (initializing == true) Robots[robot_ctr].AllyT_StopWatch = new Stopwatch();
                if (initializing == true) Robots[robot_ctr].ClimbT_StopWatch = new Stopwatch();
            }

            // Loop through all Scouters/Robots
            for (int robot_ctr = 0; robot_ctr < 1; robot_ctr++)
            {
                Robots[robot_ctr] = controllers.getRobotState(robot_ctr);  //Initialize all six robots
            }

            initializing = false;

            Robots[0].Current_Match = Robots[1].Current_Match = Robots[2].Current_Match = Robots[3].Current_Match = Robots[4].Current_Match = Robots[5].Current_Match = currentmatch + 1;

            Robots[0].color = Robots[1].color = Robots[2].color = "Red";
            Robots[3].color = Robots[4].color = Robots[5].color = "Blue";

            // In Mode Handlers (What to do when a Scouter/Robot is in a mode, not switching between modes)
            // #Session0
            // Scouter 1
            if (Robots[0].Current_Mode == RobotState.ROBOT_MODE.Auto) InAutoMode(0);  // Scouter 1
            else if (Robots[0].Current_Mode == RobotState.ROBOT_MODE.Teleop) InTeleopMode(0);
            else if (Robots[0].Current_Mode == RobotState.ROBOT_MODE.Showtime) InShowtimeMode(0);
            // Scouter 2
            if (Robots[1].Current_Mode == RobotState.ROBOT_MODE.Auto) InAutoMode(1);  // Scouter 2
            else if (Robots[1].Current_Mode == RobotState.ROBOT_MODE.Teleop) InTeleopMode(1);
            else if (Robots[1].Current_Mode == RobotState.ROBOT_MODE.Showtime) InShowtimeMode(1);

            // Scouter 3
            if (Robots[2].Current_Mode == RobotState.ROBOT_MODE.Auto) InAutoMode(2);  // Scouter 3
            else if (Robots[2].Current_Mode == RobotState.ROBOT_MODE.Teleop) InTeleopMode(2);
            else if (Robots[2].Current_Mode == RobotState.ROBOT_MODE.Showtime) InShowtimeMode(2);

            // Scouter 4
            if (Robots[3].Current_Mode == RobotState.ROBOT_MODE.Auto) InAutoMode(3);  // Scouter 4
            else if (Robots[3].Current_Mode == RobotState.ROBOT_MODE.Teleop) InTeleopMode(3);
            else if (Robots[3].Current_Mode == RobotState.ROBOT_MODE.Showtime) InShowtimeMode(3);

            // Scouter 5
            if (Robots[4].Current_Mode == RobotState.ROBOT_MODE.Auto) InAutoMode(4);  // Scouter 5
            else if (Robots[4].Current_Mode == RobotState.ROBOT_MODE.Teleop) InTeleopMode(4);
            else if (Robots[4].Current_Mode == RobotState.ROBOT_MODE.Showtime) InShowtimeMode(4);

            // Scouter 6
            if (Robots[5].Current_Mode == RobotState.ROBOT_MODE.Auto) InAutoMode(5);  // Scouter 6
            else if (Robots[5].Current_Mode == RobotState.ROBOT_MODE.Teleop) InTeleopMode(5);
            else if (Robots[5].Current_Mode == RobotState.ROBOT_MODE.Showtime) InShowtimeMode(5);
        }

        private void InAutoMode(int Controller_Number)
        {
            //Scouter Name
            ((Label)this.Controls.Find("lbl" + Controller_Number + "ScoutName", true)[0]).Text = Robots[Controller_Number].getScouterName(RobotState.SCOUTER_NAME.Select_Name).ToString();

            //Mode
            ((Label)this.Controls.Find("lbl" + Controller_Number + "ModeValue", true)[0]).Text = Robots[Controller_Number].Current_Mode.ToString() + " Mode";

            // Acquire
            ((Label)this.Controls.Find("lbl" + Controller_Number + "Position0", true)[0]).Text = "Acq:";
            ((Label)this.Controls.Find("lbl" + Controller_Number + "Position0", true)[0]).Visible = true;

            if (Robots[Controller_Number].Acq_Loc == RobotState.CURRENT_LOC.Select.ToString() && Robots[Controller_Number].Acq_Center == 0)
            {
                ((Label)this.Controls.Find("lbl" + Controller_Number + "Position0Value", true)[0]).Visible = false;
            }
            else
            {
                ((Label)this.Controls.Find("lbl" + Controller_Number + "Position0Value", true)[0]).Visible = true;
            }

            if (Robots[Controller_Number].Acq_Center != 0)
            {
                ((Label)this.Controls.Find("lbl" + Controller_Number + "Position0Value", true)[0]).Text = Robots[Controller_Number].Acq_Center.ToString();
            }
            else
            {
                ((Label)this.Controls.Find("lbl" + Controller_Number + "Position0Value", true)[0]).Text = Robots[Controller_Number].Acq_Loc;
            }
            ((Label)this.Controls.Find("lbl" + Controller_Number + "Position0Flag", true)[0]).Text = "D";
            if (Robots[Controller_Number].Flag == 1 && Robots[Controller_Number].Acq_Center != 0)
            {
                ((Label)this.Controls.Find("lbl" + Controller_Number + "Position0Flag", true)[0]).Visible = true;
            }
            else
            {
                ((Label)this.Controls.Find("lbl" + Controller_Number + "Position0Flag", true)[0]).Visible = false;
            }

            // Current Location
            ((Label)this.Controls.Find("lbl" + Controller_Number + "Position1", true)[0]).Text = "Loc:";
            ((Label)this.Controls.Find("lbl" + Controller_Number + "Position1", true)[0]).Visible = true;
            ((Label)this.Controls.Find("lbl" + Controller_Number + "Position1Value", true)[0]).Text = Robots[Controller_Number].Current_Loc.ToString();
            ((Label)this.Controls.Find("lbl" + Controller_Number + "Position1Value", true)[0]).Visible = true;

            // Deliver Destination
            ((Label)this.Controls.Find("lbl" + Controller_Number + "Position2", true)[0]).Text = "Del:";
            ((Label)this.Controls.Find("lbl" + Controller_Number + "Position2", true)[0]).Visible = true;
            if (Robots[Controller_Number].Del_Dest == RobotState.DEL_DEST.Select)
            {
                ((Label)this.Controls.Find("lbl" + Controller_Number + "Position2Value", true)[0]).Visible = false;
            }
            else
            {
                ((Label)this.Controls.Find("lbl" + Controller_Number + "Position2Value", true)[0]).Visible = true;
            }
            ((Label)this.Controls.Find("lbl" + Controller_Number + "Position2Value", true)[0]).Text = Robots[Controller_Number].Del_Dest.ToString();
            ((Label)this.Controls.Find("lbl" + Controller_Number + "Position2Flag", true)[0]).Text = "M";
            if (Robots[Controller_Number].Flag == 1 && Robots[Controller_Number].Del_Dest != RobotState.DEL_DEST.Select)
            {
                ((Label)this.Controls.Find("lbl" + Controller_Number + "Position2Flag", true)[0]).Visible = true;
            }
            else
            {
                ((Label)this.Controls.Find("lbl" + Controller_Number + "Position2Flag", true)[0]).Visible = false;
            }

            // Robot Setup
            ((Label)this.Controls.Find("lbl" + Controller_Number + "Position3", true)[0]).Text = "Setup:";
            ((Label)this.Controls.Find("lbl" + Controller_Number + "Position3", true)[0]).Visible = true;
            ((Label)this.Controls.Find("lbl" + Controller_Number + "Position3Value", true)[0]).Text = Robots[Controller_Number].Robot_Set.ToString();
            if (Robots[Controller_Number].Robot_Set == RobotState.ROBOT_SET.Select)
            {
                ((Label)this.Controls.Find("lbl" + Controller_Number + "Position3Value", true)[0]).Visible = false;
            }
            else
            {
                ((Label)this.Controls.Find("lbl" + Controller_Number + "Position3Value", true)[0]).Visible = true;
            }

            // Leave
            ((Label)this.Controls.Find("lbl" + Controller_Number + "Position4", true)[0]).Text = "Leave:";
            ((Label)this.Controls.Find("lbl" + Controller_Number + "Position4", true)[0]).Visible = true;
            ((Label)this.Controls.Find("lbl" + Controller_Number + "Position4Value", true)[0]).Visible = true;
            if (Robots[Controller_Number].Leave == 0)
            {
                ((Label)this.Controls.Find("lbl" + Controller_Number + "Position4Value", true)[0]).BackColor = System.Drawing.Color.Red;
                ((Label)this.Controls.Find("lbl" + Controller_Number + "Position4Value", true)[0]).ForeColor = System.Drawing.Color.Red;
            }
            if (Robots[Controller_Number].Leave == 1)
            {
                ((Label)this.Controls.Find("lbl" + Controller_Number + "Position4Value", true)[0]).BackColor = System.Drawing.Color.Green;
                ((Label)this.Controls.Find("lbl" + Controller_Number + "Position4Value", true)[0]).ForeColor = System.Drawing.Color.Green;
            }

            // Hp in Amp
            ((Label)this.Controls.Find("lbl" + Controller_Number + "Position5", true)[0]).Text = "HP Amp";
            ((Label)this.Controls.Find("lbl" + Controller_Number + "Position5", true)[0]).Visible = true;
            ((Label)this.Controls.Find("lbl" + Controller_Number + "Position5Value", true)[0]).Visible = true;
            if (Robots[Controller_Number].HP_Amp == RobotState.HP_AMP.N)
            {
                ((Label)this.Controls.Find("lbl" + Controller_Number + "Position5Value", true)[0]).BackColor = System.Drawing.Color.Red;
                ((Label)this.Controls.Find("lbl" + Controller_Number + "Position5Value", true)[0]).ForeColor = System.Drawing.Color.Red;
            }
            if (Robots[Controller_Number].HP_Amp == RobotState.HP_AMP.Y)
            {
                ((Label)this.Controls.Find("lbl" + Controller_Number + "Position5Value", true)[0]).BackColor = System.Drawing.Color.Green;
                ((Label)this.Controls.Find("lbl" + Controller_Number + "Position5Value", true)[0]).ForeColor = System.Drawing.Color.Green;
            }
            if (Robots[Controller_Number].HP_Amp == RobotState.HP_AMP.Select)
            {
                ((Label)this.Controls.Find("lbl" + Controller_Number + "Position5Value", true)[0]).BackColor = System.Drawing.Color.Yellow;
                ((Label)this.Controls.Find("lbl" + Controller_Number + "Position5Value", true)[0]).ForeColor = System.Drawing.Color.Yellow;
            }

            if (Robots[Controller_Number].NoSho == true)
            {
                ((Label)this.Controls.Find("lbl" + Controller_Number + "Position6", true)[0]).Text = "Mics:";
                ((Label)this.Controls.Find("lbl" + Controller_Number + "Position6", true)[0]).Visible = true;

                if (Robots[Controller_Number].Mic == 10 || Robots[Controller_Number].Mic == 9)
                {
                    ((Label)this.Controls.Find("lbl" + Controller_Number + "Position6Value", true)[0]).Visible = false;
                }
                else
                {
                    ((Label)this.Controls.Find("lbl" + Controller_Number + "Position6Value", true)[0]).Text = Robots[Controller_Number].Mic.ToString();
                    ((Label)this.Controls.Find("lbl" + Controller_Number + "Position6Value", true)[0]).Visible = true;
                }
            }
            else
            {
                ((Label)this.Controls.Find("lbl" + Controller_Number + "Position6", true)[0]).Visible = false;
                ((Label)this.Controls.Find("lbl" + Controller_Number + "Position6Value", true)[0]).Visible = false;
            }


            ((Label)this.Controls.Find("lbl" + Controller_Number + "Position7", true)[0]).Visible = false;
            ((Label)this.Controls.Find("lbl" + Controller_Number + "Position7Value", true)[0]).Visible = false;

            ((Label)this.Controls.Find("lbl" + Controller_Number + "Position8", true)[0]).Visible = false;
            ((Label)this.Controls.Find("lbl" + Controller_Number + "Position8Value", true)[0]).Visible = false;

            ((Label)this.Controls.Find("lbl" + Controller_Number + "Position9", true)[0]).Visible = false;
            ((Label)this.Controls.Find("lbl" + Controller_Number + "Position9Value", true)[0]).Visible = false;

            ((Label)this.Controls.Find("lbl" + Controller_Number + "Position10", true)[0]).Visible = false;
            ((Label)this.Controls.Find("lbl" + Controller_Number + "Position10Value", true)[0]).Visible = false;

            // Match Event
            ((Label)this.Controls.Find("lbl" + Controller_Number + "Position11", true)[0]).Text = Robots[Controller_Number].match_event.ToString();
            ((Label)this.Controls.Find("lbl" + Controller_Number + "Position11", true)[0]).Visible = true;
        }

        private void InTeleopMode(int Controller_Number)
        {
            //Scouter Name
            ((Label)this.Controls.Find("lbl" + Controller_Number + "ScoutName", true)[0]).Text = Robots[Controller_Number].getScouterName(RobotState.SCOUTER_NAME.Select_Name).ToString();

            ((Label)this.Controls.Find("lbl" + Controller_Number + "ModeValue", true)[0]).Text = Robots[Controller_Number].Current_Mode.ToString() + " Mode";

            //Robots[Controller_Number].AllyTDouble = Robots[Controller_Number].AllyT_StopWatch.Elapsed.TotalSeconds;
            //((Label)this.Controls.Find("lbl" + Controller_Number + "Position0Value", true)[0]).Text = Robots[Controller_Number].AllyTDouble.ToString("0.#");
            //((Label)this.Controls.Find("lbl" + Controller_Number + "Position0Value", true)[0]).Visible = true;

            ((Label)this.Controls.Find("lbl" + Controller_Number + "Position0", true)[0]).Text = "Acq:";
            ((Label)this.Controls.Find("lbl" + Controller_Number + "Position0", true)[0]).Visible = true;
            ((Label)this.Controls.Find("lbl" + Controller_Number + "Position0Value", true)[0]).Text = Robots[Controller_Number].Acq_Loc.ToString();
            if (Robots[Controller_Number].Acq_Loc.Equals("Select"))
            {
                ((Label)this.Controls.Find("lbl" + Controller_Number + "Position0Value", true)[0]).Visible = false;
            }
            else
            {
                ((Label)this.Controls.Find("lbl" + Controller_Number + "Position0Value", true)[0]).Visible = true;
            }
            ((Label)this.Controls.Find("lbl" + Controller_Number + "Position0Flag", true)[0]).Text = "D";
            if (Robots[Controller_Number].Flag == 1 && Robots[Controller_Number].Del_Dest == RobotState.DEL_DEST.Select && Robots[Controller_Number].Acq_Loc != "Select")
            {
                ((Label)this.Controls.Find("lbl" + Controller_Number + "Position0Flag", true)[0]).Visible = true;
            }
            else if (Robots[Controller_Number].Flag == 1 && Robots[Controller_Number].Acq_Loc.Equals("Select"))
            {
                ((Label)this.Controls.Find("lbl" + Controller_Number + "Position0Flag", true)[0]).Visible = false;
            }
            else
            {
                ((Label)this.Controls.Find("lbl" + Controller_Number + "Position0Flag", true)[0]).Visible = false;
            }

            //Robots[Controller_Number].OpptTDouble = Robots[Controller_Number].OpptT_StopWatch.Elapsed.TotalSeconds;
            //((Label)this.Controls.Find("lbl" + Controller_Number + "Position3Value", true)[0]).Text = Robots[Controller_Number].OpptTDouble.ToString("0.#");
            //((Label)this.Controls.Find("lbl" + Controller_Number + "Position3Value", true)[0]).Visible = true;

            ((Label)this.Controls.Find("lbl" + Controller_Number + "Position1", true)[0]).Text = "Loc:";
            ((Label)this.Controls.Find("lbl" + Controller_Number + "Position1", true)[0]).Visible = true;
            ((Label)this.Controls.Find("lbl" + Controller_Number + "Position1Value", true)[0]).Text = Robots[Controller_Number].Current_Loc.ToString();
            ((Label)this.Controls.Find("lbl" + Controller_Number + "Position1Value", true)[0]).Visible = true;

            //Robots[Controller_Number].NeutTDouble = Robots[Controller_Number].NeutT_StopWatch.Elapsed.TotalSeconds;
            //((Label)this.Controls.Find("lbl" + Controller_Number + "Position2Value", true)[0]).Text = Robots[Controller_Number].NeutTDouble.ToString("0.#");
            //((Label)this.Controls.Find("lbl" + Controller_Number + "Position2Value", true)[0]).Visible = true;

            ((Label)this.Controls.Find("lbl" + Controller_Number + "Position2", true)[0]).Text = "Del:";
            ((Label)this.Controls.Find("lbl" + Controller_Number + "Position2", true)[0]).Visible = true;
            ((Label)this.Controls.Find("lbl" + Controller_Number + "Position2Value", true)[0]).Text = Robots[Controller_Number].Del_Dest.ToString();
            if (Robots[Controller_Number].Del_Dest != RobotState.DEL_DEST.Select)
            {
                ((Label)this.Controls.Find("lbl" + Controller_Number + "Position2Value", true)[0]).Visible = true;
            }
            else
            {
                ((Label)this.Controls.Find("lbl" + Controller_Number + "Position2Value", true)[0]).Visible = false;
            }
            ((Label)this.Controls.Find("lbl" + Controller_Number + "Position2Flag", true)[0]).Text = "M";
            if (Robots[Controller_Number].Flag == 1 && Robots[Controller_Number].Del_Dest != RobotState.DEL_DEST.Select)
            {
                ((Label)this.Controls.Find("lbl" + Controller_Number + "Position2Flag", true)[0]).Visible = true;
            }
            else if (Robots[Controller_Number].Flag == 0)
            {
                ((Label)this.Controls.Find("lbl" + Controller_Number + "Position2Flag", true)[0]).Visible = false;
            }

            //Robots[Controller_Number].OpptTDouble = Robots[Controller_Number].OpptT_StopWatch.Elapsed.TotalSeconds;
            //((Label)this.Controls.Find("lbl" + Controller_Number + "Position3Value", true)[0]).Text = Robots[Controller_Number].OpptTDouble.ToString("0.#");
            //((Label)this.Controls.Find("lbl" + Controller_Number + "Position3Value", true)[0]).Visible = true;

            ((Label)this.Controls.Find("lbl" + Controller_Number + "Position3", true)[0]).Visible = false;
            ((Label)this.Controls.Find("lbl" + Controller_Number + "Position3Value", true)[0]).Visible = false;

            ((Label)this.Controls.Find("lbl" + Controller_Number + "Position4", true)[0]).Visible = false;
            ((Label)this.Controls.Find("lbl" + Controller_Number + "Position4Value", true)[0]).Visible = false;

            ((Label)this.Controls.Find("lbl" + Controller_Number + "Position5", true)[0]).Visible = false;
            ((Label)this.Controls.Find("lbl" + Controller_Number + "Position5Value", true)[0]).Visible = false;

            ((Label)this.Controls.Find("lbl" + Controller_Number + "Position6", true)[0]).Visible = false;
            ((Label)this.Controls.Find("lbl" + Controller_Number + "Position6Value", true)[0]).Visible = false;

            ((Label)this.Controls.Find("lbl" + Controller_Number + "Position7", true)[0]).Visible = false;
            ((Label)this.Controls.Find("lbl" + Controller_Number + "Position7Value", true)[0]).Visible = false;

            ((Label)this.Controls.Find("lbl" + Controller_Number + "Position8", true)[0]).Visible = false;
            ((Label)this.Controls.Find("lbl" + Controller_Number + "Position8Value", true)[0]).Visible = false;

            ((Label)this.Controls.Find("lbl" + Controller_Number + "Position9", true)[0]).Visible = false;
            ((Label)this.Controls.Find("lbl" + Controller_Number + "Position9Value", true)[0]).Visible = false;

            ((Label)this.Controls.Find("lbl" + Controller_Number + "Position10", true)[0]).Visible = false;
            ((Label)this.Controls.Find("lbl" + Controller_Number + "Position10Value", true)[0]).Visible = false;

            ((Label)this.Controls.Find("lbl" + Controller_Number + "Position11", true)[0]).Text = Robots[Controller_Number].match_event.ToString();
            ((Label)this.Controls.Find("lbl" + Controller_Number + "Position11", true)[0]).Visible = true;
        }

        private void InShowtimeMode(int Controller_Number)
        {
            //Scouter Name
            ((Label)this.Controls.Find("lbl" + Controller_Number + "ScoutName", true)[0]).Text = Robots[Controller_Number].getScouterName(RobotState.SCOUTER_NAME.Select_Name).ToString();

            //Mode
            ((Label)this.Controls.Find("lbl" + Controller_Number + "ModeValue", true)[0]).Text = Robots[Controller_Number].Current_Mode.ToString() + " Mode";

            ((Label)this.Controls.Find("lbl" + Controller_Number + "Position0", true)[0]).Text = "Del:";
            ((Label)this.Controls.Find("lbl" + Controller_Number + "Position0", true)[0]).Visible = true;
            ((Label)this.Controls.Find("lbl" + Controller_Number + "Position0Value", true)[0]).Text = Robots[Controller_Number].Del_Dest.ToString();
            if (Robots[Controller_Number].Del_Dest != RobotState.DEL_DEST.Select)
            {
                ((Label)this.Controls.Find("lbl" + Controller_Number + "Position0Value", true)[0]).Visible = true;
            }
            else
            {
                ((Label)this.Controls.Find("lbl" + Controller_Number + "Position0Value", true)[0]).Visible = false;
            }
            ((Label)this.Controls.Find("lbl" + Controller_Number + "Position0Flag", true)[0]).Text = "M";
            if (Robots[Controller_Number].Flag == 1 && Robots[Controller_Number].Del_Dest != RobotState.DEL_DEST.Select)
            {
                ((Label)this.Controls.Find("lbl" + Controller_Number + "Position0Flag", true)[0]).Visible = true;
            }
            else if (Robots[Controller_Number].Flag == 0)
            {
                ((Label)this.Controls.Find("lbl" + Controller_Number + "Position0Flag", true)[0]).Visible = false;
            }

            ((Label)this.Controls.Find("lbl" + Controller_Number + "Position1", true)[0]).Visible = false;
            ((Label)this.Controls.Find("lbl" + Controller_Number + "Position1Value", true)[0]).Visible = false;

            ((Label)this.Controls.Find("lbl" + Controller_Number + "Position2", true)[0]).Text = "Climb:";
            ((Label)this.Controls.Find("lbl" + Controller_Number + "Position2", true)[0]).Visible = true;
            Robots[Controller_Number].ClimbTDouble = Robots[Controller_Number].ClimbT_StopWatch.Elapsed.TotalSeconds;
            ((Label)this.Controls.Find("lbl" + Controller_Number + "Position2Value", true)[0]).Text = Robots[Controller_Number].ClimbTDouble.ToString("0.#");
            ((Label)this.Controls.Find("lbl" + Controller_Number + "Position2Value", true)[0]).Visible = true;
            ((Label)this.Controls.Find("lbl" + Controller_Number + "Position2Flag", true)[0]).Visible = false;

            ((Label)this.Controls.Find("lbl" + Controller_Number + "Position3", true)[0]).Text = "Status:";
            ((Label)this.Controls.Find("lbl" + Controller_Number + "Position3", true)[0]).Visible = true;
            ((Label)this.Controls.Find("lbl" + Controller_Number + "Position3Value", true)[0]).Text = Robots[Controller_Number].Stage_Stat.ToString();
            ((Label)this.Controls.Find("lbl" + Controller_Number + "Position3Value", true)[0]).Visible = true;

            if (Robots[Controller_Number].Stage_Stat == RobotState.STAGE_STAT.Select)
            {
                ((Label)this.Controls.Find("lbl" + Controller_Number + "Position3Value", true)[0]).Visible = false;
            }
            else
            {
                ((Label)this.Controls.Find("lbl" + Controller_Number + "Position3Value", true)[0]).Visible = true;
            }

            if (Robots[Controller_Number].Stage_Stat == RobotState.STAGE_STAT.Onstage)
            {
                ((Label)this.Controls.Find("lbl" + Controller_Number + "Position4", true)[0]).Text = "Stage:";
                ((Label)this.Controls.Find("lbl" + Controller_Number + "Position4", true)[0]).Visible = true;

                if (Robots[Controller_Number].Stage_Loc == RobotState.STAGE_LOC.Select)
                {
                    ((Label)this.Controls.Find("lbl" + Controller_Number + "Position4Value", true)[0]).Visible = false;
                }
                else
                {
                    ((Label)this.Controls.Find("lbl" + Controller_Number + "Position4Value", true)[0]).BackColor = System.Drawing.Color.Black;
                    ((Label)this.Controls.Find("lbl" + Controller_Number + "Position4Value", true)[0]).ForeColor = System.Drawing.Color.Yellow;
                    ((Label)this.Controls.Find("lbl" + Controller_Number + "Position4Value", true)[0]).Visible = true;
                    ((Label)this.Controls.Find("lbl" + Controller_Number + "Position4Value", true)[0]).Text = Robots[Controller_Number].Stage_Loc.ToString();
                }
            }
            else if (Robots[Controller_Number].Stage_Stat == RobotState.STAGE_STAT.Park ||
                Robots[Controller_Number].Stage_Stat == RobotState.STAGE_STAT.Elsewhere)
            {
                ((Label)this.Controls.Find("lbl" + Controller_Number + "Position4", true)[0]).Text = "Att:";
                ((Label)this.Controls.Find("lbl" + Controller_Number + "Position4", true)[0]).Visible = true;
                ((Label)this.Controls.Find("lbl" + Controller_Number + "Position4Value", true)[0]).Text = "..";
                ((Label)this.Controls.Find("lbl" + Controller_Number + "Position4Value", true)[0]).Visible = true;
                if (Robots[Controller_Number].Stage_Att == RobotState.STAGE_ATT.N)
                {
                    ((Label)this.Controls.Find("lbl" + Controller_Number + "Position4Value", true)[0]).BackColor = System.Drawing.Color.Red;
                    ((Label)this.Controls.Find("lbl" + Controller_Number + "Position4Value", true)[0]).ForeColor = System.Drawing.Color.Red;
                }
                else if (Robots[Controller_Number].Stage_Att == RobotState.STAGE_ATT.Y)
                {
                    ((Label)this.Controls.Find("lbl" + Controller_Number + "Position4Value", true)[0]).BackColor = System.Drawing.Color.Green;
                    ((Label)this.Controls.Find("lbl" + Controller_Number + "Position4Value", true)[0]).ForeColor = System.Drawing.Color.Green;
                }
                else if (Robots[Controller_Number].Stage_Att == RobotState.STAGE_ATT.Select)
                {
                    ((Label)this.Controls.Find("lbl" + Controller_Number + "Position4Value", true)[0]).Visible = false;
                }
            }
            else
            {
                ((Label)this.Controls.Find("lbl" + Controller_Number + "Position4", true)[0]).Visible = false;
                ((Label)this.Controls.Find("lbl" + Controller_Number + "Position4Value", true)[0]).Visible = false;
            }

            ((Label)this.Controls.Find("lbl" + Controller_Number + "Position5", true)[0]).Text = "Harm:";
            ((Label)this.Controls.Find("lbl" + Controller_Number + "Position5", true)[0]).Visible = true;
            if (Robots[Controller_Number].Harm == 10 || Robots[Controller_Number].Harm == 9)
            {
                ((Label)this.Controls.Find("lbl" + Controller_Number + "Position5Value", true)[0]).Visible = false;
            }
            else
            {
                ((Label)this.Controls.Find("lbl" + Controller_Number + "Position5Value", true)[0]).Text = Robots[Controller_Number].Harm.ToString();
                ((Label)this.Controls.Find("lbl" + Controller_Number + "Position5Value", true)[0]).BackColor = System.Drawing.Color.Black;
                ((Label)this.Controls.Find("lbl" + Controller_Number + "Position5Value", true)[0]).ForeColor = System.Drawing.Color.Yellow;
                ((Label)this.Controls.Find("lbl" + Controller_Number + "Position5Value", true)[0]).Visible = true;
            }


            ((Label)this.Controls.Find("lbl" + Controller_Number + "Position6", true)[0]).Text = "Strat:";
            ((Label)this.Controls.Find("lbl" + Controller_Number + "Position6", true)[0]).Visible = true;
            ((Label)this.Controls.Find("lbl" + Controller_Number + "Position6Value", true)[0]).Text = Robots[Controller_Number].App_Strat.ToString();
            if (Robots[Controller_Number].App_Strat == RobotState.APP_STRAT.Select)
            {
                ((Label)this.Controls.Find("lbl" + Controller_Number + "Position6Value", true)[0]).Visible = false;
            }
            else
            {
                ((Label)this.Controls.Find("lbl" + Controller_Number + "Position6Value", true)[0]).Visible = true;
            }

            ((Label)this.Controls.Find("lbl" + Controller_Number + "Position7", true)[0]).Text = "Spotlit:";
            ((Label)this.Controls.Find("lbl" + Controller_Number + "Position7", true)[0]).Visible = true;
            if (Robots[Controller_Number].Lit == RobotState.LIT.Y)
            {
                ((Label)this.Controls.Find("lbl" + Controller_Number + "Position7Value", true)[0]).BackColor = System.Drawing.Color.Green;
                ((Label)this.Controls.Find("lbl" + Controller_Number + "Position7Value", true)[0]).ForeColor = System.Drawing.Color.Green;

            }
            else if (Robots[Controller_Number].Lit == RobotState.LIT.N)
            {
                ((Label)this.Controls.Find("lbl" + Controller_Number + "Position7Value", true)[0]).BackColor = System.Drawing.Color.Red;
                ((Label)this.Controls.Find("lbl" + Controller_Number + "Position7Value", true)[0]).ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                ((Label)this.Controls.Find("lbl" + Controller_Number + "Position7Value", true)[0]).BackColor = System.Drawing.Color.Yellow;
                ((Label)this.Controls.Find("lbl" + Controller_Number + "Position7Value", true)[0]).ForeColor = System.Drawing.Color.Yellow;
            }
            ((Label)this.Controls.Find("lbl" + Controller_Number + "Position7Value", true)[0]).Text = ".";
            ((Label)this.Controls.Find("lbl" + Controller_Number + "Position7Value", true)[0]).Visible = true;

            ((Label)this.Controls.Find("lbl" + Controller_Number + "Position8", true)[0]).Text = "Def:";
            ((Label)this.Controls.Find("lbl" + Controller_Number + "Position8", true)[0]).Visible = true;
            if (Robots[Controller_Number].Def_Rat == 10 || Robots[Controller_Number].Def_Rat == 9)
            {
                ((Label)this.Controls.Find("lbl" + Controller_Number + "Position8Value", true)[0]).Visible = false;
            }
            else
            {
                ((Label)this.Controls.Find("lbl" + Controller_Number + "Position8Value", true)[0]).Text = Robots[Controller_Number].Def_Rat.ToString();
                ((Label)this.Controls.Find("lbl" + Controller_Number + "Position8Value", true)[0]).Visible = true;
            }

            ((Label)this.Controls.Find("lbl" + Controller_Number + "Position9", true)[0]).Text = "Mics:";
            ((Label)this.Controls.Find("lbl" + Controller_Number + "Position9", true)[0]).Visible = true;
            if (Robots[Controller_Number].Mic == 10 || Robots[Controller_Number].Mic == 9)
            {
                ((Label)this.Controls.Find("lbl" + Controller_Number + "Position9Value", true)[0]).Visible = false;
            }
            else
            {
                ((Label)this.Controls.Find("lbl" + Controller_Number + "Position9Value", true)[0]).Text = Robots[Controller_Number].Mic.ToString();
                ((Label)this.Controls.Find("lbl" + Controller_Number + "Position9Value", true)[0]).Visible = true;
            }


            ((Label)this.Controls.Find("lbl" + Controller_Number + "Position10", true)[0]).Text = "Avo:";
            ((Label)this.Controls.Find("lbl" + Controller_Number + "Position10", true)[0]).Visible = true;
            if (Robots[Controller_Number].Avo_Rat == 10 || Robots[Controller_Number].Avo_Rat == 9)
            {
                ((Label)this.Controls.Find("lbl" + Controller_Number + "Position10Value", true)[0]).Visible = false;
            }
            else
            {
                ((Label)this.Controls.Find("lbl" + Controller_Number + "Position10Value", true)[0]).Text = Robots[Controller_Number].Avo_Rat.ToString();
                ((Label)this.Controls.Find("lbl" + Controller_Number + "Position10Value", true)[0]).Visible = true;
            }


            ((Label)this.Controls.Find("lbl" + Controller_Number + "Position11", true)[0]).Visible = true;
            ((Label)this.Controls.Find("lbl" + Controller_Number + "Position11", true)[0]).Text = Robots[Controller_Number].match_event.ToString();
        }
    }
}