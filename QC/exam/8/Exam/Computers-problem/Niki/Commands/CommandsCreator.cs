namespace Computers.UI.Console.Commands
{
    using System;
    using System.Collections.Generic;

    public static class CommandsCreator
    {
        private static readonly IDictionary<string, IComputerCommand> commandDictionary = new Dictionary<string, IComputerCommand>
        {
            {"Play", new PlayCommand()},
            {"Charge", new ChargeCommand()},
            {"Process", new ProcessCommand()}
        };

        internal static IComputerCommand GetCommand(string commandName)
        {
            if (!commandDictionary.Keys.Contains(commandName))
            {
                throw new ArgumentException("Invalid command");
            }

            return commandDictionary[commandName];
        }
    }
}
