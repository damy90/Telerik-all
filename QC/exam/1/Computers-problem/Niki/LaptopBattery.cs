namespace ComputerBuildingSystem
{
    public class LaptopBattery
    {
        public LaptopBattery()
        {
            this.Percentage = 100 / 2;
        }

        public int Percentage { get; set; }

        public void Charge(int percentege)
        {
            this.Percentage += percentege;
            if (this.Percentage > 100)
            {
                this.Percentage = 100;
            }

            if (this.Percentage < 0)
            {
                this.Percentage = 0;
            }
        }
    }
}
