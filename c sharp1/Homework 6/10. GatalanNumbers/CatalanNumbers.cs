using System;

//check the results with http://www.wolframalpha.com/
//Catalan number 6

class CatalanNumbers
{
    static void Main()
    {
        Console.Title = "Calculate Catalan number";
        uint number;
        Console.Write("Please enter a number: ");
        while (true)
        {
            if (uint.TryParse(Console.ReadLine(), out number))
                break;
            else
                Console.Write("Please enter a positive integer number: ");
        }

        long divisor = 1;         //divisor = N!. Съкратил съм (2N)! и (N+1)!
        long numerator = 1;
        for (uint i = 1; i <= number; i++)
            divisor *= i;
        for (uint i = number + 2; i <= 2 * number; i++)
            numerator *= i;

        long result = numerator / divisor;
        Console.WriteLine(result);

        //ugly single loop algorithm 
        long r;
        int j;
        for (j = 1, r = 1; j < number; j += 1)
            r = r * (number + j + 1) / j;

        Console.WriteLine("Ugly single loop algorithm: {0}", r / j);
    }
}
