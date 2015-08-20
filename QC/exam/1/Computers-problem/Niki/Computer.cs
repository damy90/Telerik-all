namespace ComputerBuildingSystem
{
    using System.Collections.Generic;

    public abstract class Computer
    {
        public Computer(CPU cpu, RAM ram, HardDriver hardDriver, IDrawable videoCard)
        {
            this.CPU = cpu;
            this.RAM = ram;
            this.HardDrives = hardDriver;
            this.VideoCard = videoCard;
         }

        public HardDriver HardDrives { get; set; }

        public IDrawable VideoCard { get; set; }

        public CPU CPU { get; set; }

        public RAM RAM { get; set; }
    }
}
