using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.IO;
using System.Net;

namespace ScoutingCodeRedo.Static
{
    public partial class MainScreen
    {
        //Name: BuildInitialDatabase()
        //Purpose: This method builds the required, initial, tables of the database including an initial Season record (not currently used) and 
        //     then all of the events globally.
        private void BuildInitialDatabase()
        {

            /* The database model for this application will be (with the key being the team number):

                Teams Table             Match Table
                    |                        |
                    |---- Activity Table ----|
            */

            seasonframework.Database.CreateIfNotExists();
            DatabaseExists(seasonframework.Database.Exists());

            Log("Cleaning databases...");
            //seasonframework.Database.Initialize(true);
            seasonframework.Database.ExecuteSqlCommand("DELETE FROM [EventSummaries]");  // If you crash here, the database structure has been changed, delete DB and retry
            seasonframework.Database.ExecuteSqlCommand("DELETE FROM [Matches]");
            //seasonframework.Database.ExecuteSqlCommand("DELETE FROM [TeamSummaries]");    // DO NOT DELETE DURING EVENT
            //seasonframework.Database.ExecuteSqlCommand("DELETE FROM [Activities]");       // DO NOT DELETE DURING EVENT
            seasonframework.SaveChanges();  //Save all deletes/database clears

            Log("Opening Web Connection...");

            WebClient client = new WebClient(); //Webclient for interacting with API sites

            //Next is the code to support the web requests for the JSON calls.  JSON is just the format the data comes back in from both Blue Alliance and FRC

            //First, let's get all of this season's regional events

            //Define the proper URL as required by the Blue Alliance API which is located here: http://www.thebluealliance.com/apidocs
            //string uri = "http://www.thebluealliance.com/api/v2/events/2023?X-TBA-App-Id=frc250:T250DynoScoutClient:v2020";

            //#AuthKey
            string uri = "https://www.thebluealliance.com/api/v3/events/2024?X-TBA-Auth-Key=" + Properties.Settings.Default.API_Key;
            System.Net.WebRequest req = WebRequest.Create(uri);

            HttpWebResponse response = (HttpWebResponse)req.GetResponse();      //Make the request
            Stream dataStream = response.GetResponseStream();                   //Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);                 //Create a reader so we can manipulate what's returned by the server
            string responseFromServer = reader.ReadToEnd();                     //Read the content into our reader

            //Move what was returned into a list of events that we can traverse and use as required.
            List<EventSummary> JSONevents = (List<EventSummary>)Newtonsoft.Json.JsonConvert.DeserializeObject(responseFromServer, typeof(List<EventSummary>));

            Log("Received " + JSONevents.Count + " events.");

            seasonframework.Eventset.AddRange(JSONevents);
            seasonframework.SaveChanges();

            //Create a List to store our KeyValuePairs
            List<KeyValuePair<string, string>> elist = new List<KeyValuePair<string, string>>();

            var query = from b in seasonframework.Eventset
                        orderby b.name
                        select b;

            foreach (var item in query) elist.Add(new KeyValuePair<string, string>(item.event_code, item.name));

            this.comboBoxSelectRegional.DataSource = elist;      //Update the dropdown box so the user can select the appropriate event.

            reader.Close();         //Close the reader, we're done with events.
            dataStream.Close();     //Close the data stream to the web.
            response.Close();       //Close the response.
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
