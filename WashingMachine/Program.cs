using System;
using System.ComponentModel.Design;
using System.Threading.Channels;

namespace WashingMachine
{
    class Program
    {

        static void Main(string[] args)
        {
            WashingMachine washing = new WashingMachine();
            bool loop = true;

            while (loop)
            {
                SelectMenu(washing.door, washing.washingPowder, washing.onOrOff, washing.wasingProgram, washing.temperature, washing.start);

                string userChooseProgram = null;
                int userChooseTemperature;

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        washing.door = true;
                        break;

                    case "2":
                        washing.door = false;
                        break;

                    case "3":
                        washing.onOrOff = true;
                        break;

                    case "4":
                        washing.onOrOff = false;
                        break;

                    case "5":
                        if (washing.washingPowder == false)
                        {
                            Console.WriteLine("There is no washing powder please refill\n" +
                                "1. to fill");
                            userInput = Console.ReadLine();
                            switch (userInput)
                            {
                                case "1":
                                    washing.washingPowder = true;
                                    break;
                            }

                        }
                        break;

                    case "6":

                        Console.WriteLine("Select Program\n" +
                            "1. Quick Wash\n" +
                            "2. Eco Wask\n" +
                            "3. Normal Wash");

                        userChooseProgram = Console.ReadLine();

                        if (userChooseProgram == "1")
                        {
                            washing.wasingProgram = "Quck Wask";
                        }
                        else if (userChooseProgram == "2")
                        {
                            washing.wasingProgram = "Eco Wash";
                        }
                        else if (userChooseProgram == "3")
                        {
                            washing.wasingProgram = "Normal Wash";
                        }
                        break;

                    case "7":

                        Console.WriteLine("Select Temperature\n" +
                            "1. 30 degrees\n" +
                            "2. 40 degrees\n" +
                            "3. 50 degrees");

                        userChooseTemperature = Convert.ToInt32(Console.ReadLine());

                        if (userChooseTemperature == 1)
                        {
                            washing.temperature = 30;
                        }
                        else if (userChooseTemperature == 2)
                        {
                            washing.temperature = 40;
                        }
                        else if (userChooseTemperature == 3)
                        {
                            washing.temperature = 50;
                        }
                        break;

                    case "8":
                        if (washing.onOrOff == true && washing.door == false && washing.washingPowder == true && washing.wasingProgram != null)
                        {
                            washing.start = "Running, go get som coffee while you wait";
                        }
                        else
                        {
                            washing.start = "You need to check if the mechine can run";
                        }
                        break;
                    case "9":
                        Environment.Exit(1);
                        break;
                }


            }

        }

        static void SelectMenu(bool door, bool powder, bool power, string program, int temperature, string Run)
        {
            Console.Clear();

            string openClose = null;
            string powderTmp = null;
            string powerTmp = null;

            if (door == true)
            {
                openClose = "Open";
            }
            else if (door == false)
            {
                openClose = "Closed";
            }

            if (power == true)
            {
                powerTmp = "On";
            }
            else if (power == false)
            {
                powerTmp = "Off";
            }

            if (powder == true)
            {
                powderTmp = "There is powder";
            }
            else if (powder == false)
            {
                powderTmp = "Need washing powder";
            }

            Console.WriteLine("Please select action\n\n" +
               $"1. open | 2. close the door, the door is {openClose}\n" +
               $"3. trun on | 4. turn off, it is {powerTmp}\n" +
               $"5. check washingpowder, {powderTmp}\n" +
               $"6. select program {program}\n" +
               $"7. select temperature {temperature}\n" +
               $"8. Start {Run}\n" +
               "9. Go get coffee");

        }

    }
}
