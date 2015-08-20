namespace Computers.UI.Console
{
    using Computers.UI.Console.Models;

    public class CommandInfo : ICommandInfo
    {
        public string CommandName { get; set; }

        public byte CommandParameter { get; set; }
    }
}
