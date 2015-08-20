using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ComputerBuildingSystem;

namespace ComputerBuildingSystemTests
{
    [TestClass]
    public class CpuGetRandomNumberTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var cpu = new Cpu(new Cpu32(), 2, new Motherboard(new Ram(2), new VideoCard()));
            
        }
    }
}
