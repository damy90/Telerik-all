namespace DefiningClassesPartOne
{
    using System;
    using System.Collections.Generic;

    public class GSM                //problem 1, 2, 4, 5
    {
        private const double pricePerMinute = 0.37;                                                          //problem 11
        private string model;
        private string manufacturer;
        private decimal price;
        private string owner;
        private Battery battery;
        private Display display;

        private static GSM iPhone4S;                                        //problem 6
        private List<Call> callHistory = new List<Call>();                   //problem 9

        public GSM()
        {

        }

        public GSM(string model, string manufacturer) : this(model, manufacturer, 0.0m, null, null, null)
        {
            this.Model = model;                                                 //constructor with mandatory fields
            this.Manufacturer = manufacturer;
        }
            
        public GSM(string model, string manufacturer, decimal price, string owner, Battery battery, Display display)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;                                   //full constructor
            this.Price = price;
            this.Owner = owner;
            this.Battery = battery;
            this.Display = display;
        }

        static GSM()                         //problem 6
        {
            IPhone4S = new GSM("iPhone4S", "Apple", 800.00m, "Me", new Battery("579C-E2380", 200.00, 10.00, BatteryTypes.LiIon),
                                 new Display(3.5, 16000000));
        }

        public string Model 
        {
            get { return this.model; }

            private set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The model is a mandatory field");
                }
                this.model = value; 
            }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }

            private set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The manufacturer is mandatory field");
                }
                this.manufacturer = value;
            }
        }

        public decimal Price
        {
            get { return this.price; }
            
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The value of price must be positive");
                }

                this.price = value;
            }
        }

        public string Owner
        {
            get { return this.owner; }

            private set { this.owner = value; }
        }

        public Battery Battery 
        {
            get { return this.battery; }

            private set { this.battery = value; }
        }

        public Display Display 
        {
            get { return this.display; }

            private set { this.display = value; } 
        }


        public static GSM IPhone4S                          //problem 6
        {
            get { return iPhone4S; }

            private set { iPhone4S = value; }  
        }

        public List<Call> CallHistory                           //problem 9
        {
            get { return this.callHistory; } 
        }

        public void AddCalls(Call newCall)
        {                                                           //problem 10
            this.callHistory.Add(newCall);
        }

        public void RemoveCalls(Call removeCall)
        {                                                           //problem 10
            this.callHistory.Remove(removeCall);
        }

        public void ClearHistory()
        {
            this.callHistory.Clear();                               //problem 10
        }

        public double CalculationCallsTotalPrice(double pricePerMinute)                 //problem 11
        {
            double totalPrice = 0;

            foreach (Call call in callHistory)
            {
                totalPrice += (call.Duration * pricePerMinute);
            }
            
            return totalPrice;
        }
        
        public override string ToString()                   //problem 4
        {
            string strPrice = price.ToString();
            
            return string.Format("Model: {0}\nManufacturer: {1}\nPrice: {2}\nOwner: {3}\nBattery: {4}\nDisplay: {5}\n",
                this.Model, this.Manufacturer, strPrice, this.Owner, this.Battery, this.Display);
        }
    }
}
            

           


           
       


            
            



            

        


        
        

