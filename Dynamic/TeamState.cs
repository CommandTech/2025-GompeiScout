using System;
using System.Diagnostics;

namespace ScoutingCodeRedo.Dynamic
{
    public class TeamState
    {
        public string TeamName;

        public bool canLeave;

        public bool canHoldCoral;
        public bool canPickupStation;
        public bool canPickupFloorCoral;
        public bool canScoreL4;
        public bool canScoreL3;
        public bool canScoreL2;
        public bool canScoreL1;

        public bool canHoldAlgae;
        public bool canPickupReef;
        public bool canPickupFloorAlgae;
        public bool canDislodgeAlgae;
        public bool canScoreProcessor;
        public bool canScoreNet;

        public bool canClimbDeep;
        public bool canClimbShallow;
    }
}
