namespace Computers.UI.Console.AbstractComputerFactory
{
    using Computers.UI.Console.Models;
    using System;
    using System.Collections.Generic;

    public class HPComputerFactory : IComputerFactory
    {
        private const byte LaptopCpuBits = 64;
        private const byte LaptopCpuCores = 2;
        private const byte LaptopRam = 4;
        private const int LaptopHardDriveCapacity = 500;

        private const byte ServerCpuBits = 32;
        private const byte ServerCpuCores = 4;
        private const byte ServerRam = 32;
        private const int ServerHardDriveCapacity = 1000;
        private const byte ServerNumberOfHardDrives = 2;

        private const byte PcCpuBits = 64;
        private const byte PcCpuCores = 4;
        private const byte PcRam = 8;
        private const int PcHardDriveCapacity = 1000;

        public ILaptop GetLaptop()
        {
            var cpu = new CPU(LaptopCpuCores, LaptopCpuBits);
            var ram = new RAM(LaptopRam);
            var hardDrive = new HardDrive(LaptopHardDriveCapacity, false);
            var videoCard = new VideoCard(false);
            var battery = new LaptopBattery();
            var hardDrives = new List<HardDrive>();
            hardDrives.Add(hardDrive);

            return new Laptop(cpu, ram, hardDrives, videoCard, battery);
        }

        public IServer GetServer()
        {
            var cpu = new CPU(ServerCpuCores, ServerCpuBits);
            var ram = new RAM(ServerRam);
            var hardDrive = new HardDrive(ServerHardDriveCapacity, true);
            var videoCard = new VideoCard(true);
            var hardDrives = new List<HardDrive>();
            for (int i = 0; i < ServerNumberOfHardDrives; i++)
            {
                hardDrives.Add(hardDrive);
            }

            return new Server(cpu, ram, hardDrives, videoCard);
        }

        public IPersonalComputer GetPersonalComputer()
        {
            var cpu = new CPU(PcCpuCores, LaptopCpuBits);
            var ram = new RAM(PcRam);
            var hardDrive = new HardDrive(PcHardDriveCapacity, false);
            var videoCard = new VideoCard(false);
            var hardDrives = new List<HardDrive>();
            hardDrives.Add(hardDrive);

            return new PersonalComputer(cpu, ram, hardDrives, videoCard);
        }
    }
}
