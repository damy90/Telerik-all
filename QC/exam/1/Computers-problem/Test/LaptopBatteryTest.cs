// <copyright company=my> Test</copyright>
// Comment
// -----
namespace Test
{
    using System;
    using ComputerBuildingSystem;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]

    /// <summary>
    /// blah blah blah
    /// </summary>
    public class LaptopBatteryTest
    {
        /// <summary>
        /// blah blah blah
        /// </summary>
        [TestMethod]
        public void ChargeBatteryOverOneHundredReturnsOneHundred()
        {
            LaptopBattery battery = new LaptopBattery();
            battery.Charge(200);
            Assert.AreEqual(battery.Percentage, 100);
        }

        /// <summary>
        /// blah blah blah
        /// </summary>
        [TestMethod]
        public void ChargeBatteryUnderZeroReturnsZero()
        {
            LaptopBattery battery = new LaptopBattery();
            battery.Charge(-200);
            Assert.AreEqual(battery.Percentage, 0);
        }

        /// <summary>
        /// blah blah blah
        /// </summary>
        [TestMethod]
        public void ChargeBatteryNormalCharging()
        {
            LaptopBattery battery = new LaptopBattery();
            battery.Charge(20);
            Assert.AreEqual(battery.Percentage, 70);
        }
    }
}
