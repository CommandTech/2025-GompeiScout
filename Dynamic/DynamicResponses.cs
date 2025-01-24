using ScoutingCodeRedo.Properties;
using ScoutingCodeRedo.Static;
using System;
using System.Diagnostics;
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
                robot.prevlastAlgaeLoc = robot.lastAlgaeLoc;
                robot.prevlastCoralLoc = robot.lastCoralLoc;
                if (gamepad.RightButton_Release)
                {
                    robot.prevlastAlgaeAcqLoc = robot.lastAlgaeAcqLoc;
                }
                if (gamepad.LeftButton_Release)
                {
                    robot.prevlastCoralAcqLoc = robot.lastCoralAcqLoc;
                }

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
                        robot.CycleStartField(RobotState.CYCLE_DIRECTION.Down);
                        if (robot.Starting_Location == RobotState.STARTING_LOC.C1 || robot.Starting_Location == RobotState.STARTING_LOC.C2 || robot.Starting_Location == RobotState.STARTING_LOC.C3)
                        {
                            robot.DelNearFar = false;
                        }
                        else
                        {
                            robot.DelNearFar = true;
                        }
                    }
                    else if (gamepad.LTHUp_Press && !gamepad.LeftTrigger_Down)
                    {
                        robot.CycleStart(RobotState.CYCLE_DIRECTION.Up);
                        robot.CycleStartField(RobotState.CYCLE_DIRECTION.Up);
                        if (robot.Starting_Location == RobotState.STARTING_LOC.C1 || robot.Starting_Location == RobotState.STARTING_LOC.C2 || robot.Starting_Location == RobotState.STARTING_LOC.C3)
                        {
                            robot.DelNearFar = false;
                        }
                        else
                        {
                            robot.DelNearFar = true;
                        }
                    }

                    //Acquire Coral/Algae from Station/Reef
                    if (gamepad.LeftButton_Press)
                    {
                        if (robot.Flag)
                        {
                            robot.hasAlgae++;
                            robot.lastAlgaeAcqLoc = "Reef";
                            robot.AcqAlgaeNearFar = robot.DelNearFar;
                        }
                        else
                        {
                            robot.hasCoral++;
                            robot.lastCoralAcqLoc = "Station";
                            robot.AcqCoralNearFar = robot.DelNearFar;
                        }
                    }
                    //Acquire Coral/Algae from Floor
                    if (gamepad.LeftTrigger_Press)
                    {
                        if (robot.Flag)
                        {
                            robot.hasAlgae++;
                            robot.lastAlgaeAcqLoc = "Floor";
                            robot.AcqAlgaeNearFar = robot.DelNearFar;
                        }
                        else
                        {
                            robot.hasCoral++;
                            robot.lastCoralAcqLoc = "Floor";
                            robot.AcqCoralNearFar = robot.DelNearFar;
                        }
                    }

                    //Deliveries
                    if (gamepad.RightButton_Press && robot.lastAlgaeAcqLoc == robot.prevlastAlgaeAcqLoc && robot.lastAlgaeAcqLoc != " ")
                    {
                        robot.lastAlgaeLoc = "Floor";
                        robot.TransactionCheck = true;
                    }
                    if (gamepad.LeftButton_Press && robot.lastCoralAcqLoc == robot.prevlastCoralAcqLoc && robot.lastCoralAcqLoc != " " && !robot.Flag)
                    {
                        robot.lastCoralLoc = "Floor";
                        robot.TransactionCheck = true;
                    }
                    if (gamepad.DpadUp_Press)
                    {
                        if (robot.Flag)
                        {
                            if (robot.lastAlgaeAcqLoc != " ")
                            {
                                robot.lastAlgaeLoc = "Net";
                                robot.TransactionCheck = true;
                            }
                        }
                        else
                        {
                            if (robot.lastCoralAcqLoc != " " || robot.totalCoralDeliveries == 0)
                            {
                                if (robot.totalCoralDeliveries == 0 && robot.hasCoral == 0)
                                {
                                    robot.hasCoral++;
                                }
                                robot.lastCoralLoc = "L4";
                                robot.autoCoralPoints += 7;
                                robot.TransactionCheck = true;
                            }
                        }
                    }
                    if (gamepad.DpadDown_Press)
                    {
                        if (robot.Flag)
                        {
                            if (robot.lastAlgaeAcqLoc != " ")
                            {
                                robot.lastAlgaeLoc = "Processor";
                                robot.TransactionCheck = true;
                            }
                        }
                        else
                        {
                            if (robot.lastCoralAcqLoc != " " || robot.totalCoralDeliveries == 0)
                            {
                                if (robot.totalCoralDeliveries == 0 && robot.hasCoral == 0)
                                {
                                    robot.hasCoral++;
                                }
                                robot.lastCoralLoc = "L2";
                                robot.autoCoralPoints += 4;
                                robot.TransactionCheck = true;
                            }
                        }
                    }
                    if (gamepad.DpadRight_Press)
                    {
                        if (!robot.Flag && robot.lastCoralAcqLoc != " " || robot.totalCoralDeliveries == 0)
                        {
                            if (robot.totalCoralDeliveries == 0 && robot.hasCoral == 0)
                            {
                                robot.hasCoral++;
                            }
                            robot.lastCoralLoc = "L3";
                            robot.autoCoralPoints += 6;
                            robot.TransactionCheck = true;
                        }
                    }
                    if (gamepad.DpadLeft_Press)
                    {
                        if (!robot.Flag && robot.lastCoralAcqLoc != " " || robot.totalCoralDeliveries == 0)
                        {
                            if (robot.totalCoralDeliveries == 0 && robot.hasCoral == 0)
                            {
                                robot.hasCoral++;
                            }
                            robot.lastCoralLoc = "L1";
                            robot.autoCoralPoints += 3;
                            robot.TransactionCheck = true;
                        }
                    }

                    if (gamepad.YButton_Press)
                    {
                        robot.DelNearFar = true;
                    }
                    if (gamepad.AButton_Press)
                    {
                        robot.DelNearFar = false;
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
                            robot.hasAlgae++;
                            robot.lastAlgaeAcqLoc = "Reef";
                            robot.AcqAlgaeNearFar = robot.DelNearFar;
                        }
                        else
                        {
                            robot.hasCoral++;
                            robot.lastCoralAcqLoc = "Station";
                            robot.AcqCoralNearFar = robot.DelNearFar;
                        }
                    }
                    //Acquire Coral/Algae from Floor
                    if (gamepad.LeftTrigger_Press)
                    {
                        if (robot.Flag)
                        {
                            robot.hasAlgae++;
                            robot.lastAlgaeAcqLoc = "Floor";
                            robot.AcqAlgaeNearFar = robot.DelNearFar;
                        }
                        else
                        {
                            robot.hasCoral++;
                            robot.lastCoralAcqLoc = "Floor";
                            robot.AcqCoralNearFar = robot.DelNearFar;
                        }
                    }

                    //Deliveries
                    if (gamepad.RightButton_Press && robot.lastAlgaeAcqLoc == robot.prevlastAlgaeAcqLoc && robot.lastAlgaeAcqLoc != " ")
                    {
                        robot.lastAlgaeLoc = "Floor";
                        robot.TransactionCheck = true;
                    }
                    if (gamepad.LeftButton_Press && robot.lastCoralAcqLoc == robot.prevlastCoralAcqLoc && robot.lastCoralAcqLoc != " " && !robot.Flag)
                    {
                        robot.lastCoralLoc = "Floor";
                        robot.TransactionCheck = true;
                    }
                    if (gamepad.DpadUp_Press)
                    {
                        if (robot.Flag)
                        {
                            if (robot.lastAlgaeAcqLoc != " ")
                            {
                                robot.lastAlgaeLoc = "Net";
                                robot.TransactionCheck = true;
                            }
                        }
                        else
                        {
                            if (robot.lastCoralAcqLoc != " " || robot.totalCoralDeliveries == 0)
                            {
                                if (robot.totalCoralDeliveries == 0 && robot.hasCoral == 0)
                                {
                                    robot.hasCoral++;
                                }
                                robot.lastCoralLoc = "L4";
                                robot.TransactionCheck = true;
                            }
                        }
                    }
                    if (gamepad.DpadDown_Press)
                    {
                        if (robot.Flag)
                        {
                            if (robot.lastAlgaeAcqLoc != " ")
                            {
                                robot.lastAlgaeLoc = "Processor";
                                robot.TransactionCheck = true;
                            }
                        }
                        else
                        {
                            if (robot.lastCoralAcqLoc != " " || robot.totalCoralDeliveries == 0)
                            {
                                if (robot.totalCoralDeliveries == 0 && robot.hasCoral == 0)
                                {
                                    robot.hasCoral++;
                                }
                                robot.lastCoralLoc = "L2";
                                robot.TransactionCheck = true;
                            }
                        }
                    }
                    if (gamepad.DpadRight_Press)
                    {
                        if (!robot.Flag && robot.lastCoralAcqLoc != " " || robot.totalCoralDeliveries == 0)
                        {
                            if (robot.totalCoralDeliveries == 0 && robot.hasCoral == 0)
                            {
                                robot.hasCoral++;
                            }
                            robot.lastCoralLoc = "L3";
                            robot.TransactionCheck = true;
                        }
                    }
                    if (gamepad.DpadLeft_Press)
                    {
                        if (!robot.Flag && robot.lastCoralAcqLoc != " " || robot.totalCoralDeliveries == 0)
                        {
                            if (robot.totalCoralDeliveries == 0 && robot.hasCoral == 0)
                            {
                                robot.hasCoral++;
                            }
                            robot.lastCoralLoc = "L1";
                            robot.TransactionCheck = true;
                        }
                    }

                    if (gamepad.YButton_Press)
                    {
                        robot.DelNearFar = true;
                    }
                    if (gamepad.AButton_Press)
                    {
                        robot.DelNearFar = false;
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
                            robot.hasAlgae++;
                            robot.lastAlgaeAcqLoc = "Reef";
                            robot.AcqAlgaeNearFar = robot.DelNearFar;
                        }
                        else
                        {
                            robot.hasCoral++;
                            robot.lastCoralAcqLoc = "Station";
                            robot.AcqCoralNearFar = robot.DelNearFar;
                        }
                    }
                    //Acquire Coral/Algae from Floor
                    if (gamepad.LeftTrigger_Press)
                    {
                        if (robot.Flag)
                        {
                            robot.hasAlgae++;
                            robot.lastAlgaeAcqLoc = "Floor";
                            robot.AcqAlgaeNearFar = robot.DelNearFar;
                        }
                        else
                        {
                            robot.hasCoral++;
                            robot.lastCoralAcqLoc = "Floor";
                            robot.AcqCoralNearFar = robot.DelNearFar;
                        }
                    }

                    //Deliveries
                    if (gamepad.RightButton_Press && robot.lastAlgaeAcqLoc == robot.prevlastAlgaeAcqLoc && robot.lastAlgaeAcqLoc != " ")
                    {
                        robot.lastAlgaeLoc = "Floor";
                        robot.TransactionCheck = true;
                    }
                    if (gamepad.LeftButton_Press && robot.lastCoralAcqLoc == robot.prevlastCoralAcqLoc && robot.lastCoralAcqLoc != " " && !robot.Flag)
                    {
                        robot.lastCoralLoc = "Floor";
                        robot.TransactionCheck = true;
                    }
                    if (gamepad.DpadUp_Press)
                    {
                        if (robot.Flag)
                        {
                            if (robot.lastAlgaeAcqLoc != " ")
                            {
                                robot.lastAlgaeLoc = "Net";
                                robot.TransactionCheck = true;
                            }
                        }
                    }
                    if (gamepad.DpadDown_Press)
                    {
                        if (robot.Flag)
                        {
                            if (robot.lastAlgaeAcqLoc != " ")
                            {
                                robot.lastAlgaeLoc = "Processor";
                                robot.TransactionCheck = true;
                            }
                        }
                    }
                    if (gamepad.YButton_Press)
                    {
                        robot.DelNearFar = true;
                    }
                    if (gamepad.AButton_Press)
                    {
                        robot.DelNearFar = false;
                    }
                }
                //***********************************
                //Surfacing MODE
                //***********************************
                else if (robot.Current_Mode == RobotState.ROBOT_MODE.Surfacing)
                {
                    if (gamepad.RightButton_Press && robot.lastAlgaeAcqLoc == robot.prevlastAlgaeAcqLoc && robot.lastAlgaeAcqLoc != " ")
                    {
                        robot.lastAlgaeLoc = "Floor";
                        robot.TransactionCheck = true;
                    }
                    if (gamepad.LeftButton_Press && robot.lastCoralAcqLoc == robot.prevlastCoralAcqLoc && robot.lastCoralAcqLoc != " " && !robot.Flag)
                    {
                        robot.lastCoralLoc = "Floor";
                        robot.TransactionCheck = true;
                    }

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
                    if (gamepad.LeftTrigger_Press)
                    {
                        robot.ClimbT = TimeSpan.Zero;
                        robot.ClimbT_StopWatch.Reset();
                        robot.ClimbT_StopWatch_running = false;
                    }

                    //Cycle End State
                    if (gamepad.YButton_Press)
                    {
                        robot.CycleState(RobotState.CYCLE_DIRECTION.Up);

                        //Totaling end game
                        if (robot.End_State == RobotState.END_STATE.Park)
                        {
                            robot.PointsScored += 2;
                        }
                        else if (robot.End_State == RobotState.END_STATE.Shallow)
                        {
                            robot.PointsScored -= 2;
                            robot.PointsScored += 6;
                        }
                        else if (robot.End_State == RobotState.END_STATE.Deep)
                        {
                            robot.PointsScored -= 6;
                            robot.PointsScored += 12;
                        }
                        else if (robot.End_State == RobotState.END_STATE.Select)
                        {
                            robot.PointsScored -= 12;
                        }
                    }
                    //Cycle Robot Strat
                    if (gamepad.AButton_Press)
                    {
                        robot.CycleStrat(RobotState.CYCLE_DIRECTION.Up);
                    }
                    //Deliver Algae to the Floor
                    if (gamepad.RightButton_Press && robot.lastAlgaeAcqLoc == robot.prevlastAlgaeAcqLoc && robot.lastAlgaeAcqLoc != " ")
                    {
                        robot.lastAlgaeLoc = "Floor";
                        robot.TransactionCheck = true;
                    }
                    //Deliver Coral to the Floor
                    if (gamepad.LeftButton_Press && robot.lastCoralAcqLoc == robot.prevlastCoralAcqLoc && robot.lastCoralAcqLoc != " " && !robot.Flag)
                    {
                        robot.lastCoralLoc = "Floor";
                        robot.TransactionCheck = true;
                    }

                    //Cycle Cage Attempt
                    if (gamepad.DpadUp_Press)
                    {
                        robot.CycleCage(RobotState.CYCLE_DIRECTION.Up);
                    }
                    if (gamepad.DpadRight_Press)
                    {
                        //Cycle Avoidance Rating
                        robot.Avo_Rat++;
                        if (robot.Avo_Rat > 3)
                        {
                            robot.Avo_Rat = 0;
                        }
                    }
                    if (gamepad.DpadLeft_Press)
                    {
                        //Cycle Defense Rating
                        robot.Def_Rat++;
                        if (robot.Def_Rat > 3)
                        {
                            robot.Def_Rat = 0;
                        }
                    }
                    if (gamepad.DpadDown_Press)
                    {
                        //Cycle Defense Effectiveness
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
                }
                //***********************************
                //Any mode
                //***********************************

                // Changing modes
                //Leaving Auto
                if (gamepad.StartButton_Press && robot.Current_Mode == RobotState.ROBOT_MODE.Auto)
                {
                    robot.AUTO = false;
                    TransactToDatabase(robot, "EndAuto");
                    robot.Desired_Mode = RobotState.ROBOT_MODE.Surfacing;
                    robot.Current_Mode = RobotState.ROBOT_MODE.Teleop;
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

                    TransactToDatabase(robot, "Defense");

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

                        TransactToDatabase(robot, "Defense");

                        robot.DefTime_StopWatch.Reset();
                    }
                }

                //Algae Flag
                if (gamepad.RightButton_Down)
                {
                    robot.Flag = true;
                }
                else
                {
                    robot.Flag = false;
                }

                //Correcting Errors
                if (robot.hasCoral > 1)
                {
                    robot.ScouterError += 100000000;
                    robot.hasCoral = 1;
                }
                else if (robot.hasCoral < 0)
                {
                    robot.ScouterError += 10000;
                    robot.hasCoral = 0;
                }
                if (robot.hasAlgae > 1)
                {
                    robot.ScouterError += 1000000;
                    robot.hasAlgae = 1;
                }
                else if (robot.hasAlgae < 0)
                {
                    robot.ScouterError += 100;
                    robot.hasAlgae = 0;
                }


                //2025 Transaction
                if (gamepad.RightTrigger_Press && robot.TransactionCheck)
                {
                    TransactToDatabase(robot, "Activities");
                }
                else if (gamepad.RightTrigger_Press)
                {
                    robot.ScouterError += 10000000000;
                }
            }

            // Values if robot is NoSho
            else if (robot.NoSho)
            {

            }
        }

        public static void TransactToDatabase(RobotState controller, string recordType)
        {
            if (controller.lastCoralAcqLoc == "Station" && controller.lastTransCoralLoc != "Station")
            {
                controller.AcqCoralS++;
            }
            else if (controller.lastCoralAcqLoc == "Floor" && controller.lastTransCoralLoc != "Floor")
            {
                controller.AcqCoralF++;
            }
            if (controller.lastAlgaeAcqLoc == "Reef" && controller.lastTransAlgaeLoc != "Reef")
            {
                controller.AcqAlgaeR++;
            }
            else if (controller.lastAlgaeAcqLoc == "Floor" && controller.lastTransAlgaeLoc != "Floor")
            {
                controller.AcqAlgaeF++;
            }

            if (controller.Leave == RobotState.LEAVE.Y && controller.Current_Mode == RobotState.ROBOT_MODE.Auto && recordType == "EndAuto")
            {
                controller.PointsScored += 3;
            }
            if (controller.lastAlgaeLoc == "Net")
            {
                controller.DelAlgaeN++;
                controller.PointsScored += 4;
            }
            else if (controller.lastAlgaeLoc == "Processor")
            {
                controller.DelAlgaeP++;
                controller.PointsScored += 6;
            }
            else if (controller.lastAlgaeLoc == "Floor")
            {
                controller.DelAlgaeF++;
            }

            if (controller.Current_Mode == RobotState.ROBOT_MODE.Auto)
            {
                if (controller.lastCoralLoc == "L4")
                {
                    controller.DelCoralL4++;
                    controller.PointsScored += 7;
                }
                else if (controller.lastCoralLoc == "L3")
                {
                    controller.DelCoralL3++;
                    controller.PointsScored += 6;
                }
                else if (controller.lastCoralLoc == "L2")
                {
                    controller.DelCoralL2++;
                    controller.PointsScored += 4;
                }
                else if (controller.lastCoralLoc == "L1")
                {
                    controller.DelCoralL1++;
                    controller.PointsScored += 3;
                }
                else if (controller.lastCoralLoc == "Floor")
                {
                    controller.DelCoralF++;
                }
            }
            else
            {
                if (controller.lastCoralLoc == "L4")
                {
                    controller.DelCoralL4++;
                    controller.PointsScored += 5;
                }
                else if (controller.lastCoralLoc == "L3")
                {
                    controller.DelCoralL3++;
                    controller.PointsScored += 4;
                }
                else if (controller.lastCoralLoc == "L2")
                {
                    controller.DelCoralL2++;
                    controller.PointsScored += 3;
                }
                else if (controller.lastCoralLoc == "L1")
                {
                    controller.DelCoralL1++;
                    controller.PointsScored += 2;
                }
                else if (controller.lastCoralLoc == "Floor")
                {
                    controller.DelCoralF++;
                }
            }


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

                        if (Settings.Default.redRight)
                        {
                            BackgroundCode.activity_record.Starting_Loc = controller.GetStart().ToString();
                            BackgroundCode.activity_record.Del_Near_Far = "-";
                            if (controller.lastAlgaeLoc != " ")
                            {
                                BackgroundCode.activity_record.AcqAlgae_Near_Far = controller.AcqAlgaeNearFar ? "Far" : "Near";
                            }
                            if (controller.lastCoralLoc != " ")
                            {
                                BackgroundCode.activity_record.AcqCoral_Near_Far = controller.AcqCoralNearFar ? "Far" : "Near";
                            }
                        }
                        else
                        {
                            BackgroundCode.activity_record.Starting_Loc = controller.GetStartField().ToString();
                            BackgroundCode.activity_record.Del_Near_Far = "-";
                            if (controller.lastAlgaeLoc != " ")
                            {
                                BackgroundCode.activity_record.AcqAlgae_Near_Far = !controller.AcqAlgaeNearFar ? "Far" : "Near";
                            }
                            if (controller.lastCoralLoc != " ")
                            {
                                BackgroundCode.activity_record.AcqCoral_Near_Far = !controller.AcqCoralNearFar ? "Far" : "Near";
                            }
                        }


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
                            controller.ScouterError += 1;
                        }
                        if (controller.Starting_Location == RobotState.STARTING_LOC.Select)
                        {
                            controller.ScouterError += 1;
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
                        BackgroundCode.activity_record.Defense = "-";
                        BackgroundCode.activity_record.DefenseValue = "-";
                        BackgroundCode.activity_record.Avoidance = "-";

                        BackgroundCode.activity_record.SelectedCage = "-";
                        BackgroundCode.activity_record.PointScored = controller.PointsScored.ToString();

                        //Save Record to the database
                        BackgroundCode.seasonframework.ActivitySet.Add(BackgroundCode.activity_record);
                        BackgroundCode.seasonframework.SaveChanges();

                        if (controller.hasCoral == 1 && controller.lastCoralLoc != " ")
                        {
                            controller.totalCoralDeliveries++;
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
                        if (Settings.Default.redRight)
                        {
                            BackgroundCode.activity_record.Del_Near_Far = controller.DelNearFar ? "Far" : "Near";
                            BackgroundCode.activity_record.AcqAlgae_Near_Far = "-";
                            if (controller.lastAlgaeLoc != " ")
                            {
                                BackgroundCode.activity_record.AcqAlgae_Near_Far = controller.AcqAlgaeNearFar ? "Far" : "Near";
                            }
                            BackgroundCode.activity_record.AcqCoral_Near_Far = "-";
                            if (controller.lastCoralLoc != " ")
                            {
                                BackgroundCode.activity_record.AcqCoral_Near_Far = controller.AcqCoralNearFar ? "Far" : "Near";
                            }
                        }
                        else
                        {
                            BackgroundCode.activity_record.AcqAlgae_Near_Far = "-";
                            BackgroundCode.activity_record.Del_Near_Far = !controller.DelNearFar ? "Far" : "Near";
                            if (controller.lastAlgaeLoc != " ")
                            {
                                BackgroundCode.activity_record.AcqAlgae_Near_Far = !controller.AcqAlgaeNearFar ? "Far" : "Near";
                            }
                            BackgroundCode.activity_record.AcqCoral_Near_Far = "-";
                            if (controller.lastCoralLoc != " ")
                            {
                                BackgroundCode.activity_record.AcqCoral_Near_Far = !controller.AcqCoralNearFar ? "Far" : "Near";
                            }
                        }


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
                        BackgroundCode.activity_record.Defense = "-";
                        BackgroundCode.activity_record.DefenseValue = "-";
                        BackgroundCode.activity_record.Avoidance = "-";

                        BackgroundCode.activity_record.SelectedCage = "-";
                        BackgroundCode.activity_record.PointScored = controller.PointsScored.ToString();

                        //Save Record to the database
                        BackgroundCode.seasonframework.ActivitySet.Add(BackgroundCode.activity_record);
                        BackgroundCode.seasonframework.SaveChanges();

                        controller.lastTransAlgaeLoc = controller.lastAlgaeAcqLoc;
                        controller.lastTransCoralLoc = controller.lastCoralAcqLoc;

                        if (controller.hasCoral == 1 && controller.lastCoralLoc != " ")
                        {
                            controller.totalCoralDeliveries++;
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
                        if (Settings.Default.redRight)
                        {
                            BackgroundCode.activity_record.Del_Near_Far = "-";
                            BackgroundCode.activity_record.AcqAlgae_Near_Far = "-";
                            if (controller.lastAlgaeLoc != " ")
                            {
                                BackgroundCode.activity_record.AcqAlgae_Near_Far = controller.AcqAlgaeNearFar ? "Far" : "Near";
                            }
                            BackgroundCode.activity_record.AcqCoral_Near_Far = "-";
                            if (controller.lastCoralLoc != " ")
                            {
                                BackgroundCode.activity_record.AcqCoral_Near_Far = controller.AcqCoralNearFar ? "Far" : "Near";
                            }
                        }
                        else
                        {
                            BackgroundCode.activity_record.AcqAlgae_Near_Far = "-";
                            BackgroundCode.activity_record.Del_Near_Far = "-";
                            if (controller.lastAlgaeLoc != " ")
                            {
                                BackgroundCode.activity_record.AcqAlgae_Near_Far = !controller.AcqAlgaeNearFar ? "Far" : "Near";
                            }
                            BackgroundCode.activity_record.AcqCoral_Near_Far = "-";
                            if (controller.lastCoralLoc != " ")
                            {
                                BackgroundCode.activity_record.AcqCoral_Near_Far = !controller.AcqCoralNearFar ? "Far" : "Near";
                            }
                        }


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
                        BackgroundCode.activity_record.DefenseValue = controller.Def_Eff.ToString();
                        BackgroundCode.activity_record.Defense = controller.Def_Rat.ToString();
                        if (controller.Def_Rat == 0 || controller.Def_Rat == 9)
                        {
                            BackgroundCode.activity_record.DefenseValue = "0";
                            controller.Def_Eff = 0;
                        }
                        BackgroundCode.activity_record.Avoidance = controller.Avo_Rat.ToString();


                        if (controller.Def_Rat == 9)
                        {
                            controller.ScouterError += 10;
                        }
                        if (controller.Def_Eff == 9)
                        {
                            controller.ScouterError += 10;
                        }
                        if (controller.Avo_Rat == 9)
                        {
                            controller.ScouterError += 10;
                        }
                        BackgroundCode.activity_record.ScouterError = controller.ScouterError;

                        BackgroundCode.activity_record.SelectedCage = controller.Selected_Cage;
                        BackgroundCode.activity_record.PointScored = controller.PointsScored.ToString();

                        //Save Record to the database
                        BackgroundCode.seasonframework.ActivitySet.Add(BackgroundCode.activity_record);
                        BackgroundCode.seasonframework.SaveChanges();

                        if (controller.hasCoral == 1 && controller.lastCoralLoc != " ")
                        {
                            controller.totalCoralDeliveries++;
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
                        BackgroundCode.activity_record.Del_Near_Far = "-";
                        BackgroundCode.activity_record.AcqAlgae_Near_Far = "-";
                        BackgroundCode.activity_record.AcqCoral_Near_Far = "-";


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
                        BackgroundCode.activity_record.Defense = "-";
                        BackgroundCode.activity_record.DefenseValue = "-";
                        BackgroundCode.activity_record.Avoidance = "-";

                        BackgroundCode.activity_record.SelectedCage = "-";
                        BackgroundCode.activity_record.PointScored = "-";

                        //Save Record to the database
                        BackgroundCode.seasonframework.ActivitySet.Add(BackgroundCode.activity_record);
                        BackgroundCode.seasonframework.SaveChanges();

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
                        if (Settings.Default.redRight)
                        {
                            BackgroundCode.activity_record.AcqAlgae_Near_Far = "-";
                            BackgroundCode.activity_record.Del_Near_Far = "-";
                            if (controller.lastAlgaeLoc != " ")
                            {
                                BackgroundCode.activity_record.AcqAlgae_Near_Far = controller.AcqAlgaeNearFar ? "Far" : "Near";
                            }
                            BackgroundCode.activity_record.AcqCoral_Near_Far = "-";
                            if (controller.lastCoralLoc != " ")
                            {
                                BackgroundCode.activity_record.AcqCoral_Near_Far = controller.AcqCoralNearFar ? "Far" : "Near";
                            }
                        }
                        else
                        {
                            BackgroundCode.activity_record.AcqAlgae_Near_Far = "-";
                            BackgroundCode.activity_record.Del_Near_Far = "-";
                            if (controller.lastAlgaeLoc != " ")
                            {
                                BackgroundCode.activity_record.AcqAlgae_Near_Far = !controller.AcqAlgaeNearFar ? "Far" : "Near";
                            }
                            BackgroundCode.activity_record.AcqCoral_Near_Far = "-";
                            if (controller.lastCoralLoc != " ")
                            {
                                BackgroundCode.activity_record.AcqCoral_Near_Far = !controller.AcqCoralNearFar ? "Far" : "Near";
                            }
                        }


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
                        BackgroundCode.activity_record.Defense = "-";
                        BackgroundCode.activity_record.DefenseValue = "-";
                        BackgroundCode.activity_record.Avoidance = "-";

                        BackgroundCode.activity_record.SelectedCage = "-";
                        BackgroundCode.activity_record.PointScored = controller.PointsScored.ToString();

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
                BackgroundCode.Robots[i].DelNearFar = false;

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

                BackgroundCode.Robots[i].lastAlgaeAcqLoc = " ";
                BackgroundCode.Robots[i].prevlastAlgaeAcqLoc = " ";
                BackgroundCode.Robots[i].lastCoralAcqLoc = " ";
                BackgroundCode.Robots[i].prevlastCoralAcqLoc = " ";

                BackgroundCode.Robots[i].totalCoralDeliveries = 0;

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
                catch { }

                try
                {
                    BackgroundCode.Robots[i].DefTime_StopWatch.Stop();
                    BackgroundCode.Robots[i].DefTime_StopWatch.Reset();
                    BackgroundCode.Robots[i].DefTime = TimeSpan.Zero;
                    BackgroundCode.Robots[i].DefTimeDouble = 0;
                    BackgroundCode.Robots[i].DefTime_StopWatch_running = false;
                }
                catch { }

                BackgroundCode.Robots[i].ScouterError = 0;
                BackgroundCode.Robots[i].NoSho = false;
                BackgroundCode.Robots[i].Flag = false;

                BackgroundCode.Robots[i].Def_Rat = 9;
                BackgroundCode.Robots[i].Def_Eff = 9;
                BackgroundCode.Robots[i].Avo_Rat = 9;

                BackgroundCode.Robots[i].lastCoralLoc = " ";
                BackgroundCode.Robots[i].lastAlgaeLoc = " ";
                BackgroundCode.Robots[i].lastCoralAcqLoc = " ";
                BackgroundCode.Robots[i].lastAlgaeAcqLoc = " ";

                BackgroundCode.Robots[i].PointsScored = 0;
                BackgroundCode.Robots[i].App_Strategy = RobotState.APP_STRAT.Select;
            }
        }
    }
}
