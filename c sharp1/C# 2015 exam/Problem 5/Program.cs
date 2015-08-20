using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string concatenated = "";
        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            concatenated += Convert.ToString(number, 2).PadLeft(32, '0').Substring(2, 30);//TODO use stringbuilder
        }

        //Console.WriteLine(concatenated);
        Regex reg1 = new Regex(@"(1)\1+");
        MatchCollection matches = reg1.Matches(concatenated);
        int longest1 = 0;
        foreach (System.Text.RegularExpressions.Match match in matches)
        {
            if (longest1 < match.Length) longest1 = match.Length;
        }

        Console.WriteLine(longest1);

        Regex reg2 = new Regex(@"(0)\1+");
        MatchCollection matches2 = reg2.Matches(concatenated);
        int longest2 = 0;
        foreach (System.Text.RegularExpressions.Match match in matches2)
        {
            if (longest2 < match.Length) longest2 = match.Length;
        }

        Console.WriteLine(longest2);
    }
}
