using System;
using System.IO;
//Write a program that compares two text files line by line and prints the number of lines that are the same and the number of lines that are different.
//Assume the files have equal number of lines.
class Program
{
    static void Main()
    {
        StreamReader file1 = new StreamReader(@"../../text1.txt");
        StreamReader file2 = new StreamReader(@"../../text2.txt");
        int lineCount = File.ReadAllLines(@"../../text1.txt").Length;
        int countSame = 0;
        int countDiff = 0;
        using (file1)
        using (file2)
        {
            for (int line = 0; line < lineCount;line++ )
            {
                if (file1.ReadLine() == file2.ReadLine())
                    countSame++;
                else
                    countDiff++;
            }
        }
        Console.WriteLine("same: {0}\ndifferent: {1}", countSame, countDiff);
    }
}