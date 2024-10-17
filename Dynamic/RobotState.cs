using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoutingCodeRedo.Dynamic
{
    public class RobotState
    {
        public enum ROBOT_MODE { Auto, Teleop, Showtime };
        public enum CYCLE_DIRECTION { Up, Down }
        public enum MATCHEVENT_NAME { Match_Event, Fumbled, BrokeDown, CrossedCenter, LostParts, RingToss, AdditionalNote, MultiClimb, NoShow, StageInt, TippedOver, JammedPiece }
        public enum SCOUTER_NAME { Select_Name, Ayush, Logan, Marzuq, Milan, William, Scouter1, Scouter2, Scouter3, Scouter4 }

        // Year to Year ints
        public int ScouterError;
        public int prevScouterError;
        public int ScouterBox;

        // Year to Year doubles
        public static double Red_Score;
        public static double Blue_Score;

        // Year to Year strings
        public string color;

        // Year to Year bools
        public bool RTHUP_Lock;
        public bool TransactionCheck = false;
        public bool AUTO = true;
        public bool NoSho = false;

        // 2024 enums
        public enum DEL_DEST { Select, Spkr, Amp, Trap, AllyW, Neut }
        public enum ROBOT_SET { Select, Amp, SubW, Podm, OppS }
        public enum HP_AMP { Select, Y, N }
        public enum STAGE_STAT { Select, Onstage, Park, Elsewhere }
        public enum STAGE_ATT { Select, Y, N }
        public enum STAGE_LOC { Select, L, C, R }
        public enum LIT { Select, Y, N, }
        public enum APP_STRAT { Select, None, Defense, Mover, Shooter, Hybrid, Celebrity }
        public enum CURRENT_LOC { Select, Left, Right, Neutral, SubW, Source }

        //2024 PUBLIC INT
        public int Leave;
        public int Acq_Center;
        public int Flag;
        public int Harm = 10;
        public int Def_Rat = 10;
        public int Avo_Rat = 10;
        public int Mic = 10;
        public int Coop;
        public string Acq_Loc = CURRENT_LOC.Select.ToString();
        public string Acq_Loc_Temp = "Pre";
        public int Acq_Center_Temp;


        public DateTime Auto_Time;
        public DateTime CenteNoteTimeTemp;


        // 2024 timers
        public TimeSpan OpptT = TimeSpan.Zero;
        public Stopwatch OpptT_StopWatch;
        public bool OpptT_StopWatch_running;
        public double OpptTDouble;

        public TimeSpan ClimbT = TimeSpan.Zero;
        public Stopwatch ClimbT_StopWatch;
        public bool ClimbT_StopWatch_running;
        public double ClimbTDouble;

        public TimeSpan NeutT = TimeSpan.Zero;
        public Stopwatch NeutT_StopWatch;
        public bool NeutT_StopWatch_running;
        public double NeutTDouble;

        public TimeSpan AllyT = TimeSpan.Zero;
        public Stopwatch AllyT_StopWatch;
        public bool AllyT_StopWatch_running;
        public double AllyTDouble;

        // These are the standard types...

        public ROBOT_MODE Desired_Mode;         //Desired Mode

        //LOCAL VARIABLES SECTION.  All underscored variables indicate local variables for one controller/scouter

        public SCOUTER_NAME _ScouterName;          //ScouterName
        private string _TeamName;                   //TeamName
        private MATCHEVENT_NAME _match_event;       //Match Event
        private ROBOT_MODE _RobotMode;              //Control

        // 2024 local variables
        private DEL_DEST _Del_Dest;
        private ROBOT_SET _Robot_Set;
        private HP_AMP _HP_Amp;
        private STAGE_STAT _Stage_Stat;
        private STAGE_ATT _Stage_Att;
        private STAGE_LOC _Stage_Loc;
        private LIT _Lit;
        private APP_STRAT _App_Strat;
        private CURRENT_LOC _Current_Loc;
        private string _Drive_Sta;

        public ROBOT_MODE Current_Mode
        {
            get { return _RobotMode; }
            set { _RobotMode = value; }
        }

        public String TeamName
        {
            get { return _TeamName; }
            set { _TeamName = value; }
        }
        public MATCHEVENT_NAME match_event
        {
            get { return _match_event; }
            set { _match_event = value; }
        }

        public DEL_DEST Del_Dest
        {
            get { return _Del_Dest; }
            set { _Del_Dest = value; }
        }

        public ROBOT_SET Robot_Set
        {
            get { return _Robot_Set; }
            set { _Robot_Set = value; }
        }
        public HP_AMP HP_Amp
        {
            get { return _HP_Amp; }
            set { _HP_Amp = value; }
        }
        public STAGE_STAT Stage_Stat
        {
            get { return _Stage_Stat; }
            set { _Stage_Stat = value; }
        }
        public STAGE_ATT Stage_Att
        {
            get { return _Stage_Att; }
            set { _Stage_Att = value; }
        }
        public STAGE_LOC Stage_Loc
        {
            get { return _Stage_Loc; }
            set { _Stage_Loc = value; }
        }
        public LIT Lit
        {
            get { return _Lit; }
            set { _Lit = value; }
        }
        public APP_STRAT App_Strat
        {
            get { return _App_Strat; }
            set { _App_Strat = value; }
        }
        public CURRENT_LOC Current_Loc
        {
            get { return _Current_Loc; }
            set { _Current_Loc = value; }
        }
        public String Drive_Sta
        {
            get { return _Drive_Sta; }
            set { _Drive_Sta = value; }
        }

        public static object ACQ_LOC { get; internal set; }


        ///Scouter Name
        public SCOUTER_NAME getScouterName(SCOUTER_NAME ScouterName)
        { return ScouterName = _ScouterName; }

        ///<summary>
        ///Resets all values to the default
        ///</summary>
        ///

        //Scouter Name
        public void changeScouterName(CYCLE_DIRECTION CycleDirection)
        {
            if (CycleDirection == CYCLE_DIRECTION.Up)
                _ScouterName = (SCOUTER_NAME)GetNextEnum<SCOUTER_NAME>(_ScouterName);
            else
            {
                _ScouterName = (SCOUTER_NAME)GetPreviousEnum<SCOUTER_NAME>(_ScouterName);
            }
        }

        //2024 cycles
        public void changeDel_Dest(CYCLE_DIRECTION CycleDirection)
        {
            if (CycleDirection == CYCLE_DIRECTION.Up)
                _Del_Dest = (DEL_DEST)GetNextEnum<DEL_DEST>(_Del_Dest);
            else
            {
                _Del_Dest = (DEL_DEST)GetPreviousEnum<DEL_DEST>(_Del_Dest);
            }
        }

        public void changeRobot_Set(CYCLE_DIRECTION CycleDirection)
        {
            if (CycleDirection == CYCLE_DIRECTION.Up)
                _Robot_Set = (ROBOT_SET)GetNextEnum<ROBOT_SET>(_Robot_Set);
            else
            {
                _Robot_Set = (ROBOT_SET)GetPreviousEnum<ROBOT_SET>(_Robot_Set);
            }
        }

        public void changeHP_Amp(CYCLE_DIRECTION CycleDirection)
        {
            if (CycleDirection == CYCLE_DIRECTION.Up)
                _HP_Amp = (HP_AMP)GetNextEnum<HP_AMP>(_HP_Amp);
            else
            {
                _HP_Amp = (HP_AMP)GetPreviousEnum<HP_AMP>(_HP_Amp);
            }
        }
        public void changeStage_Stat(CYCLE_DIRECTION CycleDirection)
        {
            if (CycleDirection == CYCLE_DIRECTION.Up)
                _Stage_Stat = (STAGE_STAT)GetNextEnum<STAGE_STAT>(_Stage_Stat);
            else
            {
                _Stage_Stat = (STAGE_STAT)GetPreviousEnum<STAGE_STAT>(_Stage_Stat);
            }
        }
        public void changeStage_Att(CYCLE_DIRECTION CycleDirection)
        {
            if (CycleDirection == CYCLE_DIRECTION.Up)
                _Stage_Att = (STAGE_ATT)GetNextEnum<STAGE_ATT>(_Stage_Att);
            else
            {
                _Stage_Att = (STAGE_ATT)GetPreviousEnum<STAGE_ATT>(_Stage_Att);
            }
        }
        public void changeStage_Loc(CYCLE_DIRECTION CycleDirection)
        {
            if (CycleDirection == CYCLE_DIRECTION.Up)
                _Stage_Loc = (STAGE_LOC)GetNextEnum<STAGE_LOC>(_Stage_Loc);
            else
            {
                _Stage_Loc = (STAGE_LOC)GetPreviousEnum<STAGE_LOC>(_Stage_Loc);
            }
        }
        public void changeLit(CYCLE_DIRECTION CycleDirection)
        {
            if (CycleDirection == CYCLE_DIRECTION.Up)
                _Lit = (LIT)GetNextEnum<LIT>(_Lit);
            else
            {
                _Lit = (LIT)GetPreviousEnum<LIT>(_Lit);
            }
        }
        public void changeApp_Strat(CYCLE_DIRECTION CycleDirection)
        {
            if (CycleDirection == CYCLE_DIRECTION.Up)
                _App_Strat = (APP_STRAT)GetNextEnum<APP_STRAT>(_App_Strat);
            else
            {
                _App_Strat = (APP_STRAT)GetPreviousEnum<APP_STRAT>(_App_Strat);
            }
        }
        public void changeCurrent_Loc(CYCLE_DIRECTION CycleDirection)
        {
            if (CycleDirection == CYCLE_DIRECTION.Up)
                _Current_Loc = (CURRENT_LOC)GetNextEnum<CURRENT_LOC>(_Current_Loc);
            else
            {
                _Current_Loc = (CURRENT_LOC)GetPreviousEnum<CURRENT_LOC>(_Current_Loc);
            }
        }


        //Cycle Event Name
        public void cycleEventName(CYCLE_DIRECTION CycleDirection)
        {
            if (CycleDirection == CYCLE_DIRECTION.Up)
            {
                _match_event = (MATCHEVENT_NAME)GetNextEnum<MATCHEVENT_NAME>(_match_event);
            }
            else
            {
                _match_event = (MATCHEVENT_NAME)GetPreviousEnum<MATCHEVENT_NAME>(_match_event);
            }
        }

        private Enum GetNextEnum<t>(object currentlySelectedEnum)
        {
            Type enumList = typeof(t);
            if (!enumList.IsEnum)
                throw new InvalidOperationException("Object is not an Enum.");

            Array enums = Enum.GetValues(enumList);
            int index = Array.IndexOf(enums, currentlySelectedEnum);
            index = (index + 1) % enums.Length;
            return (Enum)enums.GetValue(index);
        }

        private Enum GetPreviousEnum<t>(object currentlySelectedEnum)
        {
            Type enumList = typeof(t);
            if (!enumList.IsEnum)
                throw new InvalidOperationException("Object is not an Enum.");

            Array enums = Enum.GetValues(enumList);
            int index = Array.IndexOf(enums, currentlySelectedEnum);
            index = (((index == 0) ? enums.Length : index) - 1);
            return (Enum)enums.GetValue(index);
        }
    }
}
