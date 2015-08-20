using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] subCubePrepertiesInput = Array.ConvertAll(Console.ReadLine().Split(new char[] { '(', ')', '|' }), p => p.Trim()).Where(x => !string.IsNullOrEmpty(x)).ToArray();
            foreach (string command in subCubePrepertiesInput)
                Console.WriteLine(command.Trim());
        }
    }
}
