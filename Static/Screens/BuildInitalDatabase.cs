using Newtonsoft.Json;
using ScoutingCodeRedo.Dynamic;
using ScoutingCodeRedo.Properties;
using System;
using System.Collections.Generic;
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
        private async void BuildInitialDatabase(bool isManual)
        {
            BackgroundCode.seasonframework.Database.CreateIfNotExists();
            BackgroundCode.seasonframework.Database.Connection.Open();

            Log("Cleaning databases...");
            //seasonframework.Database.Initialize(true);
            BackgroundCode.seasonframework.Database.ExecuteSqlCommand("DELETE FROM [EventSummaries]");  // If you crash here, the database structure has been changed, delete DB and retry
            BackgroundCode.seasonframework.Database.ExecuteSqlCommand("DELETE FROM [Matches]");
            //BackgroundCode.seasonframework.Database.ExecuteSqlCommand("DELETE FROM [TeamSummaries]");    // DO NOT DELETE DURING EVENT
            //BackgroundCode.seasonframework.Database.ExecuteSqlCommand("DELETE FROM [Activities]");       // DO NOT DELETE DURING EVENT
            BackgroundCode.seasonframework.SaveChanges();  //Save all deletes/database clears

            if (isManual)
            {
                LoadManualMatches();
            }
            else
            {
                string uri = $"https://www.thebluealliance.com/api/v3/events/{DateTime.Now.Year-1}?X-TBA-Auth-Key={Settings.Default.API_Key}";

                using (HttpClient client = new HttpClient())
                {
                    try
                    {
                        HttpResponseMessage response = await client.GetAsync(uri);
                        response.EnsureSuccessStatusCode(); // Throw if not a success code.

                        string responseFromServer = await response.Content.ReadAsStringAsync();

                        List<EventSummary> JSONevents = JsonConvert.DeserializeObject<List<EventSummary>>(responseFromServer);

                        Log("Received " + JSONevents.Count + " events.");
                        List<KeyValuePair<string, string>> elist = new List<KeyValuePair<string, string>>();

                        BackgroundCode.seasonframework.Eventset.AddRange(JSONevents);
                        BackgroundCode.seasonframework.SaveChanges();

                        foreach (var item in JSONevents)
                        {
                            elist.Add(new KeyValuePair<string, string>(item.Event_code, item.Name));
                        }
                        this.comboBoxSelectRegional.DataSource = elist;
                    }
                    catch (HttpRequestException e)
                    {
                        Log("Request error: " + e.Message);
                        DialogResult manualMatches = MessageBox.Show("Do you want to load manual matches?", "Error loading Blue Alliance data.", MessageBoxButtons.YesNo);
                        if (manualMatches == DialogResult.Yes)
                        {
                            Log("Loading manual matches.");
                            LoadManualMatches();
                            comboBoxSelectRegional.Items.Add("manualEvent");
                            comboBoxSelectRegional.SelectedItem = "manualEvent";
                        }
                    }
                }
            }
        }

        public void LoadManualMatches()
        {

            string csvBaseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string csvProjectBaseDirectory = Path.GetFullPath(Path.Combine(csvBaseDirectory, @"..\..\"));
            string csvPath = Path.Combine(csvProjectBaseDirectory, "Dynamic\\ManualMatchList.csv");

            Settings.Default.manualMatchList = ReadCsvFile(csvPath);

            Log($"{Settings.Default.manualMatchList.Count} matches");
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
