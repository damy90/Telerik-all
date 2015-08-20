using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.MinimumEditDistance
{
    class Program
    {
        static void Main(string[] args)
        {
            var result1 = levenshtein("developer", "enveloped");
            Console.WriteLine("Words: developer -> enveloped");
            Console.WriteLine("Distance = {0}", result1);
        }

        public static decimal levenshtein(String a, String b)
        {
            // close enough
            decimal replaceCost = .9m;
            decimal deleteCost = .8M;
            decimal insertCost = 1M;

            decimal cost;
            int firstLength = a.Length;
            int secondLength = b.Length;
            decimal[,] d = new decimal[firstLength + 1, secondLength + 1];
            decimal delete;
            decimal insert;
            decimal replace;
            // delete
            for (int i = 0; i <= firstLength; i++)
            {
                d[i, 0] = i * deleteCost;
            }

            //insert
            for (int i = 0; i <= secondLength; i++)
            {
                d[0, i] = i * insertCost;
            }


            for (int i = 1; i <= firstLength; i++)
            {
                for (int j = 1; j <= secondLength; j++)
                {
                    cost = Convert.ToInt32(!(a[i - 1] == b[j - 1])) * replaceCost;

                    delete = d[i - 1, j] + 1;
                    insert = d[i, j - 1] + 1;
                    replace = d[i - 1, j - 1] + cost;
                    d[i, j] = Math.Min(Math.Min(delete, insert), replace);
                }
            }

            return d[firstLength, secondLength];

        }
    }

}
