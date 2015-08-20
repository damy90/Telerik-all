namespace ComputersProgram
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class TestBattery
    {
        [TestMethod]
        public void TestinitialCharge()
        {
            LaptopBattery battery = new LaptopBattery();
            Assert.AreEqual(50, battery.Percentage);
        }

        [TestMethod]
        public void TestFullUnload()
        {
            LaptopBattery battery = new LaptopBattery();
            battery.Charge(-50);
            Assert.AreEqual(0, battery.Percentage);
        }

        [TestMethod]
        public void TestForNegativValue()
        {
            LaptopBattery battery = new LaptopBattery();
            battery.Charge(-51);
            Assert.AreEqual(0, battery.Percentage);
        }

        [TestMethod]
        public void TestForMaxCharge()
        {
            LaptopBattery battery = new LaptopBattery();
            battery.Charge(50);
            Assert.AreEqual(100, battery.Percentage);
        }

        [TestMethod]
        public void TestForUpLimitValue()
        {
            LaptopBattery battery = new LaptopBattery();
            battery.Charge(51);
            Assert.AreEqual(100, battery.Percentage);
        }

        [TestMethod]
        public void TestWithZe0rCharge()
        {
            LaptopBattery battery = new LaptopBattery();
            battery.Charge(0);
            Assert.AreEqual(50, battery.Percentage);
        }
    }
}
