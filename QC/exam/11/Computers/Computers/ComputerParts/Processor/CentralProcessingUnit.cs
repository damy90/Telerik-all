namespace Computers.ComputerParts.Processor
{
    using System;

    public abstract class CentralProcessingUnit : ComputerPart
    {
        public CentralProcessingUnit(byte numberOfCores, byte numberOfBits)
            : base(ComputerPartType.CentralProcessingUnit)
        {
            this.NumberOfCores = numberOfCores;
            this.NumberOfBits = numberOfBits;
        }

        protected byte NumberOfCores { get; set; }

        protected byte NumberOfBits { get; private set; }

        public virtual void CalculateSquareNumber()
        {
            var data = this.Motherboard.LoadRamValue();

            long value = data * data;

            this.Motherboard.DrawOnVideoCard(string.Format("Square of {0} is {1}.", data, value));
        }

        public int GenerateRondomNumber(int minValue, int maxValue, Random randomGenerator)
        {
            int randomNumber = randomGenerator.Next(minValue, maxValue + 1);

            this.Motherboard.SaveRamValue(randomNumber);

            return randomNumber;
        }
    }
}