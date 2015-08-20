using System;

class NumbersPrintBigest
{
    //Write a program that gets two numbers from the console and prints the greater of them.
    //Try to implement this without if statements.

    static void Main()
    {
        Console.Title = "Find the biger number";
        Console.Write("Please enter the first number:");
        float number1 = float.Parse(Console.ReadLine());
        Console.Write("Please enter the second number:");
        float number2 = float.Parse(Console.ReadLine());
        Console.WriteLine("The greater of the two entered numbers is {0}", Math.Max(number1, number2));
    }
}
