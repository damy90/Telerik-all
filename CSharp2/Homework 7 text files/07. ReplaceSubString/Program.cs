using System;
using System.IO;

class Program
{
    static void Main()
    {
        string resultPath = @"../../result.txt";
        StreamReader input = new StreamReader("../../input.txt");
        StreamWriter output = new StreamWriter(resultPath);

        using (output)
        using (input)
        {
            string text = input.ReadToEnd();
            text = text.Replace("start", "finish");
            output.WriteLine(text);
        }

        string result = File.ReadAllText(resultPath);
        Console.WriteLine("Result:\n{0}", result);
    }
}
