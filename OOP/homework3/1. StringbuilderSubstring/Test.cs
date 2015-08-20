using System;
using System.Text;

static class Test
{
    static void Main()
    {
        StringBuilder test = new StringBuilder("Hello Extension Methods");
        StringBuilder result = test.Substring(1, 3);
        Console.WriteLine(result);
        result = test.Substring(2);
        Console.WriteLine(result);
    }
}