﻿namespace ComputerBuildingSystem
{
    using System.Collections.Generic;

    public class DellManufacturer : Manufacturer
    {
        private const byte PCNumberOfCores = 4;
        private const byte PCBits = 64;
        private const byte PCRAMAmount = 8;
        private const short PCHardDriveCapacity = 1000;

        private const byte ServerNumberOfCores = 8;
        private const byte ServerBits = 64;
        private const byte ServerRAMAmount = 64;
        private const short ServerHardDriveCapacityPerUnit = 2000;

        private const byte LaptopNumberOfCores = 4;
        private const byte LaptopBits = 32;
        private const byte LaptopRAMAmount = 8;
        private const short LaptopCapacity = 1000;

        public override PC GetPC()
        {
            var ram = new RAM(PCRAMAmount);
            var hardDrive = new HardDriver(PCHardDriveCapacity);
            var videoCard = new ColorfulVideoCard();
            var motherboard = new Motherboard(ram, videoCard);
            var cpu = new CPU(PCNumberOfCores, PCBits, motherboard);
            PC pc = new PC(cpu, ram, hardDrive, videoCard);
            return pc;
        }

        public override Server GetServer()
        {
            var ram = new RAM(ServerRAMAmount);
            var hardDrives = new List<HardDriver>() { new HardDriver(ServerHardDriveCapacityPerUnit), new HardDriver(ServerHardDriveCapacityPerUnit) };
            var raid = new HardDriver(hardDrives);
            var videoCard = new MonochromeVideoCard();
            var motherboard = new Motherboard(ram, videoCard);
            var cpu = new CPU(ServerNumberOfCores, ServerBits, motherboard);
            Server server = new Server(cpu, ram, raid, videoCard);
            return server;
        }

        public override Laptop GetLaptop()
        {
            var ram = new RAM(LaptopRAMAmount);
            var hardDrive = new HardDriver(LaptopCapacity);
            var videoCard = new ColorfulVideoCard();
            var battery = new LaptopBattery();
            var motherboard = new Motherboard(ram, videoCard);
            var cpu = new CPU(LaptopNumberOfCores, LaptopBits, motherboard);
            Laptop laptop = new Laptop(battery, cpu, ram, hardDrive, videoCard);
            return laptop;
        }

        public override void GetAllProducts(out PC pc, out Server server, out Laptop laptop)
        {
            pc = this.GetPC();
            server = this.GetServer();
            laptop = this.GetLaptop();
        }
    }
}
