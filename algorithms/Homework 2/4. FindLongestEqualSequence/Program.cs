using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.FindLongestEqualSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> TestData = new List<int>() { 4, 2, 2, 2, 5, 5, 2, 3, 2, 3, 1, 5, 2 };

            List<int> sequence = FindLongestEqualSequence(TestData);

            Console.WriteLine("The longest sequence is: {0}", string.Join(", ", sequence));
        }

        static List<int> FindLongestEqualSequence(List<int> input)
        {
            int maxCount=0;
            int maxValue=0;
            int[] numbers=input.ToArray();
            int numbersCount=numbers.Length;

            for (int i = 0, count; i < numbersCount; i++)
            {
                count = 1;
                for (int j = i+1; j < numbersCount && i < numbersCount; j++)
                {
                    if (numbers[j] != numbers[i])
                    {
                        i = j-1;
                        if (count > maxCount)
                        {
                            maxCount = count;
                            maxValue = numbers[i];
                        }

                        break;
                    }

                    count++;
                }
            }

            List<int> result = Enumerable.Repeat(maxValue, maxCount).ToList();
            return result;
        }
    }
}
