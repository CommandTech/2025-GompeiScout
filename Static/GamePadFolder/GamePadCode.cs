using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Net;
using SharpDX.DirectInput;
using ScoutingCodeRedo.Dynamic;

namespace ScoutingCodeRedo.Static
{
    //This will be base code for everything that has to do with the gamepad that does not change from year to year
    internal class GamePadCode
    {
        DirectInput Input = new DirectInput();
        GamePad[] gamePads;


    }
}
