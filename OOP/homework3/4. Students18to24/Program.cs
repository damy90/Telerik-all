//Write a LINQ query that finds the first name and last name of all students with age between 
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

        var studentNameBeforeLastName =
            from student in students
            where student.age <= 24 && student.age >= 18
            select student;

        foreach (var student in studentNameBeforeLastName)
            Console.WriteLine(student);
    }
}
