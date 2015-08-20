using System;
//Write a program to convert hexadecimal numbers to binary numbers (directly).
class Program
{
    static void Main()
    {
        int hex = 0x2E ;
        string result = "";
        for (; hex > 0; hex /= 2)
        {
            if (hex % 2 == 0)
                result=0+result;
            else
                result = 1 + result;
        }
        Console.WriteLine(result);
    }
}
