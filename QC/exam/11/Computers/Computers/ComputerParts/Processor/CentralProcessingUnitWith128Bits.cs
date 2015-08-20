namespace Computers.ComputerParts.Processor
{
    public class CentralProcessingUnitWith128Bits : CentralProcessingUnit
    {
        private const int NumberOfBitsFor128BitProcessor = 128;
        private const int MaxNumberToCalculateSquare = 2000;

        public CentralProcessingUnitWith128Bits(byte numberOfCores)
            : base(numberOfCores, NumberOfBitsFor128BitProcessor)
        {
        }

        public override void CalculateSquareNumber()
        {
            var data = this.Motherboard.LoadRamValue();

            if (data < 0)
            {
                this.Motherboard.DrawOnVideoCard("Number too low.");
            }
            else if (data > MaxNumberToCalculateSquare)
            {
                this.Motherboard.DrawOnVideoCard("Number too high.");
            }
            else
            {
                base.CalculateSquareNumber();
            }
        }
    }
}
