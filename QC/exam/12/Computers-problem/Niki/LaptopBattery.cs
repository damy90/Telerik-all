namespace Computers
{
    public class LaptopBattery
    {
        private const int StartingCharge = 50;
        
        public LaptopBattery() 
        { 
            this.Percentage = StartingCharge;
        }

        public int Percentage { get; private set; }

        public void Charge(int p)
        {
            this.Percentage += p;
            
            if (this.Percentage > 100) 
            { 
                this.Percentage = 100; 
            }
            else if (this.Percentage < 0) 
            { 
                this.Percentage = 0; 
            }
        }
    }
}
