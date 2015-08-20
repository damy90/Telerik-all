namespace DefiningClasses
{
    using System;

    public class Battery
    {
        private string batteryModel;
        private double hoursIdle;
        private double hoursTalk;
        private BatteryTypes batteryType;


        public Battery(string model) : this(model, 100.0, 10.0, BatteryTypes.LiIon) { }

        //Empty constructor, setting "Standard", 100 and 10 as the
        //default values for the model, hours idle and hours talk
        //property type added for Task 3 
        public Battery() : this("Standard", 100.0, 10.0, BatteryTypes.LiIon) { }

        //Full constructor taking 3 parameters - model, hours idle and hours talk
        public Battery(string model, double idle, double talk, BatteryTypes type)
        {
            this.BatteryModel = model;
            this.HoursIdle = idle;
            this.HoursTalk = talk;
            this.Type = type;
        }


        public string BatteryModel
        {
            get { return batteryModel; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ApplicationException("Battery model can NOT be null or empty!");
                }
                this.batteryModel = value;
            }
        }

        public double HoursIdle
        {
            get { return hoursIdle; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Hours idle value cannot be a negtive number!");
                }
                this.hoursIdle = value;
            }
        }

        public double HoursTalk
        {
            get { return hoursTalk; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Hours talk value cannot be a negtive number!");
                }
                this.hoursTalk = value;
            }
        }

        public BatteryTypes Type
        {
            get { return this.batteryType; }
            private set {this.batteryType = value;}
        }
    }

    

}
