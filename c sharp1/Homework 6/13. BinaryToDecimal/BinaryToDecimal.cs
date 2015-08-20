using System;
using System.Linq;

class BinaryToDecimal
{
    //Using loops write a program that converts a binary integer number to its decimal form.
    //The input is entered as string. The output should be a variable of type long.
    //Do not use the built-in .NET functionality.
    static void Main()
    {
        Console.WriteLine("Please enter a number in binary format");
        byte[] binNumber = Console.ReadLine()
            .ToCharArray()
            .Select(x => byte.Parse(x.ToString()))
            .ToArray();

        int number = 0;
        for (int i = 0; i < binNumber.Length; i++)
            number += binNumber[binNumber.Length - i - 1] * (1 << i);//1<<i == Math.Pow(2,i)
        Console.WriteLine(number);
    }
}