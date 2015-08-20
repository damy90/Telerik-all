namespace Computers.ComputerParts
{
    public class LaptopBattery : Battery
    {
        private const int InitialBatteryPower = 50;

        public LaptopBattery()
            : base(InitialBatteryPower)
        {
        }
    }
}