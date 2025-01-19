using ScoutingCodeRedo.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ScoutingCodeRedo.Dynamic
{
    public partial class UpdateDatabase : Form
    {
        //Fix issue with manual matches and updating database.
        public UpdateDatabase(List<string> teamlist, List<int> MatchNumbers)
        {
            InitializeComponent();
            this.comboTeamNumber.DataSource = teamlist;
            this.comboMatchNumber.DataSource = MatchNumbers;
        }

        private void BtnCreateTable_Click(object sender, EventArgs e)
        {
            if (checkEndAuto.Checked || checkActivities.Checked || checkEndMatch.Checked || checkMatchEvent.Checked || checkDefense.Checked)
            {
                using (var db = new SeasonContext())
                {
                    string cbEA = "";
                    string cbA = "";
                    string cbD = "";
                    string cbEM = "";
                    string cbME = "";
                    string first = "";

                    if (checkEndAuto.Checked)
                    {
                        cbEA = first + "'EndAuto'";
                        first = ",";
                    }
                    if (checkActivities.Checked)
                    {
                        cbA = first + "'Activities'";
                        first = ",";
                    }
                    if (checkEndMatch.Checked)
                    {
                        cbEM = first + "'EndMatch'";
                        first = ",";
                    }
                    if (checkMatchEvent.Checked)
                    {
                        cbME = first + "'Match_Event'";
                    }
                    if (checkDefense.Checked)
                    {
                        cbD = first + "'Defense'";
                    }

                    string teamNumber = this.comboTeamNumber.Text;
                    string matchNumber = this.comboMatchNumber.Text;
                    bool isNumeric = int.TryParse(comboMatchNumber.Text, out _);
                    if (isNumeric)
                    {
                        string Query = "Select * INTO UpdatePreviews FROM Activities WHERE Team = 'frc" + teamNumber + "' AND Match = '" + matchNumber + "' AND RecordType IN (" + cbEA + cbA + cbEM + cbME + cbD + ")";
                        SeasonContext seasonframework = new SeasonContext();
                        seasonframework.Database.ExecuteSqlCommand("IF OBJECT_ID ('UpdatePreviews') IS NOT NULL DROP TABLE UpdatePreviews");
                        seasonframework.Database.ExecuteSqlCommand(Query);
                        this.updatePreviewsTableAdapter.Fill(this.scoutingDBDataSet.UpdatePreviews);
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid Team Number");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select at least one record type");
            }
        }

        private void BtnFetchValues_Click(object sender, EventArgs e)
        {
            using (var db = new SeasonContext())
            {
                bool isNumeric = int.TryParse(txtID.Text, out _);
                if (isNumeric)
                {
                    var IDNumber = int.Parse(txtID.Text);
                    var result = db.UpdatePreviewSet.FirstOrDefault(b => b.Id == IDNumber);
                    if (result != null)
                    {
                        comboAlgaeAcqSide.Text = result.AcqAlgae_Near_Far.ToString();
                        comboCoralAcqSide.Text = result.AcqCoral_Near_Far.ToString();

                        comboCoralDelSide.Text = result.Del_Near_Far.ToString();
                        comboAlgaeDelSide.Text = result.Del_Near_Far.ToString();

                        txtDelCoralF.Text = result.DelCoralF.ToString();
                        txtDelCoralL1.Text = result.DelCoralL1.ToString();
                        txtDelCoralL2.Text = result.DelCoralL2.ToString();
                        txtDelCoralL3.Text = result.DelCoralL3.ToString();
                        txtDelCoralL4.Text = result.DelCoralL4.ToString();

                        txtDelAlgaeF.Text = result.DelAlgaeF.ToString();
                        txtDelAlgaeP.Text = result.DelAlgaeP.ToString();
                        txtDelAlgaeN.Text = result.DelAlgaeN.ToString();

                        comboStrategy.Text = result.Strategy.ToString();
                        comboEndState.Text = result.EndState.ToString();
                        comboClimbAttempt.Text = result.CageAttept.ToString();                        
                        txtClimbTime.Text = result.ClimbT.ToString();

                        comboMode.Text = result.Mode.ToString();
                        comboStart.Text = result.Starting_Loc.ToString();
                        comboLeave.Text = result.Leave.ToString();
                        comboMatchEvent.Text = result.Match_event.ToString();
                        comboSelectedCage.Text = result.SelectedCage.ToString();

                        txtDefenseTime.Text = result.DZTime.ToString();
                        txtDefense.Text = result.Defense.ToString();
                        txtEffectiveness.Text = result.DefenseValue.ToString();
                        txtAvoidance.Text = result.Avoidance.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid ID");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a number for the ID");
                }
            }
        }

        private void BtnUpdateDatabase_Click(object sender, EventArgs e)
        {
            using (var db = new SeasonContext())
            {
                SeasonContext seasonframework = new SeasonContext();
                bool isNumeric = int.TryParse(txtID.Text, out _);
                if (isNumeric)
                {
                    int L1ChangeAmount = 0;
                    int L2ChangeAmount = 0;
                    int L3ChangeAmount = 0;
                    int L4ChangeAmount = 0;
                    int CFChangeAmount = 0;

                    int PChangeAmount = 0;
                    int NChangeAmount = 0;
                    int AFChangeAmount = 0;

                    var IDNumber = int.Parse(txtID.Text);
                    var result = db.UpdatePreviewSet.FirstOrDefault(b => b.Id == IDNumber);
                    if (result != null)
                    {
                        string query = "UPDATE Activities SET Defense = '" + txtDefense.Text + "' WHERE Id = '" + result.Id + "';";
                        seasonframework.Database.ExecuteSqlCommand(query);

                        query = "UPDATE Activities SET DefenseValue = '" + txtEffectiveness.Text + "' WHERE Id = '" + result.Id + "';";
                        seasonframework.Database.ExecuteSqlCommand(query);

                        query = "UPDATE Activities SET Avoidance = '" + txtAvoidance.Text + "' WHERE Id = '" + result.Id + "';";
                        seasonframework.Database.ExecuteSqlCommand(query);

                        query = "UPDATE Activities SET Match_event = '" + comboMatchEvent.Text + "' WHERE Id = '" + result.Id + "';";
                        seasonframework.Database.ExecuteSqlCommand(query);

                        query = "UPDATE Activities SET Strategy = '" + comboStrategy.Text + "' WHERE Id = '" + result.Id + "';";
                        seasonframework.Database.ExecuteSqlCommand(query);

                        query = "UPDATE Activities SET DZTime = '" + txtDefenseTime.Text + "' WHERE Id = '" + result.Id + "';";
                        seasonframework.Database.ExecuteSqlCommand(query);

                        if (comboAlgaeDelSide.Text != "-")
                        {
                            query = "UPDATE Activities SET Del_Near_Far = '" + comboAlgaeDelSide.Text + "' WHERE Id = '" + result.Id + "';";
                            seasonframework.Database.ExecuteSqlCommand(query);
                        }
                        else
                        {
                            query = "UPDATE Activities SET Del_Near_Far = '" + comboCoralDelSide.Text + "' WHERE Id = '" + result.Id + "';";
                            seasonframework.Database.ExecuteSqlCommand(query);
                        }

                        query = "UPDATE Activities SET AcqAlgae_Near_Far = '" + comboAlgaeAcqSide.Text + "' WHERE Id = '" + result.Id + "';";
                        seasonframework.Database.ExecuteSqlCommand(query);

                        query = "UPDATE Activities SET AcqCoral_Near_Far = '" + comboCoralAcqSide.Text + "' WHERE Id = '" + result.Id + "';";
                        seasonframework.Database.ExecuteSqlCommand(query);

                        query = "UPDATE Activities SET Starting_Loc = '" + comboStart.Text + "' WHERE Id = '" + result.Id + "';";
                        seasonframework.Database.ExecuteSqlCommand(query);

                        query = "UPDATE Activities SET Leave = '" + comboLeave.Text + "' WHERE Id = '" + result.Id + "';";
                        seasonframework.Database.ExecuteSqlCommand(query);

                        //query = "UPDATE Activities SET AcqCoralS = '" + comboCoralAcqLoc.Text + "' WHERE Id = '" + result.Id + "';";
                        //seasonframework.Database.ExecuteSqlCommand(query);

                        //query = "UPDATE Activities SET AcqCoralF = '" + comboCoralAcqLoc.Text + "' WHERE Id = '" + result.Id + "';";
                        //seasonframework.Database.ExecuteSqlCommand(query);

                        //query = "UPDATE Activities SET AcqAlgaeR = '" + comboAlgaeAcqLoc.Text + "' WHERE Id = '" + result.Id + "';";
                        //seasonframework.Database.ExecuteSqlCommand(query);

                        //query = "UPDATE Activities SET AcqAlgaeF = '" + comboAlgaeAcqLoc.Text + "' WHERE Id = '" + result.Id + "';";
                        //seasonframework.Database.ExecuteSqlCommand(query);

                        int delCoral;
                        if (int.TryParse(txtDelCoralL1.Text, out delCoral))
                        {
                            L1ChangeAmount = delCoral - result.DelCoralL1;
                        }
                        query = "UPDATE Activities SET DelCoralL1 = '" + txtDelCoralL1.Text + "' WHERE Id = '" + result.Id + "';";
                        seasonframework.Database.ExecuteSqlCommand(query);

                        if (int.TryParse(txtDelCoralL2.Text, out delCoral))
                        {
                            L2ChangeAmount = delCoral - result.DelCoralL2;
                        }
                        query = "UPDATE Activities SET DelCoralL2 = '" + txtDelCoralL2.Text + "' WHERE Id = '" + result.Id + "';";
                        seasonframework.Database.ExecuteSqlCommand(query);

                        if (int.TryParse(txtDelCoralL3.Text, out delCoral))
                        {
                            L3ChangeAmount = delCoral - result.DelCoralL3;
                        }
                        query = "UPDATE Activities SET DelCoralL3 = '" + txtDelCoralL3.Text + "' WHERE Id = '" + result.Id + "';";
                        seasonframework.Database.ExecuteSqlCommand(query);

                        if (int.TryParse(txtDelCoralL4.Text, out delCoral))
                        {
                            L4ChangeAmount = delCoral - result.DelCoralL4;
                        }
                        query = "UPDATE Activities SET DelCoralL4 = '" + txtDelCoralL4.Text + "' WHERE Id = '" + result.Id + "';";
                        seasonframework.Database.ExecuteSqlCommand(query);

                        if (int.TryParse(txtDelCoralF.Text, out delCoral))
                        {
                            CFChangeAmount = delCoral - result.DelCoralF;
                        }
                        query = "UPDATE Activities SET DelCoralF = '" + txtDelCoralF.Text + "' WHERE Id = '" + result.Id + "';";
                        seasonframework.Database.ExecuteSqlCommand(query);

                        int delAlgae;
                        if (int.TryParse(txtDelAlgaeP.Text, out delAlgae))
                        {
                            PChangeAmount = delAlgae - result.DelAlgaeP;
                        }
                        query = "UPDATE Activities SET DelAlgaeP = '" + txtDelAlgaeP.Text + "' WHERE Id = '" + result.Id + "';";
                        seasonframework.Database.ExecuteSqlCommand(query);

                        if (int.TryParse(txtDelAlgaeN.Text, out delAlgae))
                        {
                            NChangeAmount = delAlgae - result.DelAlgaeN;
                        }
                        query = "UPDATE Activities SET DelAlgaeN = '" + txtDelAlgaeN.Text + "' WHERE Id = '" + result.Id + "';";
                        seasonframework.Database.ExecuteSqlCommand(query);

                        if (int.TryParse(txtDelAlgaeF.Text, out delAlgae))
                        {
                            AFChangeAmount = delAlgae - result.DelAlgaeF;
                        }
                        query = "UPDATE Activities SET DelAlgaeF = '" + txtDelAlgaeF.Text + "' WHERE Id = '" + result.Id + "';";
                        seasonframework.Database.ExecuteSqlCommand(query);


                        query = "UPDATE Activities SET ClimbT = '" + txtClimbTime.Text + "' WHERE Id = '" + result.Id + "';";
                        seasonframework.Database.ExecuteSqlCommand(query);

                        query = "UPDATE Activities SET EndState = '" + comboEndState.Text + "' WHERE Id = '" + result.Id + "';";
                        seasonframework.Database.ExecuteSqlCommand(query);

                        query = "UPDATE Activities SET CageAttept = '" + comboClimbAttempt.Text + "' WHERE Id = '" + result.Id + "';";
                        seasonframework.Database.ExecuteSqlCommand(query);

                        query = "UPDATE Activities SET SelectedCage = '" + comboSelectedCage.Text + "' WHERE Id = '" + result.Id + "';";
                        seasonframework.Database.ExecuteSqlCommand(query);
                    }
                    //Loop through the rest of the selected match and team until it hits the endMatch and changes all the acquires and delivers to match the changed record
                    var result2 = db.ActivitySet.Where(b => b.Team == result.Team && b.Match == result.Match && b.Id > IDNumber && b.RecordType != "Match_Event").ToList();
                    foreach (var line in result2)
                    {
                        line.DelCoralL1 += L1ChangeAmount;
                        string query = "UPDATE Activities SET DelCoralL1 = '" + line.DelCoralL1 + "' WHERE Id = '" + line.Id + "';";
                        seasonframework.Database.ExecuteSqlCommand(query);

                        line.DelCoralL2 += L2ChangeAmount;
                        query = "UPDATE Activities SET DelCoralL2 = '" + line.DelCoralL2 + "' WHERE Id = '" + line.Id + "';";
                        seasonframework.Database.ExecuteSqlCommand(query);

                        line.DelCoralL3 += L3ChangeAmount;
                        query = "UPDATE Activities SET DelCoralL3 = '" + line.DelCoralL3 + "' WHERE Id = '" + line.Id + "';";
                        seasonframework.Database.ExecuteSqlCommand(query);

                        line.DelCoralL4 += L4ChangeAmount;
                        query = "UPDATE Activities SET DelCoralL4 = '" + line.DelCoralL4 + "' WHERE Id = '" + line.Id + "';";
                        seasonframework.Database.ExecuteSqlCommand(query);

                        line.DelCoralF += CFChangeAmount;
                        query = "UPDATE Activities SET DelCoralF = '" + line.DelCoralF + "' WHERE Id = '" + line.Id + "';";
                        seasonframework.Database.ExecuteSqlCommand(query);

                        line.DelAlgaeP += PChangeAmount;
                        query = "UPDATE Activities SET DelAlgaeP = '" + line.DelAlgaeP + "' WHERE Id = '" + line.Id + "';";
                        seasonframework.Database.ExecuteSqlCommand(query);

                        line.DelAlgaeN += NChangeAmount;
                        query = "UPDATE Activities SET DelAlgaeN = '" + line.DelAlgaeN + "' WHERE Id = '" + line.Id + "';";
                        seasonframework.Database.ExecuteSqlCommand(query);

                        line.DelAlgaeF += AFChangeAmount;
                        query = "UPDATE Activities SET DelAlgaeF = '" + line.DelAlgaeF + "' WHERE Id = '" + line.Id + "';";
                        seasonframework.Database.ExecuteSqlCommand(query);
                    }

                    MessageBox.Show("Database Updated");
                }
                else
                {
                    MessageBox.Show("Please enter a number for the ID");
                }
            }
        }
    }
}
