namespace ComputerBuildingSystem
{
    public class ComputerRam
    {
        private int amount;

        public ComputerRam(int amount)
        {
            this.Amount = amount;
        }

        public int Amount
        {
            get
            {
                return this.amount;
            }

            set
            {
                this.amount = value;
            }
        }
        
        public void SaveValue(int newValue)
        {
            this.amount = newValue;
        }

        public int LoadValue()
        {
            return this.amount;
        }
    }
}