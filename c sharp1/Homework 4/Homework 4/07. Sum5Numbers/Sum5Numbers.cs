using System;

class Sum5Numbers
{
    //Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.

    static void Main()
    {
        Console.WriteLine("Please enter 5 number separated by a space!");
        string[] numbers = Console.ReadLine().Split(' ');

        float sum = 0;
        foreach (string number in numbers)
        {
            sum += float.Parse(number);
        }

        Console.WriteLine("The sum is: {0}", sum);
    }
}
