namespace ComputerBuildingSystem
{
    using System.Collections.Generic;
    using ComputerBuildingSystem.Computers;

    public class ManufactorerDell : ComputerAbstractFactory
    {
        public override PersonalComputer MakePC()
        {
            var ram = new Ram(8);
            var videoCard = new VideoCard(false);
            var motherBoear = new Motherboard(ram, videoCard);
            var cpu = new Cpu(new Cpu64(), 4, motherBoear);
            var hdd = new HardDriver();
            var hardDrives = new List<HardDriver> { new HardDriver(1000, false, 0) };

            return new PersonalComputer(cpu, ram, videoCard, hdd, hardDrives);
        }

        public override Laptop MakeLaptop()
        {
            var laptopRam = new Ram(8);
            var laptopVideoCard = new VideoCard(false);
            var motherBoear = new Motherboard(laptopRam, laptopVideoCard);
            var laptopCpu = new Cpu(new Cpu32(), 4, motherBoear);
            var laptopHDD = new HardDriver();
            var laptopHardDrives = new List<HardDriver> { new HardDriver(500, false, 0) };
            var laptopBattery = new Battery();

            return new Laptop(laptopCpu, laptopRam, laptopVideoCard, laptopHDD, laptopHardDrives, laptopBattery);
        }

        public override Server MakeServer()
        {
            var serverRam = new Ram(64);
            var serverVideoCard = new VideoCard();
            var motherBoear = new Motherboard(serverRam, serverVideoCard);
            var serverCpu = new Cpu(new Cpu64(), 8, motherBoear);
            var serverHDD = new HardDriver();
            var serrverHardDrives = new List<HardDriver> 
                        {
                            new HardDriver(
                                0, 
                                true, 
                                2, 
                                new List<HardDriver> 
                            {
                                new HardDriver(2000, false, 0), 
                                new HardDriver(2000, false, 0) 
                            })
                        };

            return new Server(serverCpu, serverRam, serverVideoCard, serverHDD, serrverHardDrives);
        }
    }
}
