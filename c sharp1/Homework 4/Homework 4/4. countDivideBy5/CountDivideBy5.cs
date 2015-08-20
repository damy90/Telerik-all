using System;

class CountDivideBy5
{
    //Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0.
    static void Main()
    {
        uint num1, num2;

        Console.Title = "How many numbers divide by 5 within a range";
        Console.Write("Please enter first number: ");
        while (true)
        {
            if (uint.TryParse(Console.ReadLine(), out num1))
                break;
            else
                Console.WriteLine("Please enter a positive integer number");
        }
        Console.Write("Please enter second number: ");
        while (true)
        {
            if (uint.TryParse(Console.ReadLine(), out num2))
                break;
            else
                Console.WriteLine("Please enter a positive integer number");
        }
        if (num1 > num2)
        {
            uint p = num1;
            num1 = num2;
            num2 = p;
        }

        uint count = 0;
        for (uint i = 0, range=num2-num1; i <= range; i++)
        {
            if ((num1 + i) % 5 == 0)
                count++;
        }
        Console.WriteLine("There are {0} numbers that divide by 5 within the range",count);
    }
}

