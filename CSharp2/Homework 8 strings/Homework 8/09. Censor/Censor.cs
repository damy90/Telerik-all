using System;
using System.Text.RegularExpressions;
//We are given a string containing a list of forbidden words and a text containing some of these words.
//Write a program that replaces the forbidden words with asterisks.
class Censor
{
    static void Main()
    {
        string message = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
        string[] forbidenWords = {"PHP", "CLR", "Microsoft"};

        foreach (string forbidenWord in forbidenWords)
        {
            message = message.Replace(forbidenWord, new string('*', forbidenWord.Length));
        }

        Console.WriteLine(message);
        //Console.WriteLine(Regex.Replace(message, forbidenWords.Replace(", ", "|"), m => new String('*', m.Length)));
    }
}
