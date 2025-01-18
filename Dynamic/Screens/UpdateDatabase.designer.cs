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
            this.comboEndState = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.comboClimbAttempt = new System.Windows.Forms.ComboBox();
            this.txtClimbTime = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboCoralAcqLoc = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboCoralDelDest = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtRobotSetup = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtLeave = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
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
            this.scoutingDBDataSet = new ScoutingCodeRedo.scoutingdbDataSet();
            this.updatePreviewsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.updatePreviewsTableAdapter = new ScoutingCodeRedo.scoutingdbDataSetTableAdapters.UpdatePreviewsTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matchDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recordTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leaveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driveStaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.climbTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.defenseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avoidanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strategyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scouterNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scouterErrorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboAlgaeAcqLoc = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboCoralAcqSide = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.comboAlgaeAcqSide = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.comboAlgaeDelDest = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboAlgaeDelSide = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.comboCoralDelSide = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtHPAmp = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.txtAvoidance = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.txtDefense = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.scoutingDBDataSet)).BeginInit();
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
            this.panel10.Location = new System.Drawing.Point(793, 622);
            this.panel10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(181, 32);
            this.panel10.TabIndex = 363;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.Black;
            this.panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel12.Controls.Add(this.btnFetchValues);
            this.panel12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel12.Location = new System.Drawing.Point(-2, -2);
            this.panel12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(181, 32);
            this.panel12.TabIndex = 351;
            // 
            // btnFetchValues
            // 
            this.btnFetchValues.BackColor = System.Drawing.Color.Black;
            this.btnFetchValues.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFetchValues.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnFetchValues.Location = new System.Drawing.Point(7, 2);
            this.btnFetchValues.Margin = new System.Windows.Forms.Padding(4);
            this.btnFetchValues.Name = "btnFetchValues";
            this.btnFetchValues.Size = new System.Drawing.Size(167, 28);
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
            this.panel5.Location = new System.Drawing.Point(981, 622);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(181, 32);
            this.panel5.TabIndex = 362;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Goldenrod;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel6.Location = new System.Drawing.Point(-2, -2);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(181, 32);
            this.panel6.TabIndex = 351;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Goldenrod;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel7.Location = new System.Drawing.Point(-2, -2);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(181, 32);
            this.panel7.TabIndex = 351;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Black;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.btnUpdateDatabase);
            this.panel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel8.Location = new System.Drawing.Point(-2, -2);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(181, 32);
            this.panel8.TabIndex = 351;
            // 
            // btnUpdateDatabase
            // 
            this.btnUpdateDatabase.BackColor = System.Drawing.Color.Black;
            this.btnUpdateDatabase.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateDatabase.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnUpdateDatabase.Location = new System.Drawing.Point(5, 2);
            this.btnUpdateDatabase.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateDatabase.Name = "btnUpdateDatabase";
            this.btnUpdateDatabase.Size = new System.Drawing.Size(167, 28);
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
            this.button2.Location = new System.Drawing.Point(5, 2);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 28);
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
            this.checkEndMatch.Location = new System.Drawing.Point(541, 22);
            this.checkEndMatch.Margin = new System.Windows.Forms.Padding(4);
            this.checkEndMatch.Name = "checkEndMatch";
            this.checkEndMatch.Size = new System.Drawing.Size(99, 23);
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
            this.checkEndAuto.Location = new System.Drawing.Point(416, 22);
            this.checkEndAuto.Margin = new System.Windows.Forms.Padding(4);
            this.checkEndAuto.Name = "checkEndAuto";
            this.checkEndAuto.Size = new System.Drawing.Size(90, 23);
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
            this.panel3.Location = new System.Drawing.Point(16, 110);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1148, 250);
            this.panel3.TabIndex = 359;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Black;
            this.groupBox3.Controls.Add(this.comboEndState);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.comboClimbAttempt);
            this.groupBox3.Controls.Add(this.txtClimbTime);
            this.groupBox3.Controls.Add(this.label26);
            this.groupBox3.Controls.Add(this.label24);
            this.groupBox3.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox3.Location = new System.Drawing.Point(466, 7);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(205, 235);
            this.groupBox3.TabIndex = 41;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "SURFACING";
            // 
            // comboEndState
            // 
            this.comboEndState.BackColor = System.Drawing.Color.Black;
            this.comboEndState.ForeColor = System.Drawing.Color.White;
            this.comboEndState.FormattingEnabled = true;
            this.comboEndState.Items.AddRange(new object[] {
            "-",
            "Elsewhere",
            "Park",
            "Shallow",
            "Deep"});
            this.comboEndState.Location = new System.Drawing.Point(16, 38);
            this.comboEndState.Margin = new System.Windows.Forms.Padding(4);
            this.comboEndState.Name = "comboEndState";
            this.comboEndState.Size = new System.Drawing.Size(79, 28);
            this.comboEndState.TabIndex = 44;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(11, 18);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(74, 19);
            this.label16.TabIndex = 43;
            this.label16.Text = "End State";
            // 
            // comboClimbAttempt
            // 
            this.comboClimbAttempt.BackColor = System.Drawing.Color.Black;
            this.comboClimbAttempt.ForeColor = System.Drawing.Color.White;
            this.comboClimbAttempt.FormattingEnabled = true;
            this.comboClimbAttempt.Items.AddRange(new object[] {
            "-",
            "Y",
            "N"});
            this.comboClimbAttempt.Location = new System.Drawing.Point(18, 94);
            this.comboClimbAttempt.Margin = new System.Windows.Forms.Padding(4);
            this.comboClimbAttempt.Name = "comboClimbAttempt";
            this.comboClimbAttempt.Size = new System.Drawing.Size(79, 28);
            this.comboClimbAttempt.TabIndex = 38;
            // 
            // txtClimbTime
            // 
            this.txtClimbTime.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtClimbTime.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClimbTime.ForeColor = System.Drawing.Color.White;
            this.txtClimbTime.Location = new System.Drawing.Point(18, 147);
            this.txtClimbTime.Margin = new System.Windows.Forms.Padding(4);
            this.txtClimbTime.Name = "txtClimbTime";
            this.txtClimbTime.Size = new System.Drawing.Size(56, 26);
            this.txtClimbTime.TabIndex = 41;
            this.txtClimbTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(13, 129);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(86, 19);
            this.label26.TabIndex = 40;
            this.label26.Text = "Climb Time";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(12, 74);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(108, 19);
            this.label24.TabIndex = 35;
            this.label24.Text = "Climb Attempt";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.comboAlgaeAcqSide);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.comboCoralAcqSide);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.comboAlgaeAcqLoc);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboCoralAcqLoc);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(16, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(156, 236);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ACQUISITION";
            // 
            // comboCoralAcqLoc
            // 
            this.comboCoralAcqLoc.BackColor = System.Drawing.Color.Black;
            this.comboCoralAcqLoc.ForeColor = System.Drawing.Color.White;
            this.comboCoralAcqLoc.FormattingEnabled = true;
            this.comboCoralAcqLoc.Items.AddRange(new object[] {
            "-",
            "Station",
            "Floor"});
            this.comboCoralAcqLoc.Location = new System.Drawing.Point(14, 43);
            this.comboCoralAcqLoc.Margin = new System.Windows.Forms.Padding(4);
            this.comboCoralAcqLoc.Name = "comboCoralAcqLoc";
            this.comboCoralAcqLoc.Size = new System.Drawing.Size(119, 29);
            this.comboCoralAcqLoc.TabIndex = 354;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 23);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 19);
            this.label11.TabIndex = 29;
            this.label11.Text = "Coral Acq Loc";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Black;
            this.groupBox2.Controls.Add(this.comboAlgaeDelSide);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.comboCoralDelSide);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.comboAlgaeDelDest);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.comboCoralDelDest);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Location = new System.Drawing.Point(194, 5);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(249, 238);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DELIVERY";
            // 
            // comboCoralDelDest
            // 
            this.comboCoralDelDest.BackColor = System.Drawing.Color.Black;
            this.comboCoralDelDest.ForeColor = System.Drawing.Color.White;
            this.comboCoralDelDest.FormattingEnabled = true;
            this.comboCoralDelDest.Items.AddRange(new object[] {
            "-",
            "L4",
            "L3",
            "L2",
            "L1",
            "Floor"});
            this.comboCoralDelDest.Location = new System.Drawing.Point(12, 43);
            this.comboCoralDelDest.Margin = new System.Windows.Forms.Padding(4);
            this.comboCoralDelDest.Name = "comboCoralDelDest";
            this.comboCoralDelDest.Size = new System.Drawing.Size(79, 29);
            this.comboCoralDelDest.TabIndex = 356;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(14, 23);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(106, 19);
            this.label18.TabIndex = 29;
            this.label18.Text = "Coral Del Dest";
            // 
            // txtRobotSetup
            // 
            this.txtRobotSetup.BackColor = System.Drawing.Color.Black;
            this.txtRobotSetup.ForeColor = System.Drawing.Color.White;
            this.txtRobotSetup.Location = new System.Drawing.Point(878, 107);
            this.txtRobotSetup.Margin = new System.Windows.Forms.Padding(4);
            this.txtRobotSetup.Name = "txtRobotSetup";
            this.txtRobotSetup.Size = new System.Drawing.Size(84, 26);
            this.txtRobotSetup.TabIndex = 46;
            this.txtRobotSetup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.Black;
            this.txtID.ForeColor = System.Drawing.Color.White;
            this.txtID.Location = new System.Drawing.Point(711, 46);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(95, 26);
            this.txtID.TabIndex = 8;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLeave
            // 
            this.txtLeave.BackColor = System.Drawing.Color.Black;
            this.txtLeave.ForeColor = System.Drawing.Color.White;
            this.txtLeave.Location = new System.Drawing.Point(879, 171);
            this.txtLeave.Margin = new System.Windows.Forms.Padding(4);
            this.txtLeave.Name = "txtLeave";
            this.txtLeave.Size = new System.Drawing.Size(82, 26);
            this.txtLeave.TabIndex = 54;
            this.txtLeave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.BackColor = System.Drawing.Color.Black;
            this.label33.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label33.Location = new System.Drawing.Point(1045, 150);
            this.label33.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(68, 20);
            this.label33.TabIndex = 57;
            this.label33.Text = "Strategy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(709, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "ID";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.BackColor = System.Drawing.Color.Black;
            this.label30.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label30.Location = new System.Drawing.Point(873, 86);
            this.label30.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(97, 20);
            this.label30.TabIndex = 47;
            this.label30.Text = "Robot Setup";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.BackColor = System.Drawing.Color.Black;
            this.label34.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label34.Location = new System.Drawing.Point(873, 150);
            this.label34.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(49, 20);
            this.label34.TabIndex = 55;
            this.label34.Text = "Leave";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Controls.Add(this.txtAvoidance);
            this.panel4.Controls.Add(this.txtDefense);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.comboMatchEvent);
            this.panel4.Controls.Add(this.comboMode);
            this.panel4.Controls.Add(this.comboStrategy);
            this.panel4.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(693, -2);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(452, 244);
            this.panel4.TabIndex = 349;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(13, 149);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 45;
            this.label4.Text = "Match Event";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(13, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
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
            this.comboMatchEvent.Location = new System.Drawing.Point(14, 171);
            this.comboMatchEvent.Margin = new System.Windows.Forms.Padding(4);
            this.comboMatchEvent.Name = "comboMatchEvent";
            this.comboMatchEvent.Size = new System.Drawing.Size(95, 27);
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
            this.comboMode.Location = new System.Drawing.Point(14, 106);
            this.comboMode.Margin = new System.Windows.Forms.Padding(4);
            this.comboMode.Name = "comboMode";
            this.comboMode.Size = new System.Drawing.Size(95, 27);
            this.comboMode.TabIndex = 42;
            // 
            // comboStrategy
            // 
            this.comboStrategy.BackColor = System.Drawing.Color.Black;
            this.comboStrategy.ForeColor = System.Drawing.Color.White;
            this.comboStrategy.FormattingEnabled = true;
            this.comboStrategy.Items.AddRange(new object[] {
            "None",
            "Defense",
            "CoralScorer",
            "AlgaeScorer",
            "Hybrid",
            "Surfacing"});
            this.comboStrategy.Location = new System.Drawing.Point(354, 171);
            this.comboStrategy.Margin = new System.Windows.Forms.Padding(4);
            this.comboStrategy.Name = "comboStrategy";
            this.comboStrategy.Size = new System.Drawing.Size(84, 27);
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
            this.panel11.Location = new System.Drawing.Point(-5, 4);
            this.panel11.Margin = new System.Windows.Forms.Padding(4);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(1193, 100);
            this.panel11.TabIndex = 361;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.Goldenrod;
            this.panel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel13.Controls.Add(this.panel14);
            this.panel13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel13.Location = new System.Drawing.Point(690, 30);
            this.panel13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(181, 32);
            this.panel13.TabIndex = 352;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.Black;
            this.panel14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel14.Controls.Add(this.btnCreateTable);
            this.panel14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel14.Location = new System.Drawing.Point(-2, -2);
            this.panel14.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(181, 32);
            this.panel14.TabIndex = 351;
            // 
            // btnCreateTable
            // 
            this.btnCreateTable.BackColor = System.Drawing.Color.Black;
            this.btnCreateTable.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateTable.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnCreateTable.Location = new System.Drawing.Point(5, 2);
            this.btnCreateTable.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateTable.Name = "btnCreateTable";
            this.btnCreateTable.Size = new System.Drawing.Size(167, 28);
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
            this.label37.Location = new System.Drawing.Point(557, 263);
            this.label37.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(46, 31);
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
            this.panel2.Location = new System.Drawing.Point(108, 12);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(298, 76);
            this.panel2.TabIndex = 344;
            // 
            // comboTeamNumber
            // 
            this.comboTeamNumber.BackColor = System.Drawing.Color.Black;
            this.comboTeamNumber.ForeColor = System.Drawing.Color.White;
            this.comboTeamNumber.FormattingEnabled = true;
            this.comboTeamNumber.Location = new System.Drawing.Point(7, 30);
            this.comboTeamNumber.Margin = new System.Windows.Forms.Padding(4);
            this.comboTeamNumber.Name = "comboTeamNumber";
            this.comboTeamNumber.Size = new System.Drawing.Size(123, 30);
            this.comboTeamNumber.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(8, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Team Number";
            // 
            // comboMatchNumber
            // 
            this.comboMatchNumber.BackColor = System.Drawing.Color.Black;
            this.comboMatchNumber.ForeColor = System.Drawing.Color.White;
            this.comboMatchNumber.FormattingEnabled = true;
            this.comboMatchNumber.Location = new System.Drawing.Point(155, 30);
            this.comboMatchNumber.Margin = new System.Windows.Forms.Padding(4);
            this.comboMatchNumber.Name = "comboMatchNumber";
            this.comboMatchNumber.Size = new System.Drawing.Size(123, 30);
            this.comboMatchNumber.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(155, 5);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Match Number";
            // 
            // checkActivities
            // 
            this.checkActivities.AutoSize = true;
            this.checkActivities.BackColor = System.Drawing.Color.Black;
            this.checkActivities.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkActivities.ForeColor = System.Drawing.Color.White;
            this.checkActivities.Location = new System.Drawing.Point(421, 68);
            this.checkActivities.Margin = new System.Windows.Forms.Padding(4);
            this.checkActivities.Name = "checkActivities";
            this.checkActivities.Size = new System.Drawing.Size(92, 23);
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
            this.checkMatchEvent.Location = new System.Drawing.Point(546, 68);
            this.checkMatchEvent.Margin = new System.Windows.Forms.Padding(4);
            this.checkMatchEvent.Name = "checkMatchEvent";
            this.checkMatchEvent.Size = new System.Drawing.Size(111, 23);
            this.checkMatchEvent.TabIndex = 6;
            this.checkMatchEvent.Text = "MatchEvent";
            this.checkMatchEvent.UseVisualStyleBackColor = false;
            // 
            // scoutingDBDataSet
            // 
            this.scoutingDBDataSet.DataSetName = "scoutingdbDataSet";
            this.scoutingDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // updatePreviewsBindingSource
            // 
            this.updatePreviewsBindingSource.DataMember = "UpdatePreviews";
            this.updatePreviewsBindingSource.DataSource = this.scoutingDBDataSet;
            // 
            // updatePreviewsTableAdapter
            // 
            this.updatePreviewsTableAdapter.ClearBeforeFill = true;
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
            this.driveStaDataGridViewTextBoxColumn,
            this.climbTDataGridViewTextBoxColumn,
            this.defenseDataGridViewTextBoxColumn,
            this.avoidanceDataGridViewTextBoxColumn,
            this.strategyDataGridViewTextBoxColumn,
            this.scouterNameDataGridViewTextBoxColumn,
            this.scouterErrorDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.updatePreviewsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(11, 6);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1125, 220);
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
            // driveStaDataGridViewTextBoxColumn
            // 
            this.driveStaDataGridViewTextBoxColumn.DataPropertyName = "DriveSta";
            this.driveStaDataGridViewTextBoxColumn.HeaderText = "DriveSta";
            this.driveStaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.driveStaDataGridViewTextBoxColumn.Name = "driveStaDataGridViewTextBoxColumn";
            this.driveStaDataGridViewTextBoxColumn.Width = 125;
            // 
            // climbTDataGridViewTextBoxColumn
            // 
            this.climbTDataGridViewTextBoxColumn.DataPropertyName = "ClimbT";
            this.climbTDataGridViewTextBoxColumn.HeaderText = "ClimbT";
            this.climbTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.climbTDataGridViewTextBoxColumn.Name = "climbTDataGridViewTextBoxColumn";
            this.climbTDataGridViewTextBoxColumn.Width = 125;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(16, 357);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1148, 238);
            this.panel1.TabIndex = 358;
            // 
            // comboAlgaeAcqLoc
            // 
            this.comboAlgaeAcqLoc.BackColor = System.Drawing.Color.Black;
            this.comboAlgaeAcqLoc.ForeColor = System.Drawing.Color.White;
            this.comboAlgaeAcqLoc.FormattingEnabled = true;
            this.comboAlgaeAcqLoc.Items.AddRange(new object[] {
            "-",
            "Reef",
            "Floor"});
            this.comboAlgaeAcqLoc.Location = new System.Drawing.Point(16, 147);
            this.comboAlgaeAcqLoc.Margin = new System.Windows.Forms.Padding(4);
            this.comboAlgaeAcqLoc.Name = "comboAlgaeAcqLoc";
            this.comboAlgaeAcqLoc.Size = new System.Drawing.Size(119, 29);
            this.comboAlgaeAcqLoc.TabIndex = 356;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 127);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 19);
            this.label5.TabIndex = 355;
            this.label5.Text = "Algae Acq Loc";
            // 
            // comboCoralAcqSide
            // 
            this.comboCoralAcqSide.BackColor = System.Drawing.Color.Black;
            this.comboCoralAcqSide.ForeColor = System.Drawing.Color.White;
            this.comboCoralAcqSide.FormattingEnabled = true;
            this.comboCoralAcqSide.Items.AddRange(new object[] {
            "-",
            "Near",
            "Far"});
            this.comboCoralAcqSide.Location = new System.Drawing.Point(14, 94);
            this.comboCoralAcqSide.Margin = new System.Windows.Forms.Padding(4);
            this.comboCoralAcqSide.Name = "comboCoralAcqSide";
            this.comboCoralAcqSide.Size = new System.Drawing.Size(119, 29);
            this.comboCoralAcqSide.TabIndex = 358;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(12, 74);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(110, 19);
            this.label13.TabIndex = 357;
            this.label13.Text = "Coral Acq Side";
            // 
            // comboAlgaeAcqSide
            // 
            this.comboAlgaeAcqSide.BackColor = System.Drawing.Color.Black;
            this.comboAlgaeAcqSide.ForeColor = System.Drawing.Color.White;
            this.comboAlgaeAcqSide.FormattingEnabled = true;
            this.comboAlgaeAcqSide.Items.AddRange(new object[] {
            "-",
            "Near",
            "Far"});
            this.comboAlgaeAcqSide.Location = new System.Drawing.Point(14, 197);
            this.comboAlgaeAcqSide.Margin = new System.Windows.Forms.Padding(4);
            this.comboAlgaeAcqSide.Name = "comboAlgaeAcqSide";
            this.comboAlgaeAcqSide.Size = new System.Drawing.Size(119, 29);
            this.comboAlgaeAcqSide.TabIndex = 360;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(12, 177);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(113, 19);
            this.label14.TabIndex = 359;
            this.label14.Text = "Algae Acq Side";
            // 
            // comboAlgaeDelDest
            // 
            this.comboAlgaeDelDest.BackColor = System.Drawing.Color.Black;
            this.comboAlgaeDelDest.ForeColor = System.Drawing.Color.White;
            this.comboAlgaeDelDest.FormattingEnabled = true;
            this.comboAlgaeDelDest.Items.AddRange(new object[] {
            "-",
            "L4",
            "L3",
            "L2",
            "L1",
            "Floor"});
            this.comboAlgaeDelDest.Location = new System.Drawing.Point(12, 148);
            this.comboAlgaeDelDest.Margin = new System.Windows.Forms.Padding(4);
            this.comboAlgaeDelDest.Name = "comboAlgaeDelDest";
            this.comboAlgaeDelDest.Size = new System.Drawing.Size(78, 29);
            this.comboAlgaeDelDest.TabIndex = 358;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(14, 128);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 19);
            this.label9.TabIndex = 357;
            this.label9.Text = "Algae Del Dest";
            // 
            // comboAlgaeDelSide
            // 
            this.comboAlgaeDelSide.BackColor = System.Drawing.Color.Black;
            this.comboAlgaeDelSide.ForeColor = System.Drawing.Color.White;
            this.comboAlgaeDelSide.FormattingEnabled = true;
            this.comboAlgaeDelSide.Items.AddRange(new object[] {
            "-",
            "Near",
            "Far"});
            this.comboAlgaeDelSide.Location = new System.Drawing.Point(12, 198);
            this.comboAlgaeDelSide.Margin = new System.Windows.Forms.Padding(4);
            this.comboAlgaeDelSide.Name = "comboAlgaeDelSide";
            this.comboAlgaeDelSide.Size = new System.Drawing.Size(119, 29);
            this.comboAlgaeDelSide.TabIndex = 364;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(10, 178);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(109, 19);
            this.label12.TabIndex = 363;
            this.label12.Text = "Algae Del Side";
            // 
            // comboCoralDelSide
            // 
            this.comboCoralDelSide.BackColor = System.Drawing.Color.Black;
            this.comboCoralDelSide.ForeColor = System.Drawing.Color.White;
            this.comboCoralDelSide.FormattingEnabled = true;
            this.comboCoralDelSide.Items.AddRange(new object[] {
            "-",
            "Near",
            "Far"});
            this.comboCoralDelSide.Location = new System.Drawing.Point(12, 95);
            this.comboCoralDelSide.Margin = new System.Windows.Forms.Padding(4);
            this.comboCoralDelSide.Name = "comboCoralDelSide";
            this.comboCoralDelSide.Size = new System.Drawing.Size(119, 29);
            this.comboCoralDelSide.TabIndex = 362;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(10, 75);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(106, 19);
            this.label15.TabIndex = 361;
            this.label15.Text = "Coral Del Side";
            // 
            // txtHPAmp
            // 
            this.txtHPAmp.BackColor = System.Drawing.Color.Black;
            this.txtHPAmp.ForeColor = System.Drawing.Color.White;
            this.txtHPAmp.Location = new System.Drawing.Point(878, 46);
            this.txtHPAmp.Margin = new System.Windows.Forms.Padding(4);
            this.txtHPAmp.Name = "txtHPAmp";
            this.txtHPAmp.Size = new System.Drawing.Size(81, 26);
            this.txtHPAmp.TabIndex = 42;
            this.txtHPAmp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.BackColor = System.Drawing.Color.Black;
            this.label32.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label32.Location = new System.Drawing.Point(873, 25);
            this.label32.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(69, 20);
            this.label32.TabIndex = 43;
            this.label32.Text = "HP Amp";
            // 
            // txtAvoidance
            // 
            this.txtAvoidance.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtAvoidance.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAvoidance.ForeColor = System.Drawing.Color.White;
            this.txtAvoidance.Location = new System.Drawing.Point(293, 107);
            this.txtAvoidance.Margin = new System.Windows.Forms.Padding(4);
            this.txtAvoidance.Name = "txtAvoidance";
            this.txtAvoidance.Size = new System.Drawing.Size(41, 26);
            this.txtAvoidance.TabIndex = 46;
            this.txtAvoidance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.Black;
            this.label29.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label29.Location = new System.Drawing.Point(984, 86);
            this.label29.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(37, 20);
            this.label29.TabIndex = 49;
            this.label29.Text = "Avo";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.Color.Black;
            this.label31.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label31.Location = new System.Drawing.Point(984, 25);
            this.label31.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(34, 20);
            this.label31.TabIndex = 45;
            this.label31.Text = "Def";
            // 
            // txtDefense
            // 
            this.txtDefense.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtDefense.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDefense.ForeColor = System.Drawing.Color.White;
            this.txtDefense.Location = new System.Drawing.Point(293, 46);
            this.txtDefense.Margin = new System.Windows.Forms.Padding(4);
            this.txtDefense.Name = "txtDefense";
            this.txtDefense.Size = new System.Drawing.Size(41, 26);
            this.txtDefense.TabIndex = 43;
            this.txtDefense.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(350, 25);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 20);
            this.label6.TabIndex = 48;
            this.label6.Text = "Eff";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox1.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(354, 46);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(41, 26);
            this.textBox1.TabIndex = 47;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UpdateDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1180, 665);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.checkEndMatch);
            this.Controls.Add(this.checkEndAuto);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel11);
            this.Margin = new System.Windows.Forms.Padding(4);
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
            ((System.ComponentModel.ISupportInitialize)(this.scoutingDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updatePreviewsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkEndMatch;
        private System.Windows.Forms.CheckBox checkEndAuto;
        private scoutingdbDataSet scoutingDBDataSet;
        private System.Windows.Forms.BindingSource updatePreviewsBindingSource;
        private scoutingdbDataSetTableAdapters.UpdatePreviewsTableAdapter updatePreviewsTableAdapter;
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
        private System.Windows.Forms.ComboBox comboEndState;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox comboClimbAttempt;
        private System.Windows.Forms.TextBox txtClimbTime;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboCoralAcqLoc;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboCoralDelDest;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtRobotSetup;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtLeave;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Panel panel4;
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
        private System.Windows.Forms.ComboBox comboAlgaeAcqLoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboCoralAcqSide;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboAlgaeAcqSide;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboAlgaeDelSide;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboCoralDelSide;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboAlgaeDelDest;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox txtHPAmp;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox txtAvoidance;
        private System.Windows.Forms.TextBox txtDefense;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
    }
}