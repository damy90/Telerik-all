namespace Computers
{
    public class Ram
    {
        private int value;

        public Ram(int amount)
        {
            // TODO: validate
            this.Amount = amount;
        }

        public int Amount { get; private set; }

        public void SaveValue(int newValue)
        {
            this.value = newValue;
        }

        public int LoadValue()
        {
            return this.value;
        }
    }
}
