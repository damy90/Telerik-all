namespace Computers.UI.Console
{
    using Computers.UI.Console.AbstractComputerFactory;

    public interface IComputerFactory
    {
        ILaptop GetLaptop();
        IServer GetServer();
        IPersonalComputer GetPersonalComputer();
    }
}
