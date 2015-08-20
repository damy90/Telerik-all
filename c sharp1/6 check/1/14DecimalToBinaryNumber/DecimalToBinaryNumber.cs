/*Problem 14. Decimal to Binary Number

Using loops write a program that converts an integer number to its binary representation.
The input is entered as long. The output should be a variable of type string.
Do not use the built-in .NET functionality.*/

using System;
class DecimalToBinaryNumber
{
    static void Main()
    {
        long dec = long.Parse(Console.ReadLine());
        long? remainder = null;
        string binary = null;

        while (dec > 0)
        {
            remainder = dec % 2;
            binary = remainder.ToString() + binary;
            dec /= 2;
        }
        Console.WriteLine(binary);
    }
}