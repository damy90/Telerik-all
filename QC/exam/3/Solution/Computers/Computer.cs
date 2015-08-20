using Computers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computers
{
    public class Computer : IComputer
    {
        public Computer(ComputerType type, IMotherboard motherboard, Cpu cpu, Ram ram, IEnumerable<HardDrive> hardDrives, IVideoCard videoCard)
        {
            // TODO: validate
            this.Cpu = cpu;
            this.Ram = ram;
            this.HardDrives = hardDrives;
            this.VideoCard = videoCard;
            this.Motherboard = motherboard;
        }

        protected IMotherboard Motherboard { get; set; }

        protected IEnumerable<HardDrive> HardDrives { get; set; }

        protected IVideoCard VideoCard { get; set; }

        protected Cpu Cpu { get; set; }

        protected Ram Ram { get; set; }
    }
}