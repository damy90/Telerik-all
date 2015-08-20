using System;
//Write a program to convert decimal numbers to their binary representation.
class Program
{
    static void Main()
    {
        int decimalNumber = 12;
        for (int i = 0; i < 31 && decimalNumber > 0; i++, decimalNumber>>=1)
        {
            if ((decimalNumber & 1) == 1)
                Console.Write(1);
            else
                Console.Write(0);
        }
        Console.WriteLine();
    }
}
