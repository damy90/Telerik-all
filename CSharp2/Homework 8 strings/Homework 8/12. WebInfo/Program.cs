using System;
using System.Text.RegularExpressions;
//Write a program that parses an URL address given in the format: [protocol]://[server]/[resource]
//and extracts from it the [protocol], [server] and [resource] elements.
class Program
{
    static void Main()
    {
        string uri = "http://www.devbg.org/forum/index.php";

        var fragments = Regex.Match(uri, "(.*)://(.*?)(/.*)").Groups;

        Console.WriteLine("protocol: {0}", fragments[1]);
        Console.WriteLine("server: {0}",fragments[2]);
        Console.WriteLine("resource: {0}",fragments[3]);
    }
}