using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computers.UI.Console
{
    public static class RandomGenerator
    {
        public static int GenerateRandomNumber(int a, int b)
        {
            var randomNumberGenerator = new Random();
            int result = randomNumberGenerator.Next(a, b + 1);
            return result;
        }
    }
}
