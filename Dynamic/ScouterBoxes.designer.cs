using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoutingCodeRedo.Dynamic
{
    partial class ScouterBoxes
    {
        #region
        private void InitializeComponent()
        {
            this.lbl0Position2Flag = new System.Windows.Forms.Label();
            this.lbl0Position0Flag = new System.Windows.Forms.Label();
            this.lbl0Position2Value = new System.Windows.Forms.Label();
            this.lbl0Position1Value = new System.Windows.Forms.Label();
            this.lbl0Position0 = new System.Windows.Forms.Label();
            this.lbl0Position1 = new System.Windows.Forms.Label();
            this.lbl0Position2 = new System.Windows.Forms.Label();
            this.lbl0Position0Value = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl0Position2Flag
            // 
            this.lbl0Position2Flag.AutoSize = true;
            this.lbl0Position2Flag.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl0Position2Flag.ForeColor = System.Drawing.Color.White;
            this.lbl0Position2Flag.Location = new System.Drawing.Point(190, 128);
            this.lbl0Position2Flag.Name = "lbl0Position2Flag";
            this.lbl0Position2Flag.Size = new System.Drawing.Size(40, 33);
            this.lbl0Position2Flag.TabIndex = 346;
            this.lbl0Position2Flag.Text = "M";
            // 
            // lbl0Position0Flag
            // 
            this.lbl0Position0Flag.AutoSize = true;
            this.lbl0Position0Flag.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl0Position0Flag.ForeColor = System.Drawing.Color.White;
            this.lbl0Position0Flag.Location = new System.Drawing.Point(190, 91);
            this.lbl0Position0Flag.Name = "lbl0Position0Flag";
            this.lbl0Position0Flag.Size = new System.Drawing.Size(37, 33);
            this.lbl0Position0Flag.TabIndex = 345;
            this.lbl0Position0Flag.Text = "D";
            // 
            // lbl0Position2Value
            // 
            this.lbl0Position2Value.AutoSize = true;
            this.lbl0Position2Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl0Position2Value.ForeColor = System.Drawing.Color.Yellow;
            this.lbl0Position2Value.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl0Position2Value.Location = new System.Drawing.Point(90, 128);
            this.lbl0Position2Value.Name = "lbl0Position2Value";
            this.lbl0Position2Value.Size = new System.Drawing.Size(49, 33);
            this.lbl0Position2Value.TabIndex = 344;
            this.lbl0Position2Value.Text = "$$";
            this.lbl0Position2Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl0Position1Value
            // 
            this.lbl0Position1Value.AutoSize = true;
            this.lbl0Position1Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl0Position1Value.ForeColor = System.Drawing.Color.Yellow;
            this.lbl0Position1Value.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl0Position1Value.Location = new System.Drawing.Point(337, 91);
            this.lbl0Position1Value.Name = "lbl0Position1Value";
            this.lbl0Position1Value.Size = new System.Drawing.Size(49, 33);
            this.lbl0Position1Value.TabIndex = 343;
            this.lbl0Position1Value.Text = "$$";
            this.lbl0Position1Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl0Position0
            // 
            this.lbl0Position0.AutoSize = true;
            this.lbl0Position0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl0Position0.ForeColor = System.Drawing.Color.White;
            this.lbl0Position0.Location = new System.Drawing.Point(38, 91);
            this.lbl0Position0.Name = "lbl0Position0";
            this.lbl0Position0.Size = new System.Drawing.Size(77, 33);
            this.lbl0Position0.TabIndex = 341;
            this.lbl0Position0.Text = "Acq:";
            // 
            // lbl0Position1
            // 
            this.lbl0Position1.AutoSize = true;
            this.lbl0Position1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl0Position1.ForeColor = System.Drawing.Color.White;
            this.lbl0Position1.Location = new System.Drawing.Point(282, 91);
            this.lbl0Position1.Name = "lbl0Position1";
            this.lbl0Position1.Size = new System.Drawing.Size(84, 33);
            this.lbl0Position1.TabIndex = 342;
            this.lbl0Position1.Text = "Orig:";
            // 
            // lbl0Position2
            // 
            this.lbl0Position2.AutoSize = true;
            this.lbl0Position2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl0Position2.ForeColor = System.Drawing.Color.White;
            this.lbl0Position2.Location = new System.Drawing.Point(38, 128);
            this.lbl0Position2.Name = "lbl0Position2";
            this.lbl0Position2.Size = new System.Drawing.Size(71, 33);
            this.lbl0Position2.TabIndex = 340;
            this.lbl0Position2.Text = "Del:";
            // 
            // lbl0Position0Value
            // 
            this.lbl0Position0Value.AutoSize = true;
            this.lbl0Position0Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl0Position0Value.ForeColor = System.Drawing.Color.Yellow;
            this.lbl0Position0Value.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl0Position0Value.Location = new System.Drawing.Point(90, 91);
            this.lbl0Position0Value.Name = "lbl0Position0Value";
            this.lbl0Position0Value.Size = new System.Drawing.Size(49, 33);
            this.lbl0Position0Value.TabIndex = 339;
            this.lbl0Position0Value.Text = "$$";
            this.lbl0Position0Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ScouterBoxes
            // 
            this.BackColor = System.Drawing.Color.Black;
            this.TransparencyKey = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.lbl0Position2Flag);
            this.Controls.Add(this.lbl0Position0Flag);
            this.Controls.Add(this.lbl0Position2Value);
            this.Controls.Add(this.lbl0Position1Value);
            this.Controls.Add(this.lbl0Position0);
            this.Controls.Add(this.lbl0Position1);
            this.Controls.Add(this.lbl0Position2);
            this.Controls.Add(this.lbl0Position0Value);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Name = "ScouterBoxes";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Label lbl0Position2Flag;
        private System.Windows.Forms.Label lbl0Position0Flag;
        private System.Windows.Forms.Label lbl0Position2Value;
        private System.Windows.Forms.Label lbl0Position1Value;
        private System.Windows.Forms.Label lbl0Position0;
        private System.Windows.Forms.Label lbl0Position1;
        private System.Windows.Forms.Label lbl0Position2;
        private System.Windows.Forms.Label lbl0Position0Value;
    }
}
