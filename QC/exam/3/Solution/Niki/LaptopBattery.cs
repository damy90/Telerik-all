namespace Computers.Battery
{
    using System;

    public class LaptopBattery
    {
        private const int InitialCapacity = 50;

        public LaptopBattery()
        {
            // TODO: Bottleneck? 100 / 2
            this.Percentage = InitialCapacity;
        }

        public int Percentage { get; private set; }

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
