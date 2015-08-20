namespace ComputerBuildingSystem.Computers
{
    using System.Collections.Generic;
    using ComputerBuildingSystem.Interfaces;

    public class Laptop : Computer, ILaptop
    {
        private Battery battery;

        public Laptop(Cpu cpu, Ram ram, VideoCard videoCard, HardDriver hdd, IEnumerable<HardDriver> hardDrives, Battery battery)
            : base(cpu, ram, videoCard, hdd, hardDrives)
        {
            this.Battery = battery;
        }

        public Battery Battery
        {
            get
            {
                return this.battery;
            }

            set
            {
                this.battery = value;
            }
        }

        // TODO: Check this line [Obsolete("")]
        public void ChargeBattery(int percentage)
        {
            this.battery.Charge(percentage);
            this.VideoCard.Draw(string.Format("Battery status: {0}%", this.battery.Percentage));
        }
    }
}
