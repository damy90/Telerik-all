namespace DefiningClasses
{
    using System;

    public class Call
    {
        //fields
        private DateTime date;
        private string dialedPhoneNumber;
        private int duration;

        //Constructor
        public Call(DateTime date, string dialedPhoneNumber, int duration)
        {
            this.Date = date;
            this.DialedPhoneNumber = dialedPhoneNumber;
            this.Duration = duration;
        }
        //Properties
        public DateTime Date
        {
            get { return this.date; }
            private set { this.date = value; }
        }

        public string DialedPhoneNumber
        {
            get { return this.dialedPhoneNumber; }
            private set { this.dialedPhoneNumber = value; }
        }

        public int Duration
        {
            get { return this.duration; }
            private set { this.duration = value; }
        }

        public override string ToString()
        {
            return string.Format("Date and time: {0:G}; Duration: {1} seconds;\nDialed number: {2}",
                this.date, this.duration, this.dialedPhoneNumber);
        }
    }
}
