using System;
using System.Linq;

namespace ToyStore.SampleDataGenerator
{
    public sealed class RandomGenerator :IRandomGenerator
    {
        private static IRandomGenerator _instance;
        private readonly Random random;
        private const string Chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";

        private RandomGenerator()
        {
            random = new Random();
        }

        public static IRandomGenerator Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new RandomGenerator();
                }
                return _instance;
            }
        }

        public int GetRandomNumber(int min, int max)
        {
            return random.Next(min, max);
        }
        public string GetRandomString(int size)
        {
            char[] buffer = new char[size];

            for (int i = 0; i < size; i++)
            {
                buffer[i] = Chars[random.Next(Chars.Length)];
            }
            return new string(buffer);
        }

        public string GetRandomStringRandomLength(int minLength, int maxLength)
        {
            int randomLength = GetRandomNumber(minLength, maxLength);
            return GetRandomString(randomLength);
        }
    }
}
