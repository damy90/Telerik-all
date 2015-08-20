using Computers.Interfaces;

namespace Computers.ComputerParts
{
    public abstract class Battery : IChargeable
    {
        private const int MaxBatteryLife = 100;
        private const int MinBatteryLife = 0;

        public Battery(int percentage)
        {
            this.CurrentBatteryLife = percentage;
        }

        public int CurrentBatteryLife { get; set; }

        public void ChargeBattery(int percentageIncrease)
        {
            this.CurrentBatteryLife += percentageIncrease;

            if (this.CurrentBatteryLife > MaxBatteryLife)
            {
                this.CurrentBatteryLife = MaxBatteryLife;
            }
            else if (this.CurrentBatteryLife < MinBatteryLife)
            {
                this.CurrentBatteryLife = MinBatteryLife;
            }
        }
    }
}
