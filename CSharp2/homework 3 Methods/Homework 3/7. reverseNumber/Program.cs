using System;
//Write a method that reverses the digits of given decimal number. Example: 256 => 652
class Program
{
    static void Main()
    {
        var number = 123.45;
        Reverse(number);
    }
    static void Reverse(double number)
    {
        char[] digits = number.ToString().ToCharArray();
        Array.Reverse(digits);

        foreach (char didgit in digits)
            Console.Write(didgit);
        Console.WriteLine();
    }
}
