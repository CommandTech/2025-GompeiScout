using SharpDX.DirectInput;
using System;
using static ScoutingCodeRedo.Dynamic.RobotState;

namespace ScoutingCodeRedo.Static
{
    class GamePad
    {
        //currentValue values
        private bool _a = false;
        private bool _b = false;
        private bool _x = false;
        private bool _y = false;
        private bool _rt = false;
        private bool _lt = false;
        private bool _rb = false;
        private bool _lb = false;
        private bool _dpadup = false;
        private bool _dpaddown = false;
        private bool _dpadleft = false;
        private bool _dpadright = false;
        private bool _lTHUp = false;
        private bool _lTHDown = false;
        private bool _lTHLeft = false;
        private bool _lTHRight = false;
        private bool _rTHUp = false;
        private bool _rTHDown = false;
        private bool _rTHLeft = false;
        private bool _rTHRight = false;
        private bool _backButton = false;
        private bool _startButton = false;
        private bool _r3 = false;
        private bool _l3 = false;
        //private string _deviceInfo;

        //previous values

        private bool _aPrev = false;
        private bool _bPrev = false;
        private bool _xPrev = false;
        private bool _yPrev = false;
        private bool _rtPrev = false;
        private bool _ltPrev = false;
        private bool _rbPrev = false;
        private bool _lbPrev = false;
        private bool _dpadupPrev = false;
        private bool _dpaddownPrev = false;
        private bool _dpadleftPrev = false;
        private bool _dpadrightPrev = false;
        private bool _lTHUpPrev = false;
        private bool _lTHDownPrev = false;
        private bool _lTHLeftPrev = false;
        private bool _lTHRightPrev = false;
        private bool _rTHUpPrev = false;
        private bool _rTHDownPrev = false;
        private bool _rTHLeftPrev = false;
        private bool _rTHRightPrev = false;
        private bool _backButtonPrev = false;
        private bool _startButtonPrev = false;
        private bool _r3Prev = false;
        private bool _l3Prev = false;

        readonly Joystick _js;

        public GamePad(Joystick js)
        {
            _js = js;
            this.Update();
        }

        public void Update()
        {
            //save old values before overwritten.
            RecordOldValues();

            try
            {
                //reads all digital buttons
                _a = _js.GetCurrentState().Buttons[0];
                _b = _js.GetCurrentState().Buttons[1];
                _x = _js.GetCurrentState().Buttons[2];
                _y = _js.GetCurrentState().Buttons[3];
                _lb = _js.GetCurrentState().Buttons[4];
                _rb = _js.GetCurrentState().Buttons[5];
                _startButton = _js.GetCurrentState().Buttons[7];
                _backButton = _js.GetCurrentState().Buttons[6];

                _l3 = _js.GetCurrentState().Buttons[8];
                _r3 = _js.GetCurrentState().Buttons[9];

                //reads which dpad directions are pressed
                int pov = _js.GetCurrentState().PointOfViewControllers[0];
                _dpadup = ((pov > 27000 || pov < 9000) && pov != -1);
                _dpaddown = (9000 < pov && pov < 27000);
                _dpadright = (0 < pov && pov < 18000);
                _dpadleft = (18000 < pov);

                //reads the direction of the left hand anolog stick
                int X = _js.GetCurrentState().X;
                int Y = _js.GetCurrentState().Y;
                _lTHUp = (-100 < X) && (X < 100) && (Y < -90);
                _lTHDown = (-100 < X) && (X < 100) && (Y > 90);
                _lTHRight = (-100 < Y) && (Y < 100) && (X < 90);
                _lTHLeft = (-100 < Y) && (Y < 100) && (X > -90);

                //reads direction of left hand analog stick
                int RotationX = _js.GetCurrentState().RotationX;
                int RotationY = _js.GetCurrentState().RotationY;
                _rTHUp = (-100 < RotationX) && (RotationX < 100) && (RotationY < -90);
                _rTHDown = (-100 < RotationX) && (RotationX < 190) && (RotationY > 90);
                _rTHLeft = (-100 < RotationY) && (RotationY < 100) && (RotationX < -90);
                _rTHRight = (-100 < RotationY) && (RotationY < 100) && (RotationX > 90);

                //reads which trigger is pressed
                int Z = _js.GetCurrentState().Z;
                _rt = (Z < -99);
                _lt = (Z > 98);

                //read device info
                //_deviceInfo = _js.Information.InstanceName;
            }
            catch (Exception)
            {

            }

        }

        public JoystickState GetCurrentState()
        { return _js.GetCurrentState(); }

        //Pressed State - Only triggers once per button press
        public bool AButton_Press
        { get { return IsPressed(_a, _aPrev); } }

        public bool BButton_Press
        { get { return IsPressed(_b, _bPrev); } }

        public bool XButton_Press
        { get { return IsPressed(_x, _xPrev); } }

        public bool YButton_Press
        { get { return IsPressed(_y, _yPrev); } }

        public bool R3_Press
        { get { return IsPressed(_r3, _r3Prev); } }

        public bool L3_Press
        { get { return IsPressed(_l3, _l3Prev); } }

        public bool RightTrigger_Press
        { get { return IsPressed(_rt, _rtPrev); } }

        public bool LeftTrigger_Press
        { get { return IsPressed(_lt, _ltPrev); } }

        public bool RightButton_Press
        { get { return IsPressed(_rb, _rbPrev); } }

        public bool LeftButton_Press
        { get { return IsPressed(_lb, _lbPrev); } }

        public bool DpadUp_Press
        { get { return IsPressed(_dpadup, _dpadupPrev); } }

        public bool DpadRight_Press
        { get { return IsPressed(_dpadright, _dpadrightPrev); } }

        public bool DpadDown_Press
        { get { return IsPressed(_dpaddown, _dpaddownPrev); } }

        public bool DpadLeft_Press
        { get { return IsPressed(_dpadleft, _dpadleftPrev); } }

        public bool LTHUp_Press
        { get { return IsPressed(_lTHUp, _lTHUpPrev); } }

        public bool LTHRight_Press
        { get { return IsPressed(_lTHRight, _lTHRightPrev); } }

        public bool LTHDown_Press
        { get { return IsPressed(_lTHDown, _lTHDownPrev); } }

        public bool LTHLeft_Press
        { get { return IsPressed(_lTHLeft, _lTHLeftPrev); } }

        public bool RTHUp_Press
        { get { return IsPressed(_rTHUp, _rTHUpPrev); } }

        public bool RTHRight_Press
        { get { return IsPressed(_rTHRight, _rTHRightPrev); } }

        public bool RTHDown_Press
        { get { return IsPressed(_rTHDown, _rTHDownPrev); } }

        public bool RTHLeft_Press
        { get { return IsPressed(_rTHLeft, _rTHLeftPrev); } }

        public bool BackButton_Press
        { get { return IsPressed(_backButton, _backButtonPrev); } }

        public bool StartButton_Press
        { get { return IsPressed(_startButton, _startButtonPrev); } }

        // Released only triggers once per state
        public bool AButton_Release
        { get { return IsReleased(_a, _aPrev); } }

        public bool BButton_Release
        { get { return IsReleased(_b, _bPrev); } }

        public bool XButton_Release
        { get { return IsReleased(_x, _xPrev); } }

        public bool YButton_Release
        { get { return IsReleased(_y, _yPrev); } }

        public bool R3_Release
        { get { return IsReleased(_r3, _r3Prev); } }

        public bool L3_Release
        { get { return IsReleased(_l3, _l3Prev); } }

        public bool RightTrigger_Release
        { get { return IsReleased(_rt, _rtPrev); } }

        public bool LeftTrigger_Release
        { get { return IsReleased(_lt, _ltPrev); } }

        public bool RightButton_Release
        { get { return IsReleased(_rb, _rbPrev); } }

        public bool LeftButton_Release
        { get { return IsReleased(_lb, _lbPrev); } }

        public bool DpadUp_Release
        { get { return IsReleased(_dpadup, _dpadupPrev); } }

        public bool DpadRight_Release
        { get { return IsReleased(_dpadright, _dpadrightPrev); } }

        public bool DpadDown_Release
        { get { return IsReleased(_dpaddown, _dpaddownPrev); } }

        public bool DpadLeft_Release
        { get { return IsReleased(_dpadleft, _dpadleftPrev); } }

        public bool LTHUp_Release
        { get { return IsReleased(_lTHUp, _lTHUpPrev); } }

        public bool LTHRight_Release
        { get { return IsReleased(_lTHRight, _lTHRightPrev); } }

        public bool LTHDown_Release
        { get { return IsReleased(_lTHDown, _lTHDownPrev); } }

        public bool LTHLeft_Release
        { get { return IsReleased(_lTHLeft, _lTHLeftPrev); } }

        public bool RTHUp_Release
        { get { return IsReleased(_rTHUp, _rTHUpPrev); } }

        public bool RTHRight_Release
        { get { return IsReleased(_rTHRight, _rTHRightPrev); } }

        public bool RTHDown_Release
        { get { return IsReleased(_rTHDown, _rTHDownPrev); } }

        public bool RTHLeft_Release
        { get { return IsReleased(_rTHLeft, _rTHLeftPrev); } }

        public bool BackButton_Release
        { get { return IsReleased(_backButton, _backButtonPrev); } }

        public bool StartButton_Release
        { get { return IsReleased(_startButton, _startButtonPrev); } }

        //Down State - Triggers any time the button is held down (more than once per button press)
        public bool AButton_Down
        { get { return _a; } }

        public bool BButton_Down
        { get { return _b; } }

        public bool XButton_Down
        { get { return _x; } }

        public bool YButton_Down
        { get { return _y; } }

        public bool R3_Down
        { get { return _r3; } }

        public bool L3_Down
        { get { return _l3; } }

        public bool RightTrigger_Down
        { get { return _rt; } }

        public bool LeftTrigger_Down
        { get { return _lt; } }

        public bool RightButton_Down
        { get { return _rb; } }

        public bool LeftButton_Down
        { get { return _lb; } }

        public bool DpadUp_Down
        { get { return _dpadup; } }

        public bool DpadRight_Down
        { get { return _dpadright; } }

        public bool DpadDown_Down
        { get { return _dpaddown; } }

        public bool DpadLeft_Down
        { get { return _dpadleft; } }

        public bool LTHUp_Down
        { get { return _lTHUp; } }

        public bool LTHRight_Down
        { get { return _lTHRight; } }

        public bool LTHDown_Down
        { get { return _lTHDown; } }

        public bool LTHLeft_Down
        { get { return _lTHLeft; } }

        public bool RTHUp_Down
        { get { return _rTHUp; } }

        public bool RTHRight_Down
        { get { return _rTHRight; } }

        public bool RTHDown_Down
        { get { return _rTHDown; } }

        public bool RTHLeft_Down
        { get { return _rTHLeft; } }

        public bool BackButton_Down
        { get { return _backButton; } }

        public bool StartButton_Down
        { get { return _startButton; } }

        private void RecordOldValues()
        {
            _aPrev = _a;
            _bPrev = _b;
            _xPrev = _x;
            _yPrev = _y;
            _rtPrev = _rt;
            _ltPrev = _lt;
            _rbPrev = _rb;
            _lbPrev = _lb;
            _dpadupPrev = _dpadup;
            _dpadleftPrev = _dpadleft;
            _dpadrightPrev = _dpadright;
            _dpaddownPrev = _dpaddown;
            _lTHUpPrev = _lTHUp;
            _lTHDownPrev = _lTHDown;
            _lTHLeftPrev = _lTHLeft;
            _lTHRightPrev = _lTHRight;
            _rTHUpPrev = _rTHUp;
            _rTHDownPrev = _rTHDown;
            _rTHLeftPrev = _rTHLeft;
            _rTHRightPrev = _rTHRight;
            _backButtonPrev = _backButton;
            _startButtonPrev = _startButton;
            _r3Prev = _r3;
            _l3Prev = _l3;
        }

        private bool IsPressed(bool currentValue, bool prevValue)
        {
            if (prevValue == false && currentValue == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool IsReleased(bool currentValue, bool prevValue)
        {
            if (prevValue == true && currentValue == false)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        internal void SimulateButtonPress(string button)
        {
            var field = this.GetType().GetField("_" + button, System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            if (field != null && field.FieldType == typeof(bool))
            {
                field.SetValue(this, true);
            }
        }
        internal void SimulateButtonDown(string button)
        {
            var field = this.GetType().GetField("_" + button, System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            if (field != null && field.FieldType == typeof(bool))
            {
                field.SetValue(this, true);
            }
        }
    }
}