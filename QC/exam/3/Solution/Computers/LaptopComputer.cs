using Computers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computers
{
    public class LaptopComputer : Computer, ILaptopComputer
    {
        private readonly LaptopBattery battery;

        public LaptopComputer(IMotherboard motherboard, Cpu cpu, Ram ram, IEnumerable<HardDrive> hardDrives, IVideoCard videoCard, LaptopBattery battery)
            : base(ComputerType.LAPTOP, motherboard, cpu, ram, hardDrives, videoCard)
        {
            this.battery = battery;
        }

        public void ChargeBattery(int percentage)
        {
            this.battery.Charge(percentage);
            this.Motherboard.DrawOnVideoCard(string.Format("Battery status: {0}", battery.Percentage));
        }
    }
}
