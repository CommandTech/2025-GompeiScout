using ScoutingCodeRedo.Properties;
using ScoutingCodeRedo.Static;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoutingCodeRedo.Dynamic
{
    class DynamicResponses
    {
        public void ReadStick(GamePad[] gpArray, int controllerNumber)
        {
            GamePad gamepad = gpArray[controllerNumber];

            var robot = BackgroundCode.Robots[controllerNumber];

            if (robot.ClimbT_StopWatch == null) robot.ClimbT_StopWatch = new Stopwatch();
            if (robot.DefTime_StopWatch == null) robot.DefTime_StopWatch = new Stopwatch();

            if (!robot.NoSho && robot.GetScouterName() != RobotState.SCOUTER_NAME.Select_Name)
            {
                //***********************************
                //AUTO MODE
                //***********************************
                if (robot.Current_Mode == RobotState.ROBOT_MODE.Auto)
                {
                    //Cycle Leave
                    if (gamepad.BackButton_Press)
                    {
                        robot.CycleLeave(RobotState.CYCLE_DIRECTION.Up);
                    }

                    //Cycle Starting Location
                    if (gamepad.LTHDown_Press && !gamepad.LeftTrigger_Down)
                    {
                        robot.CycleStart(RobotState.CYCLE_DIRECTION.Down);
                        if (robot.Starting_Location == RobotState.STARTING_LOC.C1 || robot.Starting_Location == RobotState.STARTING_LOC.C2 || robot.Starting_Location == RobotState.STARTING_LOC.C3)
                        {
                            robot.Near_Far = false;
                        }
                        else
                        {
                            robot.Near_Far = true;
                        }
                    }
                    else if (gamepad.LTHUp_Press && !gamepad.LeftTrigger_Down)
                    {
                        robot.CycleStart(RobotState.CYCLE_DIRECTION.Up);
                        if (robot.Starting_Location == RobotState.STARTING_LOC.C1 || robot.Starting_Location == RobotState.STARTING_LOC.C2 || robot.Starting_Location == RobotState.STARTING_LOC.C3)
                        {
                            robot.Near_Far = false;
                        }
                        else
                        {
                            robot.Near_Far = true;
                        }
                    }

                    //Acquire Coral/Algae from Station/Reef
                    if (gamepad.LeftButton_Press)
                    {
                        if (robot.Flag)
                        {
                            robot.AcqAlgaeR++;
                            robot.hasAlgae++;
                            robot.lastAlgaeAcqLoc = "Reef";
                        }
                        else
                        {
                            robot.AcqCoralS++;
                            robot.hasCoral++;
                            robot.lastCoralAcqLoc = "Station";
                        }
                    }
                    //Acquire Coral/Algae from Floor
                    if (gamepad.LeftTrigger_Press)
                    {
                        if (robot.Flag)
                        {
                            robot.AcqAlgaeF++;
                            robot.hasAlgae++;
                            robot.lastAlgaeAcqLoc = "Floor";
                        }
                        else
                        {
                            robot.AcqCoralF++;
                            robot.hasCoral++;
                            robot.lastCoralAcqLoc = "Floor";
                        }
                    }

                    //Deliveries
                    if (gamepad.DpadUp_Press)
                    {
                        if (robot.Flag)
                        {
                            robot.DelAlgaeN++;
                            robot.lastAlgaeLoc = "Net";
                            robot.TransactionCheck = true;
                        }
                        else
                        {
                            if (robot.totalCoralDeliveries == 0 && robot.hasCoral == 0)
                            {
                                robot.hasCoral++;
                            }
                            robot.totalCoralDeliveries++;
                            robot.DelCoralL4++;
                            robot.lastCoralLoc = "L4";
                            robot.TransactionCheck = true;
                        }
                    }
                    if (gamepad.DpadDown_Press)
                    {
                        if (robot.Flag)
                        {
                            robot.DelAlgaeP++;
                            robot.lastAlgaeLoc = "Processor";
                            robot.TransactionCheck = true;
                        }
                        else
                        {
                            if (robot.totalCoralDeliveries == 0 && robot.hasCoral == 0)
                            {
                                robot.hasCoral++;
                            }
                            robot.totalCoralDeliveries++;
                            robot.DelCoralL2++;
                            robot.lastCoralLoc = "L2";
                            robot.TransactionCheck = true;
                        }
                    }
                    if (gamepad.DpadRight_Press)
                    {
                        if (robot.Flag)
                        {
                            robot.DelAlgaeF++;
                            robot.lastAlgaeLoc = "Floor";
                            robot.TransactionCheck = true;
                        }
                        else
                        {
                            if (robot.totalCoralDeliveries == 0 && robot.hasCoral == 0)
                            {
                                robot.hasCoral++;
                            }
                            robot.totalCoralDeliveries++;
                            robot.DelCoralL3++;
                            robot.lastCoralLoc = "L3";
                            robot.TransactionCheck = true;
                        }
                    }
                    if (gamepad.DpadLeft_Press)
                    {
                        if (robot.Flag)
                        {
                            robot.DelAlgaeF++;
                            robot.lastAlgaeLoc = "Floor";
                            robot.TransactionCheck = true;
                        }
                        else
                        {
                            if (robot.totalCoralDeliveries == 0 && robot.hasCoral == 0)
                            {
                                robot.hasCoral++;
                            }
                            robot.totalCoralDeliveries++;
                            robot.DelCoralL1++;
                            robot.lastCoralLoc = "L1";
                            robot.TransactionCheck = true;
                        }
                    }

                    if (gamepad.XButton_Press || gamepad.BButton_Press)
                    {
                        if (robot.totalCoralDeliveries == 0 && robot.hasCoral == 0)
                        {
                            robot.hasCoral++;
                        }
                        robot.totalCoralDeliveries++;
                        robot.DelCoralF++;
                        robot.lastCoralLoc = "Floor";
                        robot.TransactionCheck = true;
                    }
                    if (gamepad.YButton_Press)
                    {
                        robot.Near_Far = true;
                    }
                    if (gamepad.AButton_Press)
                    {
                        robot.Near_Far = false;
                    }
                }
                //***********************************
                //TELEOP MODE
                //***********************************
                else if (robot.Current_Mode == RobotState.ROBOT_MODE.Teleop)
                {
                    //Acquire Coral/Algae from Station/Reef
                    if (gamepad.LeftButton_Press)
                    {
                        if (robot.Flag)
                        {
                            robot.AcqAlgaeR++;
                            robot.hasAlgae++;
                            robot.lastAlgaeAcqLoc = "Reef";
                        }
                        else
                        {
                            robot.AcqCoralS++;
                            robot.hasCoral++;
                            robot.lastCoralAcqLoc = "Station";
                        }
                    }
                    //Acquire Coral/Algae from Floor
                    if (gamepad.LeftTrigger_Press)
                    {
                        if (robot.Flag)
                        {
                            robot.AcqAlgaeF++;
                            robot.hasAlgae++;
                            robot.lastAlgaeAcqLoc = "Floor";
                        }
                        else
                        {
                            robot.AcqCoralF++;
                            robot.hasCoral++;
                            robot.lastCoralAcqLoc = "Floor";
                        }
                    }

                    //Deliveries
                    if (gamepad.DpadUp_Press)
                    {
                        if (robot.Flag)
                        {
                            robot.DelAlgaeN++;
                            robot.lastAlgaeLoc = "Net";
                            robot.TransactionCheck = true;
                        }
                        else
                        {
                            if (robot.totalCoralDeliveries == 0 && robot.hasCoral == 0)
                            {
                                robot.hasCoral++;
                            }
                            robot.totalCoralDeliveries++;
                            robot.DelCoralL4++;
                            robot.lastCoralLoc = "L4";
                            robot.TransactionCheck = true;
                        }
                    }
                    if (gamepad.DpadDown_Press)
                    {
                        if (robot.Flag)
                        {
                            robot.DelAlgaeP++;
                            robot.lastAlgaeLoc = "Processor";
                            robot.TransactionCheck = true;
                        }
                        else
                        {
                            if (robot.totalCoralDeliveries == 0 && robot.hasCoral == 0)
                            {
                                robot.hasCoral++;
                            }
                            robot.totalCoralDeliveries++;
                            robot.DelCoralL2++;
                            robot.lastCoralLoc = "L2";
                            robot.TransactionCheck = true;
                        }
                    }
                    if (gamepad.DpadRight_Press)
                    {
                        if (robot.Flag)
                        {
                            robot.DelAlgaeF++;
                            robot.lastAlgaeLoc = "Floor";
                            robot.TransactionCheck = true;
                        }
                        else
                        {
                            if (robot.totalCoralDeliveries == 0 && robot.hasCoral == 0)
                            {
                                robot.hasCoral++;
                            }
                            robot.totalCoralDeliveries++;
                            robot.DelCoralL3++;
                            robot.lastCoralLoc = "L3";
                            robot.TransactionCheck = true;
                        }
                    }
                    if (gamepad.DpadLeft_Press)
                    {
                        if (robot.Flag)
                        {
                            robot.DelAlgaeF++;
                            robot.lastAlgaeLoc = "Floor";
                            robot.TransactionCheck = true;
                        }
                        else
                        {
                            if (robot.totalCoralDeliveries == 0 && robot.hasCoral == 0)
                            {
                                robot.hasCoral++;
                            }
                            robot.totalCoralDeliveries++;
                            robot.DelCoralL1++;
                            robot.lastCoralLoc = "L1";
                            robot.TransactionCheck = true;
                        }
                    }

                    if (gamepad.XButton_Press || gamepad.BButton_Press)
                    {
                        if (robot.totalCoralDeliveries == 0 && robot.hasCoral == 0)
                        {
                            robot.hasCoral++;
                        }
                        robot.totalCoralDeliveries++;
                        robot.DelCoralF++;
                        robot.lastCoralLoc = "Floor";
                        robot.TransactionCheck = true;
                    }
                    if (gamepad.YButton_Press)
                    {
                        robot.Near_Far = true;
                    }
                    if (gamepad.AButton_Press)
                    {
                        robot.Near_Far = false;
                    }
                }
                //***********************************
                //Defense MODE
                //***********************************
                else if (robot.Current_Mode == RobotState.ROBOT_MODE.Defense)
                {
                    //Acquire Coral/Algae from Station/Reef
                    if (gamepad.LeftButton_Press)
                    {
                        if (robot.Flag)
                        {
                            robot.AcqAlgaeR++;
                            robot.hasAlgae++;
                            robot.lastAlgaeAcqLoc = "Reef";
                        }
                        else
                        {
                            robot.AcqCoralS++;
                            robot.hasCoral++;
                            robot.lastCoralAcqLoc = "Station";
                        }
                    }
                    //Acquire Coral/Algae from Floor
                    if (gamepad.LeftTrigger_Press)
                    {
                        if (robot.Flag)
                        {
                            robot.AcqAlgaeF++;
                            robot.hasAlgae++;
                            robot.lastAlgaeAcqLoc = "Floor";
                        }
                        else
                        {
                            robot.AcqCoralF++;
                            robot.hasCoral++;
                            robot.lastCoralAcqLoc = "Floor";
                        }
                    }

                    //Deliveries
                    if (gamepad.DpadUp_Press)
                    {
                        if (robot.Flag)
                        {
                            robot.DelAlgaeN++;
                            robot.lastAlgaeLoc = "Net";
                            robot.TransactionCheck = true;
                        }
                        else
                        {
                            if (robot.totalCoralDeliveries == 0 && robot.hasCoral == 0)
                            {
                                robot.hasCoral++;
                            }
                            robot.totalCoralDeliveries++;
                            robot.DelCoralF++;
                            robot.lastCoralLoc = "Floor";
                            robot.TransactionCheck = true;
                        }
                    }
                    if (gamepad.DpadDown_Press)
                    {
                        if (robot.Flag)
                        {
                            robot.DelAlgaeP++;
                            robot.lastAlgaeLoc = "Processor";
                            robot.TransactionCheck = true;
                        }
                        else
                        {
                            if (robot.totalCoralDeliveries == 0 && robot.hasCoral == 0)
                            {
                                robot.hasCoral++;
                            }
                            robot.totalCoralDeliveries++;
                            robot.DelCoralF++;
                            robot.lastCoralLoc = "Floor";
                            robot.TransactionCheck = true;
                        }
                    }
                    if (gamepad.DpadLeft_Press || gamepad.DpadRight_Press)
                    {
                        if (robot.Flag)
                        {
                            robot.DelAlgaeF++;
                            robot.lastAlgaeLoc = "Floor";
                            robot.TransactionCheck = true;
                        }
                        else
                        {
                            if (robot.totalCoralDeliveries == 0 && robot.hasCoral == 0)
                            {
                                robot.hasCoral++;
                            }
                            robot.totalCoralDeliveries++;
                            robot.DelCoralF++;
                            robot.lastCoralLoc = "Floor";
                            robot.TransactionCheck = true;
                        }
                    }

                    if (gamepad.XButton_Press || gamepad.BButton_Press)
                    {
                        if (robot.totalCoralDeliveries == 0 && robot.hasCoral == 0)
                        {
                            robot.hasCoral++;
                        }
                        robot.totalCoralDeliveries++;
                        robot.DelCoralF++;
                        robot.lastCoralLoc = "Floor";
                        robot.TransactionCheck = true;
                    }
                    if (gamepad.YButton_Press)
                    {
                        robot.Near_Far = true;
                    }
                    if (gamepad.AButton_Press)
                    {
                        robot.Near_Far = false;
                    }
                }
                //***********************************
                //Surfacing MODE
                //***********************************
                else if (robot.Current_Mode == RobotState.ROBOT_MODE.Surfacing)
                {
                    //Stop / Resume Climb Time
                    if (gamepad.BackButton_Press)
                    {
                        if (robot.ClimbT_StopWatch_running)
                        {
                            robot.ClimbT_StopWatch.Stop();
                            robot.ClimbT_StopWatch_running = false;
                            robot.ClimbT = robot.ClimbT_StopWatch.Elapsed;
                        }
                        else
                        {
                            robot.ClimbT_StopWatch.Start();
                            robot.ClimbT_StopWatch_running = true;
                            robot.ClimbT = robot.ClimbT_StopWatch.Elapsed;
                        }
                    }
                    //Reset Climb Time
                    if (gamepad.LeftButton_Press)
                    {
                        robot.ClimbT = TimeSpan.Zero;
                        robot.ClimbT_StopWatch.Reset();
                        robot.ClimbT_StopWatch_running = false;
                    }

                    //Cycle End State
                    if (gamepad.YButton_Press)
                    {
                        robot.CycleState(RobotState.CYCLE_DIRECTION.Up);
                    }
                    //Cycle Robot Strat
                    if (gamepad.AButton_Press)
                    {
                        robot.CycleStrat(RobotState.CYCLE_DIRECTION.Up);
                    }
                    //Deliver Algae to the Floor or Net
                    if (gamepad.BButton_Press)
                    {
                        if (robot.Flag)
                        {
                            robot.DelAlgaeF++;
                            robot.lastAlgaeLoc = "Floor";
                            robot.TransactionCheck = true;
                        }
                        else
                        {
                            if (robot.totalCoralDeliveries == 0 && robot.hasCoral == 0)
                            {
                                robot.hasCoral++;
                            }
                            robot.DelAlgaeN++;
                            robot.lastAlgaeLoc = "Net";
                            robot.TransactionCheck = true;
                        }
                    }

                    //Cycle Cage Attempt
                    if (gamepad.DpadUp_Press && !robot.Flag)
                    {
                        robot.CycleCage(RobotState.CYCLE_DIRECTION.Up);
                    }
                    if (gamepad.DpadDown_Press)
                    {
                        if (robot.Flag)
                        {
                            //Cycle Algae Intake Rating
                            robot.Alg_Rat++;
                            if (robot.Alg_Rat > 5)
                            {
                                robot.Alg_Rat = 0;
                            }
                        }
                        else
                        {
                            //Cycle Coral Intake Rating
                            robot.Cor_Rat++;
                            if (robot.Cor_Rat > 5)
                            {
                                robot.Cor_Rat = 0;
                            }
                        }
                    }
                    if (gamepad.DpadRight_Press)
                    {
                        //Cycle Driver Rating
                        if (robot.Flag)
                        {
                            robot.Avo_Rat++;
                            if (robot.Avo_Rat > 5)
                            {
                                robot.Avo_Rat = 0;
                            }
                        }
                        //Cycle Avoidance Rating
                        else
                        {
                            robot.Dri_Rat++;
                            if (robot.Dri_Rat > 5)
                            {
                                robot.Dri_Rat = 0;
                            }
                        }
                    }
                    if (gamepad.DpadLeft_Press)
                    {
                        //Cycle Defense Effectiveness
                        if (robot.Flag)
                        {
                            if (robot.Def_Rat != 9 && robot.Def_Rat != 0)
                            {
                                robot.Def_Eff++;
                                if (robot.Def_Eff > 5)
                                {
                                    robot.Def_Eff = 0;
                                }
                            }
                            else
                            {
                                robot.Def_Eff = 0;
                            }
                        }
                        //Cycle Defense Rating
                        else
                        {
                            robot.Def_Rat++;
                            if (robot.Def_Rat > 3)
                            {
                                robot.Def_Rat = 0;
                            }
                        }
                    }
                }
                //***********************************
                //Any mode
                //***********************************

                // Changing modes
                //Leaving Auto
                if (gamepad.StartButton_Press && robot.Current_Mode == RobotState.ROBOT_MODE.Auto)
                {
                    robot.Desired_Mode = RobotState.ROBOT_MODE.Surfacing;
                    robot.Current_Mode = RobotState.ROBOT_MODE.Teleop;
                    robot.AUTO = false;
                    TransactToDatabase(robot, "EndAuto", false);
                }
                //Leaving Teleop into Surfacing
                else if (gamepad.StartButton_Press && robot.Current_Mode == RobotState.ROBOT_MODE.Teleop)

                {
                    robot.Desired_Mode = RobotState.ROBOT_MODE.Teleop;
                    robot.Current_Mode = RobotState.ROBOT_MODE.Surfacing;

                    robot.ClimbT_StopWatch.Start();
                    robot.ClimbT_StopWatch_running = true;
                    robot.ClimbT = robot.ClimbT_StopWatch.Elapsed;
                }
                //Leaving Surfacing into Teleop
                else if (gamepad.StartButton_Press && robot.Current_Mode == RobotState.ROBOT_MODE.Surfacing)
                {
                    robot.Desired_Mode = RobotState.ROBOT_MODE.Surfacing;
                    robot.Current_Mode = RobotState.ROBOT_MODE.Teleop;

                    robot.ClimbT_StopWatch.Stop();
                    robot.ClimbT = robot.ClimbT_StopWatch.Elapsed;
                    robot.ClimbT_StopWatch_running = false;
                    robot.ClimbT_StopWatch.Reset();
                }
                //Leaving Defense into Surfacing
                else if (gamepad.StartButton_Press && robot.Current_Mode == RobotState.ROBOT_MODE.Defense)
                {
                    robot.Current_Mode = RobotState.ROBOT_MODE.Surfacing;
                    robot.Desired_Mode = RobotState.ROBOT_MODE.Defense;

                    TransactToDatabase(robot, "Defense", false);

                    robot.DefTime_StopWatch.Reset();

                    robot.ClimbT_StopWatch.Start();
                    robot.ClimbT = robot.ClimbT_StopWatch.Elapsed;
                    robot.ClimbT_StopWatch_running = true;
                }
                else if (gamepad.L3_Press)
                {
                    //Leaving previous mode into Defense
                    if (robot.Current_Mode != RobotState.ROBOT_MODE.Defense)
                    {
                        robot.Desired_Mode = RobotState.ROBOT_MODE.Teleop;
                        robot.Current_Mode = RobotState.ROBOT_MODE.Defense;

                        robot.ClimbT_StopWatch.Stop();
                        robot.ClimbT = robot.ClimbT_StopWatch.Elapsed;
                        robot.ClimbT_StopWatch_running = false;
                        robot.ClimbT_StopWatch.Reset();

                        robot.DefTime_StopWatch.Start();
                        robot.DefTime = robot.DefTime_StopWatch.Elapsed;
                        robot.DefTime_StopWatch_running = true;
                    }
                    else
                    {
                        robot.Current_Mode = RobotState.ROBOT_MODE.Teleop;
                        robot.Desired_Mode = RobotState.ROBOT_MODE.Defense;

                        robot.DefTime_StopWatch.Stop();
                        robot.DefTime = robot.DefTime_StopWatch.Elapsed;
                        robot.DefTime_StopWatch_running = false;

                        TransactToDatabase(robot, "Defense", false);

                        robot.DefTime_StopWatch.Reset();
                    }
                }

                if (gamepad.RightButton_Down)
                {
                    robot.Flag = true;
                }
                else
                {
                    robot.Flag = false;
                }

                if (robot.hasCoral > 1)
                {
                    robot.ScouterError += 1000;
                    robot.hasCoral = 1;
                }
                else if (robot.hasCoral < 0)
                {
                    robot.ScouterError += 10;
                    robot.hasCoral = 0;
                }
                if (robot.hasAlgae > 1)
                {
                    robot.ScouterError += 100;
                    robot.hasAlgae = 1;
                }
                else if (robot.hasAlgae < 0)
                {
                    robot.ScouterError += 1;
                    robot.hasAlgae = 0;
                }


                //2025 Transaction
                if (gamepad.RightTrigger_Press && robot.TransactionCheck)
                {
                    TransactToDatabase(robot, "Activities", false);
                }
                else if (gamepad.RightTrigger_Press)
                {
                    robot.ScouterError += 10000000000000;
                }
            }

            // Values if robot is NoSho
            else if (robot.NoSho)
            {
                
            }
        }
            
        public static void TransactToDatabase(RobotState controller, string recordType, bool isTest)
        {
            //if (controller.GetScouterName() != RobotState.SCOUTER_NAME.Select_Name && controller.TransactionCheck && controller.TeamName != null)
            if (controller.GetScouterName() != RobotState.SCOUTER_NAME.Select_Name)
            {
                switch (recordType)
                {
                    case ("EndAuto"):
                        BackgroundCode.activity_record.RecordType = recordType;
                        BackgroundCode.activity_record.Time = DateTime.Now;
                        BackgroundCode.activity_record.Team = BackgroundCode.Robots[controller.ScouterBox].TeamName;
                        BackgroundCode.activity_record.Match = Settings.Default.currentMatch;
                        BackgroundCode.activity_record.Mode = controller.Current_Mode.ToString();
                        BackgroundCode.activity_record.ScouterName = controller.GetScouterName().ToString();

                        BackgroundCode.activity_record.Match_event = "-";
                        BackgroundCode.activity_record.Leave = controller.GetLeave().ToString();
                        BackgroundCode.activity_record.Starting_Loc = controller.GetStart().ToString();
                        BackgroundCode.activity_record.Near_Far = controller.Near_Far;


                        if (BackgroundCode.Robots[controller.ScouterBox] == BackgroundCode.Robots[0])
                        {
                            BackgroundCode.activity_record.DriveSta = "red0";
                        }
                        else if (BackgroundCode.Robots[controller.ScouterBox] == BackgroundCode.Robots[1])
                        {
                            BackgroundCode.activity_record.DriveSta = "red1";
                        }
                        else if (BackgroundCode.Robots[controller.ScouterBox] == BackgroundCode.Robots[2])
                        {
                            BackgroundCode.activity_record.DriveSta = "red2";
                        }
                        else if (BackgroundCode.Robots[controller.ScouterBox] == BackgroundCode.Robots[3])
                        {
                            BackgroundCode.activity_record.DriveSta = "blue0";
                        }
                        else if (BackgroundCode.Robots[controller.ScouterBox] == BackgroundCode.Robots[4])
                        {
                            BackgroundCode.activity_record.DriveSta = "blue1";
                        }
                        else if (BackgroundCode.Robots[controller.ScouterBox] == BackgroundCode.Robots[5])
                        {
                            BackgroundCode.activity_record.DriveSta = "blue2";
                        }

                        controller.DefTimeDouble = controller.DefTime_StopWatch.Elapsed.TotalSeconds;
                        BackgroundCode.activity_record.DZTime = controller.DefTimeDouble;

                        if (controller.Leave == RobotState.LEAVE.Z)
                        {
                            controller.ScouterError += 10000;
                        }
                        if (controller.Starting_Location == RobotState.STARTING_LOC.Select)
                        {
                            controller.ScouterError += 100000;
                        }
                        BackgroundCode.activity_record.ScouterError = controller.ScouterError;

                        BackgroundCode.activity_record.AcqAlgaeF = controller.AcqAlgaeF;
                        BackgroundCode.activity_record.AcqAlgaeR = controller.AcqAlgaeR;
                        BackgroundCode.activity_record.AcqCoralS = controller.AcqCoralS;
                        BackgroundCode.activity_record.AcqCoralF = controller.AcqCoralF;

                        BackgroundCode.activity_record.DelAlgaeF = controller.DelAlgaeF;
                        BackgroundCode.activity_record.DelAlgaeN = controller.DelAlgaeN;
                        BackgroundCode.activity_record.DelAlgaeP = controller.DelAlgaeP;

                        BackgroundCode.activity_record.DelCoralF = controller.DelCoralF;
                        BackgroundCode.activity_record.DelCoralL1 = controller.DelCoralL1;
                        BackgroundCode.activity_record.DelCoralL2 = controller.DelCoralL2;
                        BackgroundCode.activity_record.DelCoralL3 = controller.DelCoralL3;
                        BackgroundCode.activity_record.DelCoralL4 = controller.DelCoralL4;

                        BackgroundCode.activity_record.CageAttept = "-";
                        BackgroundCode.activity_record.EndState = "-";
                        BackgroundCode.activity_record.ClimbT = 0;

                        BackgroundCode.activity_record.Strategy = "-";
                        BackgroundCode.activity_record.Defense = 9;
                        BackgroundCode.activity_record.DefenseValue = 9;
                        BackgroundCode.activity_record.DriveRate = 9;
                        BackgroundCode.activity_record.CoralRate = 9;
                        BackgroundCode.activity_record.AlgaeRate = 9;
                        BackgroundCode.activity_record.Avoidance = 9;

                        BackgroundCode.activity_record.SelectedCage = "-";
                        BackgroundCode.activity_record.RedRight = Settings.Default.redRight;

                        //Save Record to the database
                        BackgroundCode.seasonframework.ActivitySet.Add(BackgroundCode.activity_record);
                        BackgroundCode.seasonframework.SaveChanges();

                        if (controller.hasCoral == 1 && controller.lastCoralLoc != " ")
                        {
                            controller.hasCoral = 0;
                            controller.lastCoralLoc = " ";
                            controller.lastCoralAcqLoc = " ";
                        }
                        if (controller.hasAlgae == 1 && controller.lastAlgaeLoc != " ")
                        {
                            controller.hasAlgae = 0;
                            controller.lastAlgaeLoc = " ";
                            controller.lastAlgaeAcqLoc = " ";
                        }
                        controller.TransactionCheck = false;
                        break;
                    case ("Activities"):
                        BackgroundCode.activity_record.RecordType = recordType;
                        BackgroundCode.activity_record.Time = DateTime.Now;
                        BackgroundCode.activity_record.Team = BackgroundCode.Robots[controller.ScouterBox].TeamName;
                        BackgroundCode.activity_record.Match = Settings.Default.currentMatch;
                        BackgroundCode.activity_record.Mode = controller.Current_Mode.ToString();
                        BackgroundCode.activity_record.ScouterName = controller.GetScouterName().ToString();

                        BackgroundCode.activity_record.Match_event = "-";
                        BackgroundCode.activity_record.Leave = "-";
                        BackgroundCode.activity_record.Starting_Loc = "-";
                        BackgroundCode.activity_record.Near_Far = controller.Near_Far;


                        if (BackgroundCode.Robots[controller.ScouterBox] == BackgroundCode.Robots[0])
                        {
                            BackgroundCode.activity_record.DriveSta = "red0";
                        }
                        else if (BackgroundCode.Robots[controller.ScouterBox] == BackgroundCode.Robots[1])
                        {
                            BackgroundCode.activity_record.DriveSta = "red1";
                        }
                        else if (BackgroundCode.Robots[controller.ScouterBox] == BackgroundCode.Robots[2])
                        {
                            BackgroundCode.activity_record.DriveSta = "red2";
                        }
                        else if (BackgroundCode.Robots[controller.ScouterBox] == BackgroundCode.Robots[3])
                        {
                            BackgroundCode.activity_record.DriveSta = "blue0";
                        }
                        else if (BackgroundCode.Robots[controller.ScouterBox] == BackgroundCode.Robots[4])
                        {
                            BackgroundCode.activity_record.DriveSta = "blue1";
                        }
                        else if (BackgroundCode.Robots[controller.ScouterBox] == BackgroundCode.Robots[5])
                        {
                            BackgroundCode.activity_record.DriveSta = "blue2";
                        }

                        controller.DefTimeDouble = controller.DefTime_StopWatch.Elapsed.TotalSeconds;
                        BackgroundCode.activity_record.DZTime = controller.DefTimeDouble;


                        BackgroundCode.activity_record.ScouterError = controller.ScouterError;

                        BackgroundCode.activity_record.AcqAlgaeF = controller.AcqAlgaeF;
                        BackgroundCode.activity_record.AcqAlgaeR = controller.AcqAlgaeR;
                        BackgroundCode.activity_record.AcqCoralS = controller.AcqCoralS;
                        BackgroundCode.activity_record.AcqCoralF = controller.AcqCoralF;

                        BackgroundCode.activity_record.DelAlgaeF = controller.DelAlgaeF;
                        BackgroundCode.activity_record.DelAlgaeN = controller.DelAlgaeN;
                        BackgroundCode.activity_record.DelAlgaeP = controller.DelAlgaeP;

                        BackgroundCode.activity_record.DelCoralF = controller.DelCoralF;
                        BackgroundCode.activity_record.DelCoralL1 = controller.DelCoralL1;
                        BackgroundCode.activity_record.DelCoralL2 = controller.DelCoralL2;
                        BackgroundCode.activity_record.DelCoralL3 = controller.DelCoralL3;
                        BackgroundCode.activity_record.DelCoralL4 = controller.DelCoralL4;

                        BackgroundCode.activity_record.CageAttept = "-";
                        BackgroundCode.activity_record.EndState = "-";
                        BackgroundCode.activity_record.ClimbT = 0;

                        BackgroundCode.activity_record.Strategy = "-";
                        BackgroundCode.activity_record.Defense = 9;
                        BackgroundCode.activity_record.DefenseValue = 9;
                        BackgroundCode.activity_record.DriveRate = 9;
                        BackgroundCode.activity_record.CoralRate = 9;
                        BackgroundCode.activity_record.AlgaeRate = 9;
                        BackgroundCode.activity_record.Avoidance = 9;

                        BackgroundCode.activity_record.SelectedCage = "-";
                        BackgroundCode.activity_record.RedRight = Settings.Default.redRight;

                        //Save Record to the database
                        BackgroundCode.seasonframework.ActivitySet.Add(BackgroundCode.activity_record);
                        BackgroundCode.seasonframework.SaveChanges();

                        if (controller.hasCoral == 1 && controller.lastCoralLoc != " ")
                        {
                            controller.hasCoral = 0;
                            controller.lastCoralLoc = " ";
                            controller.lastCoralAcqLoc = " ";
                        }
                        if (controller.hasAlgae == 1 && controller.lastAlgaeLoc != " ")
                        {
                            controller.hasAlgae = 0;
                            controller.lastAlgaeLoc = " ";
                            controller.lastAlgaeAcqLoc = " ";
                        }
                        controller.TransactionCheck = false;
                        break;
                    case ("EndMatch"):
                        BackgroundCode.activity_record.RecordType = recordType;
                        BackgroundCode.activity_record.Time = DateTime.Now;
                        BackgroundCode.activity_record.Team = BackgroundCode.Robots[controller.ScouterBox].TeamName;
                        BackgroundCode.activity_record.Match = Settings.Default.currentMatch;
                        BackgroundCode.activity_record.Mode = controller.Current_Mode.ToString();
                        BackgroundCode.activity_record.ScouterName = controller.GetScouterName().ToString();

                        BackgroundCode.activity_record.Match_event = "-";
                        BackgroundCode.activity_record.Leave = "-";
                        BackgroundCode.activity_record.Starting_Loc = "-";
                        BackgroundCode.activity_record.Near_Far = controller.Near_Far;


                        if (BackgroundCode.Robots[controller.ScouterBox] == BackgroundCode.Robots[0])
                        {
                            BackgroundCode.activity_record.DriveSta = "red0";
                        }
                        else if (BackgroundCode.Robots[controller.ScouterBox] == BackgroundCode.Robots[1])
                        {
                            BackgroundCode.activity_record.DriveSta = "red1";
                        }
                        else if (BackgroundCode.Robots[controller.ScouterBox] == BackgroundCode.Robots[2])
                        {
                            BackgroundCode.activity_record.DriveSta = "red2";
                        }
                        else if (BackgroundCode.Robots[controller.ScouterBox] == BackgroundCode.Robots[3])
                        {
                            BackgroundCode.activity_record.DriveSta = "blue0";
                        }
                        else if (BackgroundCode.Robots[controller.ScouterBox] == BackgroundCode.Robots[4])
                        {
                            BackgroundCode.activity_record.DriveSta = "blue1";
                        }
                        else if (BackgroundCode.Robots[controller.ScouterBox] == BackgroundCode.Robots[5])
                        {
                            BackgroundCode.activity_record.DriveSta = "blue2";
                        }

                        controller.DefTimeDouble = controller.DefTime_StopWatch.Elapsed.TotalSeconds;
                        BackgroundCode.activity_record.DZTime = controller.DefTimeDouble;

                        BackgroundCode.activity_record.AcqAlgaeF = controller.AcqAlgaeF;
                        BackgroundCode.activity_record.AcqAlgaeR = controller.AcqAlgaeR;
                        BackgroundCode.activity_record.AcqCoralS = controller.AcqCoralS;
                        BackgroundCode.activity_record.AcqCoralF = controller.AcqCoralF;

                        BackgroundCode.activity_record.DelAlgaeF = controller.DelAlgaeF;
                        BackgroundCode.activity_record.DelAlgaeN = controller.DelAlgaeN;
                        BackgroundCode.activity_record.DelAlgaeP = controller.DelAlgaeP;

                        BackgroundCode.activity_record.DelCoralF = controller.DelCoralF;
                        BackgroundCode.activity_record.DelCoralL1 = controller.DelCoralL1;
                        BackgroundCode.activity_record.DelCoralL2 = controller.DelCoralL2;
                        BackgroundCode.activity_record.DelCoralL3 = controller.DelCoralL3;
                        BackgroundCode.activity_record.DelCoralL4 = controller.DelCoralL4;

                        BackgroundCode.activity_record.CageAttept = controller.GetAttempt().ToString();
                        BackgroundCode.activity_record.EndState = controller.GetState().ToString();

                        controller.ClimbTDouble = controller.ClimbT_StopWatch.Elapsed.TotalSeconds;
                        BackgroundCode.activity_record.ClimbT = controller.ClimbTDouble;

                        BackgroundCode.activity_record.Strategy = controller.GetStrat().ToString();
                        BackgroundCode.activity_record.DefenseValue = controller.Def_Eff;
                        BackgroundCode.activity_record.Defense = controller.Def_Rat;
                        if (controller.Def_Rat == 0 || controller.Def_Rat == 9) {
                            BackgroundCode.activity_record.DefenseValue = 0;
                            controller.Def_Eff = 0;
                        }
                        BackgroundCode.activity_record.DriveRate = controller.Dri_Rat;
                        BackgroundCode.activity_record.CoralRate = controller.Cor_Rat;
                        BackgroundCode.activity_record.AlgaeRate = controller.Alg_Rat;
                        BackgroundCode.activity_record.Avoidance = controller.Avo_Rat;


                        if (controller.Def_Rat == 9)
                        {
                            controller.ScouterError += 10000000;
                        }
                        if (controller.Def_Eff == 9)
                        {
                            controller.ScouterError += 100000000;
                        }
                        if (controller.Avo_Rat == 9)
                        {
                            controller.ScouterError += 1000000000;
                        }
                        if (controller.Dri_Rat == 9)
                        {
                            controller.ScouterError += 1000000000000;
                        }
                        if (controller.Alg_Rat == 9)
                        {
                            controller.ScouterError += 10000000000;
                        }
                        if (controller.Cor_Rat == 9)
                        {
                            controller.ScouterError += 100000000000;
                        }
                        BackgroundCode.activity_record.ScouterError = controller.ScouterError;

                        BackgroundCode.activity_record.SelectedCage = controller.Selected_Cage;
                        BackgroundCode.activity_record.RedRight = Settings.Default.redRight;

                        //Save Record to the database
                        BackgroundCode.seasonframework.ActivitySet.Add(BackgroundCode.activity_record);
                        BackgroundCode.seasonframework.SaveChanges();

                        if (controller.hasCoral == 1 && controller.lastCoralLoc != " ")
                        {
                            controller.hasCoral = 0;
                            controller.lastCoralLoc = " ";
                            controller.lastCoralAcqLoc = " ";
                        }
                        if (controller.hasAlgae == 1 && controller.lastAlgaeLoc != " ")
                        {
                            controller.hasAlgae = 0;
                            controller.lastAlgaeLoc = " ";
                            controller.lastAlgaeAcqLoc = " ";
                        }
                        controller.TransactionCheck = false;
                        break;
                    case ("Match_Event"):
                        BackgroundCode.activity_record.RecordType = recordType;
                        BackgroundCode.activity_record.Time = DateTime.Now;
                        BackgroundCode.activity_record.Team = BackgroundCode.Robots[controller.ScouterBox].TeamName;
                        BackgroundCode.activity_record.Match = Settings.Default.currentMatch;
                        BackgroundCode.activity_record.Mode = controller.Current_Mode.ToString();
                        BackgroundCode.activity_record.ScouterName = controller.GetScouterName().ToString();

                        BackgroundCode.activity_record.Match_event = controller.Match_event.ToString();
                        BackgroundCode.activity_record.Leave = "-";
                        BackgroundCode.activity_record.Starting_Loc = "-";
                        BackgroundCode.activity_record.Near_Far = false;


                        if (BackgroundCode.Robots[controller.ScouterBox] == BackgroundCode.Robots[0])
                        {
                            BackgroundCode.activity_record.DriveSta = "red0";
                        }
                        else if (BackgroundCode.Robots[controller.ScouterBox] == BackgroundCode.Robots[1])
                        {
                            BackgroundCode.activity_record.DriveSta = "red1";
                        }
                        else if (BackgroundCode.Robots[controller.ScouterBox] == BackgroundCode.Robots[2])
                        {
                            BackgroundCode.activity_record.DriveSta = "red2";
                        }
                        else if (BackgroundCode.Robots[controller.ScouterBox] == BackgroundCode.Robots[3])
                        {
                            BackgroundCode.activity_record.DriveSta = "blue0";
                        }
                        else if (BackgroundCode.Robots[controller.ScouterBox] == BackgroundCode.Robots[4])
                        {
                            BackgroundCode.activity_record.DriveSta = "blue1";
                        }
                        else if (BackgroundCode.Robots[controller.ScouterBox] == BackgroundCode.Robots[5])
                        {
                            BackgroundCode.activity_record.DriveSta = "blue2";
                        }

                        BackgroundCode.activity_record.DZTime = '-';


                        BackgroundCode.activity_record.ScouterError = controller.ScouterError;

                        BackgroundCode.activity_record.AcqAlgaeF = '-';
                        BackgroundCode.activity_record.AcqAlgaeR = '-';
                        BackgroundCode.activity_record.AcqCoralS = '-';
                        BackgroundCode.activity_record.AcqCoralF = '-';

                        BackgroundCode.activity_record.DelAlgaeF = '-';
                        BackgroundCode.activity_record.DelAlgaeN = '-';
                        BackgroundCode.activity_record.DelAlgaeP = '-';

                        BackgroundCode.activity_record.DelCoralF = '-';
                        BackgroundCode.activity_record.DelCoralL1 = '-';
                        BackgroundCode.activity_record.DelCoralL2 = '-';
                        BackgroundCode.activity_record.DelCoralL3 = '-';
                        BackgroundCode.activity_record.DelCoralL4 = '-';

                        BackgroundCode.activity_record.CageAttept = "-";
                        BackgroundCode.activity_record.EndState = "-";

                        BackgroundCode.activity_record.ClimbT = '-';

                        BackgroundCode.activity_record.Strategy = "-";
                        BackgroundCode.activity_record.Defense = 9;
                        BackgroundCode.activity_record.DefenseValue = 9;
                        BackgroundCode.activity_record.DriveRate = 9;
                        BackgroundCode.activity_record.CoralRate = 9;
                        BackgroundCode.activity_record.AlgaeRate = 9;
                        BackgroundCode.activity_record.Avoidance = 9;

                        BackgroundCode.activity_record.SelectedCage = "-";
                        BackgroundCode.activity_record.RedRight = Settings.Default.redRight;

                        //Save Record to the database
                        BackgroundCode.seasonframework.ActivitySet.Add(BackgroundCode.activity_record);
                        BackgroundCode.seasonframework.SaveChanges();

                        if (controller.Match_event == RobotState.MATCHEVENT_NAME.DropCoral)
                        {
                            controller.hasCoral = 0;
                        }
                        break;
                    case "Defense":
                        BackgroundCode.activity_record.RecordType = recordType;
                        BackgroundCode.activity_record.Time = DateTime.Now;
                        BackgroundCode.activity_record.Team = BackgroundCode.Robots[controller.ScouterBox].TeamName;
                        BackgroundCode.activity_record.Match = Settings.Default.currentMatch;
                        BackgroundCode.activity_record.Mode = RobotState.ROBOT_MODE.Defense.ToString();
                        BackgroundCode.activity_record.ScouterName = controller.GetScouterName().ToString();

                        BackgroundCode.activity_record.Match_event = "-";
                        BackgroundCode.activity_record.Leave = "-";
                        BackgroundCode.activity_record.Starting_Loc = "-";
                        BackgroundCode.activity_record.Near_Far = controller.Near_Far;


                        if (BackgroundCode.Robots[controller.ScouterBox] == BackgroundCode.Robots[0])
                        {
                            BackgroundCode.activity_record.DriveSta = "red0";
                        }
                        else if (BackgroundCode.Robots[controller.ScouterBox] == BackgroundCode.Robots[1])
                        {
                            BackgroundCode.activity_record.DriveSta = "red1";
                        }
                        else if (BackgroundCode.Robots[controller.ScouterBox] == BackgroundCode.Robots[2])
                        {
                            BackgroundCode.activity_record.DriveSta = "red2";
                        }
                        else if (BackgroundCode.Robots[controller.ScouterBox] == BackgroundCode.Robots[3])
                        {
                            BackgroundCode.activity_record.DriveSta = "blue0";
                        }
                        else if (BackgroundCode.Robots[controller.ScouterBox] == BackgroundCode.Robots[4])
                        {
                            BackgroundCode.activity_record.DriveSta = "blue1";
                        }
                        else if (BackgroundCode.Robots[controller.ScouterBox] == BackgroundCode.Robots[5])
                        {
                            BackgroundCode.activity_record.DriveSta = "blue2";
                        }

                        controller.DefTimeDouble = controller.DefTime_StopWatch.Elapsed.TotalSeconds;
                        BackgroundCode.activity_record.DZTime = controller.DefTimeDouble;


                        BackgroundCode.activity_record.ScouterError = controller.ScouterError;

                        BackgroundCode.activity_record.AcqAlgaeF = controller.AcqAlgaeF;
                        BackgroundCode.activity_record.AcqAlgaeR = controller.AcqAlgaeR;
                        BackgroundCode.activity_record.AcqCoralS = controller.AcqCoralS;
                        BackgroundCode.activity_record.AcqCoralF = controller.AcqCoralF;

                        BackgroundCode.activity_record.DelAlgaeF = controller.DelAlgaeF;
                        BackgroundCode.activity_record.DelAlgaeN = controller.DelAlgaeN;
                        BackgroundCode.activity_record.DelAlgaeP = controller.DelAlgaeP;

                        BackgroundCode.activity_record.DelCoralF = controller.DelCoralF;
                        BackgroundCode.activity_record.DelCoralL1 = controller.DelCoralL1;
                        BackgroundCode.activity_record.DelCoralL2 = controller.DelCoralL2;
                        BackgroundCode.activity_record.DelCoralL3 = controller.DelCoralL3;
                        BackgroundCode.activity_record.DelCoralL4 = controller.DelCoralL4;

                        BackgroundCode.activity_record.CageAttept = "-";
                        BackgroundCode.activity_record.EndState = "-";

                        BackgroundCode.activity_record.ClimbT = '-';

                        BackgroundCode.activity_record.Strategy = "-";
                        BackgroundCode.activity_record.Defense = 9;
                        BackgroundCode.activity_record.DefenseValue = 9;
                        BackgroundCode.activity_record.DriveRate = 9;
                        BackgroundCode.activity_record.CoralRate = 9;
                        BackgroundCode.activity_record.AlgaeRate = 9;
                        BackgroundCode.activity_record.Avoidance = 9;

                        BackgroundCode.activity_record.SelectedCage = "-";
                        BackgroundCode.activity_record.RedRight = Settings.Default.redRight;

                        //Save Record to the database
                        BackgroundCode.seasonframework.ActivitySet.Add(BackgroundCode.activity_record);
                        BackgroundCode.seasonframework.SaveChanges();
                        break;
                    default:
                        MessageBox.Show("Error: Record Type not found");
                        break;
                }
            }
        }

        public static void ResetValues()
        {
            for (int i = 0; i < BackgroundCode.gamePads.Length; i++)
            {
                BackgroundCode.Robots[i].Current_Mode = RobotState.ROBOT_MODE.Auto;
                BackgroundCode.Robots[i].Leave = RobotState.LEAVE.Z;
                BackgroundCode.Robots[i].AUTO = true;
                BackgroundCode.Robots[i].Starting_Location = RobotState.STARTING_LOC.Select;
                BackgroundCode.Robots[i].Near_Far = false;

                BackgroundCode.Robots[i].AcqAlgaeF = 0;
                BackgroundCode.Robots[i].AcqAlgaeR = 0;
                BackgroundCode.Robots[i].AcqCoralS = 0;
                BackgroundCode.Robots[i].AcqCoralF = 0;
                BackgroundCode.Robots[i].hasCoral = 0;
                BackgroundCode.Robots[i].hasAlgae = 0;

                BackgroundCode.Robots[i].DelAlgaeF = 0;
                BackgroundCode.Robots[i].DelAlgaeN = 0;
                BackgroundCode.Robots[i].DelAlgaeP = 0;

                BackgroundCode.Robots[i].DelCoralF = 0;
                BackgroundCode.Robots[i].DelCoralL1 = 0;
                BackgroundCode.Robots[i].DelCoralL2 = 0;
                BackgroundCode.Robots[i].DelCoralL3 = 0;
                BackgroundCode.Robots[i].DelCoralL4 = 0;

                BackgroundCode.Robots[i].Cage_Attempt = RobotState.CAGE_ATTEMPT.Select;
                BackgroundCode.Robots[i].End_State = RobotState.END_STATE.Select;
                try
                {
                    BackgroundCode.Robots[i].ClimbT_StopWatch.Stop();
                    BackgroundCode.Robots[i].ClimbT_StopWatch.Reset();
                    BackgroundCode.Robots[i].ClimbT = TimeSpan.Zero;
                    BackgroundCode.Robots[i].ClimbTDouble = 0;
                    BackgroundCode.Robots[i].ClimbT_StopWatch_running = false;
                }
                catch {}

                try
                {
                    BackgroundCode.Robots[i].DefTime_StopWatch.Stop();
                    BackgroundCode.Robots[i].DefTime_StopWatch.Reset();
                    BackgroundCode.Robots[i].DefTime = TimeSpan.Zero;
                    BackgroundCode.Robots[i].DefTimeDouble = 0;
                    BackgroundCode.Robots[i].DefTime_StopWatch_running = false;
                }
                catch {}

                BackgroundCode.Robots[i].ScouterError = 0;
                BackgroundCode.Robots[i].NoSho = false;
                BackgroundCode.Robots[i].Flag = false;

                BackgroundCode.Robots[i].Def_Rat = 9;
                BackgroundCode.Robots[i].Def_Eff = 9;
                BackgroundCode.Robots[i].Avo_Rat = 9;
                BackgroundCode.Robots[i].Dri_Rat = 9;
                BackgroundCode.Robots[i].Cor_Rat = 9;
                BackgroundCode.Robots[i].Alg_Rat = 9;

                BackgroundCode.Robots[i].lastCoralLoc = " ";
                BackgroundCode.Robots[i].lastAlgaeLoc = " ";
                BackgroundCode.Robots[i].lastCoralAcqLoc = " ";
                BackgroundCode.Robots[i].lastAlgaeAcqLoc = " ";
            }
        }
    }
}
