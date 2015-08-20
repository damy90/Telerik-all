using System;
using System.Text;
//Write a program that converts a string to a sequence of C# Unicode character literals. Use format strings.
class UnicodeCharacterLiterals
{
    static void Main(string[] args)
    {
        string text = "Hi!";

        StringBuilder utf = new StringBuilder();
        foreach (char character in text)
            utf.AppendFormat("\\u{0:X4}", (int)character);
        
        Console.WriteLine(utf);
    }
}
