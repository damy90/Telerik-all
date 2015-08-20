/*Problem 5. Calculate 1 + 1!/X + 2!/X^2 + … + N!/X^N

Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
Use only one loop. Print the result with 5 digits after the decimal point.*/

using System;
class CalculateNXN
{
    static void Main()
    {
        Console.Write("Enter n: ");
        double n = double.Parse(Console.ReadLine());
        Console.Write("Enter x: ");
        double x = double.Parse(Console.ReadLine());

        double factorial = 1;
        double result = 1;

        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
            result += factorial / Math.Pow(x, i);
        }

        Console.WriteLine("{0:0.00000}", result);
    }
}