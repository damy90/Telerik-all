using System;

//Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N]. Example:
	//N = 3, K = 2  {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}
class Variations 
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int elementsCount = int.Parse(Console.ReadLine());
        int[] combination=new int[elementsCount];
        for (int i = 0; i < elementsCount; i++)
            combination[i] = 1;
        
        while (true)
        {
            for (int i = 0; i < elementsCount; i++)
                Console.Write(combination[i]);
            Console.WriteLine();
            bool last = true;
            for (int i = 0; i < elementsCount; i++)
                last = last && (combination[i] == number);
            if (last)
                break;
            combination[elementsCount - 1] += 1;
            for (int i = elementsCount - 1; i > 0 && combination[i] > number; i--)
                if (combination[i - 1] <= number)
                {
                    combination[i - 1]++;
                    for (int j = i; j < elementsCount; j++)
                        combination[j] = 1;
                }
            
        }
    }
}
