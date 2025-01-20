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
        public void GenerateFakeData()
        {
            RobotState robot = BackgroundCode.Robots[0];
            string[] actions = { "intake", "deliver", "move", "endMatch", "changemode", "leave", "defense"};
            string[] buttons = { "a", "y", "rt", "lt", "rb", "lb", "dpadup", "dpaddown", "dpadleft", "dpadright", "lTHUp", "lTHDown", "rTHLeft", "rTHRight", "backButton", "startButton", "r3", "endMatch"};

            string action = actions[random.Next(actions.Length)];


            bool coralAlgae = random.Next(2) == 0;
            bool AcqLoc = random.Next(2) == 0;
            int DelLoc = random.Next(5);

            switch (action)
            {
                case "intake":
                    if (coralAlgae)
                    {
                        if (robot.lastCoralAcqLoc == " ")
                        {
                            if (AcqLoc)
                            {
                                //BackgroundCode.gamePads[0].SimulateButtonPress("lb");
                                BackgroundCode.gamePads[0].setLeftButton = true;
                            }
                            else
                            {
                                //BackgroundCode.gamePads[0].SimulateButtonPress("lt");
                                BackgroundCode.gamePads[0].setLeftTrigger = true;
                            }
                        }
                    }
                    else
                    {
                        if (robot.lastAlgaeAcqLoc == " ")
                        {
                            BackgroundCode.gamePads[0].setRightButton = true;
                            //BackgroundCode.gamePads[0].SimulateButtonDown("rb");
                            //Thread.Sleep(1);
                            if (AcqLoc)
                            {
                                //BackgroundCode.gamePads[0].SimulateButtonPress("lb");
                                BackgroundCode.gamePads[0].setLeftButton = true;
                            }
                            else
                            {
                                //BackgroundCode.gamePads[0].SimulateButtonPress("lt");
                                BackgroundCode.gamePads[0].setLeftTrigger = true;
                            }
                        }
                    }
                    
                    break;
                case "deliver":
                    //if (robot.lastCoralAcqLoc != " " && coralAlgae)
                    //{
                    //    switch (DelLoc)
                    //    {
                    //        case 0:
                    //            BackgroundCode.gamePads[0].SimulateButtonPress("lb");
                    //            break;
                    //        case 1:
                    //            BackgroundCode.gamePads[0].SimulateButtonPress("dpadleft");
                    //            break;
                    //        case 2:
                    //            BackgroundCode.gamePads[0].SimulateButtonPress("dpaddown");
                    //            break;
                    //        case 3:
                    //            BackgroundCode.gamePads[0].SimulateButtonPress("dpadright");
                    //            break;
                    //        case 4:
                    //            BackgroundCode.gamePads[0].SimulateButtonPress("dpadup");
                    //            break;
                    //    }
                    //}
                    //if (robot.lastAlgaeAcqLoc != " " && !coralAlgae)
                    //{
                    //    BackgroundCode.gamePads[0].SimulateButtonDown("rb");
                    //    Thread.Sleep(25);
                    //    DelLoc = random.Next(3);
                    //    switch (DelLoc)
                    //    {
                    //        case 0:
                    //            break;
                    //        case 1:
                    //            BackgroundCode.gamePads[0].SimulateButtonPress("dpadup");
                    //            break;
                    //        case 2:
                    //            BackgroundCode.gamePads[0].SimulateButtonPress("dpaddown");
                    //            break;
                    //    }
                    //}

                    //Thread.Sleep(25);
                    //BackgroundCode.gamePads[0].SimulateButtonPress("rt");
                    break;
                case "move":
                    break;
                case "endMatch":
                    break;
                case "changeMode":
                    break;
                case "leave":
                    break;
                case "defense":
                    break;
            }

            Thread.Sleep(50);

            //// Randomly decide whether to press or hold down a button
            //bool pressButton = random.Next(2) == 0;

            //// Randomly select a button
            //string button1 = buttons[random.Next(buttons.Length)];
            //string button2;

            //// Ensure button2 is different from button1
            //do
            //{
            //    button2 = buttons[random.Next(buttons.Length)];
            //} while (button2 == button1);

            //if (button1.StartsWith("dpad") && (robot.lastAlgaeAcqLoc == " " || robot.lastCoralAcqLoc == " ") && robot.Current_Mode != RobotState.ROBOT_MODE.Surfacing)
            //{
            //    // If dpad is selected before having a piece, randomly select right bumper or left bumper
            //    button1 = random.Next(2) == 0 ? "rb" : "lb";

            //    if (button1 == "rb")
            //    {
            //        // If right bumper is selected, hold down right bumper and press either left bumper or left trigger
            //        BackgroundCode.gamePads[0].SimulateButtonDown("rb");
            //        string secondaryButton = random.Next(2) == 0 ? "lb" : "lt";
            //        BackgroundCode.gamePads[0].SimulateButtonPress(secondaryButton);
            //        Console.WriteLine($"Held down button: rb and pressed {secondaryButton}");
            //        return;
            //    }
            //    else
            //    {
            //        // If left bumper is selected, just press it
            //        BackgroundCode.gamePads[0].SimulateButtonPress("lb");
            //        Console.WriteLine("Pressed button: lb");
            //        return;
            //    }
            //}
            //if (button1.StartsWith("dpad") && (robot.lastAlgaeAcqLoc != " " || robot.lastCoralAcqLoc != " ") && robot.Current_Mode != RobotState.ROBOT_MODE.Surfacing)
            //{
            //    BackgroundCode.gamePads[0].SimulateButtonDown(button1);
            //    Thread.Sleep(25);
            //    BackgroundCode.gamePads[0].SimulateButtonDown("rt");
            //    return;
            //}

            //if (button1.StartsWith("lTH") && robot.Current_Mode != RobotState.ROBOT_MODE.Auto)
            //{
            //    return;
            //}
            //if (button1 == "startButton" && random.Next(100) < 1 && (robot.Current_Mode == RobotState.ROBOT_MODE.Auto || robot.Current_Mode == RobotState.ROBOT_MODE.Surfacing))
            //{
            //    return;
            //}
            //if (button1 == "backButton" && !(robot.Current_Mode == RobotState.ROBOT_MODE.Auto || robot.Current_Mode == RobotState.ROBOT_MODE.Surfacing))
            //{
            //    return;
            //}
            //if (button1 == "endMatch" && robot.Current_Mode == RobotState.ROBOT_MODE.Surfacing && !robot.ClimbT_StopWatch_running && robot.End_State != RobotState.END_STATE.Select && robot.Def_Rat != 9 && robot.Def_Eff != 9 && robot.Avo_Rat != 9 && robot.Cage_Attempt != RobotState.CAGE_ATTEMPT.Select && robot.App_Strategy != RobotState.APP_STRAT.Select)
            //{
            //    Settings.Default.generateFakeData = !Settings.Default.generateFakeData;
            //    MessageBox.Show("Fake data generation stopped. Please press the button again to generate fake data.");
            //}
            //if (button1 == "rt" && !robot.TransactionCheck)
            //{
            //    return;
            //}

            //if (pressButton)
            //{
            //    BackgroundCode.gamePads[0].SimulateButtonPress(button1);
            //    Console.WriteLine($"Pressed button: {button1}");
            //}
            //else
            //{
            //    BackgroundCode.gamePads[0].SimulateButtonDown(button1);
            //    BackgroundCode.gamePads[0].SimulateButtonPress(button2);
            //    Console.WriteLine($"Held down button: {button1} and pressed {button2}");
            //}
        }
    }
}
