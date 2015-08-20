namespace ComputerBuildingSystem
{
    using System;

    public class ComputerBuildingSystemEntryPoint
    {
        private static PC pc;
        private static Server server;
        private static Laptop laptop;
        private static ManufacturerFactory manufacturerFactory = new ManufacturerFactory();

        public static void Main()
        {
            var manufacturerName = Console.ReadLine();

            Manufacturer manufacturer = manufacturerFactory.GetManufacturer(manufacturerName);
            manufacturer.GetAllProducts(out pc, out server, out laptop);
            while (true)
            {
                var input = Console.ReadLine();

                if (input == null || input.StartsWith("Exit"))
                {
                    break;
                }

                var separator = new[]
                {
                    ' '
                };
                var commmandPortions = input.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                if (commmandPortions.Length != 2)
                {
                    {
                        throw new ArgumentException("Invalid command!");
                    }
                }
               
                var commandName = commmandPortions[0];
                var commandArgument = int.Parse(commmandPortions[1]);
                ICommand command = null;
                if (commandName == "Charge")
                {
                    command = new ChargeCommand(laptop);                  
                }
                else if (commandName == "Process")
                {
                    command = new ProcessCommand(server);
                }
                else if (commandName == "Play")
                {
                    command = new PlayCommand(pc);
                }
                else
                {
                    Console.WriteLine("Invalid command!");
                }

                if (command != null)
                {
                    command.Execute(commandArgument);
                }
            }
        }
    }
}
