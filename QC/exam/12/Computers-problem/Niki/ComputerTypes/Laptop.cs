namespace Computers.ComputerTypes
{
    using Computers.Contracts;

    public class Laptop : Computer
    {
        private LaptopBattery battery;

        public Laptop(Cpu cpu, Ram ram, IStorageDevice hardDrives, VideoCard videoCard, LaptopBattery battery)
            : base(cpu, ram, hardDrives, videoCard)
        {
            this.battery = battery;
        }

        internal void ChargeBattery(int percentage)
        {
            this.battery.Charge(percentage);

            this.VideoCard.Draw(string.Format("Battery status: {0}%", this.battery.Percentage));
        }
    }
}
