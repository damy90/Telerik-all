/*Problem 16. Decimal to Hexadecimal Number

Using loops write a program that converts an integer number to its hexadecimal representation.
The input is entered as long. The output should be a variable of type string.
Do not use the built-in .NET functionality.*/

using System;
class DecimalToHexadecimalNumber
{
    static void Main()
    {
        long dec = long.Parse(Console.ReadLine());
        long? remainder = null;
        string hex = null;

        while (dec > 0)
        {
            remainder = dec % 16;
            switch (remainder)
            {
                case 10:
                    hex = 'A' + hex;
                    break;
                case 11:
                    hex = 'B' + hex;
                    break;
                case 12:
                    hex = 'C' + hex;
                    break;
                case 13:
                    hex = 'D' + hex;
                    break;
                case 14:
                    hex = 'E' + hex;
                    break;
                case 15:
                    hex = 'F' + hex;
                    break;
                default:
                    hex = remainder.ToString() + hex;
                    break;
            }
            dec /= 16;
        }
        Console.WriteLine(hex);
    }
}