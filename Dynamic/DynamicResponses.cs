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

            //if (robot.OpptT_StopWatch == null) robot.OpptT_StopWatch = new Stopwatch();

            if (!robot.NoSho && robot._ScouterName != RobotState.SCOUTER_NAME.Select_Name)
            {
                //AUTO MODE
                if (robot.Current_Mode == RobotState.ROBOT_MODE.Auto)
                {
                    
                }
                //TELEOP MODE
                else if (robot.Current_Mode == RobotState.ROBOT_MODE.Teleop)
                {
                    
                }
                //SHOWTIME MODE
                else if (robot.Current_Mode == RobotState.ROBOT_MODE.Showtime)
                {
                    
                }
                //Any mode

                // Changing modes
                //if (gamepad.BackButton_Press && robot.Current_Mode == RobotState.ROBOT_MODE.Auto && !robot.AUTO)
                //{
                //    robot.Desired_Mode = RobotState.ROBOT_MODE.Showtime;
                //    robot.Current_Mode = RobotState.ROBOT_MODE.Teleop;
                //}
                //else if (gamepad.BackButton_Press && robot.Current_Mode == RobotState.ROBOT_MODE.Teleop)

                //{
                //    robot.Desired_Mode = RobotState.ROBOT_MODE.Teleop;
                //    robot.Current_Mode = RobotState.ROBOT_MODE.Showtime;
                //}
                //else if (gamepad.BackButton_Press && robot.Current_Mode == RobotState.ROBOT_MODE.Showtime)
                //{
                //    robot.Desired_Mode = RobotState.ROBOT_MODE.Showtime;
                //    robot.Current_Mode = RobotState.ROBOT_MODE.Teleop;

                //    robot.ClimbT_StopWatch.Stop();
                //    robot.ClimbT = robot.ClimbT_StopWatch.Elapsed;
                //    robot.ClimbT_StopWatch_running = false;
                //}

                

                //2025 EndAuto End of Autonomous transaction
                //if (robot.AUTO && gamepad.BackButton_Press)
                //{
                //    TransactToDatabase(robot, "StartMatch", false);
                //    robot.AUTO = false;
                //    robot.Acq_Center_Temp = 0;
                //    robot.Acq_Center = 0;
                //}
                //else if (gamepad.RightTrigger_Press && robot.TransactionCheck == true)
                //{
                //    TransactToDatabase(robot, "Activities", false);
                //}
                //else if (gamepad.RightTrigger_Press && robot.TransactionCheck == false)
                //{
                //    robot.ScouterError += 100000;
                //}
            }

            // Values if robot is NoSho
            else if (robot.NoSho)
            {
                
            }
        }
            
        public static void TransactToDatabase(RobotState controller, string recordType, bool isTest)
        {
            if (controller._ScouterName != RobotState.SCOUTER_NAME.Select_Name && controller.TeamName != null)
            {
                switch (recordType)
                {
                    case ("StartMatch"):
                        ////Record start match time
                        //BackgroundCode.activity_record.RecordType = "StartMatch";
                        //controller.Auto_Time = DateTime.Now;
                        //BackgroundCode.activity_record.Time = controller.Auto_Time.AddSeconds(-18);

                        //BackgroundCode.activity_record.Team = BackgroundCode.Robots[controller.ScouterBox].TeamName;
                        //BackgroundCode.activity_record.Match = Settings.Default.currentMatch;
                        //BackgroundCode.activity_record.Mode = controller.Current_Mode.ToString();
                        //BackgroundCode.activity_record.ScouterName = controller.GetScouterName().ToString();

                        //BackgroundCode.activity_record.Match_event = "-";

                        //if (BackgroundCode.Robots[controller.ScouterBox] == BackgroundCode.Robots[0])
                        //{
                        //    BackgroundCode.activity_record.DriveSta = "red0";
                        //}
                        //else if (BackgroundCode.Robots[controller.ScouterBox] == BackgroundCode.Robots[1])
                        //{
                        //    BackgroundCode.activity_record.DriveSta = "red1";
                        //}
                        //else if (BackgroundCode.Robots[controller.ScouterBox] == BackgroundCode.Robots[2])
                        //{
                        //    BackgroundCode.activity_record.DriveSta = "red2";
                        //}
                        //else if (BackgroundCode.Robots[controller.ScouterBox] == BackgroundCode.Robots[3])
                        //{
                        //    BackgroundCode.activity_record.DriveSta = "blue0";
                        //}
                        //else if (BackgroundCode.Robots[controller.ScouterBox] == BackgroundCode.Robots[4])
                        //{
                        //    BackgroundCode.activity_record.DriveSta = "blue1";
                        //}
                        //else if (BackgroundCode.Robots[controller.ScouterBox] == BackgroundCode.Robots[5])
                        //{
                        //    BackgroundCode.activity_record.DriveSta = "blue2";
                        //}
                        
                        //BackgroundCode.activity_record.Defense = 9;
                        //BackgroundCode.activity_record.Avoidance = 9;
                        //BackgroundCode.activity_record.ScouterError = controller.ScouterError;

                        ////Save Record to the database
                        //BackgroundCode.seasonframework.ActivitySet.Add(BackgroundCode.activity_record);
                        //BackgroundCode.seasonframework.SaveChanges(); // If you crash here migration isn't working

                        break;
                    case ("Activities"):
                        
                        break;
                    case ("EndMatch"):
                        
                        break;
                    case ("Match_Event"):
                        
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
