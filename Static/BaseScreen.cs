using SharpDX.XInput;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoutingCodeRedo.Static
{
    internal partial class BaseScreen : Form
    {
        private System.ComponentModel.IContainer components = null;
        public BaseScreen()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // BaseScreen
            // 
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Name = "BaseScreen";
            this.ResumeLayout(false);
        }
    }
}
