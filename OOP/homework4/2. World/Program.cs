//Define abstract class Human with first name and last name.
//Define new class Student which is derived from Human and has new field – grade.
//Define class Worker derived from Human with new property WeekSalary and WorkHoursPerDay and method MoneyPerHour() that returns money earned by hour by the worker.
//Define the proper constructors and properties for this hierarchy. Initialize a list of 10 students and sort them by grade in ascending order.
//Initialize a list of 10 workers and sort them by money per hour in descending order.
//Merge the lists and sort them by first name and last name.
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>()
        {
            new Student ("Angel", "Angelov", 'A'),
            new Student ("Bojidar", "Georgiev", 'F'),
            new Student ("Gosho", "Goshev", 'F'),
            new Student ("Anton", "Ivanov", 'F'),
            new Student ("Choveka", "Paiak", 'C'),
            new Student ("Ne", "Se", 'C'),
            new Student ("Seshtam", "Za", 'F'),
            new Student ("Poveche", "Imena", 'F'),
            new Student ("Asff", "Gksla", 'F'),
            new Student ("Hdww", "Gsswq", 'F')
        };
        var sortStudents = students.OrderByDescending(student => student.Grade);

        Console.WriteLine("\tSorted students");
        foreach (var student in sortStudents)
            Console.WriteLine("{0} {1} grade: {2}",student.Name, student.LastName, student.Grade);

        List<Worker> workers = new List<Worker>()
        {
            new Worker ("Chavdar", "Angelov", 200, 8),
            new Worker ("Bojidar", "Simeonov", 100, 4),
            new Worker ("Hristo", "Hristov", 100, 6),
            new Worker ("Anton", "Stoev", 150, 8),
            new Worker ("Adash", "Adashov", 100, 7),
            new Worker ("Bai", "Shefa", 1000, 2),
            new Worker ("Sina Na", "Shefa", 1000, 1),
            new Worker ("Avtomat", "Avtomatov", 0, 24),
            new Worker ("Fantom", "Fantomov", 100, 1),
            new Worker ("Iako", "Ime", 34, 3)
        };

        var sortWorkers = workers.OrderByDescending(worker => worker.MoneyPerHour());

        Console.WriteLine("\tSorted workers");
        foreach (var worker in sortWorkers)
            Console.WriteLine("{0} {1} Money Per Hour: {2}", worker.Name, worker.LastName, worker.MoneyPerHour());

        var mergedlists = workers.Concat<Human>(students).ToList();
        var sortEveryone = mergedlists
            .OrderBy(person => person.Name)
            .ThenBy(person => person.LastName);

        Console.WriteLine("\tSorted people");
        foreach (var person in sortEveryone)
            Console.WriteLine("{0} {1}", person.Name, person.LastName);
    }
}
