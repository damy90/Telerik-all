using System;
using System.IO;

class Program
{
    static void Main()
    {
        string resultPath = @"../../result.txt";
        StreamReader input = new StreamReader("../../input.txt");
        StreamWriter output = new StreamWriter(resultPath);
        string[] listOfWords = { "list", "of", "words" };

        using (output)
        using (input)
        {
            string text = input.ReadToEnd();
            foreach (string word in listOfWords)
            {
                text = text.Replace(word, "");
            }
            
            output.WriteLine(text);
        }

        string result = File.ReadAllText(resultPath);
        Console.WriteLine("Result:\n{0}", result);
    }
}
