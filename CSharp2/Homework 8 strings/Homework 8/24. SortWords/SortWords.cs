using System;
//Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.

class SortWords
{
    static void Main()
    {
        string input = "ball freezby TV agent homework acadeny internet";

        string[] words = input.Split(' ');
        Array.Sort(words);

        foreach (string word in words)
            Console.WriteLine(word);
    }
}
