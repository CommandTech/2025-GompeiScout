using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoutingCodeRedo.Static
{
    partial class PriorityForm
    {
        private System.ComponentModel.IContainer components = null;
        #region
        private void InitializeComponent()
        {
            this.UpdateScouterText = new System.Windows.Forms.Label();
            this.PrioOK = new System.Windows.Forms.Button();
            this.TeamList = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            // PriorityForm
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(535, 231);
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
    }
}
