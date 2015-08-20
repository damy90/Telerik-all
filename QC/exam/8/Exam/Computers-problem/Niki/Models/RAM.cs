namespace Computers.UI.Console
{
    public class RAM
    {
        internal RAM(int amount)
        {
            this.Amount = amount;
        }

        int Amount { get; set; }

        int Value { get; set; }

        internal void SaveValue(int newValue)
        {
            this.Value = newValue;
        }

        internal int LoadValue()
        {
            return this.Value;
        }
    }
}