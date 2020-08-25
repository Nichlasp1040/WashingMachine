using System;

namespace WashingMachine
{
    class Program
    {

        static void Main(string[] args)
        {
            WashingMachine washingPower = new WashingMachine();
            washingPower.PowerButten();

            WashingMachine TheDoor = new WashingMachine();

            if (TheDoor.Door == false)
            {
                Console.WriteLine("1. Åben doren og leg besidt toj ind");
                string temp = Console.ReadLine();
                while (temp == "1")
                {
                    TheDoor.Door = true;
                    Console.WriteLine("Besidt tøj blev lagt i vaske maskinen");

                    Console.WriteLine("2. for at lukke døren");
                    temp = Console.ReadLine();
                }
            }

            Console.WriteLine("Velg program.\n1. Hurtig vask (30 min)\n2. Eco vask (1:30 time)\n3. Normal vask (1 time)");

            while (washingPower.OnOrOff == true)
            {
                string userChooseProgram = Console.ReadLine();

                switch (userChooseProgram)
                {
                    case "1":
                        userChooseProgram = "Hurtig vask";
                        break;
                    case "2":
                        userChooseProgram = "Eco vask";
                        break;
                    case "3":
                        userChooseProgram = "Normal vask";
                        break;
                }

                Console.WriteLine("velg temperatur\n1. 30 grader\n2. 40 grader\n3. 60 grader");

                int userChooseTemperature = Convert.ToInt32(Console.ReadLine());
                
                switch (userChooseTemperature)
                {
                    case 1:
                        userChooseTemperature = 30;
                        break;
                    case 2:
                        userChooseTemperature = 40;
                        break;
                    case 3:
                        userChooseTemperature = 60;
                        break;
                }

                WashingMachine washingMachineProgram = new WashingMachine(userChooseProgram, userChooseTemperature);

                Console.WriteLine(washingMachineProgram.Temperature + "\n" + washingMachineProgram.WashingProgram);

            }

        }
    }
}
