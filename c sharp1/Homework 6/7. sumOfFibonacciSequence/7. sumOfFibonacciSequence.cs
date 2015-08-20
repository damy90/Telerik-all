using System;

//check the results with http://www.wolframalpha.com/
//example expression: sum fibonacci(x) for x from 1 to 10

class FibonacciSequence
{
    static void Main()
    {
        Console.Title = "Sum of N members of Fibonacci sequence";

        uint membersCount;
        Console.Write("Please enter how many members to sum: ");
        while (true)
        {
            if (uint.TryParse(Console.ReadLine(), out membersCount))
                break;
            Console.Write("Please enter a positive integer number: ");
        }

        long firstNumber = 0, secondNumber = 1, nextNumber, sum=0;
        Console.Title = "Fibonacci Sequence";
        //Console.WriteLine("The sequence is: ");   //->show the sequence

        for (uint i = 1; i <= membersCount; i++)
        {
            //Console.Write("{0}, ",firstNumber);   //->show the sequence
            
            nextNumber = firstNumber + secondNumber;
            firstNumber = secondNumber;
            secondNumber = nextNumber;
            sum += firstNumber;//fixed
        }

        Console.WriteLine("\n\nThe sum is: {0}", sum);
    }
}
