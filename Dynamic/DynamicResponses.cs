using System;
using System.Diagnostics;
using ScoutingCodeRedo.Properties;
using ScoutingCodeRedo.Static;

namespace ScoutingCodeRedo.Dynamic
{
    class DynamicResponses
    {
        public void readStick(GamePad[] gpArray, int controllerNumber)
        {
            GamePad gamepad = gpArray[controllerNumber];

            var robot = BackgroundCode.Robots[controllerNumber];

            if (robot.OpptT_StopWatch == null) robot.OpptT_StopWatch = new Stopwatch();
            if (robot.NeutT_StopWatch == null) robot.NeutT_StopWatch = new Stopwatch();
            if (robot.AllyT_StopWatch == null) robot.AllyT_StopWatch = new Stopwatch();
            if (robot.ClimbT_StopWatch == null) robot.ClimbT_StopWatch = new Stopwatch();

            if (gamepad.R3_Press && !gamepad.XButton_Down)
            {
                if (robot.match_event != RobotState.MATCHEVENT_NAME.Match_Event &&
                    !robot.NoSho &&
                    robot._ScouterName != RobotState.SCOUTER_NAME.Select_Name)
                {
                    if (robot.match_event == RobotState.MATCHEVENT_NAME.NoShow)
                    {
                        robot.NoSho = true;
                    }
                    else
                    {
                        BackgroundCode.activity_record.match_event = robot.match_event.ToString().ToString(); //If you crash here you didn't load matches
                    }

                    //Save Record to the database
                    BackgroundCode.seasonframework.ActivitySet.Add(BackgroundCode.activity_record);
                    BackgroundCode.seasonframework.SaveChanges(); // If you crash here migration isn't working

                    robot.match_event = RobotState.MATCHEVENT_NAME.Match_Event;

                    //Reset Match Event
                    robot.match_event = 0;
                }
                else if (robot.match_event == RobotState.MATCHEVENT_NAME.Match_Event)
                {
                    robot.ScouterError = robot.ScouterError + 100000;
                }
            }

            // #Auto
            // **************************************************************
            // *** Auto MODE ***
            // **************************************************************
            if (robot.Current_Mode == RobotState.ROBOT_MODE.Auto && !robot.NoSho)
            {
                //2024 Setup Controls
                if (gamepad.XButton_Down)
                {
                    if (gamepad.LTHRight_Press)
                    {
                        robot.changeRobot_Set(RobotState.CYCLE_DIRECTION.Up);
                    }
                    if (gamepad.LTHLeft_Press)
                    {
                        robot.changeRobot_Set(RobotState.CYCLE_DIRECTION.Down);
                    }
                }

                //2024 Leave
                if (gamepad.StartButton_Press && robot.Leave == 0)
                {
                    robot.Leave = 1;

                }
                else if (gamepad.StartButton_Press && robot.Leave == 1)
                {
                    robot.Leave = 0;
                }

                //2024 HP in Amp
                if (gamepad.XButton_Down)
                {
                    if (gamepad.L3_Press)
                    {
                        robot.changeHP_Amp(RobotState.CYCLE_DIRECTION.Up);
                    }
                }

                //2024 Current Location and Red Right logic
                if (gamepad.XButton_Down && !gamepad.LeftTrigger_Down)
                {
                    robot.Current_Loc = RobotState.CURRENT_LOC.Left;
                }
                if (gamepad.BButton_Down && !gamepad.LeftTrigger_Down)
                {
                    robot.Current_Loc = RobotState.CURRENT_LOC.Right;

                }
                if (gamepad.AButton_Down && !gamepad.LeftTrigger_Down)
                {
                    robot.Current_Loc = RobotState.CURRENT_LOC.Neutral;
                }
                if (gamepad.YButton_Down && !gamepad.LeftTrigger_Down)
                {
                    if (Settings.Default.redRight)
                    {
                        if (robot.color == "Red")
                        {
                            if (robot.Current_Loc == RobotState.CURRENT_LOC.Right)
                            {
                                robot.Current_Loc = RobotState.CURRENT_LOC.SubW;
                            }
                            if (robot.Current_Loc == RobotState.CURRENT_LOC.Left)
                            {
                                robot.Current_Loc = RobotState.CURRENT_LOC.Source;
                            }
                        }
                        else
                        {
                            if (robot.Current_Loc == RobotState.CURRENT_LOC.Right)
                            {
                                robot.Current_Loc = RobotState.CURRENT_LOC.Source;
                            }
                            if (robot.Current_Loc == RobotState.CURRENT_LOC.Left)
                            {
                                robot.Current_Loc = RobotState.CURRENT_LOC.SubW;
                            }
                        }
                    }
                    else
                    {
                        if (robot.color == "Blue")
                        {
                            if (robot.Current_Loc == RobotState.CURRENT_LOC.Right)
                            {
                                robot.Current_Loc = RobotState.CURRENT_LOC.SubW;
                            }
                            if (robot.Current_Loc == RobotState.CURRENT_LOC.Left)
                            {
                                robot.Current_Loc = RobotState.CURRENT_LOC.Source;
                            }
                        }
                        else
                        {
                            if (robot.Current_Loc == RobotState.CURRENT_LOC.Right)
                            {
                                robot.Current_Loc = RobotState.CURRENT_LOC.Source;
                            }
                            if (robot.Current_Loc == RobotState.CURRENT_LOC.Left)
                            {
                                robot.Current_Loc = RobotState.CURRENT_LOC.SubW;
                            }
                        }
                    }
                }

                //2024 acquire locations
                if (gamepad.LeftTrigger_Press)
                {
                    robot.Acq_Center = 0;
                }
                if (gamepad.LeftTrigger_Down)
                {
                    robot.Del_Dest = RobotState.DEL_DEST.Select;
                    robot.Acq_Loc = robot.Current_Loc.ToString();
                }
                if (!gamepad.RightButton_Down)
                {
                    if (gamepad.DpadUp_Press || gamepad.DpadDown_Press)
                    {
                        robot.Acq_Center = 3;
                        robot.Acq_Loc = "Select";
                        robot.CenteNoteTimeTemp = DateTime.Now;
                    }
                    else if (gamepad.DpadRight_Press && robot.Acq_Center < 4)
                    {
                        robot.Acq_Center = 4;
                        robot.Acq_Loc = "Select";
                        robot.CenteNoteTimeTemp = DateTime.Now;
                    }
                    else if (gamepad.DpadRight_Press && robot.Acq_Center == 4)
                    {
                        robot.Acq_Center = 5;
                        robot.Acq_Loc = "Select";
                        robot.CenteNoteTimeTemp = DateTime.Now;
                    }
                    else if (gamepad.DpadLeft_Press && robot.Acq_Center != 1)
                    {
                        if (gamepad.DpadLeft_Press && robot.Acq_Center != 2)
                        {
                            robot.Acq_Center = 2;
                            robot.Acq_Loc = "Select";
                            robot.CenteNoteTimeTemp = DateTime.Now;
                        }
                        else if (gamepad.DpadLeft_Press && robot.Acq_Center == 2)
                        {
                            robot.Acq_Center = 1;
                            robot.Acq_Loc = "Select";
                            robot.CenteNoteTimeTemp = DateTime.Now;
                        }
                    }
                }

                // 2024 deliver destination
                if (gamepad.RightButton_Down)
                {
                    robot.Acq_Loc = "Select";
                    robot.Acq_Center = 0;
                }
                if (gamepad.RightButton_Down && gamepad.DpadUp_Down)
                {
                    robot.Del_Dest = RobotState.DEL_DEST.Spkr;
                }
                if (gamepad.RightButton_Down && gamepad.DpadLeft_Down)
                {
                    robot.Del_Dest = RobotState.DEL_DEST.Amp;
                }
                if (gamepad.RightButton_Down && gamepad.DpadRight_Down)
                {
                    robot.Del_Dest = RobotState.DEL_DEST.AllyW;
                }
                if (gamepad.RightButton_Down && gamepad.DpadDown_Down)
                {
                    robot.Del_Dest = RobotState.DEL_DEST.Neut;
                }
                if (gamepad.RightButton_Down && gamepad.L3_Down)
                {
                    robot.Del_Dest = RobotState.DEL_DEST.Trap;
                }

                // 2024 Flag
                if (gamepad.LeftButton_Down)
                {
                    robot.Flag = 1;
                }
                else
                {
                    robot.Flag = 0;
                }
            }

            // #Teleop
            // **************************************************************
            // *** Teleop MODE ***
            // **************************************************************
            if (robot.Current_Mode == RobotState.ROBOT_MODE.Teleop && !robot.NoSho)
            {
                //2024 current loc 
                if (gamepad.XButton_Down)
                {
                    robot.Current_Loc = RobotState.CURRENT_LOC.Left;
                }
                if (gamepad.BButton_Down)
                {
                    robot.Current_Loc = RobotState.CURRENT_LOC.Right;

                }
                if (gamepad.AButton_Down)
                {
                    robot.Current_Loc = RobotState.CURRENT_LOC.Neutral;
                }
                if (gamepad.YButton_Down)
                {
                    if (Settings.Default.redRight)
                    {
                        if (robot.color == "Red")
                        {
                            if (robot.Current_Loc == RobotState.CURRENT_LOC.Right)
                            {
                                robot.Current_Loc = RobotState.CURRENT_LOC.SubW;
                            }
                            if (robot.Current_Loc == RobotState.CURRENT_LOC.Left)
                            {
                                robot.Current_Loc = RobotState.CURRENT_LOC.Source;
                            }
                        }
                        else
                        {
                            if (robot.Current_Loc == RobotState.CURRENT_LOC.Right)
                            {
                                robot.Current_Loc = RobotState.CURRENT_LOC.Source;
                            }
                            if (robot.Current_Loc == RobotState.CURRENT_LOC.Left)
                            {
                                robot.Current_Loc = RobotState.CURRENT_LOC.SubW;
                            }
                        }
                    }
                    else
                    {
                        if (robot.color == "Blue")
                        {
                            if (robot.Current_Loc == RobotState.CURRENT_LOC.Right)
                            {
                                robot.Current_Loc = RobotState.CURRENT_LOC.SubW;
                            }
                            if (robot.Current_Loc == RobotState.CURRENT_LOC.Left)
                            {
                                robot.Current_Loc = RobotState.CURRENT_LOC.Source;
                            }
                        }
                        else
                        {
                            if (robot.Current_Loc == RobotState.CURRENT_LOC.Right)
                            {
                                robot.Current_Loc = RobotState.CURRENT_LOC.Source;
                            }
                            if (robot.Current_Loc == RobotState.CURRENT_LOC.Left)
                            {
                                robot.Current_Loc = RobotState.CURRENT_LOC.SubW;
                            }
                        }
                    }
                }
                //2024 del 
                if (gamepad.RightButton_Down)
                {
                    robot.Acq_Loc = "Select";
                }
                if (gamepad.RightButton_Down && gamepad.DpadUp_Down)
                {
                    robot.Del_Dest = RobotState.DEL_DEST.Spkr;
                }
                if (gamepad.RightButton_Down && gamepad.DpadLeft_Down)
                {
                    robot.Del_Dest = RobotState.DEL_DEST.Amp;
                }
                if (gamepad.RightButton_Down && gamepad.DpadRight_Down)
                {
                    robot.Del_Dest = RobotState.DEL_DEST.AllyW;
                }
                if (gamepad.RightButton_Down && gamepad.DpadDown_Down)
                {
                    robot.Del_Dest = RobotState.DEL_DEST.Neut;
                }
                if (gamepad.RightButton_Down && gamepad.L3_Down)
                {
                    robot.Del_Dest = RobotState.DEL_DEST.Trap;
                }

                //2024 acq loc 
                if (gamepad.LeftTrigger_Down)
                {
                    robot.Del_Dest = RobotState.DEL_DEST.Select;
                    robot.Acq_Loc = robot.Current_Loc.ToString();
                }

                // 2024 flag 
                if (gamepad.LeftButton_Down)
                {
                    robot.Flag = 1;
                }
                else
                {
                    robot.Flag = 0;
                }

                //2024 comp
                if (robot.Current_Loc == RobotState.CURRENT_LOC.Neutral)
                {
                    robot.NeutT_StopWatch.Start();
                    robot.NeutT = robot.NeutT_StopWatch.Elapsed;
                    robot.NeutT_StopWatch_running = true;

                    robot.OpptT_StopWatch.Stop();
                    robot.OpptT_StopWatch_running = false;

                    robot.AllyT_StopWatch.Stop();
                    robot.AllyT_StopWatch_running = false;
                }
                //2024 zone time 
                if (Settings.Default.redRight)
                {
                    if (robot.color == "Red")
                    {
                        if (robot.Current_Loc == RobotState.CURRENT_LOC.Right || robot.Current_Loc == RobotState.CURRENT_LOC.SubW)
                        {
                            robot.AllyT_StopWatch.Start();
                            robot.AllyT = robot.AllyT_StopWatch.Elapsed;
                            robot.AllyT_StopWatch_running = true;

                            robot.NeutT_StopWatch.Stop();
                            robot.NeutT_StopWatch_running = false;

                            robot.OpptT_StopWatch.Stop();
                            robot.OpptT_StopWatch_running = false;
                        }
                        if (robot.Current_Loc == RobotState.CURRENT_LOC.Left || robot.Current_Loc == RobotState.CURRENT_LOC.Source)
                        {
                            robot.OpptT_StopWatch.Start();
                            robot.OpptT = robot.OpptT_StopWatch.Elapsed;
                            robot.OpptT_StopWatch_running = true;

                            robot.AllyT_StopWatch.Stop();
                            robot.AllyT_StopWatch_running = false;

                            robot.NeutT_StopWatch.Stop();
                            robot.NeutT_StopWatch_running = false;
                        }
                    }
                    else
                    {
                        if (robot.Current_Loc == RobotState.CURRENT_LOC.Right || robot.Current_Loc == RobotState.CURRENT_LOC.Source)
                        {
                            robot.OpptT_StopWatch.Start();
                            robot.OpptT = robot.OpptT_StopWatch.Elapsed;
                            robot.OpptT_StopWatch_running = true;

                            robot.AllyT_StopWatch.Stop();
                            robot.AllyT_StopWatch_running = false;

                            robot.NeutT_StopWatch.Stop();
                            robot.NeutT_StopWatch_running = false;
                        }
                        if (robot.Current_Loc == RobotState.CURRENT_LOC.Left || robot.Current_Loc == RobotState.CURRENT_LOC.SubW)
                        {
                            robot.AllyT_StopWatch.Start();
                            robot.AllyT = robot.AllyT_StopWatch.Elapsed;
                            robot.AllyT_StopWatch_running = true;

                            robot.NeutT_StopWatch.Stop();
                            robot.NeutT_StopWatch_running = false;

                            robot.OpptT_StopWatch.Stop();
                            robot.OpptT_StopWatch_running = false;
                        }
                    }

                }
                else
                {
                    if (robot.color == "Blue")
                    {
                        if (robot.Current_Loc == RobotState.CURRENT_LOC.Right || robot.Current_Loc == RobotState.CURRENT_LOC.SubW)
                        {
                            robot.AllyT_StopWatch.Start();
                            robot.AllyT = robot.AllyT_StopWatch.Elapsed;
                            robot.AllyT_StopWatch_running = true;

                            robot.NeutT_StopWatch.Stop();
                            robot.NeutT_StopWatch_running = false;

                            robot.OpptT_StopWatch.Stop();
                            robot.OpptT_StopWatch_running = false;
                        }
                        if (robot.Current_Loc == RobotState.CURRENT_LOC.Left || robot.Current_Loc == RobotState.CURRENT_LOC.Source)
                        {
                            robot.OpptT_StopWatch.Start();
                            robot.OpptT = robot.OpptT_StopWatch.Elapsed;
                            robot.OpptT_StopWatch_running = true;

                            robot.AllyT_StopWatch.Stop();
                            robot.AllyT_StopWatch_running = false;

                            robot.NeutT_StopWatch.Stop();
                            robot.NeutT_StopWatch_running = false;
                        }
                    }
                    else
                    {
                        if (robot.Current_Loc == RobotState.CURRENT_LOC.Right || robot.Current_Loc == RobotState.CURRENT_LOC.Source)
                        {
                            robot.OpptT_StopWatch.Start();
                            robot.OpptT = robot.OpptT_StopWatch.Elapsed;
                            robot.OpptT_StopWatch_running = true;

                            robot.AllyT_StopWatch.Stop();
                            robot.AllyT_StopWatch_running = false;

                            robot.NeutT_StopWatch.Stop();
                            robot.NeutT_StopWatch_running = false;
                        }
                        if (robot.Current_Loc == RobotState.CURRENT_LOC.Left || robot.Current_Loc == RobotState.CURRENT_LOC.SubW)
                        {
                            robot.AllyT_StopWatch.Start();
                            robot.AllyT = robot.AllyT_StopWatch.Elapsed;
                            robot.AllyT_StopWatch_running = true;

                            robot.NeutT_StopWatch.Stop();
                            robot.NeutT_StopWatch_running = false;

                            robot.OpptT_StopWatch.Stop();
                            robot.OpptT_StopWatch_running = false;
                        }
                    }
                }
                if (gamepad.StartButton_Press)
                {
                    robot.ClimbT_StopWatch.Stop();
                    robot.ClimbT_StopWatch_running = false;
                    if (gamepad.LeftTrigger_Down && gamepad.StartButton_Press)
                    {
                        robot.ClimbT_StopWatch.Reset();
                        robot.ClimbT_StopWatch_running = true;
                    }
                }
            }

            // #Showtime 
            // **************************************************************
            // *** SHOWTIME MODE ***
            // **************************************************************
            //2024 climb time
            if (robot.Current_Mode == RobotState.ROBOT_MODE.Showtime && !robot.NoSho)
            {
                if (gamepad.StartButton_Press)
                {
                    if (robot.ClimbT_StopWatch_running)
                    {
                        robot.ClimbT_StopWatch.Stop();
                        robot.ClimbT_StopWatch_running = false;
                    }
                    else if (!robot.ClimbT_StopWatch_running)
                    {
                        robot.ClimbT_StopWatch.Start();
                        robot.ClimbT_StopWatch_running = true;
                    }
                }
                if (gamepad.LeftTrigger_Down && gamepad.StartButton_Down)
                {
                    robot.ClimbT_StopWatch.Reset();
                    robot.ClimbT_StopWatch_running = false;
                }

                // 2024 del
                if (gamepad.L3_Press && gamepad.RightButton_Down)
                {
                    robot.Del_Dest = RobotState.DEL_DEST.Trap;
                }

                //2024 flag 
                if (gamepad.LeftButton_Down)
                {
                    robot.Flag = 1;
                }
                else
                {
                    robot.Flag = 0;
                }

                //2024 stat
                if (gamepad.XButton_Down)
                {
                    if (gamepad.LTHRight_Press)
                    {
                        robot.changeStage_Stat(RobotState.CYCLE_DIRECTION.Up);
                    }
                    else if (gamepad.LTHLeft_Press)
                    {
                        robot.changeStage_Stat(RobotState.CYCLE_DIRECTION.Down);
                    }
                }

                //2024 stage Att
                if (gamepad.YButton_Down && robot.Stage_Stat == RobotState.STAGE_STAT.Onstage)
                {
                    if (gamepad.LTHRight_Press)
                    {
                        robot.Stage_Att = RobotState.STAGE_ATT.Select;
                        robot.changeStage_Loc(RobotState.CYCLE_DIRECTION.Up);
                    }
                    else if (gamepad.LTHLeft_Press)
                    {
                        robot.Stage_Att = RobotState.STAGE_ATT.Select;
                        robot.changeStage_Loc(RobotState.CYCLE_DIRECTION.Down);
                    }
                }

                //2024 stage loc
                if (gamepad.YButton_Down && (robot.Stage_Stat == RobotState.STAGE_STAT.Elsewhere || robot.Stage_Stat == RobotState.STAGE_STAT.Park))
                {
                    if (gamepad.LTHRight_Press)
                    {
                        robot.changeStage_Att(RobotState.CYCLE_DIRECTION.Up);
                        robot.Stage_Loc = RobotState.STAGE_LOC.Select;
                    }
                    else if (gamepad.LTHLeft_Press)
                    {
                        robot.changeStage_Att(RobotState.CYCLE_DIRECTION.Down);
                        robot.Stage_Loc = RobotState.STAGE_LOC.Select;

                    }
                }

                // 2024 strat
                if (gamepad.BButton_Down)
                {
                    if (gamepad.LTHRight_Press)
                    {
                        robot.changeApp_Strat(RobotState.CYCLE_DIRECTION.Up);
                    }
                    else if (gamepad.LTHLeft_Press)
                    {
                        robot.changeApp_Strat(RobotState.CYCLE_DIRECTION.Down);
                    }
                }

                //2024 harm 
                if (gamepad.AButton_Down)
                {
                    if (gamepad.LTHLeft_Press)
                    {
                        robot.Harm++;
                        if (robot.Harm == 11)
                        {
                            robot.Harm = 0;

                        }
                        if (robot.Harm == 3)
                        {
                            robot.Harm = 0;
                        }
                    }
                    if (gamepad.LTHRight_Press)
                    {
                        robot.Harm--;
                        if (robot.Harm == 8)
                        {
                            robot.Harm = 0;
                        }
                        if (robot.Harm == -1)
                        {
                            robot.Harm = 2;
                        }
                    }
                }

                //2024 Mic
                if (gamepad.DpadUp_Press)
                {
                    robot.Mic++;
                    if (robot.Mic == 11)
                    {
                        robot.Mic = 0;
                    }
                    if (robot.Mic == 4)
                    {
                        robot.Mic = 0;
                    }
                }

                //2024 Spotlit 
                if (gamepad.DpadDown_Press)
                {
                    robot.changeLit(RobotState.CYCLE_DIRECTION.Up);
                }

                // 2024 Def / avo
                if (gamepad.DpadRight_Press)
                {
                    robot.Def_Rat++;
                    if (robot.Def_Rat == 11)
                    {
                        robot.Def_Rat = 0;
                    }
                    if (robot.Def_Rat == 4)
                    {
                        robot.Def_Rat = 0;
                    }
                }

                if (gamepad.DpadLeft_Press)
                {
                    robot.Avo_Rat++;
                    if (robot.Avo_Rat == 11)
                    {
                        robot.Avo_Rat = 0;
                    }
                    if (robot.Avo_Rat == 4)
                    {
                        robot.Avo_Rat = 0;
                    }
                }
            }

            // Values if robot is NoSho

            if (robot.NoSho == true)
            {
                if (gamepad.XButton_Down)
                {
                    if (gamepad.L3_Press)
                    {
                        robot.changeHP_Amp(RobotState.CYCLE_DIRECTION.Up);
                    }
                }

                if (gamepad.DpadUp_Press)
                {
                    robot.Mic++;
                    if (robot.Mic == 11)
                    {
                        robot.Mic = 0;
                    }
                    if (robot.Mic == 4)
                    {
                        robot.Mic = 0;
                    }
                }

            }

            // #Transact
            // **************************************************************
            // ***  TRANSACT TO DATABASE  ***
            // **************************************************************
            if (robot._ScouterName != RobotState.SCOUTER_NAME.Select_Name &&
                (robot.Acq_Loc != "Select" ||
                robot.Del_Dest != RobotState.DEL_DEST.Select ||
                robot.Acq_Center != 0))
            {
                robot.TransactionCheck = true;
            }
            else
            {
                robot.TransactionCheck = false;
            }

            //2023 EndAuto End of Autonomous transaction
            if (robot.AUTO && gamepad.BackButton_Press && !robot.NoSho &&
                robot._ScouterName != RobotState.SCOUTER_NAME.Select_Name)
            {
                if (robot.Current_Loc == RobotState.CURRENT_LOC.Source)
                {
                    robot.OpptT_StopWatch.Start();
                    robot.OpptT_StopWatch_running = true;
                }
                else if (robot.Current_Loc == RobotState.CURRENT_LOC.SubW)
                {
                    robot.AllyT_StopWatch.Start();
                    robot.AllyT_StopWatch_running = true;
                }

                transactToDatabase(robot, "StartMatch");
                transactToDatabase(robot, "EndAuto");
                robot.AUTO = false;
                robot.Acq_Center_Temp = 0;
                robot.Acq_Center = 0;

            }
            else if (gamepad.RightTrigger_Press && !robot.NoSho && robot.TransactionCheck == true)
            {
                if (robot.Acq_Loc != RobotState.CURRENT_LOC.Select.ToString() || robot.Acq_Center != 0)
                {
                    if (Settings.Default.redRight)
                    {
                        if (robot.color == "Red")
                        {
                            if (robot.Current_Loc == RobotState.CURRENT_LOC.Right)
                            {
                                robot.Acq_Loc_Temp = "AllyWing";
                            }
                            if (robot.Current_Loc == RobotState.CURRENT_LOC.Left)
                            {
                                robot.Acq_Loc_Temp = "OppWing";
                            }
                        }
                        else
                        {
                            if (robot.Current_Loc == RobotState.CURRENT_LOC.Right)
                            {
                                robot.Acq_Loc_Temp = "OppWing";
                            }
                            if (robot.Current_Loc == RobotState.CURRENT_LOC.Left)
                            {
                                robot.Acq_Loc_Temp = "AllyWing";
                            }
                        }
                    }
                    else
                    {
                        if (robot.color == "Red")
                        {
                            if (robot.Current_Loc == RobotState.CURRENT_LOC.Right)
                            {
                                robot.Acq_Loc_Temp = "OppWing";
                            }
                            if (robot.Current_Loc == RobotState.CURRENT_LOC.Left)
                            {
                                robot.Acq_Loc_Temp = "AllyWing";
                            }
                        }
                        else
                        {
                            if (robot.Current_Loc == RobotState.CURRENT_LOC.Right)
                            {
                                robot.Acq_Loc_Temp = "AllyWing";
                            }
                            if (robot.Current_Loc == RobotState.CURRENT_LOC.Left)
                            {
                                robot.Acq_Loc_Temp = "OppWing";
                            }
                        }
                    }
                    if (robot.Current_Loc == RobotState.CURRENT_LOC.Source)
                    {
                        robot.Acq_Loc_Temp = "Source";
                    }
                    if (robot.Current_Loc == RobotState.CURRENT_LOC.Neutral)
                    {
                        robot.Acq_Loc_Temp = "Neutral";
                    }
                    if (robot.Current_Loc == RobotState.CURRENT_LOC.SubW)
                    {
                        robot.Acq_Loc_Temp = "AllyWing";
                    }

                    robot.Acq_Center_Temp = robot.Acq_Center;

                    if (robot.Flag == 1)
                    {
                        if (robot.Acq_Center_Temp != 0 && robot.Acq_Loc_Temp != "Neutral")
                        {
                            robot.Acq_Loc_Temp = "Neutral";
                            robot.ScouterError = robot.ScouterError + 1000;
                        }
                    }
                    else if (robot.Flag == 0 && robot.Acq_Center_Temp != 0)
                    {
                        if (robot.Acq_Loc_Temp != "Neutral")
                        {
                            robot.Acq_Loc_Temp = "Neutral";
                            robot.ScouterError = robot.ScouterError + 1000;
                        }
                    }

                    transactToDatabase(robot, "Activities");

                    //Reset Temp Variables
                    robot.Acq_Loc_Temp = "Select";
                    robot.Acq_Center_Temp = 0;
                }
                else if (robot.Del_Dest != RobotState.DEL_DEST.Select)
                {

                    //Reset Temp Variables
                    robot.Acq_Center_Temp = 0;
                    robot.Acq_Loc_Temp = "Select";
                }

                //Reset Values
                robot.Del_Dest = RobotState.DEL_DEST.Select;
                robot.Acq_Loc = "Select";
                robot.Acq_Center = 0;
                robot.Flag = 0;
                robot.TransactionCheck = false;
                robot.Acq_Center_Temp = 0;
            }
            else if (gamepad.RightTrigger_Press && !robot.NoSho && robot.TransactionCheck == false)
            {
                robot.ScouterError = robot.ScouterError + 100000;
            }


            // 2023 Changing modes
            if (gamepad.BackButton_Press && robot.Current_Mode == RobotState.ROBOT_MODE.Auto && !robot.AUTO && !robot.NoSho)
            {
                robot.Desired_Mode = RobotState.ROBOT_MODE.Showtime;
                robot.Current_Mode = RobotState.ROBOT_MODE.Teleop;
            }
            else if (gamepad.BackButton_Press && robot.Current_Mode == RobotState.ROBOT_MODE.Teleop && !robot.NoSho)

            {
                robot.Desired_Mode = RobotState.ROBOT_MODE.Teleop;
                robot.Current_Mode = RobotState.ROBOT_MODE.Showtime;
                if (robot.ClimbTDouble == 0)
                {
                    robot.ClimbT_StopWatch.Start();
                    robot.ClimbT = robot.ClimbT_StopWatch.Elapsed;
                    robot.ClimbT_StopWatch_running = true;
                }
                robot.AllyT_StopWatch.Stop();
                robot.AllyT = robot.AllyT_StopWatch.Elapsed;
                robot.AllyT_StopWatch_running = false;

                robot.OpptT_StopWatch.Stop();
                robot.OpptT = robot.OpptT_StopWatch.Elapsed;
                robot.OpptT_StopWatch_running = false;

                robot.NeutT_StopWatch.Stop();
                robot.NeutT = robot.NeutT_StopWatch.Elapsed;
                robot.NeutT_StopWatch_running = false;
            }
            else if (gamepad.BackButton_Press && robot.Current_Mode == RobotState.ROBOT_MODE.Showtime && !robot.NoSho)
            {
                robot.Desired_Mode = RobotState.ROBOT_MODE.Showtime;
                robot.Current_Mode = RobotState.ROBOT_MODE.Teleop;

                robot.ClimbT_StopWatch.Stop();
                robot.ClimbT = robot.ClimbT_StopWatch.Elapsed;
                robot.ClimbT_StopWatch_running = false;
            }
        }
        public static void transactToDatabase(RobotState controller, string recordType)
        {
            if (controller._ScouterName != RobotState.SCOUTER_NAME.Select_Name && controller.TeamName != null)
            {
                if (!controller.NoSho &&
                    controller._ScouterName != RobotState.SCOUTER_NAME.Select_Name)
                {
                    if (controller.match_event == RobotState.MATCHEVENT_NAME.NoShow)
                    {
                        BackgroundCode.activity_record.match_event = controller.match_event.ToString()[0].ToString();
                        controller.NoSho = true;
                    }
                    else
                    {
                        BackgroundCode.activity_record.match_event = controller.match_event.ToString()[0].ToString();
                    }
                    BackgroundCode.activity_record.Team = controller.TeamName;
                    BackgroundCode.activity_record.Match = controller.Current_Match + 1;

                    switch (recordType)
                    {
                        case "StartMatch":
                            BackgroundCode.activity_record.Time = controller.Auto_Time.AddSeconds(-18);
                            break;
                        case "EndAuto":
                            BackgroundCode.activity_record.Time = controller.Auto_Time;
                            break;
                        default:
                            BackgroundCode.activity_record.Time = DateTime.Now;
                            break;
                    }
                    if (controller.Acq_Center_Temp != 0)
                    {
                        BackgroundCode.activity_record.Time = controller.CenteNoteTimeTemp;
                    }

                    BackgroundCode.activity_record.Mode = controller.Current_Mode.ToString();
                    BackgroundCode.activity_record.ScouterName = controller.getScouterName(RobotState.SCOUTER_NAME.Select_Name).ToString();
                    BackgroundCode.activity_record.RecordType = recordType;

                    //2024
                    BackgroundCode.activity_record.Leave = 0;
                    BackgroundCode.activity_record.AcqLoc = "-";
                    BackgroundCode.activity_record.AcqCenter = 0;
                    BackgroundCode.activity_record.AcqDis = 0;
                    BackgroundCode.activity_record.AcqDrp = 0;
                    BackgroundCode.activity_record.DelMiss = 0;
                    BackgroundCode.activity_record.DelOrig = "-";
                    BackgroundCode.activity_record.DelDest = "-";

                    if (controller == BackgroundCode.Robots[0])
                    {
                        BackgroundCode.activity_record.DriveSta = "red0";
                    }
                    else if (controller == BackgroundCode.Robots[1])
                    {
                        BackgroundCode.activity_record.DriveSta = "red1";
                    }
                    else if (controller == BackgroundCode.Robots[2])
                    {
                        BackgroundCode.activity_record.DriveSta = "red2";
                    }
                    else if (controller == BackgroundCode.Robots[3])
                    {
                        BackgroundCode.activity_record.DriveSta = "blue0";
                    }
                    else if (controller == BackgroundCode.Robots[4])
                    {
                        BackgroundCode.activity_record.DriveSta = "blue1";
                    }
                    else if (controller == BackgroundCode.Robots[5])
                    {
                        BackgroundCode.activity_record.DriveSta = "blue2";
                    }




                    BackgroundCode.activity_record.RobotSta = "-";
                    BackgroundCode.activity_record.HPAmp = "-";
                    BackgroundCode.activity_record.StageStat = "-";
                    BackgroundCode.activity_record.StageAtt = 9;
                    BackgroundCode.activity_record.StageLoc = "-";
                    BackgroundCode.activity_record.Harmony = 9;
                    BackgroundCode.activity_record.Spotlit = 9;
                    BackgroundCode.activity_record.ClimbT = 0;
                    BackgroundCode.activity_record.OZTime = 0;
                    BackgroundCode.activity_record.AZTime = 0;
                    BackgroundCode.activity_record.NZTime = 0;
                    BackgroundCode.activity_record.Mics = 9;
                    BackgroundCode.activity_record.Defense = 9;
                    BackgroundCode.activity_record.Avoidance = 9;
                    BackgroundCode.activity_record.Strategy = "-";


                    //Save Record to the database
                    BackgroundCode.seasonframework.ActivitySet.Add(BackgroundCode.activity_record);
                    BackgroundCode.seasonframework.SaveChanges(); // If you crash here migration isn't working

                    controller.match_event = RobotState.MATCHEVENT_NAME.Match_Event;

                    //Reset Match Event
                    controller.match_event = 0;
                }
                else if (controller.match_event == RobotState.MATCHEVENT_NAME.Match_Event)
                {
                    controller.ScouterError++;
                }
                controller.match_event = RobotState.MATCHEVENT_NAME.Match_Event;
            }
        }
    }
}
