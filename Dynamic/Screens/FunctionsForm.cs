using ScoutingCodeRedo.Dynamic.Screens;
using ScoutingCodeRedo.Properties;
using ScoutingCodeRedo.Static;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace ScoutingCodeRedo.Dynamic
{
    internal partial class FunctionsForm : Form
    {
        public FunctionsForm()
        {
            InitializeComponent();
            cbxPractice.Checked = Settings.Default.practiceMode;
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
        }

        private void btnCages_Click(object sender, EventArgs e)
        {
            CagesForm frm = new CagesForm();
            this.Hide();
            frm.Show();
        }

        private void btnFakeData_Click(object sender, EventArgs e)
        {
            Settings.Default.generateFakeData = !Settings.Default.generateFakeData;
            foreach (var team in BackgroundCode.teamlist)
            {
                Random random = new Random();

                TeamState state = new TeamState();
                state.TeamName = team;

                state.canLeave = random.Next(100) > 12;
                state.canHoldCoral = random.Next(100) > 20;
                if (state.canHoldCoral)
                {
                    state.canPickupStation = true;
                    state.canPickupStation = random.Next(100) > 23;
                    state.canPickupFloorCoral = random.Next(100) > 62;
                    state.canScoreL4 = random.Next(100) > 35;
                    state.canScoreL3 = random.Next(100) > 25;
                    state.canScoreL2 = random.Next(100) > 20;
                    state.canScoreL1 = random.Next(100) > 10;
                }
                state.canHoldAlgae = random.Next(100) > 36;
                state.canDislodgeAlgae = random.Next(100) > 20;

                if (state.canHoldAlgae)
                {
                    state.canPickupReef = random.Next(100) > 25;
                    state.canPickupFloorAlgae = true;
                    state.canPickupFloorAlgae = random.Next(100) > 10;
                    state.canScoreProcessor = random.Next(100) > 45;
                    state.canScoreNet = random.Next(100) > 15;
                }

                state.canClimbDeep = random.Next(100) > 52;
                state.canClimbShallow = random.Next(2) > 24;


                if (!BackgroundCode.teamStates.Contains(state))
                {
                    BackgroundCode.teamStates.Add(state);
                }
            }

            this.Hide();
        }
    }
}
