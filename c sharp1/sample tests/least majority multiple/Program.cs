using System;
//least majority multiple 
class Program
{
    static void Main()
    {
        int leastMajorityMultiple = int.MaxValue;
        //input
        int[] numbers = new int[5];
        for (int i = 0; i < 5; i++)
            numbers[i] = int.Parse(Console.ReadLine());
        //within given numbers
        for (int i = 0; i < 5; i++)
        {
            int count = 1;
            for (int j = 0; j < 5; j++)
            {
                if (numbers[i] % numbers[j] == 0 && i!=j)
                    count++;
                if (leastMajorityMultiple > numbers[i] && count >= 3)
                {
                    leastMajorityMultiple = numbers[i];
                    continue;
                }
            }
        }
        //product of 2 numbers
        for (int i = 0; i < 5; i++)
        {
            int count = 2;
            int product2;
            for (int j = i+1; j < 5; j++)
            {
                product2 = numbers[i] * numbers[j];
                for (int k = 0; k < 5; k++)
                {
                    if (product2 % numbers[k] == 0 && k!=i && k!=j)
                        count++;
                    if (leastMajorityMultiple > product2 && count >= 1)
                    {
                        leastMajorityMultiple = product2;
                        continue;
                    }
                }
            }
        }
        //product of 3 numbers
        //for (int i = 0; i < 5; i++)
        //{
        //    int product3;
        //    for (int j = i + 1; j < 5; j++)
        //        for (int k = j + 1; k < 5; k++)
        //        {
        //            product3 = numbers[i] * numbers[j] * numbers[k];
        //            if (leastMajorityMultiple > product3)
        //                leastMajorityMultiple = product3;
        //        }
        //}

        Console.WriteLine(leastMajorityMultiple);
    }
}