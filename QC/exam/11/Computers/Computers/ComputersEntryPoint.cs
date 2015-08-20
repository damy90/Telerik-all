using Computers.Manufacturers;

namespace Computers
{
    using System;

    public class ComputersEntryPoint
    {
        public void Start()
        {
            var manufacturerName = Console.ReadLine();

            var manufacturer = ManufacturerFactory.GetManufacturer(manufacturerName);

            var personalComputer = manufacturer.ProducePersonalComputer();
            var laptop = manufacturer.ProduceLaptop();
            var server = manufacturer.ProduceServer();
            
            while (true)
            {
                var command = Console.ReadLine();

                if (command.StartsWith("Exit"))
                {
                    break;
                }

                var commandParameters = command.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (commandParameters.Length != 2)
                {
                    Console.WriteLine("Invalid command!");
                }

                var commandName = commandParameters[0];
                var commandArguments = int.Parse(commandParameters[1]);

                if (commandName == "Charge")
                {
                    laptop.ChargeBattery(commandArguments);
                }
                else if (commandName == "Process")
                {
                    server.Process(commandArguments);
                }
                else if (commandName == "Play")
                {
                    personalComputer.Play(commandArguments);
                }
                else
                {
                    Console.WriteLine("Invalid command!");
                }
            }
        }
    }
}