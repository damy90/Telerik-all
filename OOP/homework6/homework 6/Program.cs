using System;

class Program
{
    static void Main()
    {
        Student jarjar = new Student("Jar", "Jar", "Binks", 442364728, "In a galaxy far, far away", "0866 66 66", "the.force@gmail.com",
            4, Faculty.ET, Specialty.HydroBiology, University.TU);
        Console.WriteLine(jarjar);
        Console.WriteLine();

        Student joro = jarjar.Clone();
        joro.FirstName = "Joro";
        Console.WriteLine(joro);
        Console.WriteLine("Joro IS Jar Jar: {0}", joro == jarjar);//compares SSN
        Console.WriteLine("Joro is bigger than Jar Jar: {0}", joro.CompareTo(jarjar)>0);
    }
}
