namespace ComputersProgram.ComputerProducerFactory
{
    using System.Collections.Generic;

    internal class Dell : AbstractComputerFactory
    {
        private const string BrandName = "Dell";

        public string Name
        {
            get
            {
                return BrandName;
            }
        }

        public override Computer MakeLaptop()
        {
            var videoCard = new ColorVideoCard();
            var ramMemory = new RAMMemory(8);
            var cpu = new Cpu(4, 32);
            var hdd = new[] { new HardDriver(1000, false, 0) };
            var battery = new LaptopBattery();
            var laptop = new Computer("LAPTOP", cpu, ramMemory, hdd, videoCard, new LaptopBattery());

            return laptop;
        }

        public override Computer MakePC()
        {
            var ramMemory = new RAMMemory(8);
            var videoCard = new ColorVideoCard();
            var cpu = new Cpu(4, 64);
            var hdd = new[] { new HardDriver(1000, false, 0) };
            var pc = new Computer("PC", cpu, ramMemory, hdd, videoCard, null);

            return pc;
        }

        public override Computer MakeServer()
        {
            var serverRam = new RAMMemory(64);
            var serverVideo = new MonochromeVideoCard();
            var cpu = new Cpu(8, 64);
            var hdd = new List<HardDriver>
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
            var server = new Computer("SERVER", cpu, serverRam, hdd, serverVideo, null);

            return server;
        }
    }
}
