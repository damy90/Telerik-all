using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

// Условието е да се направи с 2 цикъла. :) За съжаление съм начинаещ и не ми хрумна нещо по-практично.
// За това го написах по този начин, но все пак работи :)

class CalculateFormulaNAndK
{
    static void Main()
    {
        Console.Write("Enter a number for 'n': ");
        BigInteger numbN = BigInteger.Parse(Console.ReadLine());

        Console.Write("Enter a number for 'k': ");
        BigInteger numbK = BigInteger.Parse(Console.ReadLine());

        //There was no way to continue the operation if N < K 
        if ((numbN < 0) || (numbK < 0) || (numbN < numbK))
        {
            Console.WriteLine("N can't be less than the K!");
        }
        Console.WriteLine();

        //Calculate "N-K"
        BigInteger numbNsubK = numbN - numbK;

        //Calculate factorial for "N"
        BigInteger tempValueN = 1;
        for (int i = 2; i <= numbN; i++)
        {
            tempValueN *= i;
        }

        //Calculate factorial for "K"
        BigInteger tempValueK = 1;
        for (int j = 2; j <= numbK; j++)
        {
            tempValueK *= j;
        }

        //Calculate factorial for "(N-K)!"
        BigInteger tempSubNK = 1;
        for (int g = 2; g <= numbNsubK; g++)
        {
            tempSubNK *= g;
        }

        //Calculate N!/(K!*(N-K)!)
        BigInteger result = tempValueN / (tempValueK * tempSubNK);
        if (result == 0)
        {
            Console.WriteLine("Something's wrong!");
        }
        else 
        {
            Console.WriteLine("Result: N!/(K!*(N-K)!) = {0}", result);
        }
    }
}
