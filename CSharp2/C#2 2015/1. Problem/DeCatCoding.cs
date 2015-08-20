using System;
using System.Collections.Generic;
using System.Numerics;

public class DeCatCoding
{
    public static void Main()
    {
        string[] input = Console.ReadLine().Split();

        Console.WriteLine(string.Join(" ", DecodeMessage(input)));
    }

    /// <summary>
    /// Decode some weird messages intercepted from the cat illuminati.
    /// </summary>
    /// <param name="input">Array of encoded words</param>
    /// <returns>Array of decoded words</returns>
    private static string[] DecodeMessage(string[] input)
    {
        int fromBase = 21;
        int toBase = 26;
        var decodedWords = new string[input.Length];
        List<int> didgits;
        string word;
        int didgit;
        for (int i = 0; i < input.Length; i++)
        {
            word = input[i];
            didgits = new List<int>();
            for (int j = 0; j < word.Length; j++)
            {
                didgit = word[j] - DidgitMap(0);
                if (didgit >= fromBase)
                {
                    throw new ArgumentOutOfRangeException("Invalid input! A didgit is too big for the numeral system witg base " + fromBase);
                }

                if (didgit < 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid input! A didgit has a negative value in a numeric system staarting from " + DidgitMap(0));
                }

                didgits.Add(didgit);
            }

            BigInteger intNumber = ToInt(didgits, fromBase);
            decodedWords[i] = ToBase(intNumber, toBase);
        }

        return decodedWords;
    }

    /// <summary>
    /// convert input number from any numeral system to integer
    /// </summary>
    /// <param name="digits">A number represented as an array of numbers representing the digits n any numeral system</param>
    /// <param name="fromBase">The base of the numeral system of the number </param>
    /// <returns>An integer number</returns>
    private static BigInteger ToInt(List<int> digits, int fromBase)
    {
        BigInteger result = 0;
        for (int i = 0; i < digits.Count; i++)
        {
            result += digits[i] * BigInteger.Pow(fromBase, digits.Count - 1 - i);
        }

        return result;
    }

    /// <summary>
    /// convert integer to any numeral system
    /// </summary>
    /// <param name="number">An integer number</param>
    /// <param name="toBase">The base for conversion of the integer number</param>
    /// <returns>A string representing the digits of the converted number</returns>
    private static string ToBase(BigInteger number, BigInteger toBase)
    {
        string result = string.Empty;
        if (number == 0)
        {
            result += 0;
        }

        for (int remainder = 0; number > 0; number /= toBase)
        {
            remainder = (int)(number % toBase);
            result = DidgitMap(remainder) + result;
        }

        return result;
    }

    /// <summary>
    /// map digits to their character representation for custom numeric systems
    /// </summary>
    /// <param name="digit">An integer number as the decimal value of the digit</param>
    /// <returns>The character representing the digit</returns>
    private static char DidgitMap(int digit)
    {
        char[] hexMap = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        return hexMap[digit];
    }
}