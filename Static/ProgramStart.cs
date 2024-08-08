using ScoutingCodeRedo.Dynamic;
using System;
using System.Windows.Forms;

namespace ScoutingCodeRedo.Static
{
    static class Program
    {
        ///<summary>
        ///The main entry point for the application.
        ///</summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BaseScreen baseScreen = new BaseScreen();

            ScouterBoxes scouterBoxes = new ScouterBoxes
            {
                Owner = baseScreen,
                TopMost = true
            };
            scouterBoxes.Location = baseScreen.Location;
            scouterBoxes.Show();

            Application.Run(baseScreen);
        }
    }
}