using System;
using System.Collections.Generic;
using System.Text;

namespace WashingMachine
{
    class WashingMachine
    {

        #region Variables

        private bool OnOrOff;
        private bool Door;
        private bool WashingPowder;
        private string WashingProgram;
        private string Start;
        private int Temperature;

        #endregion

        public bool onOrOff
        {
            get { return OnOrOff; }
            set { OnOrOff = value; }
        }

        public bool door
        {
            get { return Door; }
            set { Door = value; }
        }

        public bool washingPowder
        {
            get { return WashingPowder; }
            set { WashingPowder = value; }
        }

        public string wasingProgram
        {
            get { return WashingProgram; }
            set { WashingProgram = value; }
        }

        public int temperature
        {
            get { return Temperature; }
            set { Temperature = value; }
        }

        public string start
        {
            get { return Start; }
            set { Start = value; }
        }

        public WashingMachine()
        {
            OnOrOff = onOrOff;
            WashingPowder = IsTherePowder();
            Door = door;
            WashingProgram = wasingProgram;
            Temperature = temperature;
            Start = start;
        }

        private bool IsTherePowder()
        {
            Random rand = new Random();
            int tmp = rand.Next(0, 10);
            bool temp2;

            if (tmp < 3)
            {
                temp2 = false;
            }
            else
            {
                temp2 = true;
            }

            return temp2;
        }
    }
}
