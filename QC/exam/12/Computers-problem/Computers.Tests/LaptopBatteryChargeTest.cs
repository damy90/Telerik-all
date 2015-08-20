namespace Computers.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class LaptopBatteryChargeTest
    {
        private LaptopBattery battery;

        [TestInitialize]
        public void Initializations()
        {
            this.battery = new LaptopBattery();
        }

        [TestMethod]
        public void OverchargingBatteryResultsInFullBattery()
        {
            this.battery.Charge(200);

            var actual = this.battery.Percentage;
            int expected = 100;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void UnderchargingBatteryResultsInEmptyBattery()
        {
            this.battery.Charge(-200);

            var actual = this.battery.Percentage;
            int expected = 0;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Adding25resultsin75percentCharge()
        {
            this.battery.Charge(25);

            var actual = this.battery.Percentage;
            int expected = 75;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Removing20resultsin30percentCharge()
        {
            this.battery.Charge(-20);

            var actual = this.battery.Percentage;
            int expected = 30;
            Assert.AreEqual(expected, actual);
        }
    }
}
