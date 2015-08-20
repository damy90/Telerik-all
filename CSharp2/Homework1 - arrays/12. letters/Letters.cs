using System;

//Write a program that creates an array containing all letters from the alphabet (A-Z). 
//Read a word from the console and print the index of each of its letters in the array.
class Letters
{
    static void Main()
    {
        string input = Console.ReadLine();
        char[] word = input.ToUpper().ToCharArray();
        char[] alphabet = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        int[] result = new int[word.Length];

        for (int i = 0; i < word.Length; i++)
        {
            result[i] = Array.IndexOf(alphabet, word[i]);
        }

        Console.Write("{0} ", string.Join(", ", result));
    }
}
