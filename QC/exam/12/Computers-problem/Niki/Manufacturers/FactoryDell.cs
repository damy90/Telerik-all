namespace Computers.Manufacturers
{
    using Computers.ComputerTypes;
    using Computers.Contracts;
    using Computers.StorageDevices;

    public class FactoryDell : IFactory
    {
        public PC CreatePC()
        {
            var ram = new Ram(8);
            var videoCard = new VideoCard(false);
            var cpu = new Cpu(4, 64, ram, videoCard);
            var storage = new HardDrive(1000);
            var pc = new PC(cpu, ram, storage, videoCard);

            return pc;
        }

        public Server CreateServer()
        {
            var ram = new Ram(64);
            var videoCard = new VideoCard(true);
            var cpu = new Cpu(8, 64, ram, videoCard);
            var storage = new RaidArray(2, 2000);
            var server = new Server(cpu, ram, storage, videoCard);

            return server;
        }

        public Laptop CreateLaptop()
        {
            var ram = new Ram(4);
            var videoCard = new VideoCard(false);
            var cpu = new Cpu(4, 32, ram, videoCard);
            var storage = new HardDrive(1000);
            var battery = new LaptopBattery();
            var laptop = new Laptop(cpu, ram, storage, videoCard, battery);

            return laptop;
        }
    }
}