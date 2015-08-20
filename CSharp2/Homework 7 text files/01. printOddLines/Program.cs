using System;
using System.IO;
//Write a program that reads a text file and prints on the console its odd lines.
class Program
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"../../text.txt");
        using (reader)
        {
            string line;
            while (reader.ReadLine() != null)
            {
                line = reader.ReadLine();
                if (line != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}