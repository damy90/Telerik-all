namespace Computers.ComputerComponents
{
    using Interfaces;

    public class LaptopBatery : IBattery
    {
        public LaptopBatery() 
        { 
            this.Percentage = 100 / 2; 
        }

        public int Percentage { get; set; }

        public void Charge(int percentage)
        {
            this.Percentage += percentage;

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
