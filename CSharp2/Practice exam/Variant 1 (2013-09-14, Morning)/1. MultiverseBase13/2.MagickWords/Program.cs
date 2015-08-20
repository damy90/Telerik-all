using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        //var sw = new StreamReader(new FileStream("../../test.015.in.txt", FileMode.Open));
        //Console.SetIn(sw);  //пренасочва към sw

        int wordsCount = int.Parse(Console.ReadLine());
        var words = new List<string>();
        int maxLettersCount = 0;
        for (int i = 0; i < wordsCount; i++)
        {
            words.Add(Console.ReadLine());
            if (words[i].Length > maxLettersCount)
            {
                maxLettersCount = words[i].Length;
            }
        }
        //sw.Close();     //и това в края
        for (int i = 0; i < wordsCount; i++)
        {
            int newIndex = words[i].Length % (wordsCount + 1);
            if (newIndex != i && newIndex != i + 1)
            {
                words.Insert(newIndex, words[i]);
                if (newIndex > i)
                {
                    words.RemoveAt(i);
                }
                else
                {
                    words.RemoveAt(i + 1);
                }
            }
        }

        //Console.WriteLine();
        //foreach (var word in words)
        //{
        //    Console.WriteLine(new string(word.ToArray()));
        //}

        //var wordsList = new LinkedList<Queue<char>>(words);

        StringBuilder result = new StringBuilder();

        for (int i = 0; i < maxLettersCount; i++)
        {
            for (int j = 0; j < wordsCount; j++)
            {
                if (words[j].Length > i)
                {
                    result.Append(words[j][i]);
                }
            }
        }

        Console.WriteLine(result);
    }
}
