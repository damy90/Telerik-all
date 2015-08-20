using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.PriorityQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            PriorityQueue<int> heap = new PriorityQueue<int>();
            heap.Enqueue(1);
            heap.Enqueue(2);
            heap.Enqueue(3);
            heap.Enqueue(4);
            heap.Dequeue();
            heap.Enqueue(3);
            heap.Enqueue(5);
            Console.WriteLine(heap.ToString());
            Console.WriteLine(heap.Dequeue());
            Console.WriteLine(heap.ToString());
            heap.Enqueue(2);
            Console.WriteLine(heap.ToString());
        }
    }
}
