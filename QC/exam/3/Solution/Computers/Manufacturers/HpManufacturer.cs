namespace Computers.Manufacturers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Interfaces;

    public class HpManufacturer : Manufacturer, IComputerManufacturer
    {
        public HpManufacturer(Random random)
            : base(random)
        {
        }

        public override IPersonalComputer MakePersonalComputer()
        {
            var ram = new Ram(2);
            var videoCard = new ColorVideoCard();
            var hardDrive = new[] { new HardDrive(500, false, 0) };
            IMotherboard motherboard = new Motherboard(ram, videoCard);
            Cpu cpu = new Cpu32Bit(2, motherboard, this.random);

            var result = new PersonalComputer(motherboard, cpu, ram, hardDrive, videoCard);
            return result;
        }

        public override ILaptopComputer MakeLaptopComputer()
        {
            IVideoCard videoCard = new ColorVideoCard();
            Ram ram = new Ram(4);
            IMotherboard motherboard = new Motherboard(ram, videoCard);
            Cpu cpu = new Cpu64Bit(2, motherboard, this.random);
            var hardDrive = new[]
            {
                new HardDrive(500, false, 0)
            };
            LaptopBattery battery = new LaptopBattery();
            ILaptopComputer laptop = new LaptopComputer(motherboard, cpu, ram, hardDrive, videoCard, battery);
            return laptop;
        }

        public override IServerComputer MakeSeverComputer()
        {
            Ram serverRam = new Ram(32);
            IVideoCard serverVideo = new MonochromeVideoCard();
            IMotherboard motherboard = new Motherboard(serverRam, serverVideo);
            var hardDrive = new List<HardDrive>
            {
                new HardDrive(
                    0,
                    true, 
                    2,
                    new List<HardDrive>
                    {
                        new HardDrive(1000, false, 0),
                        new HardDrive(1000, false, 0)
                    })
            };
            Cpu cpu = new Cpu32Bit(4, motherboard, this.random);

            IServerComputer server = new ServerComputer(motherboard, cpu, serverRam, hardDrive, serverVideo);
            return server;
        }
    }
}