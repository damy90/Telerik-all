namespace ComputerBuildingSystem
{
    using System;
    using ComputerBuildingSystem.Interfaces;

    public class ConputerBuildingSystem
    {
        public static void Main()
        {
            ComputerAbstractFactory manufacturer;

            var manufacturerName = Console.ReadLine();

            if (manufacturerName == "HP")
            {
                manufacturer = new ManufactorerHP();
            }
            else if (manufacturerName == "Dell")
            {
                manufacturer = new ManufactorerDell();
            }
            else if (manufacturerName == "Lenovo")
            {
                manufacturer = new ManufactorerLenovo();
            }
            else
            {
                throw new InvalidArgumentException("Invalid manufacturer!");
            }

            var factory = new ComputerFactory(manufacturer);

            IPersonalComputer personalComputer = factory.GetPersonalComputer();
            ILaptop laptop = factory.GetLaptop();
            IServer server = factory.GetServer();

            while (true)
            {
                var userInput = Console.ReadLine();
                if (userInput == null || userInput.StartsWith("Exit"))
                {
                    break;
                }

                var commandAndValue = userInput.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (commandAndValue.Length != 2)
                {
                    throw new ArgumentException("Invalid command!");
                }

                var command = commandAndValue[0];
                var commandValue = int.Parse(commandAndValue[1]);

                if (command == "Charge")
                {
                    laptop.ChargeBattery(commandValue);
                }
                else if (command == "Process")
                {
                    server.Process(commandValue);
                }
                else if (command == "Play")
                {
                    personalComputer.Play(commandValue);
                }
                else
                {
                    Console.WriteLine("Invalid command!");
                }
            }
        }
    }
}
