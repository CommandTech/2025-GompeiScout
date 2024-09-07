﻿using ScoutingCodeRedo.Dynamic;
using ScoutingCodeRedo.Properties;
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
            Settings.Default.loadedEvent = null;
            Settings.Default.manualMatchList = null;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);

            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);

            BaseScreen baseScreen = new BaseScreen();

            ScouterBoxes scouterBoxes = new ScouterBoxes
            {
                Owner = baseScreen,
                TopMost = false
            };
            scouterBoxes.Location = baseScreen.Location;
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

                // Optionally, you can save data or perform cleanup here
                SaveDataOnCrash();
            }
        }

        // Method to save data or perform cleanup on crash
        static void SaveDataOnCrash()
        {
            try
            {
                // Your save data logic here
                string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
                string projectBaseDirectory = System.IO.Path.GetFullPath(System.IO.Path.Combine(baseDirectory, @"..\..\"));
                string iniPath = System.IO.Path.Combine(projectBaseDirectory, "config.ini");
                INIFile iniFile = new INIFile(iniPath);

                iniFile.Write("MatchData", "event", Settings.Default.loadedEvent);
                iniFile.Write("MatchData", "match_number", BaseScreen.currentmatch.ToString());
                iniFile.Write("MatchData", "redRight", Settings.Default.redRight.ToString());
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