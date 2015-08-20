using System;

class PrintNumber1ToNnotDivisable
{
    //Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n not divisible by 3 and 7, on a single line, separated by a space.
    static void Main()
    {
        Console.Title = "Find all numbers from 1 to N that are not divisible by 3 and 7 at the same time";

        int number;
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
                if (i % 3 != 0 && i % 7 != 0)
                    Console.Write(i + " ");
        }
        else if (number < 1)
        {
            for (int i = 1; i >= number; i--)
                if (i % 3 != 0 && i % 7 != 0)
                    Console.Write(i + " ");
        }
    }
}
