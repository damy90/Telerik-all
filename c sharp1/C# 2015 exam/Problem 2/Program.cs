using System;

class Program
{
    static void Main()
    {
        int m = int.Parse(Console.ReadLine());
        string text = Console.ReadLine().ToUpper();
        string[] lettersMap = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };

        int score = 0;//range?
        for (int i = 0; i < text.Length; i++)
        {
            string currentChar = text[i].ToString();
            if (currentChar == "@")
            {
                break;
            }
            int multiplier=1;
            if (int.TryParse(currentChar, out multiplier))
            {
                score *= multiplier;
                continue;
            }
            
            int addScore = Array.IndexOf(lettersMap, currentChar);
            if (addScore == -1)
            {
                score %= m;
                continue;
            }

            score += addScore;
        }

        Console.WriteLine(score);
    }
}
