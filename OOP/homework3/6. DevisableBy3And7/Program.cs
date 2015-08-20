//Write a program that prints from given array of integers all numbers that are divisible by 7 and 3.
//Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        //lambda expression
        List<int> list = new List<int>() { 21, 42, 4, 44 };
        List<int> divisable = list.FindAll(x => (x % 21) == 0);
        foreach (var num in divisable)
            Console.WriteLine("{0} ", num);

        Console.WriteLine();
        //LINQ
        var divisableLinq =
            from num in list
            where (num % 21 == 0)
            select num;

        foreach (var num in divisableLinq)
            Console.WriteLine("{0} ", num);
    }
}
