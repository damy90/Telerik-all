using System;
//Write a program that reads a year from the console and checks whether it is a leap.
class Program
{
    static void Main()
    {
        Console.Write("Please enter an year: ");
        int year = int.Parse(Console.ReadLine());
        Console.WriteLine("{0} is leap year: {1}", year, DateTime.IsLeapYear(year));
    }
}
