//Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned integer.
//The first and the second sequence of bits may not overlap.

using System;

class SwitchBits
{
    static void Main()
    {
        //read the values
        Console.Write("Enter the number: ");
        uint number = uint.Parse(Console.ReadLine());
        int bitCount;
        while (true)
        {
            Console.Write("Enter the number of bits (between 1 and 16): ");

            if (int.TryParse(Console.ReadLine(), out bitCount) && bitCount >= 1 && bitCount <= 16)
                break;
            else
                Console.WriteLine("The value is out of limits");
        }

        int maxPosition = 31 - bitCount;
        int position1;
        while (true)
        {
            Console.Write("Enter the first position (between 0 and {0}): ", 31 - bitCount);

            if (int.TryParse(Console.ReadLine(), out position1) && position1 >= 0 && position1 <= maxPosition)
                break;
            else
                Console.WriteLine("The value is out of limits");
        }

        int position2;
        while (true)
        {
            if ((position1 - bitCount) < -1 || (position1 + 2 * (bitCount - 1)) > 31)//single interval
            {
                Console.Write("Enter the second position (between {0} and {1}): "
                , ((position1 - bitCount - 1) > 0) ? 0 : (position1 + bitCount), ((position1 - bitCount - 1) > 0) ? position1 - bitCount : 31 - bitCount);
            }
            else if (!((position1 - bitCount) < -1 || (position1 + 2 * (bitCount - 1)) > 31))//double interval
            {
                Console.Write("Enter the second position (between{0}{1} and between {2} and {3}): ",
                    position1 - bitCount == 0 ? "" : " 0 and ", position1 - bitCount, position1 + bitCount, 31 - bitCount);
            }

            if (int.TryParse(Console.ReadLine(), out position2) && position2 >= 0 && position2 <= maxPosition && (position2 >= (position1 + bitCount) || position2 <= (position1 - bitCount)))
                break;
            else
                Console.WriteLine("The value is out of limits");
        }

        if (position1 > position2)
        {
            int p = position1;
            position1 = position2;
            position2 = p;
        }

        //output the binary number
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));


        uint mask1 = 0;
        uint mask2 = 0;

        for (int i = 0; i <= bitCount - 1; i++)
        {
            mask1 |= ((uint)1) << (i + position1);
            mask2 |= ((uint)1) << (i + position2); ;
        }

        uint clearMask = ~(mask1 | mask2);
        int distance = position2 - position1;

        uint result = (number & clearMask) | ((number & mask1) << distance) | ((number & mask2) >> distance);
        Console.WriteLine(Convert.ToString(result, 2).PadLeft(32, '0'));
    }
}