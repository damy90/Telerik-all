using System;

class NumberSequence
{
    static void Main()
    {
        //Replace 10 with 1000 for Problem 16
        int membersCount = 10;
        //solution with a loop
        for (int i = 2; i < membersCount + 2; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
            else
            {
                Console.WriteLine(-i);
            }
        }
    }
}