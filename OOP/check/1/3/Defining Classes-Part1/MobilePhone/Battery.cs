namespace MobilePhone
{
    internal class Battery
    {
        public Battery()
            :this(model:null,hoursIdle:0,hoursTalk:0,batteryType:0)
        {
            
        }

        public Battery(string model, double hoursIdle, double hoursTalk, BatteryType batteryType)
        {
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
            this.BatteryType = batteryType;
        }

        public string Model { get; set; }
        public double HoursIdle { get; set; }
        public double HoursTalk { get; set; }
        public BatteryType BatteryType { get; set; }
    }
}
