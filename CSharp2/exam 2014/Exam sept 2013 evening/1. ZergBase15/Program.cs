using System;
using System.Linq;

class Program
{
    static void Main()
    {
        //Regex r = new Regex(@"(?<=[A-Z])(?=[A-Z][a-z]) | (?<=[^A-Z])(?=[A-Z]) | (?<=[A-Za-z])(?=[^A-Za-z])", RegexOptions.IgnorePatternWhitespace);
        //string zergCode = r.Replace(Console.ReadLine(), " ");
        //string[] words = r.Replace(Console.ReadLine(), " ").Split();
        //var words = Enumerable.Range(0, imput.Length / 4).Select(i => imput.Substring(i * 4, 4)).ToArray();
        string imput = Console.ReadLine();
        var words2 = new string[imput.Length / 4];
        //Sanest split
        for (int i = 0; i < imput.Length/4; i++)
        {
            words2[i] = imput.Substring(i * 4, 4);
        }
        
        string[] hexMap = { "Rawr", "Rrrr", "Hsst", "Ssst", "Grrr", "Rarr", "Mrrr", "Psst", "Uaah", "Uaha", "Zzzz", "Bauu", "Djav", "Myau", "Gruh" };

        ulong intNumber = 0;
        for (int j = 0; j < words2.Length; j++)
        {
            intNumber = intNumber+(ulong)(Array.IndexOf(hexMap, words2[j]) * Math.Pow(15, words2.Length - 1 - j));
        }

        Console.WriteLine(intNumber);
    }
}
