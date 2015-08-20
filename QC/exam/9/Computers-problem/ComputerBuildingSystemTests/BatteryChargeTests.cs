using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ComputerBuildingSystem;

namespace ComputerBuildingSystemTests
{
    [TestClass]
    public class BatteryChargeTests
    {
        [TestMethod]
        public void BatteryCreationWith50PercentTest()
        {
            var battery = new Battery();
            Assert.AreEqual(50, battery.Percentage);
        }
        
        [TestMethod]
        public void BatteryChargeWith0Test()
        {
            var battery = new Battery();
            battery.Charge(0);
            Assert.AreEqual(50, battery.Percentage);
        }
        [TestMethod]
        public void BatteryChargeWith1Test()
        {
            var battery = new Battery();
            battery.Charge(1);
            Assert.AreEqual(51, battery.Percentage);
        }
        [TestMethod]
        public void BatteryChargeWith100Test()
        {
            var battery = new Battery();
            battery.Charge(100);
            Assert.AreEqual(100, battery.Percentage);
        }

        [TestMethod]
        public void BatteryChargeWith50Test()
        {
            var battery = new Battery();
            battery.Charge(50);
            Assert.AreEqual(100, battery.Percentage);
        }

        [TestMethod]
        public void BatteryChargeWithNegative100Test()
        {
            var battery = new Battery();
            battery.Charge(-100);
            Assert.AreEqual(0, battery.Percentage);
        }
    }
}
