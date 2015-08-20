using System;

class DecimalToHex
{
    //Using loops write a program that converts an integer number to its hexadecimal representation.
    //The input is entered as long. The output should be a variable of type string.
    //Do not use the built-in .NET functionality.
    static void Main()
    {
        int number = 16;
        string hex = "";
        //Better use a hex map array but no time to rewrite
        for (int remainder = 0; number > 0; number /= 16)
        {
            remainder = number % 16;
            switch (remainder)
            {
                case 10:
                    hex = "A" + hex;
                    break;
                case 11:
                    hex = "B" + hex;
                    break;
                case 12:
                    hex = "C" + hex;
                    break;
                case 13:
                    hex = "D" + hex;
                    break;
                case 14:
                    hex = "E" + hex;
                    break;
                case 15:
                    hex = "F" + hex;
                    break;
                default:
                    hex = remainder.ToString() + hex;
                    break;
            }
        }
        Console.WriteLine("0x{0}", hex);
    }
}
