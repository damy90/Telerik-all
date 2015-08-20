using System;
//Write a program to convert binary numbers to their decimal representation.
class Program
{
    static void Main()
    {
        byte[] binNumber = { 1, 1, 0, 0, 0 };
        int number=0;
        for (int i = 0; i < binNumber.Length; i++)
            number += binNumber[binNumber.Length - i-1] * (1 << i);//1<<i == Math.Pow(2,i)
        Console.WriteLine(number);
    }
}
