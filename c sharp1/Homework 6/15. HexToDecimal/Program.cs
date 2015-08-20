using System;
//Write a program to convert hexadecimal numbers to their decimal representation.
class HexToDecimal
{
    //Using loops write a program that converts a hexadecimal integer number to its decimal form.
    //The input is entered as string. The output should be a variable of type long.
    //Do not use the built-in .NET functionality.
    static void Main()
    {
        Console.Write("Please enter a number in hex format: ");
        string input = Console.ReadLine();
        char[] hex = input.ToCharArray();
        char[] hexMap = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };

        long result = 0;
        for (int i = 0; i < hex.Length; i++)
            result += Array.IndexOf(hexMap, hex[hex.Length - 1 - i]) * 1 << (4 * i);//1 << (4 * i) == (int)(Math.Pow(16, i));

        Console.WriteLine(result);

    }
}