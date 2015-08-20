using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int[] number = new int[N];
        int[] newNumber = new int[N];

        for (int i = 0; i < N; i++)
            number[i] = int.Parse(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {
            int largestBitPos = 0;
            for (int bitPos = 0; bitPos < 32 && (1 << bitPos) <= number[i]; bitPos++)
            {
                largestBitPos = bitPos;
            }
            int reverse = 0;
            if( (largestBitPos%2)!=0 )
                reverse |= number[i] & (1 << (largestBitPos / 2));
            for (int n = 0; n <= largestBitPos / 2; n++)
            {
                int mask1 = 1 << n;
                int mask2 = 1 << (largestBitPos - n);
                int value1 = number[i] & mask1;
                int value2 = number[i] & mask2;
                if (value1!=0)
                    reverse |= mask2;
                if (value2 != 0)
                    reverse |= mask1;
            }
            newNumber[i] = reverse;
        }
        for (int i = 0; i < N; i++)
            Console.WriteLine(newNumber[i]);
    }
}
