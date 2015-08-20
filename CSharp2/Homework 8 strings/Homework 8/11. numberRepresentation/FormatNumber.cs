using System;
//Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation.
//Format the output aligned right in 15 symbols.
class FormatNumber
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("{0,15}", number);    // decimal

        Console.WriteLine("{0,15:X}", number);  // hexadecimal

        Console.WriteLine("{0,15:P}", number);  // percentage

        Console.WriteLine("{0,15:E}", number);  // scientific notation
    }
}