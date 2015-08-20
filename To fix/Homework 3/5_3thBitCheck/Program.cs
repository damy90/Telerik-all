using System;

class Program
{
    static void Main()
    {
        int position = 3;
        int number;
        Console.WriteLine("Please enter a number");
        int.TryParse(Console.ReadLine(), out number);
        int mask = 1 << position;
        int numberAndMask = number & mask;
        int bit = numberAndMask >> position;
        Console.WriteLine(bit);
    }
}
