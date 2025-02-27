using ScoutingCodeRedo.Dynamic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

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
                var scouterName = BackgroundCode.Robots[i].GetScouterName();
                if (scouterName != RobotState.SCOUTER_NAME.Select_Name)
                {
                    scouterDict[scouterName] = BackgroundCode.Robots[i].ScouterBox;
                }
            }

            scoutDrops.AddRange(new[] { ScoutDrop0, ScoutDrop1, ScoutDrop2, ScoutDrop3, ScoutDrop4, ScoutDrop5 });

            var scouterNames = scouterDict.Keys.Select(sn => sn.ToString()).ToArray();
            foreach (var comboBox in scoutDrops)
            {
                comboBox.Items.AddRange(scouterNames);
                comboBox.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            }
        }

        private void ScoutOK_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 6; i++)
            {
                if (scoutDrops[i].SelectedIndex != -1)
                {
                    Enum.TryParse(scoutDrops[i].SelectedItem.ToString(), out RobotState.SCOUTER_NAME name);

                    for (int j = 0; j < 6; j++)
                    {
                        if (BackgroundCode.Robots[j]._ScouterName == name)
                        {
                            SwapRobots(i, j);
                            break;
                        }
                    }
                }
            }

            this.Hide();
        }

        private void SwapRobots(int i, int j)
        {
            (BackgroundCode.Robots[j], BackgroundCode.Robots[i]) = (BackgroundCode.Robots[i], BackgroundCode.Robots[j]);
            (BackgroundCode.Robots[j].ScouterBox, BackgroundCode.Robots[i].ScouterBox) = (BackgroundCode.Robots[i].ScouterBox, BackgroundCode.Robots[j].ScouterBox);
            (BackgroundCode.Robots[j].TeamName, BackgroundCode.Robots[i].TeamName) = (BackgroundCode.Robots[i].TeamName, BackgroundCode.Robots[j].TeamName);
            (BackgroundCode.Robots[j].color, BackgroundCode.Robots[i].color) = (BackgroundCode.Robots[i].color, BackgroundCode.Robots[j].color);
            (BackgroundCode.gamePads[j], BackgroundCode.gamePads[i]) = (BackgroundCode.gamePads[i], BackgroundCode.gamePads[j]);
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateComboBox(scoutDrops);
        }

        private void UpdateComboBox(List<ComboBox> comboBoxes)
        {
            var scouterNamesC = scouterDict.Keys.ToList();
            var selectedNames = comboBoxes.Select(cb => cb.SelectedItem?.ToString()).ToList();

            scouterNamesC.RemoveAll(sn => selectedNames.Contains(sn.ToString()));

            foreach (var comboBox in comboBoxes)
            {
                var prevItem = comboBox.SelectedItem;
                comboBox.SelectedIndexChanged -= ComboBox_SelectedIndexChanged;

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
            var scouterNames = scouterDict.Keys.Select(sn => sn.ToString()).ToArray();
            foreach (var comboBox in scoutDrops)
            {
                comboBox.SelectedItem = null;
                comboBox.Items.Clear();
                comboBox.Items.AddRange(scouterNames);
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            ClearScouters(null, null);
            for (int i = 0; i < 6; i++)
            {
                BackgroundCode.Robots[i].ScouterBox = i;
            }
            this.Hide();
        }
    }
}
