//We are given a school. In the school there are classes of students. Each class has a set of teachers.
//Each teacher teaches a set of disciplines. Students have name and unique class number. Classes have unique text identifier.
//Teachers have name. Disciplines have name, number of lectures and number of exercises. Both teachers and students are people.
//Students, classes, teachers and disciplines could have optional comments (free text block).
//Your task is to identify the classes (in terms of  OOP) and their attributes and operations, encapsulate their fields, define the class hierarchy and create a class diagram with Visual Studio.
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        //some tests
        Student go6o = new Student("Go6o", 1245);
        Student to6o = new Student("To6o", 2345);
        to6o.AddComment("YOU SHAL NOT PAAAAASSS!!!");
        to6o.AddComment("To be expelled");

        Discipline borringStuff = new Discipline("Borring Stuff", 100, 1);
        List<Discipline> profesorovDisciplines = new List<Discipline>()
        {
            borringStuff
        };
        Teacher profesorov = new Teacher("Profesorov", profesorovDisciplines);
        //create class
        List<Student> class1AStudents = new List<Student>()
        { 
            to6o, go6o
        };
        List<Teacher> class1ATeachers = new List<Teacher>()
        {
            profesorov
        };
        List<SchoolClass> TUClasses2 = new List<SchoolClass>()
        {
            new SchoolClass(class1AStudents, "Class 1-A", class1ATeachers)
        };
        School TU = new School(TUClasses2);
    }
}
