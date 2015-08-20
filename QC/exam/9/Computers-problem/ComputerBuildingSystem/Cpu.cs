namespace ComputerBuildingSystem
{
    using System;

    public class Cpu
    {
        private readonly IMotherboard motherBoeard;
        private readonly CpuStrategy cpuStrategy;

        public Cpu(CpuStrategy cpuStrategy, byte numberOfCores, IMotherboard motherBoeard)
        {
            this.cpuStrategy = cpuStrategy;
            this.NumberOfCores = numberOfCores;
            this.motherBoeard = motherBoeard;
        }

        private byte NumberOfCores { get; set; }

        public void SquareNumber(int value)
        {
            int square = 0;
            square = this.cpuStrategy.SquareNumber(value);

            if (square == -2)
            {
                this.motherBoeard.DrawOnVideoCard("Number too low.");
            }
            else if (square == -1)
            {
                this.motherBoeard.DrawOnVideoCard("Number too high.");
            }
            else
            {
                this.motherBoeard.DrawOnVideoCard(string.Format("Square of {0} is {1}.", value, square));
            }
        }

        public void GetRandomNumber(int minValue, int maxValue)
        {
            Random random = new Random();
            int randomNumber = 0;
            randomNumber = random.Next(minValue, maxValue + 1);

            this.motherBoeard.SaveRamValue(randomNumber);
        }
    }
}
