using Computers.UI.Console.AbstractComputerFactory;
using Computers.UI.Console;
using Computers.UI.Console.Models;

namespace Computers.UI.Console.Commands
{
    public class ProcessCommand : IComputerCommand
    {
        public void Execute(IStringBuilderPrinter printer, IComputer computer, byte parameter)
        {
            //var result = computer.Process(parameter);
            //printer.AppendResult(result);
        }
    }
}
