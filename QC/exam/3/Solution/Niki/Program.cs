namespace Computers
{
    using System;
    using Interfaces;
    using Manufacturers;

    public class Computers
    {
        public static void Main()
        {
            Random random = new Random();
            ManufacturerFactory manufacturerFactory = new ManufacturerFactory(random);
            var manufacturerName = Console.ReadLine();
            IComputerManufacturer computerFactory = manufacturerFactory.GetManufacturerFactory(manufacturerName);
            ILaptopComputer laptop = computerFactory.MakeLaptopComputer();
            IPersonalComputer personalComputer = computerFactory.MakePersonalComputer();
            IServerComputer server = computerFactory.MakeSeverComputer();

            while (true)
            {
                var input = Console.ReadLine();
                if (input == null)
                {
                    break;
                }

                if (input.StartsWith("Exit"))
                {
                    break;
                }

                var commandParts = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (commandParts.Length != 2)
                {
                    // throw new ArgumentException("Invalid command!");
                    Console.WriteLine("Invalid command!");
                }

                var commandName = commandParts[0];
                var commandArgument = int.Parse(commandParts[1]);

                if (commandName == "Charge")
                {
                    laptop.ChargeBattery(commandArgument);
                }
                else if (commandName == "Process")
                {
                    server.Process(commandArgument);
                }
                else if (commandName == "Play")
                {
                    personalComputer.Play(commandArgument);
                }
                else
                {
                    // continue;
                    Console.WriteLine("Invalid command!");
                }
            }
        }
    }
}