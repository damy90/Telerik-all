using System;
using System.Text.RegularExpressions;
//Write a program that extracts from a given text all sentences containing given word.
class Program
{
    static void Main(string[] args)
    {
        string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        string[] sentences = Regex.Split(text, @"(?<=[\.!\?])\s+");
        string punctuation="!?.,- '\"()[]/:|{}+=#&<>*\\";
        foreach (string sentence in sentences)
        {
            int index=-1;
            do
            {
                index = sentence.IndexOf("in", index + 1, StringComparison.CurrentCultureIgnoreCase);
                if (index != -1 && (index == 0 || punctuation.IndexOf(sentence[index - 1]) != -1) && (index + 2 >= sentence.Length || punctuation.IndexOf(sentence[index + 2]) != -1) )
                {
                    Console.WriteLine(sentence);
                    break;
                }
            }
            while (index != -1);
        }
    }
}
