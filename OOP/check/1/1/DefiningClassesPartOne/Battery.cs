namespace DefiningClassesPartOne
{

    using System;

    public class Battery                //problem 1
    {
        private string model;
        private double hoursIdle;
        private double hoursTalk;
        private BatteryTypes batteryType;

        public Battery(string model, double hoursIdle, double hoursTalk, BatteryTypes type)
        {
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
            this.BatteryType = batteryType;
        }

        public string Model 
        {
            get { return this.model; }

            private set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    value = "Invalid value";
                }
                this.model = value;
            } 
        }

        public double HoursIdle 
        {
            get { return this.hoursIdle;}

            private set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException ("The value must be positive");
                }

                this.hoursIdle = value;
            } 
        }

        public double HoursTalk
        {
            get { return this.hoursTalk; }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The value must be positive");
                }

                this.hoursTalk = value;
            }
        }

        public BatteryTypes BatteryType 
        {
            get { return this.batteryType; }

            private set { this.batteryType = value; }
        }

        public override string ToString()
        {
            return string.Format("Model: {0}, Hours idle: {1}, Hours talk: {2}, Type: {3}",
                this.Model, this.HoursIdle, this.HoursTalk, this.BatteryType);
        }
    }
}

        
    
        


