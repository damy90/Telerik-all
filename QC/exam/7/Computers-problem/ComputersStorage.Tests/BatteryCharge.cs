namespace ComputersStorage.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Computers.Api;
    using Computers;

    [TestClass]
    public class BatteryCharge
    {
        [TestMethod]
        public void ChargeBatteryWithZeroShouldReturnSameCharge()
        {
            LaptopBattery battery = new LaptopBattery();
            battery.Charge(0);

            Assert.AreEqual(50, battery.Percentage);
        }

        [TestMethod]
        public void ChargeBatteryWithBigNegativePercentShouldReturnZero()
        {
            LaptopBattery battery = new LaptopBattery();
            battery.Charge(-500);

            Assert.AreEqual(0, battery.Percentage);
        }

        [TestMethod]
        public void ChargeBatteryWithBigPositivePercentShouldReturnOneHundred()
        {
            LaptopBattery battery = new LaptopBattery();
            battery.Charge(+500);

            Assert.AreEqual(100, battery.Percentage);
        }

        [TestMethod]
        public void ChargeAndDischargeBatteryShouldWork()
        {
            LaptopBattery battery = new LaptopBattery();
            battery.Charge(-500);
            battery.Charge(24);
            battery.Charge(-1);

            Assert.AreEqual(23, battery.Percentage);
        }

        [TestMethod]
        public void MaxDischargeShouldReturnZero()
        {
            LaptopBattery battery = new LaptopBattery();
            battery.Charge(-10);
            battery.Charge(-24);
            battery.Charge(-16);
            battery.Charge(-5);

            Assert.AreEqual(0, battery.Percentage);
        }
        
        [TestMethod]
        public void OverChargeShouldReturnOneHundred()
        {
            LaptopBattery battery = new LaptopBattery();
            battery.Charge(10);
            battery.Charge(24);
            battery.Charge(16);
            battery.Charge(5);

            Assert.AreEqual(100, battery.Percentage);
        }
    }
}