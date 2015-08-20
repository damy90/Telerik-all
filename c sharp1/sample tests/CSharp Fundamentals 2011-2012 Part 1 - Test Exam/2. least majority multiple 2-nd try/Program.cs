using System;

class Program
{
    static void Main()
    {
        int leastMajorityMultiple = int.MaxValue, minInput = int.MaxValue;
        //input
        int[] numbers = new int[5];
        for (int i = 0; i < 5; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
            if (numbers[i] < minInput)
                minInput = numbers[i];
        }
        for (int testNumber = minInput; (testNumber < int.MaxValue) && (leastMajorityMultiple == int.MaxValue); testNumber++)
        {
            int count = 0;
            for (int i = 0; i < 5; i++)
            {
                if (testNumber % numbers[i] == 0)
                    count++;
                if (testNumber < leastMajorityMultiple && count >= 3)
                {
                    leastMajorityMultiple = testNumber;
                    break;
                }
            }
        }
        Console.WriteLine(leastMajorityMultiple);
    }
}
