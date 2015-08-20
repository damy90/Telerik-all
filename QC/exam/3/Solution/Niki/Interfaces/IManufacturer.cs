namespace Computers.Interfaces
{
    using System;
    using System.Linq;

    public interface IManufacturer
    {
        IComputerManufacturer GetManufacturer();
    }
}
