namespace Computers.ComputerTypes
{
    using Computers.Contracts;

    public class Computer : IComputer
    {
        private IMotherboard motherboard;
        
        public Computer(Cpu cpu, Ram ram, IStorageDevice storage, VideoCard videoCard)
        {
            this.CPU = cpu;
            this.Ram = ram;
            this.StorageDevice = storage;
            this.VideoCard = videoCard;

            this.motherboard = new Motherboard(this.CPU, this.Ram, VideoCard);
        }
        
        public IStorageDevice StorageDevice { get; set; }
        
        public VideoCard VideoCard { get; set; }

        public Cpu CPU { get; set; }

        public Ram Ram { get; set; }
    }
}
