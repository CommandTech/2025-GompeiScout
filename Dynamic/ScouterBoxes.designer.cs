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
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
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
            this.panel9 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
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
            this.panel13 = new System.Windows.Forms.Panel();
            this.label79 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label33 = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.label60 = new System.Windows.Forms.Label();
            this.panel16 = new System.Windows.Forms.Panel();
            this.label61 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.label65 = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.label67 = new System.Windows.Forms.Label();
            this.label68 = new System.Windows.Forms.Label();
            this.label69 = new System.Windows.Forms.Label();
            this.label70 = new System.Windows.Forms.Label();
            this.label71 = new System.Windows.Forms.Label();
            this.label72 = new System.Windows.Forms.Label();
            this.label73 = new System.Windows.Forms.Label();
            this.label74 = new System.Windows.Forms.Label();
            this.label75 = new System.Windows.Forms.Label();
            this.label76 = new System.Windows.Forms.Label();
            this.label77 = new System.Windows.Forms.Label();
            this.label78 = new System.Windows.Forms.Label();
            this.label80 = new System.Windows.Forms.Label();
            this.label81 = new System.Windows.Forms.Label();
            this.label82 = new System.Windows.Forms.Label();
            this.label83 = new System.Windows.Forms.Label();
            this.label84 = new System.Windows.Forms.Label();
            this.label85 = new System.Windows.Forms.Label();
            this.label86 = new System.Windows.Forms.Label();
            this.panel31.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel32.SuspendLayout();
            this.panel35.SuspendLayout();
            this.panel36.SuspendLayout();
            this.panel39.SuspendLayout();
            this.panel41.SuspendLayout();
            this.team1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel30.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel21.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel23.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel16.SuspendLayout();
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
            this.panel32.Controls.Add(this.label5);
            this.panel32.Controls.Add(this.label6);
            this.panel32.Controls.Add(this.label7);
            this.panel32.Controls.Add(this.label8);
            this.panel32.Controls.Add(this.label9);
            this.panel32.Controls.Add(this.label10);
            this.panel32.Controls.Add(this.label11);
            this.panel32.Controls.Add(this.label12);
            this.panel32.Controls.Add(this.label13);
            this.panel32.Controls.Add(this.label14);
            this.panel32.Controls.Add(this.label15);
            this.panel32.Controls.Add(this.label16);
            this.panel32.Controls.Add(this.label17);
            this.panel32.Controls.Add(this.label18);
            this.panel32.Controls.Add(this.label20);
            this.panel32.Controls.Add(this.label21);
            this.panel32.Controls.Add(this.label22);
            this.panel32.Controls.Add(this.label24);
            this.panel32.Controls.Add(this.label25);
            this.panel32.Controls.Add(this.label26);
            this.panel32.Controls.Add(this.label27);
            this.panel32.Controls.Add(this.label29);
            this.panel32.Controls.Add(this.label30);
            this.panel32.Controls.Add(this.label31);
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
            this.panel3.Controls.Add(this.label62);
            this.panel3.Controls.Add(this.label63);
            this.panel3.Controls.Add(this.label64);
            this.panel3.Controls.Add(this.label65);
            this.panel3.Controls.Add(this.label66);
            this.panel3.Controls.Add(this.label67);
            this.panel3.Controls.Add(this.label68);
            this.panel3.Controls.Add(this.label69);
            this.panel3.Controls.Add(this.label70);
            this.panel3.Controls.Add(this.label71);
            this.panel3.Controls.Add(this.label72);
            this.panel3.Controls.Add(this.label73);
            this.panel3.Controls.Add(this.label74);
            this.panel3.Controls.Add(this.label75);
            this.panel3.Controls.Add(this.label76);
            this.panel3.Controls.Add(this.label77);
            this.panel3.Controls.Add(this.label78);
            this.panel3.Controls.Add(this.label80);
            this.panel3.Controls.Add(this.label81);
            this.panel3.Controls.Add(this.label82);
            this.panel3.Controls.Add(this.label83);
            this.panel3.Controls.Add(this.label84);
            this.panel3.Controls.Add(this.label85);
            this.panel3.Controls.Add(this.label86);
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
            this.panel7.Controls.Add(this.panel12);
            this.panel7.Controls.Add(this.panel14);
            this.panel7.Controls.Add(this.label35);
            this.panel7.Controls.Add(this.label36);
            this.panel7.Controls.Add(this.label37);
            this.panel7.Controls.Add(this.label38);
            this.panel7.Controls.Add(this.label39);
            this.panel7.Controls.Add(this.label40);
            this.panel7.Controls.Add(this.label41);
            this.panel7.Controls.Add(this.label42);
            this.panel7.Controls.Add(this.label43);
            this.panel7.Controls.Add(this.label44);
            this.panel7.Controls.Add(this.label45);
            this.panel7.Controls.Add(this.label46);
            this.panel7.Controls.Add(this.label47);
            this.panel7.Controls.Add(this.label48);
            this.panel7.Controls.Add(this.label49);
            this.panel7.Controls.Add(this.label50);
            this.panel7.Controls.Add(this.label51);
            this.panel7.Controls.Add(this.label52);
            this.panel7.Controls.Add(this.label53);
            this.panel7.Controls.Add(this.label55);
            this.panel7.Controls.Add(this.label56);
            this.panel7.Controls.Add(this.label57);
            this.panel7.Controls.Add(this.label58);
            this.panel7.Controls.Add(this.label59);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label5.Location = new System.Drawing.Point(305, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 33);
            this.label5.TabIndex = 395;
            this.label5.Text = "$$";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Yellow;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label6.Location = new System.Drawing.Point(287, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 33);
            this.label6.TabIndex = 394;
            this.label6.Text = "0";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(243, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 33);
            this.label7.TabIndex = 393;
            this.label7.Text = "Avo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Red;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label8.Location = new System.Drawing.Point(98, 234);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 33);
            this.label8.TabIndex = 392;
            this.label8.Text = ".";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Yellow;
            this.label9.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label9.Location = new System.Drawing.Point(71, 279);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 33);
            this.label9.TabIndex = 391;
            this.label9.Text = "#";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(6, 279);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 33);
            this.label10.TabIndex = 390;
            this.label10.Text = "Mics:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(3, 234);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 33);
            this.label11.TabIndex = 389;
            this.label11.Text = "Spotlit:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(154, 94);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 33);
            this.label12.TabIndex = 388;
            this.label12.Text = "M";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(154, 57);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 33);
            this.label13.TabIndex = 387;
            this.label13.Text = "D";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Red;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label14.Location = new System.Drawing.Point(315, 137);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(24, 33);
            this.label14.TabIndex = 386;
            this.label14.Text = ".";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Red;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label15.Location = new System.Drawing.Point(98, 178);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(24, 33);
            this.label15.TabIndex = 385;
            this.label15.Text = ".";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(244, 188);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(90, 33);
            this.label16.TabIndex = 384;
            this.label16.Text = "Strat:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label17.ForeColor = System.Drawing.Color.Yellow;
            this.label17.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label17.Location = new System.Drawing.Point(54, 94);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(49, 33);
            this.label17.TabIndex = 383;
            this.label17.Text = "$$";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label18.ForeColor = System.Drawing.Color.Yellow;
            this.label18.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label18.Location = new System.Drawing.Point(299, 57);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(49, 33);
            this.label18.TabIndex = 382;
            this.label18.Text = "$$";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(3, 179);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(147, 33);
            this.label20.TabIndex = 381;
            this.label20.Text = "HP Amp: ";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(243, 137);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(108, 33);
            this.label21.TabIndex = 378;
            this.label21.Text = "Leave:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label22.ForeColor = System.Drawing.Color.Yellow;
            this.label22.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label22.Location = new System.Drawing.Point(288, 235);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(32, 33);
            this.label22.TabIndex = 379;
            this.label22.Text = "0";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.White;
            this.label24.Location = new System.Drawing.Point(2, 57);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(77, 33);
            this.label24.TabIndex = 377;
            this.label24.Text = "Acq:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label25.ForeColor = System.Drawing.Color.Yellow;
            this.label25.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label25.Location = new System.Drawing.Point(78, 138);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(32, 33);
            this.label25.TabIndex = 374;
            this.label25.Text = "#";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.White;
            this.label26.Location = new System.Drawing.Point(2, 137);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(104, 33);
            this.label26.TabIndex = 376;
            this.label26.Text = "Setup:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.White;
            this.label27.Location = new System.Drawing.Point(244, 234);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(72, 33);
            this.label27.TabIndex = 371;
            this.label27.Text = "Def:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.White;
            this.label29.Location = new System.Drawing.Point(244, 57);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(84, 33);
            this.label29.TabIndex = 380;
            this.label29.Text = "Orig:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.Color.White;
            this.label30.Location = new System.Drawing.Point(2, 94);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(71, 33);
            this.label30.TabIndex = 375;
            this.label30.Text = "Del:";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label31.ForeColor = System.Drawing.Color.Yellow;
            this.label31.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label31.Location = new System.Drawing.Point(54, 57);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(49, 33);
            this.label31.TabIndex = 372;
            this.label31.Text = "$$";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label35.ForeColor = System.Drawing.Color.Yellow;
            this.label35.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label35.Location = new System.Drawing.Point(315, 179);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(49, 33);
            this.label35.TabIndex = 396;
            this.label35.Text = "$$";
            this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label36.ForeColor = System.Drawing.Color.Yellow;
            this.label36.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label36.Location = new System.Drawing.Point(299, 274);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(32, 33);
            this.label36.TabIndex = 395;
            this.label36.Text = "0";
            this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.ForeColor = System.Drawing.Color.White;
            this.label37.Location = new System.Drawing.Point(255, 273);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(77, 33);
            this.label37.TabIndex = 394;
            this.label37.Text = "Avo:";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.BackColor = System.Drawing.Color.Red;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label38.ForeColor = System.Drawing.Color.Red;
            this.label38.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label38.Location = new System.Drawing.Point(110, 228);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(24, 33);
            this.label38.TabIndex = 393;
            this.label38.Text = ".";
            this.label38.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label39.ForeColor = System.Drawing.Color.Yellow;
            this.label39.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label39.Location = new System.Drawing.Point(80, 273);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(32, 33);
            this.label39.TabIndex = 392;
            this.label39.Text = "#";
            this.label39.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.ForeColor = System.Drawing.Color.White;
            this.label40.Location = new System.Drawing.Point(15, 273);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(89, 33);
            this.label40.TabIndex = 391;
            this.label40.Text = "Mics:";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.ForeColor = System.Drawing.Color.White;
            this.label41.Location = new System.Drawing.Point(15, 228);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(112, 33);
            this.label41.TabIndex = 390;
            this.label41.Text = "Spotlit:";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.ForeColor = System.Drawing.Color.White;
            this.label42.Location = new System.Drawing.Point(165, 84);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(40, 33);
            this.label42.TabIndex = 389;
            this.label42.Text = "M";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.ForeColor = System.Drawing.Color.White;
            this.label43.Location = new System.Drawing.Point(165, 47);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(37, 33);
            this.label43.TabIndex = 388;
            this.label43.Text = "D";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.BackColor = System.Drawing.Color.Red;
            this.label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label44.ForeColor = System.Drawing.Color.Red;
            this.label44.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label44.Location = new System.Drawing.Point(324, 127);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(24, 33);
            this.label44.TabIndex = 387;
            this.label44.Text = ".";
            this.label44.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.BackColor = System.Drawing.Color.Red;
            this.label45.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label45.ForeColor = System.Drawing.Color.Red;
            this.label45.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label45.Location = new System.Drawing.Point(109, 178);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(24, 33);
            this.label45.TabIndex = 386;
            this.label45.Text = ".";
            this.label45.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.ForeColor = System.Drawing.Color.White;
            this.label46.Location = new System.Drawing.Point(254, 178);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(90, 33);
            this.label46.TabIndex = 385;
            this.label46.Text = "Strat:";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label47.ForeColor = System.Drawing.Color.Yellow;
            this.label47.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label47.Location = new System.Drawing.Point(65, 84);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(49, 33);
            this.label47.TabIndex = 384;
            this.label47.Text = "$$";
            this.label47.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label48.ForeColor = System.Drawing.Color.Yellow;
            this.label48.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label48.Location = new System.Drawing.Point(307, 47);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(49, 33);
            this.label48.TabIndex = 383;
            this.label48.Text = "$$";
            this.label48.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label49.ForeColor = System.Drawing.Color.White;
            this.label49.Location = new System.Drawing.Point(14, 179);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(147, 33);
            this.label49.TabIndex = 382;
            this.label49.Text = "HP Amp: ";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label50.ForeColor = System.Drawing.Color.White;
            this.label50.Location = new System.Drawing.Point(252, 127);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(108, 33);
            this.label50.TabIndex = 379;
            this.label50.Text = "Leave:";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label51.ForeColor = System.Drawing.Color.Yellow;
            this.label51.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label51.Location = new System.Drawing.Point(299, 228);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(32, 33);
            this.label51.TabIndex = 380;
            this.label51.Text = "0";
            this.label51.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label52.ForeColor = System.Drawing.Color.White;
            this.label52.Location = new System.Drawing.Point(13, 47);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(77, 33);
            this.label52.TabIndex = 378;
            this.label52.Text = "Acq:";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label53.ForeColor = System.Drawing.Color.Yellow;
            this.label53.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label53.Location = new System.Drawing.Point(89, 128);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(32, 33);
            this.label53.TabIndex = 375;
            this.label53.Text = "#";
            this.label53.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label55.ForeColor = System.Drawing.Color.White;
            this.label55.Location = new System.Drawing.Point(13, 127);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(104, 33);
            this.label55.TabIndex = 377;
            this.label55.Text = "Setup:";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label56.ForeColor = System.Drawing.Color.White;
            this.label56.Location = new System.Drawing.Point(255, 227);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(72, 33);
            this.label56.TabIndex = 372;
            this.label56.Text = "Def:";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label57.ForeColor = System.Drawing.Color.White;
            this.label57.Location = new System.Drawing.Point(252, 47);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(84, 33);
            this.label57.TabIndex = 381;
            this.label57.Text = "Orig:";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label58.ForeColor = System.Drawing.Color.White;
            this.label58.Location = new System.Drawing.Point(13, 84);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(71, 33);
            this.label58.TabIndex = 376;
            this.label58.Text = "Del:";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label59.ForeColor = System.Drawing.Color.Yellow;
            this.label59.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label59.Location = new System.Drawing.Point(65, 47);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(49, 33);
            this.label59.TabIndex = 373;
            this.label59.Text = "$$";
            this.label59.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label62.ForeColor = System.Drawing.Color.Yellow;
            this.label62.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label62.Location = new System.Drawing.Point(313, 184);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(49, 33);
            this.label62.TabIndex = 396;
            this.label62.Text = "$$";
            this.label62.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label63.ForeColor = System.Drawing.Color.Yellow;
            this.label63.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label63.Location = new System.Drawing.Point(297, 279);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(32, 33);
            this.label63.TabIndex = 395;
            this.label63.Text = "0";
            this.label63.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label64.ForeColor = System.Drawing.Color.White;
            this.label64.Location = new System.Drawing.Point(253, 278);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(77, 33);
            this.label64.TabIndex = 394;
            this.label64.Text = "Avo:";
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.BackColor = System.Drawing.Color.Red;
            this.label65.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label65.ForeColor = System.Drawing.Color.Red;
            this.label65.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label65.Location = new System.Drawing.Point(108, 233);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(24, 33);
            this.label65.TabIndex = 393;
            this.label65.Text = ".";
            this.label65.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label66.ForeColor = System.Drawing.Color.Yellow;
            this.label66.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label66.Location = new System.Drawing.Point(78, 278);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(32, 33);
            this.label66.TabIndex = 392;
            this.label66.Text = "#";
            this.label66.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label67.ForeColor = System.Drawing.Color.White;
            this.label67.Location = new System.Drawing.Point(13, 278);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(89, 33);
            this.label67.TabIndex = 391;
            this.label67.Text = "Mics:";
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label68.ForeColor = System.Drawing.Color.White;
            this.label68.Location = new System.Drawing.Point(13, 233);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(112, 33);
            this.label68.TabIndex = 390;
            this.label68.Text = "Spotlit:";
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label69.ForeColor = System.Drawing.Color.White;
            this.label69.Location = new System.Drawing.Point(163, 89);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(40, 33);
            this.label69.TabIndex = 389;
            this.label69.Text = "M";
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label70.ForeColor = System.Drawing.Color.White;
            this.label70.Location = new System.Drawing.Point(163, 52);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(37, 33);
            this.label70.TabIndex = 388;
            this.label70.Text = "D";
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.BackColor = System.Drawing.Color.Red;
            this.label71.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label71.ForeColor = System.Drawing.Color.Red;
            this.label71.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label71.Location = new System.Drawing.Point(322, 132);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(24, 33);
            this.label71.TabIndex = 387;
            this.label71.Text = ".";
            this.label71.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.BackColor = System.Drawing.Color.Red;
            this.label72.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label72.ForeColor = System.Drawing.Color.Red;
            this.label72.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label72.Location = new System.Drawing.Point(107, 183);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(24, 33);
            this.label72.TabIndex = 386;
            this.label72.Text = ".";
            this.label72.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label73.ForeColor = System.Drawing.Color.White;
            this.label73.Location = new System.Drawing.Point(252, 183);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(90, 33);
            this.label73.TabIndex = 385;
            this.label73.Text = "Strat:";
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label74.ForeColor = System.Drawing.Color.Yellow;
            this.label74.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label74.Location = new System.Drawing.Point(63, 89);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(49, 33);
            this.label74.TabIndex = 384;
            this.label74.Text = "$$";
            this.label74.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label75.ForeColor = System.Drawing.Color.Yellow;
            this.label75.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label75.Location = new System.Drawing.Point(305, 52);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(49, 33);
            this.label75.TabIndex = 383;
            this.label75.Text = "$$";
            this.label75.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label76.ForeColor = System.Drawing.Color.White;
            this.label76.Location = new System.Drawing.Point(12, 184);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(147, 33);
            this.label76.TabIndex = 382;
            this.label76.Text = "HP Amp: ";
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label77.ForeColor = System.Drawing.Color.White;
            this.label77.Location = new System.Drawing.Point(250, 132);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(108, 33);
            this.label77.TabIndex = 379;
            this.label77.Text = "Leave:";
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label78.ForeColor = System.Drawing.Color.Yellow;
            this.label78.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label78.Location = new System.Drawing.Point(297, 233);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(32, 33);
            this.label78.TabIndex = 380;
            this.label78.Text = "0";
            this.label78.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label80
            // 
            this.label80.AutoSize = true;
            this.label80.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label80.ForeColor = System.Drawing.Color.White;
            this.label80.Location = new System.Drawing.Point(11, 52);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(77, 33);
            this.label80.TabIndex = 378;
            this.label80.Text = "Acq:";
            // 
            // label81
            // 
            this.label81.AutoSize = true;
            this.label81.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label81.ForeColor = System.Drawing.Color.Yellow;
            this.label81.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label81.Location = new System.Drawing.Point(87, 133);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(32, 33);
            this.label81.TabIndex = 375;
            this.label81.Text = "#";
            this.label81.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label82
            // 
            this.label82.AutoSize = true;
            this.label82.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label82.ForeColor = System.Drawing.Color.White;
            this.label82.Location = new System.Drawing.Point(11, 132);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(104, 33);
            this.label82.TabIndex = 377;
            this.label82.Text = "Setup:";
            // 
            // label83
            // 
            this.label83.AutoSize = true;
            this.label83.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label83.ForeColor = System.Drawing.Color.White;
            this.label83.Location = new System.Drawing.Point(253, 232);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(72, 33);
            this.label83.TabIndex = 372;
            this.label83.Text = "Def:";
            // 
            // label84
            // 
            this.label84.AutoSize = true;
            this.label84.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label84.ForeColor = System.Drawing.Color.White;
            this.label84.Location = new System.Drawing.Point(250, 52);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(84, 33);
            this.label84.TabIndex = 381;
            this.label84.Text = "Orig:";
            // 
            // label85
            // 
            this.label85.AutoSize = true;
            this.label85.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label85.ForeColor = System.Drawing.Color.White;
            this.label85.Location = new System.Drawing.Point(11, 89);
            this.label85.Name = "label85";
            this.label85.Size = new System.Drawing.Size(71, 33);
            this.label85.TabIndex = 376;
            this.label85.Text = "Del:";
            // 
            // label86
            // 
            this.label86.AutoSize = true;
            this.label86.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label86.ForeColor = System.Drawing.Color.Yellow;
            this.label86.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label86.Location = new System.Drawing.Point(63, 52);
            this.label86.Name = "label86";
            this.label86.Size = new System.Drawing.Size(49, 33);
            this.label86.TabIndex = 373;
            this.label86.Text = "$$";
            this.label86.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.panel35.ResumeLayout(false);
            this.panel35.PerformLayout();
            this.panel36.ResumeLayout(false);
            this.panel36.PerformLayout();
            this.panel39.ResumeLayout(false);
            this.panel39.PerformLayout();
            this.panel41.ResumeLayout(false);
            this.panel41.PerformLayout();
            this.team1.ResumeLayout(false);
            this.team1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel30.ResumeLayout(false);
            this.panel30.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel21.ResumeLayout(false);
            this.panel21.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel23.ResumeLayout(false);
            this.panel23.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
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
        private Panel panel9;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label20;
        private Label label21;
        private Label label22;
        private Label label24;
        private Label label25;
        private Label label26;
        private Label label27;
        private Label label29;
        private Label label30;
        private Label label31;
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
        private Label label62;
        private Label label63;
        private Label label64;
        private Label label65;
        private Label label66;
        private Label label67;
        private Label label68;
        private Label label69;
        private Label label70;
        private Label label71;
        private Label label72;
        private Label label73;
        private Label label74;
        private Label label75;
        private Label label76;
        private Label label77;
        private Label label78;
        private Label label80;
        private Label label81;
        private Label label82;
        private Label label83;
        private Label label84;
        private Label label85;
        private Label label86;
        private Panel panel12;
        private Label label33;
        private Panel panel14;
        private Label label34;
        private Label label35;
        private Label label36;
        private Label label37;
        private Label label38;
        private Label label39;
        private Label label40;
        private Label label41;
        private Label label42;
        private Label label43;
        private Label label44;
        private Label label45;
        private Label label46;
        private Label label47;
        private Label label48;
        private Label label49;
        private Label label50;
        private Label label51;
        private Label label52;
        private Label label53;
        private Label label55;
        private Label label56;
        private Label label57;
        private Label label58;
        private Label label59;
    }
}
