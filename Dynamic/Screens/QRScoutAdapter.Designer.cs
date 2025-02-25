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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panelQRScanned = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(800, 601);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // panelQRScanned
            // 
            this.panelQRScanned.BackColor = System.Drawing.Color.Lime;
            this.panelQRScanned.Location = new System.Drawing.Point(682, 27);
            this.panelQRScanned.Name = "panelQRScanned";
            this.panelQRScanned.Size = new System.Drawing.Size(101, 90);
            this.panelQRScanned.TabIndex = 1;
            this.panelQRScanned.Visible = false;
            // 
            // QRScoutAdapter
            // 
            this.ClientSize = new System.Drawing.Size(800, 601);
            this.Controls.Add(this.panelQRScanned);
            this.Controls.Add(this.pictureBox);
            this.Name = "QRScoutAdapter";
            this.Text = "Camera Capture";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CameraCapture_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.IContainer components = null;
        private PictureBox pictureBox;
        private Timer timer;
        private Panel panelQRScanned;
    }
}