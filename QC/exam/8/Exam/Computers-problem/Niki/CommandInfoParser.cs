namespace Computers.UI.Console
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal static class CommandInfoParser
    {
        internal static ICommandInfo Parse(string inputCommand) 
        {
            var separators = new[] { ' ' };
            var commandInfo = inputCommand.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            if (commandInfo.Length != 2)
            {
                {
                    throw new ArgumentException("Invalid command!");
                }
            }

            var commandName = commandInfo[0];
            var commandParameter = byte.Parse(commandInfo[1]);

            var resultCommandInfo = new CommandInfo
            {
                CommandName = commandName,
                CommandParameter = commandParameter
            };

            return resultCommandInfo;
        }
    }
}
