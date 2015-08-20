namespace Computers.ComputerComponents
{ 
    public class Ram 
    {
        //private const int MAX_AMOUNT;
        private readonly int amount;

        private int value; 
        
        public Ram(int initialAmount) 
        {
            this.amount = initialAmount; 
        } 
        int Amount 
        {
            get
            {
                return this.amount;
            }
        } 
        public void SaveValue(int newValue) 
        { 
            value = newValue; 
        } 
        public int LoadValue() 
        { 
            return value; 
        } 
    } 
}