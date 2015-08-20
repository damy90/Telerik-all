
namespace Student_Metods
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Start
    {
        static void Main()
        {
            Students[] students = 
            {
               new Students("Ivan", "Petrov", 12),
               new Students("Atanas", "Georgiev", 22),
               new Students("Georgi", "Atanassov", 50),
               new Students("Stamat", "Dimitrov", 19),
               new Students("Pesho", "Todorov", 27),
               new Students("Pesho", "Ivanov", 27),
               new Students("Pesho", "Peshev", 27),
               new Students("Pesho", "Andreev", 27)
            };

            var result = AgeSort(students);

            var sortedFirstNames = NameSort.NameSorter(students);


            var sortedFirsName = students.OrderBy(x => x.FirstName).Reverse(); // problem 6

            

        }

        
        
        static List<Students> AgeSort(Students[] input)  // problem 4
        {
            var result = new List<Students>();
            foreach (var student in input)
            {
                if (student.Age >= 18 && student.Age <= 24)
                {
                    result.Add(student);
                }
            }
            return result;
        }
    }
}
