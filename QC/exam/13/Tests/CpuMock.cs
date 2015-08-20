namespace ComputersProgram
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Telerik.JustMock;

    [TestClass]
    public class CpuMock
    {
        protected void CPUMock()
        {
            int a = 1;
            int b = 10;
            Cpu cpu = Mock.Create<Cpu>();
            Mock.Arrange(() => cpu.NumberOfBits).Returns(32);
            Mock.Arrange(() => cpu.GenerateRndInteger(a, b)).Returns(cpu.GenerateRndInteger(a, b));
        }

    }
}