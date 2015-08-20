/*Problem 15. Hexadecimal to Decimal Number

Using loops write a program that converts a hexadecimal integer number to its decimal form.
The input is entered as string. The output should be a variable of type long.
Do not use the built-in .NET functionality.*/

using System;
class HexadecimalToDecimalNumber
{
    static void Main()
    {
        string input = Console.ReadLine();

        int lastIndex = input.Length - 1;

        long dec = 0;
        for (int i = 0; i < input.Length; i++, lastIndex--)
        {
            int currentNumberInHex;
            switch (input[i])
            {
                case 'A':
                    currentNumberInHex = 10;
                    break;
                case 'B':
                    currentNumberInHex = 11;
                    break;
                case 'C':
                    currentNumberInHex = 12;
                    break;
                case 'D':
                    currentNumberInHex = 13;
                    break;
                case 'E':
                    currentNumberInHex = 14;
                    break;
                case 'F':
                    currentNumberInHex = 15;
                    break;
                default:
                    currentNumberInHex = int.Parse(input[i].ToString());
                    break;
            }
            long hexSum = 1;
            for (int j = 0; j < lastIndex; j++)
            {
                hexSum *= 16;
            }
            hexSum *= currentNumberInHex;
            dec += hexSum;
        }
        Console.WriteLine(dec);
    }
}