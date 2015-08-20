using System;
//Write a program that reads from the console a string of maximum 20 characters. If the length of the string is less than 20, the rest of the characters should be filled with '*'.
//Print the result string into the console.

class StringLength
{
    static void Main()
    {
        string text = Console.ReadLine();

        int length = text.Length;
        if (length > 20)
            text = text.Remove(20, length - 20);
        else
            text = text.PadRight(20, '*');

        Console.WriteLine(text);
    }
}
