//Write an expression that checks if given integer is odd or even.

using System;

class IfOdd
{
    static void Main()
    {
        int number;
        Console.Title = "Check if a number is odd or even";
        Console.Write("Please enter a number:\t");
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("This number is {0}", (number % 2 == 0) ? "even" : "odd");
                break;
            }
            else
            {
                Console.WriteLine("\nPlease enter an integer number");
            }
        }
    }
}

