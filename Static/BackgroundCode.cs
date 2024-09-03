using System;
using System.Collections.Generic;
using ScoutingCodeRedo.Dynamic;
using ScoutingCodeRedo.Static.GamePadFolder;
using SharpDX.DirectInput;

namespace ScoutingCodeRedo.Static
{
    internal class BackgroundCode
    {
        public DirectInput Input = new DirectInput();
        public GamePad[] gamePads;

        public static RobotState[] Robots = new RobotState[6];                            //Contains the state of each Scout's match tracking

        public List<Match> InMemoryMatchList = new List<Match>();           //The list of all the matches at the selected event.
        public List<Match> UnSortedMatchList = new List<Match>();           //This is just the list of all matches, not yet sorted
        public List<int> MatchNumbers = new List<int>();

        public SeasonContext seasonframework = new SeasonContext();
        public List<string> teamlist = new List<string>();                         //The list of teams for the event selected

        public RobotState[] rs = new RobotState[6];

        public GamePadFolder.Controllers controllers = new GamePadFolder.Controllers();
        public BackgroundCode()
        {
            for (int i = 0; i < 6; i++)
            {
                BackgroundCode.Robots[i] = new RobotState
                {
                    ScouterBox = i,
                    _ScouterName = RobotState.SCOUTER_NAME.Select_Name,
                    color = i < 3 ? "Red" : "Blue"
                };
            }
        }
    }
}
