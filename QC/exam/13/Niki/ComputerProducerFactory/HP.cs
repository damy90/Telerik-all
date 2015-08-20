namespace ComputersProgram.ComputerProducerFactory
{
    using System.Collections.Generic;

    internal class HP : AbstractComputerFactory
    {
        private const string BrandName = "HP";

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
            var ramMemory = new RAMMemory(4);
            var cpu = new Cpu(2, 64);
            var hdd = new[] { new HardDriver(500, false, 0) };
            var battery = new LaptopBattery();
            var laptop = new Computer("LAPTOP", cpu, ramMemory, hdd, videoCard, new LaptopBattery());

            return laptop;
        }

        public override Computer MakePC()
        {
            var ramMemory = new RAMMemory(2);
            var videoCard = new ColorVideoCard();
            var cpu = new Cpu(2, 32);
            var hdd = new[] { new HardDriver(500, false, 0) };
            var pc = new Computer("PC", cpu, ramMemory, hdd, videoCard, null);

            return pc;
        }

        public override Computer MakeServer()
        {
            var serverRam = new RAMMemory(2);
            var serverVideo = new MonochromeVideoCard();
            var cpu = new Cpu(4, 32);
            var hdd = new List<HardDriver>
                          {
                              new HardDriver(
                                  0,
                                  true,
                                  2,
                                  new List<HardDriver>
                                      {
                                          new HardDriver(1000, false, 0),
                                          new HardDriver(1000, false, 0)
                                      })
                          };

            var server = new Computer("SERVER", cpu, serverRam, hdd, serverVideo, null);

            return server;
        }
    }
}
