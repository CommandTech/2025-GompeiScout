using ScoutingCodeRedo.Static;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ScoutingCodeRedo.Dynamic
{
    partial class ScouterBoxes
    {
        #region
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbl0Position0 = new System.Windows.Forms.Label();
            this.lbl0Position1 = new System.Windows.Forms.Label();
            this.redPanel = new System.Windows.Forms.Panel();
            this.red3 = new System.Windows.Forms.Panel();
            this.lbl2Position0Value = new System.Windows.Forms.Label();
            this.lbl2Position0 = new System.Windows.Forms.Label();
            this.lbl2Position12Value = new System.Windows.Forms.Label();
            this.lbl2Position12 = new System.Windows.Forms.Label();
            this.lbl2Position11Value = new System.Windows.Forms.Label();
            this.lbl2Position11 = new System.Windows.Forms.Label();
            this.lbl2Position8Value = new System.Windows.Forms.Label();
            this.lbl2Position8 = new System.Windows.Forms.Label();
            this.lbl2Position7Value = new System.Windows.Forms.Label();
            this.lbl2Position7 = new System.Windows.Forms.Label();
            this.lbl2Position5Value = new System.Windows.Forms.Label();
            this.lbl2Position5 = new System.Windows.Forms.Label();
            this.lbl2Position4Value = new System.Windows.Forms.Label();
            this.lbl2Position4 = new System.Windows.Forms.Label();
            this.lbl2Position3Des = new System.Windows.Forms.Label();
            this.lbl2Position3Source = new System.Windows.Forms.Label();
            this.lbl2Position2Des = new System.Windows.Forms.Label();
            this.lbl2Position2Source = new System.Windows.Forms.Label();
            this.lbl2Position1 = new System.Windows.Forms.Label();
            this.lbl2Position3Value = new System.Windows.Forms.Label();
            this.lbl2Position3 = new System.Windows.Forms.Label();
            this.lbl2Position2Value = new System.Windows.Forms.Label();
            this.lbl2Position2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label64 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label65 = new System.Windows.Forms.Label();
            this.red2 = new System.Windows.Forms.Panel();
            this.lbl1Position0Value = new System.Windows.Forms.Label();
            this.lbl1Position0 = new System.Windows.Forms.Label();
            this.lbl1Position12Value = new System.Windows.Forms.Label();
            this.lbl1Position12 = new System.Windows.Forms.Label();
            this.lbl1Position11Value = new System.Windows.Forms.Label();
            this.lbl1Position11 = new System.Windows.Forms.Label();
            this.lbl1Position8Value = new System.Windows.Forms.Label();
            this.lbl1Position8 = new System.Windows.Forms.Label();
            this.lbl1Position7Value = new System.Windows.Forms.Label();
            this.lbl1Position7 = new System.Windows.Forms.Label();
            this.lbl1Position5Value = new System.Windows.Forms.Label();
            this.lbl1Position5 = new System.Windows.Forms.Label();
            this.lbl1Position4Value = new System.Windows.Forms.Label();
            this.lbl1Position4 = new System.Windows.Forms.Label();
            this.lbl1Position3Des = new System.Windows.Forms.Label();
            this.lbl1Position3Source = new System.Windows.Forms.Label();
            this.lbl1Position2Des = new System.Windows.Forms.Label();
            this.lbl1Position2Source = new System.Windows.Forms.Label();
            this.lbl1Position1 = new System.Windows.Forms.Label();
            this.lbl1Position3Value = new System.Windows.Forms.Label();
            this.lbl1Position3 = new System.Windows.Forms.Label();
            this.lbl1Position2Value = new System.Windows.Forms.Label();
            this.lbl1Position2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label32 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label33 = new System.Windows.Forms.Label();
            this.red1 = new System.Windows.Forms.Panel();
            this.lbl0Position0Value = new System.Windows.Forms.Label();
            this.lbl0Position12Value = new System.Windows.Forms.Label();
            this.lbl0Position12 = new System.Windows.Forms.Label();
            this.lbl0Position11Value = new System.Windows.Forms.Label();
            this.lbl0Position11 = new System.Windows.Forms.Label();
            this.lbl0Position8Value = new System.Windows.Forms.Label();
            this.lbl0Position8 = new System.Windows.Forms.Label();
            this.lbl0Position7Value = new System.Windows.Forms.Label();
            this.lbl0Position7 = new System.Windows.Forms.Label();
            this.lbl0Position5Value = new System.Windows.Forms.Label();
            this.lbl0Position5 = new System.Windows.Forms.Label();
            this.lbl0Position4Value = new System.Windows.Forms.Label();
            this.lbl0Position4 = new System.Windows.Forms.Label();
            this.lbl0Position3Des = new System.Windows.Forms.Label();
            this.lbl0Position3Source = new System.Windows.Forms.Label();
            this.lbl0Position2Des = new System.Windows.Forms.Label();
            this.lbl0Position2Source = new System.Windows.Forms.Label();
            this.lbl0Position3Value = new System.Windows.Forms.Label();
            this.lbl0Position3 = new System.Windows.Forms.Label();
            this.lbl0Position2Value = new System.Windows.Forms.Label();
            this.lbl0Position2 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label28 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bluePanel = new System.Windows.Forms.Panel();
            this.blue3 = new System.Windows.Forms.Panel();
            this.lbl5Position0Value = new System.Windows.Forms.Label();
            this.lbl5Position0 = new System.Windows.Forms.Label();
            this.lbl5Position12Value = new System.Windows.Forms.Label();
            this.lbl5Position12 = new System.Windows.Forms.Label();
            this.lbl5Position11Value = new System.Windows.Forms.Label();
            this.lbl5Position11 = new System.Windows.Forms.Label();
            this.lbl5Position8Value = new System.Windows.Forms.Label();
            this.lbl5Position8 = new System.Windows.Forms.Label();
            this.lbl5Position7Value = new System.Windows.Forms.Label();
            this.lbl5Position7 = new System.Windows.Forms.Label();
            this.lbl5Position5Value = new System.Windows.Forms.Label();
            this.lbl5Position5 = new System.Windows.Forms.Label();
            this.lbl5Position4Value = new System.Windows.Forms.Label();
            this.lbl5Position4 = new System.Windows.Forms.Label();
            this.lbl5Position3Des = new System.Windows.Forms.Label();
            this.lbl5Position3Source = new System.Windows.Forms.Label();
            this.lbl5Position2Des = new System.Windows.Forms.Label();
            this.lbl5Position2Source = new System.Windows.Forms.Label();
            this.lbl5Position1 = new System.Windows.Forms.Label();
            this.lbl5Position3Value = new System.Windows.Forms.Label();
            this.lbl5Position3 = new System.Windows.Forms.Label();
            this.lbl5Position2Value = new System.Windows.Forms.Label();
            this.lbl5Position2 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label96 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label97 = new System.Windows.Forms.Label();
            this.blue2 = new System.Windows.Forms.Panel();
            this.lbl4Position0Value = new System.Windows.Forms.Label();
            this.lbl4Position0 = new System.Windows.Forms.Label();
            this.lbl4Position12Value = new System.Windows.Forms.Label();
            this.lbl4Position12 = new System.Windows.Forms.Label();
            this.lbl4Position11Value = new System.Windows.Forms.Label();
            this.lbl4Position11 = new System.Windows.Forms.Label();
            this.lbl4Position8Value = new System.Windows.Forms.Label();
            this.lbl4Position8 = new System.Windows.Forms.Label();
            this.lbl4Position7Value = new System.Windows.Forms.Label();
            this.lbl4Position7 = new System.Windows.Forms.Label();
            this.lbl4Position5Value = new System.Windows.Forms.Label();
            this.lbl4Position5 = new System.Windows.Forms.Label();
            this.lbl4Position4Value = new System.Windows.Forms.Label();
            this.lbl4Position4 = new System.Windows.Forms.Label();
            this.lbl4Position3Des = new System.Windows.Forms.Label();
            this.lbl4Position3Source = new System.Windows.Forms.Label();
            this.lbl4Position2Des = new System.Windows.Forms.Label();
            this.lbl4Position2Source = new System.Windows.Forms.Label();
            this.lbl4Position1 = new System.Windows.Forms.Label();
            this.lbl4Position3Value = new System.Windows.Forms.Label();
            this.lbl4Position3 = new System.Windows.Forms.Label();
            this.lbl4Position2Value = new System.Windows.Forms.Label();
            this.lbl4Position2 = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.label129 = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.label130 = new System.Windows.Forms.Label();
            this.blue1 = new System.Windows.Forms.Panel();
            this.lbl3Position0Value = new System.Windows.Forms.Label();
            this.lbl3Position0 = new System.Windows.Forms.Label();
            this.lbl3Position12Value = new System.Windows.Forms.Label();
            this.lbl3Position12 = new System.Windows.Forms.Label();
            this.lbl3Position11Value = new System.Windows.Forms.Label();
            this.lbl3Position11 = new System.Windows.Forms.Label();
            this.lbl3Position8Value = new System.Windows.Forms.Label();
            this.lbl3Position8 = new System.Windows.Forms.Label();
            this.lbl3Position7Value = new System.Windows.Forms.Label();
            this.lbl3Position7 = new System.Windows.Forms.Label();
            this.lbl3Position5Value = new System.Windows.Forms.Label();
            this.lbl3Position5 = new System.Windows.Forms.Label();
            this.lbl3Position4Value = new System.Windows.Forms.Label();
            this.lbl3Position4 = new System.Windows.Forms.Label();
            this.lbl3Position3Des = new System.Windows.Forms.Label();
            this.lbl3Position3Source = new System.Windows.Forms.Label();
            this.lbl3Position2Des = new System.Windows.Forms.Label();
            this.lbl3Position2Source = new System.Windows.Forms.Label();
            this.lbl3Position1 = new System.Windows.Forms.Label();
            this.lbl3Position3Value = new System.Windows.Forms.Label();
            this.lbl3Position3 = new System.Windows.Forms.Label();
            this.lbl3Position2Value = new System.Windows.Forms.Label();
            this.lbl3Position2 = new System.Windows.Forms.Label();
            this.panel18 = new System.Windows.Forms.Panel();
            this.label161 = new System.Windows.Forms.Label();
            this.panel19 = new System.Windows.Forms.Panel();
            this.label162 = new System.Windows.Forms.Label();
            this.updateScreen = new System.Windows.Forms.Timer(this.components);
            this.lblRedScore = new System.Windows.Forms.Label();
            this.lblBlueScore = new System.Windows.Forms.Label();
            this.redPanel.SuspendLayout();
            this.red3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.red2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.red1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel2.SuspendLayout();
            this.bluePanel.SuspendLayout();
            this.blue3.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.blue2.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel15.SuspendLayout();
            this.blue1.SuspendLayout();
            this.panel18.SuspendLayout();
            this.panel19.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl0Position0
            // 
            this.lbl0Position0.AutoSize = true;
            this.lbl0Position0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl0Position0.ForeColor = System.Drawing.Color.White;
            this.lbl0Position0.Location = new System.Drawing.Point(7, 61);
            this.lbl0Position0.Name = "lbl0Position0";
            this.lbl0Position0.Size = new System.Drawing.Size(83, 29);
            this.lbl0Position0.TabIndex = 341;
            this.lbl0Position0.Text = "Leave";
            // 
            // lbl0Position1
            // 
            this.lbl0Position1.AutoSize = true;
            this.lbl0Position1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl0Position1.ForeColor = System.Drawing.Color.White;
            this.lbl0Position1.Location = new System.Drawing.Point(250, 62);
            this.lbl0Position1.Name = "lbl0Position1";
            this.lbl0Position1.Size = new System.Drawing.Size(131, 29);
            this.lbl0Position1.TabIndex = 342;
            this.lbl0Position1.Text = "Near Side";
            // 
            // redPanel
            // 
            this.redPanel.BackColor = System.Drawing.Color.Red;
            this.redPanel.Controls.Add(this.red3);
            this.redPanel.Controls.Add(this.red2);
            this.redPanel.Controls.Add(this.red1);
            this.redPanel.Location = new System.Drawing.Point(20, 56);
            this.redPanel.Name = "redPanel";
            this.redPanel.Size = new System.Drawing.Size(1485, 400);
            this.redPanel.TabIndex = 347;
            // 
            // red3
            // 
            this.red3.BackColor = System.Drawing.Color.Black;
            this.red3.Controls.Add(this.lbl2Position0Value);
            this.red3.Controls.Add(this.lbl2Position0);
            this.red3.Controls.Add(this.lbl2Position12Value);
            this.red3.Controls.Add(this.lbl2Position12);
            this.red3.Controls.Add(this.lbl2Position11Value);
            this.red3.Controls.Add(this.lbl2Position11);
            this.red3.Controls.Add(this.lbl2Position8Value);
            this.red3.Controls.Add(this.lbl2Position8);
            this.red3.Controls.Add(this.lbl2Position7Value);
            this.red3.Controls.Add(this.lbl2Position7);
            this.red3.Controls.Add(this.lbl2Position5Value);
            this.red3.Controls.Add(this.lbl2Position5);
            this.red3.Controls.Add(this.lbl2Position4Value);
            this.red3.Controls.Add(this.lbl2Position4);
            this.red3.Controls.Add(this.lbl2Position3Des);
            this.red3.Controls.Add(this.lbl2Position3Source);
            this.red3.Controls.Add(this.lbl2Position2Des);
            this.red3.Controls.Add(this.lbl2Position2Source);
            this.red3.Controls.Add(this.lbl2Position1);
            this.red3.Controls.Add(this.lbl2Position3Value);
            this.red3.Controls.Add(this.lbl2Position3);
            this.red3.Controls.Add(this.lbl2Position2Value);
            this.red3.Controls.Add(this.lbl2Position2);
            this.red3.Controls.Add(this.panel6);
            this.red3.Controls.Add(this.panel7);
            this.red3.Location = new System.Drawing.Point(994, 3);
            this.red3.Name = "red3";
            this.red3.Size = new System.Drawing.Size(484, 394);
            this.red3.TabIndex = 388;
            // 
            // lbl2Position0Value
            // 
            this.lbl2Position0Value.AutoSize = true;
            this.lbl2Position0Value.BackColor = System.Drawing.Color.Red;
            this.lbl2Position0Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl2Position0Value.ForeColor = System.Drawing.Color.Red;
            this.lbl2Position0Value.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl2Position0Value.Location = new System.Drawing.Point(77, 61);
            this.lbl2Position0Value.Name = "lbl2Position0Value";
            this.lbl2Position0Value.Size = new System.Drawing.Size(20, 29);
            this.lbl2Position0Value.TabIndex = 355;
            this.lbl2Position0Value.Text = ".";
            this.lbl2Position0Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl2Position0
            // 
            this.lbl2Position0.AutoSize = true;
            this.lbl2Position0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2Position0.ForeColor = System.Drawing.Color.White;
            this.lbl2Position0.Location = new System.Drawing.Point(7, 61);
            this.lbl2Position0.Name = "lbl2Position0";
            this.lbl2Position0.Size = new System.Drawing.Size(83, 29);
            this.lbl2Position0.TabIndex = 341;
            this.lbl2Position0.Text = "Leave";
            // 
            // lbl2Position12Value
            // 
            this.lbl2Position12Value.AutoSize = true;
            this.lbl2Position12Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2Position12Value.ForeColor = System.Drawing.Color.White;
            this.lbl2Position12Value.Location = new System.Drawing.Point(57, 279);
            this.lbl2Position12Value.Name = "lbl2Position12Value";
            this.lbl2Position12Value.Size = new System.Drawing.Size(27, 29);
            this.lbl2Position12Value.TabIndex = 386;
            this.lbl2Position12Value.Text = "9";
            // 
            // lbl2Position12
            // 
            this.lbl2Position12.AutoSize = true;
            this.lbl2Position12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2Position12.ForeColor = System.Drawing.Color.White;
            this.lbl2Position12.Location = new System.Drawing.Point(7, 278);
            this.lbl2Position12.Name = "lbl2Position12";
            this.lbl2Position12.Size = new System.Drawing.Size(74, 29);
            this.lbl2Position12.TabIndex = 385;
            this.lbl2Position12.Text = "Strat:";
            // 
            // lbl2Position11Value
            // 
            this.lbl2Position11Value.AutoSize = true;
            this.lbl2Position11Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2Position11Value.ForeColor = System.Drawing.Color.White;
            this.lbl2Position11Value.Location = new System.Drawing.Point(111, 251);
            this.lbl2Position11Value.Name = "lbl2Position11Value";
            this.lbl2Position11Value.Size = new System.Drawing.Size(27, 29);
            this.lbl2Position11Value.TabIndex = 384;
            this.lbl2Position11Value.Text = "9";
            // 
            // lbl2Position11
            // 
            this.lbl2Position11.AutoSize = true;
            this.lbl2Position11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2Position11.ForeColor = System.Drawing.Color.White;
            this.lbl2Position11.Location = new System.Drawing.Point(7, 251);
            this.lbl2Position11.Name = "lbl2Position11";
            this.lbl2Position11.Size = new System.Drawing.Size(133, 29);
            this.lbl2Position11.TabIndex = 383;
            this.lbl2Position11.Text = "End State:";
            // 
            // lbl2Position8Value
            // 
            this.lbl2Position8Value.AutoSize = true;
            this.lbl2Position8Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2Position8Value.ForeColor = System.Drawing.Color.White;
            this.lbl2Position8Value.Location = new System.Drawing.Point(444, 192);
            this.lbl2Position8Value.Name = "lbl2Position8Value";
            this.lbl2Position8Value.Size = new System.Drawing.Size(27, 29);
            this.lbl2Position8Value.TabIndex = 372;
            this.lbl2Position8Value.Text = "9";
            // 
            // lbl2Position8
            // 
            this.lbl2Position8.AutoSize = true;
            this.lbl2Position8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2Position8.ForeColor = System.Drawing.Color.White;
            this.lbl2Position8.Location = new System.Drawing.Point(380, 191);
            this.lbl2Position8.Name = "lbl2Position8";
            this.lbl2Position8.Size = new System.Drawing.Size(85, 29);
            this.lbl2Position8.TabIndex = 371;
            this.lbl2Position8.Text = "Avoid:";
            // 
            // lbl2Position7Value
            // 
            this.lbl2Position7Value.AutoSize = true;
            this.lbl2Position7Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2Position7Value.ForeColor = System.Drawing.Color.White;
            this.lbl2Position7Value.Location = new System.Drawing.Point(336, 247);
            this.lbl2Position7Value.Name = "lbl2Position7Value";
            this.lbl2Position7Value.Size = new System.Drawing.Size(27, 29);
            this.lbl2Position7Value.TabIndex = 380;
            this.lbl2Position7Value.Text = "9";
            // 
            // lbl2Position7
            // 
            this.lbl2Position7.AutoSize = true;
            this.lbl2Position7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2Position7.ForeColor = System.Drawing.Color.White;
            this.lbl2Position7.Location = new System.Drawing.Point(301, 246);
            this.lbl2Position7.Name = "lbl2Position7";
            this.lbl2Position7.Size = new System.Drawing.Size(51, 29);
            this.lbl2Position7.TabIndex = 379;
            this.lbl2Position7.Text = "Eff:";
            // 
            // lbl2Position5Value
            // 
            this.lbl2Position5Value.AutoSize = true;
            this.lbl2Position5Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2Position5Value.ForeColor = System.Drawing.Color.White;
            this.lbl2Position5Value.Location = new System.Drawing.Point(242, 191);
            this.lbl2Position5Value.Name = "lbl2Position5Value";
            this.lbl2Position5Value.Size = new System.Drawing.Size(27, 29);
            this.lbl2Position5Value.TabIndex = 370;
            this.lbl2Position5Value.Text = "9";
            this.lbl2Position5Value.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl2Position5
            // 
            this.lbl2Position5.AutoSize = true;
            this.lbl2Position5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2Position5.ForeColor = System.Drawing.Color.White;
            this.lbl2Position5.Location = new System.Drawing.Point(189, 190);
            this.lbl2Position5.Name = "lbl2Position5";
            this.lbl2Position5.Size = new System.Drawing.Size(60, 29);
            this.lbl2Position5.TabIndex = 369;
            this.lbl2Position5.Text = "Def:";
            this.lbl2Position5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl2Position4Value
            // 
            this.lbl2Position4Value.AutoSize = true;
            this.lbl2Position4Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2Position4Value.ForeColor = System.Drawing.Color.White;
            this.lbl2Position4Value.Location = new System.Drawing.Point(345, 142);
            this.lbl2Position4Value.Name = "lbl2Position4Value";
            this.lbl2Position4Value.Size = new System.Drawing.Size(27, 29);
            this.lbl2Position4Value.TabIndex = 366;
            this.lbl2Position4Value.Text = "9";
            // 
            // lbl2Position4
            // 
            this.lbl2Position4.AutoSize = true;
            this.lbl2Position4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2Position4.ForeColor = System.Drawing.Color.White;
            this.lbl2Position4.Location = new System.Drawing.Point(263, 141);
            this.lbl2Position4.Name = "lbl2Position4";
            this.lbl2Position4.Size = new System.Drawing.Size(108, 29);
            this.lbl2Position4.TabIndex = 365;
            this.lbl2Position4.Text = "Attempt:";
            // 
            // lbl2Position3Des
            // 
            this.lbl2Position3Des.AutoSize = true;
            this.lbl2Position3Des.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2Position3Des.ForeColor = System.Drawing.Color.White;
            this.lbl2Position3Des.Location = new System.Drawing.Point(181, 156);
            this.lbl2Position3Des.Name = "lbl2Position3Des";
            this.lbl2Position3Des.Size = new System.Drawing.Size(75, 29);
            this.lbl2Position3Des.TabIndex = 364;
            this.lbl2Position3Des.Text = "Floor";
            // 
            // lbl2Position3Source
            // 
            this.lbl2Position3Source.AutoSize = true;
            this.lbl2Position3Source.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2Position3Source.ForeColor = System.Drawing.Color.White;
            this.lbl2Position3Source.Location = new System.Drawing.Point(108, 156);
            this.lbl2Position3Source.Name = "lbl2Position3Source";
            this.lbl2Position3Source.Size = new System.Drawing.Size(75, 29);
            this.lbl2Position3Source.TabIndex = 378;
            this.lbl2Position3Source.Text = "Floor";
            // 
            // lbl2Position2Des
            // 
            this.lbl2Position2Des.AutoSize = true;
            this.lbl2Position2Des.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2Position2Des.ForeColor = System.Drawing.Color.White;
            this.lbl2Position2Des.Location = new System.Drawing.Point(181, 118);
            this.lbl2Position2Des.Name = "lbl2Position2Des";
            this.lbl2Position2Des.Size = new System.Drawing.Size(75, 29);
            this.lbl2Position2Des.TabIndex = 363;
            this.lbl2Position2Des.Text = "Floor";
            // 
            // lbl2Position2Source
            // 
            this.lbl2Position2Source.AutoSize = true;
            this.lbl2Position2Source.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2Position2Source.ForeColor = System.Drawing.Color.White;
            this.lbl2Position2Source.Location = new System.Drawing.Point(108, 118);
            this.lbl2Position2Source.Name = "lbl2Position2Source";
            this.lbl2Position2Source.Size = new System.Drawing.Size(94, 29);
            this.lbl2Position2Source.TabIndex = 377;
            this.lbl2Position2Source.Text = "Station";
            // 
            // lbl2Position1
            // 
            this.lbl2Position1.AutoSize = true;
            this.lbl2Position1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2Position1.ForeColor = System.Drawing.Color.White;
            this.lbl2Position1.Location = new System.Drawing.Point(250, 62);
            this.lbl2Position1.Name = "lbl2Position1";
            this.lbl2Position1.Size = new System.Drawing.Size(131, 29);
            this.lbl2Position1.TabIndex = 342;
            this.lbl2Position1.Text = "Near Side";
            // 
            // lbl2Position3Value
            // 
            this.lbl2Position3Value.AutoSize = true;
            this.lbl2Position3Value.BackColor = System.Drawing.Color.Red;
            this.lbl2Position3Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl2Position3Value.ForeColor = System.Drawing.Color.Red;
            this.lbl2Position3Value.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl2Position3Value.Location = new System.Drawing.Point(77, 156);
            this.lbl2Position3Value.Name = "lbl2Position3Value";
            this.lbl2Position3Value.Size = new System.Drawing.Size(20, 29);
            this.lbl2Position3Value.TabIndex = 359;
            this.lbl2Position3Value.Text = ".";
            this.lbl2Position3Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl2Position3
            // 
            this.lbl2Position3.AutoSize = true;
            this.lbl2Position3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2Position3.ForeColor = System.Drawing.Color.White;
            this.lbl2Position3.Location = new System.Drawing.Point(7, 154);
            this.lbl2Position3.Name = "lbl2Position3";
            this.lbl2Position3.Size = new System.Drawing.Size(87, 29);
            this.lbl2Position3.TabIndex = 356;
            this.lbl2Position3.Text = "Algae:";
            // 
            // lbl2Position2Value
            // 
            this.lbl2Position2Value.AutoSize = true;
            this.lbl2Position2Value.BackColor = System.Drawing.Color.Red;
            this.lbl2Position2Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl2Position2Value.ForeColor = System.Drawing.Color.Red;
            this.lbl2Position2Value.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl2Position2Value.Location = new System.Drawing.Point(77, 115);
            this.lbl2Position2Value.Name = "lbl2Position2Value";
            this.lbl2Position2Value.Size = new System.Drawing.Size(20, 29);
            this.lbl2Position2Value.TabIndex = 354;
            this.lbl2Position2Value.Text = ".";
            this.lbl2Position2Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl2Position2
            // 
            this.lbl2Position2.AutoSize = true;
            this.lbl2Position2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2Position2.ForeColor = System.Drawing.Color.White;
            this.lbl2Position2.Location = new System.Drawing.Point(7, 116);
            this.lbl2Position2.Name = "lbl2Position2";
            this.lbl2Position2.Size = new System.Drawing.Size(83, 29);
            this.lbl2Position2.TabIndex = 352;
            this.lbl2Position2.Text = "Coral:";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Red;
            this.panel6.Controls.Add(this.label64);
            this.panel6.Location = new System.Drawing.Point(0, 94);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(494, 11);
            this.panel6.TabIndex = 347;
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label64.ForeColor = System.Drawing.Color.Red;
            this.label64.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label64.Location = new System.Drawing.Point(418, 214);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(46, 31);
            this.label64.TabIndex = 277;
            this.label64.Text = "00";
            this.label64.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Red;
            this.panel7.Controls.Add(this.label65);
            this.panel7.Location = new System.Drawing.Point(0, 46);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(484, 11);
            this.panel7.TabIndex = 348;
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label65.ForeColor = System.Drawing.Color.Red;
            this.label65.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label65.Location = new System.Drawing.Point(418, 214);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(46, 31);
            this.label65.TabIndex = 277;
            this.label65.Text = "00";
            this.label65.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // red2
            // 
            this.red2.BackColor = System.Drawing.Color.Black;
            this.red2.Controls.Add(this.lbl1Position0Value);
            this.red2.Controls.Add(this.lbl1Position0);
            this.red2.Controls.Add(this.lbl1Position12Value);
            this.red2.Controls.Add(this.lbl1Position12);
            this.red2.Controls.Add(this.lbl1Position11Value);
            this.red2.Controls.Add(this.lbl1Position11);
            this.red2.Controls.Add(this.lbl1Position8Value);
            this.red2.Controls.Add(this.lbl1Position8);
            this.red2.Controls.Add(this.lbl1Position7Value);
            this.red2.Controls.Add(this.lbl1Position7);
            this.red2.Controls.Add(this.lbl1Position5Value);
            this.red2.Controls.Add(this.lbl1Position5);
            this.red2.Controls.Add(this.lbl1Position4Value);
            this.red2.Controls.Add(this.lbl1Position4);
            this.red2.Controls.Add(this.lbl1Position3Des);
            this.red2.Controls.Add(this.lbl1Position3Source);
            this.red2.Controls.Add(this.lbl1Position2Des);
            this.red2.Controls.Add(this.lbl1Position2Source);
            this.red2.Controls.Add(this.lbl1Position1);
            this.red2.Controls.Add(this.lbl1Position3Value);
            this.red2.Controls.Add(this.lbl1Position3);
            this.red2.Controls.Add(this.lbl1Position2Value);
            this.red2.Controls.Add(this.lbl1Position2);
            this.red2.Controls.Add(this.panel3);
            this.red2.Controls.Add(this.panel4);
            this.red2.Location = new System.Drawing.Point(500, 3);
            this.red2.Name = "red2";
            this.red2.Size = new System.Drawing.Size(484, 394);
            this.red2.TabIndex = 387;
            // 
            // lbl1Position0Value
            // 
            this.lbl1Position0Value.AutoSize = true;
            this.lbl1Position0Value.BackColor = System.Drawing.Color.Red;
            this.lbl1Position0Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl1Position0Value.ForeColor = System.Drawing.Color.Red;
            this.lbl1Position0Value.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl1Position0Value.Location = new System.Drawing.Point(77, 61);
            this.lbl1Position0Value.Name = "lbl1Position0Value";
            this.lbl1Position0Value.Size = new System.Drawing.Size(20, 29);
            this.lbl1Position0Value.TabIndex = 355;
            this.lbl1Position0Value.Text = ".";
            this.lbl1Position0Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl1Position0
            // 
            this.lbl1Position0.AutoSize = true;
            this.lbl1Position0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1Position0.ForeColor = System.Drawing.Color.White;
            this.lbl1Position0.Location = new System.Drawing.Point(7, 61);
            this.lbl1Position0.Name = "lbl1Position0";
            this.lbl1Position0.Size = new System.Drawing.Size(83, 29);
            this.lbl1Position0.TabIndex = 341;
            this.lbl1Position0.Text = "Leave";
            // 
            // lbl1Position12Value
            // 
            this.lbl1Position12Value.AutoSize = true;
            this.lbl1Position12Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1Position12Value.ForeColor = System.Drawing.Color.White;
            this.lbl1Position12Value.Location = new System.Drawing.Point(57, 279);
            this.lbl1Position12Value.Name = "lbl1Position12Value";
            this.lbl1Position12Value.Size = new System.Drawing.Size(27, 29);
            this.lbl1Position12Value.TabIndex = 386;
            this.lbl1Position12Value.Text = "9";
            // 
            // lbl1Position12
            // 
            this.lbl1Position12.AutoSize = true;
            this.lbl1Position12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1Position12.ForeColor = System.Drawing.Color.White;
            this.lbl1Position12.Location = new System.Drawing.Point(7, 278);
            this.lbl1Position12.Name = "lbl1Position12";
            this.lbl1Position12.Size = new System.Drawing.Size(74, 29);
            this.lbl1Position12.TabIndex = 385;
            this.lbl1Position12.Text = "Strat:";
            // 
            // lbl1Position11Value
            // 
            this.lbl1Position11Value.AutoSize = true;
            this.lbl1Position11Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1Position11Value.ForeColor = System.Drawing.Color.White;
            this.lbl1Position11Value.Location = new System.Drawing.Point(111, 251);
            this.lbl1Position11Value.Name = "lbl1Position11Value";
            this.lbl1Position11Value.Size = new System.Drawing.Size(27, 29);
            this.lbl1Position11Value.TabIndex = 384;
            this.lbl1Position11Value.Text = "9";
            // 
            // lbl1Position11
            // 
            this.lbl1Position11.AutoSize = true;
            this.lbl1Position11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1Position11.ForeColor = System.Drawing.Color.White;
            this.lbl1Position11.Location = new System.Drawing.Point(7, 251);
            this.lbl1Position11.Name = "lbl1Position11";
            this.lbl1Position11.Size = new System.Drawing.Size(133, 29);
            this.lbl1Position11.TabIndex = 383;
            this.lbl1Position11.Text = "End State:";
            // 
            // lbl1Position8Value
            // 
            this.lbl1Position8Value.AutoSize = true;
            this.lbl1Position8Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1Position8Value.ForeColor = System.Drawing.Color.White;
            this.lbl1Position8Value.Location = new System.Drawing.Point(444, 192);
            this.lbl1Position8Value.Name = "lbl1Position8Value";
            this.lbl1Position8Value.Size = new System.Drawing.Size(27, 29);
            this.lbl1Position8Value.TabIndex = 372;
            this.lbl1Position8Value.Text = "9";
            // 
            // lbl1Position8
            // 
            this.lbl1Position8.AutoSize = true;
            this.lbl1Position8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1Position8.ForeColor = System.Drawing.Color.White;
            this.lbl1Position8.Location = new System.Drawing.Point(380, 191);
            this.lbl1Position8.Name = "lbl1Position8";
            this.lbl1Position8.Size = new System.Drawing.Size(85, 29);
            this.lbl1Position8.TabIndex = 371;
            this.lbl1Position8.Text = "Avoid:";
            // 
            // lbl1Position7Value
            // 
            this.lbl1Position7Value.AutoSize = true;
            this.lbl1Position7Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1Position7Value.ForeColor = System.Drawing.Color.White;
            this.lbl1Position7Value.Location = new System.Drawing.Point(336, 247);
            this.lbl1Position7Value.Name = "lbl1Position7Value";
            this.lbl1Position7Value.Size = new System.Drawing.Size(27, 29);
            this.lbl1Position7Value.TabIndex = 380;
            this.lbl1Position7Value.Text = "9";
            // 
            // lbl1Position7
            // 
            this.lbl1Position7.AutoSize = true;
            this.lbl1Position7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1Position7.ForeColor = System.Drawing.Color.White;
            this.lbl1Position7.Location = new System.Drawing.Point(301, 246);
            this.lbl1Position7.Name = "lbl1Position7";
            this.lbl1Position7.Size = new System.Drawing.Size(51, 29);
            this.lbl1Position7.TabIndex = 379;
            this.lbl1Position7.Text = "Eff:";
            // 
            // lbl1Position5Value
            // 
            this.lbl1Position5Value.AutoSize = true;
            this.lbl1Position5Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1Position5Value.ForeColor = System.Drawing.Color.White;
            this.lbl1Position5Value.Location = new System.Drawing.Point(242, 191);
            this.lbl1Position5Value.Name = "lbl1Position5Value";
            this.lbl1Position5Value.Size = new System.Drawing.Size(27, 29);
            this.lbl1Position5Value.TabIndex = 370;
            this.lbl1Position5Value.Text = "9";
            this.lbl1Position5Value.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl1Position5
            // 
            this.lbl1Position5.AutoSize = true;
            this.lbl1Position5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1Position5.ForeColor = System.Drawing.Color.White;
            this.lbl1Position5.Location = new System.Drawing.Point(189, 190);
            this.lbl1Position5.Name = "lbl1Position5";
            this.lbl1Position5.Size = new System.Drawing.Size(60, 29);
            this.lbl1Position5.TabIndex = 369;
            this.lbl1Position5.Text = "Def:";
            this.lbl1Position5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl1Position4Value
            // 
            this.lbl1Position4Value.AutoSize = true;
            this.lbl1Position4Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1Position4Value.ForeColor = System.Drawing.Color.White;
            this.lbl1Position4Value.Location = new System.Drawing.Point(345, 142);
            this.lbl1Position4Value.Name = "lbl1Position4Value";
            this.lbl1Position4Value.Size = new System.Drawing.Size(27, 29);
            this.lbl1Position4Value.TabIndex = 366;
            this.lbl1Position4Value.Text = "9";
            // 
            // lbl1Position4
            // 
            this.lbl1Position4.AutoSize = true;
            this.lbl1Position4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1Position4.ForeColor = System.Drawing.Color.White;
            this.lbl1Position4.Location = new System.Drawing.Point(263, 141);
            this.lbl1Position4.Name = "lbl1Position4";
            this.lbl1Position4.Size = new System.Drawing.Size(108, 29);
            this.lbl1Position4.TabIndex = 365;
            this.lbl1Position4.Text = "Attempt:";
            // 
            // lbl1Position3Des
            // 
            this.lbl1Position3Des.AutoSize = true;
            this.lbl1Position3Des.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1Position3Des.ForeColor = System.Drawing.Color.White;
            this.lbl1Position3Des.Location = new System.Drawing.Point(181, 156);
            this.lbl1Position3Des.Name = "lbl1Position3Des";
            this.lbl1Position3Des.Size = new System.Drawing.Size(75, 29);
            this.lbl1Position3Des.TabIndex = 364;
            this.lbl1Position3Des.Text = "Floor";
            // 
            // lbl1Position3Source
            // 
            this.lbl1Position3Source.AutoSize = true;
            this.lbl1Position3Source.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1Position3Source.ForeColor = System.Drawing.Color.White;
            this.lbl1Position3Source.Location = new System.Drawing.Point(108, 156);
            this.lbl1Position3Source.Name = "lbl1Position3Source";
            this.lbl1Position3Source.Size = new System.Drawing.Size(75, 29);
            this.lbl1Position3Source.TabIndex = 378;
            this.lbl1Position3Source.Text = "Floor";
            // 
            // lbl1Position2Des
            // 
            this.lbl1Position2Des.AutoSize = true;
            this.lbl1Position2Des.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1Position2Des.ForeColor = System.Drawing.Color.White;
            this.lbl1Position2Des.Location = new System.Drawing.Point(181, 118);
            this.lbl1Position2Des.Name = "lbl1Position2Des";
            this.lbl1Position2Des.Size = new System.Drawing.Size(75, 29);
            this.lbl1Position2Des.TabIndex = 363;
            this.lbl1Position2Des.Text = "Floor";
            // 
            // lbl1Position2Source
            // 
            this.lbl1Position2Source.AutoSize = true;
            this.lbl1Position2Source.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1Position2Source.ForeColor = System.Drawing.Color.White;
            this.lbl1Position2Source.Location = new System.Drawing.Point(108, 118);
            this.lbl1Position2Source.Name = "lbl1Position2Source";
            this.lbl1Position2Source.Size = new System.Drawing.Size(94, 29);
            this.lbl1Position2Source.TabIndex = 377;
            this.lbl1Position2Source.Text = "Station";
            // 
            // lbl1Position1
            // 
            this.lbl1Position1.AutoSize = true;
            this.lbl1Position1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1Position1.ForeColor = System.Drawing.Color.White;
            this.lbl1Position1.Location = new System.Drawing.Point(250, 62);
            this.lbl1Position1.Name = "lbl1Position1";
            this.lbl1Position1.Size = new System.Drawing.Size(131, 29);
            this.lbl1Position1.TabIndex = 342;
            this.lbl1Position1.Text = "Near Side";
            // 
            // lbl1Position3Value
            // 
            this.lbl1Position3Value.AutoSize = true;
            this.lbl1Position3Value.BackColor = System.Drawing.Color.Red;
            this.lbl1Position3Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl1Position3Value.ForeColor = System.Drawing.Color.Red;
            this.lbl1Position3Value.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl1Position3Value.Location = new System.Drawing.Point(77, 156);
            this.lbl1Position3Value.Name = "lbl1Position3Value";
            this.lbl1Position3Value.Size = new System.Drawing.Size(20, 29);
            this.lbl1Position3Value.TabIndex = 359;
            this.lbl1Position3Value.Text = ".";
            this.lbl1Position3Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl1Position3
            // 
            this.lbl1Position3.AutoSize = true;
            this.lbl1Position3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1Position3.ForeColor = System.Drawing.Color.White;
            this.lbl1Position3.Location = new System.Drawing.Point(7, 154);
            this.lbl1Position3.Name = "lbl1Position3";
            this.lbl1Position3.Size = new System.Drawing.Size(87, 29);
            this.lbl1Position3.TabIndex = 356;
            this.lbl1Position3.Text = "Algae:";
            // 
            // lbl1Position2Value
            // 
            this.lbl1Position2Value.AutoSize = true;
            this.lbl1Position2Value.BackColor = System.Drawing.Color.Red;
            this.lbl1Position2Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl1Position2Value.ForeColor = System.Drawing.Color.Red;
            this.lbl1Position2Value.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl1Position2Value.Location = new System.Drawing.Point(77, 115);
            this.lbl1Position2Value.Name = "lbl1Position2Value";
            this.lbl1Position2Value.Size = new System.Drawing.Size(20, 29);
            this.lbl1Position2Value.TabIndex = 354;
            this.lbl1Position2Value.Text = ".";
            this.lbl1Position2Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl1Position2
            // 
            this.lbl1Position2.AutoSize = true;
            this.lbl1Position2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1Position2.ForeColor = System.Drawing.Color.White;
            this.lbl1Position2.Location = new System.Drawing.Point(7, 116);
            this.lbl1Position2.Name = "lbl1Position2";
            this.lbl1Position2.Size = new System.Drawing.Size(83, 29);
            this.lbl1Position2.TabIndex = 352;
            this.lbl1Position2.Text = "Coral:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Red;
            this.panel3.Controls.Add(this.label32);
            this.panel3.Location = new System.Drawing.Point(0, 94);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(494, 11);
            this.panel3.TabIndex = 347;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.ForeColor = System.Drawing.Color.Red;
            this.label32.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label32.Location = new System.Drawing.Point(418, 214);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(46, 31);
            this.label32.TabIndex = 277;
            this.label32.Text = "00";
            this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Red;
            this.panel4.Controls.Add(this.label33);
            this.panel4.Location = new System.Drawing.Point(0, 46);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(484, 11);
            this.panel4.TabIndex = 348;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = System.Drawing.Color.Red;
            this.label33.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label33.Location = new System.Drawing.Point(418, 214);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(46, 31);
            this.label33.TabIndex = 277;
            this.label33.Text = "00";
            this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // red1
            // 
            this.red1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.red1.Controls.Add(this.lbl0Position0Value);
            this.red1.Controls.Add(this.lbl0Position0);
            this.red1.Controls.Add(this.lbl0Position12Value);
            this.red1.Controls.Add(this.lbl0Position12);
            this.red1.Controls.Add(this.lbl0Position11Value);
            this.red1.Controls.Add(this.lbl0Position11);
            this.red1.Controls.Add(this.lbl0Position8Value);
            this.red1.Controls.Add(this.lbl0Position8);
            this.red1.Controls.Add(this.lbl0Position7Value);
            this.red1.Controls.Add(this.lbl0Position7);
            this.red1.Controls.Add(this.lbl0Position5Value);
            this.red1.Controls.Add(this.lbl0Position5);
            this.red1.Controls.Add(this.lbl0Position4Value);
            this.red1.Controls.Add(this.lbl0Position4);
            this.red1.Controls.Add(this.lbl0Position3Des);
            this.red1.Controls.Add(this.lbl0Position3Source);
            this.red1.Controls.Add(this.lbl0Position2Des);
            this.red1.Controls.Add(this.lbl0Position2Source);
            this.red1.Controls.Add(this.lbl0Position1);
            this.red1.Controls.Add(this.lbl0Position3Value);
            this.red1.Controls.Add(this.lbl0Position3);
            this.red1.Controls.Add(this.lbl0Position2Value);
            this.red1.Controls.Add(this.lbl0Position2);
            this.red1.Controls.Add(this.panel8);
            this.red1.Controls.Add(this.panel2);
            this.red1.Location = new System.Drawing.Point(6, 3);
            this.red1.Name = "red1";
            this.red1.Size = new System.Drawing.Size(484, 394);
            this.red1.TabIndex = 0;
            // 
            // lbl0Position0Value
            // 
            this.lbl0Position0Value.AutoSize = true;
            this.lbl0Position0Value.BackColor = System.Drawing.Color.Red;
            this.lbl0Position0Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl0Position0Value.ForeColor = System.Drawing.Color.Red;
            this.lbl0Position0Value.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl0Position0Value.Location = new System.Drawing.Point(77, 61);
            this.lbl0Position0Value.Name = "lbl0Position0Value";
            this.lbl0Position0Value.Size = new System.Drawing.Size(20, 29);
            this.lbl0Position0Value.TabIndex = 355;
            this.lbl0Position0Value.Text = ".";
            this.lbl0Position0Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl0Position12Value
            // 
            this.lbl0Position12Value.AutoSize = true;
            this.lbl0Position12Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl0Position12Value.ForeColor = System.Drawing.Color.White;
            this.lbl0Position12Value.Location = new System.Drawing.Point(57, 279);
            this.lbl0Position12Value.Name = "lbl0Position12Value";
            this.lbl0Position12Value.Size = new System.Drawing.Size(27, 29);
            this.lbl0Position12Value.TabIndex = 386;
            this.lbl0Position12Value.Text = "9";
            // 
            // lbl0Position12
            // 
            this.lbl0Position12.AutoSize = true;
            this.lbl0Position12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl0Position12.ForeColor = System.Drawing.Color.White;
            this.lbl0Position12.Location = new System.Drawing.Point(7, 278);
            this.lbl0Position12.Name = "lbl0Position12";
            this.lbl0Position12.Size = new System.Drawing.Size(74, 29);
            this.lbl0Position12.TabIndex = 385;
            this.lbl0Position12.Text = "Strat:";
            // 
            // lbl0Position11Value
            // 
            this.lbl0Position11Value.AutoSize = true;
            this.lbl0Position11Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl0Position11Value.ForeColor = System.Drawing.Color.White;
            this.lbl0Position11Value.Location = new System.Drawing.Point(111, 251);
            this.lbl0Position11Value.Name = "lbl0Position11Value";
            this.lbl0Position11Value.Size = new System.Drawing.Size(27, 29);
            this.lbl0Position11Value.TabIndex = 384;
            this.lbl0Position11Value.Text = "9";
            // 
            // lbl0Position11
            // 
            this.lbl0Position11.AutoSize = true;
            this.lbl0Position11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl0Position11.ForeColor = System.Drawing.Color.White;
            this.lbl0Position11.Location = new System.Drawing.Point(7, 251);
            this.lbl0Position11.Name = "lbl0Position11";
            this.lbl0Position11.Size = new System.Drawing.Size(133, 29);
            this.lbl0Position11.TabIndex = 383;
            this.lbl0Position11.Text = "End State:";
            // 
            // lbl0Position8Value
            // 
            this.lbl0Position8Value.AutoSize = true;
            this.lbl0Position8Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl0Position8Value.ForeColor = System.Drawing.Color.White;
            this.lbl0Position8Value.Location = new System.Drawing.Point(444, 192);
            this.lbl0Position8Value.Name = "lbl0Position8Value";
            this.lbl0Position8Value.Size = new System.Drawing.Size(27, 29);
            this.lbl0Position8Value.TabIndex = 372;
            this.lbl0Position8Value.Text = "9";
            // 
            // lbl0Position8
            // 
            this.lbl0Position8.AutoSize = true;
            this.lbl0Position8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl0Position8.ForeColor = System.Drawing.Color.White;
            this.lbl0Position8.Location = new System.Drawing.Point(380, 191);
            this.lbl0Position8.Name = "lbl0Position8";
            this.lbl0Position8.Size = new System.Drawing.Size(85, 29);
            this.lbl0Position8.TabIndex = 371;
            this.lbl0Position8.Text = "Avoid:";
            // 
            // lbl0Position7Value
            // 
            this.lbl0Position7Value.AutoSize = true;
            this.lbl0Position7Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl0Position7Value.ForeColor = System.Drawing.Color.White;
            this.lbl0Position7Value.Location = new System.Drawing.Point(336, 247);
            this.lbl0Position7Value.Name = "lbl0Position7Value";
            this.lbl0Position7Value.Size = new System.Drawing.Size(27, 29);
            this.lbl0Position7Value.TabIndex = 380;
            this.lbl0Position7Value.Text = "9";
            // 
            // lbl0Position7
            // 
            this.lbl0Position7.AutoSize = true;
            this.lbl0Position7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl0Position7.ForeColor = System.Drawing.Color.White;
            this.lbl0Position7.Location = new System.Drawing.Point(301, 246);
            this.lbl0Position7.Name = "lbl0Position7";
            this.lbl0Position7.Size = new System.Drawing.Size(51, 29);
            this.lbl0Position7.TabIndex = 379;
            this.lbl0Position7.Text = "Eff:";
            // 
            // lbl0Position5Value
            // 
            this.lbl0Position5Value.AutoSize = true;
            this.lbl0Position5Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl0Position5Value.ForeColor = System.Drawing.Color.White;
            this.lbl0Position5Value.Location = new System.Drawing.Point(242, 191);
            this.lbl0Position5Value.Name = "lbl0Position5Value";
            this.lbl0Position5Value.Size = new System.Drawing.Size(27, 29);
            this.lbl0Position5Value.TabIndex = 370;
            this.lbl0Position5Value.Text = "9";
            this.lbl0Position5Value.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl0Position5
            // 
            this.lbl0Position5.AutoSize = true;
            this.lbl0Position5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl0Position5.ForeColor = System.Drawing.Color.White;
            this.lbl0Position5.Location = new System.Drawing.Point(189, 190);
            this.lbl0Position5.Name = "lbl0Position5";
            this.lbl0Position5.Size = new System.Drawing.Size(60, 29);
            this.lbl0Position5.TabIndex = 369;
            this.lbl0Position5.Text = "Def:";
            this.lbl0Position5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl0Position4Value
            // 
            this.lbl0Position4Value.AutoSize = true;
            this.lbl0Position4Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl0Position4Value.ForeColor = System.Drawing.Color.White;
            this.lbl0Position4Value.Location = new System.Drawing.Point(345, 142);
            this.lbl0Position4Value.Name = "lbl0Position4Value";
            this.lbl0Position4Value.Size = new System.Drawing.Size(27, 29);
            this.lbl0Position4Value.TabIndex = 366;
            this.lbl0Position4Value.Text = "9";
            // 
            // lbl0Position4
            // 
            this.lbl0Position4.AutoSize = true;
            this.lbl0Position4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl0Position4.ForeColor = System.Drawing.Color.White;
            this.lbl0Position4.Location = new System.Drawing.Point(263, 141);
            this.lbl0Position4.Name = "lbl0Position4";
            this.lbl0Position4.Size = new System.Drawing.Size(108, 29);
            this.lbl0Position4.TabIndex = 365;
            this.lbl0Position4.Text = "Attempt:";
            // 
            // lbl0Position3Des
            // 
            this.lbl0Position3Des.AutoSize = true;
            this.lbl0Position3Des.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl0Position3Des.ForeColor = System.Drawing.Color.White;
            this.lbl0Position3Des.Location = new System.Drawing.Point(181, 156);
            this.lbl0Position3Des.Name = "lbl0Position3Des";
            this.lbl0Position3Des.Size = new System.Drawing.Size(75, 29);
            this.lbl0Position3Des.TabIndex = 364;
            this.lbl0Position3Des.Text = "Floor";
            // 
            // lbl0Position3Source
            // 
            this.lbl0Position3Source.AutoSize = true;
            this.lbl0Position3Source.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl0Position3Source.ForeColor = System.Drawing.Color.White;
            this.lbl0Position3Source.Location = new System.Drawing.Point(108, 156);
            this.lbl0Position3Source.Name = "lbl0Position3Source";
            this.lbl0Position3Source.Size = new System.Drawing.Size(75, 29);
            this.lbl0Position3Source.TabIndex = 378;
            this.lbl0Position3Source.Text = "Floor";
            // 
            // lbl0Position2Des
            // 
            this.lbl0Position2Des.AutoSize = true;
            this.lbl0Position2Des.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl0Position2Des.ForeColor = System.Drawing.Color.White;
            this.lbl0Position2Des.Location = new System.Drawing.Point(181, 118);
            this.lbl0Position2Des.Name = "lbl0Position2Des";
            this.lbl0Position2Des.Size = new System.Drawing.Size(75, 29);
            this.lbl0Position2Des.TabIndex = 363;
            this.lbl0Position2Des.Text = "Floor";
            // 
            // lbl0Position2Source
            // 
            this.lbl0Position2Source.AutoSize = true;
            this.lbl0Position2Source.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl0Position2Source.ForeColor = System.Drawing.Color.White;
            this.lbl0Position2Source.Location = new System.Drawing.Point(108, 118);
            this.lbl0Position2Source.Name = "lbl0Position2Source";
            this.lbl0Position2Source.Size = new System.Drawing.Size(94, 29);
            this.lbl0Position2Source.TabIndex = 377;
            this.lbl0Position2Source.Text = "Station";
            // 
            // lbl0Position3Value
            // 
            this.lbl0Position3Value.AutoSize = true;
            this.lbl0Position3Value.BackColor = System.Drawing.Color.Red;
            this.lbl0Position3Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl0Position3Value.ForeColor = System.Drawing.Color.Red;
            this.lbl0Position3Value.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl0Position3Value.Location = new System.Drawing.Point(77, 156);
            this.lbl0Position3Value.Name = "lbl0Position3Value";
            this.lbl0Position3Value.Size = new System.Drawing.Size(20, 29);
            this.lbl0Position3Value.TabIndex = 359;
            this.lbl0Position3Value.Text = ".";
            this.lbl0Position3Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl0Position3
            // 
            this.lbl0Position3.AutoSize = true;
            this.lbl0Position3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl0Position3.ForeColor = System.Drawing.Color.White;
            this.lbl0Position3.Location = new System.Drawing.Point(7, 154);
            this.lbl0Position3.Name = "lbl0Position3";
            this.lbl0Position3.Size = new System.Drawing.Size(87, 29);
            this.lbl0Position3.TabIndex = 356;
            this.lbl0Position3.Text = "Algae:";
            // 
            // lbl0Position2Value
            // 
            this.lbl0Position2Value.AutoSize = true;
            this.lbl0Position2Value.BackColor = System.Drawing.Color.Red;
            this.lbl0Position2Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl0Position2Value.ForeColor = System.Drawing.Color.Red;
            this.lbl0Position2Value.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl0Position2Value.Location = new System.Drawing.Point(77, 115);
            this.lbl0Position2Value.Name = "lbl0Position2Value";
            this.lbl0Position2Value.Size = new System.Drawing.Size(20, 29);
            this.lbl0Position2Value.TabIndex = 354;
            this.lbl0Position2Value.Text = ".";
            this.lbl0Position2Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl0Position2
            // 
            this.lbl0Position2.AutoSize = true;
            this.lbl0Position2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl0Position2.ForeColor = System.Drawing.Color.White;
            this.lbl0Position2.Location = new System.Drawing.Point(7, 116);
            this.lbl0Position2.Name = "lbl0Position2";
            this.lbl0Position2.Size = new System.Drawing.Size(83, 29);
            this.lbl0Position2.TabIndex = 352;
            this.lbl0Position2.Text = "Coral:";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Red;
            this.panel8.Controls.Add(this.label28);
            this.panel8.Location = new System.Drawing.Point(0, 94);
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
            this.label28.Size = new System.Drawing.Size(46, 31);
            this.label28.TabIndex = 277;
            this.label28.Text = "00";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(484, 11);
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
            this.label1.Size = new System.Drawing.Size(46, 31);
            this.label1.TabIndex = 277;
            this.label1.Text = "00";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bluePanel
            // 
            this.bluePanel.BackColor = System.Drawing.Color.Blue;
            this.bluePanel.Controls.Add(this.blue3);
            this.bluePanel.Controls.Add(this.blue2);
            this.bluePanel.Controls.Add(this.blue1);
            this.bluePanel.Location = new System.Drawing.Point(19, 462);
            this.bluePanel.Name = "bluePanel";
            this.bluePanel.Size = new System.Drawing.Size(1485, 399);
            this.bluePanel.TabIndex = 348;
            // 
            // blue3
            // 
            this.blue3.BackColor = System.Drawing.Color.Black;
            this.blue3.Controls.Add(this.lbl5Position0Value);
            this.blue3.Controls.Add(this.lbl5Position0);
            this.blue3.Controls.Add(this.lbl5Position12Value);
            this.blue3.Controls.Add(this.lbl5Position12);
            this.blue3.Controls.Add(this.lbl5Position11Value);
            this.blue3.Controls.Add(this.lbl5Position11);
            this.blue3.Controls.Add(this.lbl5Position8Value);
            this.blue3.Controls.Add(this.lbl5Position8);
            this.blue3.Controls.Add(this.lbl5Position7Value);
            this.blue3.Controls.Add(this.lbl5Position7);
            this.blue3.Controls.Add(this.lbl5Position5Value);
            this.blue3.Controls.Add(this.lbl5Position5);
            this.blue3.Controls.Add(this.lbl5Position4Value);
            this.blue3.Controls.Add(this.lbl5Position4);
            this.blue3.Controls.Add(this.lbl5Position3Des);
            this.blue3.Controls.Add(this.lbl5Position3Source);
            this.blue3.Controls.Add(this.lbl5Position2Des);
            this.blue3.Controls.Add(this.lbl5Position2Source);
            this.blue3.Controls.Add(this.lbl5Position1);
            this.blue3.Controls.Add(this.lbl5Position3Value);
            this.blue3.Controls.Add(this.lbl5Position3);
            this.blue3.Controls.Add(this.lbl5Position2Value);
            this.blue3.Controls.Add(this.lbl5Position2);
            this.blue3.Controls.Add(this.panel10);
            this.blue3.Controls.Add(this.panel11);
            this.blue3.Location = new System.Drawing.Point(994, 2);
            this.blue3.Name = "blue3";
            this.blue3.Size = new System.Drawing.Size(484, 394);
            this.blue3.TabIndex = 391;
            // 
            // lbl5Position0Value
            // 
            this.lbl5Position0Value.AutoSize = true;
            this.lbl5Position0Value.BackColor = System.Drawing.Color.Red;
            this.lbl5Position0Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl5Position0Value.ForeColor = System.Drawing.Color.Red;
            this.lbl5Position0Value.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl5Position0Value.Location = new System.Drawing.Point(77, 61);
            this.lbl5Position0Value.Name = "lbl5Position0Value";
            this.lbl5Position0Value.Size = new System.Drawing.Size(20, 29);
            this.lbl5Position0Value.TabIndex = 355;
            this.lbl5Position0Value.Text = ".";
            this.lbl5Position0Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl5Position0
            // 
            this.lbl5Position0.AutoSize = true;
            this.lbl5Position0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5Position0.ForeColor = System.Drawing.Color.White;
            this.lbl5Position0.Location = new System.Drawing.Point(7, 61);
            this.lbl5Position0.Name = "lbl5Position0";
            this.lbl5Position0.Size = new System.Drawing.Size(83, 29);
            this.lbl5Position0.TabIndex = 341;
            this.lbl5Position0.Text = "Leave";
            // 
            // lbl5Position12Value
            // 
            this.lbl5Position12Value.AutoSize = true;
            this.lbl5Position12Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5Position12Value.ForeColor = System.Drawing.Color.White;
            this.lbl5Position12Value.Location = new System.Drawing.Point(57, 279);
            this.lbl5Position12Value.Name = "lbl5Position12Value";
            this.lbl5Position12Value.Size = new System.Drawing.Size(27, 29);
            this.lbl5Position12Value.TabIndex = 386;
            this.lbl5Position12Value.Text = "9";
            // 
            // lbl5Position12
            // 
            this.lbl5Position12.AutoSize = true;
            this.lbl5Position12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5Position12.ForeColor = System.Drawing.Color.White;
            this.lbl5Position12.Location = new System.Drawing.Point(7, 278);
            this.lbl5Position12.Name = "lbl5Position12";
            this.lbl5Position12.Size = new System.Drawing.Size(74, 29);
            this.lbl5Position12.TabIndex = 385;
            this.lbl5Position12.Text = "Strat:";
            // 
            // lbl5Position11Value
            // 
            this.lbl5Position11Value.AutoSize = true;
            this.lbl5Position11Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5Position11Value.ForeColor = System.Drawing.Color.White;
            this.lbl5Position11Value.Location = new System.Drawing.Point(111, 251);
            this.lbl5Position11Value.Name = "lbl5Position11Value";
            this.lbl5Position11Value.Size = new System.Drawing.Size(27, 29);
            this.lbl5Position11Value.TabIndex = 384;
            this.lbl5Position11Value.Text = "9";
            // 
            // lbl5Position11
            // 
            this.lbl5Position11.AutoSize = true;
            this.lbl5Position11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5Position11.ForeColor = System.Drawing.Color.White;
            this.lbl5Position11.Location = new System.Drawing.Point(7, 251);
            this.lbl5Position11.Name = "lbl5Position11";
            this.lbl5Position11.Size = new System.Drawing.Size(133, 29);
            this.lbl5Position11.TabIndex = 383;
            this.lbl5Position11.Text = "End State:";
            // 
            // lbl5Position8Value
            // 
            this.lbl5Position8Value.AutoSize = true;
            this.lbl5Position8Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5Position8Value.ForeColor = System.Drawing.Color.White;
            this.lbl5Position8Value.Location = new System.Drawing.Point(444, 192);
            this.lbl5Position8Value.Name = "lbl5Position8Value";
            this.lbl5Position8Value.Size = new System.Drawing.Size(27, 29);
            this.lbl5Position8Value.TabIndex = 372;
            this.lbl5Position8Value.Text = "9";
            // 
            // lbl5Position8
            // 
            this.lbl5Position8.AutoSize = true;
            this.lbl5Position8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5Position8.ForeColor = System.Drawing.Color.White;
            this.lbl5Position8.Location = new System.Drawing.Point(380, 191);
            this.lbl5Position8.Name = "lbl5Position8";
            this.lbl5Position8.Size = new System.Drawing.Size(85, 29);
            this.lbl5Position8.TabIndex = 371;
            this.lbl5Position8.Text = "Avoid:";
            // 
            // lbl5Position7Value
            // 
            this.lbl5Position7Value.AutoSize = true;
            this.lbl5Position7Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5Position7Value.ForeColor = System.Drawing.Color.White;
            this.lbl5Position7Value.Location = new System.Drawing.Point(336, 247);
            this.lbl5Position7Value.Name = "lbl5Position7Value";
            this.lbl5Position7Value.Size = new System.Drawing.Size(27, 29);
            this.lbl5Position7Value.TabIndex = 380;
            this.lbl5Position7Value.Text = "9";
            // 
            // lbl5Position7
            // 
            this.lbl5Position7.AutoSize = true;
            this.lbl5Position7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5Position7.ForeColor = System.Drawing.Color.White;
            this.lbl5Position7.Location = new System.Drawing.Point(301, 246);
            this.lbl5Position7.Name = "lbl5Position7";
            this.lbl5Position7.Size = new System.Drawing.Size(51, 29);
            this.lbl5Position7.TabIndex = 379;
            this.lbl5Position7.Text = "Eff:";
            // 
            // lbl5Position5Value
            // 
            this.lbl5Position5Value.AutoSize = true;
            this.lbl5Position5Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5Position5Value.ForeColor = System.Drawing.Color.White;
            this.lbl5Position5Value.Location = new System.Drawing.Point(242, 191);
            this.lbl5Position5Value.Name = "lbl5Position5Value";
            this.lbl5Position5Value.Size = new System.Drawing.Size(27, 29);
            this.lbl5Position5Value.TabIndex = 370;
            this.lbl5Position5Value.Text = "9";
            this.lbl5Position5Value.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl5Position5
            // 
            this.lbl5Position5.AutoSize = true;
            this.lbl5Position5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5Position5.ForeColor = System.Drawing.Color.White;
            this.lbl5Position5.Location = new System.Drawing.Point(189, 190);
            this.lbl5Position5.Name = "lbl5Position5";
            this.lbl5Position5.Size = new System.Drawing.Size(60, 29);
            this.lbl5Position5.TabIndex = 369;
            this.lbl5Position5.Text = "Def:";
            this.lbl5Position5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl5Position4Value
            // 
            this.lbl5Position4Value.AutoSize = true;
            this.lbl5Position4Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5Position4Value.ForeColor = System.Drawing.Color.White;
            this.lbl5Position4Value.Location = new System.Drawing.Point(345, 142);
            this.lbl5Position4Value.Name = "lbl5Position4Value";
            this.lbl5Position4Value.Size = new System.Drawing.Size(27, 29);
            this.lbl5Position4Value.TabIndex = 366;
            this.lbl5Position4Value.Text = "9";
            // 
            // lbl5Position4
            // 
            this.lbl5Position4.AutoSize = true;
            this.lbl5Position4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5Position4.ForeColor = System.Drawing.Color.White;
            this.lbl5Position4.Location = new System.Drawing.Point(263, 141);
            this.lbl5Position4.Name = "lbl5Position4";
            this.lbl5Position4.Size = new System.Drawing.Size(108, 29);
            this.lbl5Position4.TabIndex = 365;
            this.lbl5Position4.Text = "Attempt:";
            // 
            // lbl5Position3Des
            // 
            this.lbl5Position3Des.AutoSize = true;
            this.lbl5Position3Des.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5Position3Des.ForeColor = System.Drawing.Color.White;
            this.lbl5Position3Des.Location = new System.Drawing.Point(181, 156);
            this.lbl5Position3Des.Name = "lbl5Position3Des";
            this.lbl5Position3Des.Size = new System.Drawing.Size(75, 29);
            this.lbl5Position3Des.TabIndex = 364;
            this.lbl5Position3Des.Text = "Floor";
            // 
            // lbl5Position3Source
            // 
            this.lbl5Position3Source.AutoSize = true;
            this.lbl5Position3Source.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5Position3Source.ForeColor = System.Drawing.Color.White;
            this.lbl5Position3Source.Location = new System.Drawing.Point(108, 156);
            this.lbl5Position3Source.Name = "lbl5Position3Source";
            this.lbl5Position3Source.Size = new System.Drawing.Size(75, 29);
            this.lbl5Position3Source.TabIndex = 378;
            this.lbl5Position3Source.Text = "Floor";
            // 
            // lbl5Position2Des
            // 
            this.lbl5Position2Des.AutoSize = true;
            this.lbl5Position2Des.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5Position2Des.ForeColor = System.Drawing.Color.White;
            this.lbl5Position2Des.Location = new System.Drawing.Point(181, 118);
            this.lbl5Position2Des.Name = "lbl5Position2Des";
            this.lbl5Position2Des.Size = new System.Drawing.Size(75, 29);
            this.lbl5Position2Des.TabIndex = 363;
            this.lbl5Position2Des.Text = "Floor";
            // 
            // lbl5Position2Source
            // 
            this.lbl5Position2Source.AutoSize = true;
            this.lbl5Position2Source.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5Position2Source.ForeColor = System.Drawing.Color.White;
            this.lbl5Position2Source.Location = new System.Drawing.Point(108, 118);
            this.lbl5Position2Source.Name = "lbl5Position2Source";
            this.lbl5Position2Source.Size = new System.Drawing.Size(94, 29);
            this.lbl5Position2Source.TabIndex = 377;
            this.lbl5Position2Source.Text = "Station";
            // 
            // lbl5Position1
            // 
            this.lbl5Position1.AutoSize = true;
            this.lbl5Position1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5Position1.ForeColor = System.Drawing.Color.White;
            this.lbl5Position1.Location = new System.Drawing.Point(250, 62);
            this.lbl5Position1.Name = "lbl5Position1";
            this.lbl5Position1.Size = new System.Drawing.Size(131, 29);
            this.lbl5Position1.TabIndex = 342;
            this.lbl5Position1.Text = "Near Side";
            // 
            // lbl5Position3Value
            // 
            this.lbl5Position3Value.AutoSize = true;
            this.lbl5Position3Value.BackColor = System.Drawing.Color.Red;
            this.lbl5Position3Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl5Position3Value.ForeColor = System.Drawing.Color.Red;
            this.lbl5Position3Value.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl5Position3Value.Location = new System.Drawing.Point(77, 156);
            this.lbl5Position3Value.Name = "lbl5Position3Value";
            this.lbl5Position3Value.Size = new System.Drawing.Size(20, 29);
            this.lbl5Position3Value.TabIndex = 359;
            this.lbl5Position3Value.Text = ".";
            this.lbl5Position3Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl5Position3
            // 
            this.lbl5Position3.AutoSize = true;
            this.lbl5Position3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5Position3.ForeColor = System.Drawing.Color.White;
            this.lbl5Position3.Location = new System.Drawing.Point(7, 154);
            this.lbl5Position3.Name = "lbl5Position3";
            this.lbl5Position3.Size = new System.Drawing.Size(87, 29);
            this.lbl5Position3.TabIndex = 356;
            this.lbl5Position3.Text = "Algae:";
            // 
            // lbl5Position2Value
            // 
            this.lbl5Position2Value.AutoSize = true;
            this.lbl5Position2Value.BackColor = System.Drawing.Color.Red;
            this.lbl5Position2Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl5Position2Value.ForeColor = System.Drawing.Color.Red;
            this.lbl5Position2Value.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl5Position2Value.Location = new System.Drawing.Point(77, 115);
            this.lbl5Position2Value.Name = "lbl5Position2Value";
            this.lbl5Position2Value.Size = new System.Drawing.Size(20, 29);
            this.lbl5Position2Value.TabIndex = 354;
            this.lbl5Position2Value.Text = ".";
            this.lbl5Position2Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl5Position2
            // 
            this.lbl5Position2.AutoSize = true;
            this.lbl5Position2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5Position2.ForeColor = System.Drawing.Color.White;
            this.lbl5Position2.Location = new System.Drawing.Point(7, 116);
            this.lbl5Position2.Name = "lbl5Position2";
            this.lbl5Position2.Size = new System.Drawing.Size(83, 29);
            this.lbl5Position2.TabIndex = 352;
            this.lbl5Position2.Text = "Coral:";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Blue;
            this.panel10.Controls.Add(this.label96);
            this.panel10.Location = new System.Drawing.Point(0, 94);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(494, 11);
            this.panel10.TabIndex = 347;
            // 
            // label96
            // 
            this.label96.AutoSize = true;
            this.label96.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label96.ForeColor = System.Drawing.Color.Red;
            this.label96.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label96.Location = new System.Drawing.Point(418, 214);
            this.label96.Name = "label96";
            this.label96.Size = new System.Drawing.Size(46, 31);
            this.label96.TabIndex = 277;
            this.label96.Text = "00";
            this.label96.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.Blue;
            this.panel11.Controls.Add(this.label97);
            this.panel11.Location = new System.Drawing.Point(0, 46);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(484, 11);
            this.panel11.TabIndex = 348;
            // 
            // label97
            // 
            this.label97.AutoSize = true;
            this.label97.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label97.ForeColor = System.Drawing.Color.Red;
            this.label97.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label97.Location = new System.Drawing.Point(418, 214);
            this.label97.Name = "label97";
            this.label97.Size = new System.Drawing.Size(46, 31);
            this.label97.TabIndex = 277;
            this.label97.Text = "00";
            this.label97.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // blue2
            // 
            this.blue2.BackColor = System.Drawing.Color.Black;
            this.blue2.Controls.Add(this.lbl4Position0Value);
            this.blue2.Controls.Add(this.lbl4Position0);
            this.blue2.Controls.Add(this.lbl4Position12Value);
            this.blue2.Controls.Add(this.lbl4Position12);
            this.blue2.Controls.Add(this.lbl4Position11Value);
            this.blue2.Controls.Add(this.lbl4Position11);
            this.blue2.Controls.Add(this.lbl4Position8Value);
            this.blue2.Controls.Add(this.lbl4Position8);
            this.blue2.Controls.Add(this.lbl4Position7Value);
            this.blue2.Controls.Add(this.lbl4Position7);
            this.blue2.Controls.Add(this.lbl4Position5Value);
            this.blue2.Controls.Add(this.lbl4Position5);
            this.blue2.Controls.Add(this.lbl4Position4Value);
            this.blue2.Controls.Add(this.lbl4Position4);
            this.blue2.Controls.Add(this.lbl4Position3Des);
            this.blue2.Controls.Add(this.lbl4Position3Source);
            this.blue2.Controls.Add(this.lbl4Position2Des);
            this.blue2.Controls.Add(this.lbl4Position2Source);
            this.blue2.Controls.Add(this.lbl4Position1);
            this.blue2.Controls.Add(this.lbl4Position3Value);
            this.blue2.Controls.Add(this.lbl4Position3);
            this.blue2.Controls.Add(this.lbl4Position2Value);
            this.blue2.Controls.Add(this.lbl4Position2);
            this.blue2.Controls.Add(this.panel14);
            this.blue2.Controls.Add(this.panel15);
            this.blue2.Location = new System.Drawing.Point(500, 2);
            this.blue2.Name = "blue2";
            this.blue2.Size = new System.Drawing.Size(484, 394);
            this.blue2.TabIndex = 390;
            // 
            // lbl4Position0Value
            // 
            this.lbl4Position0Value.AutoSize = true;
            this.lbl4Position0Value.BackColor = System.Drawing.Color.Red;
            this.lbl4Position0Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl4Position0Value.ForeColor = System.Drawing.Color.Red;
            this.lbl4Position0Value.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl4Position0Value.Location = new System.Drawing.Point(77, 61);
            this.lbl4Position0Value.Name = "lbl4Position0Value";
            this.lbl4Position0Value.Size = new System.Drawing.Size(20, 29);
            this.lbl4Position0Value.TabIndex = 355;
            this.lbl4Position0Value.Text = ".";
            this.lbl4Position0Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl4Position0
            // 
            this.lbl4Position0.AutoSize = true;
            this.lbl4Position0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4Position0.ForeColor = System.Drawing.Color.White;
            this.lbl4Position0.Location = new System.Drawing.Point(7, 61);
            this.lbl4Position0.Name = "lbl4Position0";
            this.lbl4Position0.Size = new System.Drawing.Size(83, 29);
            this.lbl4Position0.TabIndex = 341;
            this.lbl4Position0.Text = "Leave";
            // 
            // lbl4Position12Value
            // 
            this.lbl4Position12Value.AutoSize = true;
            this.lbl4Position12Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4Position12Value.ForeColor = System.Drawing.Color.White;
            this.lbl4Position12Value.Location = new System.Drawing.Point(57, 279);
            this.lbl4Position12Value.Name = "lbl4Position12Value";
            this.lbl4Position12Value.Size = new System.Drawing.Size(27, 29);
            this.lbl4Position12Value.TabIndex = 386;
            this.lbl4Position12Value.Text = "9";
            // 
            // lbl4Position12
            // 
            this.lbl4Position12.AutoSize = true;
            this.lbl4Position12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4Position12.ForeColor = System.Drawing.Color.White;
            this.lbl4Position12.Location = new System.Drawing.Point(7, 278);
            this.lbl4Position12.Name = "lbl4Position12";
            this.lbl4Position12.Size = new System.Drawing.Size(74, 29);
            this.lbl4Position12.TabIndex = 385;
            this.lbl4Position12.Text = "Strat:";
            // 
            // lbl4Position11Value
            // 
            this.lbl4Position11Value.AutoSize = true;
            this.lbl4Position11Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4Position11Value.ForeColor = System.Drawing.Color.White;
            this.lbl4Position11Value.Location = new System.Drawing.Point(111, 251);
            this.lbl4Position11Value.Name = "lbl4Position11Value";
            this.lbl4Position11Value.Size = new System.Drawing.Size(27, 29);
            this.lbl4Position11Value.TabIndex = 384;
            this.lbl4Position11Value.Text = "9";
            // 
            // lbl4Position11
            // 
            this.lbl4Position11.AutoSize = true;
            this.lbl4Position11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4Position11.ForeColor = System.Drawing.Color.White;
            this.lbl4Position11.Location = new System.Drawing.Point(7, 251);
            this.lbl4Position11.Name = "lbl4Position11";
            this.lbl4Position11.Size = new System.Drawing.Size(133, 29);
            this.lbl4Position11.TabIndex = 383;
            this.lbl4Position11.Text = "End State:";
            // 
            // lbl4Position8Value
            // 
            this.lbl4Position8Value.AutoSize = true;
            this.lbl4Position8Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4Position8Value.ForeColor = System.Drawing.Color.White;
            this.lbl4Position8Value.Location = new System.Drawing.Point(444, 192);
            this.lbl4Position8Value.Name = "lbl4Position8Value";
            this.lbl4Position8Value.Size = new System.Drawing.Size(27, 29);
            this.lbl4Position8Value.TabIndex = 372;
            this.lbl4Position8Value.Text = "9";
            // 
            // lbl4Position8
            // 
            this.lbl4Position8.AutoSize = true;
            this.lbl4Position8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4Position8.ForeColor = System.Drawing.Color.White;
            this.lbl4Position8.Location = new System.Drawing.Point(380, 191);
            this.lbl4Position8.Name = "lbl4Position8";
            this.lbl4Position8.Size = new System.Drawing.Size(85, 29);
            this.lbl4Position8.TabIndex = 371;
            this.lbl4Position8.Text = "Avoid:";
            // 
            // lbl4Position7Value
            // 
            this.lbl4Position7Value.AutoSize = true;
            this.lbl4Position7Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4Position7Value.ForeColor = System.Drawing.Color.White;
            this.lbl4Position7Value.Location = new System.Drawing.Point(336, 247);
            this.lbl4Position7Value.Name = "lbl4Position7Value";
            this.lbl4Position7Value.Size = new System.Drawing.Size(27, 29);
            this.lbl4Position7Value.TabIndex = 380;
            this.lbl4Position7Value.Text = "9";
            // 
            // lbl4Position7
            // 
            this.lbl4Position7.AutoSize = true;
            this.lbl4Position7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4Position7.ForeColor = System.Drawing.Color.White;
            this.lbl4Position7.Location = new System.Drawing.Point(301, 246);
            this.lbl4Position7.Name = "lbl4Position7";
            this.lbl4Position7.Size = new System.Drawing.Size(51, 29);
            this.lbl4Position7.TabIndex = 379;
            this.lbl4Position7.Text = "Eff:";
            // 
            // lbl4Position5Value
            // 
            this.lbl4Position5Value.AutoSize = true;
            this.lbl4Position5Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4Position5Value.ForeColor = System.Drawing.Color.White;
            this.lbl4Position5Value.Location = new System.Drawing.Point(242, 191);
            this.lbl4Position5Value.Name = "lbl4Position5Value";
            this.lbl4Position5Value.Size = new System.Drawing.Size(27, 29);
            this.lbl4Position5Value.TabIndex = 370;
            this.lbl4Position5Value.Text = "9";
            this.lbl4Position5Value.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl4Position5
            // 
            this.lbl4Position5.AutoSize = true;
            this.lbl4Position5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4Position5.ForeColor = System.Drawing.Color.White;
            this.lbl4Position5.Location = new System.Drawing.Point(189, 190);
            this.lbl4Position5.Name = "lbl4Position5";
            this.lbl4Position5.Size = new System.Drawing.Size(60, 29);
            this.lbl4Position5.TabIndex = 369;
            this.lbl4Position5.Text = "Def:";
            this.lbl4Position5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl4Position4Value
            // 
            this.lbl4Position4Value.AutoSize = true;
            this.lbl4Position4Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4Position4Value.ForeColor = System.Drawing.Color.White;
            this.lbl4Position4Value.Location = new System.Drawing.Point(345, 142);
            this.lbl4Position4Value.Name = "lbl4Position4Value";
            this.lbl4Position4Value.Size = new System.Drawing.Size(27, 29);
            this.lbl4Position4Value.TabIndex = 366;
            this.lbl4Position4Value.Text = "9";
            // 
            // lbl4Position4
            // 
            this.lbl4Position4.AutoSize = true;
            this.lbl4Position4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4Position4.ForeColor = System.Drawing.Color.White;
            this.lbl4Position4.Location = new System.Drawing.Point(263, 141);
            this.lbl4Position4.Name = "lbl4Position4";
            this.lbl4Position4.Size = new System.Drawing.Size(108, 29);
            this.lbl4Position4.TabIndex = 365;
            this.lbl4Position4.Text = "Attempt:";
            // 
            // lbl4Position3Des
            // 
            this.lbl4Position3Des.AutoSize = true;
            this.lbl4Position3Des.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4Position3Des.ForeColor = System.Drawing.Color.White;
            this.lbl4Position3Des.Location = new System.Drawing.Point(181, 156);
            this.lbl4Position3Des.Name = "lbl4Position3Des";
            this.lbl4Position3Des.Size = new System.Drawing.Size(75, 29);
            this.lbl4Position3Des.TabIndex = 364;
            this.lbl4Position3Des.Text = "Floor";
            // 
            // lbl4Position3Source
            // 
            this.lbl4Position3Source.AutoSize = true;
            this.lbl4Position3Source.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4Position3Source.ForeColor = System.Drawing.Color.White;
            this.lbl4Position3Source.Location = new System.Drawing.Point(108, 156);
            this.lbl4Position3Source.Name = "lbl4Position3Source";
            this.lbl4Position3Source.Size = new System.Drawing.Size(75, 29);
            this.lbl4Position3Source.TabIndex = 378;
            this.lbl4Position3Source.Text = "Floor";
            // 
            // lbl4Position2Des
            // 
            this.lbl4Position2Des.AutoSize = true;
            this.lbl4Position2Des.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4Position2Des.ForeColor = System.Drawing.Color.White;
            this.lbl4Position2Des.Location = new System.Drawing.Point(181, 118);
            this.lbl4Position2Des.Name = "lbl4Position2Des";
            this.lbl4Position2Des.Size = new System.Drawing.Size(75, 29);
            this.lbl4Position2Des.TabIndex = 363;
            this.lbl4Position2Des.Text = "Floor";
            // 
            // lbl4Position2Source
            // 
            this.lbl4Position2Source.AutoSize = true;
            this.lbl4Position2Source.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4Position2Source.ForeColor = System.Drawing.Color.White;
            this.lbl4Position2Source.Location = new System.Drawing.Point(108, 118);
            this.lbl4Position2Source.Name = "lbl4Position2Source";
            this.lbl4Position2Source.Size = new System.Drawing.Size(94, 29);
            this.lbl4Position2Source.TabIndex = 377;
            this.lbl4Position2Source.Text = "Station";
            // 
            // lbl4Position1
            // 
            this.lbl4Position1.AutoSize = true;
            this.lbl4Position1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4Position1.ForeColor = System.Drawing.Color.White;
            this.lbl4Position1.Location = new System.Drawing.Point(250, 62);
            this.lbl4Position1.Name = "lbl4Position1";
            this.lbl4Position1.Size = new System.Drawing.Size(131, 29);
            this.lbl4Position1.TabIndex = 342;
            this.lbl4Position1.Text = "Near Side";
            // 
            // lbl4Position3Value
            // 
            this.lbl4Position3Value.AutoSize = true;
            this.lbl4Position3Value.BackColor = System.Drawing.Color.Red;
            this.lbl4Position3Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl4Position3Value.ForeColor = System.Drawing.Color.Red;
            this.lbl4Position3Value.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl4Position3Value.Location = new System.Drawing.Point(77, 156);
            this.lbl4Position3Value.Name = "lbl4Position3Value";
            this.lbl4Position3Value.Size = new System.Drawing.Size(20, 29);
            this.lbl4Position3Value.TabIndex = 359;
            this.lbl4Position3Value.Text = ".";
            this.lbl4Position3Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl4Position3
            // 
            this.lbl4Position3.AutoSize = true;
            this.lbl4Position3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4Position3.ForeColor = System.Drawing.Color.White;
            this.lbl4Position3.Location = new System.Drawing.Point(7, 154);
            this.lbl4Position3.Name = "lbl4Position3";
            this.lbl4Position3.Size = new System.Drawing.Size(87, 29);
            this.lbl4Position3.TabIndex = 356;
            this.lbl4Position3.Text = "Algae:";
            // 
            // lbl4Position2Value
            // 
            this.lbl4Position2Value.AutoSize = true;
            this.lbl4Position2Value.BackColor = System.Drawing.Color.Red;
            this.lbl4Position2Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl4Position2Value.ForeColor = System.Drawing.Color.Red;
            this.lbl4Position2Value.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl4Position2Value.Location = new System.Drawing.Point(77, 115);
            this.lbl4Position2Value.Name = "lbl4Position2Value";
            this.lbl4Position2Value.Size = new System.Drawing.Size(20, 29);
            this.lbl4Position2Value.TabIndex = 354;
            this.lbl4Position2Value.Text = ".";
            this.lbl4Position2Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl4Position2
            // 
            this.lbl4Position2.AutoSize = true;
            this.lbl4Position2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4Position2.ForeColor = System.Drawing.Color.White;
            this.lbl4Position2.Location = new System.Drawing.Point(7, 116);
            this.lbl4Position2.Name = "lbl4Position2";
            this.lbl4Position2.Size = new System.Drawing.Size(83, 29);
            this.lbl4Position2.TabIndex = 352;
            this.lbl4Position2.Text = "Coral:";
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.Blue;
            this.panel14.Controls.Add(this.label129);
            this.panel14.Location = new System.Drawing.Point(0, 94);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(494, 11);
            this.panel14.TabIndex = 347;
            // 
            // label129
            // 
            this.label129.AutoSize = true;
            this.label129.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label129.ForeColor = System.Drawing.Color.Red;
            this.label129.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label129.Location = new System.Drawing.Point(418, 214);
            this.label129.Name = "label129";
            this.label129.Size = new System.Drawing.Size(46, 31);
            this.label129.TabIndex = 277;
            this.label129.Text = "00";
            this.label129.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.Blue;
            this.panel15.Controls.Add(this.label130);
            this.panel15.Location = new System.Drawing.Point(0, 46);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(484, 11);
            this.panel15.TabIndex = 348;
            // 
            // label130
            // 
            this.label130.AutoSize = true;
            this.label130.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label130.ForeColor = System.Drawing.Color.Red;
            this.label130.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label130.Location = new System.Drawing.Point(418, 214);
            this.label130.Name = "label130";
            this.label130.Size = new System.Drawing.Size(46, 31);
            this.label130.TabIndex = 277;
            this.label130.Text = "00";
            this.label130.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // blue1
            // 
            this.blue1.BackColor = System.Drawing.Color.Black;
            this.blue1.Controls.Add(this.lbl3Position0Value);
            this.blue1.Controls.Add(this.lbl3Position0);
            this.blue1.Controls.Add(this.lbl3Position12Value);
            this.blue1.Controls.Add(this.lbl3Position12);
            this.blue1.Controls.Add(this.lbl3Position11Value);
            this.blue1.Controls.Add(this.lbl3Position11);
            this.blue1.Controls.Add(this.lbl3Position8Value);
            this.blue1.Controls.Add(this.lbl3Position8);
            this.blue1.Controls.Add(this.lbl3Position7Value);
            this.blue1.Controls.Add(this.lbl3Position7);
            this.blue1.Controls.Add(this.lbl3Position5Value);
            this.blue1.Controls.Add(this.lbl3Position5);
            this.blue1.Controls.Add(this.lbl3Position4Value);
            this.blue1.Controls.Add(this.lbl3Position4);
            this.blue1.Controls.Add(this.lbl3Position3Des);
            this.blue1.Controls.Add(this.lbl3Position3Source);
            this.blue1.Controls.Add(this.lbl3Position2Des);
            this.blue1.Controls.Add(this.lbl3Position2Source);
            this.blue1.Controls.Add(this.lbl3Position1);
            this.blue1.Controls.Add(this.lbl3Position3Value);
            this.blue1.Controls.Add(this.lbl3Position3);
            this.blue1.Controls.Add(this.lbl3Position2Value);
            this.blue1.Controls.Add(this.lbl3Position2);
            this.blue1.Controls.Add(this.panel18);
            this.blue1.Controls.Add(this.panel19);
            this.blue1.Location = new System.Drawing.Point(6, 2);
            this.blue1.Name = "blue1";
            this.blue1.Size = new System.Drawing.Size(484, 394);
            this.blue1.TabIndex = 389;
            // 
            // lbl3Position0Value
            // 
            this.lbl3Position0Value.AutoSize = true;
            this.lbl3Position0Value.BackColor = System.Drawing.Color.Red;
            this.lbl3Position0Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl3Position0Value.ForeColor = System.Drawing.Color.Red;
            this.lbl3Position0Value.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl3Position0Value.Location = new System.Drawing.Point(77, 61);
            this.lbl3Position0Value.Name = "lbl3Position0Value";
            this.lbl3Position0Value.Size = new System.Drawing.Size(20, 29);
            this.lbl3Position0Value.TabIndex = 355;
            this.lbl3Position0Value.Text = ".";
            this.lbl3Position0Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl3Position0
            // 
            this.lbl3Position0.AutoSize = true;
            this.lbl3Position0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3Position0.ForeColor = System.Drawing.Color.White;
            this.lbl3Position0.Location = new System.Drawing.Point(7, 61);
            this.lbl3Position0.Name = "lbl3Position0";
            this.lbl3Position0.Size = new System.Drawing.Size(83, 29);
            this.lbl3Position0.TabIndex = 341;
            this.lbl3Position0.Text = "Leave";
            // 
            // lbl3Position12Value
            // 
            this.lbl3Position12Value.AutoSize = true;
            this.lbl3Position12Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3Position12Value.ForeColor = System.Drawing.Color.White;
            this.lbl3Position12Value.Location = new System.Drawing.Point(57, 279);
            this.lbl3Position12Value.Name = "lbl3Position12Value";
            this.lbl3Position12Value.Size = new System.Drawing.Size(27, 29);
            this.lbl3Position12Value.TabIndex = 386;
            this.lbl3Position12Value.Text = "9";
            // 
            // lbl3Position12
            // 
            this.lbl3Position12.AutoSize = true;
            this.lbl3Position12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3Position12.ForeColor = System.Drawing.Color.White;
            this.lbl3Position12.Location = new System.Drawing.Point(7, 278);
            this.lbl3Position12.Name = "lbl3Position12";
            this.lbl3Position12.Size = new System.Drawing.Size(74, 29);
            this.lbl3Position12.TabIndex = 385;
            this.lbl3Position12.Text = "Strat:";
            // 
            // lbl3Position11Value
            // 
            this.lbl3Position11Value.AutoSize = true;
            this.lbl3Position11Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3Position11Value.ForeColor = System.Drawing.Color.White;
            this.lbl3Position11Value.Location = new System.Drawing.Point(111, 251);
            this.lbl3Position11Value.Name = "lbl3Position11Value";
            this.lbl3Position11Value.Size = new System.Drawing.Size(27, 29);
            this.lbl3Position11Value.TabIndex = 384;
            this.lbl3Position11Value.Text = "9";
            // 
            // lbl3Position11
            // 
            this.lbl3Position11.AutoSize = true;
            this.lbl3Position11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3Position11.ForeColor = System.Drawing.Color.White;
            this.lbl3Position11.Location = new System.Drawing.Point(7, 251);
            this.lbl3Position11.Name = "lbl3Position11";
            this.lbl3Position11.Size = new System.Drawing.Size(133, 29);
            this.lbl3Position11.TabIndex = 383;
            this.lbl3Position11.Text = "End State:";
            // 
            // lbl3Position8Value
            // 
            this.lbl3Position8Value.AutoSize = true;
            this.lbl3Position8Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3Position8Value.ForeColor = System.Drawing.Color.White;
            this.lbl3Position8Value.Location = new System.Drawing.Point(444, 192);
            this.lbl3Position8Value.Name = "lbl3Position8Value";
            this.lbl3Position8Value.Size = new System.Drawing.Size(27, 29);
            this.lbl3Position8Value.TabIndex = 372;
            this.lbl3Position8Value.Text = "9";
            // 
            // lbl3Position8
            // 
            this.lbl3Position8.AutoSize = true;
            this.lbl3Position8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3Position8.ForeColor = System.Drawing.Color.White;
            this.lbl3Position8.Location = new System.Drawing.Point(380, 191);
            this.lbl3Position8.Name = "lbl3Position8";
            this.lbl3Position8.Size = new System.Drawing.Size(85, 29);
            this.lbl3Position8.TabIndex = 371;
            this.lbl3Position8.Text = "Avoid:";
            // 
            // lbl3Position7Value
            // 
            this.lbl3Position7Value.AutoSize = true;
            this.lbl3Position7Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3Position7Value.ForeColor = System.Drawing.Color.White;
            this.lbl3Position7Value.Location = new System.Drawing.Point(336, 247);
            this.lbl3Position7Value.Name = "lbl3Position7Value";
            this.lbl3Position7Value.Size = new System.Drawing.Size(27, 29);
            this.lbl3Position7Value.TabIndex = 380;
            this.lbl3Position7Value.Text = "9";
            // 
            // lbl3Position7
            // 
            this.lbl3Position7.AutoSize = true;
            this.lbl3Position7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3Position7.ForeColor = System.Drawing.Color.White;
            this.lbl3Position7.Location = new System.Drawing.Point(301, 246);
            this.lbl3Position7.Name = "lbl3Position7";
            this.lbl3Position7.Size = new System.Drawing.Size(51, 29);
            this.lbl3Position7.TabIndex = 379;
            this.lbl3Position7.Text = "Eff:";
            // 
            // lbl3Position5Value
            // 
            this.lbl3Position5Value.AutoSize = true;
            this.lbl3Position5Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3Position5Value.ForeColor = System.Drawing.Color.White;
            this.lbl3Position5Value.Location = new System.Drawing.Point(242, 191);
            this.lbl3Position5Value.Name = "lbl3Position5Value";
            this.lbl3Position5Value.Size = new System.Drawing.Size(27, 29);
            this.lbl3Position5Value.TabIndex = 370;
            this.lbl3Position5Value.Text = "9";
            this.lbl3Position5Value.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl3Position5
            // 
            this.lbl3Position5.AutoSize = true;
            this.lbl3Position5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3Position5.ForeColor = System.Drawing.Color.White;
            this.lbl3Position5.Location = new System.Drawing.Point(189, 190);
            this.lbl3Position5.Name = "lbl3Position5";
            this.lbl3Position5.Size = new System.Drawing.Size(60, 29);
            this.lbl3Position5.TabIndex = 369;
            this.lbl3Position5.Text = "Def:";
            this.lbl3Position5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl3Position4Value
            // 
            this.lbl3Position4Value.AutoSize = true;
            this.lbl3Position4Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3Position4Value.ForeColor = System.Drawing.Color.White;
            this.lbl3Position4Value.Location = new System.Drawing.Point(345, 142);
            this.lbl3Position4Value.Name = "lbl3Position4Value";
            this.lbl3Position4Value.Size = new System.Drawing.Size(27, 29);
            this.lbl3Position4Value.TabIndex = 366;
            this.lbl3Position4Value.Text = "9";
            // 
            // lbl3Position4
            // 
            this.lbl3Position4.AutoSize = true;
            this.lbl3Position4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3Position4.ForeColor = System.Drawing.Color.White;
            this.lbl3Position4.Location = new System.Drawing.Point(263, 141);
            this.lbl3Position4.Name = "lbl3Position4";
            this.lbl3Position4.Size = new System.Drawing.Size(108, 29);
            this.lbl3Position4.TabIndex = 365;
            this.lbl3Position4.Text = "Attempt:";
            // 
            // lbl3Position3Des
            // 
            this.lbl3Position3Des.AutoSize = true;
            this.lbl3Position3Des.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3Position3Des.ForeColor = System.Drawing.Color.White;
            this.lbl3Position3Des.Location = new System.Drawing.Point(181, 156);
            this.lbl3Position3Des.Name = "lbl3Position3Des";
            this.lbl3Position3Des.Size = new System.Drawing.Size(75, 29);
            this.lbl3Position3Des.TabIndex = 364;
            this.lbl3Position3Des.Text = "Floor";
            // 
            // lbl3Position3Source
            // 
            this.lbl3Position3Source.AutoSize = true;
            this.lbl3Position3Source.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3Position3Source.ForeColor = System.Drawing.Color.White;
            this.lbl3Position3Source.Location = new System.Drawing.Point(108, 156);
            this.lbl3Position3Source.Name = "lbl3Position3Source";
            this.lbl3Position3Source.Size = new System.Drawing.Size(75, 29);
            this.lbl3Position3Source.TabIndex = 378;
            this.lbl3Position3Source.Text = "Floor";
            // 
            // lbl3Position2Des
            // 
            this.lbl3Position2Des.AutoSize = true;
            this.lbl3Position2Des.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3Position2Des.ForeColor = System.Drawing.Color.White;
            this.lbl3Position2Des.Location = new System.Drawing.Point(181, 118);
            this.lbl3Position2Des.Name = "lbl3Position2Des";
            this.lbl3Position2Des.Size = new System.Drawing.Size(75, 29);
            this.lbl3Position2Des.TabIndex = 363;
            this.lbl3Position2Des.Text = "Floor";
            // 
            // lbl3Position2Source
            // 
            this.lbl3Position2Source.AutoSize = true;
            this.lbl3Position2Source.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3Position2Source.ForeColor = System.Drawing.Color.White;
            this.lbl3Position2Source.Location = new System.Drawing.Point(108, 118);
            this.lbl3Position2Source.Name = "lbl3Position2Source";
            this.lbl3Position2Source.Size = new System.Drawing.Size(94, 29);
            this.lbl3Position2Source.TabIndex = 377;
            this.lbl3Position2Source.Text = "Station";
            // 
            // lbl3Position1
            // 
            this.lbl3Position1.AutoSize = true;
            this.lbl3Position1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3Position1.ForeColor = System.Drawing.Color.White;
            this.lbl3Position1.Location = new System.Drawing.Point(250, 62);
            this.lbl3Position1.Name = "lbl3Position1";
            this.lbl3Position1.Size = new System.Drawing.Size(131, 29);
            this.lbl3Position1.TabIndex = 342;
            this.lbl3Position1.Text = "Near Side";
            // 
            // lbl3Position3Value
            // 
            this.lbl3Position3Value.AutoSize = true;
            this.lbl3Position3Value.BackColor = System.Drawing.Color.Red;
            this.lbl3Position3Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl3Position3Value.ForeColor = System.Drawing.Color.Red;
            this.lbl3Position3Value.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl3Position3Value.Location = new System.Drawing.Point(77, 156);
            this.lbl3Position3Value.Name = "lbl3Position3Value";
            this.lbl3Position3Value.Size = new System.Drawing.Size(20, 29);
            this.lbl3Position3Value.TabIndex = 359;
            this.lbl3Position3Value.Text = ".";
            this.lbl3Position3Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl3Position3
            // 
            this.lbl3Position3.AutoSize = true;
            this.lbl3Position3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3Position3.ForeColor = System.Drawing.Color.White;
            this.lbl3Position3.Location = new System.Drawing.Point(7, 154);
            this.lbl3Position3.Name = "lbl3Position3";
            this.lbl3Position3.Size = new System.Drawing.Size(87, 29);
            this.lbl3Position3.TabIndex = 356;
            this.lbl3Position3.Text = "Algae:";
            // 
            // lbl3Position2Value
            // 
            this.lbl3Position2Value.AutoSize = true;
            this.lbl3Position2Value.BackColor = System.Drawing.Color.Red;
            this.lbl3Position2Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl3Position2Value.ForeColor = System.Drawing.Color.Red;
            this.lbl3Position2Value.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl3Position2Value.Location = new System.Drawing.Point(77, 115);
            this.lbl3Position2Value.Name = "lbl3Position2Value";
            this.lbl3Position2Value.Size = new System.Drawing.Size(20, 29);
            this.lbl3Position2Value.TabIndex = 354;
            this.lbl3Position2Value.Text = ".";
            this.lbl3Position2Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl3Position2
            // 
            this.lbl3Position2.AutoSize = true;
            this.lbl3Position2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3Position2.ForeColor = System.Drawing.Color.White;
            this.lbl3Position2.Location = new System.Drawing.Point(7, 116);
            this.lbl3Position2.Name = "lbl3Position2";
            this.lbl3Position2.Size = new System.Drawing.Size(83, 29);
            this.lbl3Position2.TabIndex = 352;
            this.lbl3Position2.Text = "Coral:";
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.Color.Blue;
            this.panel18.Controls.Add(this.label161);
            this.panel18.Location = new System.Drawing.Point(0, 94);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(494, 11);
            this.panel18.TabIndex = 347;
            // 
            // label161
            // 
            this.label161.AutoSize = true;
            this.label161.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label161.ForeColor = System.Drawing.Color.Red;
            this.label161.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label161.Location = new System.Drawing.Point(418, 214);
            this.label161.Name = "label161";
            this.label161.Size = new System.Drawing.Size(46, 31);
            this.label161.TabIndex = 277;
            this.label161.Text = "00";
            this.label161.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel19
            // 
            this.panel19.BackColor = System.Drawing.Color.Blue;
            this.panel19.Controls.Add(this.label162);
            this.panel19.Location = new System.Drawing.Point(0, 46);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(484, 11);
            this.panel19.TabIndex = 348;
            // 
            // label162
            // 
            this.label162.AutoSize = true;
            this.label162.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label162.ForeColor = System.Drawing.Color.Red;
            this.label162.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label162.Location = new System.Drawing.Point(418, 214);
            this.label162.Name = "label162";
            this.label162.Size = new System.Drawing.Size(46, 31);
            this.label162.TabIndex = 277;
            this.label162.Text = "00";
            this.label162.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // updateScreen
            // 
            this.updateScreen.Interval = 50;
            this.updateScreen.Tick += new System.EventHandler(this.UpdateScreen);
            // 
            // lblRedScore
            // 
            this.lblRedScore.AutoSize = true;
            this.lblRedScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRedScore.ForeColor = System.Drawing.Color.Red;
            this.lblRedScore.Location = new System.Drawing.Point(1009, 18);
            this.lblRedScore.Name = "lblRedScore";
            this.lblRedScore.Size = new System.Drawing.Size(27, 29);
            this.lblRedScore.TabIndex = 387;
            this.lblRedScore.Text = "0";
            // 
            // lblBlueScore
            // 
            this.lblBlueScore.AutoSize = true;
            this.lblBlueScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlueScore.ForeColor = System.Drawing.Color.Blue;
            this.lblBlueScore.Location = new System.Drawing.Point(1053, 18);
            this.lblBlueScore.Name = "lblBlueScore";
            this.lblBlueScore.Size = new System.Drawing.Size(27, 29);
            this.lblBlueScore.TabIndex = 388;
            this.lblBlueScore.Text = "0";
            // 
            // ScouterBoxes
            // 
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.lblBlueScore);
            this.Controls.Add(this.lblRedScore);
            this.Controls.Add(this.bluePanel);
            this.Controls.Add(this.redPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ScouterBoxes";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Black;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.redPanel.ResumeLayout(false);
            this.red3.ResumeLayout(false);
            this.red3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.red2.ResumeLayout(false);
            this.red2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.red1.ResumeLayout(false);
            this.red1.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.bluePanel.ResumeLayout(false);
            this.blue3.ResumeLayout(false);
            this.blue3.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.blue2.ResumeLayout(false);
            this.blue2.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.blue1.ResumeLayout(false);
            this.blue1.PerformLayout();
            this.panel18.ResumeLayout(false);
            this.panel18.PerformLayout();
            this.panel19.ResumeLayout(false);
            this.panel19.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.Label lbl0Position0;
        private System.Windows.Forms.Label lbl0Position1;
        private System.ComponentModel.IContainer components = null;
        private Timer updateScreen;
        private Panel redPanel;
        private Panel red1;
        private Panel bluePanel;
        private Panel panel2;
        private Label label1;
        private Panel panel8;
        private Label label28;
        private Label lbl0Position3Value;
        private Label lbl0Position3;
        private Label lbl0Position2Value;
        private Label lbl0Position2;
        private Label lbl0Position2Des;
        private Label lbl0Position0Value;
        private Label lbl0Position4;
        private Label lbl0Position3Des;
        private Label lbl0Position4Value;
        private Label lbl0Position8Value;
        private Label lbl0Position8;
        private Label lbl0Position5Value;
        private Label lbl0Position5;
        private Label lbl0Position3Source;
        private Label lbl0Position2Source;
        private Label lbl0Position7Value;
        private Label lbl0Position7;
        private Label lbl0Position12Value;
        private Label lbl0Position12;
        private Label lbl0Position11Value;
        private Label lbl0Position11;
        private Panel red2;
        private Label lbl1Position0Value;
        private Label lbl1Position0;
        private Label lbl1Position12Value;
        private Label lbl1Position12;
        private Label lbl1Position11Value;
        private Label lbl1Position11;
        private Label lbl1Position8Value;
        private Label lbl1Position8;
        private Label lbl1Position7Value;
        private Label lbl1Position7;
        private Label lbl1Position5Value;
        private Label lbl1Position5;
        private Label lbl1Position4Value;
        private Label lbl1Position4;
        private Label lbl1Position3Des;
        private Label lbl1Position3Source;
        private Label lbl1Position2Des;
        private Label lbl1Position2Source;
        private Label lbl1Position1;
        private Label lbl1Position3Value;
        private Label lbl1Position3;
        private Label lbl1Position2Value;
        private Label lbl1Position2;
        private Panel panel3;
        private Label label32;
        private Panel panel4;
        private Label label33;
        private Panel red3;
        private Label lbl2Position0Value;
        private Label lbl2Position0;
        private Label lbl2Position12Value;
        private Label lbl2Position12;
        private Label lbl2Position11Value;
        private Label lbl2Position11;
        private Label lbl2Position8Value;
        private Label lbl2Position8;
        private Label lbl2Position7Value;
        private Label lbl2Position7;
        private Label lbl2Position5Value;
        private Label lbl2Position5;
        private Label lbl2Position4Value;
        private Label lbl2Position4;
        private Label lbl2Position3Des;
        private Label lbl2Position3Source;
        private Label lbl2Position2Des;
        private Label lbl2Position2Source;
        private Label lbl2Position1;
        private Label lbl2Position3Value;
        private Label lbl2Position3;
        private Label lbl2Position2Value;
        private Label lbl2Position2;
        private Panel panel6;
        private Label label64;
        private Panel panel7;
        private Label label65;
        private Panel blue3;
        private Label lbl5Position0Value;
        private Label lbl5Position0;
        private Label lbl5Position12Value;
        private Label lbl5Position12;
        private Label lbl5Position11Value;
        private Label lbl5Position11;
        private Label lbl5Position8Value;
        private Label lbl5Position8;
        private Label lbl5Position7Value;
        private Label lbl5Position7;
        private Label lbl5Position5Value;
        private Label lbl5Position5;
        private Label lbl5Position4Value;
        private Label lbl5Position4;
        private Label lbl5Position3Des;
        private Label lbl5Position3Source;
        private Label lbl5Position2Des;
        private Label lbl5Position2Source;
        private Label lbl5Position1;
        private Label lbl5Position3Value;
        private Label lbl5Position3;
        private Label lbl5Position2Value;
        private Label lbl5Position2;
        private Panel panel10;
        private Label label96;
        private Panel panel11;
        private Label label97;
        private Panel blue2;
        private Label lbl4Position0Value;
        private Label lbl4Position0;
        private Label lbl4Position12Value;
        private Label lbl4Position12;
        private Label lbl4Position11Value;
        private Label lbl4Position11;
        private Label lbl4Position8Value;
        private Label lbl4Position8;
        private Label lbl4Position7Value;
        private Label lbl4Position7;
        private Label lbl4Position5Value;
        private Label lbl4Position5;
        private Label lbl4Position4Value;
        private Label lbl4Position4;
        private Label lbl4Position3Des;
        private Label lbl4Position3Source;
        private Label lbl4Position2Des;
        private Label lbl4Position2Source;
        private Label lbl4Position1;
        private Label lbl4Position3Value;
        private Label lbl4Position3;
        private Label lbl4Position2Value;
        private Label lbl4Position2;
        private Panel panel14;
        private Label label129;
        private Panel panel15;
        private Label label130;
        private Panel blue1;
        private Label lbl3Position0Value;
        private Label lbl3Position0;
        private Label lbl3Position12Value;
        private Label lbl3Position12;
        private Label lbl3Position11Value;
        private Label lbl3Position11;
        private Label lbl3Position8Value;
        private Label lbl3Position8;
        private Label lbl3Position7Value;
        private Label lbl3Position7;
        private Label lbl3Position5Value;
        private Label lbl3Position5;
        private Label lbl3Position4Value;
        private Label lbl3Position4;
        private Label lbl3Position3Des;
        private Label lbl3Position3Source;
        private Label lbl3Position2Des;
        private Label lbl3Position2Source;
        private Label lbl3Position1;
        private Label lbl3Position3Value;
        private Label lbl3Position3;
        private Label lbl3Position2Value;
        private Label lbl3Position2;
        private Panel panel18;
        private Label label161;
        private Panel panel19;
        private Label label162;
        private Label lblRedScore;
        private Label lblBlueScore;
    }
}
