using Computers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computers.Manufacturers
{
    class LenovoManufacturer : Manufacturer, IComputerManufacturer
    {
        public LenovoManufacturer(Random random)
            : base(random)
        {
        }

        public override IPersonalComputer MakePersonalComputer()
        {
            var ram = new Ram(4);
            var videoCard = new MonochromeVideoCard();
            var hardDrive = new[] { new HardDrive(2000, false, 0) };
            IMotherboard motherboard = new Motherboard(ram, videoCard);
            Cpu cpu = new Cpu64Bit(2, motherboard, this.random);

            var result = new PersonalComputer(motherboard, cpu, ram, hardDrive, videoCard);
            return result;
        }

        public override ILaptopComputer MakeLaptopComputer()
        {
            IVideoCard videoCard = new ColorVideoCard();
            Ram ram = new Ram(16);
            IMotherboard motherboard = new Motherboard(ram, videoCard);
            Cpu cpu = new Cpu64Bit(2, motherboard, this.random);
            var hardDrive = new[]
            {
                new HardDrive(1000, false, 0)
            };
            LaptopBattery battery = new LaptopBattery();
            ILaptopComputer laptop = new LaptopComputer(motherboard, cpu, ram, hardDrive, videoCard, battery);
            return laptop;
        }

        public override IServerComputer MakeSeverComputer()
        {
            Ram serverRam = new Ram(8);
            IVideoCard serverVideo = new MonochromeVideoCard();
            IMotherboard motherboard = new Motherboard(serverRam, serverVideo);
            var hardDrive = new List<HardDrive>
            {
                new HardDrive(500, false, 0),
                new HardDrive(500, false, 0)
            };
            Cpu cpu = new Cpu128Bit(2, motherboard, this.random);

            IServerComputer server = new ServerComputer(motherboard, cpu, serverRam, hardDrive, serverVideo);
            return server;
        }
    }
}
