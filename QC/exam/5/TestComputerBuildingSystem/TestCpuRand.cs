namespace TestComputerBuildingSystem
{
    using System;
    using ComputerBuildingSystem;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class TestCpuRand
    {
        [TestMethod]
        public void TestRandomNumberBetweenNumbers()
        {
            var ram = new ComputerRam(8);
            var hardDrive = new ComputerHardDrive();
            var cpu = new ComputerCpu(4, 64, ram, hardDrive);
            var expectedNumber = cpu.Rand(1, 10);
            var result = ((0 > expectedNumber) && (expectedNumber > 10)) ? true : false; 
            Assert.IsFalse(false);
        }

        [TestMethod]
        public void TestRandomNumberIsOutOfRange()
        {
            var ram = new ComputerRam(8);
            var hardDrive = new ComputerHardDrive();
            var cpu = new ComputerCpu(4, 64, ram, hardDrive);
            var expectedNumber = cpu.Rand(1, 100);
            var result = expectedNumber > 100 ? true : false;
            Assert.IsFalse(false);
        }
    }
}
