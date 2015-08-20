using System;

//Write a program that reads two numbers N and K and generates all the combinations of K distinct elements from the set [1..N]. Example:
	//N = 5, K = 2  {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5}
class Combinations
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int elementsCount = int.Parse(Console.ReadLine());
        int[] combination = new int[elementsCount];
        for (int i = 0; i < elementsCount; i++)
            combination[i] = i+1;

        while (true)
        {
            for (int i = 0; i < elementsCount; i++)
                Console.Write(combination[i]);
            Console.WriteLine();
            bool last = true;
            for (int i = 0; i < elementsCount; i++)
                last = last && (combination[i] == number - elementsCount+i+1);
            if (last)
                break;
            combination[elementsCount - 1] += 1;
            for (int i = elementsCount - 1; i > 0 && combination[i] > number - (elementsCount-1-i); i--)
                if (combination[i - 1] <= number-1)
                {
                    combination[i - 1]++;
                    for (int j = i; j < elementsCount; j++)
                        combination[j] = combination[j-1]+1;
                }

        }
    }
}