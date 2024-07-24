using System;
using System.Collections.Generic;
using System.Diagnostics;
using SharpDX.XInput;
using ScoutingCodeRedo.Static;
using SharpDX.DirectInput;
using SharpDX;


namespace ScoutingCodeRedo.Dynamic
{
    class Controllers
    {
        public void setScore()
        {
            RobotState.Red_Score = 0;
            RobotState.Blue_Score = 0;
        }

        public static RobotState[] rs;   //Objects for storing Match State

        // #Rumble
        //Controller rumble0 = new Controller((UserIndex)0);
        //Controller rumble1 = new Controller((UserIndex)1);
        //Controller rumble2 = new Controller((UserIndex)2);
        //Controller rumble3 = new Controller((UserIndex)3);
        //Controller rumble4 = new Controller((UserIndex)4);
        //Controller rumble5 = new Controller((UserIndex)5);

        Vibration vibration = new Vibration { LeftMotorSpeed = 65535, RightMotorSpeed = 65535 };
        Vibration vibration2 = new Vibration { LeftMotorSpeed = 0, RightMotorSpeed = 0 };

        Activity activity_record = new Activity();              //This is the activity for one Acquire and Scoring cycle.  We also save when an Event Activity is selected.       
        SeasonContext seasonframework = new SeasonContext();    //This is the context, meaning the entire database structure supporting this application.

        Static.Utilities utilities = new Static.Utilities();
        public Stopwatch stopwatch = new Stopwatch();
        public static Dictionary<int, int> controllerNumberMap = new Dictionary<int, int>
        {
            {0, 0},
            {1, 1},
            {2, 2},
            {3, 3},
            {4, 4},
            {5, 5},
        };

        public static Dictionary<int, RobotState.SCOUTER_NAME> ScouterNameMap = new Dictionary<int, RobotState.SCOUTER_NAME>
        {
            {0, RobotState.SCOUTER_NAME.Select_Name},
            {1, RobotState.SCOUTER_NAME.Select_Name},
            {2, RobotState.SCOUTER_NAME.Select_Name},
            {3, RobotState.SCOUTER_NAME.Select_Name},
            {4, RobotState.SCOUTER_NAME.Select_Name},
            {5, RobotState.SCOUTER_NAME.Select_Name},
        };

        public TimeSpan Zero { get; private set; }

        //getScoreZone to getScoreZone all the joysticks connected to the computer
        public Joystick[] GetSticks(DirectInput Input, SharpDX.DirectInput.Joystick stick, Joystick[] Sticks, Joystick stick1)
        {
            List<SharpDX.DirectInput.Joystick> sticks = new List<SharpDX.DirectInput.Joystick>(); //Creates the list of joysticks connected to the computer via USB.
            foreach (DeviceInstance device in Input.GetDevices(DeviceClass.GameControl, DeviceEnumerationFlags.AttachedOnly))
            {
                //Creates a joystick for each game device in USB Ports
                try
                {
                    stick = new SharpDX.DirectInput.Joystick(Input, device.InstanceGuid);
                    stick.Acquire();

                    //Gets the joysticks properties and sets the range for them.
                    foreach (DeviceObjectInstance deviceObject in stick.GetObjects())
                    {
                        if ((deviceObject.ObjectType & ObjectDeviceType.Axis) != 0)
                            stick.GetObjectPropertiesById((int)deviceObject.ObjectType).SetRange(-100, 100);
                    }

                    //Adds how ever many joysticks are connected to the computer into the sticks list.
                    sticks.Add(stick);
                }
                catch (Exception) { }
            }
            return sticks.ToArray();
        }

        public RobotState getRobotState(int state)
        {
            state = Math.Max(0, state);
            state = Math.Min(5, state);
            return rs[state]; //If you crash here, you do not have a controller connected
        }

        public GamePad[] getGamePads()
        {
            //Connect to DirectInput and setup Joystick Objects
            DirectInput Input = new DirectInput();
            Joystick stick;
            GamePad gamepad;

            //Creates the list of joysticks connected to the computer via USB.
            List<SharpDX.DirectInput.Joystick> sticks = new List<SharpDX.DirectInput.Joystick>();
            List<GamePad> gamepads = new List<GamePad>();
            foreach (DeviceInstance device in Input.GetDevices(DeviceClass.GameControl, DeviceEnumerationFlags.AttachedOnly))
            {
                //Creates a joystick object for each game device in USB Ports
                try
                {
                    stick = new SharpDX.DirectInput.Joystick(Input, device.InstanceGuid);
                    stick.Acquire();

                    //Gets the joysticks properties and sets the range for them.
                    foreach (DeviceObjectInstance deviceObject in stick.GetObjects())
                    {
                        if ((deviceObject.ObjectType & ObjectDeviceType.Axis) != 0)
                            stick.GetObjectPropertiesById((int)deviceObject.ObjectType).SetRange(-100, 100);
                    }

                    gamepad = new GamePad(stick);

                    //Adds how ever many joysticks are connected to the computer into the sticks list.
                    sticks.Add(stick);
                    gamepads.Add(gamepad);
                    Console.WriteLine(stick.Information.InstanceName);
                }
                catch (Exception) { }

                //Initiate Match State objects
                rs = new RobotState[6];
                rs[0] = new RobotState();
                rs[1] = new RobotState();
                rs[2] = new RobotState();
                rs[3] = new RobotState();
                rs[4] = new RobotState();
                rs[5] = new RobotState();
                rs[0].color = "Red";
                rs[1].color = "Red";
                rs[2].color = "Red";
                rs[3].color = "Blue";
                rs[4].color = "Blue";
                rs[5].color = "Blue";
            }
            return gamepads.ToArray();  //return sticks.ToArray();
        }
        public void readStick(GamePad[] gpArray, int controllerNumber)
        {
            GamePad gamepad = gpArray[controllerNumber];
            gamepad.Update();

            if (gamepad.RTHRight_Press && !rs[controllerNumberMap[controllerNumber]].NoSho && !gamepad.XButton_Down)
            {
                rs[controllerNumberMap[controllerNumber]].cycleEventName(RobotState.CYCLE_DIRECTION.Up);
            }
            if (gamepad.RTHLeft_Press && !rs[controllerNumberMap[controllerNumber]].NoSho && !gamepad.XButton_Down)
            {
                rs[controllerNumberMap[controllerNumber]].cycleEventName(RobotState.CYCLE_DIRECTION.Down);
            }

            if (gamepad.R3_Press && !gamepad.XButton_Down)
            {
                if (rs[controllerNumberMap[controllerNumber]].match_event != RobotState.MATCHEVENT_NAME.Match_Event &&
                    !rs[controllerNumberMap[controllerNumber]].NoSho &&
                    rs[controllerNumberMap[controllerNumber]]._ScouterName != RobotState.SCOUTER_NAME.Select_Name)
                {
                    if (rs[controllerNumberMap[controllerNumber]].match_event == RobotState.MATCHEVENT_NAME.NoShow)
                    {
                        activity_record.match_event = rs[controllerNumberMap[controllerNumber]].match_event.ToString().ToString();
                        rs[controllerNumberMap[controllerNumber]].NoSho = true;
                    }
                    else
                    {
                        activity_record.match_event = rs[controllerNumberMap[controllerNumber]].match_event.ToString().ToString(); //If you crash here you didn't load matches
                    }
                    activity_record.Team = rs[controllerNumberMap[controllerNumber]].TeamName;
                    activity_record.Match = rs[controllerNumberMap[controllerNumber]].Current_Match;
                    activity_record.Time = DateTime.Now;
                    activity_record.Mode = rs[controllerNumberMap[controllerNumber]].Current_Mode.ToString();
                    activity_record.ScouterName = rs[controllerNumberMap[controllerNumber]].getScouterName(RobotState.SCOUTER_NAME.Select_Name).ToString();
                    activity_record.RecordType = "Match_Event";

                    //2024
                    activity_record.Leave = 0;
                    activity_record.AcqLoc = "-";
                    activity_record.AcqCenter = 0;
                    activity_record.AcqDis = 0;
                    activity_record.AcqDrp = 0;
                    activity_record.DelMiss = 0;
                    activity_record.DelOrig = "-";
                    activity_record.DelDest = "-";

                    if (rs[controllerNumberMap[controllerNumber]] == rs[0])
                    {
                        activity_record.DriveSta = "red0";
                    }
                    else if (rs[controllerNumberMap[controllerNumber]] == rs[1])
                    {
                        activity_record.DriveSta = "red1";
                    }
                    else if (rs[controllerNumberMap[controllerNumber]] == rs[2])
                    {
                        activity_record.DriveSta = "red2";
                    }
                    else if (rs[controllerNumberMap[controllerNumber]] == rs[3])
                    {
                        activity_record.DriveSta = "blue0";
                    }
                    else if (rs[controllerNumberMap[controllerNumber]] == rs[4])
                    {
                        activity_record.DriveSta = "blue1";
                    }
                    else if (rs[controllerNumberMap[controllerNumber]] == rs[5])
                    {
                        activity_record.DriveSta = "blue2";
                    }




                    activity_record.RobotSta = "-";
                    activity_record.HPAmp = "-";
                    activity_record.StageStat = "-";
                    activity_record.StageAtt = 9;
                    activity_record.StageLoc = "-";
                    activity_record.Harmony = 9;
                    activity_record.Spotlit = 9;
                    activity_record.ClimbT = 0;
                    activity_record.OZTime = 0;
                    activity_record.AZTime = 0;
                    activity_record.NZTime = 0;
                    activity_record.Mics = 9;
                    activity_record.Defense = 9;
                    activity_record.Avoidance = 9;
                    activity_record.Strategy = "-";


                    //Save Record to the database
                    seasonframework.ActivitySet.Add(activity_record);
                    seasonframework.SaveChanges(); // If you crash here migration isn't working

                    rs[controllerNumberMap[controllerNumber]].match_event = RobotState.MATCHEVENT_NAME.Match_Event;

                    //Reset Match Event
                    rs[controllerNumberMap[controllerNumber]].match_event = 0;
                }
                else if (rs[controllerNumberMap[controllerNumber]].match_event == RobotState.MATCHEVENT_NAME.Match_Event)
                {
                    rs[controllerNumberMap[controllerNumber]].ScouterError = rs[controllerNumberMap[controllerNumber]].ScouterError + 100000;
                }
            }

            // #Auto
            // **************************************************************
            // *** Auto MODE ***
            // **************************************************************
            if (rs[controllerNumberMap[controllerNumber]].Current_Mode == RobotState.ROBOT_MODE.Auto && !rs[controllerNumberMap[controllerNumber]].NoSho)
            {
                //2024 Scouter Names
                if (gamepad.XButton_Down)
                {
                    if (gamepad.RTHRight_Press)
                    {
                        rs[controllerNumberMap[controllerNumber]].changeScouterName(RobotState.CYCLE_DIRECTION.Up);
                        ScouterNameMap[controllerNumber] = rs[controllerNumber]._ScouterName;
                    }
                    if (gamepad.RTHLeft_Press)
                    {
                        rs[controllerNumberMap[controllerNumber]].changeScouterName(RobotState.CYCLE_DIRECTION.Down);
                        ScouterNameMap[controllerNumber] = rs[controllerNumber]._ScouterName;
                    }
                }

                //2024 Setup Controls
                if (gamepad.XButton_Down)
                {
                    if (gamepad.LTHRight_Press)
                    {
                        rs[controllerNumberMap[controllerNumber]].changeRobot_Set(RobotState.CYCLE_DIRECTION.Up);
                    }
                    if (gamepad.LTHLeft_Press)
                    {
                        rs[controllerNumberMap[controllerNumber]].changeRobot_Set(RobotState.CYCLE_DIRECTION.Down);
                    }
                }

                //2024 Leave
                if (gamepad.StartButton_Press && rs[controllerNumberMap[controllerNumber]].Leave == 0)
                {
                    rs[controllerNumberMap[controllerNumber]].Leave = 1;

                }
                else if (gamepad.StartButton_Press && rs[controllerNumberMap[controllerNumber]].Leave == 1)
                {
                    rs[controllerNumberMap[controllerNumber]].Leave = 0;
                }

                //2024 HP in Amp
                if (gamepad.XButton_Down)
                {
                    if (gamepad.L3_Press)
                    {
                        rs[controllerNumberMap[controllerNumber]].changeHP_Amp(RobotState.CYCLE_DIRECTION.Up);
                    }
                }

                //2024 Current Location and Red Right logic
                if (gamepad.XButton_Down && !gamepad.LeftTrigger_Down)
                {
                    rs[controllerNumberMap[controllerNumber]].Current_Loc = RobotState.CURRENT_LOC.Left;
                }
                if (gamepad.BButton_Down && !gamepad.LeftTrigger_Down)
                {
                    rs[controllerNumberMap[controllerNumber]].Current_Loc = RobotState.CURRENT_LOC.Right;

                }
                if (gamepad.AButton_Down && !gamepad.LeftTrigger_Down)
                {
                    rs[controllerNumberMap[controllerNumber]].Current_Loc = RobotState.CURRENT_LOC.Neutral;
                }
                if (gamepad.YButton_Down && !gamepad.LeftTrigger_Down)
                {
                    if (RobotState.Red_Right == true)
                    {
                        if (rs[controllerNumberMap[controllerNumber]].color == "Red")
                        {
                            if (rs[controllerNumberMap[controllerNumber]].Current_Loc == RobotState.CURRENT_LOC.Right)
                            {
                                rs[controllerNumberMap[controllerNumber]].Current_Loc = RobotState.CURRENT_LOC.SubW;
                            }
                            if (rs[controllerNumberMap[controllerNumber]].Current_Loc == RobotState.CURRENT_LOC.Left)
                            {
                                rs[controllerNumberMap[controllerNumber]].Current_Loc = RobotState.CURRENT_LOC.Source;
                            }
                        }
                        else
                        {
                            if (rs[controllerNumberMap[controllerNumber]].Current_Loc == RobotState.CURRENT_LOC.Right)
                            {
                                rs[controllerNumberMap[controllerNumber]].Current_Loc = RobotState.CURRENT_LOC.Source;
                            }
                            if (rs[controllerNumberMap[controllerNumber]].Current_Loc == RobotState.CURRENT_LOC.Left)
                            {
                                rs[controllerNumberMap[controllerNumber]].Current_Loc = RobotState.CURRENT_LOC.SubW;
                            }
                        }
                    }
                    else
                    {
                        if (rs[controllerNumberMap[controllerNumber]].color == "Blue")
                        {
                            if (rs[controllerNumberMap[controllerNumber]].Current_Loc == RobotState.CURRENT_LOC.Right)
                            {
                                rs[controllerNumberMap[controllerNumber]].Current_Loc = RobotState.CURRENT_LOC.SubW;
                            }
                            if (rs[controllerNumberMap[controllerNumber]].Current_Loc == RobotState.CURRENT_LOC.Left)
                            {
                                rs[controllerNumberMap[controllerNumber]].Current_Loc = RobotState.CURRENT_LOC.Source;
                            }
                        }
                        else
                        {
                            if (rs[controllerNumberMap[controllerNumber]].Current_Loc == RobotState.CURRENT_LOC.Right)
                            {
                                rs[controllerNumberMap[controllerNumber]].Current_Loc = RobotState.CURRENT_LOC.Source;
                            }
                            if (rs[controllerNumberMap[controllerNumber]].Current_Loc == RobotState.CURRENT_LOC.Left)
                            {
                                rs[controllerNumberMap[controllerNumber]].Current_Loc = RobotState.CURRENT_LOC.SubW;
                            }
                        }
                    }
                }

                //2024 acquire locations
                if (gamepad.LeftTrigger_Press)
                {
                    rs[controllerNumberMap[controllerNumber]].Acq_Center = 0;
                }
                if (gamepad.LeftTrigger_Down)
                {
                    rs[controllerNumberMap[controllerNumber]].Del_Dest = RobotState.DEL_DEST.Select;
                    rs[controllerNumberMap[controllerNumber]].Acq_Loc = rs[controllerNumberMap[controllerNumber]].Current_Loc.ToString();
                }
                if (!gamepad.RightButton_Down)
                {
                    if (gamepad.DpadUp_Press || gamepad.DpadDown_Press)
                    {
                        rs[controllerNumberMap[controllerNumber]].Acq_Center = 3;
                        rs[controllerNumberMap[controllerNumber]].Acq_Loc = "Select";
                        rs[controllerNumberMap[controllerNumber]].CenteNoteTimeTemp = DateTime.Now;
                    }
                    else if (gamepad.DpadRight_Press && rs[controllerNumberMap[controllerNumber]].Acq_Center < 4)
                    {
                        rs[controllerNumberMap[controllerNumber]].Acq_Center = 4;
                        rs[controllerNumberMap[controllerNumber]].Acq_Loc = "Select";
                        rs[controllerNumberMap[controllerNumber]].CenteNoteTimeTemp = DateTime.Now;
                    }
                    else if (gamepad.DpadRight_Press && rs[controllerNumberMap[controllerNumber]].Acq_Center == 4)
                    {
                        rs[controllerNumberMap[controllerNumber]].Acq_Center = 5;
                        rs[controllerNumberMap[controllerNumber]].Acq_Loc = "Select";
                        rs[controllerNumberMap[controllerNumber]].CenteNoteTimeTemp = DateTime.Now;
                    }
                    else if (gamepad.DpadLeft_Press && rs[controllerNumberMap[controllerNumber]].Acq_Center != 1)
                    {
                        if (gamepad.DpadLeft_Press && rs[controllerNumberMap[controllerNumber]].Acq_Center != 2)
                        {
                            rs[controllerNumberMap[controllerNumber]].Acq_Center = 2;
                            rs[controllerNumberMap[controllerNumber]].Acq_Loc = "Select";
                            rs[controllerNumberMap[controllerNumber]].CenteNoteTimeTemp = DateTime.Now;
                        }
                        else if (gamepad.DpadLeft_Press && rs[controllerNumberMap[controllerNumber]].Acq_Center == 2)
                        {
                            rs[controllerNumberMap[controllerNumber]].Acq_Center = 1;
                            rs[controllerNumberMap[controllerNumber]].Acq_Loc = "Select";
                            rs[controllerNumberMap[controllerNumber]].CenteNoteTimeTemp = DateTime.Now;
                        }
                    }
                }

                // 2024 deliver destination
                if (gamepad.RightButton_Down)
                {
                    rs[controllerNumberMap[controllerNumber]].Acq_Loc = "Select";
                    rs[controllerNumberMap[controllerNumber]].Acq_Center = 0;
                }
                if (gamepad.RightButton_Down && gamepad.DpadUp_Down)
                {
                    rs[controllerNumberMap[controllerNumber]].Del_Dest = RobotState.DEL_DEST.Spkr;
                }
                if (gamepad.RightButton_Down && gamepad.DpadLeft_Down)
                {
                    rs[controllerNumberMap[controllerNumber]].Del_Dest = RobotState.DEL_DEST.Amp;
                }
                if (gamepad.RightButton_Down && gamepad.DpadRight_Down)
                {
                    rs[controllerNumberMap[controllerNumber]].Del_Dest = RobotState.DEL_DEST.AllyW;
                }
                if (gamepad.RightButton_Down && gamepad.DpadDown_Down)
                {
                    rs[controllerNumberMap[controllerNumber]].Del_Dest = RobotState.DEL_DEST.Neut;
                }
                if (gamepad.RightButton_Down && gamepad.L3_Down)
                {
                    rs[controllerNumberMap[controllerNumber]].Del_Dest = RobotState.DEL_DEST.Trap;
                }

                // 2024 Flag
                if (gamepad.LeftButton_Down)
                {
                    rs[controllerNumberMap[controllerNumber]].Flag = 1;
                }
                else
                {
                    rs[controllerNumberMap[controllerNumber]].Flag = 0;
                }
            }

            // #Teleop
            // **************************************************************
            // *** Teleop MODE ***
            // **************************************************************
            if (rs[controllerNumberMap[controllerNumber]].Current_Mode == RobotState.ROBOT_MODE.Teleop && !rs[controllerNumberMap[controllerNumber]].NoSho)
            {
                //2024 current loc 
                if (gamepad.XButton_Down)
                {
                    rs[controllerNumberMap[controllerNumber]].Current_Loc = RobotState.CURRENT_LOC.Left;
                }
                if (gamepad.BButton_Down)
                {
                    rs[controllerNumberMap[controllerNumber]].Current_Loc = RobotState.CURRENT_LOC.Right;

                }
                if (gamepad.AButton_Down)
                {
                    rs[controllerNumberMap[controllerNumber]].Current_Loc = RobotState.CURRENT_LOC.Neutral;
                }
                if (gamepad.YButton_Down)
                {
                    if (RobotState.Red_Right == true)
                    {
                        if (rs[controllerNumberMap[controllerNumber]].color == "Red")
                        {
                            if (rs[controllerNumberMap[controllerNumber]].Current_Loc == RobotState.CURRENT_LOC.Right)
                            {
                                rs[controllerNumberMap[controllerNumber]].Current_Loc = RobotState.CURRENT_LOC.SubW;
                            }
                            if (rs[controllerNumberMap[controllerNumber]].Current_Loc == RobotState.CURRENT_LOC.Left)
                            {
                                rs[controllerNumberMap[controllerNumber]].Current_Loc = RobotState.CURRENT_LOC.Source;
                            }
                        }
                        else
                        {
                            if (rs[controllerNumberMap[controllerNumber]].Current_Loc == RobotState.CURRENT_LOC.Right)
                            {
                                rs[controllerNumberMap[controllerNumber]].Current_Loc = RobotState.CURRENT_LOC.Source;
                            }
                            if (rs[controllerNumberMap[controllerNumber]].Current_Loc == RobotState.CURRENT_LOC.Left)
                            {
                                rs[controllerNumberMap[controllerNumber]].Current_Loc = RobotState.CURRENT_LOC.SubW;
                            }
                        }
                    }
                    else
                    {
                        if (rs[controllerNumberMap[controllerNumber]].color == "Blue")
                        {
                            if (rs[controllerNumberMap[controllerNumber]].Current_Loc == RobotState.CURRENT_LOC.Right)
                            {
                                rs[controllerNumberMap[controllerNumber]].Current_Loc = RobotState.CURRENT_LOC.SubW;
                            }
                            if (rs[controllerNumberMap[controllerNumber]].Current_Loc == RobotState.CURRENT_LOC.Left)
                            {
                                rs[controllerNumberMap[controllerNumber]].Current_Loc = RobotState.CURRENT_LOC.Source;
                            }
                        }
                        else
                        {
                            if (rs[controllerNumberMap[controllerNumber]].Current_Loc == RobotState.CURRENT_LOC.Right)
                            {
                                rs[controllerNumberMap[controllerNumber]].Current_Loc = RobotState.CURRENT_LOC.Source;
                            }
                            if (rs[controllerNumberMap[controllerNumber]].Current_Loc == RobotState.CURRENT_LOC.Left)
                            {
                                rs[controllerNumberMap[controllerNumber]].Current_Loc = RobotState.CURRENT_LOC.SubW;
                            }
                        }
                    }
                }
                //2024 del 
                if (gamepad.RightButton_Down)
                {
                    rs[controllerNumberMap[controllerNumber]].Acq_Loc = "Select";
                }
                if (gamepad.RightButton_Down && gamepad.DpadUp_Down)
                {
                    rs[controllerNumberMap[controllerNumber]].Del_Dest = RobotState.DEL_DEST.Spkr;
                }
                if (gamepad.RightButton_Down && gamepad.DpadLeft_Down)
                {
                    rs[controllerNumberMap[controllerNumber]].Del_Dest = RobotState.DEL_DEST.Amp;
                }
                if (gamepad.RightButton_Down && gamepad.DpadRight_Down)
                {
                    rs[controllerNumberMap[controllerNumber]].Del_Dest = RobotState.DEL_DEST.AllyW;
                }
                if (gamepad.RightButton_Down && gamepad.DpadDown_Down)
                {
                    rs[controllerNumberMap[controllerNumber]].Del_Dest = RobotState.DEL_DEST.Neut;
                }
                if (gamepad.RightButton_Down && gamepad.L3_Down)
                {
                    rs[controllerNumberMap[controllerNumber]].Del_Dest = RobotState.DEL_DEST.Trap;
                }

                //2024 acq loc 
                if (gamepad.LeftTrigger_Down)
                {
                    rs[controllerNumberMap[controllerNumber]].Del_Dest = RobotState.DEL_DEST.Select;
                    rs[controllerNumberMap[controllerNumber]].Acq_Loc = rs[controllerNumberMap[controllerNumber]].Current_Loc.ToString();
                }

                // 2024 flag 
                if (gamepad.LeftButton_Down)
                {
                    rs[controllerNumberMap[controllerNumber]].Flag = 1;
                }
                else
                {
                    rs[controllerNumberMap[controllerNumber]].Flag = 0;
                }

                //2024 comp
                if (rs[controllerNumberMap[controllerNumber]].Current_Loc == RobotState.CURRENT_LOC.Neutral)
                {
                    rs[controllerNumberMap[controllerNumber]].NeutT_StopWatch.Start();
                    rs[controllerNumberMap[controllerNumber]].NeutT = rs[controllerNumberMap[controllerNumber]].NeutT_StopWatch.Elapsed;
                    rs[controllerNumberMap[controllerNumber]].NeutT_StopWatch_running = true;

                    rs[controllerNumberMap[controllerNumber]].OpptT_StopWatch.Stop();
                    rs[controllerNumberMap[controllerNumber]].OpptT_StopWatch_running = false;

                    rs[controllerNumberMap[controllerNumber]].AllyT_StopWatch.Stop();
                    rs[controllerNumberMap[controllerNumber]].AllyT_StopWatch_running = false;
                }
                //2024 zone time 
                if (RobotState.Red_Right == true)
                {
                    if (rs[controllerNumberMap[controllerNumber]].color == "Red")
                    {
                        if (rs[controllerNumberMap[controllerNumber]].Current_Loc == RobotState.CURRENT_LOC.Right || rs[controllerNumberMap[controllerNumber]].Current_Loc == RobotState.CURRENT_LOC.SubW)
                        {
                            rs[controllerNumberMap[controllerNumber]].AllyT_StopWatch.Start();
                            rs[controllerNumberMap[controllerNumber]].AllyT = rs[controllerNumberMap[controllerNumber]].AllyT_StopWatch.Elapsed;
                            rs[controllerNumberMap[controllerNumber]].AllyT_StopWatch_running = true;

                            rs[controllerNumberMap[controllerNumber]].NeutT_StopWatch.Stop();
                            rs[controllerNumberMap[controllerNumber]].NeutT_StopWatch_running = false;

                            rs[controllerNumberMap[controllerNumber]].OpptT_StopWatch.Stop();
                            rs[controllerNumberMap[controllerNumber]].OpptT_StopWatch_running = false;
                        }
                        if (rs[controllerNumberMap[controllerNumber]].Current_Loc == RobotState.CURRENT_LOC.Left || rs[controllerNumberMap[controllerNumber]].Current_Loc == RobotState.CURRENT_LOC.Source)
                        {
                            rs[controllerNumberMap[controllerNumber]].OpptT_StopWatch.Start();
                            rs[controllerNumberMap[controllerNumber]].OpptT = rs[controllerNumberMap[controllerNumber]].OpptT_StopWatch.Elapsed;
                            rs[controllerNumberMap[controllerNumber]].OpptT_StopWatch_running = true;

                            rs[controllerNumberMap[controllerNumber]].AllyT_StopWatch.Stop();
                            rs[controllerNumberMap[controllerNumber]].AllyT_StopWatch_running = false;

                            rs[controllerNumberMap[controllerNumber]].NeutT_StopWatch.Stop();
                            rs[controllerNumberMap[controllerNumber]].NeutT_StopWatch_running = false;
                        }
                    }
                    else
                    {
                        if (rs[controllerNumberMap[controllerNumber]].Current_Loc == RobotState.CURRENT_LOC.Right || rs[controllerNumberMap[controllerNumber]].Current_Loc == RobotState.CURRENT_LOC.Source)
                        {
                            rs[controllerNumberMap[controllerNumber]].OpptT_StopWatch.Start();
                            rs[controllerNumberMap[controllerNumber]].OpptT = rs[controllerNumberMap[controllerNumber]].OpptT_StopWatch.Elapsed;
                            rs[controllerNumberMap[controllerNumber]].OpptT_StopWatch_running = true;

                            rs[controllerNumberMap[controllerNumber]].AllyT_StopWatch.Stop();
                            rs[controllerNumberMap[controllerNumber]].AllyT_StopWatch_running = false;

                            rs[controllerNumberMap[controllerNumber]].NeutT_StopWatch.Stop();
                            rs[controllerNumberMap[controllerNumber]].NeutT_StopWatch_running = false;
                        }
                        if (rs[controllerNumberMap[controllerNumber]].Current_Loc == RobotState.CURRENT_LOC.Left || rs[controllerNumberMap[controllerNumber]].Current_Loc == RobotState.CURRENT_LOC.SubW)
                        {
                            rs[controllerNumberMap[controllerNumber]].AllyT_StopWatch.Start();
                            rs[controllerNumberMap[controllerNumber]].AllyT = rs[controllerNumberMap[controllerNumber]].AllyT_StopWatch.Elapsed;
                            rs[controllerNumberMap[controllerNumber]].AllyT_StopWatch_running = true;

                            rs[controllerNumberMap[controllerNumber]].NeutT_StopWatch.Stop();
                            rs[controllerNumberMap[controllerNumber]].NeutT_StopWatch_running = false;

                            rs[controllerNumberMap[controllerNumber]].OpptT_StopWatch.Stop();
                            rs[controllerNumberMap[controllerNumber]].OpptT_StopWatch_running = false;
                        }
                    }

                }
                else
                {
                    if (rs[controllerNumberMap[controllerNumber]].color == "Blue")
                    {
                        if (rs[controllerNumberMap[controllerNumber]].Current_Loc == RobotState.CURRENT_LOC.Right || rs[controllerNumberMap[controllerNumber]].Current_Loc == RobotState.CURRENT_LOC.SubW)
                        {
                            rs[controllerNumberMap[controllerNumber]].AllyT_StopWatch.Start();
                            rs[controllerNumberMap[controllerNumber]].AllyT = rs[controllerNumberMap[controllerNumber]].AllyT_StopWatch.Elapsed;
                            rs[controllerNumberMap[controllerNumber]].AllyT_StopWatch_running = true;

                            rs[controllerNumberMap[controllerNumber]].NeutT_StopWatch.Stop();
                            rs[controllerNumberMap[controllerNumber]].NeutT_StopWatch_running = false;

                            rs[controllerNumberMap[controllerNumber]].OpptT_StopWatch.Stop();
                            rs[controllerNumberMap[controllerNumber]].OpptT_StopWatch_running = false;
                        }
                        if (rs[controllerNumberMap[controllerNumber]].Current_Loc == RobotState.CURRENT_LOC.Left || rs[controllerNumberMap[controllerNumber]].Current_Loc == RobotState.CURRENT_LOC.Source)
                        {
                            rs[controllerNumberMap[controllerNumber]].OpptT_StopWatch.Start();
                            rs[controllerNumberMap[controllerNumber]].OpptT = rs[controllerNumberMap[controllerNumber]].OpptT_StopWatch.Elapsed;
                            rs[controllerNumberMap[controllerNumber]].OpptT_StopWatch_running = true;

                            rs[controllerNumberMap[controllerNumber]].AllyT_StopWatch.Stop();
                            rs[controllerNumberMap[controllerNumber]].AllyT_StopWatch_running = false;

                            rs[controllerNumberMap[controllerNumber]].NeutT_StopWatch.Stop();
                            rs[controllerNumberMap[controllerNumber]].NeutT_StopWatch_running = false;
                        }
                    }
                    else
                    {
                        if (rs[controllerNumberMap[controllerNumber]].Current_Loc == RobotState.CURRENT_LOC.Right || rs[controllerNumberMap[controllerNumber]].Current_Loc == RobotState.CURRENT_LOC.Source)
                        {
                            rs[controllerNumberMap[controllerNumber]].OpptT_StopWatch.Start();
                            rs[controllerNumberMap[controllerNumber]].OpptT = rs[controllerNumberMap[controllerNumber]].OpptT_StopWatch.Elapsed;
                            rs[controllerNumberMap[controllerNumber]].OpptT_StopWatch_running = true;

                            rs[controllerNumberMap[controllerNumber]].AllyT_StopWatch.Stop();
                            rs[controllerNumberMap[controllerNumber]].AllyT_StopWatch_running = false;

                            rs[controllerNumberMap[controllerNumber]].NeutT_StopWatch.Stop();
                            rs[controllerNumberMap[controllerNumber]].NeutT_StopWatch_running = false;
                        }
                        if (rs[controllerNumberMap[controllerNumber]].Current_Loc == RobotState.CURRENT_LOC.Left || rs[controllerNumberMap[controllerNumber]].Current_Loc == RobotState.CURRENT_LOC.SubW)
                        {
                            rs[controllerNumberMap[controllerNumber]].AllyT_StopWatch.Start();
                            rs[controllerNumberMap[controllerNumber]].AllyT = rs[controllerNumberMap[controllerNumber]].AllyT_StopWatch.Elapsed;
                            rs[controllerNumberMap[controllerNumber]].AllyT_StopWatch_running = true;

                            rs[controllerNumberMap[controllerNumber]].NeutT_StopWatch.Stop();
                            rs[controllerNumberMap[controllerNumber]].NeutT_StopWatch_running = false;

                            rs[controllerNumberMap[controllerNumber]].OpptT_StopWatch.Stop();
                            rs[controllerNumberMap[controllerNumber]].OpptT_StopWatch_running = false;
                        }
                    }
                }
                if (gamepad.StartButton_Press)
                {
                    rs[controllerNumberMap[controllerNumber]].ClimbT_StopWatch.Stop();
                    rs[controllerNumberMap[controllerNumber]].ClimbT_StopWatch_running = false;
                    if (gamepad.LeftTrigger_Down && gamepad.StartButton_Press)
                    {
                        rs[controllerNumberMap[controllerNumber]].ClimbT_StopWatch.Reset();
                        rs[controllerNumberMap[controllerNumber]].ClimbT_StopWatch_running = true;
                    }
                }
            }

            // #Showtime 
            // **************************************************************
            // *** SHOWTIME MODE ***
            // **************************************************************
            //2024 climb time
            if (rs[controllerNumberMap[controllerNumber]].Current_Mode == RobotState.ROBOT_MODE.Showtime && !rs[controllerNumberMap[controllerNumber]].NoSho)
            {
                if (gamepad.StartButton_Press)
                {
                    if (rs[controllerNumberMap[controllerNumber]].ClimbT_StopWatch_running)
                    {
                        rs[controllerNumberMap[controllerNumber]].ClimbT_StopWatch.Stop();
                        rs[controllerNumberMap[controllerNumber]].ClimbT_StopWatch_running = false;
                    }
                    else if (!rs[controllerNumberMap[controllerNumber]].ClimbT_StopWatch_running)
                    {
                        rs[controllerNumberMap[controllerNumber]].ClimbT_StopWatch.Start();
                        rs[controllerNumberMap[controllerNumber]].ClimbT_StopWatch_running = true;
                    }
                }
                if (gamepad.LeftTrigger_Down && gamepad.StartButton_Down)
                {
                    rs[controllerNumberMap[controllerNumber]].ClimbT_StopWatch.Reset();
                    rs[controllerNumberMap[controllerNumber]].ClimbT_StopWatch_running = false;
                }

                // 2024 del
                if (gamepad.L3_Press && gamepad.RightButton_Down)
                {
                    rs[controllerNumberMap[controllerNumber]].Del_Dest = RobotState.DEL_DEST.Trap;
                }

                //2024 flag 
                if (gamepad.LeftButton_Down)
                {
                    rs[controllerNumberMap[controllerNumber]].Flag = 1;
                }
                else
                {
                    rs[controllerNumberMap[controllerNumber]].Flag = 0;
                }

                //2024 stat
                if (gamepad.XButton_Down)
                {
                    if (gamepad.LTHRight_Press)
                    {
                        rs[controllerNumberMap[controllerNumber]].changeStage_Stat(RobotState.CYCLE_DIRECTION.Up);
                    }
                    else if (gamepad.LTHLeft_Press)
                    {
                        rs[controllerNumberMap[controllerNumber]].changeStage_Stat(RobotState.CYCLE_DIRECTION.Down);
                    }
                }

                //2024 stage Att
                if (gamepad.YButton_Down && rs[controllerNumberMap[controllerNumber]].Stage_Stat == RobotState.STAGE_STAT.Onstage)
                {
                    if (gamepad.LTHRight_Press)
                    {
                        rs[controllerNumberMap[controllerNumber]].Stage_Att = RobotState.STAGE_ATT.Select;
                        rs[controllerNumberMap[controllerNumber]].changeStage_Loc(RobotState.CYCLE_DIRECTION.Up);
                    }
                    else if (gamepad.LTHLeft_Press)
                    {
                        rs[controllerNumberMap[controllerNumber]].Stage_Att = RobotState.STAGE_ATT.Select;
                        rs[controllerNumberMap[controllerNumber]].changeStage_Loc(RobotState.CYCLE_DIRECTION.Down);
                    }
                }

                //2024 stage loc
                if (gamepad.YButton_Down && (rs[controllerNumberMap[controllerNumber]].Stage_Stat == RobotState.STAGE_STAT.Elsewhere || rs[controllerNumberMap[controllerNumber]].Stage_Stat == RobotState.STAGE_STAT.Park))
                {
                    if (gamepad.LTHRight_Press)
                    {
                        rs[controllerNumberMap[controllerNumber]].changeStage_Att(RobotState.CYCLE_DIRECTION.Up);
                        rs[controllerNumberMap[controllerNumber]].Stage_Loc = RobotState.STAGE_LOC.Select;
                    }
                    else if (gamepad.LTHLeft_Press)
                    {
                        rs[controllerNumberMap[controllerNumber]].changeStage_Att(RobotState.CYCLE_DIRECTION.Down);
                        rs[controllerNumberMap[controllerNumber]].Stage_Loc = RobotState.STAGE_LOC.Select;

                    }
                }

                // 2024 strat
                if (gamepad.BButton_Down)
                {
                    if (gamepad.LTHRight_Press)
                    {
                        rs[controllerNumberMap[controllerNumber]].changeApp_Strat(RobotState.CYCLE_DIRECTION.Up);
                    }
                    else if (gamepad.LTHLeft_Press)
                    {
                        rs[controllerNumberMap[controllerNumber]].changeApp_Strat(RobotState.CYCLE_DIRECTION.Down);
                    }
                }

                //2024 harm 
                if (gamepad.AButton_Down)
                {
                    if (gamepad.LTHLeft_Press)
                    {
                        rs[controllerNumberMap[controllerNumber]].Harm++;
                        if (rs[controllerNumberMap[controllerNumber]].Harm == 11)
                        {
                            rs[controllerNumberMap[controllerNumber]].Harm = 0;

                        }
                        if (rs[controllerNumberMap[controllerNumber]].Harm == 3)
                        {
                            rs[controllerNumberMap[controllerNumber]].Harm = 0;
                        }
                    }
                    if (gamepad.LTHRight_Press)
                    {
                        rs[controllerNumberMap[controllerNumber]].Harm--;
                        if (rs[controllerNumberMap[controllerNumber]].Harm == 8)
                        {
                            rs[controllerNumberMap[controllerNumber]].Harm = 0;
                        }
                        if (rs[controllerNumberMap[controllerNumber]].Harm == -1)
                        {
                            rs[controllerNumberMap[controllerNumber]].Harm = 2;
                        }
                    }
                }

                //2024 Mic
                if (gamepad.DpadUp_Press)
                {
                    rs[controllerNumberMap[controllerNumber]].Mic++;
                    if (rs[controllerNumberMap[controllerNumber]].Mic == 11)
                    {
                        rs[controllerNumberMap[controllerNumber]].Mic = 0;
                    }
                    if (rs[controllerNumberMap[controllerNumber]].Mic == 4)
                    {
                        rs[controllerNumberMap[controllerNumber]].Mic = 0;
                    }
                }

                //2024 Spotlit 
                if (gamepad.DpadDown_Press)
                {
                    rs[controllerNumberMap[controllerNumber]].changeLit(RobotState.CYCLE_DIRECTION.Up);
                }

                // 2024 Def / avo
                if (gamepad.DpadRight_Press)
                {
                    rs[controllerNumberMap[controllerNumber]].Def_Rat++;
                    if (rs[controllerNumberMap[controllerNumber]].Def_Rat == 11)
                    {
                        rs[controllerNumberMap[controllerNumber]].Def_Rat = 0;
                    }
                    if (rs[controllerNumberMap[controllerNumber]].Def_Rat == 4)
                    {
                        rs[controllerNumberMap[controllerNumber]].Def_Rat = 0;
                    }
                }

                if (gamepad.DpadLeft_Press)
                {
                    rs[controllerNumberMap[controllerNumber]].Avo_Rat++;
                    if (rs[controllerNumberMap[controllerNumber]].Avo_Rat == 11)
                    {
                        rs[controllerNumberMap[controllerNumber]].Avo_Rat = 0;
                    }
                    if (rs[controllerNumberMap[controllerNumber]].Avo_Rat == 4)
                    {
                        rs[controllerNumberMap[controllerNumber]].Avo_Rat = 0;
                    }
                }
            }

            // Values if robot is NoSho

            if (rs[controllerNumberMap[controllerNumber]].NoSho == true)
            {
                if (gamepad.XButton_Down)
                {
                    if (gamepad.L3_Press)
                    {
                        rs[controllerNumberMap[controllerNumber]].changeHP_Amp(RobotState.CYCLE_DIRECTION.Up);
                    }
                }

                if (gamepad.DpadUp_Press)
                {
                    rs[controllerNumberMap[controllerNumber]].Mic++;
                    if (rs[controllerNumberMap[controllerNumber]].Mic == 11)
                    {
                        rs[controllerNumberMap[controllerNumber]].Mic = 0;
                    }
                    if (rs[controllerNumberMap[controllerNumber]].Mic == 4)
                    {
                        rs[controllerNumberMap[controllerNumber]].Mic = 0;
                    }
                }

            }

            // #Transact
            // **************************************************************
            // ***  TRANSACT TO DATABASE  ***
            // **************************************************************
            if (rs[controllerNumberMap[controllerNumber]]._ScouterName != RobotState.SCOUTER_NAME.Select_Name &&
                (rs[controllerNumberMap[controllerNumber]].Acq_Loc != "Select" ||
                rs[controllerNumberMap[controllerNumber]].Del_Dest != RobotState.DEL_DEST.Select ||
                rs[controllerNumberMap[controllerNumber]].Acq_Center != 0))
            {
                rs[controllerNumberMap[controllerNumber]].TransactionCheck = true;
            }
            else
            {
                rs[controllerNumberMap[controllerNumber]].TransactionCheck = false;
            }

            //2023 EndAuto End of Autonomous transaction
            if (rs[controllerNumberMap[controllerNumber]].AUTO && gamepad.BackButton_Press && !rs[controllerNumberMap[controllerNumber]].NoSho &&
                rs[controllerNumberMap[controllerNumber]]._ScouterName != RobotState.SCOUTER_NAME.Select_Name)
            {
                if (rs[controllerNumberMap[controllerNumber]].Current_Loc == RobotState.CURRENT_LOC.Source)
                {
                    rs[controllerNumberMap[controllerNumber]].OpptT_StopWatch.Start();
                    rs[controllerNumberMap[controllerNumber]].OpptT_StopWatch_running = true;
                }
                else if (rs[controllerNumberMap[controllerNumber]].Current_Loc == RobotState.CURRENT_LOC.SubW)
                {
                    rs[controllerNumberMap[controllerNumber]].AllyT_StopWatch.Start();
                    rs[controllerNumberMap[controllerNumber]].AllyT_StopWatch_running = true;
                }

                //Record start match time
                activity_record.RecordType = "StartMatch";
                rs[controllerNumberMap[controllerNumber]].Auto_Time = DateTime.Now;
                activity_record.Time = rs[controllerNumberMap[controllerNumber]].Auto_Time.AddSeconds(-18);

                activity_record.Team = rs[controllerNumberMap[controllerNumber]].TeamName;
                activity_record.Match = rs[controllerNumberMap[controllerNumber]].Current_Match;
                activity_record.Mode = rs[controllerNumberMap[controllerNumber]].Current_Mode.ToString();
                activity_record.ScouterName = rs[controllerNumberMap[controllerNumber]].getScouterName(RobotState.SCOUTER_NAME.Select_Name).ToString();

                activity_record.match_event = "-";
                activity_record.Leave = 0;
                activity_record.AcqLoc = "-";
                activity_record.AcqCenter = 0;
                activity_record.AcqDis = 0;
                activity_record.AcqDrp = 0;
                activity_record.DelMiss = 0;
                activity_record.DelOrig = "-";
                activity_record.DelDest = "-";

                if (rs[controllerNumberMap[controllerNumber]] == rs[0])
                {
                    activity_record.DriveSta = "red0";
                }
                else if (rs[controllerNumberMap[controllerNumber]] == rs[1])
                {
                    activity_record.DriveSta = "red1";
                }
                else if (rs[controllerNumberMap[controllerNumber]] == rs[2])
                {
                    activity_record.DriveSta = "red2";
                }
                else if (rs[controllerNumberMap[controllerNumber]] == rs[3])
                {
                    activity_record.DriveSta = "blue0";
                }
                else if (rs[controllerNumberMap[controllerNumber]] == rs[4])
                {
                    activity_record.DriveSta = "blue1";
                }
                else if (rs[controllerNumberMap[controllerNumber]] == rs[5])
                {
                    activity_record.DriveSta = "blue2";
                }
                activity_record.RobotSta = "-";
                activity_record.HPAmp = "-";
                activity_record.StageStat = "-";
                activity_record.StageAtt = 9;
                activity_record.StageLoc = "-";
                activity_record.Harmony = 9;
                activity_record.Spotlit = 9;
                activity_record.ClimbT = 0;
                activity_record.OZTime = 0;
                activity_record.AZTime = 0;
                activity_record.NZTime = 0;
                activity_record.Mics = 9;
                activity_record.Defense = 9;
                activity_record.Avoidance = 9;
                activity_record.Strategy = "-";
                activity_record.ScouterError = rs[controllerNumberMap[controllerNumber]].ScouterError;

                //Save Record to the database
                seasonframework.ActivitySet.Add(activity_record);
                seasonframework.SaveChanges();

                // End Auto line
                activity_record.Team = rs[controllerNumberMap[controllerNumber]].TeamName;
                activity_record.Match = rs[controllerNumberMap[controllerNumber]].Current_Match;
                activity_record.Time = rs[controllerNumberMap[controllerNumber]].Auto_Time;
                activity_record.Mode = rs[controllerNumberMap[controllerNumber]].Current_Mode.ToString();
                activity_record.ScouterName = rs[controllerNumberMap[controllerNumber]].getScouterName(RobotState.SCOUTER_NAME.Select_Name).ToString();
                activity_record.RecordType = "EndAuto";
                activity_record.match_event = "-";
                activity_record.Leave = rs[controllerNumberMap[controllerNumber]].Leave;
                activity_record.AcqLoc = "-";
                activity_record.AcqCenter = 0;
                activity_record.AcqDis = 0;
                activity_record.AcqDrp = 0;
                activity_record.DelMiss = 0;
                activity_record.DelOrig = "-";
                activity_record.DelDest = "-";

                if (rs[controllerNumberMap[controllerNumber]] == rs[0])
                {
                    activity_record.DriveSta = "red0";
                }
                else if (rs[controllerNumberMap[controllerNumber]] == rs[1])
                {
                    activity_record.DriveSta = "red1";
                }
                else if (rs[controllerNumberMap[controllerNumber]] == rs[2])
                {
                    activity_record.DriveSta = "red2";
                }
                else if (rs[controllerNumberMap[controllerNumber]] == rs[3])
                {
                    activity_record.DriveSta = "blue0";
                }
                else if (rs[controllerNumberMap[controllerNumber]] == rs[4])
                {
                    activity_record.DriveSta = "blue1";
                }
                else if (rs[controllerNumberMap[controllerNumber]] == rs[5])
                {
                    activity_record.DriveSta = "blue2";
                }

                if (rs[controllerNumberMap[controllerNumber]].Robot_Set == RobotState.ROBOT_SET.Select)
                {
                    activity_record.RobotSta = "Z";
                    rs[controllerNumberMap[controllerNumber]].ScouterError++;
                }
                else
                {
                    activity_record.RobotSta = rs[controllerNumberMap[controllerNumber]].Robot_Set.ToString();
                }

                if (rs[controllerNumberMap[controllerNumber]].HP_Amp == RobotState.HP_AMP.Select)
                {
                    activity_record.HPAmp = "Z";
                    rs[controllerNumberMap[controllerNumber]].ScouterError++;
                }
                else
                {
                    activity_record.HPAmp = rs[controllerNumberMap[controllerNumber]].HP_Amp.ToString();
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
                activity_record.Mics = 9;
                activity_record.Defense = 9;
                activity_record.Avoidance = 9;
                activity_record.Strategy = "-";
                activity_record.ScouterError = rs[controllerNumberMap[controllerNumber]].ScouterError;
                rs[controllerNumberMap[controllerNumber]].AUTO = false;
                rs[controllerNumberMap[controllerNumber]].Acq_Center_Temp = 0;
                rs[controllerNumberMap[controllerNumber]].Acq_Center = 0;


                //Save Record to the database
                seasonframework.ActivitySet.Add(activity_record);
                seasonframework.SaveChanges();
            }
            else if (gamepad.RightTrigger_Press && !rs[controllerNumberMap[controllerNumber]].NoSho && rs[controllerNumberMap[controllerNumber]].TransactionCheck == true)
            {
                if (rs[controllerNumberMap[controllerNumber]].Acq_Loc != RobotState.CURRENT_LOC.Select.ToString() || rs[controllerNumberMap[controllerNumber]].Acq_Center != 0)
                {
                    if (RobotState.Red_Right == true)
                    {
                        if (rs[controllerNumberMap[controllerNumber]].color == "Red")
                        {
                            if (rs[controllerNumberMap[controllerNumber]].Current_Loc == RobotState.CURRENT_LOC.Right)
                            {
                                rs[controllerNumberMap[controllerNumber]].Acq_Loc_Temp = "AllyWing";
                            }
                            if (rs[controllerNumberMap[controllerNumber]].Current_Loc == RobotState.CURRENT_LOC.Left)
                            {
                                rs[controllerNumberMap[controllerNumber]].Acq_Loc_Temp = "OppWing";
                            }
                        }
                        else
                        {
                            if (rs[controllerNumberMap[controllerNumber]].Current_Loc == RobotState.CURRENT_LOC.Right)
                            {
                                rs[controllerNumberMap[controllerNumber]].Acq_Loc_Temp = "OppWing";
                            }
                            if (rs[controllerNumberMap[controllerNumber]].Current_Loc == RobotState.CURRENT_LOC.Left)
                            {
                                rs[controllerNumberMap[controllerNumber]].Acq_Loc_Temp = "AllyWing";
                            }
                        }
                    }
                    else
                    {
                        if (rs[controllerNumberMap[controllerNumber]].color == "Red")
                        {
                            if (rs[controllerNumberMap[controllerNumber]].Current_Loc == RobotState.CURRENT_LOC.Right)
                            {
                                rs[controllerNumberMap[controllerNumber]].Acq_Loc_Temp = "OppWing";
                            }
                            if (rs[controllerNumberMap[controllerNumber]].Current_Loc == RobotState.CURRENT_LOC.Left)
                            {
                                rs[controllerNumberMap[controllerNumber]].Acq_Loc_Temp = "AllyWing";
                            }
                        }
                        else
                        {
                            if (rs[controllerNumberMap[controllerNumber]].Current_Loc == RobotState.CURRENT_LOC.Right)
                            {
                                rs[controllerNumberMap[controllerNumber]].Acq_Loc_Temp = "AllyWing";
                            }
                            if (rs[controllerNumberMap[controllerNumber]].Current_Loc == RobotState.CURRENT_LOC.Left)
                            {
                                rs[controllerNumberMap[controllerNumber]].Acq_Loc_Temp = "OppWing";
                            }
                        }
                    }
                    if (rs[controllerNumberMap[controllerNumber]].Current_Loc == RobotState.CURRENT_LOC.Source)
                    {
                        rs[controllerNumberMap[controllerNumber]].Acq_Loc_Temp = "Source";
                    }
                    if (rs[controllerNumberMap[controllerNumber]].Current_Loc == RobotState.CURRENT_LOC.Neutral)
                    {
                        rs[controllerNumberMap[controllerNumber]].Acq_Loc_Temp = "Neutral";
                    }
                    if (rs[controllerNumberMap[controllerNumber]].Current_Loc == RobotState.CURRENT_LOC.SubW)
                    {
                        rs[controllerNumberMap[controllerNumber]].Acq_Loc_Temp = "AllyWing";
                    }

                    rs[controllerNumberMap[controllerNumber]].Acq_Center_Temp = rs[controllerNumberMap[controllerNumber]].Acq_Center;

                    if (rs[controllerNumberMap[controllerNumber]].Flag == 1)
                    {
                        activity_record.Leave = 0;

                        if (rs[controllerNumberMap[controllerNumber]].Acq_Center_Temp != 0 && rs[controllerNumberMap[controllerNumber]].Acq_Loc_Temp != "Neutral")
                        {
                            rs[controllerNumberMap[controllerNumber]].Acq_Loc_Temp = "Neutral";
                            rs[controllerNumberMap[controllerNumber]].ScouterError = rs[controllerNumberMap[controllerNumber]].ScouterError + 1000;
                        }
                        activity_record.AcqLoc = rs[controllerNumberMap[controllerNumber]].Acq_Loc_Temp.ToString();
                        activity_record.AcqCenter = rs[controllerNumberMap[controllerNumber]].Acq_Center_Temp;
                        if (rs[controllerNumberMap[controllerNumber]].Acq_Center_Temp != 0)
                        {
                            activity_record.Time = rs[controllerNumberMap[controllerNumber]].CenteNoteTimeTemp;
                        }
                        else
                        {
                            activity_record.Time = DateTime.Now;
                        }

                        if (rs[controllerNumberMap[controllerNumber]].Acq_Center != 0)
                        {
                            activity_record.AcqDis = -1;
                            activity_record.AcqDrp = 0;
                        }
                        else
                        {
                            activity_record.AcqDis = 0;
                            activity_record.AcqDrp = 1;
                        }

                        activity_record.DelMiss = 0;
                        activity_record.DelOrig = "-";
                        activity_record.DelDest = "-";
                        if (rs[controllerNumberMap[controllerNumber]] == rs[0])
                        {
                            activity_record.DriveSta = "red0";
                        }
                        else if (rs[controllerNumberMap[controllerNumber]] == rs[1])
                        {
                            activity_record.DriveSta = "red1";
                        }
                        else if (rs[controllerNumberMap[controllerNumber]] == rs[2])
                        {
                            activity_record.DriveSta = "red2";
                        }
                        else if (rs[controllerNumberMap[controllerNumber]] == rs[3])
                        {
                            activity_record.DriveSta = "blue0";
                        }
                        else if (rs[controllerNumberMap[controllerNumber]] == rs[4])
                        {
                            activity_record.DriveSta = "blue1";
                        }
                        else if (rs[controllerNumberMap[controllerNumber]] == rs[5])
                        {
                            activity_record.DriveSta = "blue2";
                        }
                        activity_record.RobotSta = "-";
                        activity_record.HPAmp = "-";
                        activity_record.StageStat = "-";
                        activity_record.StageAtt = 9;
                        activity_record.StageLoc = "-";
                        activity_record.Harmony = 9;
                        activity_record.Spotlit = 9;
                        activity_record.ClimbT = 0;
                        activity_record.OZTime = 0;
                        activity_record.AZTime = 0;
                        activity_record.NZTime = 0;
                        activity_record.Mics = 9;
                        activity_record.Defense = 9;
                        activity_record.Avoidance = 9;
                        activity_record.Strategy = "-";
                        activity_record.Team = rs[controllerNumberMap[controllerNumber]].TeamName;
                        activity_record.Match = rs[controllerNumberMap[controllerNumber]].Current_Match;
                        activity_record.Mode = "Auto";
                        activity_record.ScouterName = rs[controllerNumberMap[controllerNumber]].getScouterName(RobotState.SCOUTER_NAME.Select_Name).ToString();
                        activity_record.RecordType = "Activities";
                        activity_record.match_event = "-";
                        activity_record.ScouterError = rs[controllerNumberMap[controllerNumber]].ScouterError;

                        //Save Record to the database
                        seasonframework.ActivitySet.Add(activity_record);
                        seasonframework.SaveChanges();

                        //Reset Temp Variables
                        rs[controllerNumberMap[controllerNumber]].Acq_Loc_Temp = "Select";
                        rs[controllerNumberMap[controllerNumber]].Acq_Center_Temp = 0;
                    }
                    else if (rs[controllerNumberMap[controllerNumber]].Flag == 0 && rs[controllerNumberMap[controllerNumber]].Acq_Center_Temp != 0)
                    {
                        activity_record.Leave = 0;
                        if (rs[controllerNumberMap[controllerNumber]].Acq_Loc_Temp != "Neutral")
                        {
                            rs[controllerNumberMap[controllerNumber]].Acq_Loc_Temp = "Neutral";
                            rs[controllerNumberMap[controllerNumber]].ScouterError = rs[controllerNumberMap[controllerNumber]].ScouterError + 1000;
                        }

                        activity_record.AcqLoc = rs[controllerNumberMap[controllerNumber]].Acq_Loc_Temp.ToString();
                        activity_record.AcqCenter = rs[controllerNumberMap[controllerNumber]].Acq_Center_Temp;
                        activity_record.Time = rs[controllerNumberMap[controllerNumber]].CenteNoteTimeTemp;

                        activity_record.AcqDrp = 0;
                        activity_record.AcqDis = 1;
                        activity_record.DelMiss = 0;
                        activity_record.DelOrig = "-";
                        activity_record.DelDest = "-";
                        if (rs[controllerNumberMap[controllerNumber]] == rs[0])
                        {
                            activity_record.DriveSta = "red0";
                        }
                        else if (rs[controllerNumberMap[controllerNumber]] == rs[1])
                        {
                            activity_record.DriveSta = "red1";
                        }
                        else if (rs[controllerNumberMap[controllerNumber]] == rs[2])
                        {
                            activity_record.DriveSta = "red2";
                        }
                        else if (rs[controllerNumberMap[controllerNumber]] == rs[3])
                        {
                            activity_record.DriveSta = "blue0";
                        }
                        else if (rs[controllerNumberMap[controllerNumber]] == rs[4])
                        {
                            activity_record.DriveSta = "blue1";
                        }
                        else if (rs[controllerNumberMap[controllerNumber]] == rs[5])
                        {
                            activity_record.DriveSta = "blue2";
                        }
                        activity_record.RobotSta = "-";
                        activity_record.HPAmp = "-";
                        activity_record.StageStat = "-";
                        activity_record.StageAtt = 9;
                        activity_record.StageLoc = "-";
                        activity_record.Harmony = 9;
                        activity_record.Spotlit = 9;
                        activity_record.ClimbT = 0;
                        activity_record.OZTime = 0;
                        activity_record.AZTime = 0;
                        activity_record.NZTime = 0;
                        activity_record.Mics = 9;
                        activity_record.Defense = 9;
                        activity_record.Avoidance = 9;
                        activity_record.Strategy = "-";
                        activity_record.Team = rs[controllerNumberMap[controllerNumber]].TeamName;
                        activity_record.Match = rs[controllerNumberMap[controllerNumber]].Current_Match;
                        activity_record.Mode = "Auto";
                        activity_record.ScouterName = rs[controllerNumberMap[controllerNumber]].getScouterName(RobotState.SCOUTER_NAME.Select_Name).ToString();
                        activity_record.RecordType = "Activities";
                        activity_record.match_event = "-";
                        activity_record.ScouterError = rs[controllerNumberMap[controllerNumber]].ScouterError;

                        //Save Record to the database
                        seasonframework.ActivitySet.Add(activity_record);
                        seasonframework.SaveChanges();
                    }
                }
                else if (rs[controllerNumberMap[controllerNumber]].Del_Dest != RobotState.DEL_DEST.Select)
                {
                    activity_record.Leave = 0;

                    activity_record.AcqCenter = rs[controllerNumberMap[controllerNumber]].Acq_Center_Temp;
                    if (rs[controllerNumberMap[controllerNumber]].Acq_Center_Temp != 0)
                    {
                        activity_record.Time = rs[controllerNumberMap[controllerNumber]].CenteNoteTimeTemp;
                    }
                    else
                    {
                        activity_record.Time = DateTime.Now;
                    }
                    activity_record.AcqDis = 0;
                    activity_record.AcqDrp = 0;
                    activity_record.DelMiss = rs[controllerNumberMap[controllerNumber]].Flag;

                    // red right logic 
                    if (RobotState.Red_Right == true)
                    {
                        if (rs[controllerNumberMap[controllerNumber]].color == "Red")
                        {
                            if (rs[controllerNumberMap[controllerNumber]].Current_Loc == RobotState.CURRENT_LOC.Right)
                            {
                                activity_record.DelOrig = "AllyW";
                            }
                            if (rs[controllerNumberMap[controllerNumber]].Current_Loc == RobotState.CURRENT_LOC.Left)
                            {
                                activity_record.DelOrig = "OppW";
                            }
                        }
                        else
                        {
                            if (rs[controllerNumberMap[controllerNumber]].Current_Loc == RobotState.CURRENT_LOC.Right)
                            {
                                activity_record.DelOrig = "OppW";
                            }
                            if (rs[controllerNumberMap[controllerNumber]].Current_Loc == RobotState.CURRENT_LOC.Left)
                            {
                                activity_record.DelOrig = "AllyW";
                            }
                        }
                    }
                    else
                    {
                        if (rs[controllerNumberMap[controllerNumber]].color == "Red")
                        {
                            if (rs[controllerNumberMap[controllerNumber]].Current_Loc == RobotState.CURRENT_LOC.Right)
                            {
                                activity_record.DelOrig = "OppW";
                            }
                            if (rs[controllerNumberMap[controllerNumber]].Current_Loc == RobotState.CURRENT_LOC.Left)
                            {
                                activity_record.DelOrig = "AllyW";
                            }
                        }
                        else
                        {
                            if (rs[controllerNumberMap[controllerNumber]].Current_Loc == RobotState.CURRENT_LOC.Right)
                            {
                                activity_record.DelOrig = "AllyW";
                            }
                            if (rs[controllerNumberMap[controllerNumber]].Current_Loc == RobotState.CURRENT_LOC.Left)
                            {
                                activity_record.DelOrig = "OppW";
                            }
                        }
                    }
                    if (rs[controllerNumberMap[controllerNumber]].Current_Loc == RobotState.CURRENT_LOC.Neutral)
                    {
                        activity_record.DelOrig = "Neut";
                    }
                    if (rs[controllerNumberMap[controllerNumber]].Current_Loc == RobotState.CURRENT_LOC.SubW)
                    {
                        activity_record.DelOrig = "SubW";
                    }
                    if (rs[controllerNumberMap[controllerNumber]].Current_Loc == RobotState.CURRENT_LOC.Source)
                    {
                        activity_record.DelOrig = "OppW";
                    }

                    if (rs[controllerNumberMap[controllerNumber]].Current_Mode == RobotState.ROBOT_MODE.Showtime)
                    {
                        if (rs[controllerNumberMap[controllerNumber]].Del_Dest == RobotState.DEL_DEST.Trap)
                        {
                            activity_record.DelOrig = "ShowTime";
                        }
                    }

                    if (rs[controllerNumberMap[controllerNumber]].Acq_Loc_Temp == "Select")
                    {
                        activity_record.AcqLoc = "Z";
                        rs[controllerNumberMap[controllerNumber]].ScouterError = rs[controllerNumberMap[controllerNumber]].ScouterError + 10000000;
                    }
                    else
                    {
                        activity_record.AcqLoc = rs[controllerNumberMap[controllerNumber]].Acq_Loc_Temp.ToString();
                    }

                    activity_record.DelDest = rs[controllerNumberMap[controllerNumber]].Del_Dest.ToString();

                    if (rs[controllerNumberMap[controllerNumber]] == rs[0])
                    {
                        activity_record.DriveSta = "red0";
                    }
                    else if (rs[controllerNumberMap[controllerNumber]] == rs[1])
                    {
                        activity_record.DriveSta = "red1";
                    }
                    else if (rs[controllerNumberMap[controllerNumber]] == rs[2])
                    {
                        activity_record.DriveSta = "red2";
                    }
                    else if (rs[controllerNumberMap[controllerNumber]] == rs[3])
                    {
                        activity_record.DriveSta = "blue0";
                    }
                    else if (rs[controllerNumberMap[controllerNumber]] == rs[4])
                    {
                        activity_record.DriveSta = "blue1";
                    }
                    else if (rs[controllerNumberMap[controllerNumber]] == rs[5])
                    {
                        activity_record.DriveSta = "blue2";
                    }
                    activity_record.RobotSta = "-";
                    activity_record.HPAmp = "-";
                    activity_record.StageStat = "-";
                    activity_record.StageAtt = 9;
                    activity_record.StageLoc = "-";
                    activity_record.Harmony = 9;
                    activity_record.Spotlit = 9;
                    activity_record.ClimbT = 0;
                    activity_record.OZTime = 0;
                    activity_record.AZTime = 0;
                    activity_record.NZTime = 0;
                    activity_record.Mics = 9;
                    activity_record.Defense = 9;
                    activity_record.Avoidance = 9;
                    activity_record.Strategy = "-";
                    activity_record.Team = rs[controllerNumberMap[controllerNumber]].TeamName;
                    activity_record.Match = rs[controllerNumberMap[controllerNumber]].Current_Match;
                    activity_record.Mode = rs[controllerNumberMap[controllerNumber]].Current_Mode.ToString();
                    activity_record.ScouterName = rs[controllerNumberMap[controllerNumber]].getScouterName(RobotState.SCOUTER_NAME.Select_Name).ToString();
                    activity_record.RecordType = "Activities";
                    activity_record.match_event = "-";
                    activity_record.ScouterError = rs[controllerNumberMap[controllerNumber]].ScouterError;

                    //Save Record to the database
                    seasonframework.ActivitySet.Add(activity_record);
                    seasonframework.SaveChanges();

                    //Reset Temp Variables
                    rs[controllerNumberMap[controllerNumber]].Acq_Center_Temp = 0;
                    rs[controllerNumberMap[controllerNumber]].Acq_Loc_Temp = "Select";
                }

                //Reset Values
                rs[controllerNumberMap[controllerNumber]].Del_Dest = RobotState.DEL_DEST.Select;
                rs[controllerNumberMap[controllerNumber]].Acq_Loc = "Select";
                rs[controllerNumberMap[controllerNumber]].Acq_Center = 0;
                rs[controllerNumberMap[controllerNumber]].Flag = 0;
                rs[controllerNumberMap[controllerNumber]].TransactionCheck = false;
                rs[controllerNumberMap[controllerNumber]].Acq_Center_Temp = 0;
            }
            else if (gamepad.RightTrigger_Press && !rs[controllerNumberMap[controllerNumber]].NoSho && rs[controllerNumberMap[controllerNumber]].TransactionCheck == false)
            {
                rs[controllerNumberMap[controllerNumber]].ScouterError = rs[controllerNumberMap[controllerNumber]].ScouterError + 100000;
            }

            // 2023 Changing modes
            if (gamepad.BackButton_Press && rs[controllerNumberMap[controllerNumber]].Current_Mode == RobotState.ROBOT_MODE.Auto && !rs[controllerNumberMap[controllerNumber]].AUTO && !rs[controllerNumberMap[controllerNumber]].NoSho)
            {
                rs[controllerNumberMap[controllerNumber]].Desired_Mode = RobotState.ROBOT_MODE.Showtime;
                rs[controllerNumberMap[controllerNumber]].Current_Mode = RobotState.ROBOT_MODE.Teleop;
            }
            else if (gamepad.BackButton_Press && rs[controllerNumberMap[controllerNumber]].Current_Mode == RobotState.ROBOT_MODE.Teleop && !rs[controllerNumberMap[controllerNumber]].NoSho)

            {
                rs[controllerNumberMap[controllerNumber]].Desired_Mode = RobotState.ROBOT_MODE.Teleop;
                rs[controllerNumberMap[controllerNumber]].Current_Mode = RobotState.ROBOT_MODE.Showtime;
                if (rs[controllerNumberMap[controllerNumber]].ClimbTDouble == 0)
                {
                    rs[controllerNumberMap[controllerNumber]].ClimbT_StopWatch.Start();
                    rs[controllerNumberMap[controllerNumber]].ClimbT = rs[controllerNumberMap[controllerNumber]].ClimbT_StopWatch.Elapsed;
                    rs[controllerNumberMap[controllerNumber]].ClimbT_StopWatch_running = true;
                }
                rs[controllerNumberMap[controllerNumber]].AllyT_StopWatch.Stop();
                rs[controllerNumberMap[controllerNumber]].AllyT = rs[controllerNumberMap[controllerNumber]].AllyT_StopWatch.Elapsed;
                rs[controllerNumberMap[controllerNumber]].AllyT_StopWatch_running = false;

                rs[controllerNumberMap[controllerNumber]].OpptT_StopWatch.Stop();
                rs[controllerNumberMap[controllerNumber]].OpptT = rs[controllerNumberMap[controllerNumber]].OpptT_StopWatch.Elapsed;
                rs[controllerNumberMap[controllerNumber]].OpptT_StopWatch_running = false;

                rs[controllerNumberMap[controllerNumber]].NeutT_StopWatch.Stop();
                rs[controllerNumberMap[controllerNumber]].NeutT = rs[controllerNumberMap[controllerNumber]].NeutT_StopWatch.Elapsed;
                rs[controllerNumberMap[controllerNumber]].NeutT_StopWatch_running = false;
            }
            else if (gamepad.BackButton_Press && rs[controllerNumberMap[controllerNumber]].Current_Mode == RobotState.ROBOT_MODE.Showtime && !rs[controllerNumberMap[controllerNumber]].NoSho)
            {
                rs[controllerNumberMap[controllerNumber]].Desired_Mode = RobotState.ROBOT_MODE.Showtime;
                rs[controllerNumberMap[controllerNumber]].Current_Mode = RobotState.ROBOT_MODE.Teleop;

                rs[controllerNumberMap[controllerNumber]].ClimbT_StopWatch.Stop();
                rs[controllerNumberMap[controllerNumber]].ClimbT = rs[controllerNumberMap[controllerNumber]].ClimbT_StopWatch.Elapsed;
                rs[controllerNumberMap[controllerNumber]].ClimbT_StopWatch_running = false;
            }
        }
    }
}