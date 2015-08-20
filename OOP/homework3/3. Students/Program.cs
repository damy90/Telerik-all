//Write a method that from a given array of students finds all students whose first name is before its last name alphabetically.
//Use LINQ query operators.
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var students = new[]
        {
            new {name="Goshko", lastName="Andreev"},
            new {name="Andery", lastName="Goshkov"},
            new {name="Anton", lastName="Bu"}
        };

        var studentNameBeforeLastName =
            from student in students
            where student.name.CompareTo(student.lastName)<0
            select student;

        foreach (var student in studentNameBeforeLastName)
            Console.WriteLine("{0} {1}",student.name, student.lastName);
    }
}
