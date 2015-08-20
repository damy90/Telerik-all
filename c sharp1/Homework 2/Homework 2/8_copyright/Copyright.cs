//Write a program that prints an isosceles triangle of 9 copyright symbols ©

using System;
using System.Text;

class Copyright
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        // This SHOULD print UTF8
        Console.WriteLine("  \u00a9  \n \u00a9\u00a9\u00a9 \n\u00a9\u00a9\u00a9\u00a9\u00a9");
    }
}