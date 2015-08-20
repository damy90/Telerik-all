using System;
//Write a program to convert hexadecimal numbers to their decimal representation.
class Program
{
    static void Main()
    {
        int[] hex = {0x1, 0xF};
        int result=0;
        for (int i = 0; i < hex.Length; i++)
            result += hex[hex.Length - 1 - i] *1<< (4 * i);//==hex[hex.Length - 1 - i] * (int)(Math.Pow(16, i));
        Console.WriteLine(result);
    }
}