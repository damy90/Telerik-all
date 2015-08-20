using System;
//Write a program to convert binary numbers to their decimal representation.
class Program
{
    static void Main()
    {
        int number = 16;
        string hex="";
        for (int remainder=0; number > 0; number/=16)
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
