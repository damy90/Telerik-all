/*Problem 3. Min, Max, Sum and Average of N Numbers

Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
The output is like in the examples below.*/

using System;
class MinMaxSumAverageN
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int max = int.MinValue;
        int min = int.MaxValue;
        double sum = 0;
        double avg = 0;

        for (int i = 0; i < n; i++)
        {
            int x = int.Parse(Console.ReadLine());
            if (x > max)
            {
                max = x;
            }
            if (x < min)
            {
                min = x;
            }
            sum += x;

        }
        avg = sum / n;

        Console.WriteLine("Min is {0}", min);
        Console.WriteLine("Max is {0}", max);
        Console.WriteLine("Sum is {0}", sum);
        Console.WriteLine("Avg is {0:0.00}", avg);
    }
}