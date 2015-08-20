using System;
//Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).
class Program
{
    static void Main()
    {
        short number = 333;
        string bits = Convert.ToString(number, 2).PadLeft(16, '0');
        Console.WriteLine(bits);
    }
}
