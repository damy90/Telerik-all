using System;

class SortNumbers
{
    //Write a program that enters 3 real numbers and prints them sorted in descending order.
    //Use nested if statements.

    static void Main()
    {
        Console.Title = "Find the bigest number";

        Console.Write("Please enter 1-st number: ");
        int number1 = int.Parse(Console.ReadLine());
        Console.Write("Please enter 2-nd number: ");
        int number2 = int.Parse(Console.ReadLine());
        Console.Write("Please enter 3-th number: ");
        int number3 = int.Parse(Console.ReadLine());

        int memory;
        if (number1 > number2)
        {
            memory = number1;
            number1 = number2;
            number2 = memory;
        }
        if (number1 > number3)
        {
            memory = number1;
            number1 = number3;
            number3 = memory;
        }
        if (number2 > number3)
        {
            memory = number2;
            number2 = number3;
            number3 = memory;
        }
        Console.WriteLine("Numbers in decending order: {2}, {1}, {0}", number1, number2, number3);
    }
}