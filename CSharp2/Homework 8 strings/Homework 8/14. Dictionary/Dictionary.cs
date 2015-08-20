using System;
using System.Collections.Generic;
//A dictionary is stored as a sequence of text lines containing words and their explanations.
//Write a program that enters a word and translates it by using the dictionary.
class Dictionary
{
    static void Main()
    {
        Dictionary<string, string> dict = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        dict.Add(".NET", "platform for applications from Microsoft");
        dict.Add("CLR", "managed execution environment for .NET");
        dict.Add("namespace", "hierarchical organization of classes");
        string word = ".net";
        string result = "";
        dict.TryGetValue(word, out result);

        if (string.IsNullOrEmpty(result))
            Console.WriteLine("Deffinition for {0} not found", word);
        else
            Console.WriteLine("{0} - {1}", word, result);
    }
}
