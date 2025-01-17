using System;
using System.Windows.Forms;

namespace ScoutingCodeRedo.Static
{
    partial class PrintOut : Form
    {
        public PrintOut()
        {
            InitializeComponent();
            this.lblkey.Text = "";
        }

        public void UpdateLbl(string text)
        {
            lblkey.Text += text + Environment.NewLine;
        }
    }
}
