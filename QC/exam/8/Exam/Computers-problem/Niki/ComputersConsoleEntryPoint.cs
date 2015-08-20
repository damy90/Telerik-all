namespace Computers.UI.Console
{
    using System;
    using System.Collections.Generic;
    using Models;
    using Computers.UI.Console.Commands;

    public class ComputersConsoleEntryPoint
    {
        public static void Main()
        {
            var manufacturer = Console.ReadLine();

            var computerFactory = FactoryGenerator.GetComputerFactory(manufacturer);
            var laptop = computerFactory.GetLaptop();
            var pc = computerFactory.GetPersonalComputer();
            var server = computerFactory.GetServer();
            var compDictionary = new Dictionary<string, IComputer>()
                {
                    {"Play", pc},
                    {"Charge", laptop},
                    {"Process", server}
                };

            var resultsPrinter = new StringBuilderPrinter();

            while (true)
            {
                var userInput = Console.ReadLine();

                if (userInput == null || userInput.StartsWith("Exit"))
                {
                    break;
                }

                var commandInfo = CommandInfoParser.Parse(userInput);
                var commandName = commandInfo.CommandName;
                var commandParameter = commandInfo.CommandParameter;
                var computerInUse = compDictionary[commandName];

                if (commandName == "Play") 
                {
                    pc.GuessNumber(commandParameter);
                }
                else if (commandName == "Charge") 
                {
                    laptop.ChargeBattery(commandParameter);
                }
                else if (commandName == "Process") 
                {
                    server.Process(commandParameter);
                }

                //var command = CommandsCreator.GetCommand(commandName);                
                //command.Execute(resultsPrinter, computerInUse, commandParameter);
            }
        }
    }
}
