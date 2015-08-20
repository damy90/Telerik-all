//8. Create a class Call to hold a call performed through a GSM.
//It should contain date, time, dialled phone number and duration (in seconds).

using System;

class Call
{
    private DateTime time;
    private string phone;
    private int duration;

    public Call(DateTime time, string phone, int duration)
    {
        this.time = time;
        this.phone = phone;
        this.duration = duration;
    }
    public DateTime Time
    {
        get
        {
            return this.time;
        }
        set
        {
            this.time = value;
        }
    }

    public string Phone
    {
        get
        {
            return this.phone;
        }
        set
        {
            this.phone = value;
        }
    }

    public int Duration
    {
        get
        {
            return this.duration;
        }
        set
        {
            this.duration = value;
        }
    }
}
