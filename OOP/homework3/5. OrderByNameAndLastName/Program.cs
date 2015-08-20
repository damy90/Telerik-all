//Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name and last name in descending order.
//Rewrite the same with LINQ.
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var students = new[]
        {
            new {name="Goshko", lastName="Andreev", age=17},
            new {name="Andery", lastName="Goshkov", age=24},
            new {name="Anton", lastName="Bu", age=2105},
            new {name="Hristo", lastName="Hristoskow", age=18},
            new {name="Phantom", lastName="Student", age=20}

        };
        //lambda expression
        var sortBuNameAndLastName = students
            .OrderBy(student => student.name)
            .ThenBy(student => student.lastName);

        foreach (var student in sortBuNameAndLastName)
            Console.WriteLine(student);
        Console.WriteLine();
        //LINQ
        var result = 
            from student in students
            orderby student.name descending, student.lastName descending
                     select student;

        foreach (var student in result)
            Console.WriteLine(student);
    }
}
