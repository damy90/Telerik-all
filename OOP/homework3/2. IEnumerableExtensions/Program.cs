using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var elements = new[] {  "a",  "b" };
        Console.WriteLine(elements.Average());
        Console.WriteLine(elements.Min());
        Console.WriteLine(elements.Max());
        Console.WriteLine(elements.Sum());
        string a = "a";
        string b = "b";
        Console.WriteLine(a * b);
    }
}
