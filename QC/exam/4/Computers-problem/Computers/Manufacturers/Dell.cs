﻿namespace Computers.Manufacturers
{
    using System;
    using System.Collections.Generic;
    using ComputerComponents;
    using Enumarations;
    using Interfaces;

    public class Dell : IManufacturer
    {
        public IComputer Manufacture(ComputerType type)
        {
            if (type == ComputerType.Laptop)
            {
                return this.ManufactureLaptop();
            }
            else if (type == ComputerType.PC)
            {
                return this.ManufacturePC();
            }
            else
            {
                return this.ManufactureServer();
            }
        }

        private IComputer ManufacturePC()
        {
            Ram ram = new Ram(8);
            HardDrive hardDrive = new HardDrive(1000, false, 0);
            IEnumerable<HardDrive> hardDrives = new List<HardDrive>() { hardDrive };
            IVideoCard videoCard = new ColorfulVideoCard();
            ICpu cpu = new Cpu(4, CpuType.Bits64, new Motherboard(ram, videoCard));
            IComputer pc = new PersonalComputer(cpu, ram, hardDrives, videoCard);

            return pc;
        }
        
        private IComputer ManufactureServer()
        {
            Ram ram = new Ram(64);
            HardDrive firstHardDrive = new HardDrive(2000, true, 2);
            HardDrive secondHardDrive = new HardDrive(2000, true, 2);
            IEnumerable<HardDrive> hardDrives = new List<HardDrive>() { firstHardDrive, secondHardDrive };
            IVideoCard videoCard = new MonochromeVideoCard();
            ICpu cpu = new Cpu(8, CpuType.Bits64, new Motherboard(ram, videoCard));
            IComputer server = new Server(cpu, ram, hardDrives, videoCard);

            return server;
        }

        private IComputer ManufactureLaptop()
        {
            Ram ram = new Ram(8);
            HardDrive hardDrive = new HardDrive(1000, false, 0);
            IEnumerable<HardDrive> hardDrives = new List<HardDrive>() 
            {
                hardDrive
            };

            IVideoCard videoCard = new ColorfulVideoCard();
            LaptopBatery battery = new LaptopBatery();
            ICpu cpu = new Cpu(4, CpuType.Bits32, new Motherboard(ram, videoCard));
            IComputer laptop = new Laptop(cpu, ram, hardDrives, videoCard, battery);

            return laptop;
        }
    }
}
