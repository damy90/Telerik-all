﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.RecurrentSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 2;
            Queue<int> sequence = new Queue<int>();
            sequence.Enqueue(n);

            for (int i = 0; i < 50; i++)
            {
                int currentNumber = sequence.Dequeue();

                Console.WriteLine(currentNumber);

                sequence.Enqueue(currentNumber + 1);
                sequence.Enqueue(2 * currentNumber + 1);
                sequence.Enqueue(currentNumber + 2);
            }
        }
    }
}
