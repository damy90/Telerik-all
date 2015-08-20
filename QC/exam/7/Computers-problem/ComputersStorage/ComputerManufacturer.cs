namespace Computers.Api
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ComputerManufacturer
    {
        private const int DefaultRamSize = 8;
        private const int ThirtyTwoBitsArchitecture = 32;

        private static Computer pc, laptop, server;

        public static void CreateComputer()
        {
            var manufacturer = Console.ReadLine();

            if (manufacturer == "HP")
            {
                pc = HpFactory.GetComputer(ComputerType.Pc);
                server = HpFactory.GetComputer(ComputerType.Server);
                laptop = HpFactory.GetComputer(ComputerType.Laptop);
            }
            else if (manufacturer == "Dell")
            {
                pc = DellFactory.GetComputer(ComputerType.Pc);
                server = DellFactory.GetComputer(ComputerType.Server);
                laptop = DellFactory.GetComputer(ComputerType.Laptop);
            }
            else
            {
                throw new ArgumentException("Invalid manufacturer!");
            }

            while (true)
            {
                var userCommand = Console.ReadLine();

                if (userCommand == null)
                {
                    throw new ArgumentNullException("Empty command!");
                }

                if (userCommand.StartsWith("Exit"))
                {
                    break;
                }

                var commandTokens = userCommand.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (commandTokens.Length != 2)
                {
                    {
                        throw new ArgumentException("Invalid command!");
                    }
                }

                var commandName = commandTokens[0];
                var commandValue = int.Parse(commandTokens[1]);

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
                    Console.WriteLine("Invalid command!");
                }
            }
        }
    }
}