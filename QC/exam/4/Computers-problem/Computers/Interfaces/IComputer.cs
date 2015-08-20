namespace Computers.Interfaces
{
    using System.Collections.Generic;
    using ComputerComponents;

    public interface IComputer
    {
        ICpu Cpu { get; set; }

        Ram Ram { get; set; }

        IEnumerable<HardDrive> HardDrives { get; set; }
    }
}
