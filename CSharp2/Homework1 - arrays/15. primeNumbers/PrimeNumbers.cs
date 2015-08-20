using System;

//Write a program that finds all prime numbers in the range [1...10 000 000]. Use the sieve of Eratosthenes algorithm (find it in Wikipedia).
// За да провериш резлтата виж този сайт: http://www.wolframalpha.com/input/?i=prime+numbers+from+1+to+10000000
class PrimeNumbers
{
    static void Main()
    {
        bool[] isPrime = new bool[10000000];
        for (int i = 2; i < isPrime.Length; i++)
            isPrime[i] = true;

        for (int i = 2; i < Math.Sqrt(isPrime.Length); i++)
            for (int j = i * i; j < isPrime.Length; j += i)
                isPrime[j] = false;

        for (int i = 2; i < isPrime.Length; i++)
            if (isPrime[i])
                Console.Write("{0}, ", i);
    }
}
