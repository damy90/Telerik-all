//1. Define a class that holds information about a mobile phone device: model, manufacturer, price, owner, battery characteristics (model, hours idle and hours talk) and display characteristics (size and number of colors).
//Define 3 separate classes (class GSM holding instances of the classes Battery and Display).
//2. Define several constructors for the defined classes that take different sets of arguments (the full information for the class or part of it).
//Assume that model and manufacturer are mandatory (the others are optional). All unknown data fill with null.
//4. Use properties to encapsulate the data fields inside the GSM, Battery and Display classes.
//Ensure all fields hold correct data at any given time.
//5. Use properties to encapsulate the data fields inside the GSM, Battery and Display classes.
//Ensure all fields hold correct data at any given time.
//6. Add a static field and a property IPhone4S in the GSM class to hold the information about iPhone 4S.
//9. Add a property CallHistory in the GSM class to hold a list of the performed calls.
//Try to use the system class List<Call>
//10. Add methods in the GSM class for adding and deleting calls from the calls history.
//Add a method to clear the call history.
//11. Add a method that calculates the total price of the calls in the call history.
//Assume the price per minute is fixed and is provided as a parameter.
using System;
using System.Collections.Generic;
using System.Text;

class GSM
{
    private string model;
    private string manufacturer;
    private decimal? price;  //nullable decimal
    private string owner;
    private Battery battery;
    private Display display;
    private static GSM IPhone4S;//why?
    private List<Call> callHistory=new List<Call>();

    public GSM(string model, string manufacturer, decimal? price = null, string owner = "", Battery battery = null, Display display = null)
    {
        this.Model = model;
        this.Manufacturer = manufacturer;
        this.price = price;
        this.owner = owner;
        this.battery = battery;
        this.display = display;
    }

    public List<Call> CallHistory
    {
        get
        {
            return this.callHistory;
        }
    }

    public static GSM GetIPhone()
    {
        if (IPhone4S == null)
        {
            var iBattery = new Battery("Samsung Ultra Durable", 12.5f, 2, BatteryType.LiIon);   //a patented portable pack of electrical energy invented by Apple
            var iDisplay = new Display(4, 16);    //with a patented rectangular shape designed by Apple
            IPhone4S = new GSM("IPhony 4S", "Aple", 2999.99m, null, iBattery, iDisplay);
        }

        return IPhone4S;
    }

    public string Model
    {
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Device model is mandatory and cannot be null or empty!");
            }

            this.model = value;
        }
    }

    public string Manufacturer
    {
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Device manufacturer is mandatory and cannot be null or empty!");
            }

            this.manufacturer = value;
        }
    }

    public decimal? Price
    {
        set
        {
            if (value != null && value < 0)
            {
                throw new ArgumentOutOfRangeException("Price must be non negative!");
            }

            this.price = value;
        }
    }

    public string Owner
    {
        set
        {
            this.owner = value;
        }
    }

    public Battery Battery
    {
        set
        {
            this.battery = value;
        }
    }

    public Display Display
    {
        set
        {
            this.display = value;
        }
    }

    public void AddCall(DateTime time, string phone, int duradion)
    {
        Call call = new Call(time, phone, duradion);
        callHistory.Add(call);
    }

    public void AddCall(Call call)
    {
        callHistory.Add(call);
    }

    public void DelCall(int index)
    {
        callHistory.RemoveAt(index);
    }

    public void DelCall(Call call)
    {
        callHistory.Remove(call);
    }

    public void ClearCallHistory()
    {
        callHistory=new List<Call>();
    }

    public decimal Bill(decimal price)
    {
        decimal money=0;
        foreach (Call call in callHistory)
        {
            int minutes;
            if (call.Duration % 60 > 0)
                minutes = call.Duration / 60 + 1;
            else
                minutes = call.Duration / 60;
            money += minutes * price;
        }
        return money;
    }

    public override string ToString()
    {
        var result = new StringBuilder();
        result.Append(string.Format("\nModel: {0}\nManufacturer: {1}\nPrice: {2}\nOwner: {3}",
            model,
            manufacturer,
            this.price != null ? this.price.ToString() + "$" : "unspecified",
            !string.IsNullOrEmpty(this.owner) ? this.owner : "unspecified"));

        if (this.battery != null)
        {
            result.Append(string.Format("\nHours idle: {0}\nHours talk: {1}\nBattery type: {2}\nBattery model: {3}",
                this.battery.HoursIdle != null ? this.battery.HoursIdle.ToString() + " h" : "unspecified",
                this.battery.HoursTalk != null ? this.battery.HoursTalk.ToString() + " h" : "unspecified",
                this.battery.Type != null ? this.battery.Type.ToString() : "unspecified",
                this.battery.Model != null ? this.battery.Model.ToString() : "unspecified"));
        }

        if (this.display != null)
        {
            result.Append(string.Format("\nDisplay size: {0}\nDisplay colors: {1}",
                this.display.Size != null ? this.display.Size.ToString() + "'" : "unspecified",
                this.display.Colors != null ? this.display.Colors.ToString() : "unspecified"));
        }

        return result.ToString();
    }
}
