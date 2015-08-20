namespace DefiningClassesPartOne
{
    using System;

    public class Call           //problem 8
    {
        private DateTime dateTime;
        private string dialedPhone;
        private int duration;

        public Call(DateTime dateTime, string dialedPhone, int duration)
        {
            this.Date = dateTime;
            this.DialedPhone = dialedPhone;
            this.Duration = duration;
        }

        public DateTime Date
        {
            get { return this.dateTime; }

            private set { this.dateTime = value;} 
        }

        public string DialedPhone 
        {
            get { return this.dialedPhone; }

            private set 
            {
                if (value.Length != 10)
                {
                    throw new ArgumentException("Length of phone number must be 10 symbols");
                }
                this.dialedPhone = value; 
            }
        }

        public int Duration 
        {
            get { return this.duration; }

            private set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("Duration cannot be negative number");
                }
                this.duration = value; 
            }
        }

        public override string ToString()
        {
            return string.Format("Date and time: {0:G}, Duration: {1} min., Dialed phone number: {2}", this.Date, this.Duration,
                this.DialedPhone);
        }
    }
}

    


