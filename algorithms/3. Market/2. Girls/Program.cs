using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Girls
{
    class Program
    {
        private static List<string> personalCombinations=new List<string>();
        private static string[] combination;
        private static int N;
        private static int count = 0;

        static void Main(string[] args)
        {
            int K = int.Parse(Console.ReadLine());//shirts count
            string L = Console.ReadLine();//skirts wariant string
            N = int.Parse(Console.ReadLine());//girls count
            combination = new string[N];

            for (int i = 0; i < K; i++)
            {
                for (int j = 0; j < L.Length; j++)
                {
                    //stringformat
                    personalCombinations.Add("" + i + L[j]);
                }
            }

            Combinations(0);
            Console.WriteLine(count);
            /*foreach (var item in personalCombinations)
            {
                Console.WriteLine(item);
            }*/
        }

        private static void Combinations(int index, int depth = 0)
        {
            if (depth >= N)// && combination[0][0]!=combination[1][0]
            {
                if (combination[0][0] != combination[1][0] && combination[0][1] != combination[1][1])
                {
                    Console.WriteLine(string.Join("-", combination));
                    count++;
                }

                return;
            }

            for (int i = index; i < personalCombinations.Count; i++, index++)
            {
                // set used
                combination[depth] = personalCombinations[i];
                Combinations(index + 1, depth + 1);
            }
        }
    }
}
