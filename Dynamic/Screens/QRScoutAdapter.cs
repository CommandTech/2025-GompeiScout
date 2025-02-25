using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.Drawing;
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
            //videoSource.Start();
            timer.Start();
        }

        private void Video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            pictureBox.Image = bitmap;
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            //For testing purposes
            ConvertData(null);

            if (pictureBox.Image != null)
            {
                BarcodeReader reader = new BarcodeReader();
                ZXing.Result result = reader.Decode((Bitmap)pictureBox.Image);
                if (result != null)
                {
                    timer.Stop();
                    //videoSource.SignalToStop();
                    ConvertData(result);
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

        private void ConvertData(ZXing.Result data)
        {
            //For testing purposes
            List<string> splitData = new List<string>
            {
                "L",
                "1",
                "R1",
                "0",
                "R2",
                "false",
                "SP2",
                "false",
                "0",
                "0",
                "0",
                "0",
                "0",
                "0",
                "0",
                "false",
                "0",
                "false",
                "",
                "0",
                "0",
                "0",
                "0",
                "0",
                "0",
                "false",
                "false",
                "0",
                "false",
                "No",
                "false",
                "3",
                "3",
                "No Card",
                ""
            };
            //List<string> splitData = data.Text.Split('\t').ToList();
            List<string> currentData = new List<string>
            {
                splitData[1],
                splitData[4]
            };
            foreach (var listData in previousData)
            {
                if (listData[0] == currentData[0] && listData[1] == currentData[1])
                {
                    //MessageBox.Show("This QR code has already been scanned");
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


            panelQRScanned.Visible = false;
        }
    }
}