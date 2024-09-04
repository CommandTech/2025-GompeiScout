using ScoutingCodeRedo.Static;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoutingCodeRedo.Dynamic
{
    internal partial class ScouterBoxes : Form
    {
       public ScouterBoxes() {
            InitializeComponent();

            updateScreen.Enabled = true;
        }

        private void UpdateScreen(object sender, EventArgs e)
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j <= 10; j++)
                {
                    try
                    {
                        string labelName = $"lbl{i}Position{j}";
                        Label label = this.Controls.Find(labelName, true).FirstOrDefault() as Label;
                        if (label != null)
                        {
                            label.Text = "0";
                        }
                    }
                    catch (Exception)
                    { }

                    try
                    {
                        string labelValueName = $"lbl{i}Position{j}Value";
                        Label labelValue = this.Controls.Find(labelValueName, true).FirstOrDefault() as Label;
                        if (labelValue != null)
                        {
                            if (labelValue.BackColor == Color.Black)
                            {
                                labelValue.Text = "0";
                            }
                            else
                            {
                                labelValue.ForeColor = Color.LimeGreen;
                                labelValue.BackColor = Color.LimeGreen;
                            }
                        }
                    }
                    catch (Exception)
                    { }

                    try
                    {
                        string labelFlagName = $"lbl{i}Position{j}Flag";
                        Label labelFlag = this.Controls.Find(labelFlagName, true).FirstOrDefault() as Label;
                        if (labelFlag != null)
                        {
                            labelFlag.Text = "0";
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
        }
    }
}
