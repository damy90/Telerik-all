using System;
using System.Collections.Generic;
//Write a program that extracts from a given text all palindromes
class FindPalindromes
{
    static void Main()
    {
        string text = "asa nnn gfddk abba gsfsd gffg";

        string[] words = text.Split(' ');
        List<string> palindromes = new List<string>();
        foreach (var word in words)
        {
            string reverseWord = Reverse(word);
            if (word == reverseWord)
                palindromes.Add(word);
        }

        foreach (var word in palindromes)
            Console.WriteLine(word);
    }

    public static string Reverse(string s)
    {
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}
