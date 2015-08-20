namespace ComputerBuildingSystem
{
    public class Laptop : Computer
    {
        public Laptop(LaptopBattery battery, CPU cpu, RAM ram, HardDriver hardDriver, IDrawable videoCard)
            : base(cpu, ram, hardDriver, videoCard)
        {
            this.Battery = battery;
        }

        public LaptopBattery Battery { get; set; }

        public void ChargeBattery(int percentage)
        {
            this.Battery.Charge(percentage);

            VideoCard.Draw(string.Format("Battery status: {0}%", this.Battery.Percentage));
        }
    }
}
