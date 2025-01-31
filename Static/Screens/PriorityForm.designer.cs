namespace ScoutingCodeRedo.Static
{
    partial class PriorityForm
    {
        #region
        private void InitializeComponent()
        {
            this.UpdateScouterText = new System.Windows.Forms.Label();
            this.PrioOK = new System.Windows.Forms.Button();
            this.TeamList = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.combohomeTeam = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UpdateScouterText
            // 
            this.UpdateScouterText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UpdateScouterText.BackColor = System.Drawing.Color.Transparent;
            this.UpdateScouterText.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateScouterText.ForeColor = System.Drawing.Color.FloralWhite;
            this.UpdateScouterText.Location = new System.Drawing.Point(45, 24);
            this.UpdateScouterText.Name = "UpdateScouterText";
            this.UpdateScouterText.Size = new System.Drawing.Size(435, 74);
            this.UpdateScouterText.TabIndex = 353;
            this.UpdateScouterText.Text = "Scouting Priority";
            this.UpdateScouterText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PrioOK
            // 
            this.PrioOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrioOK.ForeColor = System.Drawing.Color.Navy;
            this.PrioOK.Location = new System.Drawing.Point(452, 179);
            this.PrioOK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PrioOK.Name = "PrioOK";
            this.PrioOK.Size = new System.Drawing.Size(66, 35);
            this.PrioOK.TabIndex = 352;
            this.PrioOK.Text = "OK";
            this.PrioOK.UseVisualStyleBackColor = true;
            this.PrioOK.Click += new System.EventHandler(this.ScoutOK_Click);
            // 
            // TeamList
            // 
            this.TeamList.BackColor = System.Drawing.Color.Black;
            this.TeamList.ForeColor = System.Drawing.Color.White;
            this.TeamList.Location = new System.Drawing.Point(185, 124);
            this.TeamList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TeamList.Name = "TeamList";
            this.TeamList.Size = new System.Drawing.Size(163, 26);
            this.TeamList.TabIndex = 351;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FloralWhite;
            this.label1.Location = new System.Drawing.Point(60, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 26);
            this.label1.TabIndex = 354;
            this.label1.Text = "Team List:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // combohomeTeam
            // 
            this.combohomeTeam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.combohomeTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combohomeTeam.ForeColor = System.Drawing.Color.Yellow;
            this.combohomeTeam.FormattingEnabled = true;
            this.combohomeTeam.Location = new System.Drawing.Point(185, 179);
            this.combohomeTeam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.combohomeTeam.Name = "combohomeTeam";
            this.combohomeTeam.Size = new System.Drawing.Size(163, 28);
            this.combohomeTeam.TabIndex = 361;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FloralWhite;
            this.label2.Location = new System.Drawing.Point(57, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 26);
            this.label2.TabIndex = 362;
            this.label2.Text = "Your Team:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PriorityForm
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(535, 231);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.combohomeTeam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UpdateScouterText);
            this.Controls.Add(this.PrioOK);
            this.Controls.Add(this.TeamList);
            this.Name = "PriorityForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UpdateScouterText;
        private System.Windows.Forms.Button PrioOK;
        private System.Windows.Forms.TextBox TeamList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combohomeTeam;
        private System.Windows.Forms.Label label2;
    }
}
