namespace ComputerBuildingSystem.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public interface IComputer
    {
        Cpu Cpu { get; set; }

        Ram Ram { get; set; }

        VideoCard VideoCard { get; set; }

        HardDriver HardDrive { get; set; }

        IEnumerable<HardDriver> HardDrives { get; set; }
    }
}
