using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using ScoutingCodeRedo.Dynamic;
using System;

namespace ScoutingCodeRedo.Static
{
    public partial class SwapScouters : Form
    {
        public List<RobotState.SCOUTER_NAME> scouterNames = new List<RobotState.SCOUTER_NAME>();
        public SwapScouters()
        {
            InitializeComponent();
            for (int i = 0; i < 6; i++)
            {
                scouterNames.Add(BackgroundCode.Robots[i].getScouterName(RobotState.SCOUTER_NAME.Select_Name));
            }
            this.ScoutDrop0.Items.AddRange(scouterNames.Select(sn => sn.ToString()).ToArray());
            this.ScoutDrop1.Items.AddRange(scouterNames.Select(sn => sn.ToString()).ToArray());
            this.ScoutDrop2.Items.AddRange(scouterNames.Select(sn => sn.ToString()).ToArray());
            this.ScoutDrop3.Items.AddRange(scouterNames.Select(sn => sn.ToString()).ToArray());
            this.ScoutDrop4.Items.AddRange(scouterNames.Select(sn => sn.ToString()).ToArray());
            this.ScoutDrop5.Items.AddRange(scouterNames.Select(sn => sn.ToString()).ToArray());
        }

        //How I vision this is that each robot state is an object, each one has an int that declares which box they are in, then when deciding which box gets controlled by which controller, it looks at the int.
    }
}
