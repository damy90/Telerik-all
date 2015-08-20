namespace TestComputerBuildingSystem
{
    using System;
    using ComputerBuildingSystem;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class TestCpuSquareNumber
    {
        [TestMethod]
        public void TestCpuReturnExactCoreAndNumberOfBits()
        {
            var ram = new ComputerRam(8);
            var hardDrive = new ComputerHardDrive();
            var cpu = new ComputerCpu(4, 64, ram, hardDrive);
            cpu.SquareNumber64();
            var cores = cpu.NumberOfCores;
            Assert.AreEqual(4, cores);
        }
    }
}
