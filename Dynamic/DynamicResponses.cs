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

            if (robot.OpptT_StopWatch == null) robot.OpptT_StopWatch = new Stopwatch();
            if (robot.NeutT_StopWatch == null) robot.NeutT_StopWatch = new Stopwatch();
            if (robot.AllyT_StopWatch == null) robot.AllyT_StopWatch = new Stopwatch();
            if (robot.ClimbT_StopWatch == null) robot.ClimbT_StopWatch = new Stopwatch();


            if (!robot.NoSho && robot._ScouterName != RobotState.SCOUTER_NAME.Select_Name)
            {
                //AUTO MODE
                if (robot.Current_Mode == RobotState.ROBOT_MODE.Auto)
                {
                    //2024 Setup Controls
                    if (gamepad.XButton_Down)
                    {
                        if (gamepad.LTHRight_Press)
                        {
                            robot.ChangeRobot_Set(RobotState.CYCLE_DIRECTION.Up);
                        }
                        if (gamepad.LTHLeft_Press)
                        {
                            robot.ChangeRobot_Set(RobotState.CYCLE_DIRECTION.Down);
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
                            robot.ChangeHP_Amp(RobotState.CYCLE_DIRECTION.Up);
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
                //TELEOP MODE
                else if (robot.Current_Mode == RobotState.ROBOT_MODE.Teleop)
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
                //SHOWTIME MODE
                else if (robot.Current_Mode == RobotState.ROBOT_MODE.Showtime)
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
                    if (gamepad.XButton_Down && !gamepad.AButton_Down)
                    {
                        if (gamepad.LTHRight_Press)
                        {
                            robot.ChangeStage_Stat(RobotState.CYCLE_DIRECTION.Up);
                        }
                        else if (gamepad.LTHLeft_Press)
                        {
                            robot.ChangeStage_Stat(RobotState.CYCLE_DIRECTION.Down);
                        }
                    }

                    //2024 stage Att
                    if (gamepad.YButton_Down && robot.Stage_Stat == RobotState.STAGE_STAT.Onstage)
                    {
                        if (gamepad.LTHRight_Press)
                        {
                            robot.Stage_Att = RobotState.STAGE_ATT.Select;
                            robot.ChangeStage_Loc(RobotState.CYCLE_DIRECTION.Up);
                        }
                        else if (gamepad.LTHLeft_Press)
                        {
                            robot.Stage_Att = RobotState.STAGE_ATT.Select;
                            robot.ChangeStage_Loc(RobotState.CYCLE_DIRECTION.Down);
                        }
                    }

                    //2024 stage loc
                    if (gamepad.YButton_Down && (robot.Stage_Stat == RobotState.STAGE_STAT.Elsewhere || robot.Stage_Stat == RobotState.STAGE_STAT.Park))
                    {
                        if (gamepad.LTHRight_Press)
                        {
                            robot.ChangeStage_Att(RobotState.CYCLE_DIRECTION.Up);
                            robot.Stage_Loc = RobotState.STAGE_LOC.Select;
                        }
                        else if (gamepad.LTHLeft_Press)
                        {
                            robot.ChangeStage_Att(RobotState.CYCLE_DIRECTION.Down);
                            robot.Stage_Loc = RobotState.STAGE_LOC.Select;

                        }
                    }

                    // 2024 strat
                    if (gamepad.BButton_Down)
                    {
                        if (gamepad.LTHRight_Press)
                        {
                            robot.ChangeApp_Strat(RobotState.CYCLE_DIRECTION.Up);
                        }
                        else if (gamepad.LTHLeft_Press)
                        {
                            robot.ChangeApp_Strat(RobotState.CYCLE_DIRECTION.Down);
                        }
                    }

                    //2024 harm 
                    if (gamepad.AButton_Down && !gamepad.XButton_Down)
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
                        robot.ChangeLit(RobotState.CYCLE_DIRECTION.Up);
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
                //Any mode

                // 2024 Changing modes
                if (gamepad.BackButton_Press && robot.Current_Mode == RobotState.ROBOT_MODE.Auto && !robot.AUTO)
                {
                    robot.Desired_Mode = RobotState.ROBOT_MODE.Showtime;
                    robot.Current_Mode = RobotState.ROBOT_MODE.Teleop;
                }
                else if (gamepad.BackButton_Press && robot.Current_Mode == RobotState.ROBOT_MODE.Teleop)

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
                else if (gamepad.BackButton_Press && robot.Current_Mode == RobotState.ROBOT_MODE.Showtime)
                {
                    robot.Desired_Mode = RobotState.ROBOT_MODE.Showtime;
                    robot.Current_Mode = RobotState.ROBOT_MODE.Teleop;

                    robot.ClimbT_StopWatch.Stop();
                    robot.ClimbT = robot.ClimbT_StopWatch.Elapsed;
                    robot.ClimbT_StopWatch_running = false;
                }

                //2024 Acquire transaction
                if (robot.Acq_Loc != "Select" || robot.Del_Dest != RobotState.DEL_DEST.Select || robot.Acq_Center != 0)
                {
                    robot.TransactionCheck = true;
                }
                else
                {
                    robot.TransactionCheck = false;
                }

                //2024 EndAuto End of Autonomous transaction
                if (robot.AUTO && gamepad.BackButton_Press)
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

                    TransactToDatabase(robot, "StartMatch", false);
                    robot.AUTO = false;
                    robot.Acq_Center_Temp = 0;
                    robot.Acq_Center = 0;
                }
                else if (gamepad.RightTrigger_Press && robot.TransactionCheck == true)
                {
                    TransactToDatabase(robot, "Activities", false);
                }
                else if (gamepad.RightTrigger_Press && robot.TransactionCheck == false)
                {
                    robot.ScouterError += 100000;
                }
            }

            // Values if robot is NoSho
            else if (robot.NoSho)
            {
                if (gamepad.XButton_Down)
                {
                    if (gamepad.L3_Press)
                    {
                        robot.ChangeHP_Amp(RobotState.CYCLE_DIRECTION.Up);
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
        }
            
        public static void TransactToDatabase(RobotState controller, string recordType, bool isTest)
        {
            if (controller._ScouterName != RobotState.SCOUTER_NAME.Select_Name && controller.TeamName != null)
            {
                switch (recordType)
                {
                    case ("StartMatch"):
                        //Record start match time
                        BackgroundCode.activity_record.RecordType = "StartMatch";
                        controller.Auto_Time = DateTime.Now;
                        BackgroundCode.activity_record.Time = controller.Auto_Time.AddSeconds(-18);

                        BackgroundCode.activity_record.Team = BackgroundCode.Robots[controller.ScouterBox].TeamName;
                        BackgroundCode.activity_record.Match = Settings.Default.currentMatch;
                        BackgroundCode.activity_record.Mode = controller.Current_Mode.ToString();
                        BackgroundCode.activity_record.ScouterName = controller.GetScouterName().ToString();

                        BackgroundCode.activity_record.Match_event = "-";
                        BackgroundCode.activity_record.Leave = 0;
                        BackgroundCode.activity_record.AcqLoc = "-";
                        BackgroundCode.activity_record.AcqCenter = 0;
                        BackgroundCode.activity_record.AcqDis = 0;
                        BackgroundCode.activity_record.AcqDrp = 0;
                        BackgroundCode.activity_record.DelMiss = 0;
                        BackgroundCode.activity_record.DelOrig = "-";
                        BackgroundCode.activity_record.DelDest = "-";

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
                        BackgroundCode.activity_record.ScouterError = controller.ScouterError;

                        //Save Record to the database
                        BackgroundCode.seasonframework.ActivitySet.Add(BackgroundCode.activity_record);
                        BackgroundCode.seasonframework.SaveChanges(); // If you crash here migration isn't working



                        // End Auto line
                        BackgroundCode.activity_record.Team = BackgroundCode.Robots[controller.ScouterBox].TeamName;
                        BackgroundCode.activity_record.Match = Settings.Default.currentMatch;
                        BackgroundCode.activity_record.Time = controller.Auto_Time;
                        BackgroundCode.activity_record.Mode = controller.Current_Mode.ToString();
                        BackgroundCode.activity_record.ScouterName = controller.GetScouterName().ToString();
                        BackgroundCode.activity_record.RecordType = "EndAuto";
                        BackgroundCode.activity_record.Match_event = "-";
                        BackgroundCode.activity_record.Leave = controller.Leave;
                        BackgroundCode.activity_record.AcqLoc = "-";
                        BackgroundCode.activity_record.AcqCenter = 0;
                        BackgroundCode.activity_record.AcqDis = 0;
                        BackgroundCode.activity_record.AcqDrp = 0;
                        BackgroundCode.activity_record.DelMiss = 0;
                        BackgroundCode.activity_record.DelOrig = "-";
                        BackgroundCode.activity_record.DelDest = "-";

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

                        if (controller.Robot_Set == RobotState.ROBOT_SET.Select)
                        {
                            BackgroundCode.activity_record.RobotSta = "Z";
                            controller.ScouterError++;

                        }
                        else
                        {
                            BackgroundCode.activity_record.RobotSta = controller.Robot_Set.ToString();
                        }

                        if (controller.HP_Amp == RobotState.HP_AMP.Select)
                        {
                            BackgroundCode.activity_record.HPAmp = "Z";
                            controller.ScouterError++;
                        }
                        else
                        {
                            BackgroundCode.activity_record.HPAmp = controller.HP_Amp.ToString();
                        }

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
                        BackgroundCode.activity_record.ScouterError = controller.ScouterError;
                        controller.AUTO = false;
                        controller.Acq_Center_Temp = 0;
                        controller.Acq_Center = 0;


                        //Save Record to the database
                        BackgroundCode.seasonframework.ActivitySet.Add(BackgroundCode.activity_record);
                        BackgroundCode.seasonframework.SaveChanges(); // If you crash here migration isn't working
                        break;
                    case ("Activities"):
                        if (controller.Acq_Loc != RobotState.CURRENT_LOC.Select.ToString() || controller.Acq_Center != 0)
                        {
                            if (Settings.Default.redRight == true)
                            {
                                if (controller.color == "Red")
                                {
                                    if (controller.Current_Loc == RobotState.CURRENT_LOC.Right)
                                    {
                                        controller.Acq_Loc_Temp = "AllyWing";
                                    }
                                    if (controller.Current_Loc == RobotState.CURRENT_LOC.Left)
                                    {
                                        controller.Acq_Loc_Temp = "OppWing";
                                    }
                                }
                                else
                                {
                                    if (controller.Current_Loc == RobotState.CURRENT_LOC.Right)
                                    {
                                        controller.Acq_Loc_Temp = "OppWing";
                                    }
                                    if (controller.Current_Loc == RobotState.CURRENT_LOC.Left)
                                    {
                                        controller.Acq_Loc_Temp = "AllyWing";
                                    }
                                }
                            }
                            else
                            {
                                if (controller.color == "Red")
                                {
                                    if (controller.Current_Loc == RobotState.CURRENT_LOC.Right)
                                    {
                                        controller.Acq_Loc_Temp = "OppWing";
                                    }
                                    if (controller.Current_Loc == RobotState.CURRENT_LOC.Left)
                                    {
                                        controller.Acq_Loc_Temp = "AllyWing";
                                    }
                                }
                                else
                                {
                                    if (controller.Current_Loc == RobotState.CURRENT_LOC.Right)
                                    {
                                        controller.Acq_Loc_Temp = "AllyWing";
                                    }
                                    if (controller.Current_Loc == RobotState.CURRENT_LOC.Left)
                                    {
                                        controller.Acq_Loc_Temp = "OppWing";
                                    }
                                }
                            }
                            if (controller.Current_Loc == RobotState.CURRENT_LOC.Source)
                            {
                                controller.Acq_Loc_Temp = "Source";
                            }
                            if (controller.Current_Loc == RobotState.CURRENT_LOC.Neutral)
                            {
                                controller.Acq_Loc_Temp = "Neutral";
                            }
                            if (controller.Current_Loc == RobotState.CURRENT_LOC.SubW)
                            {
                                controller.Acq_Loc_Temp = "AllyWing";
                            }

                            controller.Acq_Center_Temp = controller.Acq_Center;

                            if (controller.Flag == 1)
                            {
                                BackgroundCode.activity_record.Leave = 0;

                                if (controller.Acq_Center_Temp != 0 && controller.Acq_Loc_Temp != "Neutral")
                                {
                                    controller.Acq_Loc_Temp = "Neutral";
                                    controller.ScouterError += 1000;
                                }
                                BackgroundCode.activity_record.AcqLoc = controller.Acq_Loc_Temp.ToString();
                                BackgroundCode.activity_record.AcqCenter = controller.Acq_Center_Temp;
                                if (controller.Acq_Center_Temp != 0)
                                {
                                    BackgroundCode.activity_record.Time = controller.CenteNoteTimeTemp;
                                }
                                else
                                {
                                    BackgroundCode.activity_record.Time = DateTime.Now;
                                }

                                if (controller.Acq_Center != 0)
                                {
                                    BackgroundCode.activity_record.AcqDis = -1;
                                    BackgroundCode.activity_record.AcqDrp = 0;
                                }
                                else
                                {
                                    BackgroundCode.activity_record.AcqDis = 0;
                                    BackgroundCode.activity_record.AcqDrp = 1;
                                }

                                BackgroundCode.activity_record.DelMiss = 0;
                                BackgroundCode.activity_record.DelOrig = "-";
                                BackgroundCode.activity_record.DelDest = "-";
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
                                BackgroundCode.activity_record.Team = BackgroundCode.Robots[controller.ScouterBox].TeamName;
                                BackgroundCode.activity_record.Match = Settings.Default.currentMatch;
                                BackgroundCode.activity_record.Mode = "Auto";
                                BackgroundCode.activity_record.ScouterName = controller.GetScouterName().ToString();
                                BackgroundCode.activity_record.RecordType = "Activities";
                                BackgroundCode.activity_record.Match_event = "-";
                                BackgroundCode.activity_record.ScouterError = controller.ScouterError;


                                //Save Record to the database
                                BackgroundCode.seasonframework.ActivitySet.Add(BackgroundCode.activity_record);
                                BackgroundCode.seasonframework.SaveChanges(); // If you crash here migration isn't working


                                //Reset Temp Variables
                                controller.Acq_Loc_Temp = "Select";
                                controller.Acq_Center_Temp = 0;
                            }
                            else if (controller.Flag == 0 && controller.Acq_Center_Temp != 0)
                            {
                                BackgroundCode.activity_record.Leave = 0;
                                if (controller.Acq_Loc_Temp != "Neutral")
                                {
                                    controller.Acq_Loc_Temp = "Neutral";
                                    controller.ScouterError += 1000;
                                }

                                BackgroundCode.activity_record.AcqLoc = controller.Acq_Loc_Temp.ToString();
                                BackgroundCode.activity_record.AcqCenter = controller.Acq_Center_Temp;
                                BackgroundCode.activity_record.Time = controller.CenteNoteTimeTemp;

                                BackgroundCode.activity_record.AcqDrp = 0;
                                BackgroundCode.activity_record.AcqDis = 1;
                                BackgroundCode.activity_record.DelMiss = 0;
                                BackgroundCode.activity_record.DelOrig = "-";
                                BackgroundCode.activity_record.DelDest = "-";
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
                                BackgroundCode.activity_record.Team = BackgroundCode.Robots[controller.ScouterBox].TeamName;
                                BackgroundCode.activity_record.Match = Settings.Default.currentMatch;
                                BackgroundCode.activity_record.Mode = "Auto";
                                BackgroundCode.activity_record.ScouterName = controller.GetScouterName().ToString();
                                BackgroundCode.activity_record.RecordType = "Activities";
                                BackgroundCode.activity_record.Match_event = "-";
                                BackgroundCode.activity_record.ScouterError = controller.ScouterError;

                                //Save Record to the database
                                BackgroundCode.seasonframework.ActivitySet.Add(BackgroundCode.activity_record);
                                BackgroundCode.seasonframework.SaveChanges(); // If you crash here migration isn't working
                            }
                        }
                        else if (controller.Del_Dest != RobotState.DEL_DEST.Select)
                        {
                            BackgroundCode.activity_record.Leave = 0;

                            BackgroundCode.activity_record.AcqCenter = controller.Acq_Center_Temp;
                            if (controller.Acq_Center_Temp != 0)
                            {
                                BackgroundCode.activity_record.Time = controller.CenteNoteTimeTemp;
                            }
                            else
                            {
                                BackgroundCode.activity_record.Time = DateTime.Now;
                            }
                            BackgroundCode.activity_record.AcqDis = 0;
                            BackgroundCode.activity_record.AcqDrp = 0;
                            BackgroundCode.activity_record.DelMiss = controller.Flag;

                            // red right logic 
                            if (Settings.Default.redRight == true)
                            {
                                if (controller.color == "Red")
                                {
                                    if (controller.Current_Loc == RobotState.CURRENT_LOC.Right)
                                    {
                                        BackgroundCode.activity_record.DelOrig = "AllyW";
                                    }
                                    if (controller.Current_Loc == RobotState.CURRENT_LOC.Left)
                                    {
                                        BackgroundCode.activity_record.DelOrig = "OppW";
                                    }
                                }
                                else
                                {
                                    if (controller.Current_Loc == RobotState.CURRENT_LOC.Right)
                                    {
                                        BackgroundCode.activity_record.DelOrig = "OppW";
                                    }
                                    if (controller.Current_Loc == RobotState.CURRENT_LOC.Left)
                                    {
                                        BackgroundCode.activity_record.DelOrig = "AllyW";
                                    }
                                }
                            }
                            else
                            {
                                if (controller.color == "Red")
                                {
                                    if (controller.Current_Loc == RobotState.CURRENT_LOC.Right)
                                    {
                                        BackgroundCode.activity_record.DelOrig = "OppW";
                                    }
                                    if (controller.Current_Loc == RobotState.CURRENT_LOC.Left)
                                    {
                                        BackgroundCode.activity_record.DelOrig = "AllyW";
                                    }
                                }
                                else
                                {
                                    if (controller.Current_Loc == RobotState.CURRENT_LOC.Right)
                                    {
                                        BackgroundCode.activity_record.DelOrig = "AllyW";
                                    }
                                    if (controller.Current_Loc == RobotState.CURRENT_LOC.Left)
                                    {
                                        BackgroundCode.activity_record.DelOrig = "OppW";
                                    }
                                }
                            }
                            if (controller.Current_Loc == RobotState.CURRENT_LOC.Neutral)
                            {
                                BackgroundCode.activity_record.DelOrig = "Neut";
                            }
                            if (controller.Current_Loc == RobotState.CURRENT_LOC.SubW)
                            {
                                BackgroundCode.activity_record.DelOrig = "SubW";
                            }
                            if (controller.Current_Loc == RobotState.CURRENT_LOC.Source)
                            {
                                BackgroundCode.activity_record.DelOrig = "OppW";
                            }

                            if (controller.Current_Mode == RobotState.ROBOT_MODE.Showtime)
                            {
                                if (controller.Del_Dest == RobotState.DEL_DEST.Trap)
                                {
                                    BackgroundCode.activity_record.DelOrig = "ShowTime";
                                }
                            }

                            if (controller.Acq_Loc_Temp == "Select")
                            {
                                BackgroundCode.activity_record.AcqLoc = "Z";
                                controller.ScouterError += 10000000;
                            }
                            else
                            {
                                BackgroundCode.activity_record.AcqLoc = controller.Acq_Loc_Temp.ToString();
                            }

                            BackgroundCode.activity_record.DelDest = controller.Del_Dest.ToString();

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
                            BackgroundCode.activity_record.Team = BackgroundCode.Robots[controller.ScouterBox].TeamName;
                            BackgroundCode.activity_record.Match = Settings.Default.currentMatch;
                            BackgroundCode.activity_record.Mode = controller.Current_Mode.ToString();
                            BackgroundCode.activity_record.ScouterName = controller.GetScouterName().ToString();
                            BackgroundCode.activity_record.RecordType = "Activities";
                            BackgroundCode.activity_record.Match_event = "-";
                            BackgroundCode.activity_record.ScouterError = controller.ScouterError;

                            //Save Record to the database
                            BackgroundCode.seasonframework.ActivitySet.Add(BackgroundCode.activity_record);
                            BackgroundCode.seasonframework.SaveChanges(); // If you crash here migration isn't working

                            //Reset Temp Variables
                            controller.Acq_Center_Temp = 0;
                            controller.Acq_Loc_Temp = "Select";
                        }

                        //Reset Values
                        controller.Del_Dest = RobotState.DEL_DEST.Select;
                        controller.Acq_Loc = "Select";
                        controller.Acq_Center = 0;
                        controller.Flag = 0;
                        controller.TransactionCheck = false;
                        break;
                    case ("EndMatch"):
                        if (controller._ScouterName != RobotState.SCOUTER_NAME.Select_Name && controller.NoSho == false)
                        {
                            BackgroundCode.activity_record.Team = BackgroundCode.Robots[controller.ScouterBox].TeamName;
                            BackgroundCode.activity_record.Match = Settings.Default.currentMatch;
                            BackgroundCode.activity_record.Time = DateTime.Now;
                            BackgroundCode.activity_record.Mode = controller.Current_Mode.ToString();
                            controller.Current_Mode = RobotState.ROBOT_MODE.Auto;
                            BackgroundCode.activity_record.ScouterName = controller.GetScouterName().ToString();
                            BackgroundCode.activity_record.RecordType = "EndMatch";
                            BackgroundCode.activity_record.Match_event = "-";
                            BackgroundCode.activity_record.Leave = controller.Leave;
                            if (controller.Acq_Loc_Temp != "Select" && controller.Acq_Loc_Temp != "Pre")
                            {
                                BackgroundCode.activity_record.AcqLoc = controller.Acq_Loc_Temp;
                            }
                            else
                            {
                                BackgroundCode.activity_record.AcqLoc = "-";
                            }
                            BackgroundCode.activity_record.AcqCenter = 0;
                            BackgroundCode.activity_record.AcqDis = 0;
                            BackgroundCode.activity_record.AcqDrp = 0;
                            BackgroundCode.activity_record.DelOrig = "-";
                            BackgroundCode.activity_record.DelDest = "-";
                            BackgroundCode.activity_record.DelMiss = 0;

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

                            if (controller.App_Strat == RobotState.APP_STRAT.Select)
                            {
                                BackgroundCode.activity_record.Strategy = "Z";
                                controller.ScouterError += 10;
                            }
                            else
                            {
                                BackgroundCode.activity_record.Strategy = controller.App_Strat.ToString();
                            }

                            if (controller.Robot_Set == RobotState.ROBOT_SET.Select)
                            {
                                BackgroundCode.activity_record.RobotSta = "Z";
                            }
                            else
                            {
                                BackgroundCode.activity_record.RobotSta = controller.Robot_Set.ToString();
                            }

                            if (controller.HP_Amp == RobotState.HP_AMP.Select)
                            {
                                BackgroundCode.activity_record.HPAmp = "Z";
                            }
                            else
                            {
                                BackgroundCode.activity_record.HPAmp = controller.HP_Amp.ToString();
                            }

                            if (controller.Stage_Stat == RobotState.STAGE_STAT.Select)
                            {
                                BackgroundCode.activity_record.StageStat = "Z";
                                controller.ScouterError += 10;
                            }
                            else if (controller.Stage_Stat == RobotState.STAGE_STAT.Onstage)
                            {
                                BackgroundCode.activity_record.StageStat = "On";
                            }
                            else if (controller.Stage_Stat == RobotState.STAGE_STAT.Elsewhere)
                            {
                                BackgroundCode.activity_record.StageStat = "Else";
                            }
                            else if (controller.Stage_Stat == RobotState.STAGE_STAT.Park)
                            {
                                BackgroundCode.activity_record.StageStat = "Park";
                            }

                            if (controller.Stage_Loc == RobotState.STAGE_LOC.Select)
                            {
                                if (controller.Stage_Stat != RobotState.STAGE_STAT.Onstage)
                                {
                                    BackgroundCode.activity_record.StageLoc = "A";
                                }
                                else
                                {
                                    BackgroundCode.activity_record.StageLoc = "Z";
                                    controller.ScouterError += 10;
                                }
                            }
                            else
                            {
                                BackgroundCode.activity_record.StageLoc = controller.Stage_Loc.ToString();
                            }

                            if (controller.Stage_Stat == RobotState.STAGE_STAT.Onstage)
                            {
                                BackgroundCode.activity_record.StageAtt = 1;
                            }
                            else if (controller.Stage_Stat == RobotState.STAGE_STAT.Park)
                            {
                                if (controller.Stage_Att == RobotState.STAGE_ATT.Select)
                                {
                                    BackgroundCode.activity_record.StageAtt = 10;
                                    controller.ScouterError += 10;
                                }
                                else if (controller.Stage_Att == RobotState.STAGE_ATT.Y)
                                {
                                    BackgroundCode.activity_record.StageAtt = -1;
                                }
                                else if (controller.Stage_Att == RobotState.STAGE_ATT.N)
                                {
                                    BackgroundCode.activity_record.StageAtt = 0;
                                }
                            }
                            else if (controller.Stage_Stat == RobotState.STAGE_STAT.Elsewhere)
                            {
                                if (controller.Stage_Att == RobotState.STAGE_ATT.Select)
                                {
                                    BackgroundCode.activity_record.StageAtt = 10;
                                    controller.ScouterError += 10;
                                }
                                else if (controller.Stage_Att == RobotState.STAGE_ATT.Y)
                                {
                                    BackgroundCode.activity_record.StageAtt = -1;
                                }
                                else if (controller.Stage_Att == RobotState.STAGE_ATT.N)
                                {
                                    BackgroundCode.activity_record.StageAtt = 0;
                                }
                            }
                            else if (controller.Stage_Stat == RobotState.STAGE_STAT.Select)
                            {
                                BackgroundCode.activity_record.StageAtt = 9;
                            }

                            // Harmony
                            if (controller.Stage_Stat != RobotState.STAGE_STAT.Onstage)
                            {
                                BackgroundCode.activity_record.Harmony = 9;
                            }
                            else if (controller.Harm == 10)
                            {
                                BackgroundCode.activity_record.Harmony = controller.Harm;
                                controller.ScouterError += 10;
                            }
                            else
                            {
                                BackgroundCode.activity_record.Harmony = controller.Harm;
                            }

                            // Spot lit
                            if (controller.Stage_Stat != RobotState.STAGE_STAT.Onstage)
                            {
                                BackgroundCode.activity_record.Spotlit = 9;
                            }
                            else if (controller.Lit == RobotState.LIT.Select)
                            {
                                BackgroundCode.activity_record.Spotlit = 10;
                                controller.ScouterError += 10;
                            }
                            else if (controller.Lit == RobotState.LIT.Y)
                            {
                                BackgroundCode.activity_record.Spotlit = 1;
                            }
                            else if (controller.Lit == RobotState.LIT.N)
                            {
                                BackgroundCode.activity_record.Spotlit = 0;
                            }

                            if (controller.Stage_Stat == RobotState.STAGE_STAT.Onstage ||
                                ((controller.Stage_Stat == RobotState.STAGE_STAT.Park || controller.Stage_Stat == RobotState.STAGE_STAT.Elsewhere) &&
                                controller.Stage_Att == RobotState.STAGE_ATT.Y))
                            {
                                controller.ClimbTDouble = controller.ClimbT_StopWatch.Elapsed.TotalSeconds;
                                BackgroundCode.activity_record.ClimbT = controller.ClimbTDouble;
                            }
                            else
                            {
                                BackgroundCode.activity_record.ClimbT = 0;
                            }
                            controller.AllyTDouble = controller.AllyT_StopWatch.Elapsed.TotalSeconds;
                            controller.OpptTDouble = controller.OpptT_StopWatch.Elapsed.TotalSeconds;
                            controller.NeutTDouble = controller.NeutT_StopWatch.Elapsed.TotalSeconds;
                            BackgroundCode.activity_record.OZTime = controller.OpptTDouble;
                            BackgroundCode.activity_record.AZTime = controller.AllyTDouble;
                            BackgroundCode.activity_record.NZTime = controller.NeutTDouble;
                            BackgroundCode.activity_record.Mics = controller.Mic;
                            if (controller.HP_Amp == RobotState.HP_AMP.N)
                            {
                                BackgroundCode.activity_record.Mics = 9;
                            }
                            else if (controller.Mic == 10)
                            {
                                controller.ScouterError += 10;
                            }

                            BackgroundCode.activity_record.Defense = controller.Def_Rat;
                            if (controller.Def_Rat == 10)
                            {
                                controller.ScouterError += 10;
                            }
                            BackgroundCode.activity_record.Avoidance = controller.Avo_Rat;
                            if (controller.Avo_Rat == 10)
                            {
                                controller.ScouterError += 10;
                            }

                            BackgroundCode.activity_record.ScouterError = controller.ScouterError;

                            //Save Record to the database
                            BackgroundCode.seasonframework.ActivitySet.Add(BackgroundCode.activity_record);
                            BackgroundCode.seasonframework.SaveChanges(); // If you crash here migration isn't working
                        }
                        else if (controller.NoSho == true)
                        {
                            BackgroundCode.activity_record.Team = controller.TeamName;
                            BackgroundCode.activity_record.Match = Settings.Default.currentMatch;
                            BackgroundCode.activity_record.Time = DateTime.Now;
                            BackgroundCode.activity_record.Mode = controller.Current_Mode.ToString();
                            controller.Current_Mode = RobotState.ROBOT_MODE.Auto;
                            BackgroundCode.activity_record.ScouterName = controller.GetScouterName().ToString();
                            BackgroundCode.activity_record.RecordType = "EndMatch";
                            BackgroundCode.activity_record.Match_event = "-";
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

                            if (controller.HP_Amp == RobotState.HP_AMP.Select)
                            {
                                BackgroundCode.activity_record.HPAmp = "Z";
                            }
                            else
                            {
                                BackgroundCode.activity_record.HPAmp = controller.HP_Amp.ToString();
                            }

                            BackgroundCode.activity_record.StageStat = "-";
                            BackgroundCode.activity_record.StageAtt = 9;
                            BackgroundCode.activity_record.StageLoc = "-";
                            BackgroundCode.activity_record.Harmony = 9;
                            BackgroundCode.activity_record.Spotlit = 9;
                            BackgroundCode.activity_record.ClimbT = 0;
                            BackgroundCode.activity_record.OZTime = 0;
                            BackgroundCode.activity_record.AZTime = 0;
                            BackgroundCode.activity_record.NZTime = 0;
                            BackgroundCode.activity_record.Mics = controller.Mic;

                            if (controller.HP_Amp == RobotState.HP_AMP.N)
                            {
                                BackgroundCode.activity_record.Mics = 9;
                            }
                            else if (controller.Mic == 10)
                            {
                                controller.ScouterError += 10;
                            }

                            BackgroundCode.activity_record.Defense = 9;
                            BackgroundCode.activity_record.Avoidance = 9;
                            BackgroundCode.activity_record.Strategy = "-";
                            BackgroundCode.activity_record.ScouterError = controller.ScouterError;

                            //Save Record to the database
                            BackgroundCode.seasonframework.ActivitySet.Add(BackgroundCode.activity_record);
                            BackgroundCode.seasonframework.SaveChanges(); // If you crash here migration isn't working
                        }
                        break;
                    case ("Match_Event"):
                        if (controller.Match_event == RobotState.MATCHEVENT_NAME.NoShow)
                        {
                            BackgroundCode.activity_record.Match_event = controller.Match_event.ToString().ToString();
                            controller.NoSho = true;
                        }
                        else
                        {
                            BackgroundCode.activity_record.Match_event = controller.Match_event.ToString().ToString(); //If you crash here you didn't load matches
                        }
                        BackgroundCode.activity_record.Team = BackgroundCode.Robots[controller.ScouterBox].TeamName;
                        BackgroundCode.activity_record.Match = Settings.Default.currentMatch;
                        BackgroundCode.activity_record.Time = DateTime.Now;
                        BackgroundCode.activity_record.Mode = controller.Current_Mode.ToString();
                        BackgroundCode.activity_record.ScouterName = controller.GetScouterName().ToString();
                        BackgroundCode.activity_record.RecordType = "Match_Event";

                        //2024
                        BackgroundCode.activity_record.Leave = 0;
                        BackgroundCode.activity_record.AcqLoc = "-";
                        BackgroundCode.activity_record.AcqCenter = 0;
                        BackgroundCode.activity_record.AcqDis = 0;
                        BackgroundCode.activity_record.AcqDrp = 0;
                        BackgroundCode.activity_record.DelMiss = 0;
                        BackgroundCode.activity_record.DelOrig = "-";
                        BackgroundCode.activity_record.DelDest = "-";

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

                        controller.Match_event = RobotState.MATCHEVENT_NAME.Match_Event;

                        //Reset Match Event
                        controller.Match_event = 0;
                        break;
                    default:
                        MessageBox.Show("Error: Record Type not found");
                        break;
                }
            }
        }

        public static void ResetValues()
        {
            for (int i = 0; i < 6; i++)
            {
                BackgroundCode.Robots[i].Current_Mode = RobotState.ROBOT_MODE.Auto;
                BackgroundCode.Robots[i].Leave = 0;
                BackgroundCode.Robots[i].AUTO = true;
                BackgroundCode.Robots[i].HP_Amp = RobotState.HP_AMP.Select;
                BackgroundCode.Robots[i].Robot_Set = RobotState.ROBOT_SET.SubW;
                BackgroundCode.Robots[i].Current_Loc = RobotState.CURRENT_LOC.SubW;

                BackgroundCode.Robots[i].Acq_Center = 0;
                BackgroundCode.Robots[i].Acq_Center_Temp = 0;
                BackgroundCode.Robots[i].Acq_Loc = "Select";
                BackgroundCode.Robots[i].Acq_Loc_Temp = "Pre";

                BackgroundCode.Robots[i].NoSho = false;

                BackgroundCode.Robots[i].Flag = 0;
                BackgroundCode.Robots[i].Del_Dest = RobotState.DEL_DEST.Select;
                BackgroundCode.Robots[i].TransactionCheck = false;

                BackgroundCode.Robots[i].App_Strat = RobotState.APP_STRAT.Select;
                BackgroundCode.Robots[i].Stage_Stat = RobotState.STAGE_STAT.Select;
                BackgroundCode.Robots[i].Stage_Loc = RobotState.STAGE_LOC.Select;
                BackgroundCode.Robots[i].Stage_Att = RobotState.STAGE_ATT.Select;
                BackgroundCode.Robots[i].Harm = 0;
                BackgroundCode.Robots[i].Lit = RobotState.LIT.Select;

                if (BackgroundCode.Robots[i].ClimbT_StopWatch != null)
                {
                    BackgroundCode.Robots[i].ClimbT_StopWatch.Stop();
                    BackgroundCode.Robots[i].ClimbT_StopWatch.Reset();
                    BackgroundCode.Robots[i].ClimbT = TimeSpan.Zero;
                }

                if (BackgroundCode.Robots[i].AllyT_StopWatch != null)
                {
                    BackgroundCode.Robots[i].AllyT_StopWatch.Stop();
                    BackgroundCode.Robots[i].AllyT_StopWatch.Reset();
                    BackgroundCode.Robots[i].AllyT = TimeSpan.Zero;
                }
                if (BackgroundCode.Robots[i].OpptT_StopWatch != null)
                {
                    BackgroundCode.Robots[i].OpptT_StopWatch.Stop();
                    BackgroundCode.Robots[i].OpptT_StopWatch.Reset();
                    BackgroundCode.Robots[i].OpptT = TimeSpan.Zero;
                }
                if (BackgroundCode.Robots[i].NeutT_StopWatch != null)
                {
                    BackgroundCode.Robots[i].NeutT_StopWatch.Stop();
                    BackgroundCode.Robots[i].NeutT_StopWatch.Reset();
                    BackgroundCode.Robots[i].NeutT = TimeSpan.Zero;
                }

                BackgroundCode.Robots[i].ClimbTDouble = 0;
                BackgroundCode.Robots[i].AllyTDouble = 0;
                BackgroundCode.Robots[i].OpptTDouble = 0;
                BackgroundCode.Robots[i].NeutTDouble = 0;

                BackgroundCode.Robots[i].Mic = 0;
                BackgroundCode.Robots[i].Def_Rat = 0;
                BackgroundCode.Robots[i].Avo_Rat = 0;
                BackgroundCode.Robots[i].ScouterError = 0;
                BackgroundCode.Robots[i].Coop = 0;
            }
        }

    }
}
