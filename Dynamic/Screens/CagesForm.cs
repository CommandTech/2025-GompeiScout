using ScoutingCodeRedo.Static;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ScoutingCodeRedo.Dynamic.Screens
{
    internal partial class CagesForm : Form
    {
        private readonly List<ComboBox> Cages = new();
        public CagesForm()
        {
            InitializeComponent();

            Cages.Add(Red1);
            Cages.Add(Red2);
            Cages.Add(Red3);
            Cages.Add(Blue1);
            Cages.Add(Blue2);
            Cages.Add(Blue3);

            lblRed0.Text = BackgroundCode.UnSortedMatchList[0].Redteam1;
            lblRed1.Text = BackgroundCode.UnSortedMatchList[0].Redteam2;
            lblRed2.Text = BackgroundCode.UnSortedMatchList[0].Redteam3;

            lblBlue0.Text = BackgroundCode.UnSortedMatchList[0].Blueteam1;
            lblBlue1.Text = BackgroundCode.UnSortedMatchList[0].Blueteam2;
            lblBlue2.Text = BackgroundCode.UnSortedMatchList[0].Blueteam3;

            for (int i = 0; i < 6; i++)
            {
                Cages[i].SelectedIndex = Cages[i].Items.IndexOf(BackgroundCode.cages[i]);
            }
        }

        private void CagesOK_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 6; i++)
            {
                BackgroundCode.cages[i] = Cages[i].Text;
                BackgroundCode.Robots[i].Selected_Cage = BackgroundCode.cages[i];
            }

            this.Hide();
        }
    }
}
