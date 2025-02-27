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
                var currentMatch = BackgroundCode.InMemoryMatchList[Settings.Default.currentMatch - 1];
                var teams = new[] { currentMatch.Redteam1, currentMatch.Redteam2, currentMatch.Redteam3, currentMatch.Blueteam1, currentMatch.Blueteam2, currentMatch.Blueteam3 };

                comboPracticeTeams.Items.AddRange(teams);
                comboPracticeTeams.SelectedIndex = Settings.Default.practiceTeam;
            }
            catch
            {
                // Handle exception if necessary
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
            using (var frm = new PriorityForm())
            {
                this.Hide();
                frm.ShowDialog();
            }
        }

        private void BtnSwapScouters_Click(object sender, EventArgs e)
        {
            using (var frm = new SwapScouters())
            {
                this.Hide();
                frm.ShowDialog();
            }
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
                using (var frm = new UpdateDatabase(BackgroundCode.teamlist, BackgroundCode.MatchNumbers))
                {
                    this.Hide();
                    frm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Please load The Blue Alliance to create the database or create the database in a different way");
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
            using (var frm = new CagesForm())
            {
                this.Hide();
                frm.ShowDialog();
            }
        }
    }
}
