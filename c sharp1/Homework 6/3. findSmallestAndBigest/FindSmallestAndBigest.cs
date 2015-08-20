using System;

class FindSmallestAndBigest
{
    //Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
    //The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
    static void Main()
    {
        Console.Title = "Find the bigest and smalest out of N numbers";

        int count = 0;
        Console.Write("Please enter count: ");
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out count) && count > 1)
                break;
            Console.Write("Please enter a positive integer number: ");
        }

        int max = int.MinValue;
        int min = int.MaxValue;
        int sum = 0;
        for (int i = 0; i < count; i++)
        {
            int number;
            while (true)
            {
                Console.Write("Please enter number {0}: ", i + 1);
                if (int.TryParse(Console.ReadLine(), out number))
                    break;
                Console.WriteLine("Invalid input");
            }

            sum += number;
            if (number > max)
                max = number;
            if (number < min)
                min = number;
        }

        float avg = (float)sum / count;
        Console.WriteLine("min = {0}\nmax = {1}\nsum = {2}\navg = {3:0.00}", min, max, sum, avg);
    }
}