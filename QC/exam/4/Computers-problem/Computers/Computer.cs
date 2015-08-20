namespace Computers
{
    using System;
    using System.Collections.Generic;
    using ComputerComponents;
    using Enumarations;
    using Interfaces;

    public class Computer : IComputer
    {
        public readonly ComputerType Type;

        public Computer(ComputerType type, ICpu cpu, Ram ram, IEnumerable<HardDrive> hardDrives, IVideoCard videoCard)
        {
            this.Cpu = cpu;
            this.Ram = ram;
            this.HardDrives = hardDrives;
            this.VideoCard = videoCard;
            this.Type = type;
        }

        public ICpu Cpu { get; set; }

        public Ram Ram { get; set; }

        public IEnumerable<HardDrive> HardDrives { get; set; }

        public IVideoCard VideoCard { get; set; }
    }
}
