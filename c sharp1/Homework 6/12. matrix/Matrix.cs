using System;

class Matrix
{
    //Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix like in the examples below. Use two nested loops.
    static void Main()
    {
        Console.Title = "Matrix";
        uint number;
        Console.Write("Please enter first number: ");
        while (true)
        {
            if (uint.TryParse(Console.ReadLine(), out number) && number<=20)
                break;
            else
                Console.Write("Please enter a positive integer number less than 20: ");
        }

        for (int i = 1; i <= number; i++)
        {
            Console.WriteLine();
            for (int j = i; j <= i + number - 1; j++)
                Console.Write("{0}\t", j);
        }
        Console.WriteLine();
    }
}