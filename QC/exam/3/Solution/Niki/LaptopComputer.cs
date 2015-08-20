namespace Computers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Interfaces;

    public class LaptopComputer : Computer, ILaptopComputer
    {
        private readonly Battery.LaptopBattery battery;

        public LaptopComputer(IMotherboard motherboard, Cpu cpu, Ram ram, IEnumerable<HardDrive> hardDrives, IVideoCard videoCard, Battery.LaptopBattery battery)
            : base(ComputerType.LAPTOP, motherboard, cpu, ram, hardDrives, videoCard)
        {
            this.battery = battery;
        }

        public void ChargeBattery(int percentage)
        {
            this.battery.Charge(percentage);
            this.Motherboard.DrawOnVideoCard(string.Format("Battery status: {0}", this.battery.Percentage));
        }
    }
}
