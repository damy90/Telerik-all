using System;
using System.Globalization;
//Write a program that reads a date and time given in the format: day.month.year hour:minute:second and
//prints the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.
class Program
{
    static void Main()
    {
        string input = "27.02.2006 22:00:00";

        //input = Console.ReadLine();

        DateTime dateAndTime = DateTime.ParseExact(input, "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture);
        TimeSpan timeSpan = new TimeSpan(06, 30, 0);
        DateTime output = dateAndTime.Add(timeSpan);
        string day = output.ToString("dddd", new CultureInfo("bg-BG"));
        string date = output.ToString("dd.MM.yyyy HH:mm:ss");
        Console.WriteLine("{0} {1}", day, date);
    }
}
