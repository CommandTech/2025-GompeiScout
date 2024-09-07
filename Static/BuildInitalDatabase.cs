using Newtonsoft.Json;
using ScoutingCodeRedo.Dynamic;
using ScoutingCodeRedo.Properties;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net.Http;
using System.Windows.Forms;


namespace ScoutingCodeRedo.Static
{
    public partial class BaseScreen
    {
        //Name: BuildInitialDatabase()
        //Purpose: This method builds the required, initial, tables of the database including an initial Season record (not currently used) and 
        //     then all of the events globally.
        private async void BuildInitialDatabase()
        {
            string uri = $"https://www.thebluealliance.com/api/v3/events/{DateTime.Now.Year.ToString()}?X-TBA-Auth-Key2={Settings.Default.API_Key}";

            using (HttpClient client = new HttpClient())
            {
                // FUTURE ME: when adding the database, add the events to the database
                try
                {
                    HttpResponseMessage response = await client.GetAsync(uri);
                    response.EnsureSuccessStatusCode(); // Throw if not a success code.

                    string responseFromServer = await response.Content.ReadAsStringAsync();

                    List<EventSummary> JSONevents = JsonConvert.DeserializeObject<List<EventSummary>>(responseFromServer);

                    Log("Received " + JSONevents.Count + " events.");
                    List<KeyValuePair<string, string>> elist = new List<KeyValuePair<string, string>>();

                    foreach (var item in JSONevents)
                    {
                        elist.Add(new KeyValuePair<string, string>(item.event_code, item.name));
                    }
                    this.comboBoxSelectRegional.DataSource = elist;
                }
                catch (HttpRequestException e)
                {
                    Log("Request error: " + e.Message);
                    DialogResult manualMatches = MessageBox.Show("Do you want to load manual matches?", "Error loading Blue Alliance data.", MessageBoxButtons.YesNo);
                    if (manualMatches == DialogResult.Yes)
                    {
                        loadManualMatches();
                    }
                }
            }
        }
        public static bool DBExists;
        public void DatabaseExists(bool DatabaseExists)
        {
            if (DatabaseExists)
            {
                DBExists = true;
            }
            else
            {
                DBExists = false;
            }
        }

        public void loadManualMatches()
        {

            string csvBaseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string csvProjectBaseDirectory = Path.GetFullPath(Path.Combine(csvBaseDirectory, @"..\..\"));
            string csvPath = Path.Combine(csvProjectBaseDirectory, "Dynamic\\ManualMatchList.csv");

            Settings.Default.manualMatchList = ReadCsvFile(csvPath);
        }
        public static List<List<String>> ReadCsvFile(string filePath)
        {
            var records = new List<List<String>>();

            using (var reader = new StreamReader(filePath))
            {
                string line;
                bool isFirstLine = true;
                while ((line = reader.ReadLine()) != null)
                {
                    if (isFirstLine)
                    {
                        isFirstLine = false;
                        continue;
                    }

                    var values = line.Split(',');
                    records.Add(new List<string>(values));
                }
            }

            return records;
        }
    }
}
