namespace Computers.UI.Console
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Models;

    public abstract class Computer
    {
        internal Computer(CPU cpu, RAM ram, IEnumerable<HardDrive> hardDrives, VideoCard videoCard)
        {
            this.Cpu = cpu;
            this.Ram = ram;
            this.HardDrives = hardDrives;
            this.VideoCard = videoCard;
        }
                
        public VideoCard VideoCard { get; set; }
        public CPU Cpu { get; set; }
        public RAM Ram { get; set; }
        public IEnumerable<HardDrive> HardDrives { get; set; }
    }
}
