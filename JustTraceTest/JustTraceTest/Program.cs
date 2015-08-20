using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

class Program
{
    static void Main()
    {
        //z-a+1
        //string[] words = Console.ReadLine().Split();
        string[] words = { "Telerik", "Academy" };
        StringBuilder extractLetters = new StringBuilder();
        int maxWordLength = 0;
        for (int i = 0; i < words.Length; i++)
            maxWordLength = Math.Max(maxWordLength, words[i].Length);
        for (int cycle = 1; cycle <= maxWordLength; cycle++)
        {
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length - cycle >= 0)
                    extractLetters.Append(words[i].Substring(words[i].Length - cycle, 1));
            }
        }

        int lettersCount = extractLetters.Length;

        for (int i = 0; i < lettersCount; i++)
        {
            char item = extractLetters[i];
            int moove = (char.ToLower(extractLetters[i]) + 1 - 'a') % lettersCount;
            extractLetters.Remove(i, 1);

            int newIndex = (i + moove) % lettersCount;
            //if (newIndex > i) newIndex--;
            // the actual index could have shifted due to the removal

            extractLetters.Insert(newIndex, item);
        }

        Console.WriteLine(extractLetters);
    }
}
