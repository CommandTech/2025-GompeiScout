using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoutingCodeRedo.Static
{
    partial class PrintOut
    {
        #region
        private void InitializeComponent()
        {
            this.lblkey = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblkey
            // 
            this.lblkey.BackColor = System.Drawing.Color.Black;
            this.lblkey.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblkey.Location = new System.Drawing.Point(21, 9);
            this.lblkey.Name = "lblkey";
            this.lblkey.Size = new System.Drawing.Size(272, 672);
            this.lblkey.TabIndex = 294;
            this.lblkey.Text = "lblkey";
            // 
            // PrintOut
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(324, 697);
            this.Controls.Add(this.lblkey);
            this.Name = "PrintOut";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblkey;
    }
}
