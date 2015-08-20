namespace Computers.UI.Console.Models
{
    using Computers.UI.Console.AbstractComputerFactory;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Laptop : Computer, IComputer, ILaptop
    {        
        public Laptop(CPU cpu, RAM ram, IEnumerable<HardDrive> hardDrives, VideoCard videoCard, LaptopBattery battery)
            : base(cpu, ram, hardDrives, videoCard)
        {
            this.Battery = battery;
        }

        public LaptopBattery Battery { get; set; }

        public string ChargeBattery(int percentage)
        {
            Battery.Charge(percentage);
            return string.Format("Battery status: {0}", Battery.Percentage);
        }
    }
}
