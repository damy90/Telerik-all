using System;

class FibonacciSequence
{
    static void Main()
    {
        Console.Title = "Fibonacci Sequence";
        int numberCount;
        Console.WriteLine("Please enter member coubnt!");
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out numberCount) && numberCount >= 1)
                break;
            else
                Console.WriteLine("Please enter a positive integer number");
        }

        for (double firstNumber = 0, secondNumber = 1, nextNumber, i = 1; i <= numberCount; i++)
        {
            Console.WriteLine(firstNumber);
            nextNumber = firstNumber + secondNumber;
            firstNumber = secondNumber;
            secondNumber = nextNumber;
        }
    }
}
