using System;
using System.IO;

class Program
{
    static void Main()
    {
        string resultPath = @"../../result.txt";
        StreamReader input = new StreamReader("../../input.txt");

        using (input)
        {
            string[] names = input.ReadToEnd().Split('\n');
            
            Array.Sort(names);
            File.WriteAllLines(resultPath, names);
        }

        string result = File.ReadAllText(resultPath);
        Console.WriteLine("Result:\n{0}",result);
    }
}
