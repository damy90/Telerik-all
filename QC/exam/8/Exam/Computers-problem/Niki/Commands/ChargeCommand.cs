using Computers.UI.Console.AbstractComputerFactory;
using Computers.UI.Console;
using Computers.UI.Console.Models;

namespace Computers.UI.Console.Commands
{
    public class ChargeCommand : IComputerCommand
    {
        public void Execute(IStringBuilderPrinter printer, IComputer computer, byte parameter)
        {
            //var result = computer.ChargeBattery(parameter);
            //printer.AppendResult(result);
        }
    }
}
