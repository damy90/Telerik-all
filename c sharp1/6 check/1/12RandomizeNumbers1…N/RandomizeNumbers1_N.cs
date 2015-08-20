/*Problem 12.* Randomize the Numbers 1…N

Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.
>> Note: The above output is just an example. Due to randomness, your program most probably will produce different results. You might need to use arrays.
 */

using System;
using System.Collections.Generic;

class RandomizeNumbers1_N
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] nArray;
        List<int> uniquePos = new List<int>();

        nArray = new int[n];
        Random randomGenerator = new Random();

        for (int i = 0; i < nArray.Length; i++)
        {
            int randomIndex = randomGenerator.Next(nArray.GetLowerBound(0), nArray.GetUpperBound(0) + 1);

            while (uniquePos.Contains(randomIndex)) //checking if the number is already printed
            {
                randomIndex = randomGenerator.Next(nArray.GetLowerBound(0), nArray.GetUpperBound(0) + 1);
            }

            nArray[i] = randomIndex + 1;
            uniquePos.Add(randomIndex);
            Console.WriteLine(nArray[i]);
        }
    }
}