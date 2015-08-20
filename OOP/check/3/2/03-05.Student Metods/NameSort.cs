
namespace Student_Metods
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class NameSort
    {
        public static List<Students> NameSorter(Students[] students) 
        {
            var result = new List<Students>();

            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].FirstName.CompareTo(students[i].LastName) < 0)
                {
                    result.Add(students[i]);
                }
            }
            return result;
        }
    }
}
