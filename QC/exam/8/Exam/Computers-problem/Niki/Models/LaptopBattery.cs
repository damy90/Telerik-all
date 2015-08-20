namespace Computers.UI.Console
{
    public class LaptopBattery
    {
        private const int DefaultChargePercentage = 50;
        private const int MaxChargePercentage = 100;
        private const int MinChargePercentage = 0;

        private int percentageCharged;

        internal LaptopBattery()
        {
            this.PercentageCharged = DefaultChargePercentage;
        }

        internal int PercentageCharged
        {
            get
            {
                return this.percentageCharged;
            }

            private set
            {
                if (value > MaxChargePercentage) 
                {
                    this.percentageCharged = MaxChargePercentage;
                }

                if (value < MinChargePercentage)
                {
                    this.percentageCharged = MinChargePercentage;
                }

                this.percentageCharged = value;
            }
        }

        internal void Charge(int chargePercentage)
        {
            this.PercentageCharged = this.PercentageCharged + chargePercentage;
        }
    }
}
