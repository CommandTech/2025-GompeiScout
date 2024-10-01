using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using ScoutingCodeRedo.Dynamic;
using System;

namespace ScoutingCodeRedo.Static
{
    public partial class SwapScouters : Form
    {
        public List<ComboBox> scoutDrops = new List<ComboBox>();

        public Dictionary<RobotState.SCOUTER_NAME, int> scouterDict = new Dictionary<RobotState.SCOUTER_NAME, int>();
        public SwapScouters()
        {
            InitializeComponent();
            for (int i = 0; i < 6; i++)
            {
                if (BackgroundCode.Robots[i].getScouterName(RobotState.SCOUTER_NAME.Select_Name) != RobotState.SCOUTER_NAME.Select_Name)
                {
                    scouterDict.Add(BackgroundCode.Robots[i].getScouterName(RobotState.SCOUTER_NAME.Select_Name), BackgroundCode.Robots[i].ScouterBox);
                }
            }

            scoutDrops.Add(ScoutDrop0);
            scoutDrops.Add(ScoutDrop1);
            scoutDrops.Add(ScoutDrop2);
            scoutDrops.Add(ScoutDrop3);
            scoutDrops.Add(ScoutDrop4);
            scoutDrops.Add(ScoutDrop5);

            foreach (var comboBox in scoutDrops)
            {
                comboBox.Items.AddRange(scouterDict.Keys.Select(sn => sn.ToString()).ToArray());
                comboBox.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged);
            }
        }

        private void ScoutOK_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 6; i++)
            {
                if (scoutDrops[i].SelectedIndex != -1)
                {
                    Enum.TryParse(scoutDrops[i].SelectedItem.ToString(), out RobotState.SCOUTER_NAME name);
                    var keyList = scouterDict.Keys.ToList();

                    BackgroundCode.Robots[i].ScouterBox = scouterDict[name];
                    scouterDict[name] = i;
                }
            }

            foreach (var robot in BackgroundCode.Robots)
            {
                try {
                    robot.ScouterBox = scouterDict[robot.getScouterName(RobotState.SCOUTER_NAME.Select_Name)];
                }
                catch { }
            }

            this.Hide();
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateComboBox(scoutDrops);
        }
        private void UpdateComboBox(List<ComboBox> comboBoxes)
        {
            List<RobotState.SCOUTER_NAME> scouterNamesC = new List<RobotState.SCOUTER_NAME>();

            scouterNamesC = scouterDict.Keys.ToList();
            var selectedNames = comboBoxes.Select(cb => cb.SelectedItem).ToList();

            scouterNamesC.RemoveAll(sn => selectedNames.Contains(sn.ToString()));

            foreach (var comboBox in comboBoxes)
            {
                comboBox.SelectedIndexChanged -= ComboBox_SelectedIndexChanged;

                var prevItem = comboBox.SelectedItem;
                comboBox.Items.Clear();
                comboBox.Items.AddRange(scouterNamesC.Select(sn => sn.ToString()).ToArray());

                if (prevItem != null && comboBox.SelectedIndex == -1)
                {
                    comboBox.Items.Add(prevItem);
                    comboBox.SelectedItem = prevItem;
                }

                comboBox.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            }
        }

        private void ClearScouters(object sender, EventArgs e)
        {
            foreach (var comboBox in scoutDrops)
            {
                comboBox.SelectedItem = null;
                comboBox.Items.Clear();
                comboBox.Items.AddRange(scouterDict.Keys.Select(sn => sn.ToString()).ToArray());
            }
        }
    }
}
