using System;
using System.Collections;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string path = @"../../input.txt";
        StreamReader input = new StreamReader(path);
        

        Queue lines = new Queue();
        using (input)
        {
            lines = new Queue(input.ReadToEnd().Split('\n'));
            //lines=new string[readInput.Length] readInput
        }

        StreamWriter output =new StreamWriter(path);
        using (output)
        {
            while (lines.Count >1)
            {
                lines.Dequeue();
                output.WriteLine(lines.Dequeue());
            }
        }

        string result = File.ReadAllText(path);
        Console.WriteLine("Result:\n{0}", result);
    }
}
