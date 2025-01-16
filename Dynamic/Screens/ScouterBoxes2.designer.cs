using ScoutingCodeRedo.Static;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoutingCodeRedo.Dynamic
{
    partial class ScouterBoxes2
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
            this.updateScreen = new System.Windows.Forms.Timer(this.components);
            this.lblRedScore = new System.Windows.Forms.Label();
            this.lblBlueScore = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.red3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.red2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.red1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.blue3.SuspendLayout();
            this.panel10.SuspendLayout();
            this.blue2.SuspendLayout();
            this.panel14.SuspendLayout();
            this.blue1.SuspendLayout();
            this.panel18.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl0Position0
            // 
            this.lbl0Position0.AutoSize = true;
            this.lbl0Position0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl0Position0.ForeColor = System.Drawing.Color.White;
            this.lbl0Position0.Location = new System.Drawing.Point(107, 102);
            this.lbl0Position0.Name = "lbl0Position0";
            this.lbl0Position0.Size = new System.Drawing.Size(99, 33);
            this.lbl0Position0.TabIndex = 341;
            this.lbl0Position0.Text = "Leave";
            // 
            // lbl0Position1
            // 
            this.lbl0Position1.AutoSize = true;
            this.lbl0Position1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl0Position1.ForeColor = System.Drawing.Color.White;
            this.lbl0Position1.Location = new System.Drawing.Point(250, 103);
            this.lbl0Position1.Name = "lbl0Position1";
            this.lbl0Position1.Size = new System.Drawing.Size(153, 33);
            this.lbl0Position1.TabIndex = 342;
            this.lbl0Position1.Text = "Near Side";
            // 
            // redPanel
            // 
            this.redPanel.BackColor = System.Drawing.Color.Red;
            this.redPanel.Location = new System.Drawing.Point(20, 56);
            this.redPanel.Name = "redPanel";
            this.redPanel.Size = new System.Drawing.Size(1485, 400);
            this.redPanel.TabIndex = 347;
            this.redPanel.Visible = false;
            // 
            // red3
            // 
            this.red3.BackColor = System.Drawing.Color.Transparent;
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
            this.red3.ForeColor = System.Drawing.Color.Transparent;
            this.red3.Location = new System.Drawing.Point(989, 151);
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
            this.lbl2Position0Value.Location = new System.Drawing.Point(151, 104);
            this.lbl2Position0Value.Name = "lbl2Position0Value";
            this.lbl2Position0Value.Size = new System.Drawing.Size(24, 33);
            this.lbl2Position0Value.TabIndex = 355;
            this.lbl2Position0Value.Text = ".";
            this.lbl2Position0Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl2Position0
            // 
            this.lbl2Position0.AutoSize = true;
            this.lbl2Position0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2Position0.ForeColor = System.Drawing.Color.White;
            this.lbl2Position0.Location = new System.Drawing.Point(81, 104);
            this.lbl2Position0.Name = "lbl2Position0";
            this.lbl2Position0.Size = new System.Drawing.Size(99, 33);
            this.lbl2Position0.TabIndex = 341;
            this.lbl2Position0.Text = "Leave";
            // 
            // lbl2Position12Value
            // 
            this.lbl2Position12Value.AutoSize = true;
            this.lbl2Position12Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2Position12Value.ForeColor = System.Drawing.Color.White;
            this.lbl2Position12Value.Location = new System.Drawing.Point(109, 343);
            this.lbl2Position12Value.Name = "lbl2Position12Value";
            this.lbl2Position12Value.Size = new System.Drawing.Size(32, 33);
            this.lbl2Position12Value.TabIndex = 386;
            this.lbl2Position12Value.Text = "9";
            // 
            // lbl2Position12
            // 
            this.lbl2Position12.AutoSize = true;
            this.lbl2Position12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2Position12.ForeColor = System.Drawing.Color.White;
            this.lbl2Position12.Location = new System.Drawing.Point(59, 342);
            this.lbl2Position12.Name = "lbl2Position12";
            this.lbl2Position12.Size = new System.Drawing.Size(90, 33);
            this.lbl2Position12.TabIndex = 385;
            this.lbl2Position12.Text = "Strat:";
            // 
            // lbl2Position11Value
            // 
            this.lbl2Position11Value.AutoSize = true;
            this.lbl2Position11Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2Position11Value.ForeColor = System.Drawing.Color.White;
            this.lbl2Position11Value.Location = new System.Drawing.Point(163, 315);
            this.lbl2Position11Value.Name = "lbl2Position11Value";
            this.lbl2Position11Value.Size = new System.Drawing.Size(32, 33);
            this.lbl2Position11Value.TabIndex = 384;
            this.lbl2Position11Value.Text = "9";
            // 
            // lbl2Position11
            // 
            this.lbl2Position11.AutoSize = true;
            this.lbl2Position11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2Position11.ForeColor = System.Drawing.Color.White;
            this.lbl2Position11.Location = new System.Drawing.Point(59, 315);
            this.lbl2Position11.Name = "lbl2Position11";
            this.lbl2Position11.Size = new System.Drawing.Size(159, 33);
            this.lbl2Position11.TabIndex = 383;
            this.lbl2Position11.Text = "End State:";
            // 
            // lbl2Position8Value
            // 
            this.lbl2Position8Value.AutoSize = true;
            this.lbl2Position8Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2Position8Value.ForeColor = System.Drawing.Color.White;
            this.lbl2Position8Value.Location = new System.Drawing.Point(444, 235);
            this.lbl2Position8Value.Name = "lbl2Position8Value";
            this.lbl2Position8Value.Size = new System.Drawing.Size(32, 33);
            this.lbl2Position8Value.TabIndex = 372;
            this.lbl2Position8Value.Text = "9";
            // 
            // lbl2Position8
            // 
            this.lbl2Position8.AutoSize = true;
            this.lbl2Position8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2Position8.ForeColor = System.Drawing.Color.White;
            this.lbl2Position8.Location = new System.Drawing.Point(380, 234);
            this.lbl2Position8.Name = "lbl2Position8";
            this.lbl2Position8.Size = new System.Drawing.Size(102, 33);
            this.lbl2Position8.TabIndex = 371;
            this.lbl2Position8.Text = "Avoid:";
            // 
            // lbl2Position7Value
            // 
            this.lbl2Position7Value.AutoSize = true;
            this.lbl2Position7Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2Position7Value.ForeColor = System.Drawing.Color.White;
            this.lbl2Position7Value.Location = new System.Drawing.Point(336, 290);
            this.lbl2Position7Value.Name = "lbl2Position7Value";
            this.lbl2Position7Value.Size = new System.Drawing.Size(32, 33);
            this.lbl2Position7Value.TabIndex = 380;
            this.lbl2Position7Value.Text = "9";
            // 
            // lbl2Position7
            // 
            this.lbl2Position7.AutoSize = true;
            this.lbl2Position7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2Position7.ForeColor = System.Drawing.Color.White;
            this.lbl2Position7.Location = new System.Drawing.Point(301, 289);
            this.lbl2Position7.Name = "lbl2Position7";
            this.lbl2Position7.Size = new System.Drawing.Size(62, 33);
            this.lbl2Position7.TabIndex = 379;
            this.lbl2Position7.Text = "Eff:";
            // 
            // lbl2Position5Value
            // 
            this.lbl2Position5Value.AutoSize = true;
            this.lbl2Position5Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2Position5Value.ForeColor = System.Drawing.Color.White;
            this.lbl2Position5Value.Location = new System.Drawing.Point(242, 234);
            this.lbl2Position5Value.Name = "lbl2Position5Value";
            this.lbl2Position5Value.Size = new System.Drawing.Size(32, 33);
            this.lbl2Position5Value.TabIndex = 370;
            this.lbl2Position5Value.Text = "9";
            this.lbl2Position5Value.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl2Position5
            // 
            this.lbl2Position5.AutoSize = true;
            this.lbl2Position5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2Position5.ForeColor = System.Drawing.Color.White;
            this.lbl2Position5.Location = new System.Drawing.Point(189, 233);
            this.lbl2Position5.Name = "lbl2Position5";
            this.lbl2Position5.Size = new System.Drawing.Size(72, 33);
            this.lbl2Position5.TabIndex = 369;
            this.lbl2Position5.Text = "Def:";
            this.lbl2Position5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl2Position4Value
            // 
            this.lbl2Position4Value.AutoSize = true;
            this.lbl2Position4Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2Position4Value.ForeColor = System.Drawing.Color.White;
            this.lbl2Position4Value.Location = new System.Drawing.Point(345, 185);
            this.lbl2Position4Value.Name = "lbl2Position4Value";
            this.lbl2Position4Value.Size = new System.Drawing.Size(32, 33);
            this.lbl2Position4Value.TabIndex = 366;
            this.lbl2Position4Value.Text = "9";
            // 
            // lbl2Position4
            // 
            this.lbl2Position4.AutoSize = true;
            this.lbl2Position4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2Position4.ForeColor = System.Drawing.Color.White;
            this.lbl2Position4.Location = new System.Drawing.Point(263, 184);
            this.lbl2Position4.Name = "lbl2Position4";
            this.lbl2Position4.Size = new System.Drawing.Size(131, 33);
            this.lbl2Position4.TabIndex = 365;
            this.lbl2Position4.Text = "Attempt:";
            // 
            // lbl2Position3Des
            // 
            this.lbl2Position3Des.AutoSize = true;
            this.lbl2Position3Des.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2Position3Des.ForeColor = System.Drawing.Color.White;
            this.lbl2Position3Des.Location = new System.Drawing.Point(181, 199);
            this.lbl2Position3Des.Name = "lbl2Position3Des";
            this.lbl2Position3Des.Size = new System.Drawing.Size(87, 33);
            this.lbl2Position3Des.TabIndex = 364;
            this.lbl2Position3Des.Text = "Floor";
            // 
            // lbl2Position3Source
            // 
            this.lbl2Position3Source.AutoSize = true;
            this.lbl2Position3Source.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2Position3Source.ForeColor = System.Drawing.Color.White;
            this.lbl2Position3Source.Location = new System.Drawing.Point(108, 199);
            this.lbl2Position3Source.Name = "lbl2Position3Source";
            this.lbl2Position3Source.Size = new System.Drawing.Size(87, 33);
            this.lbl2Position3Source.TabIndex = 378;
            this.lbl2Position3Source.Text = "Floor";
            // 
            // lbl2Position2Des
            // 
            this.lbl2Position2Des.AutoSize = true;
            this.lbl2Position2Des.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2Position2Des.ForeColor = System.Drawing.Color.White;
            this.lbl2Position2Des.Location = new System.Drawing.Point(181, 161);
            this.lbl2Position2Des.Name = "lbl2Position2Des";
            this.lbl2Position2Des.Size = new System.Drawing.Size(87, 33);
            this.lbl2Position2Des.TabIndex = 363;
            this.lbl2Position2Des.Text = "Floor";
            // 
            // lbl2Position2Source
            // 
            this.lbl2Position2Source.AutoSize = true;
            this.lbl2Position2Source.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2Position2Source.ForeColor = System.Drawing.Color.White;
            this.lbl2Position2Source.Location = new System.Drawing.Point(108, 161);
            this.lbl2Position2Source.Name = "lbl2Position2Source";
            this.lbl2Position2Source.Size = new System.Drawing.Size(112, 33);
            this.lbl2Position2Source.TabIndex = 377;
            this.lbl2Position2Source.Text = "Station";
            // 
            // lbl2Position1
            // 
            this.lbl2Position1.AutoSize = true;
            this.lbl2Position1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2Position1.ForeColor = System.Drawing.Color.White;
            this.lbl2Position1.Location = new System.Drawing.Point(212, 105);
            this.lbl2Position1.Name = "lbl2Position1";
            this.lbl2Position1.Size = new System.Drawing.Size(153, 33);
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
            this.lbl2Position3Value.Location = new System.Drawing.Point(77, 199);
            this.lbl2Position3Value.Name = "lbl2Position3Value";
            this.lbl2Position3Value.Size = new System.Drawing.Size(24, 33);
            this.lbl2Position3Value.TabIndex = 359;
            this.lbl2Position3Value.Text = ".";
            this.lbl2Position3Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl2Position3
            // 
            this.lbl2Position3.AutoSize = true;
            this.lbl2Position3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2Position3.ForeColor = System.Drawing.Color.White;
            this.lbl2Position3.Location = new System.Drawing.Point(7, 197);
            this.lbl2Position3.Name = "lbl2Position3";
            this.lbl2Position3.Size = new System.Drawing.Size(103, 33);
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
            this.lbl2Position2Value.Location = new System.Drawing.Point(77, 158);
            this.lbl2Position2Value.Name = "lbl2Position2Value";
            this.lbl2Position2Value.Size = new System.Drawing.Size(24, 33);
            this.lbl2Position2Value.TabIndex = 354;
            this.lbl2Position2Value.Text = ".";
            this.lbl2Position2Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl2Position2
            // 
            this.lbl2Position2.AutoSize = true;
            this.lbl2Position2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2Position2.ForeColor = System.Drawing.Color.White;
            this.lbl2Position2.Location = new System.Drawing.Point(7, 159);
            this.lbl2Position2.Name = "lbl2Position2";
            this.lbl2Position2.Size = new System.Drawing.Size(99, 33);
            this.lbl2Position2.TabIndex = 352;
            this.lbl2Position2.Text = "Coral:";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Red;
            this.panel6.Controls.Add(this.label64);
            this.panel6.Location = new System.Drawing.Point(53, 137);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(341, 11);
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
            this.label64.Size = new System.Drawing.Size(55, 37);
            this.label64.TabIndex = 277;
            this.label64.Text = "00";
            this.label64.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // red2
            // 
            this.red2.BackColor = System.Drawing.Color.Transparent;
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
            this.red2.ForeColor = System.Drawing.Color.Transparent;
            this.red2.Location = new System.Drawing.Point(530, 9);
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
            this.lbl1Position0Value.Location = new System.Drawing.Point(182, 93);
            this.lbl1Position0Value.Name = "lbl1Position0Value";
            this.lbl1Position0Value.Size = new System.Drawing.Size(24, 33);
            this.lbl1Position0Value.TabIndex = 355;
            this.lbl1Position0Value.Text = ".";
            this.lbl1Position0Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl1Position0
            // 
            this.lbl1Position0.AutoSize = true;
            this.lbl1Position0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1Position0.ForeColor = System.Drawing.Color.White;
            this.lbl1Position0.Location = new System.Drawing.Point(112, 93);
            this.lbl1Position0.Name = "lbl1Position0";
            this.lbl1Position0.Size = new System.Drawing.Size(99, 33);
            this.lbl1Position0.TabIndex = 341;
            this.lbl1Position0.Text = "Leave";
            // 
            // lbl1Position12Value
            // 
            this.lbl1Position12Value.AutoSize = true;
            this.lbl1Position12Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1Position12Value.ForeColor = System.Drawing.Color.White;
            this.lbl1Position12Value.Location = new System.Drawing.Point(131, 319);
            this.lbl1Position12Value.Name = "lbl1Position12Value";
            this.lbl1Position12Value.Size = new System.Drawing.Size(32, 33);
            this.lbl1Position12Value.TabIndex = 386;
            this.lbl1Position12Value.Text = "9";
            // 
            // lbl1Position12
            // 
            this.lbl1Position12.AutoSize = true;
            this.lbl1Position12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1Position12.ForeColor = System.Drawing.Color.White;
            this.lbl1Position12.Location = new System.Drawing.Point(81, 318);
            this.lbl1Position12.Name = "lbl1Position12";
            this.lbl1Position12.Size = new System.Drawing.Size(90, 33);
            this.lbl1Position12.TabIndex = 385;
            this.lbl1Position12.Text = "Strat:";
            // 
            // lbl1Position11Value
            // 
            this.lbl1Position11Value.AutoSize = true;
            this.lbl1Position11Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1Position11Value.ForeColor = System.Drawing.Color.White;
            this.lbl1Position11Value.Location = new System.Drawing.Point(185, 291);
            this.lbl1Position11Value.Name = "lbl1Position11Value";
            this.lbl1Position11Value.Size = new System.Drawing.Size(32, 33);
            this.lbl1Position11Value.TabIndex = 384;
            this.lbl1Position11Value.Text = "9";
            // 
            // lbl1Position11
            // 
            this.lbl1Position11.AutoSize = true;
            this.lbl1Position11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1Position11.ForeColor = System.Drawing.Color.White;
            this.lbl1Position11.Location = new System.Drawing.Point(81, 291);
            this.lbl1Position11.Name = "lbl1Position11";
            this.lbl1Position11.Size = new System.Drawing.Size(159, 33);
            this.lbl1Position11.TabIndex = 383;
            this.lbl1Position11.Text = "End State:";
            // 
            // lbl1Position8Value
            // 
            this.lbl1Position8Value.AutoSize = true;
            this.lbl1Position8Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1Position8Value.ForeColor = System.Drawing.Color.White;
            this.lbl1Position8Value.Location = new System.Drawing.Point(466, 223);
            this.lbl1Position8Value.Name = "lbl1Position8Value";
            this.lbl1Position8Value.Size = new System.Drawing.Size(32, 33);
            this.lbl1Position8Value.TabIndex = 372;
            this.lbl1Position8Value.Text = "9";
            // 
            // lbl1Position8
            // 
            this.lbl1Position8.AutoSize = true;
            this.lbl1Position8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1Position8.ForeColor = System.Drawing.Color.White;
            this.lbl1Position8.Location = new System.Drawing.Point(402, 222);
            this.lbl1Position8.Name = "lbl1Position8";
            this.lbl1Position8.Size = new System.Drawing.Size(102, 33);
            this.lbl1Position8.TabIndex = 371;
            this.lbl1Position8.Text = "Avoid:";
            // 
            // lbl1Position7Value
            // 
            this.lbl1Position7Value.AutoSize = true;
            this.lbl1Position7Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1Position7Value.ForeColor = System.Drawing.Color.White;
            this.lbl1Position7Value.Location = new System.Drawing.Point(358, 278);
            this.lbl1Position7Value.Name = "lbl1Position7Value";
            this.lbl1Position7Value.Size = new System.Drawing.Size(32, 33);
            this.lbl1Position7Value.TabIndex = 380;
            this.lbl1Position7Value.Text = "9";
            // 
            // lbl1Position7
            // 
            this.lbl1Position7.AutoSize = true;
            this.lbl1Position7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1Position7.ForeColor = System.Drawing.Color.White;
            this.lbl1Position7.Location = new System.Drawing.Point(323, 277);
            this.lbl1Position7.Name = "lbl1Position7";
            this.lbl1Position7.Size = new System.Drawing.Size(62, 33);
            this.lbl1Position7.TabIndex = 379;
            this.lbl1Position7.Text = "Eff:";
            // 
            // lbl1Position5Value
            // 
            this.lbl1Position5Value.AutoSize = true;
            this.lbl1Position5Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1Position5Value.ForeColor = System.Drawing.Color.White;
            this.lbl1Position5Value.Location = new System.Drawing.Point(264, 222);
            this.lbl1Position5Value.Name = "lbl1Position5Value";
            this.lbl1Position5Value.Size = new System.Drawing.Size(32, 33);
            this.lbl1Position5Value.TabIndex = 370;
            this.lbl1Position5Value.Text = "9";
            this.lbl1Position5Value.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl1Position5
            // 
            this.lbl1Position5.AutoSize = true;
            this.lbl1Position5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1Position5.ForeColor = System.Drawing.Color.White;
            this.lbl1Position5.Location = new System.Drawing.Point(211, 221);
            this.lbl1Position5.Name = "lbl1Position5";
            this.lbl1Position5.Size = new System.Drawing.Size(72, 33);
            this.lbl1Position5.TabIndex = 369;
            this.lbl1Position5.Text = "Def:";
            this.lbl1Position5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl1Position4Value
            // 
            this.lbl1Position4Value.AutoSize = true;
            this.lbl1Position4Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1Position4Value.ForeColor = System.Drawing.Color.White;
            this.lbl1Position4Value.Location = new System.Drawing.Point(367, 173);
            this.lbl1Position4Value.Name = "lbl1Position4Value";
            this.lbl1Position4Value.Size = new System.Drawing.Size(32, 33);
            this.lbl1Position4Value.TabIndex = 366;
            this.lbl1Position4Value.Text = "9";
            // 
            // lbl1Position4
            // 
            this.lbl1Position4.AutoSize = true;
            this.lbl1Position4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1Position4.ForeColor = System.Drawing.Color.White;
            this.lbl1Position4.Location = new System.Drawing.Point(285, 172);
            this.lbl1Position4.Name = "lbl1Position4";
            this.lbl1Position4.Size = new System.Drawing.Size(131, 33);
            this.lbl1Position4.TabIndex = 365;
            this.lbl1Position4.Text = "Attempt:";
            // 
            // lbl1Position3Des
            // 
            this.lbl1Position3Des.AutoSize = true;
            this.lbl1Position3Des.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1Position3Des.ForeColor = System.Drawing.Color.White;
            this.lbl1Position3Des.Location = new System.Drawing.Point(192, 180);
            this.lbl1Position3Des.Name = "lbl1Position3Des";
            this.lbl1Position3Des.Size = new System.Drawing.Size(87, 33);
            this.lbl1Position3Des.TabIndex = 364;
            this.lbl1Position3Des.Text = "Floor";
            // 
            // lbl1Position3Source
            // 
            this.lbl1Position3Source.AutoSize = true;
            this.lbl1Position3Source.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1Position3Source.ForeColor = System.Drawing.Color.White;
            this.lbl1Position3Source.Location = new System.Drawing.Point(119, 180);
            this.lbl1Position3Source.Name = "lbl1Position3Source";
            this.lbl1Position3Source.Size = new System.Drawing.Size(87, 33);
            this.lbl1Position3Source.TabIndex = 378;
            this.lbl1Position3Source.Text = "Floor";
            // 
            // lbl1Position2Des
            // 
            this.lbl1Position2Des.AutoSize = true;
            this.lbl1Position2Des.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1Position2Des.ForeColor = System.Drawing.Color.White;
            this.lbl1Position2Des.Location = new System.Drawing.Point(192, 142);
            this.lbl1Position2Des.Name = "lbl1Position2Des";
            this.lbl1Position2Des.Size = new System.Drawing.Size(87, 33);
            this.lbl1Position2Des.TabIndex = 363;
            this.lbl1Position2Des.Text = "Floor";
            // 
            // lbl1Position2Source
            // 
            this.lbl1Position2Source.AutoSize = true;
            this.lbl1Position2Source.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1Position2Source.ForeColor = System.Drawing.Color.White;
            this.lbl1Position2Source.Location = new System.Drawing.Point(119, 142);
            this.lbl1Position2Source.Name = "lbl1Position2Source";
            this.lbl1Position2Source.Size = new System.Drawing.Size(112, 33);
            this.lbl1Position2Source.TabIndex = 377;
            this.lbl1Position2Source.Text = "Station";
            // 
            // lbl1Position1
            // 
            this.lbl1Position1.AutoSize = true;
            this.lbl1Position1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1Position1.ForeColor = System.Drawing.Color.White;
            this.lbl1Position1.Location = new System.Drawing.Point(250, 94);
            this.lbl1Position1.Name = "lbl1Position1";
            this.lbl1Position1.Size = new System.Drawing.Size(153, 33);
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
            this.lbl1Position3Value.Location = new System.Drawing.Point(88, 180);
            this.lbl1Position3Value.Name = "lbl1Position3Value";
            this.lbl1Position3Value.Size = new System.Drawing.Size(24, 33);
            this.lbl1Position3Value.TabIndex = 359;
            this.lbl1Position3Value.Text = ".";
            this.lbl1Position3Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl1Position3
            // 
            this.lbl1Position3.AutoSize = true;
            this.lbl1Position3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1Position3.ForeColor = System.Drawing.Color.White;
            this.lbl1Position3.Location = new System.Drawing.Point(18, 178);
            this.lbl1Position3.Name = "lbl1Position3";
            this.lbl1Position3.Size = new System.Drawing.Size(103, 33);
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
            this.lbl1Position2Value.Location = new System.Drawing.Point(88, 139);
            this.lbl1Position2Value.Name = "lbl1Position2Value";
            this.lbl1Position2Value.Size = new System.Drawing.Size(24, 33);
            this.lbl1Position2Value.TabIndex = 354;
            this.lbl1Position2Value.Text = ".";
            this.lbl1Position2Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl1Position2
            // 
            this.lbl1Position2.AutoSize = true;
            this.lbl1Position2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1Position2.ForeColor = System.Drawing.Color.White;
            this.lbl1Position2.Location = new System.Drawing.Point(18, 140);
            this.lbl1Position2.Name = "lbl1Position2";
            this.lbl1Position2.Size = new System.Drawing.Size(99, 33);
            this.lbl1Position2.TabIndex = 352;
            this.lbl1Position2.Text = "Coral:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Red;
            this.panel3.Controls.Add(this.label32);
            this.panel3.Location = new System.Drawing.Point(81, 126);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(351, 11);
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
            this.label32.Size = new System.Drawing.Size(55, 37);
            this.label32.TabIndex = 277;
            this.label32.Text = "00";
            this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // red1
            // 
            this.red1.BackColor = System.Drawing.Color.Transparent;
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
            this.red1.ForeColor = System.Drawing.Color.Transparent;
            this.red1.Location = new System.Drawing.Point(121, 154);
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
            this.lbl0Position0Value.Location = new System.Drawing.Point(177, 102);
            this.lbl0Position0Value.Name = "lbl0Position0Value";
            this.lbl0Position0Value.Size = new System.Drawing.Size(24, 33);
            this.lbl0Position0Value.TabIndex = 355;
            this.lbl0Position0Value.Text = ".";
            this.lbl0Position0Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl0Position12Value
            // 
            this.lbl0Position12Value.AutoSize = true;
            this.lbl0Position12Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl0Position12Value.ForeColor = System.Drawing.Color.White;
            this.lbl0Position12Value.Location = new System.Drawing.Point(126, 334);
            this.lbl0Position12Value.Name = "lbl0Position12Value";
            this.lbl0Position12Value.Size = new System.Drawing.Size(32, 33);
            this.lbl0Position12Value.TabIndex = 386;
            this.lbl0Position12Value.Text = "9";
            // 
            // lbl0Position12
            // 
            this.lbl0Position12.AutoSize = true;
            this.lbl0Position12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl0Position12.ForeColor = System.Drawing.Color.White;
            this.lbl0Position12.Location = new System.Drawing.Point(76, 333);
            this.lbl0Position12.Name = "lbl0Position12";
            this.lbl0Position12.Size = new System.Drawing.Size(90, 33);
            this.lbl0Position12.TabIndex = 385;
            this.lbl0Position12.Text = "Strat:";
            // 
            // lbl0Position11Value
            // 
            this.lbl0Position11Value.AutoSize = true;
            this.lbl0Position11Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl0Position11Value.ForeColor = System.Drawing.Color.White;
            this.lbl0Position11Value.Location = new System.Drawing.Point(180, 306);
            this.lbl0Position11Value.Name = "lbl0Position11Value";
            this.lbl0Position11Value.Size = new System.Drawing.Size(32, 33);
            this.lbl0Position11Value.TabIndex = 384;
            this.lbl0Position11Value.Text = "9";
            // 
            // lbl0Position11
            // 
            this.lbl0Position11.AutoSize = true;
            this.lbl0Position11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl0Position11.ForeColor = System.Drawing.Color.White;
            this.lbl0Position11.Location = new System.Drawing.Point(76, 306);
            this.lbl0Position11.Name = "lbl0Position11";
            this.lbl0Position11.Size = new System.Drawing.Size(159, 33);
            this.lbl0Position11.TabIndex = 383;
            this.lbl0Position11.Text = "End State:";
            // 
            // lbl0Position8Value
            // 
            this.lbl0Position8Value.AutoSize = true;
            this.lbl0Position8Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl0Position8Value.ForeColor = System.Drawing.Color.White;
            this.lbl0Position8Value.Location = new System.Drawing.Point(451, 230);
            this.lbl0Position8Value.Name = "lbl0Position8Value";
            this.lbl0Position8Value.Size = new System.Drawing.Size(32, 33);
            this.lbl0Position8Value.TabIndex = 372;
            this.lbl0Position8Value.Text = "9";
            // 
            // lbl0Position8
            // 
            this.lbl0Position8.AutoSize = true;
            this.lbl0Position8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl0Position8.ForeColor = System.Drawing.Color.White;
            this.lbl0Position8.Location = new System.Drawing.Point(387, 229);
            this.lbl0Position8.Name = "lbl0Position8";
            this.lbl0Position8.Size = new System.Drawing.Size(102, 33);
            this.lbl0Position8.TabIndex = 371;
            this.lbl0Position8.Text = "Avoid:";
            // 
            // lbl0Position7Value
            // 
            this.lbl0Position7Value.AutoSize = true;
            this.lbl0Position7Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl0Position7Value.ForeColor = System.Drawing.Color.White;
            this.lbl0Position7Value.Location = new System.Drawing.Point(343, 285);
            this.lbl0Position7Value.Name = "lbl0Position7Value";
            this.lbl0Position7Value.Size = new System.Drawing.Size(32, 33);
            this.lbl0Position7Value.TabIndex = 380;
            this.lbl0Position7Value.Text = "9";
            // 
            // lbl0Position7
            // 
            this.lbl0Position7.AutoSize = true;
            this.lbl0Position7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl0Position7.ForeColor = System.Drawing.Color.White;
            this.lbl0Position7.Location = new System.Drawing.Point(308, 284);
            this.lbl0Position7.Name = "lbl0Position7";
            this.lbl0Position7.Size = new System.Drawing.Size(62, 33);
            this.lbl0Position7.TabIndex = 379;
            this.lbl0Position7.Text = "Eff:";
            // 
            // lbl0Position5Value
            // 
            this.lbl0Position5Value.AutoSize = true;
            this.lbl0Position5Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl0Position5Value.ForeColor = System.Drawing.Color.White;
            this.lbl0Position5Value.Location = new System.Drawing.Point(249, 229);
            this.lbl0Position5Value.Name = "lbl0Position5Value";
            this.lbl0Position5Value.Size = new System.Drawing.Size(32, 33);
            this.lbl0Position5Value.TabIndex = 370;
            this.lbl0Position5Value.Text = "9";
            this.lbl0Position5Value.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl0Position5
            // 
            this.lbl0Position5.AutoSize = true;
            this.lbl0Position5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl0Position5.ForeColor = System.Drawing.Color.White;
            this.lbl0Position5.Location = new System.Drawing.Point(196, 228);
            this.lbl0Position5.Name = "lbl0Position5";
            this.lbl0Position5.Size = new System.Drawing.Size(72, 33);
            this.lbl0Position5.TabIndex = 369;
            this.lbl0Position5.Text = "Def:";
            this.lbl0Position5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl0Position4Value
            // 
            this.lbl0Position4Value.AutoSize = true;
            this.lbl0Position4Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl0Position4Value.ForeColor = System.Drawing.Color.White;
            this.lbl0Position4Value.Location = new System.Drawing.Point(352, 180);
            this.lbl0Position4Value.Name = "lbl0Position4Value";
            this.lbl0Position4Value.Size = new System.Drawing.Size(32, 33);
            this.lbl0Position4Value.TabIndex = 366;
            this.lbl0Position4Value.Text = "9";
            // 
            // lbl0Position4
            // 
            this.lbl0Position4.AutoSize = true;
            this.lbl0Position4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl0Position4.ForeColor = System.Drawing.Color.White;
            this.lbl0Position4.Location = new System.Drawing.Point(270, 179);
            this.lbl0Position4.Name = "lbl0Position4";
            this.lbl0Position4.Size = new System.Drawing.Size(131, 33);
            this.lbl0Position4.TabIndex = 365;
            this.lbl0Position4.Text = "Attempt:";
            // 
            // lbl0Position3Des
            // 
            this.lbl0Position3Des.AutoSize = true;
            this.lbl0Position3Des.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl0Position3Des.ForeColor = System.Drawing.Color.White;
            this.lbl0Position3Des.Location = new System.Drawing.Point(181, 181);
            this.lbl0Position3Des.Name = "lbl0Position3Des";
            this.lbl0Position3Des.Size = new System.Drawing.Size(87, 33);
            this.lbl0Position3Des.TabIndex = 364;
            this.lbl0Position3Des.Text = "Floor";
            // 
            // lbl0Position3Source
            // 
            this.lbl0Position3Source.AutoSize = true;
            this.lbl0Position3Source.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl0Position3Source.ForeColor = System.Drawing.Color.White;
            this.lbl0Position3Source.Location = new System.Drawing.Point(108, 181);
            this.lbl0Position3Source.Name = "lbl0Position3Source";
            this.lbl0Position3Source.Size = new System.Drawing.Size(87, 33);
            this.lbl0Position3Source.TabIndex = 378;
            this.lbl0Position3Source.Text = "Floor";
            // 
            // lbl0Position2Des
            // 
            this.lbl0Position2Des.AutoSize = true;
            this.lbl0Position2Des.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl0Position2Des.ForeColor = System.Drawing.Color.White;
            this.lbl0Position2Des.Location = new System.Drawing.Point(181, 143);
            this.lbl0Position2Des.Name = "lbl0Position2Des";
            this.lbl0Position2Des.Size = new System.Drawing.Size(87, 33);
            this.lbl0Position2Des.TabIndex = 363;
            this.lbl0Position2Des.Text = "Floor";
            // 
            // lbl0Position2Source
            // 
            this.lbl0Position2Source.AutoSize = true;
            this.lbl0Position2Source.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl0Position2Source.ForeColor = System.Drawing.Color.White;
            this.lbl0Position2Source.Location = new System.Drawing.Point(108, 143);
            this.lbl0Position2Source.Name = "lbl0Position2Source";
            this.lbl0Position2Source.Size = new System.Drawing.Size(112, 33);
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
            this.lbl0Position3Value.Location = new System.Drawing.Point(77, 181);
            this.lbl0Position3Value.Name = "lbl0Position3Value";
            this.lbl0Position3Value.Size = new System.Drawing.Size(24, 33);
            this.lbl0Position3Value.TabIndex = 359;
            this.lbl0Position3Value.Text = ".";
            this.lbl0Position3Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl0Position3
            // 
            this.lbl0Position3.AutoSize = true;
            this.lbl0Position3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl0Position3.ForeColor = System.Drawing.Color.White;
            this.lbl0Position3.Location = new System.Drawing.Point(7, 179);
            this.lbl0Position3.Name = "lbl0Position3";
            this.lbl0Position3.Size = new System.Drawing.Size(103, 33);
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
            this.lbl0Position2Value.Location = new System.Drawing.Point(77, 140);
            this.lbl0Position2Value.Name = "lbl0Position2Value";
            this.lbl0Position2Value.Size = new System.Drawing.Size(24, 33);
            this.lbl0Position2Value.TabIndex = 354;
            this.lbl0Position2Value.Text = ".";
            this.lbl0Position2Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl0Position2
            // 
            this.lbl0Position2.AutoSize = true;
            this.lbl0Position2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl0Position2.ForeColor = System.Drawing.Color.White;
            this.lbl0Position2.Location = new System.Drawing.Point(7, 141);
            this.lbl0Position2.Name = "lbl0Position2";
            this.lbl0Position2.Size = new System.Drawing.Size(99, 33);
            this.lbl0Position2.TabIndex = 352;
            this.lbl0Position2.Text = "Coral:";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Red;
            this.panel8.Controls.Add(this.label28);
            this.panel8.Location = new System.Drawing.Point(71, 135);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(346, 11);
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
            // bluePanel
            // 
            this.bluePanel.BackColor = System.Drawing.Color.Blue;
            this.bluePanel.Location = new System.Drawing.Point(19, 462);
            this.bluePanel.Name = "bluePanel";
            this.bluePanel.Size = new System.Drawing.Size(1485, 399);
            this.bluePanel.TabIndex = 348;
            this.bluePanel.Visible = false;
            // 
            // blue3
            // 
            this.blue3.BackColor = System.Drawing.Color.Transparent;
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
            this.blue3.ForeColor = System.Drawing.Color.Black;
            this.blue3.Location = new System.Drawing.Point(989, 513);
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
            this.lbl5Position0Value.Location = new System.Drawing.Point(144, 61);
            this.lbl5Position0Value.Name = "lbl5Position0Value";
            this.lbl5Position0Value.Size = new System.Drawing.Size(24, 33);
            this.lbl5Position0Value.TabIndex = 355;
            this.lbl5Position0Value.Text = ".";
            this.lbl5Position0Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl5Position0
            // 
            this.lbl5Position0.AutoSize = true;
            this.lbl5Position0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lbl5Position0.ForeColor = System.Drawing.Color.White;
            this.lbl5Position0.Location = new System.Drawing.Point(74, 65);
            this.lbl5Position0.Name = "lbl5Position0";
            this.lbl5Position0.Size = new System.Drawing.Size(71, 25);
            this.lbl5Position0.TabIndex = 341;
            this.lbl5Position0.Text = "Leave";
            // 
            // lbl5Position12Value
            // 
            this.lbl5Position12Value.AutoSize = true;
            this.lbl5Position12Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lbl5Position12Value.ForeColor = System.Drawing.Color.White;
            this.lbl5Position12Value.Location = new System.Drawing.Point(109, 278);
            this.lbl5Position12Value.Name = "lbl5Position12Value";
            this.lbl5Position12Value.Size = new System.Drawing.Size(24, 25);
            this.lbl5Position12Value.TabIndex = 386;
            this.lbl5Position12Value.Text = "9";
            // 
            // lbl5Position12
            // 
            this.lbl5Position12.AutoSize = true;
            this.lbl5Position12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lbl5Position12.ForeColor = System.Drawing.Color.White;
            this.lbl5Position12.Location = new System.Drawing.Point(59, 277);
            this.lbl5Position12.Name = "lbl5Position12";
            this.lbl5Position12.Size = new System.Drawing.Size(65, 25);
            this.lbl5Position12.TabIndex = 385;
            this.lbl5Position12.Text = "Strat:";
            // 
            // lbl5Position11Value
            // 
            this.lbl5Position11Value.AutoSize = true;
            this.lbl5Position11Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lbl5Position11Value.ForeColor = System.Drawing.Color.White;
            this.lbl5Position11Value.Location = new System.Drawing.Point(163, 250);
            this.lbl5Position11Value.Name = "lbl5Position11Value";
            this.lbl5Position11Value.Size = new System.Drawing.Size(24, 25);
            this.lbl5Position11Value.TabIndex = 384;
            this.lbl5Position11Value.Text = "9";
            // 
            // lbl5Position11
            // 
            this.lbl5Position11.AutoSize = true;
            this.lbl5Position11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lbl5Position11.ForeColor = System.Drawing.Color.White;
            this.lbl5Position11.Location = new System.Drawing.Point(59, 250);
            this.lbl5Position11.Name = "lbl5Position11";
            this.lbl5Position11.Size = new System.Drawing.Size(114, 25);
            this.lbl5Position11.TabIndex = 383;
            this.lbl5Position11.Text = "End State:";
            // 
            // lbl5Position8Value
            // 
            this.lbl5Position8Value.AutoSize = true;
            this.lbl5Position8Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lbl5Position8Value.ForeColor = System.Drawing.Color.White;
            this.lbl5Position8Value.Location = new System.Drawing.Point(444, 187);
            this.lbl5Position8Value.Name = "lbl5Position8Value";
            this.lbl5Position8Value.Size = new System.Drawing.Size(24, 25);
            this.lbl5Position8Value.TabIndex = 372;
            this.lbl5Position8Value.Text = "9";
            // 
            // lbl5Position8
            // 
            this.lbl5Position8.AutoSize = true;
            this.lbl5Position8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lbl5Position8.ForeColor = System.Drawing.Color.White;
            this.lbl5Position8.Location = new System.Drawing.Point(380, 186);
            this.lbl5Position8.Name = "lbl5Position8";
            this.lbl5Position8.Size = new System.Drawing.Size(74, 25);
            this.lbl5Position8.TabIndex = 371;
            this.lbl5Position8.Text = "Avoid:";
            // 
            // lbl5Position7Value
            // 
            this.lbl5Position7Value.AutoSize = true;
            this.lbl5Position7Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lbl5Position7Value.ForeColor = System.Drawing.Color.White;
            this.lbl5Position7Value.Location = new System.Drawing.Point(336, 242);
            this.lbl5Position7Value.Name = "lbl5Position7Value";
            this.lbl5Position7Value.Size = new System.Drawing.Size(24, 25);
            this.lbl5Position7Value.TabIndex = 380;
            this.lbl5Position7Value.Text = "9";
            // 
            // lbl5Position7
            // 
            this.lbl5Position7.AutoSize = true;
            this.lbl5Position7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lbl5Position7.ForeColor = System.Drawing.Color.White;
            this.lbl5Position7.Location = new System.Drawing.Point(301, 241);
            this.lbl5Position7.Name = "lbl5Position7";
            this.lbl5Position7.Size = new System.Drawing.Size(45, 25);
            this.lbl5Position7.TabIndex = 379;
            this.lbl5Position7.Text = "Eff:";
            // 
            // lbl5Position5Value
            // 
            this.lbl5Position5Value.AutoSize = true;
            this.lbl5Position5Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lbl5Position5Value.ForeColor = System.Drawing.Color.White;
            this.lbl5Position5Value.Location = new System.Drawing.Point(242, 186);
            this.lbl5Position5Value.Name = "lbl5Position5Value";
            this.lbl5Position5Value.Size = new System.Drawing.Size(24, 25);
            this.lbl5Position5Value.TabIndex = 370;
            this.lbl5Position5Value.Text = "9";
            this.lbl5Position5Value.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl5Position5
            // 
            this.lbl5Position5.AutoSize = true;
            this.lbl5Position5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lbl5Position5.ForeColor = System.Drawing.Color.White;
            this.lbl5Position5.Location = new System.Drawing.Point(189, 185);
            this.lbl5Position5.Name = "lbl5Position5";
            this.lbl5Position5.Size = new System.Drawing.Size(52, 25);
            this.lbl5Position5.TabIndex = 369;
            this.lbl5Position5.Text = "Def:";
            this.lbl5Position5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl5Position4Value
            // 
            this.lbl5Position4Value.AutoSize = true;
            this.lbl5Position4Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lbl5Position4Value.ForeColor = System.Drawing.Color.White;
            this.lbl5Position4Value.Location = new System.Drawing.Point(345, 137);
            this.lbl5Position4Value.Name = "lbl5Position4Value";
            this.lbl5Position4Value.Size = new System.Drawing.Size(24, 25);
            this.lbl5Position4Value.TabIndex = 366;
            this.lbl5Position4Value.Text = "9";
            // 
            // lbl5Position4
            // 
            this.lbl5Position4.AutoSize = true;
            this.lbl5Position4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lbl5Position4.ForeColor = System.Drawing.Color.White;
            this.lbl5Position4.Location = new System.Drawing.Point(263, 136);
            this.lbl5Position4.Name = "lbl5Position4";
            this.lbl5Position4.Size = new System.Drawing.Size(93, 25);
            this.lbl5Position4.TabIndex = 365;
            this.lbl5Position4.Text = "Attempt:";
            // 
            // lbl5Position3Des
            // 
            this.lbl5Position3Des.AutoSize = true;
            this.lbl5Position3Des.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lbl5Position3Des.ForeColor = System.Drawing.Color.White;
            this.lbl5Position3Des.Location = new System.Drawing.Point(181, 162);
            this.lbl5Position3Des.Name = "lbl5Position3Des";
            this.lbl5Position3Des.Size = new System.Drawing.Size(61, 25);
            this.lbl5Position3Des.TabIndex = 364;
            this.lbl5Position3Des.Text = "Floor";
            // 
            // lbl5Position3Source
            // 
            this.lbl5Position3Source.AutoSize = true;
            this.lbl5Position3Source.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lbl5Position3Source.ForeColor = System.Drawing.Color.White;
            this.lbl5Position3Source.Location = new System.Drawing.Point(108, 162);
            this.lbl5Position3Source.Name = "lbl5Position3Source";
            this.lbl5Position3Source.Size = new System.Drawing.Size(61, 25);
            this.lbl5Position3Source.TabIndex = 378;
            this.lbl5Position3Source.Text = "Floor";
            // 
            // lbl5Position2Des
            // 
            this.lbl5Position2Des.AutoSize = true;
            this.lbl5Position2Des.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lbl5Position2Des.ForeColor = System.Drawing.Color.White;
            this.lbl5Position2Des.Location = new System.Drawing.Point(181, 124);
            this.lbl5Position2Des.Name = "lbl5Position2Des";
            this.lbl5Position2Des.Size = new System.Drawing.Size(61, 25);
            this.lbl5Position2Des.TabIndex = 363;
            this.lbl5Position2Des.Text = "Floor";
            // 
            // lbl5Position2Source
            // 
            this.lbl5Position2Source.AutoSize = true;
            this.lbl5Position2Source.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lbl5Position2Source.ForeColor = System.Drawing.Color.White;
            this.lbl5Position2Source.Location = new System.Drawing.Point(108, 124);
            this.lbl5Position2Source.Name = "lbl5Position2Source";
            this.lbl5Position2Source.Size = new System.Drawing.Size(80, 25);
            this.lbl5Position2Source.TabIndex = 377;
            this.lbl5Position2Source.Text = "Station";
            // 
            // lbl5Position1
            // 
            this.lbl5Position1.AutoSize = true;
            this.lbl5Position1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lbl5Position1.ForeColor = System.Drawing.Color.White;
            this.lbl5Position1.Location = new System.Drawing.Point(227, 66);
            this.lbl5Position1.Name = "lbl5Position1";
            this.lbl5Position1.Size = new System.Drawing.Size(108, 25);
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
            this.lbl5Position3Value.Location = new System.Drawing.Point(77, 158);
            this.lbl5Position3Value.Name = "lbl5Position3Value";
            this.lbl5Position3Value.Size = new System.Drawing.Size(24, 33);
            this.lbl5Position3Value.TabIndex = 359;
            this.lbl5Position3Value.Text = ".";
            this.lbl5Position3Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl5Position3
            // 
            this.lbl5Position3.AutoSize = true;
            this.lbl5Position3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lbl5Position3.ForeColor = System.Drawing.Color.White;
            this.lbl5Position3.Location = new System.Drawing.Point(7, 160);
            this.lbl5Position3.Name = "lbl5Position3";
            this.lbl5Position3.Size = new System.Drawing.Size(75, 25);
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
            this.lbl5Position2Value.Location = new System.Drawing.Point(77, 117);
            this.lbl5Position2Value.Name = "lbl5Position2Value";
            this.lbl5Position2Value.Size = new System.Drawing.Size(24, 33);
            this.lbl5Position2Value.TabIndex = 354;
            this.lbl5Position2Value.Text = ".";
            this.lbl5Position2Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl5Position2
            // 
            this.lbl5Position2.AutoSize = true;
            this.lbl5Position2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lbl5Position2.ForeColor = System.Drawing.Color.White;
            this.lbl5Position2.Location = new System.Drawing.Point(7, 122);
            this.lbl5Position2.Name = "lbl5Position2";
            this.lbl5Position2.Size = new System.Drawing.Size(71, 25);
            this.lbl5Position2.TabIndex = 352;
            this.lbl5Position2.Text = "Coral:";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Blue;
            this.panel10.Controls.Add(this.label96);
            this.panel10.Location = new System.Drawing.Point(47, 94);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(356, 11);
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
            this.label96.Size = new System.Drawing.Size(55, 37);
            this.label96.TabIndex = 277;
            this.label96.Text = "00";
            this.label96.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // blue2
            // 
            this.blue2.BackColor = System.Drawing.Color.Transparent;
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
            this.blue2.ForeColor = System.Drawing.Color.Transparent;
            this.blue2.Location = new System.Drawing.Point(530, 351);
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
            this.lbl4Position0Value.Location = new System.Drawing.Point(191, 63);
            this.lbl4Position0Value.Name = "lbl4Position0Value";
            this.lbl4Position0Value.Size = new System.Drawing.Size(24, 33);
            this.lbl4Position0Value.TabIndex = 355;
            this.lbl4Position0Value.Text = ".";
            this.lbl4Position0Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl4Position0
            // 
            this.lbl4Position0.AutoSize = true;
            this.lbl4Position0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4Position0.ForeColor = System.Drawing.Color.White;
            this.lbl4Position0.Location = new System.Drawing.Point(121, 63);
            this.lbl4Position0.Name = "lbl4Position0";
            this.lbl4Position0.Size = new System.Drawing.Size(99, 33);
            this.lbl4Position0.TabIndex = 341;
            this.lbl4Position0.Text = "Leave";
            // 
            // lbl4Position12Value
            // 
            this.lbl4Position12Value.AutoSize = true;
            this.lbl4Position12Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4Position12Value.ForeColor = System.Drawing.Color.White;
            this.lbl4Position12Value.Location = new System.Drawing.Point(131, 289);
            this.lbl4Position12Value.Name = "lbl4Position12Value";
            this.lbl4Position12Value.Size = new System.Drawing.Size(32, 33);
            this.lbl4Position12Value.TabIndex = 386;
            this.lbl4Position12Value.Text = "9";
            // 
            // lbl4Position12
            // 
            this.lbl4Position12.AutoSize = true;
            this.lbl4Position12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4Position12.ForeColor = System.Drawing.Color.White;
            this.lbl4Position12.Location = new System.Drawing.Point(81, 288);
            this.lbl4Position12.Name = "lbl4Position12";
            this.lbl4Position12.Size = new System.Drawing.Size(90, 33);
            this.lbl4Position12.TabIndex = 385;
            this.lbl4Position12.Text = "Strat:";
            // 
            // lbl4Position11Value
            // 
            this.lbl4Position11Value.AutoSize = true;
            this.lbl4Position11Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4Position11Value.ForeColor = System.Drawing.Color.White;
            this.lbl4Position11Value.Location = new System.Drawing.Point(185, 261);
            this.lbl4Position11Value.Name = "lbl4Position11Value";
            this.lbl4Position11Value.Size = new System.Drawing.Size(32, 33);
            this.lbl4Position11Value.TabIndex = 384;
            this.lbl4Position11Value.Text = "9";
            // 
            // lbl4Position11
            // 
            this.lbl4Position11.AutoSize = true;
            this.lbl4Position11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4Position11.ForeColor = System.Drawing.Color.White;
            this.lbl4Position11.Location = new System.Drawing.Point(81, 261);
            this.lbl4Position11.Name = "lbl4Position11";
            this.lbl4Position11.Size = new System.Drawing.Size(159, 33);
            this.lbl4Position11.TabIndex = 383;
            this.lbl4Position11.Text = "End State:";
            // 
            // lbl4Position8Value
            // 
            this.lbl4Position8Value.AutoSize = true;
            this.lbl4Position8Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4Position8Value.ForeColor = System.Drawing.Color.White;
            this.lbl4Position8Value.Location = new System.Drawing.Point(470, 205);
            this.lbl4Position8Value.Name = "lbl4Position8Value";
            this.lbl4Position8Value.Size = new System.Drawing.Size(32, 33);
            this.lbl4Position8Value.TabIndex = 372;
            this.lbl4Position8Value.Text = "9";
            // 
            // lbl4Position8
            // 
            this.lbl4Position8.AutoSize = true;
            this.lbl4Position8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4Position8.ForeColor = System.Drawing.Color.White;
            this.lbl4Position8.Location = new System.Drawing.Point(406, 204);
            this.lbl4Position8.Name = "lbl4Position8";
            this.lbl4Position8.Size = new System.Drawing.Size(102, 33);
            this.lbl4Position8.TabIndex = 371;
            this.lbl4Position8.Text = "Avoid:";
            // 
            // lbl4Position7Value
            // 
            this.lbl4Position7Value.AutoSize = true;
            this.lbl4Position7Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4Position7Value.ForeColor = System.Drawing.Color.White;
            this.lbl4Position7Value.Location = new System.Drawing.Point(362, 260);
            this.lbl4Position7Value.Name = "lbl4Position7Value";
            this.lbl4Position7Value.Size = new System.Drawing.Size(32, 33);
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
            this.lbl4Position7.Size = new System.Drawing.Size(62, 33);
            this.lbl4Position7.TabIndex = 379;
            this.lbl4Position7.Text = "Eff:";
            // 
            // lbl4Position5Value
            // 
            this.lbl4Position5Value.AutoSize = true;
            this.lbl4Position5Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4Position5Value.ForeColor = System.Drawing.Color.White;
            this.lbl4Position5Value.Location = new System.Drawing.Point(268, 204);
            this.lbl4Position5Value.Name = "lbl4Position5Value";
            this.lbl4Position5Value.Size = new System.Drawing.Size(32, 33);
            this.lbl4Position5Value.TabIndex = 370;
            this.lbl4Position5Value.Text = "9";
            this.lbl4Position5Value.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl4Position5
            // 
            this.lbl4Position5.AutoSize = true;
            this.lbl4Position5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4Position5.ForeColor = System.Drawing.Color.White;
            this.lbl4Position5.Location = new System.Drawing.Point(215, 203);
            this.lbl4Position5.Name = "lbl4Position5";
            this.lbl4Position5.Size = new System.Drawing.Size(72, 33);
            this.lbl4Position5.TabIndex = 369;
            this.lbl4Position5.Text = "Def:";
            this.lbl4Position5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl4Position4Value
            // 
            this.lbl4Position4Value.AutoSize = true;
            this.lbl4Position4Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4Position4Value.ForeColor = System.Drawing.Color.White;
            this.lbl4Position4Value.Location = new System.Drawing.Point(371, 155);
            this.lbl4Position4Value.Name = "lbl4Position4Value";
            this.lbl4Position4Value.Size = new System.Drawing.Size(32, 33);
            this.lbl4Position4Value.TabIndex = 366;
            this.lbl4Position4Value.Text = "9";
            // 
            // lbl4Position4
            // 
            this.lbl4Position4.AutoSize = true;
            this.lbl4Position4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4Position4.ForeColor = System.Drawing.Color.White;
            this.lbl4Position4.Location = new System.Drawing.Point(289, 154);
            this.lbl4Position4.Name = "lbl4Position4";
            this.lbl4Position4.Size = new System.Drawing.Size(131, 33);
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
            this.lbl4Position3Des.Size = new System.Drawing.Size(87, 33);
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
            this.lbl4Position3Source.Size = new System.Drawing.Size(87, 33);
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
            this.lbl4Position2Des.Size = new System.Drawing.Size(87, 33);
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
            this.lbl4Position2Source.Size = new System.Drawing.Size(112, 33);
            this.lbl4Position2Source.TabIndex = 377;
            this.lbl4Position2Source.Text = "Station";
            // 
            // lbl4Position1
            // 
            this.lbl4Position1.AutoSize = true;
            this.lbl4Position1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4Position1.ForeColor = System.Drawing.Color.White;
            this.lbl4Position1.Location = new System.Drawing.Point(250, 64);
            this.lbl4Position1.Name = "lbl4Position1";
            this.lbl4Position1.Size = new System.Drawing.Size(153, 33);
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
            this.lbl4Position3Value.Size = new System.Drawing.Size(24, 33);
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
            this.lbl4Position3.Size = new System.Drawing.Size(103, 33);
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
            this.lbl4Position2Value.Size = new System.Drawing.Size(24, 33);
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
            this.lbl4Position2.Size = new System.Drawing.Size(99, 33);
            this.lbl4Position2.TabIndex = 352;
            this.lbl4Position2.Text = "Coral:";
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.Blue;
            this.panel14.Controls.Add(this.label129);
            this.panel14.Location = new System.Drawing.Point(87, 94);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(345, 11);
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
            this.label129.Size = new System.Drawing.Size(55, 37);
            this.label129.TabIndex = 277;
            this.label129.Text = "00";
            this.label129.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // blue1
            // 
            this.blue1.BackColor = System.Drawing.Color.Transparent;
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
            this.blue1.ForeColor = System.Drawing.Color.Transparent;
            this.blue1.Location = new System.Drawing.Point(122, 513);
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
            this.lbl3Position0Value.Location = new System.Drawing.Point(171, 55);
            this.lbl3Position0Value.Name = "lbl3Position0Value";
            this.lbl3Position0Value.Size = new System.Drawing.Size(24, 33);
            this.lbl3Position0Value.TabIndex = 355;
            this.lbl3Position0Value.Text = ".";
            this.lbl3Position0Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl3Position0
            // 
            this.lbl3Position0.AutoSize = true;
            this.lbl3Position0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3Position0.ForeColor = System.Drawing.Color.White;
            this.lbl3Position0.Location = new System.Drawing.Point(101, 55);
            this.lbl3Position0.Name = "lbl3Position0";
            this.lbl3Position0.Size = new System.Drawing.Size(99, 33);
            this.lbl3Position0.TabIndex = 341;
            this.lbl3Position0.Text = "Leave";
            // 
            // lbl3Position12Value
            // 
            this.lbl3Position12Value.AutoSize = true;
            this.lbl3Position12Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3Position12Value.ForeColor = System.Drawing.Color.White;
            this.lbl3Position12Value.Location = new System.Drawing.Point(125, 289);
            this.lbl3Position12Value.Name = "lbl3Position12Value";
            this.lbl3Position12Value.Size = new System.Drawing.Size(32, 33);
            this.lbl3Position12Value.TabIndex = 386;
            this.lbl3Position12Value.Text = "9";
            // 
            // lbl3Position12
            // 
            this.lbl3Position12.AutoSize = true;
            this.lbl3Position12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3Position12.ForeColor = System.Drawing.Color.White;
            this.lbl3Position12.Location = new System.Drawing.Point(75, 288);
            this.lbl3Position12.Name = "lbl3Position12";
            this.lbl3Position12.Size = new System.Drawing.Size(90, 33);
            this.lbl3Position12.TabIndex = 385;
            this.lbl3Position12.Text = "Strat:";
            // 
            // lbl3Position11Value
            // 
            this.lbl3Position11Value.AutoSize = true;
            this.lbl3Position11Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3Position11Value.ForeColor = System.Drawing.Color.White;
            this.lbl3Position11Value.Location = new System.Drawing.Point(179, 261);
            this.lbl3Position11Value.Name = "lbl3Position11Value";
            this.lbl3Position11Value.Size = new System.Drawing.Size(32, 33);
            this.lbl3Position11Value.TabIndex = 384;
            this.lbl3Position11Value.Text = "9";
            // 
            // lbl3Position11
            // 
            this.lbl3Position11.AutoSize = true;
            this.lbl3Position11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3Position11.ForeColor = System.Drawing.Color.White;
            this.lbl3Position11.Location = new System.Drawing.Point(75, 261);
            this.lbl3Position11.Name = "lbl3Position11";
            this.lbl3Position11.Size = new System.Drawing.Size(159, 33);
            this.lbl3Position11.TabIndex = 383;
            this.lbl3Position11.Text = "End State:";
            // 
            // lbl3Position8Value
            // 
            this.lbl3Position8Value.AutoSize = true;
            this.lbl3Position8Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3Position8Value.ForeColor = System.Drawing.Color.White;
            this.lbl3Position8Value.Location = new System.Drawing.Point(454, 186);
            this.lbl3Position8Value.Name = "lbl3Position8Value";
            this.lbl3Position8Value.Size = new System.Drawing.Size(32, 33);
            this.lbl3Position8Value.TabIndex = 372;
            this.lbl3Position8Value.Text = "9";
            // 
            // lbl3Position8
            // 
            this.lbl3Position8.AutoSize = true;
            this.lbl3Position8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3Position8.ForeColor = System.Drawing.Color.White;
            this.lbl3Position8.Location = new System.Drawing.Point(390, 185);
            this.lbl3Position8.Name = "lbl3Position8";
            this.lbl3Position8.Size = new System.Drawing.Size(102, 33);
            this.lbl3Position8.TabIndex = 371;
            this.lbl3Position8.Text = "Avoid:";
            // 
            // lbl3Position7Value
            // 
            this.lbl3Position7Value.AutoSize = true;
            this.lbl3Position7Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3Position7Value.ForeColor = System.Drawing.Color.White;
            this.lbl3Position7Value.Location = new System.Drawing.Point(346, 241);
            this.lbl3Position7Value.Name = "lbl3Position7Value";
            this.lbl3Position7Value.Size = new System.Drawing.Size(32, 33);
            this.lbl3Position7Value.TabIndex = 380;
            this.lbl3Position7Value.Text = "9";
            // 
            // lbl3Position7
            // 
            this.lbl3Position7.AutoSize = true;
            this.lbl3Position7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3Position7.ForeColor = System.Drawing.Color.White;
            this.lbl3Position7.Location = new System.Drawing.Point(311, 240);
            this.lbl3Position7.Name = "lbl3Position7";
            this.lbl3Position7.Size = new System.Drawing.Size(62, 33);
            this.lbl3Position7.TabIndex = 379;
            this.lbl3Position7.Text = "Eff:";
            // 
            // lbl3Position5Value
            // 
            this.lbl3Position5Value.AutoSize = true;
            this.lbl3Position5Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3Position5Value.ForeColor = System.Drawing.Color.White;
            this.lbl3Position5Value.Location = new System.Drawing.Point(252, 185);
            this.lbl3Position5Value.Name = "lbl3Position5Value";
            this.lbl3Position5Value.Size = new System.Drawing.Size(32, 33);
            this.lbl3Position5Value.TabIndex = 370;
            this.lbl3Position5Value.Text = "9";
            this.lbl3Position5Value.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl3Position5
            // 
            this.lbl3Position5.AutoSize = true;
            this.lbl3Position5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3Position5.ForeColor = System.Drawing.Color.White;
            this.lbl3Position5.Location = new System.Drawing.Point(199, 184);
            this.lbl3Position5.Name = "lbl3Position5";
            this.lbl3Position5.Size = new System.Drawing.Size(72, 33);
            this.lbl3Position5.TabIndex = 369;
            this.lbl3Position5.Text = "Def:";
            this.lbl3Position5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl3Position4Value
            // 
            this.lbl3Position4Value.AutoSize = true;
            this.lbl3Position4Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3Position4Value.ForeColor = System.Drawing.Color.White;
            this.lbl3Position4Value.Location = new System.Drawing.Point(355, 136);
            this.lbl3Position4Value.Name = "lbl3Position4Value";
            this.lbl3Position4Value.Size = new System.Drawing.Size(32, 33);
            this.lbl3Position4Value.TabIndex = 366;
            this.lbl3Position4Value.Text = "9";
            // 
            // lbl3Position4
            // 
            this.lbl3Position4.AutoSize = true;
            this.lbl3Position4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3Position4.ForeColor = System.Drawing.Color.White;
            this.lbl3Position4.Location = new System.Drawing.Point(273, 135);
            this.lbl3Position4.Name = "lbl3Position4";
            this.lbl3Position4.Size = new System.Drawing.Size(131, 33);
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
            this.lbl3Position3Des.Size = new System.Drawing.Size(87, 33);
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
            this.lbl3Position3Source.Size = new System.Drawing.Size(87, 33);
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
            this.lbl3Position2Des.Size = new System.Drawing.Size(87, 33);
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
            this.lbl3Position2Source.Size = new System.Drawing.Size(112, 33);
            this.lbl3Position2Source.TabIndex = 377;
            this.lbl3Position2Source.Text = "Station";
            // 
            // lbl3Position1
            // 
            this.lbl3Position1.AutoSize = true;
            this.lbl3Position1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3Position1.ForeColor = System.Drawing.Color.White;
            this.lbl3Position1.Location = new System.Drawing.Point(250, 56);
            this.lbl3Position1.Name = "lbl3Position1";
            this.lbl3Position1.Size = new System.Drawing.Size(153, 33);
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
            this.lbl3Position3Value.Size = new System.Drawing.Size(24, 33);
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
            this.lbl3Position3.Size = new System.Drawing.Size(103, 33);
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
            this.lbl3Position2Value.Size = new System.Drawing.Size(24, 33);
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
            this.lbl3Position2.Size = new System.Drawing.Size(99, 33);
            this.lbl3Position2.TabIndex = 352;
            this.lbl3Position2.Text = "Coral:";
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.Color.Blue;
            this.panel18.Controls.Add(this.label161);
            this.panel18.Location = new System.Drawing.Point(70, 88);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(346, 11);
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
            this.label161.Size = new System.Drawing.Size(55, 37);
            this.label161.TabIndex = 277;
            this.label161.Text = "00";
            this.label161.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.lblRedScore.Size = new System.Drawing.Size(32, 33);
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
            this.lblBlueScore.Size = new System.Drawing.Size(32, 33);
            this.lblBlueScore.TabIndex = 388;
            this.lblBlueScore.Text = "0";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.BackgroundImage = global::ScoutingCodeRedo.Properties.Resources.Hexagons;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Controls.Add(this.red3);
            this.panel5.Controls.Add(this.blue3);
            this.panel5.Controls.Add(this.blue2);
            this.panel5.Controls.Add(this.red2);
            this.panel5.Controls.Add(this.blue1);
            this.panel5.Controls.Add(this.red1);
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1578, 889);
            this.panel5.TabIndex = 392;
            // 
            // ScouterBoxes2
            // 
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.lblBlueScore);
            this.Controls.Add(this.lblRedScore);
            this.Controls.Add(this.panel5);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ScouterBoxes2";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Black;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.red3.ResumeLayout(false);
            this.red3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.red2.ResumeLayout(false);
            this.red2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.red1.ResumeLayout(false);
            this.red1.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.blue3.ResumeLayout(false);
            this.blue3.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.blue2.ResumeLayout(false);
            this.blue2.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.blue1.ResumeLayout(false);
            this.blue1.PerformLayout();
            this.panel18.ResumeLayout(false);
            this.panel18.PerformLayout();
            this.panel5.ResumeLayout(false);
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
        private Label lblRedScore;
        private Label lblBlueScore;
        private Panel panel5;
    }
}
