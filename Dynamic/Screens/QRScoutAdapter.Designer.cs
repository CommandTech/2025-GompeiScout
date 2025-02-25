using AForge.Video.DirectShow;
using System.Drawing;
using System;
using System.Windows.Forms;

namespace ScoutingCodeRedo.Dynamic.Screens
{
    partial class QRScoutAdapter
    {
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox = new PictureBox();
            this.timer = new Timer();
            this.SuspendLayout();

            // PictureBox settings
            this.pictureBox.Dock = DockStyle.Fill;
            this.pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(this.pictureBox);

            // Timer
            this.timer.Interval = 100; // Scan every 100ms
            this.timer.Tick += new EventHandler(this.Timer_Tick);

            // Form settings
            this.ClientSize = new Size(800, 600);
            this.Name = "CameraCapture";
            this.Text = "Camera Capture";
            this.FormClosing += new FormClosingEventHandler(this.CameraCapture_FormClosing);
            this.ResumeLayout(false);
        }

        #endregion
        private System.ComponentModel.IContainer components = null;
        private PictureBox pictureBox;
        private Timer timer;
    }
}