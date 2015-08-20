using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using TelerikAcademy.Models;

namespace _2.TolListTest
{
    class Program
    {
        static void Main(string[] args)
        {
            TelerikAcademyEntities db = new TelerikAcademyEntities();

            Stopwatch sw = new Stopwatch();
            sw.Start();

            var query = db.Employees.ToList()
                .Select(employee => employee.Address).ToList()
                .Select(employee => employee.Town).ToList()
                .Where(employee => employee.Name == "Sofia").ToList();

            sw.Stop();

            var slow = sw.Elapsed;
            Console.WriteLine("{0} employees found", query.Count);

            sw.Restart();

            var querySmart = db.Employees
               .Select(employee => employee.Address)
               .Select(employee => employee.Town)
               .Where(employee => employee.Name == "Sofia").ToList();

            sw.Stop();

            Console.WriteLine("{0} employees found", querySmart.Count);
            Console.WriteLine("Slow: {0}\nFast: {1}", slow, sw.Elapsed);
            //1298 vs 13 queries
        }
    }
}
