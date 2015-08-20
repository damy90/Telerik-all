namespace Computer.Tests
{
    using System;
    using Computers.ComputerParts;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class ChargeBatteryTests
    {
        [TestMethod]
        public void ChargeBatteryWith20PercentShouldReturn70()
        {
            var battery = new LaptopBattery();
            battery.ChargeBattery(20);
            Assert.AreEqual(70, battery.CurrentBatteryLife);
        }

        [TestMethod]
        public void ChargeBatteryWithMinus20PercentShouldReturn30()
        {
            var battery = new LaptopBattery();
            battery.ChargeBattery(-20);
            Assert.AreEqual(30, battery.CurrentBatteryLife);
        }

        [TestMethod]
        public void ChargeBatteryWith50PercentShouldReturn100()
        {
            var battery = new LaptopBattery();
            battery.ChargeBattery(50);
            Assert.AreEqual(100, battery.CurrentBatteryLife);
        }

        [TestMethod]
        public void ChargeBatteryWithMinus50PercentShouldReturn0()
        {
            var battery = new LaptopBattery();
            battery.ChargeBattery(-50);
            Assert.AreEqual(0, battery.CurrentBatteryLife);
        }

        [TestMethod]
        public void ChargeBatteryWith70PercentShouldReturn100()
        {
            var battery = new LaptopBattery();
            battery.ChargeBattery(70);
            Assert.AreEqual(100, battery.CurrentBatteryLife);
        }

        [TestMethod]
        public void ChargeBatteryWithMinus70PercentShouldReturn0()
        {
            var battery = new LaptopBattery();
            battery.ChargeBattery(-70);
            Assert.AreEqual(0, battery.CurrentBatteryLife);
        }
    }
}