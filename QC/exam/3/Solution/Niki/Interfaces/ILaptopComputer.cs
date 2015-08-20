namespace Computers.Interfaces
{
    using System;
    using System.Linq;

    public interface ILaptopComputer : IComputer
    {
        void ChargeBattery(int percentage);
    }
}
