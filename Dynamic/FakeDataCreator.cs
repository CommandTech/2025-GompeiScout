using ScoutingCodeRedo.Properties;
using ScoutingCodeRedo.Static;
using SharpDX.DirectInput;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoutingCodeRedo.Dynamic
{
    class FakeDataCreator
    {
        private static readonly Random random = new Random();
        public void GenerateFakeData(GamePad gamepad, RobotState robot)
        {
            string[] actions = { "intake", "deliver", "changeMode", "modeAction"};
            
            string action = actions[random.Next(actions.Length)];

            bool coralAlgae = random.Next(2) == 0;
            bool AcqLoc = random.Next(2) == 0;
            int DelLoc = random.Next(5);
            bool DefSurf = random.Next(2) == 0;
            int modeAction = random.Next(7);
            int startingLoc = random.Next(7);

            if (robot.Starting_Location == RobotState.STARTING_LOC.Select)
            {
                if (Settings.Default.redRight)
                {
                    while (startingLoc >= 0)
                    {
                        Thread.Sleep(100);
                        robot.CycleStart(RobotState.CYCLE_DIRECTION.Up);
                        robot.CycleStartField(RobotState.CYCLE_DIRECTION.Up);
                        startingLoc--;
                    }
                }
                else
                {
                    while (startingLoc >= 0)
                    {
                        Thread.Sleep(100);
                        robot.CycleStart(RobotState.CYCLE_DIRECTION.Up);
                        robot.CycleStartField(RobotState.CYCLE_DIRECTION.Down);
                        startingLoc--;
                    }
                }
            }

            Thread.Sleep(random.Next(100));
            switch (action)
            {
                case "intake":
                    if (robot.Current_Mode != RobotState.ROBOT_MODE.Surfacing && robot.Leave == RobotState.LEAVE.Y)
                    {
                        if (coralAlgae)
                        {
                            if (robot.lastCoralAcqLoc == " ")
                            {
                                if (AcqLoc)
                                {
                                    gamepad.SimulateButtonPress("lb");
                                }
                                else
                                {
                                    gamepad.SimulateButtonPress("lt");
                                }
                            }
                        }
                        else
                        {
                            if (robot.lastAlgaeAcqLoc == " ")
                            {
                                robot.Flag = true;
                                if (AcqLoc)
                                {
                                    gamepad.SimulateButtonPress("lb");
                                }
                                else
                                {
                                    gamepad.SimulateButtonPress("lt");
                                }
                            }
                        }
                    }
                    break;
                case "deliver":
                    if (robot.Current_Mode != RobotState.ROBOT_MODE.Surfacing && robot.Leave == RobotState.LEAVE.Y)
                    {
                        if (robot.hasCoral == 1 && coralAlgae || robot.totalCoralDeliveries == 0)
                        {
                            switch (DelLoc)
                            {
                                case 0:
                                    gamepad.SimulateButtonPress("lb");
                                    break;
                                case 1:
                                    gamepad.SimulateButtonPress("dpadleft");
                                    break;
                                case 2:
                                    gamepad.SimulateButtonPress("dpaddown");
                                    break;
                                case 3:
                                    gamepad.SimulateButtonPress("dpadright");
                                    break;
                                case 4:
                                    gamepad.SimulateButtonPress("dpadup");
                                    break;
                            }

                            Thread.Sleep(50);
                            gamepad.SimulateButtonPress("rt");
                        }
                        if (robot.hasAlgae == 1 && !coralAlgae)
                        {
                            robot.Flag = true;

                            DelLoc = random.Next(3);
                            switch (DelLoc)
                            {
                                case 0:
                                    break;
                                case 1:
                                    gamepad.SimulateButtonPress("dpadup");
                                    break;
                                case 2:
                                    gamepad.SimulateButtonPress("dpaddown");
                                    break;
                            }

                            Thread.Sleep(50);
                            gamepad.SimulateButtonPress("rt");
                        }
                    }
                    else if (robot.Current_Mode == RobotState.ROBOT_MODE.Surfacing)
                    {
                        if (AcqLoc)
                        {
                            if (robot.hasCoral == 1)
                            {
                                gamepad.SimulateButtonPress("lb");

                                Thread.Sleep(50);
                                gamepad.SimulateButtonPress("rt");
                            }
                        }
                        else
                        {
                            if (robot.hasAlgae == 1)
                            {
                                gamepad.SimulateButtonPress("rb");

                                Thread.Sleep(50);
                                gamepad.SimulateButtonPress("rt");
                            }
                        }
                    }
                    break;
                case "changeMode":
                    if (random.Next(100) < 10)
                    {
                        if (robot.Current_Mode == RobotState.ROBOT_MODE.Auto && robot.Leave != RobotState.LEAVE.Z && robot.Starting_Location != RobotState.STARTING_LOC.Select)
                        {
                            gamepad.SimulateButtonPress("startButton");
                        }
                        else if (robot.Current_Mode != RobotState.ROBOT_MODE.Surfacing && robot.Current_Mode != RobotState.ROBOT_MODE.Auto)
                        {
                            if (DefSurf)
                            {
                                gamepad.SimulateButtonPress("l3");
                            }
                            else
                            {
                                gamepad.SimulateButtonPress("startButton");
                            }
                        }
                        else if (robot.Current_Mode == RobotState.ROBOT_MODE.Surfacing && robot.End_State != RobotState.END_STATE.Select && robot.Def_Rat != 9 && robot.Def_Eff != 9 && robot.Avo_Rat != 9 && robot.Cage_Attempt != RobotState.CAGE_ATTEMPT.Select && robot.App_Strategy != RobotState.APP_STRAT.Select)
                        {
                            Settings.Default.generateFakeData = !Settings.Default.generateFakeData;
                            MessageBox.Show("Fake data generation stopped.");
                        }
                    }
                    break;
                case "modeAction":
                    if (robot.Current_Mode != RobotState.ROBOT_MODE.Surfacing)
                    {
                        modeAction = random.Next(3);

                        switch (modeAction)
                        {
                            case 0:
                                if (robot.totalCoralDeliveries == 0 && robot.Starting_Location != RobotState.STARTING_LOC.Select)
                                {
                                    gamepad.SimulateButtonPress("backButton");
                                }
                                break;
                            case 1:
                                gamepad.SimulateButtonPress("y");
                                break;
                            case 2:
                                gamepad.SimulateButtonPress("a");
                                break;
                        }
                    }
                    else
                    {
                        switch (modeAction)
                        {
                            case 0:
                                gamepad.SimulateButtonPress("dpadup");
                                break;
                            case 1:
                                gamepad.SimulateButtonPress("dpaddown");
                                break;
                            case 2:
                                gamepad.SimulateButtonPress("dpadleft");
                                break;
                            case 3:
                                gamepad.SimulateButtonPress("dpadright");
                                break;
                            case 4:
                                gamepad.SimulateButtonPress("y");
                                break;
                            case 5:
                                gamepad.SimulateButtonPress("a");
                                break;
                            case 6:
                                if (robot.ClimbT_StopWatch_running)
                                {
                                    gamepad.SimulateButtonPress("backButton");
                                }
                                break;
                        }
                    }
                    break;
            }
        }
    }
}
