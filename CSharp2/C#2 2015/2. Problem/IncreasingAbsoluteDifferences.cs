using System;
using System.Linq;

public class IncreasingAbsoluteDifferences
{
    public static void Main()
    {
        int secuencesCount = int.Parse(Console.ReadLine());
        var sequences = new int[secuencesCount][];

        for (int i = 0; i < secuencesCount; i++)
        {
            sequences[i] = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
        }

        int[][] absDiffSequences = DifferenceAdjacentElements(sequences);

        for (int i = 0; i < absDiffSequences.Length; i++)
        {
            Console.WriteLine(IsIncreasing(absDiffSequences[i]));
        }
    }

    /// <summary>
    /// Calculates the absolute difference between adjacent elements for each array in an array of sequences
    /// </summary>
    private static int[][] DifferenceAdjacentElements(int[][] sequences)
    {
        var absDiffSequences = new int[sequences.GetLength(0)][];

        for (int i = 0; i < sequences.GetLength(0); i++)
        {
            absDiffSequences[i] = new int[sequences[i].Length - 1];
            for (int j = 0; j < sequences[i].Length - 1; j++)
            {
                absDiffSequences[i][j] = Math.Abs(sequences[i][j] - sequences[i][j + 1]);
            }
        }

        return absDiffSequences;
    }

    /// <summary>
    /// Checks if a sequence of numbers is increasing (the absolute difference between adjacent elements is 0 or 1) 
    /// </summary>
    private static bool IsIncreasing(int[] sequence)
    {
        for (int i = 0; i < sequence.Length - 1; i++)
        {
            if (sequence[i] > sequence[i + 1] || sequence[i + 1] - sequence[i] > 1)
            {
                return false;
            }
        }

        return true;
    }
}