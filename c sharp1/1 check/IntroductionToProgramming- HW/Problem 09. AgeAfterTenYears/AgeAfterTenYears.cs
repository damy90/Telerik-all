//Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.

using System;

class AgeAfterTenYears
{
    static void Main()
    {
        Console.Write("Please enter your birthday (dd.MM.yyyy): ");
        DateTime birthday = DateTime.Parse(Console.ReadLine());
        int currentAge = DateTime.Today.Year - birthday.Year;
        if (DateTime.Today.Month < birthday.Month)
        {
            currentAge = currentAge - 1;
        }

        Console.WriteLine("Your current age: {0}", currentAge);
        Console.WriteLine("Your age after ten years: {0}", currentAge + 10);
    }
}

