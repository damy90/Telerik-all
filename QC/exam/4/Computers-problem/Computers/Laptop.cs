namespace Computers
{
    using System.Collections.Generic;
    using ComputerComponents;
    using Enumarations;
    using Interfaces;

    public class Laptop : Computer, ILaptop, IComputer
    {
        private readonly LaptopBatery battery;

        public Laptop(ICpu initialCpu, Ram initialRam, IEnumerable<HardDrive> initialHardDrives, IVideoCard initialVideoCard, LaptopBatery battery) 
            : base(ComputerType.Laptop, initialCpu, initialRam, initialHardDrives, initialVideoCard)
        {
            this.battery = battery;
        }

        public void ChargeBattery(int percentage)
        {
            this.battery.Charge(percentage);

            this.Cpu.Motherboard.DrawOnVideoCard(string.Format("Battery status: {0}", this.battery.Percentage));
        }
    }
}
