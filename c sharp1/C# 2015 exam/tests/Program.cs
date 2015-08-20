using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tests
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = "Java-language";
            str.ToCharArray();
            string xx = new string(str.Where((ch, index) => (index+1) % 2 == 0).ToArray());
            Console.WriteLine(xx);
            string result = new string(EverySecondChar("Java-language").ToArray());
            Console.WriteLine(result);
            string result2 = EverySecondDidgit("Java-language");
            Console.WriteLine(result2);
        }
        protected static IEnumerable<char> EverySecondChar(string word)
        {
            for (int i = 1; i < word.Length; i += 2)
                yield return word[i];
        }

        protected static string EverySecondDidgit(string word)
        {
            char[] oddDidgits = new char[word.Length / 2];
            for (int i = 1; i < word.Length; i += 2)
                oddDidgits[i / 2] = word[i];
            return new string(oddDidgits);
        }
    }

}
