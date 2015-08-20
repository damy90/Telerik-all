using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        BigInteger number = BigInteger.Parse(input);
        char[] lettersMap = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        int lettersCount = lettersMap.GetLength(0);

        if (number < 0)
        {
            number = -number;
        }

        BigInteger secretNumber = 0;
        for (int position = 1; number >0; position++)
        {
            int didgit = (int)(number % 10);
            if (position % 2 == 0)
            {
                secretNumber += (didgit * didgit * position);
            }
            else
            {
                secretNumber += didgit * position * position;
            }

            number = number / 10;
        }

        Console.WriteLine(secretNumber);

        string secretAlpha = "";
        int startLetterMapIndex = (int)(secretNumber % lettersCount);
        int secretAlphaLength = (int)(secretNumber % 10);
        if (secretAlphaLength == 0)
        {
            Console.WriteLine("{0} has no secret alpha-sequence", input);
            return;
        }
        for (int i = 0; i < secretAlphaLength; i++)
        {
            secretAlpha += lettersMap[(startLetterMapIndex + i) % lettersCount];
        }

        Console.WriteLine(secretAlpha);
    }
}
