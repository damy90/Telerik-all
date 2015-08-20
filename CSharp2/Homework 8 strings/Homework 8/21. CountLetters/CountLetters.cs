using System;
using System.Linq;
//Write a program that reads a string from the console and prints all different letters in the string along with information how many times each letter is found.
class CountLetters
{
    static void Main()
    {
        string text = Console.ReadLine();
        var chars = text.ToLower()
            .ToCharArray()
            .Where(c=> (!Char.IsWhiteSpace(c) && c!='.'))
            .GroupBy(c => c);

        foreach (var ch in chars)
            Console.WriteLine("{0}: {1}", ch.Key, ch.Count());
    }
}
