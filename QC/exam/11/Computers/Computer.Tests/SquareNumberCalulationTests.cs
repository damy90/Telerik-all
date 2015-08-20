namespace Computer.Tests
{
    using Computers.ComputerParts.Processor;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class SquareNumberCalulationTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var processor = new CentralProcessingUnitWith32Bits(4);
            processor.CalculateSquareNumber();
        }
    }
}
