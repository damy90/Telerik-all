using System;

class Program
{
    static void Main()
    {
        Console.Title = "Read bit";
        int p;
        int i;
        byte v;
        Console.Write("Read a bit at a given position\nPlease enter a number: ");
        int.TryParse(Console.ReadLine(), out i);
        while (true)
        {
            Console.Write("Please enter position of the bit (0-31): ");
            if(int.TryParse(Console.ReadLine(), out p) && (p < 31 || p > 0))
                break;
            else
                Console.WriteLine("The value must be a number between 0 and 31");
        }
        Console.Write("Please enter bit value: ");
        while (true)
        {
            Console.Write("Please enter bit value (0 or 1): ");
            if(byte.TryParse(Console.ReadLine(), out v) && (v == 0 || v ==1) )
                break;
            else
                Console.WriteLine("The value must be 0 or 1");
        }
        if (v == 0)
        {
            int mask = ~(1 << p);
            int result = i & mask;
            Console.WriteLine("\nNumber in binary:\t{0}\nResult in binary:\t{1}\nResult - decimal:\t{2}"
                ,Convert.ToString(i, 2), Convert.ToString(result, 2), result);
        }
        else//(v == 1)
        {
            int mask = 1 << p;
            int result = i | mask;
            Console.WriteLine("\nNumber in binary:\t{0}\nResult in binary:\t{1}\nResult - decimal:\t{2}"
                ,Convert.ToString(i, 2).PadLeft(32, '0'), Convert.ToString(result, 2).PadLeft(32, '0'), result);
        }
    }
}