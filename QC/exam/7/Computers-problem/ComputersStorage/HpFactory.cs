﻿namespace Computers.Api
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class HpFactory
    {
        private const int DefaultRamSize = 8;
        private const int ThirtyTwoBitsArchitecture = 32;

        public static Computer GetComputer(ComputerType computerType)
        {
            RamMemory ram;
            VideoCard videoCard;
            Cpu cpu;

            switch (computerType)
            {
                case ComputerType.Pc:
                    {
                        ram = new RamMemory(DefaultRamSize / 4);
                        videoCard = new VideoCard()
                        {
                            IsMonochrome = false
                        };

                        cpu = new Cpu(DefaultRamSize / 4, ThirtyTwoBitsArchitecture, ram);
                        var computerHardDrivers = new[] { new HardDriver(500, false, 0, null) };
                        return new Computer(computerType, cpu, ram, computerHardDrivers, videoCard, null);
                    }

                case ComputerType.Server:
                    {
                        ram = new RamMemory(DefaultRamSize * 4);
                        videoCard = new VideoCard();
                        cpu = new Cpu(DefaultRamSize / 2, ThirtyTwoBitsArchitecture, ram);
                        var serverHardDrivers = new List<HardDriver> { new HardDriver(0, true, 2, new List<HardDriver> { new HardDriver(1000, false, 0, null), new HardDriver(1000, false, 0, null) }) };

                        return new Computer(computerType, cpu, ram, serverHardDrivers, videoCard, null);
                    }

                case ComputerType.Laptop:
                    {
                        ram = new RamMemory(DefaultRamSize / 2);
                        videoCard = new VideoCard()
                        {
                            IsMonochrome = false
                        };
                        cpu = new Cpu(DefaultRamSize / 4, ThirtyTwoBitsArchitecture * 2, ram);
                        var laptopHardDriver = new[] { new HardDriver(500, false, 0, null) };

                        return new Computer(computerType, cpu, ram, laptopHardDriver, videoCard, new LaptopBattery());
                    }

                default:
                    throw new ArgumentException();
            }
        }
    }
}