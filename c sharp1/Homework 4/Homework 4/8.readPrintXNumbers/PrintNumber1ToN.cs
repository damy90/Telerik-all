using System;

class PrintNumber1ToN
{
    //Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line.

    static void Main()
    {
        int number;
        Console.Title = "Find all numbers from 1 to n";
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
                Console.WriteLine(i);
        }
        else if (number < 1)
        {
            for (int i = 1; i >= number; i--)
                Console.WriteLine(i);
        }
        else
            Console.WriteLine(1);
    }
}
