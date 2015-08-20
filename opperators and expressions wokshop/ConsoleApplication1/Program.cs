using System;



class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));

        int mask1 = 7 << 3;
        int mask2 = 7 << 24;
        int clearMask = ~(mask1 | mask2);

        int result=((clearMask&number)|((number&mask1)<<21)|((number&mask2)>>21));
    }
}
