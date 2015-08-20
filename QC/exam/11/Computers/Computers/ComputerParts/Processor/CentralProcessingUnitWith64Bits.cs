namespace Computers.ComputerParts.Processor
{
    public class CentralProcessingUnitWith64Bits : CentralProcessingUnit
    {
        private const int NumberOfBitsFor64BitProcessor = 64;
        private const int MaxNumberToCalculateSquare = 1000;

        public CentralProcessingUnitWith64Bits(byte numberOfCores)
            : base(numberOfCores, NumberOfBitsFor64BitProcessor)
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
