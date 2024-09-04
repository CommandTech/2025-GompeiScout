using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScoutingCodeRedo.Properties;
using ScoutingCodeRedo.Static;
using ScoutingCodeRedo.Static.GamePadFolder;

namespace ScoutingCodeRedo.Dynamic
{
    internal class DynamicResponses
    {
        public void readStick(Static.GamePad[] gpArray, int controllerNumber)
        {
            GamePad gamepad = gpArray[controllerNumber];
            gamepad.Update();

            var robot = BackgroundCode.Robots[controllerNumber];

            // #Auto
            // **************************************************************
            // *** Auto MODE ***
            // **************************************************************
            if (robot.Current_Mode == RobotState.ROBOT_MODE.Auto && !robot.NoSho)
            {
                //2024 Scouter Names
                if (gamepad.XButton_Down)
                {
                    if (gamepad.RTHRight_Press)
                    {
                        robot.changeScouterName(RobotState.CYCLE_DIRECTION.Up);
                    }
                    if (gamepad.RTHLeft_Press)
                    {
                        robot.changeScouterName(RobotState.CYCLE_DIRECTION.Down);
                    }
                }

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

            // 2024 Changing modes
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
    }
}
