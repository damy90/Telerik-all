namespace Computers.UI.Console
{
    using Computers.UI.Console.Models;

    public interface ICommandInfo
    {
        string CommandName { get; set; }

        byte CommandParameter { get; set; }
    }
}
