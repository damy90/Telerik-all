namespace DefiningClasses
{
    using System;
    using System.Collections.Generic;

    public class GSM
    {
        //fields
        private string model;
        private string manufacturer;
        private decimal price;
        private string owner;
        private Battery battery;
        private Display display = new Display();
        private static GSM iPhone4S = new GSM("iPhone4S", "Apple");
        private List<Call> callHistory;


        //problem 2
        //Constructor taking only manifacturer and model as parameters, setting all others to some default values
        public GSM(string model, string manufacturer)
            : this(model, manufacturer, 100.0m, "Pesho", new Battery(), new Display(), new List<Call>())
        {
            this.Manufacturer = manufacturer;
            this.Model = model;
        }

        //Constructor with full set of arguments
        public GSM(string model, string manufacturer, decimal price, string owner, Battery battery, Display display, List<Call> callHistory)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.Battery = battery;
            this.Display = display;
            this.CallHistory = new List<Call>();
        }

        public override string ToString()
        {
            return String.Format("Manifacturer: {0}\n" +
                                 "Model: {1}\n" +
                                 "Price: {2}\n" +
                                 "Owner: {3}\n" +
                                 "Battery: {4}\n" +
                                 "Display: {5}",
                                 this.Manufacturer, this.Model, this.Price, this.Owner,
                                 this.Battery.ToString(), this.Display.ToString());
        }

        //Properties encapsulating the data fields
        public static GSM IPhone4S
        {
            get { return GSM.iPhone4S; }
        }

        public string Model
        {
            get { return model; }
            private set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException("The model value must be at least two characters long!");
                }
                this.model = value;
            }
        }

        public string Manufacturer
        {
            get { return manufacturer; }
            private set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException("The model value must be at least two characters long!");
                }
                this.manufacturer = value;
            }
        }

        public decimal Price
        {
            get { return price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Price cannot be a negative number!");
                }
                this.price = value;
            }
        }
        public string Owner
        {
            get { return owner; }
            set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException("The model value must be at least two characters long!");
                }
                this.owner = value;
            }
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

        //Problem 9. Add a property CallHistory
        public List<Call> CallHistory
        {
            get { return callHistory; }
            private set { this.callHistory = value; }
        }

        //Problem 10. Add/Remove/Clear
        public void Add(Call newCall)
        {
            this.CallHistory.Add(newCall);
        }
        public void Delete(Call call)
        {
            this.CallHistory.Remove(call);
        }
        public void ClearHistory()
        {
            this.CallHistory.Clear();
        }

        //Problem 11. Call price
        public decimal CalculateTotalPrice(decimal pricePerMin)
        {
            int totalDuration = 0;

            for (int i = 0; i < this.callHistory.Count; i++)
            {
                totalDuration += callHistory[i].Duration;
            }

            decimal totalPrice = totalDuration * pricePerMin;
            return totalPrice;
        }

        public string PrintCallHistory()
        {
            return string.Format("Calls history:\n{0}", string.Join(Environment.NewLine, new List<Call>(this.callHistory)));
        }
    }
}
