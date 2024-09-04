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
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel32 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl2Position6Value = new System.Windows.Forms.Label();
            this.lbl2Position10Value = new System.Windows.Forms.Label();
            this.lbl2Position10 = new System.Windows.Forms.Label();
            this.lbl2Position7Value = new System.Windows.Forms.Label();
            this.lbl2Position9Value = new System.Windows.Forms.Label();
            this.lbl2Position9 = new System.Windows.Forms.Label();
            this.lbl2Position7 = new System.Windows.Forms.Label();
            this.lbl2Position2Flag = new System.Windows.Forms.Label();
            this.lbl2Position0Flag = new System.Windows.Forms.Label();
            this.lbl2Position4Value = new System.Windows.Forms.Label();
            this.lbl2Position5Value = new System.Windows.Forms.Label();
            this.lbl2Position6 = new System.Windows.Forms.Label();
            this.lbl2Position2Value = new System.Windows.Forms.Label();
            this.lbl2Position1Value = new System.Windows.Forms.Label();
            this.lbl2Position5 = new System.Windows.Forms.Label();
            this.lbl2Position4 = new System.Windows.Forms.Label();
            this.lbl2Position8Value = new System.Windows.Forms.Label();
            this.lbl2Position0 = new System.Windows.Forms.Label();
            this.lbl2Position3Value = new System.Windows.Forms.Label();
            this.lbl2Position3 = new System.Windows.Forms.Label();
            this.lbl2Position8 = new System.Windows.Forms.Label();
            this.lbl2Position1 = new System.Windows.Forms.Label();
            this.lbl2Position2 = new System.Windows.Forms.Label();
            this.lbl2Position0Value = new System.Windows.Forms.Label();
            this.panel35 = new System.Windows.Forms.Panel();
            this.label106 = new System.Windows.Forms.Label();
            this.panel36 = new System.Windows.Forms.Panel();
            this.panel21 = new System.Windows.Forms.Panel();
            this.label23 = new System.Windows.Forms.Label();
            this.lbl1Position6Value = new System.Windows.Forms.Label();
            this.lbl1Position10Value = new System.Windows.Forms.Label();
            this.lbl1Position10 = new System.Windows.Forms.Label();
            this.lbl1Position7Value = new System.Windows.Forms.Label();
            this.lbl1Position9Value = new System.Windows.Forms.Label();
            this.lbl1Position9 = new System.Windows.Forms.Label();
            this.lbl1Position7 = new System.Windows.Forms.Label();
            this.lbl1Position2Flag = new System.Windows.Forms.Label();
            this.lbl1Position0Flag = new System.Windows.Forms.Label();
            this.lbl1Position4Value = new System.Windows.Forms.Label();
            this.lbl1Position5Value = new System.Windows.Forms.Label();
            this.lbl1Position6 = new System.Windows.Forms.Label();
            this.lbl1Position2Value = new System.Windows.Forms.Label();
            this.lbl1Position1Value = new System.Windows.Forms.Label();
            this.lbl1Position5 = new System.Windows.Forms.Label();
            this.lbl1Position4 = new System.Windows.Forms.Label();
            this.lbl1Position8Value = new System.Windows.Forms.Label();
            this.lbl1Position0 = new System.Windows.Forms.Label();
            this.lbl1Position3Value = new System.Windows.Forms.Label();
            this.lbl1Position3 = new System.Windows.Forms.Label();
            this.lbl1Position8 = new System.Windows.Forms.Label();
            this.lbl1Position1 = new System.Windows.Forms.Label();
            this.lbl1Position2 = new System.Windows.Forms.Label();
            this.lbl1Position0Value = new System.Windows.Forms.Label();
            this.panel39 = new System.Windows.Forms.Panel();
            this.label111 = new System.Windows.Forms.Label();
            this.lbl0Position6Value2 = new System.Windows.Forms.Label();
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.label60 = new System.Windows.Forms.Label();
            this.panel16 = new System.Windows.Forms.Panel();
            this.label61 = new System.Windows.Forms.Label();
            this.lbl5Position6Value = new System.Windows.Forms.Label();
            this.lbl5Position10Value = new System.Windows.Forms.Label();
            this.lbl5Position10 = new System.Windows.Forms.Label();
            this.lbl5Position7Value = new System.Windows.Forms.Label();
            this.lbl5Position9Value = new System.Windows.Forms.Label();
            this.lbl5Position9 = new System.Windows.Forms.Label();
            this.lbl5Position7 = new System.Windows.Forms.Label();
            this.lbl5Position2Flag = new System.Windows.Forms.Label();
            this.lbl5Position0Flag = new System.Windows.Forms.Label();
            this.lbl5Position4Value = new System.Windows.Forms.Label();
            this.lbl5Position5Value = new System.Windows.Forms.Label();
            this.lbl5Position6 = new System.Windows.Forms.Label();
            this.lbl5Position2Value = new System.Windows.Forms.Label();
            this.lbl5Position1Value = new System.Windows.Forms.Label();
            this.lbl5Position5 = new System.Windows.Forms.Label();
            this.lbl5Position4 = new System.Windows.Forms.Label();
            this.lbl5Position8Value = new System.Windows.Forms.Label();
            this.lbl5Position0 = new System.Windows.Forms.Label();
            this.lbl5Position3Value = new System.Windows.Forms.Label();
            this.lbl5Position3 = new System.Windows.Forms.Label();
            this.lbl5Position8 = new System.Windows.Forms.Label();
            this.lbl5Position1 = new System.Windows.Forms.Label();
            this.lbl5Position2 = new System.Windows.Forms.Label();
            this.lbl5Position0Value = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label33 = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.label34 = new System.Windows.Forms.Label();
            this.lbl4Position6Value = new System.Windows.Forms.Label();
            this.lbl4Position10Value = new System.Windows.Forms.Label();
            this.lbl4Position10 = new System.Windows.Forms.Label();
            this.lbl4Position7Value = new System.Windows.Forms.Label();
            this.lbl4Position9Value = new System.Windows.Forms.Label();
            this.lbl4Position9 = new System.Windows.Forms.Label();
            this.lbl4Position7 = new System.Windows.Forms.Label();
            this.lbl4Position2Flag = new System.Windows.Forms.Label();
            this.lbl4Position0Flag = new System.Windows.Forms.Label();
            this.lbl4Position4Value = new System.Windows.Forms.Label();
            this.lbl4Position5Value = new System.Windows.Forms.Label();
            this.lbl4Position6 = new System.Windows.Forms.Label();
            this.lbl4Position2Value = new System.Windows.Forms.Label();
            this.lbl4Position1Value = new System.Windows.Forms.Label();
            this.lbl4Position5 = new System.Windows.Forms.Label();
            this.lbl4Position4 = new System.Windows.Forms.Label();
            this.lbl4Position8Value = new System.Windows.Forms.Label();
            this.lbl4Position0 = new System.Windows.Forms.Label();
            this.lbl4Position3Value = new System.Windows.Forms.Label();
            this.lbl4Position3 = new System.Windows.Forms.Label();
            this.lbl4Position8 = new System.Windows.Forms.Label();
            this.lbl4Position1 = new System.Windows.Forms.Label();
            this.lbl4Position2 = new System.Windows.Forms.Label();
            this.lbl4Position0Value = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label54 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label79 = new System.Windows.Forms.Label();
            this.panel23 = new System.Windows.Forms.Panel();
            this.label32 = new System.Windows.Forms.Label();
            this.lbl3Position6Value = new System.Windows.Forms.Label();
            this.lbl3Position10Value = new System.Windows.Forms.Label();
            this.lbl3Position10 = new System.Windows.Forms.Label();
            this.lbl3Position7Value = new System.Windows.Forms.Label();
            this.lbl3Position9Value = new System.Windows.Forms.Label();
            this.lbl3Position9 = new System.Windows.Forms.Label();
            this.lbl3Position7 = new System.Windows.Forms.Label();
            this.lbl3Position2Flag = new System.Windows.Forms.Label();
            this.lbl3Position0Flag = new System.Windows.Forms.Label();
            this.lbl3Position4Value = new System.Windows.Forms.Label();
            this.lbl3Position5Value = new System.Windows.Forms.Label();
            this.lbl3Position6 = new System.Windows.Forms.Label();
            this.lbl3Position2Value = new System.Windows.Forms.Label();
            this.lbl3Position1Value = new System.Windows.Forms.Label();
            this.lbl3Position5 = new System.Windows.Forms.Label();
            this.lbl3Position4 = new System.Windows.Forms.Label();
            this.lbl3Position8Value = new System.Windows.Forms.Label();
            this.lbl3Position0 = new System.Windows.Forms.Label();
            this.lbl3Position3Value = new System.Windows.Forms.Label();
            this.lbl3Position3 = new System.Windows.Forms.Label();
            this.lbl3Position8 = new System.Windows.Forms.Label();
            this.lbl3Position1 = new System.Windows.Forms.Label();
            this.lbl3Position2 = new System.Windows.Forms.Label();
            this.lbl3Position0Value = new System.Windows.Forms.Label();
            this.panel30 = new System.Windows.Forms.Panel();
            this.label89 = new System.Windows.Forms.Label();
            this.updateScreen = new System.Windows.Forms.Timer(this.components);
            this.panel31.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel32.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel35.SuspendLayout();
            this.panel36.SuspendLayout();
            this.panel21.SuspendLayout();
            this.panel39.SuspendLayout();
            this.panel41.SuspendLayout();
            this.team1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel23.SuspendLayout();
            this.panel30.SuspendLayout();
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
            // panel32
            // 
            this.panel32.BackColor = System.Drawing.Color.Black;
            this.panel32.Controls.Add(this.panel9);
            this.panel32.Controls.Add(this.lbl2Position6Value);
            this.panel32.Controls.Add(this.lbl2Position10Value);
            this.panel32.Controls.Add(this.lbl2Position10);
            this.panel32.Controls.Add(this.lbl2Position7Value);
            this.panel32.Controls.Add(this.lbl2Position9Value);
            this.panel32.Controls.Add(this.lbl2Position9);
            this.panel32.Controls.Add(this.lbl2Position7);
            this.panel32.Controls.Add(this.lbl2Position2Flag);
            this.panel32.Controls.Add(this.lbl2Position0Flag);
            this.panel32.Controls.Add(this.lbl2Position4Value);
            this.panel32.Controls.Add(this.lbl2Position5Value);
            this.panel32.Controls.Add(this.lbl2Position6);
            this.panel32.Controls.Add(this.lbl2Position2Value);
            this.panel32.Controls.Add(this.lbl2Position1Value);
            this.panel32.Controls.Add(this.lbl2Position5);
            this.panel32.Controls.Add(this.lbl2Position4);
            this.panel32.Controls.Add(this.lbl2Position8Value);
            this.panel32.Controls.Add(this.lbl2Position0);
            this.panel32.Controls.Add(this.lbl2Position3Value);
            this.panel32.Controls.Add(this.lbl2Position3);
            this.panel32.Controls.Add(this.lbl2Position8);
            this.panel32.Controls.Add(this.lbl2Position1);
            this.panel32.Controls.Add(this.lbl2Position2);
            this.panel32.Controls.Add(this.lbl2Position0Value);
            this.panel32.Controls.Add(this.panel35);
            this.panel32.Location = new System.Drawing.Point(791, 3);
            this.panel32.Name = "panel32";
            this.panel32.Size = new System.Drawing.Size(393, 394);
            this.panel32.TabIndex = 347;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Red;
            this.panel9.Controls.Add(this.label4);
            this.panel9.Location = new System.Drawing.Point(0, 123);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(393, 11);
            this.panel9.TabIndex = 373;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label4.Location = new System.Drawing.Point(418, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 37);
            this.label4.TabIndex = 277;
            this.label4.Text = "00";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl2Position6Value
            // 
            this.lbl2Position6Value.AutoSize = true;
            this.lbl2Position6Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl2Position6Value.ForeColor = System.Drawing.Color.Yellow;
            this.lbl2Position6Value.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl2Position6Value.Location = new System.Drawing.Point(305, 189);
            this.lbl2Position6Value.Name = "lbl2Position6Value";
            this.lbl2Position6Value.Size = new System.Drawing.Size(49, 33);
            this.lbl2Position6Value.TabIndex = 395;
            this.lbl2Position6Value.Text = "$$";
            this.lbl2Position6Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl2Position10Value
            // 
            this.lbl2Position10Value.AutoSize = true;
            this.lbl2Position10Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl2Position10Value.ForeColor = System.Drawing.Color.Yellow;
            this.lbl2Position10Value.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl2Position10Value.Location = new System.Drawing.Point(287, 277);
            this.lbl2Position10Value.Name = "lbl2Position10Value";
            this.lbl2Position10Value.Size = new System.Drawing.Size(32, 33);
            this.lbl2Position10Value.TabIndex = 394;
            this.lbl2Position10Value.Text = "0";
            this.lbl2Position10Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl2Position10
            // 
            this.lbl2Position10.AutoSize = true;
            this.lbl2Position10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2Position10.ForeColor = System.Drawing.Color.White;
            this.lbl2Position10.Location = new System.Drawing.Point(243, 276);
            this.lbl2Position10.Name = "lbl2Position10";
            this.lbl2Position10.Size = new System.Drawing.Size(77, 33);
            this.lbl2Position10.TabIndex = 393;
            this.lbl2Position10.Text = "Avo:";
            // 
            // lbl2Position7Value
            // 
            this.lbl2Position7Value.AutoSize = true;
            this.lbl2Position7Value.BackColor = System.Drawing.Color.Red;
            this.lbl2Position7Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl2Position7Value.ForeColor = System.Drawing.Color.Red;
            this.lbl2Position7Value.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl2Position7Value.Location = new System.Drawing.Point(98, 234);
            this.lbl2Position7Value.Name = "lbl2Position7Value";
            this.lbl2Position7Value.Size = new System.Drawing.Size(24, 33);
            this.lbl2Position7Value.TabIndex = 392;
            this.lbl2Position7Value.Text = ".";
            this.lbl2Position7Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl2Position9Value
            // 
            this.lbl2Position9Value.AutoSize = true;
            this.lbl2Position9Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl2Position9Value.ForeColor = System.Drawing.Color.Yellow;
            this.lbl2Position9Value.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl2Position9Value.Location = new System.Drawing.Point(71, 279);
            this.lbl2Position9Value.Name = "lbl2Position9Value";
            this.lbl2Position9Value.Size = new System.Drawing.Size(32, 33);
            this.lbl2Position9Value.TabIndex = 391;
            this.lbl2Position9Value.Text = "#";
            this.lbl2Position9Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl2Position9
            // 
            this.lbl2Position9.AutoSize = true;
            this.lbl2Position9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2Position9.ForeColor = System.Drawing.Color.White;
            this.lbl2Position9.Location = new System.Drawing.Point(6, 279);
            this.lbl2Position9.Name = "lbl2Position9";
            this.lbl2Position9.Size = new System.Drawing.Size(89, 33);
            this.lbl2Position9.TabIndex = 390;
            this.lbl2Position9.Text = "Mics:";
            // 
            // lbl2Position7
            // 
            this.lbl2Position7.AutoSize = true;
            this.lbl2Position7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2Position7.ForeColor = System.Drawing.Color.White;
            this.lbl2Position7.Location = new System.Drawing.Point(3, 234);
            this.lbl2Position7.Name = "lbl2Position7";
            this.lbl2Position7.Size = new System.Drawing.Size(112, 33);
            this.lbl2Position7.TabIndex = 389;
            this.lbl2Position7.Text = "Spotlit:";
            // 
            // lbl2Position2Flag
            // 
            this.lbl2Position2Flag.AutoSize = true;
            this.lbl2Position2Flag.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2Position2Flag.ForeColor = System.Drawing.Color.White;
            this.lbl2Position2Flag.Location = new System.Drawing.Point(154, 94);
            this.lbl2Position2Flag.Name = "lbl2Position2Flag";
            this.lbl2Position2Flag.Size = new System.Drawing.Size(40, 33);
            this.lbl2Position2Flag.TabIndex = 388;
            this.lbl2Position2Flag.Text = "M";
            // 
            // lbl2Position0Flag
            // 
            this.lbl2Position0Flag.AutoSize = true;
            this.lbl2Position0Flag.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2Position0Flag.ForeColor = System.Drawing.Color.White;
            this.lbl2Position0Flag.Location = new System.Drawing.Point(154, 57);
            this.lbl2Position0Flag.Name = "lbl2Position0Flag";
            this.lbl2Position0Flag.Size = new System.Drawing.Size(37, 33);
            this.lbl2Position0Flag.TabIndex = 387;
            this.lbl2Position0Flag.Text = "D";
            // 
            // lbl2Position4Value
            // 
            this.lbl2Position4Value.AutoSize = true;
            this.lbl2Position4Value.BackColor = System.Drawing.Color.Red;
            this.lbl2Position4Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl2Position4Value.ForeColor = System.Drawing.Color.Red;
            this.lbl2Position4Value.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl2Position4Value.Location = new System.Drawing.Point(315, 137);
            this.lbl2Position4Value.Name = "lbl2Position4Value";
            this.lbl2Position4Value.Size = new System.Drawing.Size(24, 33);
            this.lbl2Position4Value.TabIndex = 386;
            this.lbl2Position4Value.Text = ".";
            this.lbl2Position4Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl2Position5Value
            // 
            this.lbl2Position5Value.AutoSize = true;
            this.lbl2Position5Value.BackColor = System.Drawing.Color.Red;
            this.lbl2Position5Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl2Position5Value.ForeColor = System.Drawing.Color.Red;
            this.lbl2Position5Value.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl2Position5Value.Location = new System.Drawing.Point(98, 178);
            this.lbl2Position5Value.Name = "lbl2Position5Value";
            this.lbl2Position5Value.Size = new System.Drawing.Size(24, 33);
            this.lbl2Position5Value.TabIndex = 385;
            this.lbl2Position5Value.Text = ".";
            this.lbl2Position5Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl2Position6
            // 
            this.lbl2Position6.AutoSize = true;
            this.lbl2Position6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2Position6.ForeColor = System.Drawing.Color.White;
            this.lbl2Position6.Location = new System.Drawing.Point(244, 188);
            this.lbl2Position6.Name = "lbl2Position6";
            this.lbl2Position6.Size = new System.Drawing.Size(90, 33);
            this.lbl2Position6.TabIndex = 384;
            this.lbl2Position6.Text = "Strat:";
            // 
            // lbl2Position2Value
            // 
            this.lbl2Position2Value.AutoSize = true;
            this.lbl2Position2Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl2Position2Value.ForeColor = System.Drawing.Color.Yellow;
            this.lbl2Position2Value.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl2Position2Value.Location = new System.Drawing.Point(54, 94);
            this.lbl2Position2Value.Name = "lbl2Position2Value";
            this.lbl2Position2Value.Size = new System.Drawing.Size(49, 33);
            this.lbl2Position2Value.TabIndex = 383;
            this.lbl2Position2Value.Text = "$$";
            this.lbl2Position2Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl2Position1Value
            // 
            this.lbl2Position1Value.AutoSize = true;
            this.lbl2Position1Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl2Position1Value.ForeColor = System.Drawing.Color.Yellow;
            this.lbl2Position1Value.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl2Position1Value.Location = new System.Drawing.Point(299, 57);
            this.lbl2Position1Value.Name = "lbl2Position1Value";
            this.lbl2Position1Value.Size = new System.Drawing.Size(49, 33);
            this.lbl2Position1Value.TabIndex = 382;
            this.lbl2Position1Value.Text = "$$";
            this.lbl2Position1Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl2Position5
            // 
            this.lbl2Position5.AutoSize = true;
            this.lbl2Position5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2Position5.ForeColor = System.Drawing.Color.White;
            this.lbl2Position5.Location = new System.Drawing.Point(3, 179);
            this.lbl2Position5.Name = "lbl2Position5";
            this.lbl2Position5.Size = new System.Drawing.Size(147, 33);
            this.lbl2Position5.TabIndex = 381;
            this.lbl2Position5.Text = "HP Amp: ";
            // 
            // lbl2Position4
            // 
            this.lbl2Position4.AutoSize = true;
            this.lbl2Position4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2Position4.ForeColor = System.Drawing.Color.White;
            this.lbl2Position4.Location = new System.Drawing.Point(243, 137);
            this.lbl2Position4.Name = "lbl2Position4";
            this.lbl2Position4.Size = new System.Drawing.Size(108, 33);
            this.lbl2Position4.TabIndex = 378;
            this.lbl2Position4.Text = "Leave:";
            // 
            // lbl2Position8Value
            // 
            this.lbl2Position8Value.AutoSize = true;
            this.lbl2Position8Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl2Position8Value.ForeColor = System.Drawing.Color.Yellow;
            this.lbl2Position8Value.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl2Position8Value.Location = new System.Drawing.Point(288, 235);
            this.lbl2Position8Value.Name = "lbl2Position8Value";
            this.lbl2Position8Value.Size = new System.Drawing.Size(32, 33);
            this.lbl2Position8Value.TabIndex = 379;
            this.lbl2Position8Value.Text = "0";
            this.lbl2Position8Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl2Position0
            // 
            this.lbl2Position0.AutoSize = true;
            this.lbl2Position0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2Position0.ForeColor = System.Drawing.Color.White;
            this.lbl2Position0.Location = new System.Drawing.Point(2, 57);
            this.lbl2Position0.Name = "lbl2Position0";
            this.lbl2Position0.Size = new System.Drawing.Size(77, 33);
            this.lbl2Position0.TabIndex = 377;
            this.lbl2Position0.Text = "Acq:";
            // 
            // lbl2Position3Value
            // 
            this.lbl2Position3Value.AutoSize = true;
            this.lbl2Position3Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl2Position3Value.ForeColor = System.Drawing.Color.Yellow;
            this.lbl2Position3Value.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl2Position3Value.Location = new System.Drawing.Point(78, 138);
            this.lbl2Position3Value.Name = "lbl2Position3Value";
            this.lbl2Position3Value.Size = new System.Drawing.Size(32, 33);
            this.lbl2Position3Value.TabIndex = 374;
            this.lbl2Position3Value.Text = "#";
            this.lbl2Position3Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl2Position3
            // 
            this.lbl2Position3.AutoSize = true;
            this.lbl2Position3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2Position3.ForeColor = System.Drawing.Color.White;
            this.lbl2Position3.Location = new System.Drawing.Point(2, 137);
            this.lbl2Position3.Name = "lbl2Position3";
            this.lbl2Position3.Size = new System.Drawing.Size(104, 33);
            this.lbl2Position3.TabIndex = 376;
            this.lbl2Position3.Text = "Setup:";
            // 
            // lbl2Position8
            // 
            this.lbl2Position8.AutoSize = true;
            this.lbl2Position8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2Position8.ForeColor = System.Drawing.Color.White;
            this.lbl2Position8.Location = new System.Drawing.Point(244, 234);
            this.lbl2Position8.Name = "lbl2Position8";
            this.lbl2Position8.Size = new System.Drawing.Size(72, 33);
            this.lbl2Position8.TabIndex = 371;
            this.lbl2Position8.Text = "Def:";
            // 
            // lbl2Position1
            // 
            this.lbl2Position1.AutoSize = true;
            this.lbl2Position1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2Position1.ForeColor = System.Drawing.Color.White;
            this.lbl2Position1.Location = new System.Drawing.Point(244, 57);
            this.lbl2Position1.Name = "lbl2Position1";
            this.lbl2Position1.Size = new System.Drawing.Size(84, 33);
            this.lbl2Position1.TabIndex = 380;
            this.lbl2Position1.Text = "Orig:";
            // 
            // lbl2Position2
            // 
            this.lbl2Position2.AutoSize = true;
            this.lbl2Position2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2Position2.ForeColor = System.Drawing.Color.White;
            this.lbl2Position2.Location = new System.Drawing.Point(2, 94);
            this.lbl2Position2.Name = "lbl2Position2";
            this.lbl2Position2.Size = new System.Drawing.Size(71, 33);
            this.lbl2Position2.TabIndex = 375;
            this.lbl2Position2.Text = "Del:";
            // 
            // lbl2Position0Value
            // 
            this.lbl2Position0Value.AutoSize = true;
            this.lbl2Position0Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl2Position0Value.ForeColor = System.Drawing.Color.Yellow;
            this.lbl2Position0Value.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl2Position0Value.Location = new System.Drawing.Point(54, 57);
            this.lbl2Position0Value.Name = "lbl2Position0Value";
            this.lbl2Position0Value.Size = new System.Drawing.Size(49, 33);
            this.lbl2Position0Value.TabIndex = 372;
            this.lbl2Position0Value.Text = "$$";
            this.lbl2Position0Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.panel36.Controls.Add(this.panel21);
            this.panel36.Controls.Add(this.lbl1Position6Value);
            this.panel36.Controls.Add(this.lbl1Position10Value);
            this.panel36.Controls.Add(this.lbl1Position10);
            this.panel36.Controls.Add(this.lbl1Position7Value);
            this.panel36.Controls.Add(this.lbl1Position9Value);
            this.panel36.Controls.Add(this.lbl1Position9);
            this.panel36.Controls.Add(this.lbl1Position7);
            this.panel36.Controls.Add(this.lbl1Position2Flag);
            this.panel36.Controls.Add(this.lbl1Position0Flag);
            this.panel36.Controls.Add(this.lbl1Position4Value);
            this.panel36.Controls.Add(this.lbl1Position5Value);
            this.panel36.Controls.Add(this.lbl1Position6);
            this.panel36.Controls.Add(this.lbl1Position2Value);
            this.panel36.Controls.Add(this.lbl1Position1Value);
            this.panel36.Controls.Add(this.lbl1Position5);
            this.panel36.Controls.Add(this.lbl1Position4);
            this.panel36.Controls.Add(this.lbl1Position8Value);
            this.panel36.Controls.Add(this.lbl1Position0);
            this.panel36.Controls.Add(this.lbl1Position3Value);
            this.panel36.Controls.Add(this.lbl1Position3);
            this.panel36.Controls.Add(this.lbl1Position8);
            this.panel36.Controls.Add(this.lbl1Position1);
            this.panel36.Controls.Add(this.lbl1Position2);
            this.panel36.Controls.Add(this.lbl1Position0Value);
            this.panel36.Controls.Add(this.panel39);
            this.panel36.Location = new System.Drawing.Point(390, 3);
            this.panel36.Name = "panel36";
            this.panel36.Size = new System.Drawing.Size(395, 394);
            this.panel36.TabIndex = 280;
            // 
            // panel21
            // 
            this.panel21.BackColor = System.Drawing.Color.Red;
            this.panel21.Controls.Add(this.label23);
            this.panel21.Location = new System.Drawing.Point(0, 123);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(394, 11);
            this.panel21.TabIndex = 348;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Red;
            this.label23.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label23.Location = new System.Drawing.Point(418, 214);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(55, 37);
            this.label23.TabIndex = 277;
            this.label23.Text = "00";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl1Position6Value
            // 
            this.lbl1Position6Value.AutoSize = true;
            this.lbl1Position6Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl1Position6Value.ForeColor = System.Drawing.Color.Yellow;
            this.lbl1Position6Value.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl1Position6Value.Location = new System.Drawing.Point(306, 190);
            this.lbl1Position6Value.Name = "lbl1Position6Value";
            this.lbl1Position6Value.Size = new System.Drawing.Size(49, 33);
            this.lbl1Position6Value.TabIndex = 370;
            this.lbl1Position6Value.Text = "$$";
            this.lbl1Position6Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl1Position10Value
            // 
            this.lbl1Position10Value.AutoSize = true;
            this.lbl1Position10Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl1Position10Value.ForeColor = System.Drawing.Color.Yellow;
            this.lbl1Position10Value.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl1Position10Value.Location = new System.Drawing.Point(288, 278);
            this.lbl1Position10Value.Name = "lbl1Position10Value";
            this.lbl1Position10Value.Size = new System.Drawing.Size(32, 33);
            this.lbl1Position10Value.TabIndex = 369;
            this.lbl1Position10Value.Text = "0";
            this.lbl1Position10Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl1Position10
            // 
            this.lbl1Position10.AutoSize = true;
            this.lbl1Position10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1Position10.ForeColor = System.Drawing.Color.White;
            this.lbl1Position10.Location = new System.Drawing.Point(244, 277);
            this.lbl1Position10.Name = "lbl1Position10";
            this.lbl1Position10.Size = new System.Drawing.Size(77, 33);
            this.lbl1Position10.TabIndex = 368;
            this.lbl1Position10.Text = "Avo:";
            // 
            // lbl1Position7Value
            // 
            this.lbl1Position7Value.AutoSize = true;
            this.lbl1Position7Value.BackColor = System.Drawing.Color.Red;
            this.lbl1Position7Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl1Position7Value.ForeColor = System.Drawing.Color.Red;
            this.lbl1Position7Value.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl1Position7Value.Location = new System.Drawing.Point(99, 235);
            this.lbl1Position7Value.Name = "lbl1Position7Value";
            this.lbl1Position7Value.Size = new System.Drawing.Size(24, 33);
            this.lbl1Position7Value.TabIndex = 367;
            this.lbl1Position7Value.Text = ".";
            this.lbl1Position7Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl1Position9Value
            // 
            this.lbl1Position9Value.AutoSize = true;
            this.lbl1Position9Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl1Position9Value.ForeColor = System.Drawing.Color.Yellow;
            this.lbl1Position9Value.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl1Position9Value.Location = new System.Drawing.Point(72, 280);
            this.lbl1Position9Value.Name = "lbl1Position9Value";
            this.lbl1Position9Value.Size = new System.Drawing.Size(32, 33);
            this.lbl1Position9Value.TabIndex = 366;
            this.lbl1Position9Value.Text = "#";
            this.lbl1Position9Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl1Position9
            // 
            this.lbl1Position9.AutoSize = true;
            this.lbl1Position9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1Position9.ForeColor = System.Drawing.Color.White;
            this.lbl1Position9.Location = new System.Drawing.Point(7, 280);
            this.lbl1Position9.Name = "lbl1Position9";
            this.lbl1Position9.Size = new System.Drawing.Size(89, 33);
            this.lbl1Position9.TabIndex = 365;
            this.lbl1Position9.Text = "Mics:";
            // 
            // lbl1Position7
            // 
            this.lbl1Position7.AutoSize = true;
            this.lbl1Position7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1Position7.ForeColor = System.Drawing.Color.White;
            this.lbl1Position7.Location = new System.Drawing.Point(4, 235);
            this.lbl1Position7.Name = "lbl1Position7";
            this.lbl1Position7.Size = new System.Drawing.Size(112, 33);
            this.lbl1Position7.TabIndex = 364;
            this.lbl1Position7.Text = "Spotlit:";
            // 
            // lbl1Position2Flag
            // 
            this.lbl1Position2Flag.AutoSize = true;
            this.lbl1Position2Flag.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1Position2Flag.ForeColor = System.Drawing.Color.White;
            this.lbl1Position2Flag.Location = new System.Drawing.Point(155, 90);
            this.lbl1Position2Flag.Name = "lbl1Position2Flag";
            this.lbl1Position2Flag.Size = new System.Drawing.Size(40, 33);
            this.lbl1Position2Flag.TabIndex = 363;
            this.lbl1Position2Flag.Text = "M";
            // 
            // lbl1Position0Flag
            // 
            this.lbl1Position0Flag.AutoSize = true;
            this.lbl1Position0Flag.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1Position0Flag.ForeColor = System.Drawing.Color.White;
            this.lbl1Position0Flag.Location = new System.Drawing.Point(155, 53);
            this.lbl1Position0Flag.Name = "lbl1Position0Flag";
            this.lbl1Position0Flag.Size = new System.Drawing.Size(37, 33);
            this.lbl1Position0Flag.TabIndex = 362;
            this.lbl1Position0Flag.Text = "D";
            // 
            // lbl1Position4Value
            // 
            this.lbl1Position4Value.AutoSize = true;
            this.lbl1Position4Value.BackColor = System.Drawing.Color.Red;
            this.lbl1Position4Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl1Position4Value.ForeColor = System.Drawing.Color.Red;
            this.lbl1Position4Value.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl1Position4Value.Location = new System.Drawing.Point(316, 138);
            this.lbl1Position4Value.Name = "lbl1Position4Value";
            this.lbl1Position4Value.Size = new System.Drawing.Size(24, 33);
            this.lbl1Position4Value.TabIndex = 361;
            this.lbl1Position4Value.Text = ".";
            this.lbl1Position4Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl1Position5Value
            // 
            this.lbl1Position5Value.AutoSize = true;
            this.lbl1Position5Value.BackColor = System.Drawing.Color.Red;
            this.lbl1Position5Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl1Position5Value.ForeColor = System.Drawing.Color.Red;
            this.lbl1Position5Value.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl1Position5Value.Location = new System.Drawing.Point(99, 179);
            this.lbl1Position5Value.Name = "lbl1Position5Value";
            this.lbl1Position5Value.Size = new System.Drawing.Size(24, 33);
            this.lbl1Position5Value.TabIndex = 360;
            this.lbl1Position5Value.Text = ".";
            this.lbl1Position5Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl1Position6
            // 
            this.lbl1Position6.AutoSize = true;
            this.lbl1Position6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1Position6.ForeColor = System.Drawing.Color.White;
            this.lbl1Position6.Location = new System.Drawing.Point(245, 189);
            this.lbl1Position6.Name = "lbl1Position6";
            this.lbl1Position6.Size = new System.Drawing.Size(90, 33);
            this.lbl1Position6.TabIndex = 359;
            this.lbl1Position6.Text = "Strat:";
            // 
            // lbl1Position2Value
            // 
            this.lbl1Position2Value.AutoSize = true;
            this.lbl1Position2Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl1Position2Value.ForeColor = System.Drawing.Color.Yellow;
            this.lbl1Position2Value.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl1Position2Value.Location = new System.Drawing.Point(55, 90);
            this.lbl1Position2Value.Name = "lbl1Position2Value";
            this.lbl1Position2Value.Size = new System.Drawing.Size(49, 33);
            this.lbl1Position2Value.TabIndex = 358;
            this.lbl1Position2Value.Text = "$$";
            this.lbl1Position2Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl1Position1Value
            // 
            this.lbl1Position1Value.AutoSize = true;
            this.lbl1Position1Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl1Position1Value.ForeColor = System.Drawing.Color.Yellow;
            this.lbl1Position1Value.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl1Position1Value.Location = new System.Drawing.Point(300, 53);
            this.lbl1Position1Value.Name = "lbl1Position1Value";
            this.lbl1Position1Value.Size = new System.Drawing.Size(49, 33);
            this.lbl1Position1Value.TabIndex = 357;
            this.lbl1Position1Value.Text = "$$";
            this.lbl1Position1Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl1Position5
            // 
            this.lbl1Position5.AutoSize = true;
            this.lbl1Position5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1Position5.ForeColor = System.Drawing.Color.White;
            this.lbl1Position5.Location = new System.Drawing.Point(4, 180);
            this.lbl1Position5.Name = "lbl1Position5";
            this.lbl1Position5.Size = new System.Drawing.Size(147, 33);
            this.lbl1Position5.TabIndex = 356;
            this.lbl1Position5.Text = "HP Amp: ";
            // 
            // lbl1Position4
            // 
            this.lbl1Position4.AutoSize = true;
            this.lbl1Position4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1Position4.ForeColor = System.Drawing.Color.White;
            this.lbl1Position4.Location = new System.Drawing.Point(244, 138);
            this.lbl1Position4.Name = "lbl1Position4";
            this.lbl1Position4.Size = new System.Drawing.Size(108, 33);
            this.lbl1Position4.TabIndex = 353;
            this.lbl1Position4.Text = "Leave:";
            // 
            // lbl1Position8Value
            // 
            this.lbl1Position8Value.AutoSize = true;
            this.lbl1Position8Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl1Position8Value.ForeColor = System.Drawing.Color.Yellow;
            this.lbl1Position8Value.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl1Position8Value.Location = new System.Drawing.Point(289, 236);
            this.lbl1Position8Value.Name = "lbl1Position8Value";
            this.lbl1Position8Value.Size = new System.Drawing.Size(32, 33);
            this.lbl1Position8Value.TabIndex = 354;
            this.lbl1Position8Value.Text = "0";
            this.lbl1Position8Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl1Position0
            // 
            this.lbl1Position0.AutoSize = true;
            this.lbl1Position0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1Position0.ForeColor = System.Drawing.Color.White;
            this.lbl1Position0.Location = new System.Drawing.Point(3, 53);
            this.lbl1Position0.Name = "lbl1Position0";
            this.lbl1Position0.Size = new System.Drawing.Size(77, 33);
            this.lbl1Position0.TabIndex = 352;
            this.lbl1Position0.Text = "Acq:";
            // 
            // lbl1Position3Value
            // 
            this.lbl1Position3Value.AutoSize = true;
            this.lbl1Position3Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl1Position3Value.ForeColor = System.Drawing.Color.Yellow;
            this.lbl1Position3Value.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl1Position3Value.Location = new System.Drawing.Point(79, 139);
            this.lbl1Position3Value.Name = "lbl1Position3Value";
            this.lbl1Position3Value.Size = new System.Drawing.Size(32, 33);
            this.lbl1Position3Value.TabIndex = 349;
            this.lbl1Position3Value.Text = "#";
            this.lbl1Position3Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl1Position3
            // 
            this.lbl1Position3.AutoSize = true;
            this.lbl1Position3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1Position3.ForeColor = System.Drawing.Color.White;
            this.lbl1Position3.Location = new System.Drawing.Point(3, 138);
            this.lbl1Position3.Name = "lbl1Position3";
            this.lbl1Position3.Size = new System.Drawing.Size(104, 33);
            this.lbl1Position3.TabIndex = 351;
            this.lbl1Position3.Text = "Setup:";
            // 
            // lbl1Position8
            // 
            this.lbl1Position8.AutoSize = true;
            this.lbl1Position8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1Position8.ForeColor = System.Drawing.Color.White;
            this.lbl1Position8.Location = new System.Drawing.Point(245, 235);
            this.lbl1Position8.Name = "lbl1Position8";
            this.lbl1Position8.Size = new System.Drawing.Size(72, 33);
            this.lbl1Position8.TabIndex = 346;
            this.lbl1Position8.Text = "Def:";
            // 
            // lbl1Position1
            // 
            this.lbl1Position1.AutoSize = true;
            this.lbl1Position1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1Position1.ForeColor = System.Drawing.Color.White;
            this.lbl1Position1.Location = new System.Drawing.Point(245, 53);
            this.lbl1Position1.Name = "lbl1Position1";
            this.lbl1Position1.Size = new System.Drawing.Size(84, 33);
            this.lbl1Position1.TabIndex = 355;
            this.lbl1Position1.Text = "Orig:";
            // 
            // lbl1Position2
            // 
            this.lbl1Position2.AutoSize = true;
            this.lbl1Position2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1Position2.ForeColor = System.Drawing.Color.White;
            this.lbl1Position2.Location = new System.Drawing.Point(3, 90);
            this.lbl1Position2.Name = "lbl1Position2";
            this.lbl1Position2.Size = new System.Drawing.Size(71, 33);
            this.lbl1Position2.TabIndex = 350;
            this.lbl1Position2.Text = "Del:";
            // 
            // lbl1Position0Value
            // 
            this.lbl1Position0Value.AutoSize = true;
            this.lbl1Position0Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl1Position0Value.ForeColor = System.Drawing.Color.Yellow;
            this.lbl1Position0Value.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl1Position0Value.Location = new System.Drawing.Point(55, 53);
            this.lbl1Position0Value.Name = "lbl1Position0Value";
            this.lbl1Position0Value.Size = new System.Drawing.Size(49, 33);
            this.lbl1Position0Value.TabIndex = 347;
            this.lbl1Position0Value.Text = "$$";
            this.lbl1Position0Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.team1.Size = new System.Drawing.Size(381, 394);
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
            this.panel8.Size = new System.Drawing.Size(381, 11);
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
            this.panel3.Controls.Add(this.panel15);
            this.panel3.Controls.Add(this.panel16);
            this.panel3.Controls.Add(this.lbl5Position6Value);
            this.panel3.Controls.Add(this.lbl5Position10Value);
            this.panel3.Controls.Add(this.lbl5Position10);
            this.panel3.Controls.Add(this.lbl5Position7Value);
            this.panel3.Controls.Add(this.lbl5Position9Value);
            this.panel3.Controls.Add(this.lbl5Position9);
            this.panel3.Controls.Add(this.lbl5Position7);
            this.panel3.Controls.Add(this.lbl5Position2Flag);
            this.panel3.Controls.Add(this.lbl5Position0Flag);
            this.panel3.Controls.Add(this.lbl5Position4Value);
            this.panel3.Controls.Add(this.lbl5Position5Value);
            this.panel3.Controls.Add(this.lbl5Position6);
            this.panel3.Controls.Add(this.lbl5Position2Value);
            this.panel3.Controls.Add(this.lbl5Position1Value);
            this.panel3.Controls.Add(this.lbl5Position5);
            this.panel3.Controls.Add(this.lbl5Position4);
            this.panel3.Controls.Add(this.lbl5Position8Value);
            this.panel3.Controls.Add(this.lbl5Position0);
            this.panel3.Controls.Add(this.lbl5Position3Value);
            this.panel3.Controls.Add(this.lbl5Position3);
            this.panel3.Controls.Add(this.lbl5Position8);
            this.panel3.Controls.Add(this.lbl5Position1);
            this.panel3.Controls.Add(this.lbl5Position2);
            this.panel3.Controls.Add(this.lbl5Position0Value);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Location = new System.Drawing.Point(792, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(393, 391);
            this.panel3.TabIndex = 349;
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.DarkBlue;
            this.panel15.Controls.Add(this.label60);
            this.panel15.Location = new System.Drawing.Point(0, 37);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(393, 13);
            this.panel15.TabIndex = 397;
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label60.ForeColor = System.Drawing.Color.Red;
            this.label60.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label60.Location = new System.Drawing.Point(418, 214);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(55, 37);
            this.label60.TabIndex = 277;
            this.label60.Text = "00";
            this.label60.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.DarkBlue;
            this.panel16.Controls.Add(this.label61);
            this.panel16.Location = new System.Drawing.Point(0, 113);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(393, 11);
            this.panel16.TabIndex = 374;
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label61.ForeColor = System.Drawing.Color.Red;
            this.label61.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label61.Location = new System.Drawing.Point(418, 214);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(55, 37);
            this.label61.TabIndex = 277;
            this.label61.Text = "00";
            this.label61.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl5Position6Value
            // 
            this.lbl5Position6Value.AutoSize = true;
            this.lbl5Position6Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl5Position6Value.ForeColor = System.Drawing.Color.Yellow;
            this.lbl5Position6Value.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl5Position6Value.Location = new System.Drawing.Point(313, 184);
            this.lbl5Position6Value.Name = "lbl5Position6Value";
            this.lbl5Position6Value.Size = new System.Drawing.Size(49, 33);
            this.lbl5Position6Value.TabIndex = 396;
            this.lbl5Position6Value.Text = "$$";
            this.lbl5Position6Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl5Position10Value
            // 
            this.lbl5Position10Value.AutoSize = true;
            this.lbl5Position10Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl5Position10Value.ForeColor = System.Drawing.Color.Yellow;
            this.lbl5Position10Value.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl5Position10Value.Location = new System.Drawing.Point(297, 279);
            this.lbl5Position10Value.Name = "lbl5Position10Value";
            this.lbl5Position10Value.Size = new System.Drawing.Size(32, 33);
            this.lbl5Position10Value.TabIndex = 395;
            this.lbl5Position10Value.Text = "0";
            this.lbl5Position10Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl5Position10
            // 
            this.lbl5Position10.AutoSize = true;
            this.lbl5Position10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5Position10.ForeColor = System.Drawing.Color.White;
            this.lbl5Position10.Location = new System.Drawing.Point(253, 278);
            this.lbl5Position10.Name = "lbl5Position10";
            this.lbl5Position10.Size = new System.Drawing.Size(77, 33);
            this.lbl5Position10.TabIndex = 394;
            this.lbl5Position10.Text = "Avo:";
            // 
            // lbl5Position7Value
            // 
            this.lbl5Position7Value.AutoSize = true;
            this.lbl5Position7Value.BackColor = System.Drawing.Color.Red;
            this.lbl5Position7Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl5Position7Value.ForeColor = System.Drawing.Color.Red;
            this.lbl5Position7Value.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl5Position7Value.Location = new System.Drawing.Point(108, 233);
            this.lbl5Position7Value.Name = "lbl5Position7Value";
            this.lbl5Position7Value.Size = new System.Drawing.Size(24, 33);
            this.lbl5Position7Value.TabIndex = 393;
            this.lbl5Position7Value.Text = ".";
            this.lbl5Position7Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl5Position9Value
            // 
            this.lbl5Position9Value.AutoSize = true;
            this.lbl5Position9Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl5Position9Value.ForeColor = System.Drawing.Color.Yellow;
            this.lbl5Position9Value.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl5Position9Value.Location = new System.Drawing.Point(78, 278);
            this.lbl5Position9Value.Name = "lbl5Position9Value";
            this.lbl5Position9Value.Size = new System.Drawing.Size(32, 33);
            this.lbl5Position9Value.TabIndex = 392;
            this.lbl5Position9Value.Text = "#";
            this.lbl5Position9Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl5Position9
            // 
            this.lbl5Position9.AutoSize = true;
            this.lbl5Position9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5Position9.ForeColor = System.Drawing.Color.White;
            this.lbl5Position9.Location = new System.Drawing.Point(13, 278);
            this.lbl5Position9.Name = "lbl5Position9";
            this.lbl5Position9.Size = new System.Drawing.Size(89, 33);
            this.lbl5Position9.TabIndex = 391;
            this.lbl5Position9.Text = "Mics:";
            // 
            // lbl5Position7
            // 
            this.lbl5Position7.AutoSize = true;
            this.lbl5Position7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5Position7.ForeColor = System.Drawing.Color.White;
            this.lbl5Position7.Location = new System.Drawing.Point(13, 233);
            this.lbl5Position7.Name = "lbl5Position7";
            this.lbl5Position7.Size = new System.Drawing.Size(112, 33);
            this.lbl5Position7.TabIndex = 390;
            this.lbl5Position7.Text = "Spotlit:";
            // 
            // lbl5Position2Flag
            // 
            this.lbl5Position2Flag.AutoSize = true;
            this.lbl5Position2Flag.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5Position2Flag.ForeColor = System.Drawing.Color.White;
            this.lbl5Position2Flag.Location = new System.Drawing.Point(163, 89);
            this.lbl5Position2Flag.Name = "lbl5Position2Flag";
            this.lbl5Position2Flag.Size = new System.Drawing.Size(40, 33);
            this.lbl5Position2Flag.TabIndex = 389;
            this.lbl5Position2Flag.Text = "M";
            // 
            // lbl5Position0Flag
            // 
            this.lbl5Position0Flag.AutoSize = true;
            this.lbl5Position0Flag.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5Position0Flag.ForeColor = System.Drawing.Color.White;
            this.lbl5Position0Flag.Location = new System.Drawing.Point(163, 52);
            this.lbl5Position0Flag.Name = "lbl5Position0Flag";
            this.lbl5Position0Flag.Size = new System.Drawing.Size(37, 33);
            this.lbl5Position0Flag.TabIndex = 388;
            this.lbl5Position0Flag.Text = "D";
            // 
            // lbl5Position4Value
            // 
            this.lbl5Position4Value.AutoSize = true;
            this.lbl5Position4Value.BackColor = System.Drawing.Color.Red;
            this.lbl5Position4Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl5Position4Value.ForeColor = System.Drawing.Color.Red;
            this.lbl5Position4Value.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl5Position4Value.Location = new System.Drawing.Point(322, 132);
            this.lbl5Position4Value.Name = "lbl5Position4Value";
            this.lbl5Position4Value.Size = new System.Drawing.Size(24, 33);
            this.lbl5Position4Value.TabIndex = 387;
            this.lbl5Position4Value.Text = ".";
            this.lbl5Position4Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl5Position5Value
            // 
            this.lbl5Position5Value.AutoSize = true;
            this.lbl5Position5Value.BackColor = System.Drawing.Color.Red;
            this.lbl5Position5Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl5Position5Value.ForeColor = System.Drawing.Color.Red;
            this.lbl5Position5Value.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl5Position5Value.Location = new System.Drawing.Point(107, 183);
            this.lbl5Position5Value.Name = "lbl5Position5Value";
            this.lbl5Position5Value.Size = new System.Drawing.Size(24, 33);
            this.lbl5Position5Value.TabIndex = 386;
            this.lbl5Position5Value.Text = ".";
            this.lbl5Position5Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl5Position6
            // 
            this.lbl5Position6.AutoSize = true;
            this.lbl5Position6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5Position6.ForeColor = System.Drawing.Color.White;
            this.lbl5Position6.Location = new System.Drawing.Point(252, 183);
            this.lbl5Position6.Name = "lbl5Position6";
            this.lbl5Position6.Size = new System.Drawing.Size(90, 33);
            this.lbl5Position6.TabIndex = 385;
            this.lbl5Position6.Text = "Strat:";
            // 
            // lbl5Position2Value
            // 
            this.lbl5Position2Value.AutoSize = true;
            this.lbl5Position2Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl5Position2Value.ForeColor = System.Drawing.Color.Yellow;
            this.lbl5Position2Value.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl5Position2Value.Location = new System.Drawing.Point(63, 89);
            this.lbl5Position2Value.Name = "lbl5Position2Value";
            this.lbl5Position2Value.Size = new System.Drawing.Size(49, 33);
            this.lbl5Position2Value.TabIndex = 384;
            this.lbl5Position2Value.Text = "$$";
            this.lbl5Position2Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl5Position1Value
            // 
            this.lbl5Position1Value.AutoSize = true;
            this.lbl5Position1Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl5Position1Value.ForeColor = System.Drawing.Color.Yellow;
            this.lbl5Position1Value.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl5Position1Value.Location = new System.Drawing.Point(305, 52);
            this.lbl5Position1Value.Name = "lbl5Position1Value";
            this.lbl5Position1Value.Size = new System.Drawing.Size(49, 33);
            this.lbl5Position1Value.TabIndex = 383;
            this.lbl5Position1Value.Text = "$$";
            this.lbl5Position1Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl5Position5
            // 
            this.lbl5Position5.AutoSize = true;
            this.lbl5Position5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5Position5.ForeColor = System.Drawing.Color.White;
            this.lbl5Position5.Location = new System.Drawing.Point(12, 184);
            this.lbl5Position5.Name = "lbl5Position5";
            this.lbl5Position5.Size = new System.Drawing.Size(147, 33);
            this.lbl5Position5.TabIndex = 382;
            this.lbl5Position5.Text = "HP Amp: ";
            // 
            // lbl5Position4
            // 
            this.lbl5Position4.AutoSize = true;
            this.lbl5Position4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5Position4.ForeColor = System.Drawing.Color.White;
            this.lbl5Position4.Location = new System.Drawing.Point(250, 132);
            this.lbl5Position4.Name = "lbl5Position4";
            this.lbl5Position4.Size = new System.Drawing.Size(108, 33);
            this.lbl5Position4.TabIndex = 379;
            this.lbl5Position4.Text = "Leave:";
            // 
            // lbl5Position8Value
            // 
            this.lbl5Position8Value.AutoSize = true;
            this.lbl5Position8Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl5Position8Value.ForeColor = System.Drawing.Color.Yellow;
            this.lbl5Position8Value.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl5Position8Value.Location = new System.Drawing.Point(297, 233);
            this.lbl5Position8Value.Name = "lbl5Position8Value";
            this.lbl5Position8Value.Size = new System.Drawing.Size(32, 33);
            this.lbl5Position8Value.TabIndex = 380;
            this.lbl5Position8Value.Text = "0";
            this.lbl5Position8Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl5Position0
            // 
            this.lbl5Position0.AutoSize = true;
            this.lbl5Position0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5Position0.ForeColor = System.Drawing.Color.White;
            this.lbl5Position0.Location = new System.Drawing.Point(11, 52);
            this.lbl5Position0.Name = "lbl5Position0";
            this.lbl5Position0.Size = new System.Drawing.Size(77, 33);
            this.lbl5Position0.TabIndex = 378;
            this.lbl5Position0.Text = "Acq:";
            // 
            // lbl5Position3Value
            // 
            this.lbl5Position3Value.AutoSize = true;
            this.lbl5Position3Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl5Position3Value.ForeColor = System.Drawing.Color.Yellow;
            this.lbl5Position3Value.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl5Position3Value.Location = new System.Drawing.Point(87, 133);
            this.lbl5Position3Value.Name = "lbl5Position3Value";
            this.lbl5Position3Value.Size = new System.Drawing.Size(32, 33);
            this.lbl5Position3Value.TabIndex = 375;
            this.lbl5Position3Value.Text = "#";
            this.lbl5Position3Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl5Position3
            // 
            this.lbl5Position3.AutoSize = true;
            this.lbl5Position3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5Position3.ForeColor = System.Drawing.Color.White;
            this.lbl5Position3.Location = new System.Drawing.Point(11, 132);
            this.lbl5Position3.Name = "lbl5Position3";
            this.lbl5Position3.Size = new System.Drawing.Size(104, 33);
            this.lbl5Position3.TabIndex = 377;
            this.lbl5Position3.Text = "Setup:";
            // 
            // lbl5Position8
            // 
            this.lbl5Position8.AutoSize = true;
            this.lbl5Position8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5Position8.ForeColor = System.Drawing.Color.White;
            this.lbl5Position8.Location = new System.Drawing.Point(253, 232);
            this.lbl5Position8.Name = "lbl5Position8";
            this.lbl5Position8.Size = new System.Drawing.Size(72, 33);
            this.lbl5Position8.TabIndex = 372;
            this.lbl5Position8.Text = "Def:";
            // 
            // lbl5Position1
            // 
            this.lbl5Position1.AutoSize = true;
            this.lbl5Position1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5Position1.ForeColor = System.Drawing.Color.White;
            this.lbl5Position1.Location = new System.Drawing.Point(250, 52);
            this.lbl5Position1.Name = "lbl5Position1";
            this.lbl5Position1.Size = new System.Drawing.Size(84, 33);
            this.lbl5Position1.TabIndex = 381;
            this.lbl5Position1.Text = "Orig:";
            // 
            // lbl5Position2
            // 
            this.lbl5Position2.AutoSize = true;
            this.lbl5Position2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5Position2.ForeColor = System.Drawing.Color.White;
            this.lbl5Position2.Location = new System.Drawing.Point(11, 89);
            this.lbl5Position2.Name = "lbl5Position2";
            this.lbl5Position2.Size = new System.Drawing.Size(71, 33);
            this.lbl5Position2.TabIndex = 376;
            this.lbl5Position2.Text = "Del:";
            // 
            // lbl5Position0Value
            // 
            this.lbl5Position0Value.AutoSize = true;
            this.lbl5Position0Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl5Position0Value.ForeColor = System.Drawing.Color.Yellow;
            this.lbl5Position0Value.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl5Position0Value.Location = new System.Drawing.Point(63, 52);
            this.lbl5Position0Value.Name = "lbl5Position0Value";
            this.lbl5Position0Value.Size = new System.Drawing.Size(49, 33);
            this.lbl5Position0Value.TabIndex = 373;
            this.lbl5Position0Value.Text = "$$";
            this.lbl5Position0Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.panel7.Controls.Add(this.panel12);
            this.panel7.Controls.Add(this.panel14);
            this.panel7.Controls.Add(this.lbl4Position6Value);
            this.panel7.Controls.Add(this.lbl4Position10Value);
            this.panel7.Controls.Add(this.lbl4Position10);
            this.panel7.Controls.Add(this.lbl4Position7Value);
            this.panel7.Controls.Add(this.lbl4Position9Value);
            this.panel7.Controls.Add(this.lbl4Position9);
            this.panel7.Controls.Add(this.lbl4Position7);
            this.panel7.Controls.Add(this.lbl4Position2Flag);
            this.panel7.Controls.Add(this.lbl4Position0Flag);
            this.panel7.Controls.Add(this.lbl4Position4Value);
            this.panel7.Controls.Add(this.lbl4Position5Value);
            this.panel7.Controls.Add(this.lbl4Position6);
            this.panel7.Controls.Add(this.lbl4Position2Value);
            this.panel7.Controls.Add(this.lbl4Position1Value);
            this.panel7.Controls.Add(this.lbl4Position5);
            this.panel7.Controls.Add(this.lbl4Position4);
            this.panel7.Controls.Add(this.lbl4Position8Value);
            this.panel7.Controls.Add(this.lbl4Position0);
            this.panel7.Controls.Add(this.lbl4Position3Value);
            this.panel7.Controls.Add(this.lbl4Position3);
            this.panel7.Controls.Add(this.lbl4Position8);
            this.panel7.Controls.Add(this.lbl4Position1);
            this.panel7.Controls.Add(this.lbl4Position2);
            this.panel7.Controls.Add(this.lbl4Position0Value);
            this.panel7.Controls.Add(this.panel10);
            this.panel7.Location = new System.Drawing.Point(391, 8);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(397, 388);
            this.panel7.TabIndex = 348;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.DarkBlue;
            this.panel12.Controls.Add(this.label33);
            this.panel12.Location = new System.Drawing.Point(0, 32);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(397, 13);
            this.panel12.TabIndex = 397;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = System.Drawing.Color.Red;
            this.label33.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label33.Location = new System.Drawing.Point(418, 214);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(55, 37);
            this.label33.TabIndex = 277;
            this.label33.Text = "00";
            this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.DarkBlue;
            this.panel14.Controls.Add(this.label34);
            this.panel14.Location = new System.Drawing.Point(0, 108);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(397, 11);
            this.panel14.TabIndex = 374;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.ForeColor = System.Drawing.Color.Red;
            this.label34.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label34.Location = new System.Drawing.Point(418, 214);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(55, 37);
            this.label34.TabIndex = 277;
            this.label34.Text = "00";
            this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl4Position6Value
            // 
            this.lbl4Position6Value.AutoSize = true;
            this.lbl4Position6Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl4Position6Value.ForeColor = System.Drawing.Color.Yellow;
            this.lbl4Position6Value.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl4Position6Value.Location = new System.Drawing.Point(315, 179);
            this.lbl4Position6Value.Name = "lbl4Position6Value";
            this.lbl4Position6Value.Size = new System.Drawing.Size(49, 33);
            this.lbl4Position6Value.TabIndex = 396;
            this.lbl4Position6Value.Text = "$$";
            this.lbl4Position6Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl4Position10Value
            // 
            this.lbl4Position10Value.AutoSize = true;
            this.lbl4Position10Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl4Position10Value.ForeColor = System.Drawing.Color.Yellow;
            this.lbl4Position10Value.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl4Position10Value.Location = new System.Drawing.Point(299, 274);
            this.lbl4Position10Value.Name = "lbl4Position10Value";
            this.lbl4Position10Value.Size = new System.Drawing.Size(32, 33);
            this.lbl4Position10Value.TabIndex = 395;
            this.lbl4Position10Value.Text = "0";
            this.lbl4Position10Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl4Position10
            // 
            this.lbl4Position10.AutoSize = true;
            this.lbl4Position10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4Position10.ForeColor = System.Drawing.Color.White;
            this.lbl4Position10.Location = new System.Drawing.Point(255, 273);
            this.lbl4Position10.Name = "lbl4Position10";
            this.lbl4Position10.Size = new System.Drawing.Size(77, 33);
            this.lbl4Position10.TabIndex = 394;
            this.lbl4Position10.Text = "Avo:";
            // 
            // lbl4Position7Value
            // 
            this.lbl4Position7Value.AutoSize = true;
            this.lbl4Position7Value.BackColor = System.Drawing.Color.Red;
            this.lbl4Position7Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl4Position7Value.ForeColor = System.Drawing.Color.Red;
            this.lbl4Position7Value.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl4Position7Value.Location = new System.Drawing.Point(110, 228);
            this.lbl4Position7Value.Name = "lbl4Position7Value";
            this.lbl4Position7Value.Size = new System.Drawing.Size(24, 33);
            this.lbl4Position7Value.TabIndex = 393;
            this.lbl4Position7Value.Text = ".";
            this.lbl4Position7Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl4Position9Value
            // 
            this.lbl4Position9Value.AutoSize = true;
            this.lbl4Position9Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl4Position9Value.ForeColor = System.Drawing.Color.Yellow;
            this.lbl4Position9Value.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl4Position9Value.Location = new System.Drawing.Point(80, 273);
            this.lbl4Position9Value.Name = "lbl4Position9Value";
            this.lbl4Position9Value.Size = new System.Drawing.Size(32, 33);
            this.lbl4Position9Value.TabIndex = 392;
            this.lbl4Position9Value.Text = "#";
            this.lbl4Position9Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl4Position9
            // 
            this.lbl4Position9.AutoSize = true;
            this.lbl4Position9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4Position9.ForeColor = System.Drawing.Color.White;
            this.lbl4Position9.Location = new System.Drawing.Point(15, 273);
            this.lbl4Position9.Name = "lbl4Position9";
            this.lbl4Position9.Size = new System.Drawing.Size(89, 33);
            this.lbl4Position9.TabIndex = 391;
            this.lbl4Position9.Text = "Mics:";
            // 
            // lbl4Position7
            // 
            this.lbl4Position7.AutoSize = true;
            this.lbl4Position7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4Position7.ForeColor = System.Drawing.Color.White;
            this.lbl4Position7.Location = new System.Drawing.Point(15, 228);
            this.lbl4Position7.Name = "lbl4Position7";
            this.lbl4Position7.Size = new System.Drawing.Size(112, 33);
            this.lbl4Position7.TabIndex = 390;
            this.lbl4Position7.Text = "Spotlit:";
            // 
            // lbl4Position2Flag
            // 
            this.lbl4Position2Flag.AutoSize = true;
            this.lbl4Position2Flag.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4Position2Flag.ForeColor = System.Drawing.Color.White;
            this.lbl4Position2Flag.Location = new System.Drawing.Point(165, 84);
            this.lbl4Position2Flag.Name = "lbl4Position2Flag";
            this.lbl4Position2Flag.Size = new System.Drawing.Size(40, 33);
            this.lbl4Position2Flag.TabIndex = 389;
            this.lbl4Position2Flag.Text = "M";
            // 
            // lbl4Position0Flag
            // 
            this.lbl4Position0Flag.AutoSize = true;
            this.lbl4Position0Flag.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4Position0Flag.ForeColor = System.Drawing.Color.White;
            this.lbl4Position0Flag.Location = new System.Drawing.Point(165, 47);
            this.lbl4Position0Flag.Name = "lbl4Position0Flag";
            this.lbl4Position0Flag.Size = new System.Drawing.Size(37, 33);
            this.lbl4Position0Flag.TabIndex = 388;
            this.lbl4Position0Flag.Text = "D";
            // 
            // lbl4Position4Value
            // 
            this.lbl4Position4Value.AutoSize = true;
            this.lbl4Position4Value.BackColor = System.Drawing.Color.Red;
            this.lbl4Position4Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl4Position4Value.ForeColor = System.Drawing.Color.Red;
            this.lbl4Position4Value.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl4Position4Value.Location = new System.Drawing.Point(324, 127);
            this.lbl4Position4Value.Name = "lbl4Position4Value";
            this.lbl4Position4Value.Size = new System.Drawing.Size(24, 33);
            this.lbl4Position4Value.TabIndex = 387;
            this.lbl4Position4Value.Text = ".";
            this.lbl4Position4Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl4Position5Value
            // 
            this.lbl4Position5Value.AutoSize = true;
            this.lbl4Position5Value.BackColor = System.Drawing.Color.Red;
            this.lbl4Position5Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl4Position5Value.ForeColor = System.Drawing.Color.Red;
            this.lbl4Position5Value.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl4Position5Value.Location = new System.Drawing.Point(109, 178);
            this.lbl4Position5Value.Name = "lbl4Position5Value";
            this.lbl4Position5Value.Size = new System.Drawing.Size(24, 33);
            this.lbl4Position5Value.TabIndex = 386;
            this.lbl4Position5Value.Text = ".";
            this.lbl4Position5Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl4Position6
            // 
            this.lbl4Position6.AutoSize = true;
            this.lbl4Position6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4Position6.ForeColor = System.Drawing.Color.White;
            this.lbl4Position6.Location = new System.Drawing.Point(254, 178);
            this.lbl4Position6.Name = "lbl4Position6";
            this.lbl4Position6.Size = new System.Drawing.Size(90, 33);
            this.lbl4Position6.TabIndex = 385;
            this.lbl4Position6.Text = "Strat:";
            // 
            // lbl4Position2Value
            // 
            this.lbl4Position2Value.AutoSize = true;
            this.lbl4Position2Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl4Position2Value.ForeColor = System.Drawing.Color.Yellow;
            this.lbl4Position2Value.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl4Position2Value.Location = new System.Drawing.Point(65, 84);
            this.lbl4Position2Value.Name = "lbl4Position2Value";
            this.lbl4Position2Value.Size = new System.Drawing.Size(49, 33);
            this.lbl4Position2Value.TabIndex = 384;
            this.lbl4Position2Value.Text = "$$";
            this.lbl4Position2Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl4Position1Value
            // 
            this.lbl4Position1Value.AutoSize = true;
            this.lbl4Position1Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl4Position1Value.ForeColor = System.Drawing.Color.Yellow;
            this.lbl4Position1Value.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl4Position1Value.Location = new System.Drawing.Point(307, 47);
            this.lbl4Position1Value.Name = "lbl4Position1Value";
            this.lbl4Position1Value.Size = new System.Drawing.Size(49, 33);
            this.lbl4Position1Value.TabIndex = 383;
            this.lbl4Position1Value.Text = "$$";
            this.lbl4Position1Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl4Position5
            // 
            this.lbl4Position5.AutoSize = true;
            this.lbl4Position5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4Position5.ForeColor = System.Drawing.Color.White;
            this.lbl4Position5.Location = new System.Drawing.Point(14, 179);
            this.lbl4Position5.Name = "lbl4Position5";
            this.lbl4Position5.Size = new System.Drawing.Size(147, 33);
            this.lbl4Position5.TabIndex = 382;
            this.lbl4Position5.Text = "HP Amp: ";
            // 
            // lbl4Position4
            // 
            this.lbl4Position4.AutoSize = true;
            this.lbl4Position4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4Position4.ForeColor = System.Drawing.Color.White;
            this.lbl4Position4.Location = new System.Drawing.Point(252, 127);
            this.lbl4Position4.Name = "lbl4Position4";
            this.lbl4Position4.Size = new System.Drawing.Size(108, 33);
            this.lbl4Position4.TabIndex = 379;
            this.lbl4Position4.Text = "Leave:";
            // 
            // lbl4Position8Value
            // 
            this.lbl4Position8Value.AutoSize = true;
            this.lbl4Position8Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl4Position8Value.ForeColor = System.Drawing.Color.Yellow;
            this.lbl4Position8Value.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl4Position8Value.Location = new System.Drawing.Point(299, 228);
            this.lbl4Position8Value.Name = "lbl4Position8Value";
            this.lbl4Position8Value.Size = new System.Drawing.Size(32, 33);
            this.lbl4Position8Value.TabIndex = 380;
            this.lbl4Position8Value.Text = "0";
            this.lbl4Position8Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl4Position0
            // 
            this.lbl4Position0.AutoSize = true;
            this.lbl4Position0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4Position0.ForeColor = System.Drawing.Color.White;
            this.lbl4Position0.Location = new System.Drawing.Point(13, 47);
            this.lbl4Position0.Name = "lbl4Position0";
            this.lbl4Position0.Size = new System.Drawing.Size(77, 33);
            this.lbl4Position0.TabIndex = 378;
            this.lbl4Position0.Text = "Acq:";
            // 
            // lbl4Position3Value
            // 
            this.lbl4Position3Value.AutoSize = true;
            this.lbl4Position3Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl4Position3Value.ForeColor = System.Drawing.Color.Yellow;
            this.lbl4Position3Value.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl4Position3Value.Location = new System.Drawing.Point(89, 128);
            this.lbl4Position3Value.Name = "lbl4Position3Value";
            this.lbl4Position3Value.Size = new System.Drawing.Size(32, 33);
            this.lbl4Position3Value.TabIndex = 375;
            this.lbl4Position3Value.Text = "#";
            this.lbl4Position3Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl4Position3
            // 
            this.lbl4Position3.AutoSize = true;
            this.lbl4Position3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4Position3.ForeColor = System.Drawing.Color.White;
            this.lbl4Position3.Location = new System.Drawing.Point(13, 127);
            this.lbl4Position3.Name = "lbl4Position3";
            this.lbl4Position3.Size = new System.Drawing.Size(104, 33);
            this.lbl4Position3.TabIndex = 377;
            this.lbl4Position3.Text = "Setup:";
            // 
            // lbl4Position8
            // 
            this.lbl4Position8.AutoSize = true;
            this.lbl4Position8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4Position8.ForeColor = System.Drawing.Color.White;
            this.lbl4Position8.Location = new System.Drawing.Point(255, 227);
            this.lbl4Position8.Name = "lbl4Position8";
            this.lbl4Position8.Size = new System.Drawing.Size(72, 33);
            this.lbl4Position8.TabIndex = 372;
            this.lbl4Position8.Text = "Def:";
            // 
            // lbl4Position1
            // 
            this.lbl4Position1.AutoSize = true;
            this.lbl4Position1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4Position1.ForeColor = System.Drawing.Color.White;
            this.lbl4Position1.Location = new System.Drawing.Point(252, 47);
            this.lbl4Position1.Name = "lbl4Position1";
            this.lbl4Position1.Size = new System.Drawing.Size(84, 33);
            this.lbl4Position1.TabIndex = 381;
            this.lbl4Position1.Text = "Orig:";
            // 
            // lbl4Position2
            // 
            this.lbl4Position2.AutoSize = true;
            this.lbl4Position2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4Position2.ForeColor = System.Drawing.Color.White;
            this.lbl4Position2.Location = new System.Drawing.Point(13, 84);
            this.lbl4Position2.Name = "lbl4Position2";
            this.lbl4Position2.Size = new System.Drawing.Size(71, 33);
            this.lbl4Position2.TabIndex = 376;
            this.lbl4Position2.Text = "Del:";
            // 
            // lbl4Position0Value
            // 
            this.lbl4Position0Value.AutoSize = true;
            this.lbl4Position0Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl4Position0Value.ForeColor = System.Drawing.Color.Yellow;
            this.lbl4Position0Value.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl4Position0Value.Location = new System.Drawing.Point(65, 47);
            this.lbl4Position0Value.Name = "lbl4Position0Value";
            this.lbl4Position0Value.Size = new System.Drawing.Size(49, 33);
            this.lbl4Position0Value.TabIndex = 373;
            this.lbl4Position0Value.Text = "$$";
            this.lbl4Position0Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.panel11.Controls.Add(this.panel13);
            this.panel11.Controls.Add(this.panel23);
            this.panel11.Controls.Add(this.lbl3Position6Value);
            this.panel11.Controls.Add(this.lbl3Position10Value);
            this.panel11.Controls.Add(this.lbl3Position10);
            this.panel11.Controls.Add(this.lbl3Position7Value);
            this.panel11.Controls.Add(this.lbl3Position9Value);
            this.panel11.Controls.Add(this.lbl3Position9);
            this.panel11.Controls.Add(this.lbl3Position7);
            this.panel11.Controls.Add(this.lbl3Position2Flag);
            this.panel11.Controls.Add(this.lbl3Position0Flag);
            this.panel11.Controls.Add(this.lbl3Position4Value);
            this.panel11.Controls.Add(this.lbl3Position5Value);
            this.panel11.Controls.Add(this.lbl3Position6);
            this.panel11.Controls.Add(this.lbl3Position2Value);
            this.panel11.Controls.Add(this.lbl3Position1Value);
            this.panel11.Controls.Add(this.lbl3Position5);
            this.panel11.Controls.Add(this.lbl3Position4);
            this.panel11.Controls.Add(this.lbl3Position8Value);
            this.panel11.Controls.Add(this.lbl3Position0);
            this.panel11.Controls.Add(this.lbl3Position3Value);
            this.panel11.Controls.Add(this.lbl3Position3);
            this.panel11.Controls.Add(this.lbl3Position8);
            this.panel11.Controls.Add(this.lbl3Position1);
            this.panel11.Controls.Add(this.lbl3Position2);
            this.panel11.Controls.Add(this.lbl3Position0Value);
            this.panel11.Controls.Add(this.panel30);
            this.panel11.Location = new System.Drawing.Point(7, 7);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(380, 389);
            this.panel11.TabIndex = 347;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.DarkBlue;
            this.panel13.Controls.Add(this.label79);
            this.panel13.Location = new System.Drawing.Point(0, 33);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(380, 13);
            this.panel13.TabIndex = 371;
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label79.ForeColor = System.Drawing.Color.Red;
            this.label79.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label79.Location = new System.Drawing.Point(418, 214);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(55, 37);
            this.label79.TabIndex = 277;
            this.label79.Text = "00";
            this.label79.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel23
            // 
            this.panel23.BackColor = System.Drawing.Color.DarkBlue;
            this.panel23.Controls.Add(this.label32);
            this.panel23.Location = new System.Drawing.Point(0, 109);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(381, 11);
            this.panel23.TabIndex = 348;
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
            // lbl3Position6Value
            // 
            this.lbl3Position6Value.AutoSize = true;
            this.lbl3Position6Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl3Position6Value.ForeColor = System.Drawing.Color.Yellow;
            this.lbl3Position6Value.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl3Position6Value.Location = new System.Drawing.Point(307, 180);
            this.lbl3Position6Value.Name = "lbl3Position6Value";
            this.lbl3Position6Value.Size = new System.Drawing.Size(49, 33);
            this.lbl3Position6Value.TabIndex = 370;
            this.lbl3Position6Value.Text = "$$";
            this.lbl3Position6Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl3Position10Value
            // 
            this.lbl3Position10Value.AutoSize = true;
            this.lbl3Position10Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl3Position10Value.ForeColor = System.Drawing.Color.Yellow;
            this.lbl3Position10Value.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl3Position10Value.Location = new System.Drawing.Point(291, 275);
            this.lbl3Position10Value.Name = "lbl3Position10Value";
            this.lbl3Position10Value.Size = new System.Drawing.Size(32, 33);
            this.lbl3Position10Value.TabIndex = 369;
            this.lbl3Position10Value.Text = "0";
            this.lbl3Position10Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl3Position10
            // 
            this.lbl3Position10.AutoSize = true;
            this.lbl3Position10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3Position10.ForeColor = System.Drawing.Color.White;
            this.lbl3Position10.Location = new System.Drawing.Point(247, 274);
            this.lbl3Position10.Name = "lbl3Position10";
            this.lbl3Position10.Size = new System.Drawing.Size(77, 33);
            this.lbl3Position10.TabIndex = 368;
            this.lbl3Position10.Text = "Avo:";
            // 
            // lbl3Position7Value
            // 
            this.lbl3Position7Value.AutoSize = true;
            this.lbl3Position7Value.BackColor = System.Drawing.Color.Red;
            this.lbl3Position7Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl3Position7Value.ForeColor = System.Drawing.Color.Red;
            this.lbl3Position7Value.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl3Position7Value.Location = new System.Drawing.Point(102, 229);
            this.lbl3Position7Value.Name = "lbl3Position7Value";
            this.lbl3Position7Value.Size = new System.Drawing.Size(24, 33);
            this.lbl3Position7Value.TabIndex = 367;
            this.lbl3Position7Value.Text = ".";
            this.lbl3Position7Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl3Position9Value
            // 
            this.lbl3Position9Value.AutoSize = true;
            this.lbl3Position9Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl3Position9Value.ForeColor = System.Drawing.Color.Yellow;
            this.lbl3Position9Value.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl3Position9Value.Location = new System.Drawing.Point(72, 274);
            this.lbl3Position9Value.Name = "lbl3Position9Value";
            this.lbl3Position9Value.Size = new System.Drawing.Size(32, 33);
            this.lbl3Position9Value.TabIndex = 366;
            this.lbl3Position9Value.Text = "#";
            this.lbl3Position9Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl3Position9
            // 
            this.lbl3Position9.AutoSize = true;
            this.lbl3Position9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3Position9.ForeColor = System.Drawing.Color.White;
            this.lbl3Position9.Location = new System.Drawing.Point(7, 274);
            this.lbl3Position9.Name = "lbl3Position9";
            this.lbl3Position9.Size = new System.Drawing.Size(89, 33);
            this.lbl3Position9.TabIndex = 365;
            this.lbl3Position9.Text = "Mics:";
            // 
            // lbl3Position7
            // 
            this.lbl3Position7.AutoSize = true;
            this.lbl3Position7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3Position7.ForeColor = System.Drawing.Color.White;
            this.lbl3Position7.Location = new System.Drawing.Point(7, 229);
            this.lbl3Position7.Name = "lbl3Position7";
            this.lbl3Position7.Size = new System.Drawing.Size(112, 33);
            this.lbl3Position7.TabIndex = 364;
            this.lbl3Position7.Text = "Spotlit:";
            // 
            // lbl3Position2Flag
            // 
            this.lbl3Position2Flag.AutoSize = true;
            this.lbl3Position2Flag.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3Position2Flag.ForeColor = System.Drawing.Color.White;
            this.lbl3Position2Flag.Location = new System.Drawing.Point(157, 85);
            this.lbl3Position2Flag.Name = "lbl3Position2Flag";
            this.lbl3Position2Flag.Size = new System.Drawing.Size(40, 33);
            this.lbl3Position2Flag.TabIndex = 363;
            this.lbl3Position2Flag.Text = "M";
            // 
            // lbl3Position0Flag
            // 
            this.lbl3Position0Flag.AutoSize = true;
            this.lbl3Position0Flag.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3Position0Flag.ForeColor = System.Drawing.Color.White;
            this.lbl3Position0Flag.Location = new System.Drawing.Point(157, 48);
            this.lbl3Position0Flag.Name = "lbl3Position0Flag";
            this.lbl3Position0Flag.Size = new System.Drawing.Size(37, 33);
            this.lbl3Position0Flag.TabIndex = 362;
            this.lbl3Position0Flag.Text = "D";
            // 
            // lbl3Position4Value
            // 
            this.lbl3Position4Value.AutoSize = true;
            this.lbl3Position4Value.BackColor = System.Drawing.Color.Red;
            this.lbl3Position4Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl3Position4Value.ForeColor = System.Drawing.Color.Red;
            this.lbl3Position4Value.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl3Position4Value.Location = new System.Drawing.Point(316, 128);
            this.lbl3Position4Value.Name = "lbl3Position4Value";
            this.lbl3Position4Value.Size = new System.Drawing.Size(24, 33);
            this.lbl3Position4Value.TabIndex = 361;
            this.lbl3Position4Value.Text = ".";
            this.lbl3Position4Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl3Position5Value
            // 
            this.lbl3Position5Value.AutoSize = true;
            this.lbl3Position5Value.BackColor = System.Drawing.Color.Red;
            this.lbl3Position5Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl3Position5Value.ForeColor = System.Drawing.Color.Red;
            this.lbl3Position5Value.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl3Position5Value.Location = new System.Drawing.Point(101, 179);
            this.lbl3Position5Value.Name = "lbl3Position5Value";
            this.lbl3Position5Value.Size = new System.Drawing.Size(24, 33);
            this.lbl3Position5Value.TabIndex = 360;
            this.lbl3Position5Value.Text = ".";
            this.lbl3Position5Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl3Position6
            // 
            this.lbl3Position6.AutoSize = true;
            this.lbl3Position6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3Position6.ForeColor = System.Drawing.Color.White;
            this.lbl3Position6.Location = new System.Drawing.Point(246, 178);
            this.lbl3Position6.Name = "lbl3Position6";
            this.lbl3Position6.Size = new System.Drawing.Size(90, 33);
            this.lbl3Position6.TabIndex = 359;
            this.lbl3Position6.Text = "Strat:";
            // 
            // lbl3Position2Value
            // 
            this.lbl3Position2Value.AutoSize = true;
            this.lbl3Position2Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl3Position2Value.ForeColor = System.Drawing.Color.Yellow;
            this.lbl3Position2Value.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl3Position2Value.Location = new System.Drawing.Point(57, 85);
            this.lbl3Position2Value.Name = "lbl3Position2Value";
            this.lbl3Position2Value.Size = new System.Drawing.Size(49, 33);
            this.lbl3Position2Value.TabIndex = 358;
            this.lbl3Position2Value.Text = "$$";
            this.lbl3Position2Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl3Position1Value
            // 
            this.lbl3Position1Value.AutoSize = true;
            this.lbl3Position1Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl3Position1Value.ForeColor = System.Drawing.Color.Yellow;
            this.lbl3Position1Value.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl3Position1Value.Location = new System.Drawing.Point(299, 48);
            this.lbl3Position1Value.Name = "lbl3Position1Value";
            this.lbl3Position1Value.Size = new System.Drawing.Size(49, 33);
            this.lbl3Position1Value.TabIndex = 357;
            this.lbl3Position1Value.Text = "$$";
            this.lbl3Position1Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl3Position5
            // 
            this.lbl3Position5.AutoSize = true;
            this.lbl3Position5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3Position5.ForeColor = System.Drawing.Color.White;
            this.lbl3Position5.Location = new System.Drawing.Point(6, 180);
            this.lbl3Position5.Name = "lbl3Position5";
            this.lbl3Position5.Size = new System.Drawing.Size(147, 33);
            this.lbl3Position5.TabIndex = 356;
            this.lbl3Position5.Text = "HP Amp: ";
            // 
            // lbl3Position4
            // 
            this.lbl3Position4.AutoSize = true;
            this.lbl3Position4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3Position4.ForeColor = System.Drawing.Color.White;
            this.lbl3Position4.Location = new System.Drawing.Point(244, 128);
            this.lbl3Position4.Name = "lbl3Position4";
            this.lbl3Position4.Size = new System.Drawing.Size(108, 33);
            this.lbl3Position4.TabIndex = 353;
            this.lbl3Position4.Text = "Leave:";
            // 
            // lbl3Position8Value
            // 
            this.lbl3Position8Value.AutoSize = true;
            this.lbl3Position8Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl3Position8Value.ForeColor = System.Drawing.Color.Yellow;
            this.lbl3Position8Value.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl3Position8Value.Location = new System.Drawing.Point(291, 229);
            this.lbl3Position8Value.Name = "lbl3Position8Value";
            this.lbl3Position8Value.Size = new System.Drawing.Size(32, 33);
            this.lbl3Position8Value.TabIndex = 354;
            this.lbl3Position8Value.Text = "0";
            this.lbl3Position8Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl3Position0
            // 
            this.lbl3Position0.AutoSize = true;
            this.lbl3Position0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3Position0.ForeColor = System.Drawing.Color.White;
            this.lbl3Position0.Location = new System.Drawing.Point(5, 48);
            this.lbl3Position0.Name = "lbl3Position0";
            this.lbl3Position0.Size = new System.Drawing.Size(77, 33);
            this.lbl3Position0.TabIndex = 352;
            this.lbl3Position0.Text = "Acq:";
            // 
            // lbl3Position3Value
            // 
            this.lbl3Position3Value.AutoSize = true;
            this.lbl3Position3Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl3Position3Value.ForeColor = System.Drawing.Color.Yellow;
            this.lbl3Position3Value.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl3Position3Value.Location = new System.Drawing.Point(81, 129);
            this.lbl3Position3Value.Name = "lbl3Position3Value";
            this.lbl3Position3Value.Size = new System.Drawing.Size(32, 33);
            this.lbl3Position3Value.TabIndex = 349;
            this.lbl3Position3Value.Text = "#";
            this.lbl3Position3Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl3Position3
            // 
            this.lbl3Position3.AutoSize = true;
            this.lbl3Position3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3Position3.ForeColor = System.Drawing.Color.White;
            this.lbl3Position3.Location = new System.Drawing.Point(5, 128);
            this.lbl3Position3.Name = "lbl3Position3";
            this.lbl3Position3.Size = new System.Drawing.Size(104, 33);
            this.lbl3Position3.TabIndex = 351;
            this.lbl3Position3.Text = "Setup:";
            // 
            // lbl3Position8
            // 
            this.lbl3Position8.AutoSize = true;
            this.lbl3Position8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3Position8.ForeColor = System.Drawing.Color.White;
            this.lbl3Position8.Location = new System.Drawing.Point(247, 228);
            this.lbl3Position8.Name = "lbl3Position8";
            this.lbl3Position8.Size = new System.Drawing.Size(72, 33);
            this.lbl3Position8.TabIndex = 346;
            this.lbl3Position8.Text = "Def:";
            // 
            // lbl3Position1
            // 
            this.lbl3Position1.AutoSize = true;
            this.lbl3Position1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3Position1.ForeColor = System.Drawing.Color.White;
            this.lbl3Position1.Location = new System.Drawing.Point(244, 48);
            this.lbl3Position1.Name = "lbl3Position1";
            this.lbl3Position1.Size = new System.Drawing.Size(84, 33);
            this.lbl3Position1.TabIndex = 355;
            this.lbl3Position1.Text = "Orig:";
            // 
            // lbl3Position2
            // 
            this.lbl3Position2.AutoSize = true;
            this.lbl3Position2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3Position2.ForeColor = System.Drawing.Color.White;
            this.lbl3Position2.Location = new System.Drawing.Point(5, 85);
            this.lbl3Position2.Name = "lbl3Position2";
            this.lbl3Position2.Size = new System.Drawing.Size(71, 33);
            this.lbl3Position2.TabIndex = 350;
            this.lbl3Position2.Text = "Del:";
            // 
            // lbl3Position0Value
            // 
            this.lbl3Position0Value.AutoSize = true;
            this.lbl3Position0Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl3Position0Value.ForeColor = System.Drawing.Color.Yellow;
            this.lbl3Position0Value.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl3Position0Value.Location = new System.Drawing.Point(57, 48);
            this.lbl3Position0Value.Name = "lbl3Position0Value";
            this.lbl3Position0Value.Size = new System.Drawing.Size(49, 33);
            this.lbl3Position0Value.TabIndex = 347;
            this.lbl3Position0Value.Text = "$$";
            this.lbl3Position0Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.panel31.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel32.ResumeLayout(false);
            this.panel32.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel35.ResumeLayout(false);
            this.panel35.PerformLayout();
            this.panel36.ResumeLayout(false);
            this.panel36.PerformLayout();
            this.panel21.ResumeLayout(false);
            this.panel21.PerformLayout();
            this.panel39.ResumeLayout(false);
            this.panel39.PerformLayout();
            this.panel41.ResumeLayout(false);
            this.panel41.PerformLayout();
            this.team1.ResumeLayout(false);
            this.team1.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel23.ResumeLayout(false);
            this.panel23.PerformLayout();
            this.panel30.ResumeLayout(false);
            this.panel30.PerformLayout();
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
        private Panel panel9;
        private Label label4;
        private Label lbl2Position10Value;
        private Label lbl2Position10;
        private Label lbl2Position7Value;
        private Label lbl2Position9Value;
        private Label lbl2Position9;
        private Label lbl2Position7;
        private Label lbl2Position2Flag;
        private Label lbl2Position0Flag;
        private Label lbl2Position4Value;
        private Label lbl2Position5Value;
        private Label lbl2Position6;
        private Label lbl2Position2Value;
        private Label lbl2Position1Value;
        private Label lbl2Position5;
        private Label lbl2Position4;
        private Label lbl2Position8Value;
        private Label lbl2Position0;
        private Label lbl2Position3Value;
        private Label lbl2Position3;
        private Label lbl2Position8;
        private Label lbl2Position1;
        private Label lbl2Position2;
        private Label lbl2Position0Value;
        private Panel panel21;
        private Label label23;
        private Label lbl1Position6Value;
        private Label lbl1Position10Value;
        private Label lbl1Position10;
        private Label lbl1Position7Value;
        private Label lbl1Position9Value;
        private Label lbl1Position9;
        private Label lbl1Position7;
        private Label lbl1Position2Flag;
        private Label lbl1Position0Flag;
        private Label lbl1Position4Value;
        private Label lbl1Position5Value;
        private Label lbl1Position6;
        private Label lbl1Position2Value;
        private Label lbl1Position1Value;
        private Label lbl1Position5;
        private Label lbl1Position4;
        private Label lbl1Position8Value;
        private Label lbl1Position0;
        private Label lbl1Position3Value;
        private Label lbl1Position3;
        private Label lbl1Position8;
        private Label lbl1Position1;
        private Label lbl1Position2;
        private Label lbl1Position0Value;
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
        private Panel panel13;
        private Label label79;
        private Panel panel23;
        private Label label32;
        private Label lbl3Position6Value;
        private Label lbl3Position10Value;
        private Label lbl3Position10;
        private Label lbl3Position7Value;
        private Label lbl3Position9Value;
        private Label lbl3Position9;
        private Label lbl3Position7;
        private Label lbl3Position2Flag;
        private Label lbl3Position0Flag;
        private Label lbl3Position4Value;
        private Label lbl3Position5Value;
        private Label lbl3Position6;
        private Label lbl3Position2Value;
        private Label lbl3Position1Value;
        private Label lbl3Position5;
        private Label lbl3Position4;
        private Label lbl3Position8Value;
        private Label lbl3Position0;
        private Label lbl3Position3Value;
        private Label lbl3Position3;
        private Label lbl3Position8;
        private Label lbl3Position1;
        private Label lbl3Position2;
        private Label lbl3Position0Value;
        private Panel panel15;
        private Label label60;
        private Panel panel16;
        private Label label61;
        private Label lbl5Position6Value;
        private Label lbl5Position10Value;
        private Label lbl5Position10;
        private Label lbl5Position7Value;
        private Label lbl5Position9Value;
        private Label lbl5Position9;
        private Label lbl5Position7;
        private Label lbl5Position2Flag;
        private Label lbl5Position0Flag;
        private Label lbl5Position4Value;
        private Label lbl5Position5Value;
        private Label lbl5Position6;
        private Label lbl5Position2Value;
        private Label lbl5Position1Value;
        private Label lbl5Position5;
        private Label lbl5Position4;
        private Label lbl5Position8Value;
        private Label lbl5Position0;
        private Label lbl5Position3Value;
        private Label lbl5Position3;
        private Label lbl5Position8;
        private Label lbl5Position1;
        private Label lbl5Position2;
        private Label lbl5Position0Value;
        private Panel panel12;
        private Label label33;
        private Panel panel14;
        private Label label34;
        private Label lbl4Position6Value;
        private Label lbl4Position10Value;
        private Label lbl4Position10;
        private Label lbl4Position7Value;
        private Label lbl4Position9Value;
        private Label lbl4Position9;
        private Label lbl4Position7;
        private Label lbl4Position2Flag;
        private Label lbl4Position0Flag;
        private Label lbl4Position4Value;
        private Label lbl4Position5Value;
        private Label lbl4Position6;
        private Label lbl4Position2Value;
        private Label lbl4Position1Value;
        private Label lbl4Position5;
        private Label lbl4Position4;
        private Label lbl4Position8Value;
        private Label lbl4Position0;
        private Label lbl4Position3Value;
        private Label lbl4Position3;
        private Label lbl4Position8;
        private Label lbl4Position1;
        private Label lbl4Position2;
        private Label lbl4Position0Value;
        private Label lbl2Position6Value;
    }
}
