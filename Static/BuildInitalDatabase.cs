using Newtonsoft.Json;
using ScoutingCodeRedo.Dynamic;
using ScoutingCodeRedo.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;


namespace ScoutingCodeRedo.Static
{
    public partial class BaseScreen
    {
        //Name: BuildInitialDatabase()
        //Purpose: This method builds the required, initial, tables of the database including an initial Season record (not currently used) and 
        //     then all of the events globally.
        private async void BuildInitialDatabase()
        {
            string uri = $"https://www.thebluealliance.com/api/v3/events/{DateTime.Now.Year.ToString()}?X-TBA-Auth-Key={Settings.Default.API_Key}";

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
    }
}
