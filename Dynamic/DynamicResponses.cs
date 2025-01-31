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
                        if (robot.Flag && robot.lastAlgaeAcqLoc == " ")
                        {
                            robot.hasAlgae++;
                            robot.lastAlgaeAcqLoc = "Reef";
                            robot.AcqAlgaeNearFar = robot.DelNearFar;
                        }
                        else if (robot.lastCoralAcqLoc == " ")
                        {
                            robot.hasCoral++;
                            robot.lastCoralAcqLoc = "Station";
                            robot.AcqCoralNearFar = robot.DelNearFar;
                        }
                    }
                    //Acquire Coral/Algae from Floor
                    if (gamepad.LeftTrigger_Press)
                    {
                        if (robot.Flag && robot.lastAlgaeAcqLoc == " ")
                        {
                            robot.hasAlgae++;
                            robot.lastAlgaeAcqLoc = "Floor";
                            robot.AcqAlgaeNearFar = robot.DelNearFar;
                        }
                        else if (robot.lastCoralAcqLoc == " ")
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
                        if (robot.Flag && robot.lastAlgaeAcqLoc == " ")
                        {
                            robot.hasAlgae++;
                            robot.lastAlgaeAcqLoc = "Reef";
                            robot.AcqAlgaeNearFar = robot.DelNearFar;
                        }
                        else if (robot.lastCoralAcqLoc == " ")
                        {
                            robot.hasCoral++;
                            robot.lastCoralAcqLoc = "Station";
                            robot.AcqCoralNearFar = robot.DelNearFar;
                        }
                    }
                    //Acquire Coral/Algae from Floor
                    if (gamepad.LeftTrigger_Press)
                    {
                        if (robot.Flag && robot.lastAlgaeAcqLoc == " ")
                        {
                            robot.hasAlgae++;
                            robot.lastAlgaeAcqLoc = "Floor";
                            robot.AcqAlgaeNearFar = robot.DelNearFar;
                        }
                        else if (robot.lastCoralAcqLoc == " ")
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
                        if (robot.Flag && robot.lastAlgaeAcqLoc == " ")
                        {
                            robot.hasAlgae++;
                            robot.lastAlgaeAcqLoc = "Reef";
                            robot.AcqAlgaeNearFar = robot.DelNearFar;
                        }
                        else if (robot.lastCoralAcqLoc == " ")
                        {
                            robot.hasCoral++;
                            robot.lastCoralAcqLoc = "Station";
                            robot.AcqCoralNearFar = robot.DelNearFar;
                        }
                    }
                    //Acquire Coral/Algae from Floor
                    if (gamepad.LeftTrigger_Press)
                    {
                        if (robot.Flag && robot.lastAlgaeAcqLoc == " ")
                        {
                            robot.hasAlgae++;
                            robot.lastAlgaeAcqLoc = "Floor";
                            robot.AcqAlgaeNearFar = robot.DelNearFar;
                        }
                        else if (robot.lastAlgaeAcqLoc == " ")
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
                    TransactToDatabase(robot, "EndAuto", controllerNumber);
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

                    TransactToDatabase(robot, "Defense", controllerNumber);

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

                        TransactToDatabase(robot, "Defense", controllerNumber);

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
                    TransactToDatabase(robot, "Activities", controllerNumber);
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

        public static void TransactToDatabase(RobotState controller, string recordType, int id)
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
                var activity_record = BackgroundCode.activity_record[id];
                switch (recordType)
                {
                    case ("EndAuto"):
                        activity_record.RecordType = recordType;
                        activity_record.Time = DateTime.Now;
                        activity_record.Team = BackgroundCode.Robots[controller.ScouterBox].TeamName;
                        activity_record.Match = Settings.Default.currentMatch;
                        activity_record.Mode = controller.Current_Mode.ToString();
                        activity_record.ScouterName = controller.GetScouterName().ToString();

                        activity_record.Match_event = "-";
                        activity_record.Leave = controller.GetLeave().ToString();

                        if (Settings.Default.redRight)
                        {
                            activity_record.Starting_Loc = controller.GetStart().ToString();
                            activity_record.Del_Near_Far = "-";
                            if (controller.lastAlgaeLoc != " ")
                            {
                                activity_record.AcqAlgae_Near_Far = controller.AcqAlgaeNearFar ? "Far" : "Near";
                            }
                            if (controller.lastCoralLoc != " ")
                            {
                                activity_record.AcqCoral_Near_Far = controller.AcqCoralNearFar ? "Far" : "Near";
                            }
                        }
                        else
                        {
                            activity_record.Starting_Loc = controller.GetStartField().ToString();
                            activity_record.Del_Near_Far = "-";
                            if (controller.lastAlgaeLoc != " ")
                            {
                                activity_record.AcqAlgae_Near_Far = !controller.AcqAlgaeNearFar ? "Far" : "Near";
                            }
                            if (controller.lastCoralLoc != " ")
                            {
                                activity_record.AcqCoral_Near_Far = !controller.AcqCoralNearFar ? "Far" : "Near";
                            }
                        }


                        if (BackgroundCode.Robots[controller.ScouterBox] == BackgroundCode.Robots[0])
                        {
                            activity_record.DriveSta = "red0";
                        }
                        else if (BackgroundCode.Robots[controller.ScouterBox] == BackgroundCode.Robots[1])
                        {
                            activity_record.DriveSta = "red1";
                        }
                        else if (BackgroundCode.Robots[controller.ScouterBox] == BackgroundCode.Robots[2])
                        {
                            activity_record.DriveSta = "red2";
                        }
                        else if (BackgroundCode.Robots[controller.ScouterBox] == BackgroundCode.Robots[3])
                        {
                            activity_record.DriveSta = "blue0";
                        }
                        else if (BackgroundCode.Robots[controller.ScouterBox] == BackgroundCode.Robots[4])
                        {
                            activity_record.DriveSta = "blue1";
                        }
                        else if (BackgroundCode.Robots[controller.ScouterBox] == BackgroundCode.Robots[5])
                        {
                            activity_record.DriveSta = "blue2";
                        }

                        controller.DefTimeDouble = controller.DefTime_StopWatch.Elapsed.TotalSeconds;
                        activity_record.DZTime = controller.DefTimeDouble;

                        if (controller.Leave == RobotState.LEAVE.Z)
                        {
                            controller.ScouterError += 1;
                        }
                        if (controller.Starting_Location == RobotState.STARTING_LOC.Select)
                        {
                            controller.ScouterError += 1;
                        }
                        activity_record.ScouterError = controller.ScouterError;

                        activity_record.AcqAlgaeF = controller.AcqAlgaeF;
                        activity_record.AcqAlgaeR = controller.AcqAlgaeR;
                        activity_record.AcqCoralS = controller.AcqCoralS;
                        activity_record.AcqCoralF = controller.AcqCoralF;

                        activity_record.DelAlgaeF = controller.DelAlgaeF;
                        activity_record.DelAlgaeN = controller.DelAlgaeN;
                        activity_record.DelAlgaeP = controller.DelAlgaeP;

                        activity_record.DelCoralF = controller.DelCoralF;
                        activity_record.DelCoralL1 = controller.DelCoralL1;
                        activity_record.DelCoralL2 = controller.DelCoralL2;
                        activity_record.DelCoralL3 = controller.DelCoralL3;
                        activity_record.DelCoralL4 = controller.DelCoralL4;

                        activity_record.CageAttept = "-";
                        activity_record.EndState = "-";
                        activity_record.ClimbT = 0;

                        activity_record.Strategy = "-";
                        activity_record.Defense = "-";
                        activity_record.DefenseValue = "-";
                        activity_record.Avoidance = "-";

                        activity_record.SelectedCage = "-";
                        activity_record.PointScored = controller.PointsScored.ToString();

                        //Save Record to the database
                        BackgroundCode.seasonframework.ActivitySet.Add(activity_record);
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
                        activity_record.RecordType = recordType;
                        activity_record.Time = DateTime.Now;
                        activity_record.Team = BackgroundCode.Robots[controller.ScouterBox].TeamName;
                        activity_record.Match = Settings.Default.currentMatch;
                        activity_record.Mode = controller.Current_Mode.ToString();
                        activity_record.ScouterName = controller.GetScouterName().ToString();

                        activity_record.Match_event = "-";
                        activity_record.Leave = "-";
                        activity_record.Starting_Loc = "-";
                        if (Settings.Default.redRight)
                        {
                            activity_record.Del_Near_Far = controller.DelNearFar ? "Far" : "Near";
                            activity_record.AcqAlgae_Near_Far = "-";
                            if (controller.lastAlgaeLoc != " ")
                            {
                                activity_record.AcqAlgae_Near_Far = controller.AcqAlgaeNearFar ? "Far" : "Near";
                            }
                            activity_record.AcqCoral_Near_Far = "-";
                            if (controller.lastCoralLoc != " ")
                            {
                                activity_record.AcqCoral_Near_Far = controller.AcqCoralNearFar ? "Far" : "Near";
                            }
                        }
                        else
                        {
                            activity_record.AcqAlgae_Near_Far = "-";
                            activity_record.Del_Near_Far = !controller.DelNearFar ? "Far" : "Near";
                            if (controller.lastAlgaeLoc != " ")
                            {
                                activity_record.AcqAlgae_Near_Far = !controller.AcqAlgaeNearFar ? "Far" : "Near";
                            }
                            activity_record.AcqCoral_Near_Far = "-";
                            if (controller.lastCoralLoc != " ")
                            {
                                activity_record.AcqCoral_Near_Far = !controller.AcqCoralNearFar ? "Far" : "Near";
                            }
                        }


                        if (BackgroundCode.Robots[controller.ScouterBox] == BackgroundCode.Robots[0])
                        {
                            activity_record.DriveSta = "red0";
                        }
                        else if (BackgroundCode.Robots[controller.ScouterBox] == BackgroundCode.Robots[1])
                        {
                            activity_record.DriveSta = "red1";
                        }
                        else if (BackgroundCode.Robots[controller.ScouterBox] == BackgroundCode.Robots[2])
                        {
                            activity_record.DriveSta = "red2";
                        }
                        else if (BackgroundCode.Robots[controller.ScouterBox] == BackgroundCode.Robots[3])
                        {
                            activity_record.DriveSta = "blue0";
                        }
                        else if (BackgroundCode.Robots[controller.ScouterBox] == BackgroundCode.Robots[4])
                        {
                            activity_record.DriveSta = "blue1";
                        }
                        else if (BackgroundCode.Robots[controller.ScouterBox] == BackgroundCode.Robots[5])
                        {
                            activity_record.DriveSta = "blue2";
                        }

                        controller.DefTimeDouble = controller.DefTime_StopWatch.Elapsed.TotalSeconds;
                        activity_record.DZTime = controller.DefTimeDouble;


                        activity_record.ScouterError = controller.ScouterError;

                        activity_record.AcqAlgaeF = controller.AcqAlgaeF;
                        activity_record.AcqAlgaeR = controller.AcqAlgaeR;
                        activity_record.AcqCoralS = controller.AcqCoralS;
                        activity_record.AcqCoralF = controller.AcqCoralF;

                        activity_record.DelAlgaeF = controller.DelAlgaeF;
                        activity_record.DelAlgaeN = controller.DelAlgaeN;
                        activity_record.DelAlgaeP = controller.DelAlgaeP;

                        activity_record.DelCoralF = controller.DelCoralF;
                        activity_record.DelCoralL1 = controller.DelCoralL1;
                        activity_record.DelCoralL2 = controller.DelCoralL2;
                        activity_record.DelCoralL3 = controller.DelCoralL3;
                        activity_record.DelCoralL4 = controller.DelCoralL4;


                        activity_record.CageAttept = "-";
                        activity_record.EndState = "-";
                        activity_record.ClimbT = 0;

                        activity_record.Strategy = "-";
                        activity_record.Defense = "-";
                        activity_record.DefenseValue = "-";
                        activity_record.Avoidance = "-";

                        activity_record.SelectedCage = "-";
                        activity_record.PointScored = controller.PointsScored.ToString();

                        //Save Record to the database
                        BackgroundCode.seasonframework.ActivitySet.Add(activity_record);
                        BackgroundCode.seasonframework.SaveChanges();

                        controller.lastTransAlgaeLoc = controller.lastAlgaeAcqLoc;
                        controller.lastTransCoralLoc = controller.lastCoralAcqLoc;

                        if (controller.hasCoral == 1 && controller.lastCoralLoc != " ")
                        {
                            controller.totalCoralDeliveries++;
                            controller.hasCoral = 0;
                            controller.lastCoralLoc = " ";
                            controller.lastCoralAcqLoc = " ";
                            controller.prevlastCoralAcqLoc = " ";
                        }
                        if (controller.hasAlgae == 1 && controller.lastAlgaeLoc != " ")
                        {
                            controller.hasAlgae = 0;
                            controller.lastAlgaeLoc = " ";
                            controller.lastAlgaeAcqLoc = " ";
                            controller.prevlastAlgaeAcqLoc = " ";
                        }
                        controller.TransactionCheck = false;
                        break;
                    case ("EndMatch"):
                        activity_record.RecordType = recordType;
                        activity_record.Time = DateTime.Now;
                        activity_record.Team = BackgroundCode.Robots[controller.ScouterBox].TeamName;
                        activity_record.Match = Settings.Default.currentMatch;
                        activity_record.Mode = controller.Current_Mode.ToString();
                        activity_record.ScouterName = controller.GetScouterName().ToString();

                        activity_record.Match_event = "-";
                        activity_record.Leave = "-";
                        activity_record.Starting_Loc = "-";
                        if (Settings.Default.redRight)
                        {
                            activity_record.Del_Near_Far = "-";
                            activity_record.AcqAlgae_Near_Far = "-";
                            if (controller.lastAlgaeLoc != " ")
                            {
                                activity_record.AcqAlgae_Near_Far = controller.AcqAlgaeNearFar ? "Far" : "Near";
                            }
                            activity_record.AcqCoral_Near_Far = "-";
                            if (controller.lastCoralLoc != " ")
                            {
                                activity_record.AcqCoral_Near_Far = controller.AcqCoralNearFar ? "Far" : "Near";
                            }
                        }
                        else
                        {
                            activity_record.AcqAlgae_Near_Far = "-";
                            activity_record.Del_Near_Far = "-";
                            if (controller.lastAlgaeLoc != " ")
                            {
                                activity_record.AcqAlgae_Near_Far = !controller.AcqAlgaeNearFar ? "Far" : "Near";
                            }
                            activity_record.AcqCoral_Near_Far = "-";
                            if (controller.lastCoralLoc != " ")
                            {
                                activity_record.AcqCoral_Near_Far = !controller.AcqCoralNearFar ? "Far" : "Near";
                            }
                        }


                        if (BackgroundCode.Robots[controller.ScouterBox] == BackgroundCode.Robots[0])
                        {
                            activity_record.DriveSta = "red0";
                        }
                        else if (BackgroundCode.Robots[controller.ScouterBox] == BackgroundCode.Robots[1])
                        {
                            activity_record.DriveSta = "red1";
                        }
                        else if (BackgroundCode.Robots[controller.ScouterBox] == BackgroundCode.Robots[2])
                        {
                            activity_record.DriveSta = "red2";
                        }
                        else if (BackgroundCode.Robots[controller.ScouterBox] == BackgroundCode.Robots[3])
                        {
                            activity_record.DriveSta = "blue0";
                        }
                        else if (BackgroundCode.Robots[controller.ScouterBox] == BackgroundCode.Robots[4])
                        {
                            activity_record.DriveSta = "blue1";
                        }
                        else if (BackgroundCode.Robots[controller.ScouterBox] == BackgroundCode.Robots[5])
                        {
                            activity_record.DriveSta = "blue2";
                        }

                        controller.DefTimeDouble = controller.DefTime_StopWatch.Elapsed.TotalSeconds;
                        activity_record.DZTime = controller.DefTimeDouble;

                        activity_record.AcqAlgaeF = controller.AcqAlgaeF;
                        activity_record.AcqAlgaeR = controller.AcqAlgaeR;
                        activity_record.AcqCoralS = controller.AcqCoralS;
                        activity_record.AcqCoralF = controller.AcqCoralF;

                        activity_record.DelAlgaeF = controller.DelAlgaeF;
                        activity_record.DelAlgaeN = controller.DelAlgaeN;
                        activity_record.DelAlgaeP = controller.DelAlgaeP;

                        activity_record.DelCoralF = controller.DelCoralF;
                        activity_record.DelCoralL1 = controller.DelCoralL1;
                        activity_record.DelCoralL2 = controller.DelCoralL2;
                        activity_record.DelCoralL3 = controller.DelCoralL3;
                        activity_record.DelCoralL4 = controller.DelCoralL4;

                        activity_record.CageAttept = controller.GetAttempt().ToString();
                        activity_record.EndState = controller.GetState().ToString();

                        controller.ClimbTDouble = controller.ClimbT_StopWatch.Elapsed.TotalSeconds;
                        activity_record.ClimbT = controller.ClimbTDouble;

                        activity_record.Strategy = controller.GetStrat().ToString();
                        activity_record.DefenseValue = controller.Def_Eff.ToString();
                        activity_record.Defense = controller.Def_Rat.ToString();
                        if (controller.Def_Rat == 0 || controller.Def_Rat == 9)
                        {
                            activity_record.DefenseValue = "0";
                            controller.Def_Eff = 0;
                        }
                        activity_record.Avoidance = controller.Avo_Rat.ToString();


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
                        activity_record.ScouterError = controller.ScouterError;

                        activity_record.SelectedCage = controller.Selected_Cage;
                        activity_record.PointScored = controller.PointsScored.ToString();

                        //Save Record to the database
                        BackgroundCode.seasonframework.ActivitySet.Add(activity_record);
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
                        activity_record.RecordType = recordType;
                        activity_record.Time = DateTime.Now;
                        activity_record.Team = BackgroundCode.Robots[controller.ScouterBox].TeamName;
                        activity_record.Match = Settings.Default.currentMatch;
                        activity_record.Mode = controller.Current_Mode.ToString();
                        activity_record.ScouterName = controller.GetScouterName().ToString();

                        activity_record.Match_event = controller.Match_event.ToString();
                        activity_record.Leave = "-";
                        activity_record.Starting_Loc = "-";
                        activity_record.Del_Near_Far = "-";
                        activity_record.AcqAlgae_Near_Far = "-";
                        activity_record.AcqCoral_Near_Far = "-";


                        if (BackgroundCode.Robots[controller.ScouterBox] == BackgroundCode.Robots[0])
                        {
                            activity_record.DriveSta = "red0";
                        }
                        else if (BackgroundCode.Robots[controller.ScouterBox] == BackgroundCode.Robots[1])
                        {
                            activity_record.DriveSta = "red1";
                        }
                        else if (BackgroundCode.Robots[controller.ScouterBox] == BackgroundCode.Robots[2])
                        {
                            activity_record.DriveSta = "red2";
                        }
                        else if (BackgroundCode.Robots[controller.ScouterBox] == BackgroundCode.Robots[3])
                        {
                            activity_record.DriveSta = "blue0";
                        }
                        else if (BackgroundCode.Robots[controller.ScouterBox] == BackgroundCode.Robots[4])
                        {
                            activity_record.DriveSta = "blue1";
                        }
                        else if (BackgroundCode.Robots[controller.ScouterBox] == BackgroundCode.Robots[5])
                        {
                            activity_record.DriveSta = "blue2";
                        }

                        activity_record.DZTime = '-';


                        activity_record.ScouterError = controller.ScouterError;

                        activity_record.AcqAlgaeF = '-';
                        activity_record.AcqAlgaeR = '-';
                        activity_record.AcqCoralS = '-';
                        activity_record.AcqCoralF = '-';

                        activity_record.DelAlgaeF = '-';
                        activity_record.DelAlgaeN = '-';
                        activity_record.DelAlgaeP = '-';

                        activity_record.DelCoralF = '-';
                        activity_record.DelCoralL1 = '-';
                        activity_record.DelCoralL2 = '-';
                        activity_record.DelCoralL3 = '-';
                        activity_record.DelCoralL4 = '-';

                        activity_record.CageAttept = "-";
                        activity_record.EndState = "-";

                        activity_record.ClimbT = '-';

                        activity_record.Strategy = "-";
                        activity_record.Defense = "-";
                        activity_record.DefenseValue = "-";
                        activity_record.Avoidance = "-";

                        activity_record.SelectedCage = "-";
                        activity_record.PointScored = "-";

                        //Save Record to the database
                        BackgroundCode.seasonframework.ActivitySet.Add(activity_record);
                        BackgroundCode.seasonframework.SaveChanges();

                        break;
                    case "Defense":
                        activity_record.RecordType = recordType;
                        activity_record.Time = DateTime.Now;
                        activity_record.Team = BackgroundCode.Robots[controller.ScouterBox].TeamName;
                        activity_record.Match = Settings.Default.currentMatch;
                        activity_record.Mode = RobotState.ROBOT_MODE.Defense.ToString();
                        activity_record.ScouterName = controller.GetScouterName().ToString();

                        activity_record.Match_event = "-";
                        activity_record.Leave = "-";
                        activity_record.Starting_Loc = "-";
                        if (Settings.Default.redRight)
                        {
                            activity_record.AcqAlgae_Near_Far = "-";
                            activity_record.Del_Near_Far = "-";
                            if (controller.lastAlgaeLoc != " ")
                            {
                                activity_record.AcqAlgae_Near_Far = controller.AcqAlgaeNearFar ? "Far" : "Near";
                            }
                            activity_record.AcqCoral_Near_Far = "-";
                            if (controller.lastCoralLoc != " ")
                            {
                                activity_record.AcqCoral_Near_Far = controller.AcqCoralNearFar ? "Far" : "Near";
                            }
                        }
                        else
                        {
                            activity_record.AcqAlgae_Near_Far = "-";
                            activity_record.Del_Near_Far = "-";
                            if (controller.lastAlgaeLoc != " ")
                            {
                                activity_record.AcqAlgae_Near_Far = !controller.AcqAlgaeNearFar ? "Far" : "Near";
                            }
                            activity_record.AcqCoral_Near_Far = "-";
                            if (controller.lastCoralLoc != " ")
                            {
                                activity_record.AcqCoral_Near_Far = !controller.AcqCoralNearFar ? "Far" : "Near";
                            }
                        }


                        if (BackgroundCode.Robots[controller.ScouterBox] == BackgroundCode.Robots[0])
                        {
                            activity_record.DriveSta = "red0";
                        }
                        else if (BackgroundCode.Robots[controller.ScouterBox] == BackgroundCode.Robots[1])
                        {
                            activity_record.DriveSta = "red1";
                        }
                        else if (BackgroundCode.Robots[controller.ScouterBox] == BackgroundCode.Robots[2])
                        {
                            activity_record.DriveSta = "red2";
                        }
                        else if (BackgroundCode.Robots[controller.ScouterBox] == BackgroundCode.Robots[3])
                        {
                            activity_record.DriveSta = "blue0";
                        }
                        else if (BackgroundCode.Robots[controller.ScouterBox] == BackgroundCode.Robots[4])
                        {
                            activity_record.DriveSta = "blue1";
                        }
                        else if (BackgroundCode.Robots[controller.ScouterBox] == BackgroundCode.Robots[5])
                        {
                            activity_record.DriveSta = "blue2";
                        }

                        controller.DefTimeDouble = controller.DefTime_StopWatch.Elapsed.TotalSeconds;
                        activity_record.DZTime = controller.DefTimeDouble;


                        activity_record.ScouterError = controller.ScouterError;

                        activity_record.AcqAlgaeF = controller.AcqAlgaeF;
                        activity_record.AcqAlgaeR = controller.AcqAlgaeR;
                        activity_record.AcqCoralS = controller.AcqCoralS;
                        activity_record.AcqCoralF = controller.AcqCoralF;

                        activity_record.DelAlgaeF = controller.DelAlgaeF;
                        activity_record.DelAlgaeN = controller.DelAlgaeN;
                        activity_record.DelAlgaeP = controller.DelAlgaeP;

                        activity_record.DelCoralF = controller.DelCoralF;
                        activity_record.DelCoralL1 = controller.DelCoralL1;
                        activity_record.DelCoralL2 = controller.DelCoralL2;
                        activity_record.DelCoralL3 = controller.DelCoralL3;
                        activity_record.DelCoralL4 = controller.DelCoralL4;

                        activity_record.CageAttept = "-";
                        activity_record.EndState = "-";

                        activity_record.ClimbT = '-';

                        activity_record.Strategy = "-";
                        activity_record.Defense = "-";
                        activity_record.DefenseValue = "-";
                        activity_record.Avoidance = "-";

                        activity_record.SelectedCage = "-";
                        activity_record.PointScored = controller.PointsScored.ToString();

                        //Save Record to the database
                        BackgroundCode.seasonframework.ActivitySet.Add(activity_record);
                        BackgroundCode.seasonframework.SaveChanges();
                        break;
                    default:
                        MessageBox.Show("Error: Record Type not found");
                        break;
                }
            }
        }

        public static void ResetValues(int controllerNumber)
        {
            var robot = BackgroundCode.Robots[controllerNumber];
            robot.Current_Mode = RobotState.ROBOT_MODE.Auto;
            robot.Leave = RobotState.LEAVE.Z;
            robot.AUTO = true;
            robot.Starting_Location = RobotState.STARTING_LOC.Select;
            robot.DelNearFar = false;

            robot.AcqAlgaeF = 0;
            robot.AcqAlgaeR = 0;
            robot.AcqCoralS = 0;
            robot.AcqCoralF = 0;
            robot.hasCoral = 0;
            robot.hasAlgae = 0;

            robot.DelAlgaeF = 0;
            robot.DelAlgaeN = 0;
            robot.DelAlgaeP = 0;

            robot.DelCoralF = 0;
            robot.DelCoralL1 = 0;
            robot.DelCoralL2 = 0;
            robot.DelCoralL3 = 0;
            robot.DelCoralL4 = 0;

            robot.lastAlgaeAcqLoc = " ";
            robot.prevlastAlgaeAcqLoc = " ";
            robot.lastCoralAcqLoc = " ";
            robot.prevlastCoralAcqLoc = " ";

            robot.totalCoralDeliveries = 0;

            robot.Cage_Attempt = RobotState.CAGE_ATTEMPT.Select;
            robot.End_State = RobotState.END_STATE.Select;
            try
            {
                robot.ClimbT_StopWatch.Stop();
                robot.ClimbT_StopWatch.Reset();
                robot.ClimbT = TimeSpan.Zero;
                robot.ClimbTDouble = 0;
                robot.ClimbT_StopWatch_running = false;
            }
            catch { }

            try
            {
                robot.DefTime_StopWatch.Stop();
                robot.DefTime_StopWatch.Reset();
                robot.DefTime = TimeSpan.Zero;
                robot.DefTimeDouble = 0;
                robot.DefTime_StopWatch_running = false;
            }
            catch { }

            robot.ScouterError = 0;
            robot.NoSho = false;
            robot.Flag = false;

            robot.Def_Rat = 9;
            robot.Def_Eff = 9;
            robot.Avo_Rat = 9;

            robot.lastCoralLoc = " ";
            robot.lastAlgaeLoc = " ";
            robot.lastCoralAcqLoc = " ";
            robot.lastAlgaeAcqLoc = " ";

            robot.PointsScored = 0;
            robot.App_Strategy = RobotState.APP_STRAT.Select;
        }
    }
}
