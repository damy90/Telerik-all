namespace Computers.Api
{
    public class RamMemory
    {
        private int savedValue;

        public RamMemory(int amount)
        {
            this.Amount = amount;
        }

        private int Amount { get; set; }

        public void SaveValue(int newValue)
        {
            this.savedValue = newValue;
        }

        public int LoadValue()
        {
            return this.savedValue;
        }
    }
}