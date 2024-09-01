using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ScoutingCodeRedo.Dynamic;
using SharpDX.DirectInput;

namespace ScoutingCodeRedo.Static
{
    internal class BackgroundCode
    {
        public DirectInput Input = new DirectInput();
        public GamePad[] gamePads;

        public static RobotState[] Robots = new RobotState[6];                            //Contains the state of each Scout's match tracking

        public List<Dynamic.Match> InMemoryMatchList = new List<Dynamic.Match>();           //The list of all the matches at the selected event.
        public List<Dynamic.Match> UnSortedMatchList = new List<Dynamic.Match>();           //This is just the list of all matches, not yet sorted
        public List<int> MatchNumbers = new List<int>();

        public SeasonContext seasonframework = new SeasonContext();
        public List<string> teamlist = new List<string>();                         //The list of teams for the event selected
    }
}
