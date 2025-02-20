using ScoutingCodeRedo.Dynamic.Screens;
using ScoutingCodeRedo.Properties;
using ScoutingCodeRedo.Static;
using System;
using System.Windows.Forms;

namespace ScoutingCodeRedo.Dynamic
{
    internal partial class FunctionsForm : Form
    {
        public FunctionsForm()
        {
            InitializeComponent();
            cbxPractice.Checked = Settings.Default.practiceMode;

            comboPracticeTeams.Visible = Settings.Default.practiceMode;

            try
            {
                comboPracticeTeams.Items.Add(BackgroundCode.InMemoryMatchList[Settings.Default.currentMatch - 1].Redteam1);
                comboPracticeTeams.Items.Add(BackgroundCode.InMemoryMatchList[Settings.Default.currentMatch - 1].Redteam2);
                comboPracticeTeams.Items.Add(BackgroundCode.InMemoryMatchList[Settings.Default.currentMatch - 1].Redteam3);
                comboPracticeTeams.Items.Add(BackgroundCode.InMemoryMatchList[Settings.Default.currentMatch - 1].Blueteam1);
                comboPracticeTeams.Items.Add(BackgroundCode.InMemoryMatchList[Settings.Default.currentMatch - 1].Blueteam2);
                comboPracticeTeams.Items.Add(BackgroundCode.InMemoryMatchList[Settings.Default.currentMatch - 1].Blueteam3);

                comboPracticeTeams.SelectedIndex = Settings.Default.practiceTeam;
            }
            catch
            {

            }
        }
        private void ComboPracticeTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            Settings.Default.practiceChanged = true;
            Settings.Default.practiceTeam = comboPracticeTeams.SelectedIndex;
        }

        private void FuncOK_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BtnPriority_Click(object sender, EventArgs e)
        {
            PriorityForm frm = new PriorityForm();
            this.Hide();
            frm.Show();
        }

        private void BtnSwapScouters_Click(object sender, EventArgs e)
        {
            SwapScouters frm = new SwapScouters();
            this.Hide();
            frm.Show();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            BaseScreen.UpdateJoysticks();
            this.Hide();
        }

        private void BtnUpdateDatabase_Click(object sender, EventArgs e)
        {
            if (Settings.Default.DBExists)
            {
                UpdateDatabase frm = new UpdateDatabase(BackgroundCode.teamlist, BackgroundCode.MatchNumbers);
                this.Hide();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Please load The Blue Aliance to create the database or create the database in a different way");
            }
        }

        private void CbxPractice_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.practiceMode = cbxPractice.Checked;
            comboPracticeTeams.Visible = Settings.Default.practiceMode;
            if (!Settings.Default.practiceMode) BaseScreen.wasPractice = true;
        }

        private void BtnCages_Click(object sender, EventArgs e)
        {
            CagesForm frm = new CagesForm();
            this.Hide();
            frm.Show();
        }
    }
}
