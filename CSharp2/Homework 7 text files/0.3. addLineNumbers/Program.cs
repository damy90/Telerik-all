using System;
using System.IO;

//Write a program that reads a text file and inserts line numbers in front of each of its lines.
//The result should be written to another text file.
class Program
{
    static void Main()
    {
        string resultPath = @"../../result.txt";
        StreamReader input = new StreamReader("../../text.txt");
        StreamWriter output = new StreamWriter(resultPath);

        int number = 1;
        using (input)
        using (output)
        {
            for (string line; (line = input.ReadLine()) != null; number++)
                output.WriteLine("{0}. {1}", number, line);
        }

        string result = File.ReadAllText(resultPath);
        Console.WriteLine("Result:\n{0}",result);
    }
}