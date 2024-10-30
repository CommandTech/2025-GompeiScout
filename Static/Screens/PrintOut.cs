using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
