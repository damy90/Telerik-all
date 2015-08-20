using System;

//check the results with http://www.wolframalpha.com/
//example expression: greatest common divider 12, 8

class GCD
{
    //Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.
    //Use the Euclidean algorithm (find it in Internet).
    static void Main()
    {
        Console.Title = "Greatest common divisor (Euclidean algorithm)";

        int number1, number2;
        Console.Write("Please enter first number: ");
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out number1))
                break;
            Console.Write("Please enter a integer number: ");
        }
        Console.Write("Please enter second number: ");
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out number2))
                break;
            Console.Write("Please enter a integer number: ");
        }

        while ((number1 != 0 && number2 != 0))
        {
            if (number1 > number2)
                number1 %= number2;
            else
                number2 %= number1;
        }

        Console.WriteLine("The greatest common divisor is: {0}", number1 == 0 ? Math.Abs(number2) : Math.Abs(number1));    //works on positive and negative numbers
    }
}
