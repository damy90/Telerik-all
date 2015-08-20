namespace Computers.ComputerParts
{
    public class RamMemory : ComputerPart
    {
        private int integerValue;

        public RamMemory(int amount)
            : base(ComputerPartType.RamMemory)
        {
            this.Amount = amount;
        }

        public int Amount { get; set; }

        public void SaveValue(int newValue)
        {
            this.integerValue = newValue;
        }

        public int LoadValue()
        {
            return this.integerValue;
        }
    }
}