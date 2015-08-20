using System;
using System.Text.RegularExpressions;


class Program
{
    static void Main(string[] args)
    {
        var input = "something likeeeee!! tttthhiiissss";

        var regex = new Regex("(.)\\1+");
        var output = regex.Replace(input, "$1");

        Console.WriteLine(output);
    }
}
