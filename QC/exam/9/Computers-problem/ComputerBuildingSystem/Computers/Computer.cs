namespace ComputerBuildingSystem.Computers
{
    using System.Collections.Generic;
    using ComputerBuildingSystem.Interfaces;

    public class Computer : IComputer
    {
        private Cpu cpu;
        private Ram ram;
        private VideoCard videoCard;
        private HardDriver hdd;
        private IEnumerable<HardDriver> hardDrives;

        public Computer()
        {
        }

        public Computer(Cpu cpu, Ram ram, VideoCard videoCard, HardDriver hdd, IEnumerable<HardDriver> hardDrives)
        {
            this.Cpu = cpu;
            this.Ram = ram;
            this.VideoCard = videoCard;
            this.HardDrive = hdd;
            this.HardDrives = hardDrives;
        }

        public Cpu Cpu
        {
            get
            {
                return this.cpu;
            }

            set
            {
                this.cpu = value;
            }
        }

        public Ram Ram
        {
            get
            {
                return this.ram;
            }

            set
            {
                this.ram = value;
            }
        }

        public VideoCard VideoCard
        {
            get
            {
                return this.videoCard;
            }

            set
            {
                this.videoCard = value;
            }
        }

        public HardDriver HardDrive
        {
            get
            {
                return this.hdd;
            }

            set
            {
                this.hdd = value;
            }
        }

        public IEnumerable<HardDriver> HardDrives
        {
            get
            {
                return this.hardDrives;
            }

            set
            {
                this.hardDrives = value;
            }
        }
    }
}
