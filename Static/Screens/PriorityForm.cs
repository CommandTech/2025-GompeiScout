using ScoutingCodeRedo.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ScoutingCodeRedo.Static
{
    internal partial class PriorityForm : Form
    {
        public PriorityForm()
        {
            InitializeComponent();

            TeamList.Text = string.Join(", ", BackgroundCode.teamPrio);

            combohomeTeam.Items.Add("None");
            combohomeTeam.Items.AddRange(BackgroundCode.teamlist.ToArray());
            combohomeTeam.SelectedItem = BackgroundCode.homeTeam;
        }

        private void ScoutOK_Click(object sender, EventArgs e)
        {
            var teamPrioList = TeamList.Text.Split(',')
                                .Select(team => team.Trim())
                                .ToArray();

            BackgroundCode.teamPrio.Clear();
            BackgroundCode.teamPrio.AddRange(teamPrioList);

            BackgroundCode.homeTeam = combohomeTeam.SelectedItem.ToString();

            BaseScreen.RefreshPrio();

            this.Hide();
        }
    }
}
