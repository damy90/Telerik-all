namespace MobilePhone
{
    using System.Collections.Generic;

    class GSM
    {
        private static string iPhone4S = "Nice, but old phone :)";
        private List<Call> callHistory = new List<Call>();

        public GSM(string model, string manufacturer)
            : this(model: model, manufacturer: manufacturer,
            price: 0, owner: null, battery: new Battery(), display: new Display())
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
        }

        public GSM(string model, string manufacturer, decimal price, string owner, Battery battery, Display display)
        {
            this.Price = price;
            this.Owner = owner;
            this.Battery = battery;
            this.Display = display;
        }

        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public decimal Price { get; set; }
        public string Owner { get; set; }
        public Battery Battery { get; set; }
        public Display Display { get; set; }

        public Call AddCall(Call call)
        {
            this.callHistory.Add(call);
            return call;
        }

        public Call DelleteCall(Call call)
        {
            this.callHistory.Remove(call);
            return call;
        }

        public void ClearHistory()
        {
            this.callHistory.Clear();
        }

        public decimal CallPrice(decimal pricePerMinute)
        {
            decimal totalPrice = 0;
            foreach (var call in this.callHistory)
            {
                if (!call.ItsIncomming)
                {
                    totalPrice += ((decimal)(call.Duration()) / 60) * pricePerMinute;
                }
            }

            return totalPrice;
        }

        public static string IPhone4s
        {
            get
            {
                return iPhone4S;
            }
        }

        public override string ToString()
        {
            return this.Model + " " + this.Manufacturer + " " +
                this.Price + " " + this.Owner + " " + this.Battery.Model + " " + this.Display.Size;
        }
    }
}
