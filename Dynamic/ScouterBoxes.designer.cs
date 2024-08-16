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
            this.panel31 = new System.Windows.Forms.Panel();
            this.panel32 = new System.Windows.Forms.Panel();
            this.panel35 = new System.Windows.Forms.Panel();
            this.label106 = new System.Windows.Forms.Label();
            this.panel36 = new System.Windows.Forms.Panel();
            this.panel39 = new System.Windows.Forms.Panel();
            this.label111 = new System.Windows.Forms.Label();
            this.lbl0Position6Value2 = new System.Windows.Forms.Label();
            this.panel41 = new System.Windows.Forms.Panel();
            this.label113 = new System.Windows.Forms.Label();
            this.team1 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label54 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel30 = new System.Windows.Forms.Panel();
            this.label89 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel31.SuspendLayout();
            this.panel32.SuspendLayout();
            this.panel35.SuspendLayout();
            this.panel36.SuspendLayout();
            this.panel39.SuspendLayout();
            this.panel41.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel30.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl0Position2Flag
            // 
            this.lbl0Position2Flag.AutoSize = true;
            this.lbl0Position2Flag.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl0Position2Flag.ForeColor = System.Drawing.Color.White;
            this.lbl0Position2Flag.Location = new System.Drawing.Point(184, 150);
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
            this.lbl0Position0Flag.Location = new System.Drawing.Point(184, 113);
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
            this.lbl0Position2Value.Location = new System.Drawing.Point(84, 150);
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
            this.lbl0Position1Value.Location = new System.Drawing.Point(331, 113);
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
            this.lbl0Position0.Location = new System.Drawing.Point(32, 113);
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
            this.lbl0Position1.Location = new System.Drawing.Point(276, 113);
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
            this.lbl0Position2.Location = new System.Drawing.Point(32, 150);
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
            this.lbl0Position0Value.Location = new System.Drawing.Point(84, 113);
            this.lbl0Position0Value.Name = "lbl0Position0Value";
            this.lbl0Position0Value.Size = new System.Drawing.Size(49, 33);
            this.lbl0Position0Value.TabIndex = 339;
            this.lbl0Position0Value.Text = "$$";
            this.lbl0Position0Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel31
            // 
            this.panel31.BackColor = System.Drawing.Color.Red;
            this.panel31.Controls.Add(this.panel5);
            this.panel31.Controls.Add(this.panel4);
            this.panel31.Controls.Add(this.panel2);
            this.panel31.Controls.Add(this.panel32);
            this.panel31.Controls.Add(this.panel36);
            this.panel31.Controls.Add(this.lbl0Position6Value2);
            this.panel31.Controls.Add(this.panel41);
            this.panel31.Controls.Add(this.team1);
            this.panel31.Location = new System.Drawing.Point(20, 56);
            this.panel31.Name = "panel31";
            this.panel31.Size = new System.Drawing.Size(1196, 400);
            this.panel31.TabIndex = 347;
            // 
            // panel32
            // 
            this.panel32.BackColor = System.Drawing.Color.Black;
            this.panel32.Controls.Add(this.panel35);
            this.panel32.Location = new System.Drawing.Point(791, 3);
            this.panel32.Name = "panel32";
            this.panel32.Size = new System.Drawing.Size(393, 394);
            this.panel32.TabIndex = 347;
            // 
            // panel35
            // 
            this.panel35.BackColor = System.Drawing.Color.Red;
            this.panel35.Controls.Add(this.label106);
            this.panel35.Location = new System.Drawing.Point(0, 314);
            this.panel35.Name = "panel35";
            this.panel35.Size = new System.Drawing.Size(393, 11);
            this.panel35.TabIndex = 279;
            // 
            // label106
            // 
            this.label106.AutoSize = true;
            this.label106.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label106.ForeColor = System.Drawing.Color.Red;
            this.label106.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label106.Location = new System.Drawing.Point(418, 214);
            this.label106.Name = "label106";
            this.label106.Size = new System.Drawing.Size(55, 37);
            this.label106.TabIndex = 277;
            this.label106.Text = "00";
            this.label106.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel36
            // 
            this.panel36.BackColor = System.Drawing.Color.Black;
            this.panel36.Controls.Add(this.panel39);
            this.panel36.Location = new System.Drawing.Point(390, 3);
            this.panel36.Name = "panel36";
            this.panel36.Size = new System.Drawing.Size(395, 394);
            this.panel36.TabIndex = 280;
            // 
            // panel39
            // 
            this.panel39.BackColor = System.Drawing.Color.Red;
            this.panel39.Controls.Add(this.label111);
            this.panel39.Location = new System.Drawing.Point(0, 314);
            this.panel39.Name = "panel39";
            this.panel39.Size = new System.Drawing.Size(397, 11);
            this.panel39.TabIndex = 279;
            // 
            // label111
            // 
            this.label111.AutoSize = true;
            this.label111.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label111.ForeColor = System.Drawing.Color.Red;
            this.label111.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label111.Location = new System.Drawing.Point(418, 214);
            this.label111.Name = "label111";
            this.label111.Size = new System.Drawing.Size(55, 37);
            this.label111.TabIndex = 277;
            this.label111.Text = "00";
            this.label111.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl0Position6Value2
            // 
            this.lbl0Position6Value2.AutoSize = true;
            this.lbl0Position6Value2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl0Position6Value2.ForeColor = System.Drawing.Color.Red;
            this.lbl0Position6Value2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl0Position6Value2.Location = new System.Drawing.Point(418, 214);
            this.lbl0Position6Value2.Name = "lbl0Position6Value2";
            this.lbl0Position6Value2.Size = new System.Drawing.Size(55, 37);
            this.lbl0Position6Value2.TabIndex = 277;
            this.lbl0Position6Value2.Text = "00";
            this.lbl0Position6Value2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel41
            // 
            this.panel41.BackColor = System.Drawing.Color.Red;
            this.panel41.Controls.Add(this.label113);
            this.panel41.Location = new System.Drawing.Point(6, 317);
            this.panel41.Name = "panel41";
            this.panel41.Size = new System.Drawing.Size(381, 11);
            this.panel41.TabIndex = 279;
            // 
            // label113
            // 
            this.label113.AutoSize = true;
            this.label113.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label113.ForeColor = System.Drawing.Color.Red;
            this.label113.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label113.Location = new System.Drawing.Point(418, 214);
            this.label113.Name = "label113";
            this.label113.Size = new System.Drawing.Size(55, 37);
            this.label113.TabIndex = 277;
            this.label113.Text = "00";
            this.label113.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // team1
            // 
            this.team1.BackColor = System.Drawing.Color.Black;
            this.team1.Location = new System.Drawing.Point(6, 3);
            this.team1.Name = "team1";
            this.team1.Size = new System.Drawing.Size(381, 394);
            this.team1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel11);
            this.panel1.Location = new System.Drawing.Point(19, 462);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1197, 399);
            this.panel1.TabIndex = 348;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Location = new System.Drawing.Point(792, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(393, 391);
            this.panel3.TabIndex = 349;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DarkBlue;
            this.panel6.Controls.Add(this.label19);
            this.panel6.Location = new System.Drawing.Point(2, 310);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(390, 11);
            this.panel6.TabIndex = 279;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Red;
            this.label19.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label19.Location = new System.Drawing.Point(418, 214);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(55, 37);
            this.label19.TabIndex = 277;
            this.label19.Text = "00";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Black;
            this.panel7.Controls.Add(this.panel10);
            this.panel7.Location = new System.Drawing.Point(391, 8);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(397, 388);
            this.panel7.TabIndex = 348;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.DarkBlue;
            this.panel10.Controls.Add(this.label54);
            this.panel10.Location = new System.Drawing.Point(2, 307);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(392, 11);
            this.panel10.TabIndex = 279;
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label54.ForeColor = System.Drawing.Color.Red;
            this.label54.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label54.Location = new System.Drawing.Point(418, 214);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(55, 37);
            this.label54.TabIndex = 277;
            this.label54.Text = "00";
            this.label54.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.Black;
            this.panel11.Controls.Add(this.panel30);
            this.panel11.Location = new System.Drawing.Point(7, 7);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(380, 389);
            this.panel11.TabIndex = 347;
            // 
            // panel30
            // 
            this.panel30.BackColor = System.Drawing.Color.DarkBlue;
            this.panel30.Controls.Add(this.label89);
            this.panel30.Location = new System.Drawing.Point(2, 308);
            this.panel30.Name = "panel30";
            this.panel30.Size = new System.Drawing.Size(375, 11);
            this.panel30.TabIndex = 279;
            // 
            // label89
            // 
            this.label89.AutoSize = true;
            this.label89.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label89.ForeColor = System.Drawing.Color.Red;
            this.label89.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label89.Location = new System.Drawing.Point(418, 214);
            this.label89.Name = "label89";
            this.label89.Size = new System.Drawing.Size(55, 37);
            this.label89.TabIndex = 277;
            this.label89.Text = "00";
            this.label89.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(6, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(381, 11);
            this.panel2.TabIndex = 348;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(418, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 37);
            this.label1.TabIndex = 277;
            this.label1.Text = "00";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Red;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(390, 46);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(395, 11);
            this.panel4.TabIndex = 349;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label2.Location = new System.Drawing.Point(418, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 37);
            this.label2.TabIndex = 277;
            this.label2.Text = "00";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Red;
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(791, 46);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(393, 11);
            this.panel5.TabIndex = 350;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label3.Location = new System.Drawing.Point(418, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 37);
            this.label3.TabIndex = 277;
            this.label3.Text = "00";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ScouterBoxes
            // 
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl0Position2Flag);
            this.Controls.Add(this.lbl0Position0Flag);
            this.Controls.Add(this.lbl0Position2Value);
            this.Controls.Add(this.lbl0Position1Value);
            this.Controls.Add(this.lbl0Position0);
            this.Controls.Add(this.lbl0Position1);
            this.Controls.Add(this.lbl0Position2);
            this.Controls.Add(this.lbl0Position0Value);
            this.Controls.Add(this.panel31);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ScouterBoxes";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Black;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel31.ResumeLayout(false);
            this.panel31.PerformLayout();
            this.panel32.ResumeLayout(false);
            this.panel35.ResumeLayout(false);
            this.panel35.PerformLayout();
            this.panel36.ResumeLayout(false);
            this.panel39.ResumeLayout(false);
            this.panel39.PerformLayout();
            this.panel41.ResumeLayout(false);
            this.panel41.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel30.ResumeLayout(false);
            this.panel30.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
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
        private Panel panel31;
        private Panel panel32;
        private Panel panel35;
        private Label label106;
        private Label lbl0Position6Value2;
        private Panel panel41;
        private Label label113;
        private Panel team1;
        private Panel panel36;
        private Panel panel39;
        private Label label111;
        private Panel panel1;
        private Panel panel3;
        private Panel panel6;
        private Label label19;
        private Panel panel7;
        private Panel panel10;
        private Label label54;
        private Panel panel11;
        private Panel panel30;
        private Label label89;
        private Panel panel5;
        private Label label3;
        private Panel panel4;
        private Label label2;
        private Panel panel2;
        private Label label1;
    }
}
