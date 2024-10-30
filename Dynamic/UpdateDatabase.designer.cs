using System;
using System.Linq;

namespace ScoutingCodeRedo.Dynamic
{
    partial class UpdateDatabase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.btnFetchValues = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnUpdateDatabase = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.checkEndMatch = new System.Windows.Forms.CheckBox();
            this.checkEndAuto = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboStageLoc = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMics = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLit = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboStageStat = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtHarm = new System.Windows.Forms.TextBox();
            this.comboStageAtt = new System.Windows.Forms.ComboBox();
            this.txtClimbTime = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboAcqCenter = new System.Windows.Forms.ComboBox();
            this.comboAcqLoc = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtAcqDrp = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtAcqDis = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboDelOrg = new System.Windows.Forms.ComboBox();
            this.comboDelDest = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtOZTime = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNZTime = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtAZTime = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtDelMiss = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.txtRobotSetup = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtLeave = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.txtHPAmp = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtAvoidance = new System.Windows.Forms.TextBox();
            this.txtDefense = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboMatchEvent = new System.Windows.Forms.ComboBox();
            this.comboMode = new System.Windows.Forms.ComboBox();
            this.comboStrategy = new System.Windows.Forms.ComboBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.btnCreateTable = new System.Windows.Forms.Button();
            this.label37 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboTeamNumber = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboMatchNumber = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.checkActivities = new System.Windows.Forms.CheckBox();
            this.checkMatchEvent = new System.Windows.Forms.CheckBox();
            this.updatePreviewsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matchDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recordTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leaveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acqLocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acqCenterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acqDisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acqDrpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delOrigDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delDestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delMissDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driveStaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.robotStaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hPAmpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stageStatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stageAttDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stageLocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.harmonyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spotlitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.climbTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oZTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nZTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aZTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.defenseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avoidanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strategyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.micsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scouterNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scouterErrorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matcheventDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel10.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updatePreviewsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Goldenrod;
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Controls.Add(this.panel12);
            this.panel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel10.Location = new System.Drawing.Point(892, 777);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(203, 40);
            this.panel10.TabIndex = 363;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.Black;
            this.panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel12.Controls.Add(this.btnFetchValues);
            this.panel12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel12.Location = new System.Drawing.Point(-2, -2);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(203, 40);
            this.panel12.TabIndex = 351;
            // 
            // btnFetchValues
            // 
            this.btnFetchValues.BackColor = System.Drawing.Color.Black;
            this.btnFetchValues.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFetchValues.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnFetchValues.Location = new System.Drawing.Point(8, 2);
            this.btnFetchValues.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFetchValues.Name = "btnFetchValues";
            this.btnFetchValues.Size = new System.Drawing.Size(188, 35);
            this.btnFetchValues.TabIndex = 11;
            this.btnFetchValues.Text = "Fetch Values";
            this.btnFetchValues.UseVisualStyleBackColor = false;
            this.btnFetchValues.Click += new System.EventHandler(this.BtnFetchValues_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Goldenrod;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.button2);
            this.panel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(1104, 777);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(203, 40);
            this.panel5.TabIndex = 362;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Goldenrod;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel6.Location = new System.Drawing.Point(-2, -2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(203, 40);
            this.panel6.TabIndex = 351;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Goldenrod;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel7.Location = new System.Drawing.Point(-2, -2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(203, 40);
            this.panel7.TabIndex = 351;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Black;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.btnUpdateDatabase);
            this.panel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel8.Location = new System.Drawing.Point(-2, -2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(203, 40);
            this.panel8.TabIndex = 351;
            // 
            // btnUpdateDatabase
            // 
            this.btnUpdateDatabase.BackColor = System.Drawing.Color.Black;
            this.btnUpdateDatabase.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateDatabase.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnUpdateDatabase.Location = new System.Drawing.Point(6, 2);
            this.btnUpdateDatabase.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdateDatabase.Name = "btnUpdateDatabase";
            this.btnUpdateDatabase.Size = new System.Drawing.Size(188, 35);
            this.btnUpdateDatabase.TabIndex = 11;
            this.btnUpdateDatabase.Text = "Update Database";
            this.btnUpdateDatabase.UseVisualStyleBackColor = false;
            this.btnUpdateDatabase.Click += new System.EventHandler(this.BtnUpdateDatabase_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MidnightBlue;
            this.button2.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.AliceBlue;
            this.button2.Location = new System.Drawing.Point(6, 2);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 35);
            this.button2.TabIndex = 11;
            this.button2.Text = "Update Database";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // checkEndMatch
            // 
            this.checkEndMatch.AutoSize = true;
            this.checkEndMatch.BackColor = System.Drawing.Color.Black;
            this.checkEndMatch.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEndMatch.ForeColor = System.Drawing.Color.White;
            this.checkEndMatch.Location = new System.Drawing.Point(609, 28);
            this.checkEndMatch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkEndMatch.Name = "checkEndMatch";
            this.checkEndMatch.Size = new System.Drawing.Size(116, 27);
            this.checkEndMatch.TabIndex = 357;
            this.checkEndMatch.Text = "EndMatch";
            this.checkEndMatch.UseVisualStyleBackColor = false;
            // 
            // checkEndAuto
            // 
            this.checkEndAuto.AutoSize = true;
            this.checkEndAuto.BackColor = System.Drawing.Color.Black;
            this.checkEndAuto.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEndAuto.ForeColor = System.Drawing.Color.White;
            this.checkEndAuto.Location = new System.Drawing.Point(468, 28);
            this.checkEndAuto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkEndAuto.Name = "checkEndAuto";
            this.checkEndAuto.Size = new System.Drawing.Size(106, 27);
            this.checkEndAuto.TabIndex = 356;
            this.checkEndAuto.Text = "EndAuto";
            this.checkEndAuto.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.groupBox3);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Controls.Add(this.label32);
            this.panel3.Controls.Add(this.txtRobotSetup);
            this.panel3.Controls.Add(this.txtID);
            this.panel3.Controls.Add(this.txtLeave);
            this.panel3.Controls.Add(this.label31);
            this.panel3.Controls.Add(this.label33);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label30);
            this.panel3.Controls.Add(this.label34);
            this.panel3.Controls.Add(this.txtHPAmp);
            this.panel3.Controls.Add(this.label29);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(18, 138);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1291, 312);
            this.panel3.TabIndex = 359;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Black;
            this.groupBox3.Controls.Add(this.comboStageLoc);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtMics);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtLit);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.comboStageStat);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.txtHarm);
            this.groupBox3.Controls.Add(this.comboStageAtt);
            this.groupBox3.Controls.Add(this.txtClimbTime);
            this.groupBox3.Controls.Add(this.label26);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.label24);
            this.groupBox3.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox3.Location = new System.Drawing.Point(524, 9);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(231, 294);
            this.groupBox3.TabIndex = 41;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "SHOWTIME";
            // 
            // comboStageLoc
            // 
            this.comboStageLoc.BackColor = System.Drawing.Color.Black;
            this.comboStageLoc.ForeColor = System.Drawing.Color.White;
            this.comboStageLoc.FormattingEnabled = true;
            this.comboStageLoc.Items.AddRange(new object[] {
            "Select",
            "L",
            "C",
            "R"});
            this.comboStageLoc.Location = new System.Drawing.Point(20, 182);
            this.comboStageLoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboStageLoc.Name = "comboStageLoc";
            this.comboStageLoc.Size = new System.Drawing.Size(88, 33);
            this.comboStageLoc.TabIndex = 50;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(21, 158);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 23);
            this.label10.TabIndex = 49;
            this.label10.Text = "Stage Loc";
            // 
            // txtMics
            // 
            this.txtMics.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtMics.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMics.ForeColor = System.Drawing.Color.White;
            this.txtMics.Location = new System.Drawing.Point(156, 183);
            this.txtMics.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMics.Name = "txtMics";
            this.txtMics.Size = new System.Drawing.Size(46, 29);
            this.txtMics.TabIndex = 48;
            this.txtMics.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(153, 158);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 23);
            this.label8.TabIndex = 47;
            this.label8.Text = "Mics";
            // 
            // txtLit
            // 
            this.txtLit.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtLit.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLit.ForeColor = System.Drawing.Color.White;
            this.txtLit.Location = new System.Drawing.Point(153, 117);
            this.txtLit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLit.Name = "txtLit";
            this.txtLit.Size = new System.Drawing.Size(46, 29);
            this.txtLit.TabIndex = 46;
            this.txtLit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(148, 92);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 23);
            this.label6.TabIndex = 45;
            this.label6.Text = "Lit";
            // 
            // comboStageStat
            // 
            this.comboStageStat.BackColor = System.Drawing.Color.Black;
            this.comboStageStat.ForeColor = System.Drawing.Color.White;
            this.comboStageStat.FormattingEnabled = true;
            this.comboStageStat.Items.AddRange(new object[] {
            "Select",
            "Onstage",
            "Park",
            "Elsewhere"});
            this.comboStageStat.Location = new System.Drawing.Point(18, 48);
            this.comboStageStat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboStageStat.Name = "comboStageStat";
            this.comboStageStat.Size = new System.Drawing.Size(88, 33);
            this.comboStageStat.TabIndex = 44;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(12, 23);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(95, 23);
            this.label16.TabIndex = 43;
            this.label16.Text = "Stage Stat";
            // 
            // txtHarm
            // 
            this.txtHarm.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtHarm.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHarm.ForeColor = System.Drawing.Color.White;
            this.txtHarm.Location = new System.Drawing.Point(153, 46);
            this.txtHarm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHarm.Name = "txtHarm";
            this.txtHarm.Size = new System.Drawing.Size(46, 29);
            this.txtHarm.TabIndex = 42;
            this.txtHarm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboStageAtt
            // 
            this.comboStageAtt.BackColor = System.Drawing.Color.Black;
            this.comboStageAtt.ForeColor = System.Drawing.Color.White;
            this.comboStageAtt.FormattingEnabled = true;
            this.comboStageAtt.Location = new System.Drawing.Point(20, 117);
            this.comboStageAtt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboStageAtt.Name = "comboStageAtt";
            this.comboStageAtt.Size = new System.Drawing.Size(88, 33);
            this.comboStageAtt.TabIndex = 38;
            // 
            // txtClimbTime
            // 
            this.txtClimbTime.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtClimbTime.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClimbTime.ForeColor = System.Drawing.Color.White;
            this.txtClimbTime.Location = new System.Drawing.Point(20, 245);
            this.txtClimbTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtClimbTime.Name = "txtClimbTime";
            this.txtClimbTime.Size = new System.Drawing.Size(62, 29);
            this.txtClimbTime.TabIndex = 41;
            this.txtClimbTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(15, 222);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(104, 23);
            this.label26.TabIndex = 40;
            this.label26.Text = "Climb Time";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(148, 22);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(55, 23);
            this.label23.TabIndex = 31;
            this.label23.Text = "Harm";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(14, 92);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(88, 23);
            this.label24.TabIndex = 35;
            this.label24.Text = "Stage Att";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.comboAcqCenter);
            this.groupBox1.Controls.Add(this.comboAcqLoc);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtAcqDrp);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtAcqDis);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(18, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(176, 295);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ACQUISITION";
            // 
            // comboAcqCenter
            // 
            this.comboAcqCenter.BackColor = System.Drawing.Color.Black;
            this.comboAcqCenter.ForeColor = System.Drawing.Color.White;
            this.comboAcqCenter.FormattingEnabled = true;
            this.comboAcqCenter.Location = new System.Drawing.Point(18, 126);
            this.comboAcqCenter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboAcqCenter.Name = "comboAcqCenter";
            this.comboAcqCenter.Size = new System.Drawing.Size(88, 36);
            this.comboAcqCenter.TabIndex = 355;
            // 
            // comboAcqLoc
            // 
            this.comboAcqLoc.BackColor = System.Drawing.Color.Black;
            this.comboAcqLoc.ForeColor = System.Drawing.Color.White;
            this.comboAcqLoc.FormattingEnabled = true;
            this.comboAcqLoc.Items.AddRange(new object[] {
            "OppWing",
            "Neutral",
            "AllyWing",
            "Source",
            "Preload"});
            this.comboAcqLoc.Location = new System.Drawing.Point(16, 54);
            this.comboAcqLoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboAcqLoc.Name = "comboAcqLoc";
            this.comboAcqLoc.Size = new System.Drawing.Size(133, 36);
            this.comboAcqLoc.TabIndex = 354;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(102, 177);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 23);
            this.label14.TabIndex = 39;
            this.label14.Text = "AcqDrp";
            // 
            // txtAcqDrp
            // 
            this.txtAcqDrp.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtAcqDrp.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAcqDrp.ForeColor = System.Drawing.Color.White;
            this.txtAcqDrp.Location = new System.Drawing.Point(104, 202);
            this.txtAcqDrp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAcqDrp.Name = "txtAcqDrp";
            this.txtAcqDrp.Size = new System.Drawing.Size(46, 29);
            this.txtAcqDrp.TabIndex = 38;
            this.txtAcqDrp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(15, 177);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 23);
            this.label15.TabIndex = 37;
            this.label15.Text = "AcqDis";
            // 
            // txtAcqDis
            // 
            this.txtAcqDis.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtAcqDis.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAcqDis.ForeColor = System.Drawing.Color.White;
            this.txtAcqDis.Location = new System.Drawing.Point(16, 202);
            this.txtAcqDis.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAcqDis.Name = "txtAcqDis";
            this.txtAcqDis.Size = new System.Drawing.Size(46, 29);
            this.txtAcqDis.TabIndex = 36;
            this.txtAcqDis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(14, 29);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 23);
            this.label11.TabIndex = 29;
            this.label11.Text = "Acq Loc";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(16, 103);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 23);
            this.label13.TabIndex = 33;
            this.label13.Text = "Acq Center";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Black;
            this.groupBox2.Controls.Add(this.comboDelOrg);
            this.groupBox2.Controls.Add(this.comboDelDest);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.txtOZTime);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtNZTime);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.txtAZTime);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.txtDelMiss);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Location = new System.Drawing.Point(218, 6);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(280, 297);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DELIVERY";
            // 
            // comboDelOrg
            // 
            this.comboDelOrg.BackColor = System.Drawing.Color.Black;
            this.comboDelOrg.ForeColor = System.Drawing.Color.White;
            this.comboDelOrg.FormattingEnabled = true;
            this.comboDelOrg.Items.AddRange(new object[] {
            "SubW",
            "AllyW",
            "Neut",
            "OppW"});
            this.comboDelOrg.Location = new System.Drawing.Point(144, 54);
            this.comboDelOrg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboDelOrg.Name = "comboDelOrg";
            this.comboDelOrg.Size = new System.Drawing.Size(88, 36);
            this.comboDelOrg.TabIndex = 357;
            // 
            // comboDelDest
            // 
            this.comboDelDest.BackColor = System.Drawing.Color.Black;
            this.comboDelDest.ForeColor = System.Drawing.Color.White;
            this.comboDelDest.FormattingEnabled = true;
            this.comboDelDest.Items.AddRange(new object[] {
            "Select",
            "Spkr",
            "Amp",
            "Trap",
            "AllyW",
            "Neut"});
            this.comboDelDest.Location = new System.Drawing.Point(14, 54);
            this.comboDelDest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboDelDest.Name = "comboDelDest";
            this.comboDelDest.Size = new System.Drawing.Size(88, 36);
            this.comboDelDest.TabIndex = 356;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(141, 35);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 23);
            this.label12.TabIndex = 355;
            this.label12.Text = "Del Org";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(200, 215);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(73, 23);
            this.label22.TabIndex = 45;
            this.label22.Text = "OZTime";
            // 
            // txtOZTime
            // 
            this.txtOZTime.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtOZTime.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOZTime.ForeColor = System.Drawing.Color.White;
            this.txtOZTime.Location = new System.Drawing.Point(208, 240);
            this.txtOZTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOZTime.Name = "txtOZTime";
            this.txtOZTime.Size = new System.Drawing.Size(46, 29);
            this.txtOZTime.TabIndex = 44;
            this.txtOZTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(108, 214);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 23);
            this.label9.TabIndex = 43;
            this.label9.Text = "NZTime";
            // 
            // txtNZTime
            // 
            this.txtNZTime.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtNZTime.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNZTime.ForeColor = System.Drawing.Color.White;
            this.txtNZTime.Location = new System.Drawing.Point(112, 238);
            this.txtNZTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNZTime.Name = "txtNZTime";
            this.txtNZTime.Size = new System.Drawing.Size(46, 29);
            this.txtNZTime.TabIndex = 42;
            this.txtNZTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(16, 214);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(72, 23);
            this.label17.TabIndex = 37;
            this.label17.Text = "AZTime";
            // 
            // txtAZTime
            // 
            this.txtAZTime.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtAZTime.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAZTime.ForeColor = System.Drawing.Color.White;
            this.txtAZTime.Location = new System.Drawing.Point(21, 238);
            this.txtAZTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAZTime.Name = "txtAZTime";
            this.txtAZTime.Size = new System.Drawing.Size(46, 29);
            this.txtAZTime.TabIndex = 36;
            this.txtAZTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(16, 35);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(80, 23);
            this.label18.TabIndex = 29;
            this.label18.Text = "Del Dest";
            // 
            // txtDelMiss
            // 
            this.txtDelMiss.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtDelMiss.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDelMiss.ForeColor = System.Drawing.Color.White;
            this.txtDelMiss.Location = new System.Drawing.Point(21, 138);
            this.txtDelMiss.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDelMiss.Name = "txtDelMiss";
            this.txtDelMiss.Size = new System.Drawing.Size(46, 29);
            this.txtDelMiss.TabIndex = 32;
            this.txtDelMiss.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(16, 114);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(74, 23);
            this.label21.TabIndex = 33;
            this.label21.Text = "DelMiss";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.BackColor = System.Drawing.Color.Black;
            this.label32.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label32.Location = new System.Drawing.Point(1042, 31);
            this.label32.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(84, 25);
            this.label32.TabIndex = 43;
            this.label32.Text = "HP Amp";
            // 
            // txtRobotSetup
            // 
            this.txtRobotSetup.BackColor = System.Drawing.Color.Black;
            this.txtRobotSetup.ForeColor = System.Drawing.Color.White;
            this.txtRobotSetup.Location = new System.Drawing.Point(1047, 134);
            this.txtRobotSetup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRobotSetup.Name = "txtRobotSetup";
            this.txtRobotSetup.Size = new System.Drawing.Size(94, 29);
            this.txtRobotSetup.TabIndex = 46;
            this.txtRobotSetup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.Black;
            this.txtID.ForeColor = System.Drawing.Color.White;
            this.txtID.Location = new System.Drawing.Point(800, 60);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(106, 29);
            this.txtID.TabIndex = 8;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLeave
            // 
            this.txtLeave.BackColor = System.Drawing.Color.Black;
            this.txtLeave.ForeColor = System.Drawing.Color.White;
            this.txtLeave.Location = new System.Drawing.Point(1048, 214);
            this.txtLeave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLeave.Name = "txtLeave";
            this.txtLeave.Size = new System.Drawing.Size(92, 29);
            this.txtLeave.TabIndex = 54;
            this.txtLeave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.Color.Black;
            this.label31.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label31.Location = new System.Drawing.Point(1176, 31);
            this.label31.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(42, 25);
            this.label31.TabIndex = 45;
            this.label31.Text = "Def";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.BackColor = System.Drawing.Color.Black;
            this.label33.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label33.Location = new System.Drawing.Point(1176, 188);
            this.label33.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(84, 25);
            this.label33.TabIndex = 57;
            this.label33.Text = "Strategy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(798, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "ID";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.BackColor = System.Drawing.Color.Black;
            this.label30.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label30.Location = new System.Drawing.Point(1042, 108);
            this.label30.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(119, 25);
            this.label30.TabIndex = 47;
            this.label30.Text = "Robot Setup";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.BackColor = System.Drawing.Color.Black;
            this.label34.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label34.Location = new System.Drawing.Point(1042, 188);
            this.label34.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(61, 25);
            this.label34.TabIndex = 55;
            this.label34.Text = "Leave";
            // 
            // txtHPAmp
            // 
            this.txtHPAmp.BackColor = System.Drawing.Color.Black;
            this.txtHPAmp.ForeColor = System.Drawing.Color.White;
            this.txtHPAmp.Location = new System.Drawing.Point(1047, 58);
            this.txtHPAmp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHPAmp.Name = "txtHPAmp";
            this.txtHPAmp.Size = new System.Drawing.Size(91, 29);
            this.txtHPAmp.TabIndex = 42;
            this.txtHPAmp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.Black;
            this.label29.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label29.Location = new System.Drawing.Point(1176, 108);
            this.label29.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(46, 25);
            this.label29.TabIndex = 49;
            this.label29.Text = "Avo";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.txtAvoidance);
            this.panel4.Controls.Add(this.txtDefense);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.comboMatchEvent);
            this.panel4.Controls.Add(this.comboMode);
            this.panel4.Controls.Add(this.comboStrategy);
            this.panel4.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(780, -3);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(508, 304);
            this.panel4.TabIndex = 349;
            // 
            // txtAvoidance
            // 
            this.txtAvoidance.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtAvoidance.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAvoidance.ForeColor = System.Drawing.Color.White;
            this.txtAvoidance.Location = new System.Drawing.Point(398, 134);
            this.txtAvoidance.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAvoidance.Name = "txtAvoidance";
            this.txtAvoidance.Size = new System.Drawing.Size(46, 29);
            this.txtAvoidance.TabIndex = 46;
            this.txtAvoidance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDefense
            // 
            this.txtDefense.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtDefense.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDefense.ForeColor = System.Drawing.Color.White;
            this.txtDefense.Location = new System.Drawing.Point(398, 58);
            this.txtDefense.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDefense.Name = "txtDefense";
            this.txtDefense.Size = new System.Drawing.Size(46, 29);
            this.txtDefense.TabIndex = 43;
            this.txtDefense.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(15, 188);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 25);
            this.label4.TabIndex = 45;
            this.label4.Text = "Match Event";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(15, 106);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 25);
            this.label1.TabIndex = 44;
            this.label1.Text = "Mode";
            // 
            // comboMatchEvent
            // 
            this.comboMatchEvent.BackColor = System.Drawing.Color.Black;
            this.comboMatchEvent.ForeColor = System.Drawing.Color.White;
            this.comboMatchEvent.FormattingEnabled = true;
            this.comboMatchEvent.Items.AddRange(new object[] {
            "Match_Event",
            "Fumbled",
            "BrokeDown",
            "CrossedCenter",
            "LostParts",
            "RingToss",
            "AdditionalNote",
            "MultiClimb",
            "NoShow",
            "StageInt",
            "TippedOver",
            "JammedPiece"});
            this.comboMatchEvent.Location = new System.Drawing.Point(16, 215);
            this.comboMatchEvent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboMatchEvent.Name = "comboMatchEvent";
            this.comboMatchEvent.Size = new System.Drawing.Size(106, 31);
            this.comboMatchEvent.TabIndex = 42;
            // 
            // comboMode
            // 
            this.comboMode.BackColor = System.Drawing.Color.Black;
            this.comboMode.ForeColor = System.Drawing.Color.White;
            this.comboMode.FormattingEnabled = true;
            this.comboMode.Items.AddRange(new object[] {
            "Auto",
            "Teleop",
            "Showtime"});
            this.comboMode.Location = new System.Drawing.Point(16, 134);
            this.comboMode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboMode.Name = "comboMode";
            this.comboMode.Size = new System.Drawing.Size(106, 31);
            this.comboMode.TabIndex = 42;
            // 
            // comboStrategy
            // 
            this.comboStrategy.BackColor = System.Drawing.Color.Black;
            this.comboStrategy.ForeColor = System.Drawing.Color.White;
            this.comboStrategy.FormattingEnabled = true;
            this.comboStrategy.Items.AddRange(new object[] {
            "Select",
            "None",
            "Defense",
            "Mover",
            "Shooter",
            "Hybrid",
            "Celebrity"});
            this.comboStrategy.Location = new System.Drawing.Point(398, 214);
            this.comboStrategy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboStrategy.Name = "comboStrategy";
            this.comboStrategy.Size = new System.Drawing.Size(94, 31);
            this.comboStrategy.TabIndex = 43;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.Black;
            this.panel11.Controls.Add(this.panel13);
            this.panel11.Controls.Add(this.label37);
            this.panel11.Controls.Add(this.panel2);
            this.panel11.Controls.Add(this.checkActivities);
            this.panel11.Controls.Add(this.checkMatchEvent);
            this.panel11.Location = new System.Drawing.Point(-6, 5);
            this.panel11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(1342, 125);
            this.panel11.TabIndex = 361;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.Goldenrod;
            this.panel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel13.Controls.Add(this.panel14);
            this.panel13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel13.Location = new System.Drawing.Point(776, 37);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(203, 40);
            this.panel13.TabIndex = 352;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.Black;
            this.panel14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel14.Controls.Add(this.btnCreateTable);
            this.panel14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel14.Location = new System.Drawing.Point(-2, -2);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(203, 40);
            this.panel14.TabIndex = 351;
            // 
            // btnCreateTable
            // 
            this.btnCreateTable.BackColor = System.Drawing.Color.Black;
            this.btnCreateTable.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateTable.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnCreateTable.Location = new System.Drawing.Point(6, 2);
            this.btnCreateTable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCreateTable.Name = "btnCreateTable";
            this.btnCreateTable.Size = new System.Drawing.Size(188, 35);
            this.btnCreateTable.TabIndex = 11;
            this.btnCreateTable.Text = "Create Table";
            this.btnCreateTable.UseVisualStyleBackColor = false;
            this.btnCreateTable.Click += new System.EventHandler(this.BtnCreateTable_Click);
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.ForeColor = System.Drawing.Color.Red;
            this.label37.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label37.Location = new System.Drawing.Point(627, 329);
            this.label37.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(55, 37);
            this.label37.TabIndex = 277;
            this.label37.Text = "00";
            this.label37.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.comboTeamNumber);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.comboMatchNumber);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(122, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(335, 94);
            this.panel2.TabIndex = 344;
            // 
            // comboTeamNumber
            // 
            this.comboTeamNumber.BackColor = System.Drawing.Color.Black;
            this.comboTeamNumber.ForeColor = System.Drawing.Color.White;
            this.comboTeamNumber.FormattingEnabled = true;
            this.comboTeamNumber.Location = new System.Drawing.Point(8, 38);
            this.comboTeamNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboTeamNumber.Name = "comboTeamNumber";
            this.comboTeamNumber.Size = new System.Drawing.Size(138, 34);
            this.comboTeamNumber.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Team Number";
            // 
            // comboMatchNumber
            // 
            this.comboMatchNumber.BackColor = System.Drawing.Color.Black;
            this.comboMatchNumber.ForeColor = System.Drawing.Color.White;
            this.comboMatchNumber.FormattingEnabled = true;
            this.comboMatchNumber.Location = new System.Drawing.Point(174, 37);
            this.comboMatchNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboMatchNumber.Name = "comboMatchNumber";
            this.comboMatchNumber.Size = new System.Drawing.Size(138, 34);
            this.comboMatchNumber.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(174, 6);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "Match Number";
            // 
            // checkActivities
            // 
            this.checkActivities.AutoSize = true;
            this.checkActivities.BackColor = System.Drawing.Color.Black;
            this.checkActivities.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkActivities.ForeColor = System.Drawing.Color.White;
            this.checkActivities.Location = new System.Drawing.Point(474, 85);
            this.checkActivities.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkActivities.Name = "checkActivities";
            this.checkActivities.Size = new System.Drawing.Size(111, 27);
            this.checkActivities.TabIndex = 4;
            this.checkActivities.Text = "Activities";
            this.checkActivities.UseVisualStyleBackColor = false;
            // 
            // checkMatchEvent
            // 
            this.checkMatchEvent.AutoSize = true;
            this.checkMatchEvent.BackColor = System.Drawing.Color.Black;
            this.checkMatchEvent.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkMatchEvent.ForeColor = System.Drawing.Color.White;
            this.checkMatchEvent.Location = new System.Drawing.Point(614, 85);
            this.checkMatchEvent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkMatchEvent.Name = "checkMatchEvent";
            this.checkMatchEvent.Size = new System.Drawing.Size(130, 27);
            this.checkMatchEvent.TabIndex = 6;
            this.checkMatchEvent.Text = "MatchEvent";
            this.checkMatchEvent.UseVisualStyleBackColor = false;
            // 
            // updatePreviewsBindingSource
            // 
            this.updatePreviewsBindingSource.DataMember = "UpdatePreviews";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.teamDataGridViewTextBoxColumn,
            this.matchDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.recordTypeDataGridViewTextBoxColumn,
            this.modeDataGridViewTextBoxColumn,
            this.leaveDataGridViewTextBoxColumn,
            this.acqLocDataGridViewTextBoxColumn,
            this.acqCenterDataGridViewTextBoxColumn,
            this.acqDisDataGridViewTextBoxColumn,
            this.acqDrpDataGridViewTextBoxColumn,
            this.delOrigDataGridViewTextBoxColumn,
            this.delDestDataGridViewTextBoxColumn,
            this.delMissDataGridViewTextBoxColumn,
            this.driveStaDataGridViewTextBoxColumn,
            this.robotStaDataGridViewTextBoxColumn,
            this.hPAmpDataGridViewTextBoxColumn,
            this.stageStatDataGridViewTextBoxColumn,
            this.stageAttDataGridViewTextBoxColumn,
            this.stageLocDataGridViewTextBoxColumn,
            this.harmonyDataGridViewTextBoxColumn,
            this.spotlitDataGridViewTextBoxColumn,
            this.climbTDataGridViewTextBoxColumn,
            this.oZTimeDataGridViewTextBoxColumn,
            this.nZTimeDataGridViewTextBoxColumn,
            this.aZTimeDataGridViewTextBoxColumn,
            this.defenseDataGridViewTextBoxColumn,
            this.avoidanceDataGridViewTextBoxColumn,
            this.strategyDataGridViewTextBoxColumn,
            this.micsDataGridViewTextBoxColumn,
            this.scouterNameDataGridViewTextBoxColumn,
            this.scouterErrorDataGridViewTextBoxColumn,
            this.matcheventDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.updatePreviewsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 7);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(837, 169);
            this.dataGridView1.TabIndex = 11;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // teamDataGridViewTextBoxColumn
            // 
            this.teamDataGridViewTextBoxColumn.DataPropertyName = "Team";
            this.teamDataGridViewTextBoxColumn.HeaderText = "Team";
            this.teamDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.teamDataGridViewTextBoxColumn.Name = "teamDataGridViewTextBoxColumn";
            this.teamDataGridViewTextBoxColumn.Width = 125;
            // 
            // matchDataGridViewTextBoxColumn
            // 
            this.matchDataGridViewTextBoxColumn.DataPropertyName = "Match";
            this.matchDataGridViewTextBoxColumn.HeaderText = "Match";
            this.matchDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.matchDataGridViewTextBoxColumn.Name = "matchDataGridViewTextBoxColumn";
            this.matchDataGridViewTextBoxColumn.Width = 125;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.timeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            this.timeDataGridViewTextBoxColumn.Width = 125;
            // 
            // recordTypeDataGridViewTextBoxColumn
            // 
            this.recordTypeDataGridViewTextBoxColumn.DataPropertyName = "RecordType";
            this.recordTypeDataGridViewTextBoxColumn.HeaderText = "RecordType";
            this.recordTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.recordTypeDataGridViewTextBoxColumn.Name = "recordTypeDataGridViewTextBoxColumn";
            this.recordTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // modeDataGridViewTextBoxColumn
            // 
            this.modeDataGridViewTextBoxColumn.DataPropertyName = "Mode";
            this.modeDataGridViewTextBoxColumn.HeaderText = "Mode";
            this.modeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.modeDataGridViewTextBoxColumn.Name = "modeDataGridViewTextBoxColumn";
            this.modeDataGridViewTextBoxColumn.Width = 125;
            // 
            // leaveDataGridViewTextBoxColumn
            // 
            this.leaveDataGridViewTextBoxColumn.DataPropertyName = "Leave";
            this.leaveDataGridViewTextBoxColumn.HeaderText = "Leave";
            this.leaveDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.leaveDataGridViewTextBoxColumn.Name = "leaveDataGridViewTextBoxColumn";
            this.leaveDataGridViewTextBoxColumn.Width = 125;
            // 
            // acqLocDataGridViewTextBoxColumn
            // 
            this.acqLocDataGridViewTextBoxColumn.DataPropertyName = "AcqLoc";
            this.acqLocDataGridViewTextBoxColumn.HeaderText = "AcqLoc";
            this.acqLocDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.acqLocDataGridViewTextBoxColumn.Name = "acqLocDataGridViewTextBoxColumn";
            this.acqLocDataGridViewTextBoxColumn.Width = 125;
            // 
            // acqCenterDataGridViewTextBoxColumn
            // 
            this.acqCenterDataGridViewTextBoxColumn.DataPropertyName = "AcqCenter";
            this.acqCenterDataGridViewTextBoxColumn.HeaderText = "AcqCenter";
            this.acqCenterDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.acqCenterDataGridViewTextBoxColumn.Name = "acqCenterDataGridViewTextBoxColumn";
            this.acqCenterDataGridViewTextBoxColumn.Width = 125;
            // 
            // acqDisDataGridViewTextBoxColumn
            // 
            this.acqDisDataGridViewTextBoxColumn.DataPropertyName = "AcqDis";
            this.acqDisDataGridViewTextBoxColumn.HeaderText = "AcqDis";
            this.acqDisDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.acqDisDataGridViewTextBoxColumn.Name = "acqDisDataGridViewTextBoxColumn";
            this.acqDisDataGridViewTextBoxColumn.Width = 125;
            // 
            // acqDrpDataGridViewTextBoxColumn
            // 
            this.acqDrpDataGridViewTextBoxColumn.DataPropertyName = "AcqDrp";
            this.acqDrpDataGridViewTextBoxColumn.HeaderText = "AcqDrp";
            this.acqDrpDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.acqDrpDataGridViewTextBoxColumn.Name = "acqDrpDataGridViewTextBoxColumn";
            this.acqDrpDataGridViewTextBoxColumn.Width = 125;
            // 
            // delOrigDataGridViewTextBoxColumn
            // 
            this.delOrigDataGridViewTextBoxColumn.DataPropertyName = "DelOrig";
            this.delOrigDataGridViewTextBoxColumn.HeaderText = "DelOrig";
            this.delOrigDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.delOrigDataGridViewTextBoxColumn.Name = "delOrigDataGridViewTextBoxColumn";
            this.delOrigDataGridViewTextBoxColumn.Width = 125;
            // 
            // delDestDataGridViewTextBoxColumn
            // 
            this.delDestDataGridViewTextBoxColumn.DataPropertyName = "DelDest";
            this.delDestDataGridViewTextBoxColumn.HeaderText = "DelDest";
            this.delDestDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.delDestDataGridViewTextBoxColumn.Name = "delDestDataGridViewTextBoxColumn";
            this.delDestDataGridViewTextBoxColumn.Width = 125;
            // 
            // delMissDataGridViewTextBoxColumn
            // 
            this.delMissDataGridViewTextBoxColumn.DataPropertyName = "DelMiss";
            this.delMissDataGridViewTextBoxColumn.HeaderText = "DelMiss";
            this.delMissDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.delMissDataGridViewTextBoxColumn.Name = "delMissDataGridViewTextBoxColumn";
            this.delMissDataGridViewTextBoxColumn.Width = 125;
            // 
            // driveStaDataGridViewTextBoxColumn
            // 
            this.driveStaDataGridViewTextBoxColumn.DataPropertyName = "DriveSta";
            this.driveStaDataGridViewTextBoxColumn.HeaderText = "DriveSta";
            this.driveStaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.driveStaDataGridViewTextBoxColumn.Name = "driveStaDataGridViewTextBoxColumn";
            this.driveStaDataGridViewTextBoxColumn.Width = 125;
            // 
            // robotStaDataGridViewTextBoxColumn
            // 
            this.robotStaDataGridViewTextBoxColumn.DataPropertyName = "RobotSta";
            this.robotStaDataGridViewTextBoxColumn.HeaderText = "RobotSta";
            this.robotStaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.robotStaDataGridViewTextBoxColumn.Name = "robotStaDataGridViewTextBoxColumn";
            this.robotStaDataGridViewTextBoxColumn.Width = 125;
            // 
            // hPAmpDataGridViewTextBoxColumn
            // 
            this.hPAmpDataGridViewTextBoxColumn.DataPropertyName = "HPAmp";
            this.hPAmpDataGridViewTextBoxColumn.HeaderText = "HPAmp";
            this.hPAmpDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hPAmpDataGridViewTextBoxColumn.Name = "hPAmpDataGridViewTextBoxColumn";
            this.hPAmpDataGridViewTextBoxColumn.Width = 125;
            // 
            // stageStatDataGridViewTextBoxColumn
            // 
            this.stageStatDataGridViewTextBoxColumn.DataPropertyName = "StageStat";
            this.stageStatDataGridViewTextBoxColumn.HeaderText = "StageStat";
            this.stageStatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stageStatDataGridViewTextBoxColumn.Name = "stageStatDataGridViewTextBoxColumn";
            this.stageStatDataGridViewTextBoxColumn.Width = 125;
            // 
            // stageAttDataGridViewTextBoxColumn
            // 
            this.stageAttDataGridViewTextBoxColumn.DataPropertyName = "StageAtt";
            this.stageAttDataGridViewTextBoxColumn.HeaderText = "StageAtt";
            this.stageAttDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stageAttDataGridViewTextBoxColumn.Name = "stageAttDataGridViewTextBoxColumn";
            this.stageAttDataGridViewTextBoxColumn.Width = 125;
            // 
            // stageLocDataGridViewTextBoxColumn
            // 
            this.stageLocDataGridViewTextBoxColumn.DataPropertyName = "StageLoc";
            this.stageLocDataGridViewTextBoxColumn.HeaderText = "StageLoc";
            this.stageLocDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stageLocDataGridViewTextBoxColumn.Name = "stageLocDataGridViewTextBoxColumn";
            this.stageLocDataGridViewTextBoxColumn.Width = 125;
            // 
            // harmonyDataGridViewTextBoxColumn
            // 
            this.harmonyDataGridViewTextBoxColumn.DataPropertyName = "Harmony";
            this.harmonyDataGridViewTextBoxColumn.HeaderText = "Harmony";
            this.harmonyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.harmonyDataGridViewTextBoxColumn.Name = "harmonyDataGridViewTextBoxColumn";
            this.harmonyDataGridViewTextBoxColumn.Width = 125;
            // 
            // spotlitDataGridViewTextBoxColumn
            // 
            this.spotlitDataGridViewTextBoxColumn.DataPropertyName = "Spotlit";
            this.spotlitDataGridViewTextBoxColumn.HeaderText = "Spotlit";
            this.spotlitDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.spotlitDataGridViewTextBoxColumn.Name = "spotlitDataGridViewTextBoxColumn";
            this.spotlitDataGridViewTextBoxColumn.Width = 125;
            // 
            // climbTDataGridViewTextBoxColumn
            // 
            this.climbTDataGridViewTextBoxColumn.DataPropertyName = "ClimbT";
            this.climbTDataGridViewTextBoxColumn.HeaderText = "ClimbT";
            this.climbTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.climbTDataGridViewTextBoxColumn.Name = "climbTDataGridViewTextBoxColumn";
            this.climbTDataGridViewTextBoxColumn.Width = 125;
            // 
            // oZTimeDataGridViewTextBoxColumn
            // 
            this.oZTimeDataGridViewTextBoxColumn.DataPropertyName = "OZTime";
            this.oZTimeDataGridViewTextBoxColumn.HeaderText = "OZTime";
            this.oZTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.oZTimeDataGridViewTextBoxColumn.Name = "oZTimeDataGridViewTextBoxColumn";
            this.oZTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // nZTimeDataGridViewTextBoxColumn
            // 
            this.nZTimeDataGridViewTextBoxColumn.DataPropertyName = "NZTime";
            this.nZTimeDataGridViewTextBoxColumn.HeaderText = "NZTime";
            this.nZTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nZTimeDataGridViewTextBoxColumn.Name = "nZTimeDataGridViewTextBoxColumn";
            this.nZTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // aZTimeDataGridViewTextBoxColumn
            // 
            this.aZTimeDataGridViewTextBoxColumn.DataPropertyName = "AZTime";
            this.aZTimeDataGridViewTextBoxColumn.HeaderText = "AZTime";
            this.aZTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aZTimeDataGridViewTextBoxColumn.Name = "aZTimeDataGridViewTextBoxColumn";
            this.aZTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // defenseDataGridViewTextBoxColumn
            // 
            this.defenseDataGridViewTextBoxColumn.DataPropertyName = "Defense";
            this.defenseDataGridViewTextBoxColumn.HeaderText = "Defense";
            this.defenseDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.defenseDataGridViewTextBoxColumn.Name = "defenseDataGridViewTextBoxColumn";
            this.defenseDataGridViewTextBoxColumn.Width = 125;
            // 
            // avoidanceDataGridViewTextBoxColumn
            // 
            this.avoidanceDataGridViewTextBoxColumn.DataPropertyName = "Avoidance";
            this.avoidanceDataGridViewTextBoxColumn.HeaderText = "Avoidance";
            this.avoidanceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.avoidanceDataGridViewTextBoxColumn.Name = "avoidanceDataGridViewTextBoxColumn";
            this.avoidanceDataGridViewTextBoxColumn.Width = 125;
            // 
            // strategyDataGridViewTextBoxColumn
            // 
            this.strategyDataGridViewTextBoxColumn.DataPropertyName = "Strategy";
            this.strategyDataGridViewTextBoxColumn.HeaderText = "Strategy";
            this.strategyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.strategyDataGridViewTextBoxColumn.Name = "strategyDataGridViewTextBoxColumn";
            this.strategyDataGridViewTextBoxColumn.Width = 125;
            // 
            // micsDataGridViewTextBoxColumn
            // 
            this.micsDataGridViewTextBoxColumn.DataPropertyName = "Mics";
            this.micsDataGridViewTextBoxColumn.HeaderText = "Mics";
            this.micsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.micsDataGridViewTextBoxColumn.Name = "micsDataGridViewTextBoxColumn";
            this.micsDataGridViewTextBoxColumn.Width = 125;
            // 
            // scouterNameDataGridViewTextBoxColumn
            // 
            this.scouterNameDataGridViewTextBoxColumn.DataPropertyName = "ScouterName";
            this.scouterNameDataGridViewTextBoxColumn.HeaderText = "ScouterName";
            this.scouterNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.scouterNameDataGridViewTextBoxColumn.Name = "scouterNameDataGridViewTextBoxColumn";
            this.scouterNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // scouterErrorDataGridViewTextBoxColumn
            // 
            this.scouterErrorDataGridViewTextBoxColumn.DataPropertyName = "ScouterError";
            this.scouterErrorDataGridViewTextBoxColumn.HeaderText = "ScouterError";
            this.scouterErrorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.scouterErrorDataGridViewTextBoxColumn.Name = "scouterErrorDataGridViewTextBoxColumn";
            this.scouterErrorDataGridViewTextBoxColumn.Width = 125;
            // 
            // matcheventDataGridViewTextBoxColumn
            // 
            this.matcheventDataGridViewTextBoxColumn.DataPropertyName = "match_event";
            this.matcheventDataGridViewTextBoxColumn.HeaderText = "match_event";
            this.matcheventDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.matcheventDataGridViewTextBoxColumn.Name = "matcheventDataGridViewTextBoxColumn";
            this.matcheventDataGridViewTextBoxColumn.Width = 125;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(18, 446);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1291, 296);
            this.panel1.TabIndex = 358;
            // 
            // UpdateDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1328, 831);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.checkEndMatch);
            this.Controls.Add(this.checkEndAuto);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel11);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UpdateDatabase";
            this.Text = "UpdateDatabase";
            this.panel10.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updatePreviewsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource updatePreviewsBindingSource;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkEndMatch;
        private System.Windows.Forms.CheckBox checkEndAuto;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn matchDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recordTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leaveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn acqLocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn acqCenterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn acqDisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn acqDrpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn delOrigDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn delDestDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn delMissDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn driveStaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn robotStaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hPAmpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stageStatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stageAttDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stageLocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn harmonyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spotlitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn climbTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oZTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nZTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aZTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn defenseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn avoidanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn strategyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn micsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scouterNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scouterErrorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn matcheventDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboStageLoc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMics;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtLit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboStageStat;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtHarm;
        private System.Windows.Forms.ComboBox comboStageAtt;
        private System.Windows.Forms.TextBox txtClimbTime;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboAcqCenter;
        private System.Windows.Forms.ComboBox comboAcqLoc;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtAcqDrp;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtAcqDis;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboDelOrg;
        private System.Windows.Forms.ComboBox comboDelDest;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtOZTime;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNZTime;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtAZTime;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtDelMiss;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox txtRobotSetup;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtLeave;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox txtHPAmp;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtAvoidance;
        private System.Windows.Forms.TextBox txtDefense;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboMatchEvent;
        private System.Windows.Forms.ComboBox comboMode;
        private System.Windows.Forms.ComboBox comboStrategy;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.CheckBox checkActivities;
        private System.Windows.Forms.CheckBox checkMatchEvent;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Button btnFetchValues;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnUpdateDatabase;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Button btnCreateTable;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboTeamNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboMatchNumber;
        private System.Windows.Forms.Label label7;
    }
}