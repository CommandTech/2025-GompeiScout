using System;
using System.Diagnostics;

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

        // 2025 enums

        //2025 PUBLIC INT



        // 2025 timers



        // 2025 local variables



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

        
        ///Scouter Name
        public SCOUTER_NAME GetScouterName()
        { return _ScouterName; }

        ///<summary>
        ///Resets all values to the default
        ///</summary>
        ///

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

        //2025 cycles
        


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
    }
}
