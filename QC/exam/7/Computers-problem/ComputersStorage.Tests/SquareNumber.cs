namespace ComputersStorage.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Computers.Api;

    [TestClass]
    public class SquareNumber
    {
        [TestMethod]
        public void SquareOfFiveShouldReturn25()
        {
            var ram = new RamMemory(8);
            ram.SaveValue(5);
            var cpu = new Cpu(4, 32, ram);
            Assert.AreEqual("Square of 5 is 25.", cpu.SquareNumber());
        }

        [TestMethod]
        public void SquareOfZeroShouldReturnZero()
        {
            var ram = new RamMemory(8);
            ram.SaveValue(0);
            var cpu = new Cpu(4, 32, ram);
            Assert.AreEqual("Square of 0 is 0.", cpu.SquareNumber());
        }

        [TestMethod]
        public void UsingInvalidCpuShouldReturnInvalid()
        {
            var ram = new RamMemory(8);
            ram.SaveValue(0);
            var cpu = new Cpu(4, 86, ram);
            Assert.AreEqual("Invalid CPU", cpu.SquareNumber());
        }

        [TestMethod]
        public void SquareOf1000ShouldReturn1000000()
        {
            var ram = new RamMemory(8);
            ram.SaveValue(1000);
            var cpu = new Cpu(4, 64, ram);
            Assert.AreEqual("Square of 1000 is 1000000.", cpu.SquareNumber());
        }
        
        [TestMethod]
        public void SquareOf1001ShouldReturnTooLong()
        {
            var ram = new RamMemory(8);
            ram.SaveValue(1001);
            var cpu = new Cpu(4, 64, ram);
            Assert.AreEqual("Number too high.", cpu.SquareNumber());
        }


        [TestMethod]
        public void SquareOfNegativeNumberShouldReturnTooLow()
        {
            var ram = new RamMemory(8);
            ram.SaveValue(-1001);
            var cpu = new Cpu(4, 64, ram);
            Assert.AreEqual("Number too low.", cpu.SquareNumber());
        }
    }
}