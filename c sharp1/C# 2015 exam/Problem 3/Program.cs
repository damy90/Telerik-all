using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

class Program
{
    static void Main()
    {
        //BigInteger n = BigInteger.Parse(Console.ReadLine());
        BigInteger n = 99999999999999999;
        int transformCount = 0;
        //10 transforms || number < one didgit
        for (; n > 9 && transformCount < 10; transformCount++)
        {
            BigInteger product = 1;
            //find product
            while (n > 100)
            {
                n /= 10;

                int sumOdd = 0;
                //BigInteger allOddDidgits = BigInteger.Parse(new string(EverySecondChar(n.ToString()).ToArray()));
                BigInteger allOddDidgits = BigInteger.Parse(EverySecondDidgit(n.ToString()));
                //find sum
                while (allOddDidgits > 0)
                {
                    sumOdd += (int)(allOddDidgits % 10);
                    allOddDidgits /= 10;
                }
                if (sumOdd != 0)
                {
                    product *= sumOdd;
                }
            }
            n = product;
        }

        if (transformCount < 10)
        {
            Console.WriteLine(transformCount);
            Console.WriteLine(n);
        }
        else
        {
            Console.WriteLine(n);
        }
    }

    protected static IEnumerable<char> EverySecondChar(string word)
    {
        for (int i = 1; i < word.Length; i += 2)
            yield return word[i];
    }

    protected static string EverySecondDidgit(string word)
    {
        char[] oddDidgits = new char[word.Length/2];
        for (int i = 1; i < word.Length; i += 2)
            oddDidgits[i/2]= word[i];
        return new string(oddDidgits);
    }
}
