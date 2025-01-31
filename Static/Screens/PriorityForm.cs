using ScoutingCodeRedo.Properties;
using System;
using System.Collections.Specialized;
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
            //Make a new drop down that has all the teams from BackgroundCode.teamList
            //Automatically select the last selected team on the drop down if any
            //When the team is saved, find the next match of that team and prioritize the other 5 teams in that match
            //Highlight those teams when the show up

        }

        private void ScoutOK_Click(object sender, EventArgs e)
        {
            var teamPrioList = TeamList.Text.Split(',')
                                .Select(team => team.Trim())
                                .ToArray();

            BackgroundCode.teamPrio.Clear();
            BackgroundCode.teamPrio.AddRange(teamPrioList);

            this.Hide();
        }
    }
}
