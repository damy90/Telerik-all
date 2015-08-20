using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace count1bits
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int accum = 4;
            while (accum > 0)
            {
                accum &= (accum - 1);
                count++;
            }
            Console.Write("{0}v\b", count);
            Console.Write("\b");
            Console.WriteLine();
        }
    }
}
