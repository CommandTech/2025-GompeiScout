using System;
using System.Diagnostics;

namespace ScoutingCodeRedo.Dynamic
{
    public class RobotState
    {
        public enum ROBOT_MODE { Auto, Teleop, Defense, Surfacing };
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
        public bool AUTO = true;
        public bool NoSho = false;

        //2025
        public enum STARTING_LOC { Select, C1, C2, C3, Center, C4, C5, C6 };
        public enum LEAVE { Z, Y, N};
        public enum APP_STRAT { Select };
        public enum END_STATE { Select, Elsewhere, Park, Shallow, Deep };
        public enum CAGE_ATTEMPT { Select, Y, N };

        public bool Flag = false;
        //False is near, True is far
        public bool Near_Far = false;
        public int Def_Rat = 9;
        public int Def_Eff = 9;
        public int Avo_Rat = 9;
        public int Dri_Rat = 9;
        public int Cor_Rat = 9;
        public int Alg_Rat = 9;

        public int hasCoral;
        public int hasAlgae;

        public int AcqCoralS;
        public int AcqCoralF;
        public int AcqAlgaeR;
        public int AcqAlgaeF;

        public int DelCoralL1;
        public int DelCoralL2;
        public int DelCoralL3;
        public int DelCoralL4;
        public int DelCoralF;

        public int DelAlgaeP;
        public int DelAlgaeN;
        public int DelAlgaeF;

        public string lastAlgaeLoc;
        public string lastCoralLoc;

        public string lastAlgaeAcqLoc;
        public string lastCoralAcqLoc;

        public TimeSpan ClimbT = TimeSpan.Zero;
        public Stopwatch ClimbT_StopWatch;
        public bool ClimbT_StopWatch_running;
        public double ClimbTDouble;

        public TimeSpan DefTime = TimeSpan.Zero;
        public Stopwatch DefTime_StopWatch;
        public bool DefTime_StopWatch_running;
        public double DefTimeDouble;

        public string Selected_Cage;


        // These are the standard types...

        public ROBOT_MODE Desired_Mode;         //Desired Mode

        //LOCAL VARIABLES SECTION.  All underscored variables indicate local variables for one controller/scouter

        public SCOUTER_NAME _ScouterName;          //ScouterName
        private string _TeamName;                   //TeamName
        private MATCHEVENT_NAME _match_event;       //Match Event
        private ROBOT_MODE _RobotMode;              //Control

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
        public MATCHEVENT_NAME Match_event
        {
            get { return _match_event; }
            set { _match_event = value; }
        }

        //public SCOUTER_NAME ScouterName
        //{
        //    get { return _ScouterName; }
        //    set { _ScouterName = value; }
        //}
        public SCOUTER_NAME GetScouterName()
        { return _ScouterName; }


        //Scouter Name
        public void ChangeScouterName(CYCLE_DIRECTION CycleDirection)
        {
            if (CycleDirection == CYCLE_DIRECTION.Up)
                _ScouterName = (SCOUTER_NAME)GetNextEnum<SCOUTER_NAME>(_ScouterName);
            else
            {
                _ScouterName = (SCOUTER_NAME)GetPreviousEnum<SCOUTER_NAME>(_ScouterName);
            }
        }

        //Cycle Event Name
        public void CycleEventName(CYCLE_DIRECTION CycleDirection)
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

        //2025
        private LEAVE _Leave;
        private STARTING_LOC _StartLoc;
        private APP_STRAT _Strategy;
        private END_STATE _EndState;
        private CAGE_ATTEMPT _CageAttempt;

        //2025
        public LEAVE GetLeave()
        { return _Leave; }
        public STARTING_LOC GetStart()
        { return _StartLoc; }
        public APP_STRAT GetStrat()
        { return _Strategy; }
        public END_STATE GetState()
        { return _EndState; }
        public CAGE_ATTEMPT GetAttempt()
        { return _CageAttempt; }


        public LEAVE Leave
        {
            get { return _Leave; }
            set { _Leave = value; }
        }
        public STARTING_LOC Starting_Location
        {
            get { return _StartLoc; }
            set { _StartLoc = value; }
        }
        public CAGE_ATTEMPT Cage_Attempt
        {
            get { return _CageAttempt; }
            set { _CageAttempt = value; }
        }
        public END_STATE End_State
        {
            get { return _EndState; }
            set { _EndState = value; }
        }

        //2025 cycles
        public void CycleLeave(CYCLE_DIRECTION CycleDirection)
        {
            if (CycleDirection == CYCLE_DIRECTION.Up)
            {
                _Leave = (LEAVE)GetNextEnum<LEAVE>(_Leave);
            }
            else
            {
                _Leave = (LEAVE)GetPreviousEnum<LEAVE>(_Leave);
            }
        }

        public void CycleStart(CYCLE_DIRECTION CycleDirection)
        {
            if (CycleDirection == CYCLE_DIRECTION.Up)
            {
                _StartLoc = (STARTING_LOC)GetNextEnum<STARTING_LOC>(_StartLoc);
            }
            else
            {
                _StartLoc = (STARTING_LOC)GetPreviousEnum<STARTING_LOC>(_StartLoc);
            }
        }
        public void CycleStrat(CYCLE_DIRECTION CycleDirection)
        {
            if (CycleDirection == CYCLE_DIRECTION.Up)
            {
                _Strategy = (APP_STRAT)GetNextEnum<APP_STRAT>(_Strategy);
            }
            else
            {
                _Strategy = (APP_STRAT)GetPreviousEnum<APP_STRAT>(_Strategy);
            }
        }
        public void CycleState(CYCLE_DIRECTION CycleDirection)
        {
            if (CycleDirection == CYCLE_DIRECTION.Up)
            {
                _EndState = (END_STATE)GetNextEnum<END_STATE>(_EndState);
            }
            else
            {
                _EndState = (END_STATE)GetPreviousEnum<END_STATE>(_EndState);
            }
        }
        public void CycleCage(CYCLE_DIRECTION CycleDirection)
        {
            if (CycleDirection == CYCLE_DIRECTION.Up)
            {
                _CageAttempt = (CAGE_ATTEMPT)GetNextEnum<CAGE_ATTEMPT>(_CageAttempt);
            }
            else
            {
                _CageAttempt = (CAGE_ATTEMPT)GetPreviousEnum<CAGE_ATTEMPT>(_CageAttempt);
            }
        }
    }
}
