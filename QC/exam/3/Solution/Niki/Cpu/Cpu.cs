namespace Computers
{
    using System;
    using Interfaces;

    public abstract class Cpu
    {
        private readonly byte numberOfBits;
        private readonly Random random;
        private IMotherboard motherboard;

        public Cpu(byte numberOfCores, byte numberOfBits, IMotherboard motherboard, Random random)
        {
            // TODO: validate.
            this.numberOfBits = numberOfBits;
            this.NumberOfCores = numberOfCores;
            this.motherboard = motherboard;
            this.random = random;
        }

        public byte NumberOfCores { get; set; }

        protected abstract int MinAllowedValue { get; }

        protected abstract int MaxAllowedValue { get; }

        public void SquareNumber()
        {
            var data = this.motherboard.LoadRamValue();
            if (data < this.MinAllowedValue)
            {
                this.motherboard.DrawOnVideoCard("Number too low.");
                return;
            }

            if (data > this.MaxAllowedValue)
            {
                this.motherboard.DrawOnVideoCard("Number too high.");
                return;
            }

            int value = 0;
            for (int i = 0; i < data; i++)
            {
                value += data;
            }

            this.motherboard.DrawOnVideoCard(string.Format("Square of {0} is {1}.", data, value));
        }

        public void GenerateRandomNumber(int minValue, int maxValue)
        {
            int randomNumber = this.random.Next(minValue, maxValue + 1);
            this.motherboard.SaveRamValue(randomNumber);
        }
    }
}
