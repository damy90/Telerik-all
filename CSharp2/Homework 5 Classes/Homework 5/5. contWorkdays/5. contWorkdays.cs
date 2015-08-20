using System;
//Write a method that calculates the number of workdays between today and given date, passed as parameter.
//Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.
class Program
{
    static readonly int[,] holidays =
    {
    {
        1,
        1
    },
    {
        2,
        29
    }, //leap year holiday
    {
        6,
        18
    },
    {
        10,
        30
    }
    };

    static void Main()
    {
        //the holidays are random and made up
        DateTime today = DateTime.Now.Date;//the clock must be set to 0 with ".Date" before comparing to other dates.
        DateTime endDate= new DateTime(2015,10,10);

        if (endDate < today)
        {
            today = endDate;
            endDate = DateTime.Now.Date;
        }

        CountWorkDays(today, endDate);
    }

    private static int CountWorkDays(DateTime today, DateTime endDate)
    {
        int period = (endDate - today).Days;

        //count the days in the timespan without Saturday and Sunday
        int workdays = 0;
        for (int i = 0; i < period; i++)
        {
            DateTime checkDay = today.AddDays(i);
            if (checkDay.DayOfWeek != DayOfWeek.Saturday && checkDay.DayOfWeek != DayOfWeek.Sunday)
                workdays++;
        }
        Console.WriteLine(workdays);
        
        //substract holydays
        for (int i = 0; i < holidays.GetLength(0); i++)
            for (int year = today.Year; year <= endDate.Year; year++)
            {
                DateTime holiday;
                //check and skip invalid dates (29 february for non leap years and other dates if any)
                try
                {
                    holiday = new DateTime(year, holidays[i, 0], holidays[i, 1]);
                }
                catch (ArgumentOutOfRangeException)
                {
                    continue;
                }
                if (holiday >= today && holiday <= endDate && holiday.DayOfWeek != DayOfWeek.Saturday && holiday.DayOfWeek != DayOfWeek.Sunday)
                    workdays--;
            }

        return workdays;
    }
}
