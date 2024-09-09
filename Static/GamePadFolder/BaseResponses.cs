using ScoutingCodeRedo.Dynamic;
using SharpDX.DirectInput;
using SharpDX.XInput;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ScoutingCodeRedo.Static.GamePadFolder
{
    class Controllers
    {
        public Stopwatch stopwatch = new Stopwatch();
        public TimeSpan Zero { get; private set; }

        private DynamicResponses dynamicGamepad = new DynamicResponses();

        private bool IsAxis(Guid objectType)
        {
            return objectType == ObjectGuid.XAxis ||
                   objectType == ObjectGuid.YAxis ||
                   objectType == ObjectGuid.ZAxis ||
                   objectType == ObjectGuid.RxAxis ||
                   objectType == ObjectGuid.RyAxis ||
                   objectType == ObjectGuid.RzAxis;
        }
        public Joystick[] GetSticks(DirectInput input)
        {
            List<Joystick> sticks = new List<Joystick>();
            foreach (DeviceInstance device in input.GetDevices(DeviceClass.GameControl, DeviceEnumerationFlags.AttachedOnly))
            {
                try
                {
                    var stick = new Joystick(input, device.InstanceGuid);
                    stick.Acquire();

                    foreach (DeviceObjectInstance deviceObject in stick.GetObjects())
                    {
                        if (IsAxis(deviceObject.ObjectType))
                        {
                            var properties = stick.GetObjectPropertiesById(deviceObject.ObjectId);
                            if (properties != null)
                            {
                                properties.Range = new InputRange(-100, 100);
                            }
                        }
                    }

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
            return BackgroundCode.Robots[state]; //If you crash here, you do not have a controller connected
        }

        public GamePad[] getGamePads()
        {
            DirectInput input = new DirectInput();
            List<GamePad> gamepads = new List<GamePad>();

            foreach (var stick in GetSticks(input))
            {
                gamepads.Add(new GamePad(stick));
                Console.WriteLine(stick.Information.InstanceName);
            }

            return gamepads.ToArray();
        }
        public void readStick(GamePad[] gpArray, int controllerNumber)
        {
            GamePad gamepad = gpArray[controllerNumber];
            gamepad.Update();

            //Match events
            if (gamepad.RTHRight_Press && !BackgroundCode.Robots[controllerNumber].NoSho && !gamepad.XButton_Down)
            {
                BackgroundCode.Robots[controllerNumber].cycleEventName(RobotState.CYCLE_DIRECTION.Up);
            }
            else if (gamepad.RTHLeft_Press && !BackgroundCode.Robots[controllerNumber].NoSho && !gamepad.XButton_Down)
            {
                BackgroundCode.Robots[controllerNumber].cycleEventName(RobotState.CYCLE_DIRECTION.Down);
            }
            else if (gamepad.R3_Press)
            {
                if (BackgroundCode.Robots[controllerNumber].match_event != RobotState.MATCHEVENT_NAME.Match_Event &&
                    !BackgroundCode.Robots[controllerNumber].NoSho &&
                    BackgroundCode.Robots[controllerNumber]._ScouterName != RobotState.SCOUTER_NAME.Select_Name)
                {
                    if (BackgroundCode.Robots[controllerNumber].match_event == RobotState.MATCHEVENT_NAME.NoShow)
                    {
                        BackgroundCode.activity_record.match_event = (BackgroundCode.Robots[controllerNumber].match_event.ToString())[0].ToString();
                        BackgroundCode.Robots[controllerNumber].NoSho = true;
                    }
                    else
                    {
                        BackgroundCode.activity_record.match_event = (BackgroundCode.Robots[controllerNumber].match_event.ToString())[0].ToString(); //If you crash here you didn't load matches
                    }
                    BackgroundCode.activity_record.Team = BackgroundCode.Robots[controllerNumber].TeamName;
                    BackgroundCode.activity_record.Match = BackgroundCode.Robots[controllerNumber].Current_Match;
                    BackgroundCode.activity_record.Time = DateTime.Now;
                    BackgroundCode.activity_record.Mode = BackgroundCode.Robots[controllerNumber].Current_Mode.ToString();
                    BackgroundCode.activity_record.ScouterName = BackgroundCode.Robots[controllerNumber].getScouterName(RobotState.SCOUTER_NAME.Select_Name).ToString();
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

                    if (BackgroundCode.Robots[controllerNumber] == BackgroundCode.Robots[0])
                    {
                        BackgroundCode.activity_record.DriveSta = "red0";
                    }
                    else if (BackgroundCode.Robots[controllerNumber] == BackgroundCode.Robots[1])
                    {
                        BackgroundCode.activity_record.DriveSta = "red1";
                    }
                    else if (BackgroundCode.Robots[controllerNumber] == BackgroundCode.Robots[2])
                    {
                        BackgroundCode.activity_record.DriveSta = "red2";
                    }
                    else if (BackgroundCode.Robots[controllerNumber] == BackgroundCode.Robots[3])
                    {
                        BackgroundCode.activity_record.DriveSta = "blue0";
                    }
                    else if (BackgroundCode.Robots[controllerNumber] == BackgroundCode.Robots[4])
                    {
                        BackgroundCode.activity_record.DriveSta = "blue1";
                    }
                    else if (BackgroundCode.Robots[controllerNumber] == BackgroundCode.Robots[5])
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

                    BackgroundCode.Robots[controllerNumber].match_event = RobotState.MATCHEVENT_NAME.Match_Event;

                    //Reset Match Event
                    BackgroundCode.Robots[controllerNumber].match_event = 0;
                }
                else if (BackgroundCode.Robots[controllerNumber].match_event == RobotState.MATCHEVENT_NAME.Match_Event)
                {
                    BackgroundCode.Robots[controllerNumber].ScouterError++;
                }
                BackgroundCode.Robots[controllerNumber].match_event = RobotState.MATCHEVENT_NAME.Match_Event;
            }

            //Scouter names
            if (gamepad.LTHRight_Press)
            {
                BackgroundCode.Robots[controllerNumber].changeScouterName(RobotState.CYCLE_DIRECTION.Up);
            }
            if (gamepad.LTHLeft_Press)
            {
                BackgroundCode.Robots[controllerNumber].changeScouterName(RobotState.CYCLE_DIRECTION.Down);
            }

            dynamicGamepad.readStick(gpArray, controllerNumber);
        }
    }
}
