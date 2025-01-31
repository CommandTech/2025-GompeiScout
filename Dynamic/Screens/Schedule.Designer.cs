namespace ScoutingCodeRedo.Dynamic.Screens
{
    partial class Schedule
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
            this.CagesOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chckLstBxScouters = new System.Windows.Forms.CheckedListBox();
            this.btnSet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CagesOK
            // 
            this.CagesOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CagesOK.ForeColor = System.Drawing.Color.Black;
            this.CagesOK.Location = new System.Drawing.Point(721, 401);
            this.CagesOK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CagesOK.Name = "CagesOK";
            this.CagesOK.Size = new System.Drawing.Size(66, 35);
            this.CagesOK.TabIndex = 364;
            this.CagesOK.Text = "OK";
            this.CagesOK.UseVisualStyleBackColor = true;
            this.CagesOK.Click += new System.EventHandler(this.CagesOK_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FloralWhite;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 26);
            this.label1.TabIndex = 366;
            this.label1.Text = "Scouters:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chckLstBxScouters
            // 
            this.chckLstBxScouters.FormattingEnabled = true;
            this.chckLstBxScouters.Location = new System.Drawing.Point(111, 32);
            this.chckLstBxScouters.Name = "chckLstBxScouters";
            this.chckLstBxScouters.Size = new System.Drawing.Size(120, 89);
            this.chckLstBxScouters.TabIndex = 367;
            // 
            // btnSet
            // 
            this.btnSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSet.ForeColor = System.Drawing.Color.Black;
            this.btnSet.Location = new System.Drawing.Point(238, 32);
            this.btnSet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(66, 35);
            this.btnSet.TabIndex = 368;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.BtnSet_Click);
            // 
            // Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.chckLstBxScouters);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CagesOK);
            this.Name = "Schedule";
            this.Text = "Schedule";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CagesOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox chckLstBxScouters;
        private System.Windows.Forms.Button btnSet;
    }
}