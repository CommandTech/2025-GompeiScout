using ScoutingCodeRedo.Dynamic;
using ScoutingCodeRedo.Properties;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace ScoutingCodeRedo.Static
{
    static class Program
    {
        ///The main entry point for the application.
        [STAThread]
        static void Main()
        {
            //Defaults some settings
            Settings.Default.loadedEvent = null;
            Settings.Default.manualMatchList = null;
            Settings.Default.DBExists = false;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Handles code crashes, used for saving data when the code crashes during events
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);

            //Determines what functions to run when different exceptions are thrown
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);

            //Creates the base screen
            BaseScreen baseScreen = new BaseScreen();

            //Creates the scouter boxes overlaying the base screen
            ScouterBoxes scouterBoxes = new ScouterBoxes
            {
                Owner = baseScreen,
                TopMost = false,
                Location = baseScreen.Location
            };
            scouterBoxes.Show();

            Application.Run(baseScreen);
        }

        // Handle UI thread exceptions
        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            HandleException(e.Exception);
        }

        // Handle non-UI thread exceptions
        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            HandleException(e.ExceptionObject as Exception);
        }

        // Common exception handling method
        static void HandleException(Exception ex)
        {
            if (ex != null)
            {
                // Log the exception, show a message, or perform other actions
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                SaveDataOnCrash();
            }
        }

        // Method to save data or perform cleanup on crash
        static void SaveDataOnCrash()
        {
            try
            {
                //Setting the variables of the config file
                string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
                string projectBaseDirectory = System.IO.Path.GetFullPath(System.IO.Path.Combine(baseDirectory, @"..\..\"));
                string iniPath = System.IO.Path.Combine(projectBaseDirectory, "config.ini");
                INIFile iniFile = new INIFile(iniPath);

                //Determines if the loaded event is a manual event or a real event
                //Then saves the data to the config file
                if (Settings.Default.loadedEvent == null)
                {
                    iniFile.Write("MatchData", "event", "manualEvent");
                }
                else
                {
                    iniFile.Write("MatchData", "event", Settings.Default.loadedEvent);
                }
                iniFile.Write("MatchData", "match_number", Settings.Default.currentMatch.ToString());
                iniFile.Write("MatchData", "redRight", Settings.Default.redRight.ToString());
                iniFile.Write("MatchData", "teamPrio", string.Join(",", Settings.Default.teamPrio));
                //Gets the current scouter names and locations to save
                string scouterNames = "";
                string scouterLocations = "";
                foreach (var robot in BackgroundCode.Robots)
                {
                    if (scouterNames.Length != 0)
                    {
                        scouterNames += ",";
                    }
                    scouterNames += robot._ScouterName;

                    if (scouterLocations.Length != 0)
                    {
                        scouterLocations += ",";
                    }
                    scouterLocations += robot.ScouterBox;
                }
                iniFile.Write("MatchData", "scouterNames", scouterNames);
                iniFile.Write("MatchData", "scouterLocations", scouterLocations);
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during the save process
                MessageBox.Show("Error saving data on crash: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Environment.Exit(0);
        }
    }
}