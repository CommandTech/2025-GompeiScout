using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Drawing;
using System.Windows.Forms;
using ZXing;

namespace ScoutingCodeRedo.Dynamic.Screens
{
    internal partial class QRScoutAdapter : Form
    {
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;

        public QRScoutAdapter()
        {
            InitializeComponent();
            StartCamera();
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
            pictureBox.Image = bitmap;
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (pictureBox.Image != null)
            {
                BarcodeReader reader = new BarcodeReader();
                Result result = reader.Decode((Bitmap)smallerPictureBox.Image);
                if (result != null)
                {
                    timer.Stop();
                    videoSource.SignalToStop();
                    MessageBox.Show("QR Code Detected: " + result.Text);
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

        private void ConvertData(Result data)
        {
            string[] splitData = data.Text.Split(',');
            //make sure to ignore qr codes already scanned (look at match number and driver station and possibly team number)
            //using the driver station, find which activity_record should be modified
            //figure out how many match event lines should be created
            //create the end auto line with the auto l1 data
            //create the match events
            //create the end match line with tele l1 added to auto l1
            //set the acquires to -1 because QR scout does not track them

        }
    }
}