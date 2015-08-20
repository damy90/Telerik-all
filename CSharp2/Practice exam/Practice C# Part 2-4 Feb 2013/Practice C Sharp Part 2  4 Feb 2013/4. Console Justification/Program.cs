using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

class Program
{
    static void Main()
    {
        int linesCount = int.Parse(Console.ReadLine());
        int width = int.Parse(Console.ReadLine());
        StringBuilder input = new StringBuilder();
        //input text
        for (int i = 0; i < linesCount; i++)
            input.Append(Console.ReadLine()).Append(' ');

        Console.Write(TextJustify(width, input));
    }

    private static StringBuilder TextJustify(int width, StringBuilder input)
    {
        string[] words = input.ToString().Split(new char[0], StringSplitOptions.RemoveEmptyEntries);

        StringBuilder output = new StringBuilder();
        StringBuilder line = new StringBuilder(width);
        int lineWordCount = 0;
        for (int i = 0, wordCount = words.Length; i < wordCount; i++)
        {
            line.Append(words[i]).Append(' ');
            lineWordCount++;
            int lineLength = line.Length;
            if (i == wordCount - 1 || lineLength + words[i + 1].Length > width)
            {
                //justify
                if (lineWordCount > 1)
                {
                    int charsRemaining = width - lineLength + 1;
                    //mimimum padding between each word
                    string padding = new string(' ', (charsRemaining / (lineWordCount - 1)) + 1);
                    Regex findPadding = new Regex(@"\s+");
                    line = new StringBuilder(line.ToString().Replace(" ", padding));
                    //padding to width
                    padding += ' ';
                    line = new StringBuilder(findPadding.Replace(line.ToString(), padding, charsRemaining % (lineWordCount - 1)));
                }
                //write justified line
                output.AppendLine(line.ToString().Trim());
                line.Clear();
                lineWordCount = 0;
            }
        }
        return output;
    }
}
