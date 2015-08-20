using System;

class Program
{
    static void Main()
    {
        string[] coinsInput = Console.ReadLine().Replace(" ", "").Split(',');//coins on each field in the valey
        int patternCount = int.Parse(Console.ReadLine());
        int valeyLength = coinsInput.Length;
        int[] coins = new int[valeyLength];
        //parse input
        for (int i = 0; i < valeyLength; i++)
            coins[i] = int.Parse(coinsInput[i]);

        //read and test patterns
        int bestResult = int.MinValue;
        for (int i = 0; i < patternCount; i++)
        {
            var pattern = Console.ReadLine();

            int result = TestPattern(coins, pattern, valeyLength);
            if (bestResult < result)
                bestResult = result;
        }
        Console.WriteLine(bestResult);
    }

    private static int TestPattern(int[] coins, string pattern, int valeyLength)
    {
        bool[] visited = new bool[valeyLength];
        string[] steps = pattern.Replace(" ", "").Split(',');
        int result = 0;
        int patternLength = steps.Length;

        int[] stepsArray = new int[patternLength];
        for (int i = 0; i < patternLength; i++)
            stepsArray[i] = int.Parse(steps[i]);

        int position = 0;
        while (true)
        {
            foreach (int step in stepsArray)
            {
                if (position >= valeyLength || position < 0 || visited[position])
                    return result;
                result += coins[position];
                visited[position] = true;
                position += step;
            }
        }
    }
}