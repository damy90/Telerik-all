using System;
//You are given a sequence of positive integer values written into a string, separated by spaces. Write a function that reads these values from given string and calculates their sum.
//Example: string = "43 68 9 23 318" => result = 461
class Program
{
    static void Main()
    {
        string input = "43 68 9 23 318";
        string[] numbers = input.Split(' ');
        int sum = SumNumbers(numbers);
        Console.WriteLine(sum);
    }

    private static int SumNumbers(string[] numbers)
    {
        int sum = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            sum = sum + int.Parse(numbers[i]);
            Console.Write("{0}{1}", i > 0 ? "+" : "", numbers[i]);
        }

        return sum;
    }
}
