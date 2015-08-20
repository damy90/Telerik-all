//Find online more information about ASCII (American Standard Code for Information Interchange) and write a program that prints the entire ASCII table of characters on the console (characters from 0 to 255).

using System;
using System.Text;

class ASCII_table
{
    static void Main()
    {
        Console.Title = "ASCII Table";
        Console.OutputEncoding = Encoding.ASCII;
        for (int i = 0; i < 128; i++)
        {
            Console.Write("{0} - {1}\t", i, (char)i);
        }
    }
}