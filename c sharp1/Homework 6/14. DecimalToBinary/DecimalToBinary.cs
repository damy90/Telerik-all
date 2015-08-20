using System;

class DecimalToBinary
{
    //Using loops write a program that converts an integer number to its binary representation.
    //The input is entered as long. The output should be a variable of type string.
    //Do not use the built-in .NET functionality.
    //only works with positive numbers
    static void Main()
    {
        Console.Write("Please enter a number: ");
        long decimalNumber = long.Parse(Console.ReadLine());

        string result = "";
        for (int i = 0; i < 63 && decimalNumber > 0; i++, decimalNumber >>= 1)
        {
            if ((decimalNumber & 1) == 1)
                result = 1 + result;
            else
                result = 0 + result;
        }

        Console.WriteLine(result);
    }
}