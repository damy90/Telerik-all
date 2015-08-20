//Create a console application that calculates and prints the square root of the number 12345.

using System;

class SquareRoot
{
    static void Main()
    {
        short number = 12345;
        double squareRoot = Math.Sqrt(number);
        Console.WriteLine("Square root of 12345 is {0}", squareRoot);
    }
}

