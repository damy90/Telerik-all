namespace Computers.ComputerParts.Processor
{
    public class CentralProcessingUnitWith32Bits : CentralProcessingUnit
    {
        private const int NumberOfBitsFor32BitProcessor = 32;
        private const int MaxNumberToCalculateSquare = 500;

        public CentralProcessingUnitWith32Bits(byte numberOfCores)
            : base(numberOfCores, NumberOfBitsFor32BitProcessor)
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
