using AForge.Video;
using AForge.Video.DirectShow;
using ScoutingCodeRedo.Static;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ZXing;

namespace ScoutingCodeRedo.Dynamic.Screens
{
    internal partial class QRScoutAdapter : Form
    {
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;
        readonly List<List<string>> previousData;

        public QRScoutAdapter()
        {
            InitializeComponent();
            StartCamera();
            previousData = new List<List<string>>();
        }

        private void StartCamera()
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (videoDevices.Count == 0)
            {
                throw new ApplicationException("No video devices found.");
            }

            videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);
            videoSource.NewFrame += new NewFrameEventHandler(Video_NewFrame);
            videoSource.Start();
            timer.Start();
        }

        private void Video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            try
            {
                pictureBox.Image = bitmap;
            }
            catch (Exception)
            {

            }
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (pictureBox.Image != null)
            {
                BarcodeReader reader = new BarcodeReader();
                Result result = reader.Decode((Bitmap)pictureBox.Image);
                if (result != null)
                {
                    timer.Stop();
                    //videoSource.SignalToStop();
                    ConvertData(result);
                    timer.Start();
                }
            }
        }
        private void CameraCapture_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
            }
        }

        private void ConvertData(Result data)
        {
            List<string> splitData = data.Text.Split('\t').ToList();
            List<string> currentData = new List<string>
            {
                splitData[1],
                splitData[2],
                splitData[3]
            };
            foreach (var listData in previousData)
            {
                if (listData[0] == currentData[0] && listData[1] == currentData[1] && listData[2] == currentData[2])
                {
                    MessageBox.Show("This QR code has already been scanned");
                    panelQRScanned.Visible = true;
                    panelQRScanned.BackColor = Color.Red;
                    return;
                }
            }
            previousData.Add(currentData);
            panelQRScanned.Visible = true;
            panelQRScanned.BackColor = Color.Lime;

            //make sure to ignore qr codes already scanned (look at match number and driver station and possibly team number)
            //using the driver station, find which activity_record should be modified
            //figure out how many match event lines should be created
            //create the end auto line with the auto l1 data
            //create the match events
            //create the end match line with tele l1 added to auto l1
            //set the acquires to -1 because QR scout does not track them

            RobotState robot = new RobotState
            {
                ClimbT_StopWatch = new Stopwatch(),
                DefTime_StopWatch = new Stopwatch(),
                TeamName = "frc" + splitData[3],
                Current_Mode = RobotState.ROBOT_MODE.Teleop
            };
            //Gets the index of the scouter for activity_record[]
            int scouter = 0;
            switch (currentData[1])
            {
                case "R1":
                    scouter = 0;
                    break;
                case "R2":
                    scouter = 1;
                    break;
                case "R3":
                    scouter = 2;
                    break;
                case "B1":
                    scouter = 3;
                    break;
                case "B2":
                    scouter = 4;
                    break;
                case "B3":
                    scouter = 5;
                    break;
            }
            robot.ScouterBox = scouter;
            int.TryParse(splitData[9], out int coral1);
            robot.DelCoralL1 = coral1;
            int.TryParse(splitData[10], out int coral2);
            robot.DelCoralL2 = coral2;
            int.TryParse(splitData[11], out int coral3);
            robot.DelCoralL3 = coral3;
            int.TryParse(splitData[12], out int coral4);
            robot.DelCoralL4 = coral4;
            int.TryParse(splitData[13], out int algaeN);
            robot.DelAlgaeN = algaeN;
            int.TryParse(splitData[14], out int algaeP);
            robot.DelAlgaeP = algaeP;

            bool.TryParse(splitData[15], out bool adis);
            if (adis)
            {
                robot.DisAlgae = 1;
            }

            bool.TryParse(splitData[7], out bool leave);
            robot.Leave = RobotState.LEAVE.N;
            if (leave)
            {
                robot.Leave = RobotState.LEAVE.Y;
            }

            robot.Selected_Cage = "Shallow";
            if (splitData[6] == "SP1")
            {
                robot.Selected_Cage = "Deep";
            }

            switch (splitData[4])
            {
                case "R1":
                    robot.Starting_Location = RobotState.STARTING_LOC.C1;
                    robot.Starting_Location_Field = RobotState.STARTING_LOC_FIELD.C6;
                    break;
                case "R2":
                    robot.Starting_Location = RobotState.STARTING_LOC.Center;
                    robot.Starting_Location_Field = RobotState.STARTING_LOC_FIELD.Center;
                    break;
                case "R3":
                    robot.Starting_Location = RobotState.STARTING_LOC.C6;
                    robot.Starting_Location_Field = RobotState.STARTING_LOC_FIELD.C1;
                    break;
            }

            //Transact end auto line here
            DynamicResponses.TransactToDatabase(robot, "EndAuto", scouter, splitData[0]);


            //Transact match events here
            //5 is no show
            //26 is fell over
            //28 is died/broke down

            while (BackgroundCode.activitiesQueue.Count != 0)
            {
                //Wait
            }
            //No Show
            if (splitData[5] == "true")
            {
                robot.Match_event = RobotState.MATCHEVENT_NAME.NoShow;
                DynamicResponses.TransactToDatabase(robot, "Match_Event", scouter, splitData[0]);
            }
            while (BackgroundCode.activitiesQueue.Count != 0)
            {
                //Wait
            }
            //Fell Over
            if (splitData[26] == "true")
            {
                robot.Match_event = RobotState.MATCHEVENT_NAME.TippedOver;
                DynamicResponses.TransactToDatabase(robot, "Match_Event", scouter, splitData[0]);
            }
            while (BackgroundCode.activitiesQueue.Count != 0)
            {
                //Wait
            }
            //Died/Broke Down
            if (splitData[28] == "true")
            {
                robot.Match_event = RobotState.MATCHEVENT_NAME.BrokeDown;
                DynamicResponses.TransactToDatabase(robot, "Match_Event", scouter, splitData[0]);
            }

            int.TryParse(splitData[19], out int Tcoral1);
            robot.DelCoralL1 = Tcoral1 + coral1;
            int.TryParse(splitData[20], out int Tcoral2);
            robot.DelCoralL2 = Tcoral2 + coral2;
            int.TryParse(splitData[21], out int Tcoral3);
            robot.DelCoralL3 = Tcoral3 + coral3;
            int.TryParse(splitData[22], out int Tcoral4);
            robot.DelCoralL4 = Tcoral4 + coral4;
            int.TryParse(splitData[23], out int TalgaeN);
            robot.DelAlgaeN = TalgaeN + algaeN;
            int.TryParse(splitData[24], out int TalgaeP);
            robot.DelAlgaeP = TalgaeP + algaeP;

            bool.TryParse(splitData[16], out bool Tadis);
            if (Tadis)
            {
                robot.DisAlgae += 1;
            }

            switch (splitData[17])
            {
                case "1":
                    break;
                case "2":
                    robot.AcqCoralF = 1;
                    break;
                case "3":
                    robot.AcqCoralS = 1;
                    break;
                case "4":
                    robot.AcqCoralS = 1;
                    robot.AcqCoralF = 1;
                    break;
            }

            int.TryParse(splitData[32], out int defEff);
            robot.Def_Eff = defEff;

            switch (splitData[29])
            {
                case "No":
                    robot.End_State = RobotState.END_STATE.Elsewhere;
                    break;
                case "P":
                    robot.End_State = RobotState.END_STATE.Park;
                    break;
                case "Sc":
                    robot.ClimbTDouble = -1;
                    robot.End_State = RobotState.END_STATE.Shallow;
                    break;
                case "Dc":
                    robot.ClimbTDouble = -1;
                    robot.End_State = RobotState.END_STATE.Deep;
                    break;
                case "Fc":
                    robot.ClimbTDouble = -1;
                    robot.End_State = RobotState.END_STATE.Park;
                    break;
            }
            robot.Comments = splitData[34];

            while (BackgroundCode.activitiesQueue.Count != 0)
            {
                //Wait
            }
            //Transact end match line here
            DynamicResponses.TransactToDatabase(robot, "EndMatch", scouter, splitData[0]);

            panelQRScanned.Visible = false;
        }
    }
}