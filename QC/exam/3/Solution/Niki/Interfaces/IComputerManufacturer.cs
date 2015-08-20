namespace Computers.Interfaces
{
    using System;
    using System.Linq;

    public interface IComputerManufacturer
    {
        IPersonalComputer MakePersonalComputer();

        ILaptopComputer MakeLaptopComputer();

        IServerComputer MakeSeverComputer();
    }
}
