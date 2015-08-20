namespace MobilePhone
{
    using System;

    class Call
    {
        private TimeSpan duration;

        public DateTime TimeStart { get; set; }
        public DateTime TimeEnd { get; set; }
        public string PhoneNumber { get; set; }
        public bool ItsIncomming { get; set; }

        public double Duration()
        {
            this.duration = this.TimeEnd - this.TimeStart;
            return this.duration.TotalSeconds;
        }

    }
}
