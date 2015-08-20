using System;
using System.Globalization;
//Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.
class CountDays
{
    static void Main()
    {
        string firstDateInput = "27.2.2006";
        string secondDateInput = "3.3.2006";

        //firstDateInput = Console.ReadLine();
        //secondDateInput = Console.ReadLine();

        DateTime startDate = DateTime.ParseExact(firstDateInput, "d.M.yyyy", CultureInfo.InvariantCulture);
        DateTime endDate = DateTime.ParseExact(secondDateInput, "d.M.yyyy", CultureInfo.InvariantCulture);

        Console.WriteLine(Math.Abs((endDate - startDate).TotalDays));
    }
}
