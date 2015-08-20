using System;

//check the results with http://www.wolframalpha.com/
//example expression: IntegerExponent[N!], N=50000

class CountZeroes
{
    //Write a program that calculates with how many zeroes the factorial of a given number n has at its end.
    //Your program should work well for very big numbers, e.g. n=100000.
    static void Main()
    {
        Console.Title = "Count trailing zeroes in N!";

        uint number;
        Console.Write("Please enter a number: ");
        while (true)
        {
            if (uint.TryParse(Console.ReadLine(), out number))
                break;
            else
                Console.Write("Please enter a positive integer number: ");
        }

        uint count=0;
        for (; number > 5; count += number)
        {
            number /= 5;
        }

        Console.WriteLine(count);
    }
}
