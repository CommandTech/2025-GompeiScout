using System;

namespace ScoutingCodeRedo.Dynamic
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
    }

    public class Activity : BaseEntity
    {
        //Data elements used in multiple modes (Auto, Auto and/or Showtime)
        //Record Type = Transaction

        //2024
        public string Team { get; set; }
        public int Match { get; set; }
        public DateTime Time { get; set; }
        public string RecordType { get; set; }
        public string Mode { get; set; }
        public int Leave { get; set; }
        public string AcqLoc { get; set; }
        public int AcqCenter { get; set; }
        public int AcqDis { get; set; }
        public int AcqDrp { get; set; }
        public string DelOrig { get; set; }
        public string DelDest { get; set; }
        public int DelMiss { get; set; }
        public string DriveSta { get; set; }
        public string RobotSta { get; set; }
        public string HPAmp { get; set; }
        public string StageStat { get; set; }
        public int StageAtt { get; set; }
        public string StageLoc { get; set; }
        public int Harmony { get; set; }
        public int Spotlit { get; set; }
        public double ClimbT { get; set; }
        public double OZTime { get; set; }
        public double NZTime { get; set; }
        public double AZTime { get; set; }
        public int Defense { get; set; }
        public int Avoidance { get; set; }
        public string Strategy { get; set; }
        public int Mics { get; set; }
        public string ScouterName { get; set; }
        public int ScouterError { get; set; }
        public string match_event { get; set; }

        //Examples from previous years
        //public TimeSpan Cycle { get; set; }
        //public DateTime AcquireTime { get; set; }
        //public DateTime DeliverTime { get; set; }
        //public Decimal score_contribution { get; set; }
    }

    public class UpdatePreview : BaseEntity
    {
        //2024
        public string Team { get; set; }
        public int Match { get; set; }
        public DateTime Time { get; set; }
        public string RecordType { get; set; }
        public string Mode { get; set; }
        public int Leave { get; set; }
        public string AcqLoc { get; set; }
        public int AcqCenter { get; set; }
        public int AcqDis { get; set; }
        public int AcqDrp { get; set; }
        public string DelOrig { get; set; }
        public string DelDest { get; set; }
        public int DelMiss { get; set; }
        public string DriveSta { get; set; }
        public string RobotSta { get; set; }
        public string HPAmp { get; set; }
        public string StageStat { get; set; }
        public int StageAtt { get; set; }
        public string StageLoc { get; set; }
        public int Harmony { get; set; }
        public int Spotlit { get; set; }
        public double ClimbT { get; set; }
        public double OZTime { get; set; }
        public double NZTime { get; set; }
        public double AZTime { get; set; }
        public int Defense { get; set; }
        public int Avoidance { get; set; }
        public string Strategy { get; set; }
        public int Mics { get; set; }
        public string ScouterName { get; set; }
        public int ScouterError { get; set; }
        public string match_event { get; set; }
    }
}
