using System;
using System.IO;
//Write a program that concatenates two text files into another text file.
class Program
{
    static void Main()
    {
        string resultPath = @"../../result.txt";
        StreamWriter concatenateWriter = File.CreateText(resultPath);
        StreamReader file1 = new StreamReader(@"../../text.txt");
        StreamReader file2 = new StreamReader(@"../../append.txt");
        using (file1)
        using (file2)
        using (concatenateWriter)
        {
            concatenateWriter.WriteLine(file1.ReadToEnd());
            concatenateWriter.WriteLine(file2.ReadToEnd());
        }

        string result = System.IO.File.ReadAllText(resultPath);
        Console.WriteLine("Result:\n{0}",result);
    }
}