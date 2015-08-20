namespace ComputersProgram
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class TestCpuRandom
    {
        [TestMethod]
        public void TestRange()
        {
            int a = 1;
            int b = 10;
            Cpu cpu = new Cpu(2, 64);
            bool wasOutOfRange = false;
            for (int i = 0; i < 10; i++)
            {
                int rnd = cpu.GenerateRndInteger(a, b);
                if (rnd < a || rnd > b)
                {
                    wasOutOfRange = true;
                }
            }

            Assert.AreEqual(false, wasOutOfRange);
        }

        [TestMethod]
        public void TestForNotGettingTheSameNumber()
        {
            int a = 1;
            int b = 10;
            Cpu cpu = new Cpu(2, 128);
            int counter = 0;
            int currNumber = int.MinValue;
            for (int i = 0; i < 3; i++)
            {
                int rnd = cpu.GenerateRndInteger(a, b);
                if (rnd == currNumber)
                {
                    counter++;
                }
            }
            bool equality = false;
            if (counter == 2)
            {
                equality = true;
            }

            Assert.AreEqual(false, equality);
        }
    }
}
