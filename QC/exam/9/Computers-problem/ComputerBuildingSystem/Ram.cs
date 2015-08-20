namespace ComputerBuildingSystem
{
    public class Ram
    {
        private int value;

        public Ram(int amount)
        {
            this.MaxAmount = amount;
        }

        public int Value
        {
            get { return this.value; }
            set { this.value = value; }
        }

        public int MaxAmount
        {
            get;
            set;
        }

        public void SaveValue(int newValue)
        {
            this.Value = newValue;
        }

        public int LoadValue()
        {
            return this.Value;
        }
    }
}