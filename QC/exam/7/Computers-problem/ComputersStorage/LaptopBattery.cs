namespace Computers.Api
{
    public class LaptopBattery
    {
        public const int MaxCharge = 100;
        public const int MinCharge = 0;

        public LaptopBattery()
        {
            this.Percentage = MaxCharge / 2;
        }

        public int Percentage { get; set; }

        public void Charge(int p)
        {
            this.Percentage += p;
            if (this.Percentage > MaxCharge)
            {
                this.Percentage = MaxCharge;
            }
            else if (this.Percentage < MinCharge)
            {
                this.Percentage = MinCharge;
            }
        }
    }
}