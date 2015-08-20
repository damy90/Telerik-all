using System;

class Worker : Human
{
    private float weekSalary;
    private int workhoursPerDay;

    public Worker(string name, string lastName, float weekSalary, int workhoursPerDay)
        : base(name, lastName)
    {
        this.WeekSalary = weekSalary;
        this.WorkhoursPerDay = workhoursPerDay;
    }

    public float WeekSalary
    {
        get
        {
            return this.weekSalary;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Salary must be a positive number");
            }
            this.weekSalary = value;
        }
    }

    public int WorkhoursPerDay
    {
        get
        {
            return this.workhoursPerDay;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Work hours must be a positive number");
            }
            this.workhoursPerDay = value;
        }
    }

    public float MoneyPerHour()
    {
        return (this.weekSalary / 7) / this.workhoursPerDay;
    }
}