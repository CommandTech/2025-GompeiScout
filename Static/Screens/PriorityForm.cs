using ScoutingCodeRedo.Properties;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoutingCodeRedo.Static
{
    internal partial class PriorityForm : Form
    {
        public PriorityForm()
        {
            InitializeComponent();

            if (Settings.Default.teamPrio != null) TeamList.Text = string.Join(", ", Settings.Default.teamPrio);
        }

        private void ScoutOK_Click(object sender, EventArgs e)
        {
            var teamPrioList = TeamList.Text.Split(',')
                                .Select(team => team.Trim())
                                .ToArray();

            Settings.Default.teamPrio = new StringCollection();
            Settings.Default.teamPrio.AddRange(teamPrioList);

            this.Hide();
        }
    }
}
