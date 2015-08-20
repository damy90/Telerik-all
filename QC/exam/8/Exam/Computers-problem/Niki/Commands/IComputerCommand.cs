namespace Computers.UI.Console.Commands
{
    using Computers.UI.Console.Models;

    public interface IComputerCommand
    {
        void Execute(IStringBuilderPrinter printer, IComputer computer, byte parameter);
    }
}
