using System;
//Write a program that reads a string, reverses it and prints the result at the console.

class ReverseString
{
    static void Main()
    {
        string text = "abc";

        char[] charArray = text.ToCharArray();
        Array.Reverse(charArray);
        string reverseText = new string(charArray);

        Console.WriteLine(reverseText);
    }
}
