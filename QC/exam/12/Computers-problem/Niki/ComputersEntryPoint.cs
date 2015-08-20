namespace Computers
{
    using System;
    using Computers.Contracts;
    using Manufacturers;

    public class ComputersEntryPoint
    {
        public static void Main()
        {
            var manufacturerName = Console.ReadLine();

            IFactory manufacturer;

            if (manufacturerName == "HP")
            {
                manufacturer = new FactoryHP();
            }
            else if (manufacturerName == "Dell")
            {
                manufacturer = new FactoryDell();
            }
            else if (manufacturerName == "Lenovo")
            {
                manufacturer = new FactoryLenovo();
            }
            else
            {
                throw new ArgumentException("Invalid manufacturer!");
            }

            var pc = manufacturer.CreatePC();
            var server = manufacturer.CreateServer();
            var laptop = manufacturer.CreateLaptop();

            // TODO: Simple factory to process commands
            while (true)
            {
                var command = Console.ReadLine();

                if (command == null)
                {
                    throw new ArgumentNullException("No Command was entered");
                }

                if (command.StartsWith("Exit"))
                {
                    break;
                }

                var parameters = command.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (parameters.Length != 2)
                {
                    {
                        throw new ArgumentException("Invalid command!");
                    }
                }

                var commandName = parameters[0];
                var commandValue = int.Parse(parameters[1]);

                if (commandName == "Charge")
                {
                    laptop.ChargeBattery(commandValue);
                }
                else if (commandName == "Process")
                {
                    server.Process(commandValue);
                }
                else if (commandName == "Play") 
                { 
                    pc.Play(commandValue); 
                }
                else 
                {
                    throw new ArgumentException("Invalid command!");
                }
            }
        }
    }
}
