//Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.

using System;

class CompareNumbers
{
    static void Main()
    {
        double eps = 0.000001;

        Console.WriteLine("Enter 1-st number");
        float number1=float.Parse(Console.ReadLine());
        Console.WriteLine("Enter 2-st number");
        float number2 = float.Parse(Console.ReadLine());

        //bool areEquaL = number1 == number2;
        bool areEquaL = Math.Abs(number1 - number2) < eps;
        Console.WriteLine("The numbers are equal: {0}", areEquaL);
    }
}