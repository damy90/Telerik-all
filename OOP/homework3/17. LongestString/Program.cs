using System;
using System.Linq;
//Write a program to return the string with maximum length from an array of strings.
//Use LINQ.
class Program
{
    static void Main()
    {
        string[] array = new string[] { "12", "123", "1" };

        var result=(from str in array
                   orderby str.Length
                       select str).Last();

        Console.WriteLine(result);
    }
}
