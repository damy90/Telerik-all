
namespace StringBuilder_Substring
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class NameSort
    {
        public static List<string> NameSorter(string[] students) 
        {
            var result = new List<string>();

            foreach (var student in students)
            {
                var names = new List<string>(student.Split(new char[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries));
                if (names.First().CompareTo(names.Last()) < 0)
                {
                    result.Add(student);
                }
            }

            return result;
        }
    }
}
