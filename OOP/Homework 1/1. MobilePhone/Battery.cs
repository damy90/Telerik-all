using System;

public enum BatteryType
{
    LiIon,
    NiMH,
    NiCd
}

class Battery
{
    private string model;
    private float? hoursIdle;
    private float? hoursTalk;
    private BatteryType? type;

    public Battery(string model, float? hoursIdle = null, float? hoursTalk = null, BatteryType? type = null)
    {
        this.model = model;
        this.hoursIdle = hoursIdle;
        this.hoursTalk = hoursTalk;
        this.type = type;
    }

    public string Model
    {
        get
        {
            return this.model;
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Device model is mandatory and cannot be null or empty!");
            }

            this.model = value;
        }
    }

    public float? HoursIdle
    {
        get
        {
            return this.hoursIdle;
        }
        set
        {
            this.hoursIdle = value;
        }
    }

    public float? HoursTalk
    {
        get
        {
            return this.hoursTalk;
        }
        set
        {
            this.hoursTalk = value;
        }
    }

    public BatteryType? Type
    {
        get
        {
            return this.type;
        }
        set
        {
            this.type = value;
        }
    }
}
