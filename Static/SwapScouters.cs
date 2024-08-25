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
        public List<RobotState.SCOUTER_NAME> scouterNamesC = new List<RobotState.SCOUTER_NAME>();

        public List<int> newLocations = new List<int>();

        public List<ComboBox> scoutDrops = new List<ComboBox>();

        public Dictionary<RobotState.SCOUTER_NAME, int> scouterDict = new Dictionary<RobotState.SCOUTER_NAME, int>();
        public SwapScouters()
        {
            InitializeComponent();
            for (int i = 0; i < 6; i++)
            {
                scouterNames.Add(BackgroundCode.Robots[i].getScouterName(RobotState.SCOUTER_NAME.Select_Name));
                scouterDict.Add(scouterNames[i], BackgroundCode.Robots[i].ScouterBox);
            }

            scoutDrops.Add(ScoutDrop0);
            scoutDrops.Add(ScoutDrop1);
            scoutDrops.Add(ScoutDrop2);
            scoutDrops.Add(ScoutDrop3);
            scoutDrops.Add(ScoutDrop4);
            scoutDrops.Add(ScoutDrop5);

            foreach (var comboBox in scoutDrops)
            {
                comboBox.Items.AddRange(scouterNames.Select(sn => sn.ToString()).ToArray());
                comboBox.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged);
            }
        }

        //How I vision this is that each robot state is an object, each one has an int that declares which box they are in, then when deciding which box gets controlled by which controller, it looks at the int.

        private void ScoutOK_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(scouterDict[scouterNames[i]]);
            }

            //bool error = false;
            //List<int> scouterIntsSelected = new List<int>();
            //foreach (var robot in BackgroundCode.Robots)
            //{
            //    if (!scouterIntsSelected.Contains(robot.ScouterBox))
            //    {
            //        scouterIntsSelected.Add(robot.ScouterBox);
            //    }
            //    else
            //    {
            //        MessageBox.Show("2 Scouters in the same spot.");
            //        error = true;
            //    }
            //}
            //if (!error)
            //{
            //    this.Hide();
            //}
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Update ComboBox items when a selection changes
            UpdateComboBox(scoutDrops);
        }
        private void UpdateComboBox(List<ComboBox> comboBoxes)
        {
            scouterNamesC = scouterNames.ToList();
            var selectedNames = comboBoxes.Select(cb => cb.SelectedItem).ToList();
            
            scouterNamesC.RemoveAll(sn => selectedNames.Contains(sn.ToString()));

            foreach (var comboBox in comboBoxes)
            {
                comboBox.SelectedIndexChanged -= ComboBox_SelectedIndexChanged;
            }

            foreach (var comboBox in comboBoxes)
            {
                var prevItem = comboBox.SelectedItem;
                comboBox.Items.Clear();
                comboBox.Items.AddRange(scouterNamesC.Select(sn => sn.ToString()).ToArray());

                if (prevItem != null && comboBox.SelectedIndex == -1)
                {
                    comboBox.Items.Add(prevItem);
                    comboBox.SelectedItem = prevItem;
                }
            }

            foreach (var comboBox in comboBoxes)
            {
                comboBox.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            }
        }

        private void ClearScouters(object sender, EventArgs e)
        {
            foreach (var comboBox in scoutDrops)
            {
                comboBox.SelectedItem = null;
                comboBox.Items.Clear();
                comboBox.Items.AddRange(scouterNames.Select(sn => sn.ToString()).ToArray());
            }
        }
    }
}
