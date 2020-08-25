using System;
using System.Collections.Generic;
using System.Text;

namespace WashingMachine
{
    class WashingMachine
    {

        #region Variables

        private bool onOrOff;
        private bool door;
        private string washingProgram;
        private int temperature;
        private int washingPowder;

        #endregion

        public WashingMachine()
        {

        }

        public bool OnOrOff
        {
            get { return this.onOrOff; }
            set { this.onOrOff = false; }
        }

        public bool PowerButten()
        {
            if (onOrOff == false)
            {
                Console.WriteLine("Vaske maskinen er slukket");
            }
            else
            {
                Console.WriteLine("Vaske maskinen er tendt");
            }

            Console.WriteLine("1. Tend");

            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    onOrOff = true;
                    break;
                case "2":
                    onOrOff = false;
                    break;
            }

            return onOrOff;
        }

        public bool Door
        {
            get { return this.door; }
            set { this.door = false; }
        }

        public int WashingPowder
        {
            get { return this.washingPowder; }
            set { this.washingPowder = value; }
        }

        public string WashingProgram
        {
            get { return this.washingProgram; }
            set
            {
                if (value == "Hurtig vask" || value == "Eco vask" || value == "Normal vask")
                {
                    this.washingProgram = value;
                }
            }
        }

        public int Temperature
        {
            get { return this.temperature; }
            set
            {
                if (value == 30 || value == 40 || value == 60)
                {
                    this.temperature = value;
                }
            }
        }

        public WashingMachine(string chooseProgram, int ChooseTemperature)
        {
            WashingProgram = chooseProgram;
            Temperature = ChooseTemperature;
        }

    }
}
