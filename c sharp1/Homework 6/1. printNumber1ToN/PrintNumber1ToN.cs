using System;

class PrintNumber1ToN
{
    //Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n, on a single line, separated by a space.
    static void Main()
    {
        int number;
        Console.Title = "Find all numbers from 1 to N";

        Console.Write("Please enter number: ");
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out number))
                break;
            else
                Console.WriteLine("Please enter an integer number");
        }

        Console.WriteLine("The numbers from 1 to {0}:", number);
        if (number >= 1)
        {
            for (int i = 1; i <= number; i++)
                Console.Write(i + " ");
        }
        else if (number < 1)
        {
            for (int i = 1; i >= number; i--)
                Console.Write(i + " ");
        }
    }
}
