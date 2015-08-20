

namespace StringBuilder_Substring
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        /* Write a method that from a given array of students finds all students whose first name is before its last name alphabetically.
Use LINQ query operators.*/

        static void Main()
        {
            string testa = "1234567890";
            string test = testa.Substring(0, 5);
            Console.WriteLine(test);

            var sectest = new StringBuilder("1234567890");
            var sbtest = sectest.SubString(0, 5);
            Console.WriteLine(sbtest.ToString());

            string[] students = { "Aleks Niklev", "Bobi Vasev", "Vasil Aleksandrow" };
            var result = NameSort.NameSorter(students);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
