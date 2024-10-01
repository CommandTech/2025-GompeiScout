using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoutingCodeRedo.Static
{
    partial class SwapScouters
    {
        private System.ComponentModel.IContainer components = null;
        #region
        private void InitializeComponent()
        {
            this.UpdateScouterText = new System.Windows.Forms.Label();
            this.ScoutOK = new System.Windows.Forms.Button();
            this.ScoutDrop5 = new System.Windows.Forms.ComboBox();
            this.ScoutDrop4 = new System.Windows.Forms.ComboBox();
            this.ScoutDrop3 = new System.Windows.Forms.ComboBox();
            this.ScoutDrop2 = new System.Windows.Forms.ComboBox();
            this.ScoutDrop1 = new System.Windows.Forms.ComboBox();
            this.ScoutDrop0 = new System.Windows.Forms.ComboBox();
            this.clearScouters = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
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
            this.UpdateScouterText.Text = "Update Scouters";
            this.UpdateScouterText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ScoutOK
            // 
            this.ScoutOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoutOK.ForeColor = System.Drawing.Color.Navy;
            this.ScoutOK.Location = new System.Drawing.Point(452, 179);
            this.ScoutOK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ScoutOK.Name = "ScoutOK";
            this.ScoutOK.Size = new System.Drawing.Size(66, 35);
            this.ScoutOK.TabIndex = 352;
            this.ScoutOK.Text = "OK";
            this.ScoutOK.UseVisualStyleBackColor = true;
            this.ScoutOK.Click += new System.EventHandler(this.ScoutOK_Click);
            // 
            // ScoutDrop5
            // 
            this.ScoutDrop5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ScoutDrop5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ScoutDrop5.ForeColor = System.Drawing.Color.Yellow;
            this.ScoutDrop5.FormattingEnabled = true;
            this.ScoutDrop5.Location = new System.Drawing.Point(355, 141);
            this.ScoutDrop5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ScoutDrop5.Name = "ScoutDrop5";
            this.ScoutDrop5.Size = new System.Drawing.Size(163, 28);
            this.ScoutDrop5.TabIndex = 351;
            // 
            // ScoutDrop4
            // 
            this.ScoutDrop4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ScoutDrop4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ScoutDrop4.ForeColor = System.Drawing.Color.Yellow;
            this.ScoutDrop4.FormattingEnabled = true;
            this.ScoutDrop4.Location = new System.Drawing.Point(184, 141);
            this.ScoutDrop4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ScoutDrop4.Name = "ScoutDrop4";
            this.ScoutDrop4.Size = new System.Drawing.Size(163, 28);
            this.ScoutDrop4.TabIndex = 350;
            // 
            // ScoutDrop3
            // 
            this.ScoutDrop3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ScoutDrop3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ScoutDrop3.ForeColor = System.Drawing.Color.Yellow;
            this.ScoutDrop3.FormattingEnabled = true;
            this.ScoutDrop3.Location = new System.Drawing.Point(13, 141);
            this.ScoutDrop3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ScoutDrop3.Name = "ScoutDrop3";
            this.ScoutDrop3.Size = new System.Drawing.Size(163, 28);
            this.ScoutDrop3.TabIndex = 349;
            // 
            // ScoutDrop2
            // 
            this.ScoutDrop2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ScoutDrop2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ScoutDrop2.ForeColor = System.Drawing.Color.Yellow;
            this.ScoutDrop2.FormattingEnabled = true;
            this.ScoutDrop2.Location = new System.Drawing.Point(355, 103);
            this.ScoutDrop2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ScoutDrop2.Name = "ScoutDrop2";
            this.ScoutDrop2.Size = new System.Drawing.Size(163, 28);
            this.ScoutDrop2.TabIndex = 348;
            // 
            // ScoutDrop1
            // 
            this.ScoutDrop1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ScoutDrop1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ScoutDrop1.ForeColor = System.Drawing.Color.Yellow;
            this.ScoutDrop1.FormattingEnabled = true;
            this.ScoutDrop1.Location = new System.Drawing.Point(184, 103);
            this.ScoutDrop1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ScoutDrop1.Name = "ScoutDrop1";
            this.ScoutDrop1.Size = new System.Drawing.Size(163, 28);
            this.ScoutDrop1.TabIndex = 347;
            // 
            // ScoutDrop0
            // 
            this.ScoutDrop0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ScoutDrop0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ScoutDrop0.ForeColor = System.Drawing.Color.Yellow;
            this.ScoutDrop0.FormattingEnabled = true;
            this.ScoutDrop0.Location = new System.Drawing.Point(13, 103);
            this.ScoutDrop0.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ScoutDrop0.Name = "ScoutDrop0";
            this.ScoutDrop0.Size = new System.Drawing.Size(163, 28);
            this.ScoutDrop0.TabIndex = 346;
            // 
            // clearScouters
            // 
            this.clearScouters.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearScouters.ForeColor = System.Drawing.Color.Navy;
            this.clearScouters.Location = new System.Drawing.Point(13, 182);
            this.clearScouters.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clearScouters.Name = "clearScouters";
            this.clearScouters.Size = new System.Drawing.Size(99, 35);
            this.clearScouters.TabIndex = 354;
            this.clearScouters.Text = "CLEAR";
            this.clearScouters.UseVisualStyleBackColor = true;
            this.clearScouters.Click += new System.EventHandler(this.ClearScouters);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.Navy;
            this.btnReset.Location = new System.Drawing.Point(120, 182);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(99, 35);
            this.btnReset.TabIndex = 355;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // SwapScouters
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(535, 231);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.clearScouters);
            this.Controls.Add(this.UpdateScouterText);
            this.Controls.Add(this.ScoutOK);
            this.Controls.Add(this.ScoutDrop5);
            this.Controls.Add(this.ScoutDrop4);
            this.Controls.Add(this.ScoutDrop3);
            this.Controls.Add(this.ScoutDrop2);
            this.Controls.Add(this.ScoutDrop1);
            this.Controls.Add(this.ScoutDrop0);
            this.Name = "SwapScouters";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label UpdateScouterText;
        private System.Windows.Forms.Button ScoutOK;
        private System.Windows.Forms.ComboBox ScoutDrop5;
        private System.Windows.Forms.ComboBox ScoutDrop4;
        private System.Windows.Forms.ComboBox ScoutDrop3;
        private System.Windows.Forms.ComboBox ScoutDrop2;
        private System.Windows.Forms.ComboBox ScoutDrop1;
        private System.Windows.Forms.ComboBox ScoutDrop0;
        private System.Windows.Forms.Button clearScouters;
        private System.Windows.Forms.Button btnReset;
    }
}
