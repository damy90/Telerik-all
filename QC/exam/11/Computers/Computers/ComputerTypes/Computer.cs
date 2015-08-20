using Computers.ComputerParts;
using Computers.ComputerParts.Processor;
using Computers.Mediator;

namespace Computers.ComputerTypes
{
    public abstract class Computer
    {
        public Computer(CentralProcessingUnit centralProcessingUnit, RamMemory ramMemory, HardDrive hardDrives, VideoCard videoCard)
        {
            this.CentralProcessingUnit = centralProcessingUnit;
            this.RamMemory = ramMemory;
            this.HardDrives = hardDrives;
            this.VideoCard = videoCard;

            this.Motherboard = new Motherboard();
            this.Motherboard.Register(this.CentralProcessingUnit);
            this.Motherboard.Register(this.RamMemory);
            this.Motherboard.Register(this.VideoCard);
        }

        public CentralProcessingUnit CentralProcessingUnit { get; private set; }

        public RamMemory RamMemory { get; private set; }

        public HardDrive HardDrives { get; private set; }

        public VideoCard VideoCard { get; private set; }

        public Motherboard Motherboard { get; set; }
    }
}
