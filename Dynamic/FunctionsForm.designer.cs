namespace ScoutingCodeRedo.Dynamic
{
    partial class FunctionsForm
    {
        #region
        private void InitializeComponent()
        {
            this.UpdateScouterText = new System.Windows.Forms.Label();
            this.FuncOK = new System.Windows.Forms.Button();
            this.btnPriority = new System.Windows.Forms.Button();
            this.btnSwapScouters = new System.Windows.Forms.Button();
            this.cbxPractice = new System.Windows.Forms.CheckBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnUpdateDatabase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UpdateScouterText
            // 
            this.UpdateScouterText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UpdateScouterText.BackColor = System.Drawing.Color.Transparent;
            this.UpdateScouterText.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateScouterText.ForeColor = System.Drawing.Color.FloralWhite;
            this.UpdateScouterText.Location = new System.Drawing.Point(12, 20);
            this.UpdateScouterText.Name = "UpdateScouterText";
            this.UpdateScouterText.Size = new System.Drawing.Size(263, 74);
            this.UpdateScouterText.TabIndex = 353;
            this.UpdateScouterText.Text = "Functions";
            // 
            // FuncOK
            // 
            this.FuncOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FuncOK.ForeColor = System.Drawing.Color.Black;
            this.FuncOK.Location = new System.Drawing.Point(269, 296);
            this.FuncOK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FuncOK.Name = "FuncOK";
            this.FuncOK.Size = new System.Drawing.Size(66, 35);
            this.FuncOK.TabIndex = 352;
            this.FuncOK.Text = "OK";
            this.FuncOK.UseVisualStyleBackColor = true;
            this.FuncOK.Click += new System.EventHandler(this.FuncOK_Click);
            // 
            // btnPriority
            // 
            this.btnPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPriority.ForeColor = System.Drawing.Color.Black;
            this.btnPriority.Location = new System.Drawing.Point(24, 99);
            this.btnPriority.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPriority.Name = "btnPriority";
            this.btnPriority.Size = new System.Drawing.Size(97, 35);
            this.btnPriority.TabIndex = 354;
            this.btnPriority.Text = "Priority";
            this.btnPriority.UseVisualStyleBackColor = true;
            this.btnPriority.Click += new System.EventHandler(this.BtnPriority_Click);
            // 
            // btnSwapScouters
            // 
            this.btnSwapScouters.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSwapScouters.ForeColor = System.Drawing.Color.Black;
            this.btnSwapScouters.Location = new System.Drawing.Point(24, 144);
            this.btnSwapScouters.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSwapScouters.Name = "btnSwapScouters";
            this.btnSwapScouters.Size = new System.Drawing.Size(179, 35);
            this.btnSwapScouters.TabIndex = 355;
            this.btnSwapScouters.Text = "Swap Scouters";
            this.btnSwapScouters.UseVisualStyleBackColor = true;
            this.btnSwapScouters.Click += new System.EventHandler(this.BtnSwapScouters_Click);
            // 
            // cbxPractice
            // 
            this.cbxPractice.AutoSize = true;
            this.cbxPractice.BackColor = System.Drawing.Color.Black;
            this.cbxPractice.ForeColor = System.Drawing.Color.Yellow;
            this.cbxPractice.Location = new System.Drawing.Point(261, 99);
            this.cbxPractice.Margin = new System.Windows.Forms.Padding(2);
            this.cbxPractice.Name = "cbxPractice";
            this.cbxPractice.Size = new System.Drawing.Size(116, 20);
            this.cbxPractice.TabIndex = 356;
            this.cbxPractice.Text = "Practice Mode";
            this.cbxPractice.UseVisualStyleBackColor = false;
            this.cbxPractice.CheckedChanged += new System.EventHandler(this.CbxPractice_CheckedChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.Location = new System.Drawing.Point(24, 189);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(226, 35);
            this.btnRefresh.TabIndex = 357;
            this.btnRefresh.Text = "Refresh Controllers";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // btnUpdateDatabase
            // 
            this.btnUpdateDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateDatabase.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateDatabase.Location = new System.Drawing.Point(24, 234);
            this.btnUpdateDatabase.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdateDatabase.Name = "btnUpdateDatabase";
            this.btnUpdateDatabase.Size = new System.Drawing.Size(202, 35);
            this.btnUpdateDatabase.TabIndex = 358;
            this.btnUpdateDatabase.Text = "Update Database";
            this.btnUpdateDatabase.UseVisualStyleBackColor = true;
            this.btnUpdateDatabase.Click += new System.EventHandler(this.BtnUpdateDatabase_Click);
            // 
            // FunctionsForm
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(408, 362);
            this.Controls.Add(this.btnUpdateDatabase);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.cbxPractice);
            this.Controls.Add(this.btnSwapScouters);
            this.Controls.Add(this.btnPriority);
            this.Controls.Add(this.UpdateScouterText);
            this.Controls.Add(this.FuncOK);
            this.Name = "FunctionsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UpdateScouterText;
        private System.Windows.Forms.Button FuncOK;
        private System.Windows.Forms.Button btnPriority;
        private System.Windows.Forms.Button btnSwapScouters;
        private System.Windows.Forms.CheckBox cbxPractice;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnUpdateDatabase;
    }
}
