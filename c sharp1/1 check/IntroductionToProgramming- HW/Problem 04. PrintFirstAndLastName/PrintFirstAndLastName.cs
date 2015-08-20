//Create console application that prints your first and last name, each at a separate line.

using System;

class PrintFirstAndLastName
{
    static void Main()
    {
        string firstName = "Andriy";
        string lastName = "Shevchenko";
        Console.WriteLine("My first name is {0}", firstName);
        Console.WriteLine("My last name is {0}", lastName);
        Console.WriteLine(); // this code make new line
        Console.WriteLine("My first name is {0}\nMy last name is {1}", firstName, lastName);
    }
}

