using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Regex r = new Regex(@"(?<=[A-Z])(?=[A-Z][a-z]) | (?<=[^A-Z])(?=[A-Z]) | (?<=[A-Za-z])(?=[^A-Za-z])", RegexOptions.IgnorePatternWhitespace);
        //string zergCode = r.Replace(Console.ReadLine(), " ");
        string[] words = r.Replace(Console.ReadLine(), " ").Split();
        string[] hexMap = { "Rawr", "Rrrr", "Hsst", "Ssst", "Grrr", "Rarr", "Mrrr", "Psst", "Uaah", "Uaha", "Zzzz", "Bauu", "Djav", "Myau", "Gruh" };

        ulong intNumber = 0;
        for (int j = 0; j < words.Length; j++)
        {
            intNumber = intNumber+(ulong)(Array.IndexOf(hexMap, words[j]) * Math.Pow(15, words.Length - 1 - j));
        }

        Console.WriteLine(intNumber);
    }
}
