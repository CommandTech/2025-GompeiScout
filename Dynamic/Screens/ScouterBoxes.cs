using ScoutingCodeRedo.Properties;
using ScoutingCodeRedo.Static;
using System;
using System.Windows.Forms;

namespace ScoutingCodeRedo.Dynamic
{
    internal partial class ScouterBoxes : Form
    {
        public ScouterBoxes()
        {
            InitializeComponent();

            updateScreen.Enabled = true;
        }

        private void UpdateScreen(object sender, EventArgs e)
        {
            for (int i = 0; i < 6; i++)
            {
                int o = BackgroundCode.Robots[i].ScouterBox;
                switch (BackgroundCode.Robots[BackgroundCode.Robots[i].ScouterBox].Current_Mode)
                {
                    case RobotState.ROBOT_MODE.Auto:
                        InAutoMode(i, o);
                        break;
                    case RobotState.ROBOT_MODE.Teleop:
                        InTeleopMode(i, o);
                        break;
                    case RobotState.ROBOT_MODE.Surfacing:
                        InSurfacingMode(i, o);
                        break;
                }
            }
        }

        private void InAutoMode(int Box_Number, int ScouterBox)
        {
            // Acquire
            //((Label)this.Controls.Find($"lbl{ScouterBox}Position0", true)[0]).Text = "Acq:";
            //((Label)this.Controls.Find($"lbl{ScouterBox}Position0", true)[0]).Visible = (ScouterBox == 0) || !Settings.Default.practiceMode;

            //if (BackgroundCode.Robots[Box_Number].Acq_Loc == RobotState.CURRENT_LOC.Select.ToString() && BackgroundCode.Robots[Box_Number].Acq_Center == 0)
            //{
            //    ((Label)this.Controls.Find($"lbl{ScouterBox}Position0Value", true)[0]).Visible = false;
            //}
            //else
            //{
            //    ((Label)this.Controls.Find($"lbl{ScouterBox}Position0Value", true)[0]).Visible = (ScouterBox == 0) || !Settings.Default.practiceMode;
            //}

        }
        private void InTeleopMode(int Box_Number, int ScouterBox)
        {
            
        }
        private void InSurfacingMode(int Box_Number, int ScouterBox)
        {
            //BackgroundCode.Robots[Box_Number].ClimbTDouble = BackgroundCode.Robots[Box_Number].ClimbT_StopWatch.Elapsed.TotalSeconds;
            //((Label)this.Controls.Find($"lbl{ScouterBox}Position2Value", true)[0]).Text = BackgroundCode.Robots[Box_Number].ClimbTDouble.ToString("0.#");
            //((Label)this.Controls.Find($"lbl{ScouterBox}Position4Value", true)[0]).BackColor = System.Drawing.Color.Black;
            //((Label)this.Controls.Find($"lbl{ScouterBox}Position4Value", true)[0]).ForeColor = System.Drawing.Color.Yellow;
        }
    }
}
