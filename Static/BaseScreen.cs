using ScoutingCodeRedo.Dynamic;
using System;
using System.Collections.Generic;
using System.Net;
using System.Windows.Forms;

namespace ScoutingCodeRedo.Static
{
    internal partial class BaseScreen : Form
    {

        BackgroundCode bgc;
        public BaseScreen()
        {
            InitializeComponent();
            bgc = new BackgroundCode();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
        private void btnInitialDBLoad_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to load The Blue Alliance data?", "Please Confirm", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //BuildInitialDatabase();
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("The Blue Alliance data was not loaded", "", MessageBoxButtons.OK);
            }

            //  Logic for setting left/right and near/far based on side of field scouters are sitting on
            DialogResult red = MessageBox.Show("Is the Red Alliance on your right?", "Please Confirm", MessageBoxButtons.YesNo);
            if (red == DialogResult.Yes)
            {
                Properties.Settings.Default.redRight = true;
            }
            else
            {
                Properties.Settings.Default.redRight = false;
            }

            //Log("SQL start time is " + DateTime.Now.TimeOfDay);
        }

        private void btnNextMatch_Click(object sender, EventArgs e)
        {
            List<string> ScoutList = new List<string>();
            if (cbxEndMatch.Checked)
            {
                nextMatch();
                for (int i = 0; i <= 5; i++)
                {
                    //using (var db = new SeasonContext())
                    //{
                    //    var teamNumber = Robots[i].TeamName;
                    //    var result = db.Teamset.FirstOrDefault(b => b.team_key == teamNumber);

                    //    var activityresult = db.ActivitySet.FirstOrDefault(a => a.Team == teamNumber && a.Match == currentmatch + 1 && a.RecordType == "EndMatch");
                    //    if (activityresult != null)
                    //    {
                    //        prevmatchcheck = 1;
                    //    }
                    //    else
                    //    {
                    //        prevmatchcheck = 0;
                    //    }
                    //}
                }
                cbxEndMatch.Checked = false;
                if (currentmatch == bgc.InMemoryMatchList.Count)
                {
                    MessageBox.Show("You are at the last match.");
                    currentmatch--;
                }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("All unsaved data will be lost.  Continue?", "Next Match", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes && currentmatch != bgc.InMemoryMatchList.Count)
                {
                    nextMatch();
                }
                else
                {
                    MessageBox.Show("You are at the last match.");
                    currentmatch--;
                }
            }

        }

        private void nextMatch()
        {
            currentmatch++;
            this.lblMatch.Text = (currentmatch).ToString();
        }

        private void btnpopulateForEvent_Click(object sender, EventArgs e)
        {
            if (this.comboBoxSelectRegional.Text == "Please press the Load Events Button...")
            {
                MessageBox.Show("You must load an event first.", "Not Ready to Get Matches");
            }
            else
            {
                WebClient client = new WebClient();

                eventcode = comboBoxSelectRegional.SelectedItem.ToString();

                eventcode = eventcode.TrimStart('[');
                regional = eventcode;
                int index = eventcode.IndexOf(",");
                if (index > 0) eventcode = eventcode.Substring(0, index);

                string uri = "http://www.thebluealliance.com/api/v3/event/" + DateTime.Now.Year.ToString() + eventcode + "/teams?X-TBA-Auth-Key=zhTqFG7csJoif1sNXt3aZngy0LB1X4LxMgTfXBvPscNG0P9FifZCa2uGJcUk2gKW";
            }
        }
    }
}
