// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LaptopBatteryTests.cs" company="">
//   
// </copyright>
// <summary>
//   The laptop battery tests.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ComputersTests
{
    using Computers.Battery;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// The laptop battery tests.
    /// </summary>
    [TestClass]
    public class LaptopBatteryTests
    {
        #region Public Methods and Operators

        /// <summary>
        /// The battery should return 0 when under charged.
        /// </summary>
        [TestMethod]
        public void BatteryShouldReturn0WhenUnderCharged()
        {
            var battery = new LaptopBattery();
            battery.Charge(-1000);
            int result = battery.Percentage;
            Assert.AreEqual(0, result);
        }

        /// <summary>
        /// The battery should return 100 when over charged.
        /// </summary>
        [TestMethod]
        public void BatteryShouldReturn100WhenOverCharged()
        {
            var battery = new LaptopBattery();
            battery.Charge(1000);
            int result = battery.Percentage;
            Assert.AreEqual(100, result);
        }

        /// <summary>
        /// The battery should return 30 when discharged with 20.
        /// </summary>
        [TestMethod]
        public void BatteryShouldReturn30WhenDischargedWith20()
        {
            var battery = new LaptopBattery();
            battery.Charge(-20);
            int result = battery.Percentage;
            Assert.AreEqual(30, result);
        }

        /// <summary>
        /// The battery should return 50 when created.
        /// </summary>
        [TestMethod]
        public void BatteryShouldReturn50WhenCreated()
        {
            var battery = new LaptopBattery();
            int result = battery.Percentage;
            Assert.AreEqual(50, result);
        }

        /// <summary>
        /// The battery should return 70 when charged with 20.
        /// </summary>
        [TestMethod]
        public void BatteryShouldReturn70WhenChargedWith20()
        {
            var battery = new LaptopBattery();
            battery.Charge(20);
            int result = battery.Percentage;
            Assert.AreEqual(70, result);
        }

        #endregion
    }
}