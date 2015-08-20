using System;
using System.Linq;
using TelerikAcademy.Models;
using System.Diagnostics;

namespace _1.EFTestInclude
{
    class Program
    {
        static void Main(string[] args)
        {
            TelerikAcademyEntities db = new TelerikAcademyEntities();

            //1.Using Entity Framework write a SQL query to select all employees from the Telerik Academy
            //database and later print their name, department and town. Try the both variants: with and
            //without .Include(…). Compare the number of executed SQL statements and the performance.

            Stopwatch sw = new Stopwatch();

            Console.WriteLine("Controll test (no Include)");
            sw.Start();
            foreach (var employee in db.Employees)
            {
                Console.WriteLine("Name: {0} {1}\nDepartment: {2}\nTown: {3}\n\n", employee.FirstName, employee.LastName, employee.Department.Name, employee.Address.Town.Name);
            }
            sw.Stop();
            var noIncludeTime = sw.Elapsed;

            Console.WriteLine("\nInclude test");
            sw.Restart();
            foreach (var employee in db.Employees.Include("Address").Include("Department"))
            {
                Console.WriteLine("Name: {0} {1}\nDepartment:{2}\nTown: {3}\n\n", employee.FirstName, employee.LastName, employee.Department.Name, employee.Address.Town.Name);
            }
            sw.Stop();
            Console.WriteLine("Without Include:\t{0}\nWith Include:\t\t{1}", noIncludeTime, sw.Elapsed);

            //355 vs 6 queries
        }
    }
}
