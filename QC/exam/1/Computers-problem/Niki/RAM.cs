namespace ComputerBuildingSystem
{
    public class RAM 
    { 
        public RAM(int amount)
        {
            this.Amount = amount;
        } 

        public int Amount { get; set; }

        public void SaveValue(int newValue)
        {
            this.Amount = newValue; 
        }

        public int LoadValue()
        {
            return this.Amount;
        }
    }
}