namespace ComputersProgram
{
    internal class RAMMemory
    {
        private int value;

        internal RAMMemory(int a)
        {
            this.Amount = a;
        }

        private int Amount { get; set; }

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