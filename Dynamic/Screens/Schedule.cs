using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScoutingCodeRedo.Static;
using static ScoutingCodeRedo.Dynamic.RobotState;

namespace ScoutingCodeRedo.Dynamic.Screens
{
    public partial class Schedule : Form
    {
        readonly List<string> scouters = new List<string>();
        public Schedule()
        {
            InitializeComponent();
    
            chckLstBxScouters.Items.AddRange(Enum.GetNames(typeof(SCOUTER_NAME)));
            chckLstBxScouters.Height = chckLstBxScouters.Items.Count * 16;

            this.Height = chckLstBxScouters.Height + 100;
        }


        private void CagesOK_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BtnSet_Click(object sender, EventArgs e)
        {
            scouters.AddRange(chckLstBxScouters.CheckedItems.Cast<string>());
        }
    }
}
