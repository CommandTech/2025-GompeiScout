using System.Collections.Generic;
using System.Data.Entity;
using System;

namespace ScoutingCodeRedo.Static
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
    }

    /* For possible future use
    public partial class Season : BaseEntity
    {
        public String  frcChampionship  { get; set; }
        public String  eventCount  { get; set; }
        public String  gameName  { get; set; }
        public String  kickoff  { get; set; }
        public String  rookieStart  { get; set; }
        public String  teamCount  { get; set; }
        public ICollection<Team> Teams { get; set; }  
    }
    */

    internal class SeasonContext : DbContext
    {
        public SeasonContext()
            : base("2024seasondb")
        { }

        public DbSet<EventSummary> Eventset { get; set; }
        public DbSet<TeamSummary> Teamset { get; set; }
        public DbSet<Match> Matchset { get; set; }
        public DbSet<Dynamic.Activity> ActivitySet { get; set; }
        public DbSet<Dynamic.UpdatePreview> UpdatePreviewSet { get; set; }
    }

    public class EventSummary : BaseEntity
    {
        public string key { get; set; }
        public string website { get; set; }
        public bool official { get; set; }
        public string end_date { get; set; }
        public string name { get; set; }
        public string short_name { get; set; }
        public string facebook_eid { get; set; }
        public string event_district_string { get; set; }
        public string venue_address { get; set; }
        public int event_district { get; set; }
        public String week { get; set; }
        public string location { get; set; }
        public string event_code { get; set; }
        public int year { get; set; }
        public List<object> webcast { get; set; }
        public string timezone { get; set; }
        public List<object> alliances { get; set; }
        public string event_type_string { get; set; }
        public string start_date { get; set; }
        public int event_type { get; set; }
    }

    public class TeamSummary : BaseEntity
    {
        /* UNUSED DATA AVAILABLE FROM TBA
        public string address { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public string gmaps_place_id { get; set; }
        public string gmaps_url { get; set; }
        public string lat { get; set; }
        public string lng { get; set; }
        public string location_name { get; set; }
        public string motto { get; set; }
        public string name { get; set; }
        public string nickname { get; set; }
        public string postal_code { get; set; }
        public string rookie_year { get; set; }
        public string school_name { get; set; }
        public string state_prov { get; set; }
        public string website { get; set; }         
        */
        public string event_key { get; set; }
        public string team_key { get; set; }
        public string team_number { get; set; }
        public string nickname { get; set; }
    }

    public class Match : BaseEntity
    {
        public string comp_level { get; set; }
        public int match_number { get; set; }
        public List<object> videos { get; set; }
        public object time_string { get; set; }
        public int set_number { get; set; }
        public string key { get; set; }
        public string time { get; set; }
        public string blueteam1 { get; set; }
        public string blueteam2 { get; set; }
        public string blueteam3 { get; set; }
        public string redteam1 { get; set; }
        public string redteam2 { get; set; }
        public string redteam3 { get; set; }
        public string event_key { get; set; }
        public int pointscorered { get; set; }
        public int redfouls { get; set; }
        public int pointscoreblue { get; set; }
        public int bluefouls { get; set; }
        public int blueauto { get; set; }
        public int redauto { get; set; }
        public int bluecharge { get; set; }
        public int redcharge { get; set; }
        public int bluetotaldel { get; set; }
        public int redtotaldel { get; set; }
    }
}
