//Create a console application that prints the current date and time.

using System;

class CurrentDateAndtime
{
    static void Main()
    {
        DateTime currentDate = DateTime.Now.Date;
        TimeSpan currentTime = DateTime.Now.TimeOfDay;
        Console.WriteLine("The current date is {0}", currentDate.ToString("dd.MM.yyy"));
        Console.WriteLine("The current time is {0}", currentTime);
    }
}

