//Write an expression that extracts from given integer n the value of given bit at index p.

using System;

class ReadBit
{
    static void Main()
    {
        Console.Title = "Read bit at position";
        int p;
        int i;
        Console.Write("Read a bit at a given position\nPlease enter a number: ");
        int.TryParse(Console.ReadLine(), out i);
        Console.Write("Please enter position of the bit: ");
        int.TryParse(Console.ReadLine(), out p);
        int mask = 1 << p;
        int numberAndMask = i & mask;
        int bit = numberAndMask >> p;
        Console.WriteLine("value= {0}",bit);
    }
}