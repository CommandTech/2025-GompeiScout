using ScoutingCodeRedo.Static;
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
            this.components = new System.ComponentModel.Container();
            this.lbl0Position2Flag = new System.Windows.Forms.Label();
            this.lbl0Position0Flag = new System.Windows.Forms.Label();
            this.lbl0Position2Value = new System.Windows.Forms.Label();
            this.lbl0Position1Value = new System.Windows.Forms.Label();
            this.lbl0Position0 = new System.Windows.Forms.Label();
            this.lbl0Position1 = new System.Windows.Forms.Label();
            this.lbl0Position2 = new System.Windows.Forms.Label();
            this.lbl0Position0Value = new System.Windows.Forms.Label();
            this.panel31 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel41 = new System.Windows.Forms.Panel();
            this.label113 = new System.Windows.Forms.Label();
            this.team1 = new System.Windows.Forms.Panel();
            this.lbl0Position6Value = new System.Windows.Forms.Label();
            this.lbl0Position10Value = new System.Windows.Forms.Label();
            this.lbl0Position10 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label28 = new System.Windows.Forms.Label();
            this.lbl0Position7Value = new System.Windows.Forms.Label();
            this.lbl0Position9Value = new System.Windows.Forms.Label();
            this.lbl0Position9 = new System.Windows.Forms.Label();
            this.lbl0Position7 = new System.Windows.Forms.Label();
            this.lbl0Position4Value = new System.Windows.Forms.Label();
            this.lbl0Position5Value = new System.Windows.Forms.Label();
            this.lbl0Position6 = new System.Windows.Forms.Label();
            this.lbl0Position5 = new System.Windows.Forms.Label();
            this.lbl0Position4 = new System.Windows.Forms.Label();
            this.lbl0Position8Value = new System.Windows.Forms.Label();
            this.lbl0Position3Value = new System.Windows.Forms.Label();
            this.lbl0Position3 = new System.Windows.Forms.Label();
            this.lbl0Position8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.updateScreen = new System.Windows.Forms.Timer(this.components);
            this.panel31.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel41.SuspendLayout();
            this.team1.SuspendLayout();
            this.panel8.SuspendLayout();
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
            this.panel31.Controls.Add(this.panel2);
            this.panel31.Controls.Add(this.panel41);
            this.panel31.Controls.Add(this.team1);
            this.panel31.Location = new System.Drawing.Point(20, 56);
            this.panel31.Name = "panel31";
            this.panel31.Size = new System.Drawing.Size(1485, 400);
            this.panel31.TabIndex = 347;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(6, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 11);
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
            // panel41
            // 
            this.panel41.BackColor = System.Drawing.Color.Red;
            this.panel41.Controls.Add(this.label113);
            this.panel41.Location = new System.Drawing.Point(6, 317);
            this.panel41.Name = "panel41";
            this.panel41.Size = new System.Drawing.Size(500, 11);
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
            this.team1.Controls.Add(this.lbl0Position6Value);
            this.team1.Controls.Add(this.lbl0Position10Value);
            this.team1.Controls.Add(this.lbl0Position10);
            this.team1.Controls.Add(this.panel8);
            this.team1.Controls.Add(this.lbl0Position7Value);
            this.team1.Controls.Add(this.lbl0Position9Value);
            this.team1.Controls.Add(this.lbl0Position9);
            this.team1.Controls.Add(this.lbl0Position7);
            this.team1.Controls.Add(this.lbl0Position4Value);
            this.team1.Controls.Add(this.lbl0Position5Value);
            this.team1.Controls.Add(this.lbl0Position6);
            this.team1.Controls.Add(this.lbl0Position5);
            this.team1.Controls.Add(this.lbl0Position4);
            this.team1.Controls.Add(this.lbl0Position8Value);
            this.team1.Controls.Add(this.lbl0Position3Value);
            this.team1.Controls.Add(this.lbl0Position3);
            this.team1.Controls.Add(this.lbl0Position8);
            this.team1.Location = new System.Drawing.Point(6, 3);
            this.team1.Name = "team1";
            this.team1.Size = new System.Drawing.Size(484, 394);
            this.team1.TabIndex = 0;
            // 
            // lbl0Position6Value
            // 
            this.lbl0Position6Value.AutoSize = true;
            this.lbl0Position6Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl0Position6Value.ForeColor = System.Drawing.Color.Yellow;
            this.lbl0Position6Value.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl0Position6Value.Location = new System.Drawing.Point(298, 187);
            this.lbl0Position6Value.Name = "lbl0Position6Value";
            this.lbl0Position6Value.Size = new System.Drawing.Size(49, 33);
            this.lbl0Position6Value.TabIndex = 362;
            this.lbl0Position6Value.Text = "$$";
            this.lbl0Position6Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl0Position10Value
            // 
            this.lbl0Position10Value.AutoSize = true;
            this.lbl0Position10Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl0Position10Value.ForeColor = System.Drawing.Color.Yellow;
            this.lbl0Position10Value.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl0Position10Value.Location = new System.Drawing.Point(281, 278);
            this.lbl0Position10Value.Name = "lbl0Position10Value";
            this.lbl0Position10Value.Size = new System.Drawing.Size(32, 33);
            this.lbl0Position10Value.TabIndex = 361;
            this.lbl0Position10Value.Text = "0";
            this.lbl0Position10Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl0Position10
            // 
            this.lbl0Position10.AutoSize = true;
            this.lbl0Position10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl0Position10.ForeColor = System.Drawing.Color.White;
            this.lbl0Position10.Location = new System.Drawing.Point(237, 277);
            this.lbl0Position10.Name = "lbl0Position10";
            this.lbl0Position10.Size = new System.Drawing.Size(77, 33);
            this.lbl0Position10.TabIndex = 360;
            this.lbl0Position10.Text = "Avo:";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Red;
            this.panel8.Controls.Add(this.label28);
            this.panel8.Location = new System.Drawing.Point(0, 123);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(494, 11);
            this.panel8.TabIndex = 347;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.Red;
            this.label28.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label28.Location = new System.Drawing.Point(418, 214);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(55, 37);
            this.label28.TabIndex = 277;
            this.label28.Text = "00";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl0Position7Value
            // 
            this.lbl0Position7Value.AutoSize = true;
            this.lbl0Position7Value.BackColor = System.Drawing.Color.Red;
            this.lbl0Position7Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl0Position7Value.ForeColor = System.Drawing.Color.Red;
            this.lbl0Position7Value.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl0Position7Value.Location = new System.Drawing.Point(95, 235);
            this.lbl0Position7Value.Name = "lbl0Position7Value";
            this.lbl0Position7Value.Size = new System.Drawing.Size(24, 33);
            this.lbl0Position7Value.TabIndex = 359;
            this.lbl0Position7Value.Text = ".";
            this.lbl0Position7Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl0Position9Value
            // 
            this.lbl0Position9Value.AutoSize = true;
            this.lbl0Position9Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl0Position9Value.ForeColor = System.Drawing.Color.Yellow;
            this.lbl0Position9Value.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl0Position9Value.Location = new System.Drawing.Point(65, 280);
            this.lbl0Position9Value.Name = "lbl0Position9Value";
            this.lbl0Position9Value.Size = new System.Drawing.Size(32, 33);
            this.lbl0Position9Value.TabIndex = 358;
            this.lbl0Position9Value.Text = "#";
            this.lbl0Position9Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl0Position9
            // 
            this.lbl0Position9.AutoSize = true;
            this.lbl0Position9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl0Position9.ForeColor = System.Drawing.Color.White;
            this.lbl0Position9.Location = new System.Drawing.Point(0, 280);
            this.lbl0Position9.Name = "lbl0Position9";
            this.lbl0Position9.Size = new System.Drawing.Size(89, 33);
            this.lbl0Position9.TabIndex = 357;
            this.lbl0Position9.Text = "Mics:";
            // 
            // lbl0Position7
            // 
            this.lbl0Position7.AutoSize = true;
            this.lbl0Position7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl0Position7.ForeColor = System.Drawing.Color.White;
            this.lbl0Position7.Location = new System.Drawing.Point(0, 235);
            this.lbl0Position7.Name = "lbl0Position7";
            this.lbl0Position7.Size = new System.Drawing.Size(112, 33);
            this.lbl0Position7.TabIndex = 356;
            this.lbl0Position7.Text = "Spotlit:";
            // 
            // lbl0Position4Value
            // 
            this.lbl0Position4Value.AutoSize = true;
            this.lbl0Position4Value.BackColor = System.Drawing.Color.Red;
            this.lbl0Position4Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl0Position4Value.ForeColor = System.Drawing.Color.Red;
            this.lbl0Position4Value.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl0Position4Value.Location = new System.Drawing.Point(309, 137);
            this.lbl0Position4Value.Name = "lbl0Position4Value";
            this.lbl0Position4Value.Size = new System.Drawing.Size(24, 33);
            this.lbl0Position4Value.TabIndex = 355;
            this.lbl0Position4Value.Text = ".";
            this.lbl0Position4Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl0Position5Value
            // 
            this.lbl0Position5Value.AutoSize = true;
            this.lbl0Position5Value.BackColor = System.Drawing.Color.Red;
            this.lbl0Position5Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl0Position5Value.ForeColor = System.Drawing.Color.Red;
            this.lbl0Position5Value.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl0Position5Value.Location = new System.Drawing.Point(93, 186);
            this.lbl0Position5Value.Name = "lbl0Position5Value";
            this.lbl0Position5Value.Size = new System.Drawing.Size(24, 33);
            this.lbl0Position5Value.TabIndex = 354;
            this.lbl0Position5Value.Text = ".";
            this.lbl0Position5Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl0Position6
            // 
            this.lbl0Position6.AutoSize = true;
            this.lbl0Position6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl0Position6.ForeColor = System.Drawing.Color.White;
            this.lbl0Position6.Location = new System.Drawing.Point(237, 186);
            this.lbl0Position6.Name = "lbl0Position6";
            this.lbl0Position6.Size = new System.Drawing.Size(90, 33);
            this.lbl0Position6.TabIndex = 353;
            this.lbl0Position6.Text = "Strat:";
            // 
            // lbl0Position5
            // 
            this.lbl0Position5.AutoSize = true;
            this.lbl0Position5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl0Position5.ForeColor = System.Drawing.Color.White;
            this.lbl0Position5.Location = new System.Drawing.Point(-2, 187);
            this.lbl0Position5.Name = "lbl0Position5";
            this.lbl0Position5.Size = new System.Drawing.Size(147, 33);
            this.lbl0Position5.TabIndex = 352;
            this.lbl0Position5.Text = "HP Amp: ";
            // 
            // lbl0Position4
            // 
            this.lbl0Position4.AutoSize = true;
            this.lbl0Position4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl0Position4.ForeColor = System.Drawing.Color.White;
            this.lbl0Position4.Location = new System.Drawing.Point(237, 137);
            this.lbl0Position4.Name = "lbl0Position4";
            this.lbl0Position4.Size = new System.Drawing.Size(108, 33);
            this.lbl0Position4.TabIndex = 350;
            this.lbl0Position4.Text = "Leave:";
            // 
            // lbl0Position8Value
            // 
            this.lbl0Position8Value.AutoSize = true;
            this.lbl0Position8Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl0Position8Value.ForeColor = System.Drawing.Color.Yellow;
            this.lbl0Position8Value.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl0Position8Value.Location = new System.Drawing.Point(284, 236);
            this.lbl0Position8Value.Name = "lbl0Position8Value";
            this.lbl0Position8Value.Size = new System.Drawing.Size(32, 33);
            this.lbl0Position8Value.TabIndex = 351;
            this.lbl0Position8Value.Text = "0";
            this.lbl0Position8Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl0Position3Value
            // 
            this.lbl0Position3Value.AutoSize = true;
            this.lbl0Position3Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl0Position3Value.ForeColor = System.Drawing.Color.Yellow;
            this.lbl0Position3Value.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl0Position3Value.Location = new System.Drawing.Point(74, 138);
            this.lbl0Position3Value.Name = "lbl0Position3Value";
            this.lbl0Position3Value.Size = new System.Drawing.Size(32, 33);
            this.lbl0Position3Value.TabIndex = 348;
            this.lbl0Position3Value.Text = "#";
            this.lbl0Position3Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl0Position3
            // 
            this.lbl0Position3.AutoSize = true;
            this.lbl0Position3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl0Position3.ForeColor = System.Drawing.Color.White;
            this.lbl0Position3.Location = new System.Drawing.Point(-2, 137);
            this.lbl0Position3.Name = "lbl0Position3";
            this.lbl0Position3.Size = new System.Drawing.Size(104, 33);
            this.lbl0Position3.TabIndex = 349;
            this.lbl0Position3.Text = "Setup:";
            // 
            // lbl0Position8
            // 
            this.lbl0Position8.AutoSize = true;
            this.lbl0Position8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl0Position8.ForeColor = System.Drawing.Color.White;
            this.lbl0Position8.Location = new System.Drawing.Point(240, 235);
            this.lbl0Position8.Name = "lbl0Position8";
            this.lbl0Position8.Size = new System.Drawing.Size(72, 33);
            this.lbl0Position8.TabIndex = 346;
            this.lbl0Position8.Text = "Def:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.Location = new System.Drawing.Point(19, 462);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1485, 399);
            this.panel1.TabIndex = 348;
            // 
            // updateScreen
            // 
            this.updateScreen.Interval = 50;
            this.updateScreen.Tick += new System.EventHandler(this.UpdateScreen);
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
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel41.ResumeLayout(false);
            this.panel41.PerformLayout();
            this.team1.ResumeLayout(false);
            this.team1.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
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
        private System.ComponentModel.IContainer components = null;
        private Timer updateScreen;
        private Panel panel31;
        private Panel panel41;
        private Label label113;
        private Panel team1;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label lbl0Position6Value;
        private Label lbl0Position10Value;
        private Label lbl0Position10;
        private Panel panel8;
        private Label label28;
        private Label lbl0Position7Value;
        private Label lbl0Position9Value;
        private Label lbl0Position9;
        private Label lbl0Position7;
        private Label lbl0Position4Value;
        private Label lbl0Position5Value;
        private Label lbl0Position6;
        private Label lbl0Position5;
        private Label lbl0Position4;
        private Label lbl0Position8Value;
        private Label lbl0Position3Value;
        private Label lbl0Position3;
        private Label lbl0Position8;
    }
}
