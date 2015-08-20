using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        //9. Create a List<Student> with sample students. Select only the students that are from group number 2.
        //Use LINQ query. Order the students by FirstName.
        var students = new List<Student>();
        var marks = new List<float>() { 2, 2, 6 };
        var student = new Student("Go6ko", "Go6kov", "35560637", "02 666666", "go6ko@abv.bg", marks, 2);
        students.Add(student);
        marks = new List<float>() { 3, 4, 6 };
        student = new Student("Joro", "Go6kov", "35560634", "03 333333", "joro@abv.bg", marks, 1);
        students.Add(student);
        marks = new List<float>() { 5, 4 };
        student = new Student("Ani", "Go6kova", "45560333", "03 333333", "ani@gmail.bg", marks, 2);
        students.Add(student);

        var selectedStudents = from x in students
                               where x.GroupNumber == 2
                               orderby x.FirstName
                               select x;

        Console.WriteLine("Students from group 2:");
        foreach (var printStudent in selectedStudents)
        {
            Console.WriteLine("{0}, group {1}", printStudent.FirstName, printStudent.GroupNumber);
        }

        //10. Implement the previous using the same query expressed with extension methods.
        var selectedStudents2 = students.Where(x => x.GroupNumber == 2)
            .OrderBy(x => x.FirstName);

        Console.WriteLine("Students from group 2:");
        foreach (var printStudent in selectedStudents2)
        {
            Console.WriteLine("{0}, group {1}", printStudent.FirstName, printStudent.GroupNumber);
        }

        //11. Extract all students that have email in abv.bg.
        //Use string methods and LINQ.
        var selectStudentsWithEmail = from x in students
                                      where x.Email.Contains("@abv.bg")
                                      select x;

        Console.WriteLine("Students with abv.bg email:");
        foreach (var printStudent in selectStudentsWithEmail)
        {
            Console.WriteLine("{0}, Email {1}", printStudent.FirstName, printStudent.Email);
        }

        //12. Extract all students with phones in Sofia.
        //Use LINQ.
        var selectStudentsFromSofia = from x in students
                                      where x.Tel.StartsWith("02")
                                      select x;

        Console.WriteLine("Students with phones in Sofia:");
        foreach (var printStudent in selectStudentsFromSofia)
        {
            Console.WriteLine("{0}, Tel: {1}", printStudent.FirstName, printStudent.Tel);
        }

        //13. Select all students that have at least one mark Excellent (6) into a new anonymous class that has properties – FullName and Marks.
        //Use LINQ.

        var selectStudentsWithExelent = from x in students
                                        where x.Marks.IndexOf(6) != -1
                                        select new
                                        {
                                            FullName = string.Format("{0} {1}", x.FirstName, x.LastName),
                                            Marks = x.Marks
                                        };

        Console.WriteLine("Students with an exelent mark:");
        foreach (var printStudent in selectStudentsWithExelent)
        {
            Console.WriteLine("{0}, Marks: {1}", printStudent.FullName, string.Join(", ", printStudent.Marks));
        }

        //14. Write down a similar program that extracts the students with exactly two marks "2".
        //Use extension methods.
        var selectStudentsTwoMarks = students.Where(x => x.Marks.Count == 2)
            .Select(x => new
            {
                FullName = string.Format("{0} {1}", x.FirstName, x.LastName),
                Marks = x.Marks
            });

        Console.WriteLine("Students with 2 marks:");
        foreach (var printStudent in selectStudentsTwoMarks)
        {
            Console.WriteLine("{0}, Marks: {1}", printStudent.FullName, string.Join(", ", printStudent.Marks));
        }

        //16. Extract all students from "Mathematics" department.
        //Use the Join operator.
        Group group1 = new Group(1, "Mathematics");
        Group group2 = new Group(2, "Engineering");

         List<Group> groups = new List<Group>{group1, group2};

            var studentsFromMathDpt =
                from g in groups
                where g.GroupNumber == 1
                join s in students on g.GroupNumber equals s.GroupNumber
                select new
                {          
                    Name = s.FirstName,
                    Department = g.DepartmentName
                };

            Console.WriteLine("Students from math department:");
            foreach (var printStudent in studentsFromMathDpt)
            {
                Console.WriteLine("{0} department: {1}", printStudent.Name, printStudent.Department);
            }

        //17. Extract all Marks of the students that enrolled in 2006. (The students from 2006 have 06 as their 5-th and 6-th digit in the FN).
        var studentsMarks2006 = students.Where(x => x.FN[4] == '0' && x.FN[5] == '6')
            .SelectMany(x => x.Marks);

        Console.WriteLine("All marks from students enrolled in 2006: {0}", string.Join(", ", studentsMarks2006));

        //18. Create a program that extracts all students grouped by GroupNumber and then prints them to the console.
        //Use LINQ.
        var studentsGroupedByGroup=from s in students
                                   orderby s.GroupNumber
                                   group s by s.GroupNumber;

        foreach (var group in studentsGroupedByGroup)
        {
            Console.WriteLine("Group {0}", group.Key);
            foreach (var printStudent in group)
            {
                Console.WriteLine("{0} group: {1}", printStudent.FirstName, printStudent.GroupNumber);
            }
        }

        //19. Rewrite the previous using extension methods.
        studentsGroupedByGroup = students.GroupBy(x => x.GroupNumber)
            .OrderBy(x=>x.Key);

        foreach (var group in studentsGroupedByGroup)
        {
            Console.WriteLine("Group {0}", group.Key);
            foreach (var printStudent in group)
            {
                Console.WriteLine("{0} group: {1}", printStudent.FirstName, printStudent.GroupNumber);
            }
        }
    }
}
