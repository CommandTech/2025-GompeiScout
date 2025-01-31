using ScoutingCodeRedo.Properties;
using System;
using System.Collections.Generic;
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
            //When the team is saved, find the next match of that team and prioritize the other 5 teams in that match
            //Highlight those teams when the show up
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

            for (int i = Settings.Default.currentMatch + 1; i < BackgroundCode.InMemoryMatchList.Count; i++)
            {
                List<string> teams = new List<string>
                {
                    BackgroundCode.InMemoryMatchList[i].Redteam1,
                    BackgroundCode.InMemoryMatchList[i].Redteam2,
                    BackgroundCode.InMemoryMatchList[i].Redteam3,
                    BackgroundCode.InMemoryMatchList[i].Blueteam1,
                    BackgroundCode.InMemoryMatchList[i].Blueteam2,
                    BackgroundCode.InMemoryMatchList[i].Blueteam3
                };

                if (teams.Contains(BackgroundCode.homeTeam))
                {
                    Console.WriteLine(BackgroundCode.InMemoryMatchList[i].Id);
                    break;
                }
            }

            this.Hide();
        }
    }
}
