using System;

class Program
{
    static void Main()
    {
        int[] bitsCount = new int[8];
        int[] result = new int[8];

        for (int i = 0; i < 8; i++)
        {
            int number;
            int.TryParse(Console.ReadLine(), out number);
            for (int mask, position = 0; position < 8; position++)
            {
                mask = 1 << position;
                if ( ((number & mask) >> position) == 1)
                    bitsCount[position]++;
            }
        }

        for (int position = 0; position < 8; position++)
            for (; bitsCount[position] > 0; bitsCount[position]--)
                result[8 - bitsCount[position]] |= (1 << position);// (int)Math.Pow(2, position);

        for (int i = 0; i < 8; i++)
            Console.WriteLine(result[i]);
    }
}
