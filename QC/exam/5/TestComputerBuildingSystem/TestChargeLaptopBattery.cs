namespace TestComputerBuildingSystem
{
    using ComputerBuildingSystem;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class TestChargeLaptopBattery
    {
        [TestMethod]
        public void MustReturnDefaultPercentage50()
        {
            var laptopBattery = new LaptopBattery();
            var expected = laptopBattery.Percentage;
            Assert.AreEqual(50, expected);
        }

        [TestMethod]
        public void ChargeBateryWithMinPower()
        {
            var laptopBattery = new LaptopBattery();
            laptopBattery.Charge(-100);
            var expected = laptopBattery.Percentage;
            Assert.AreEqual(0, expected);
        }

        [TestMethod]
        public void ChargeBateryWithMorePower()
        {
            var laptopBattery = new LaptopBattery();
            laptopBattery.Charge(1000);
            var expected = laptopBattery.Percentage;
            Assert.AreEqual(100, expected);
        }

        [TestMethod]
        public void ChargeBateryReturnExactPower60()
        {
            var laptopBattery = new LaptopBattery();
            laptopBattery.Charge(10);
            var expected = laptopBattery.Percentage;
            Assert.AreEqual(60, expected);
        }
    }
}
