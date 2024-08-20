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

        public RobotState[] Robots = new RobotState[6];                            //Contains the state of each Scout's match tracking

        public List<System.Text.RegularExpressions.Match> InMemoryMatchList = new List<System.Text.RegularExpressions.Match>();     
        public SeasonContext seasonframework = new SeasonContext();
        public List<string> teamlist = new List<string>();                         //The list of teams for the event selected
    }
}
