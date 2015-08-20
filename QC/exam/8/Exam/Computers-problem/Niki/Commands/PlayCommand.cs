using Computers.UI.Console.AbstractComputerFactory;
using Computers.UI.Console;
using Computers.UI.Console.Models;

namespace Computers.UI.Console.Commands
{
    public class PlayCommand : IComputerCommand
    {
        public void Execute(IStringBuilderPrinter printer, IComputer computer, byte parameter)
        {
            //var result = computer.GuessNumber(parameter);
            //printer.AppendResult(result);
        }
    }
}
