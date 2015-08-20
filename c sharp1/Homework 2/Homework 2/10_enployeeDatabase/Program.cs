//A marketing company wants to keep record of its employees. Each record would have the following characteristics:

//First name
//Last name
//Age (0...100)
//Gender (m or f)
//Personal ID number (e.g. 8306112507)
//Unique employee number (27560000…27569999)

//Declare the variables needed to keep the information for a single employee using appropriate primitive data types. Use descriptive names. Print the data at the console.

using System;

class Program
{
    static void Main()
    {
        string firstName = "Hristo";
        string familyName = "Hristoskov";
        byte age = 66;
        char gender = 'm';
        ulong idNumber = 8306112507;
        uint employeeNumber = 27569999;

        Console.WriteLine("First name:\t{0}\nFamily name:\t{1}\nAge:\t\t{2}", firstName, familyName, age);
        //Console.WriteLine with condition (if gender == 'm' print "Male" else "Female"
        Console.WriteLine("Gender\t\t{0}\nID Number\t{1}\nEmployee number\t{2}",
            gender == 'm' ? "Male" : "Female", idNumber, employeeNumber);
    }
}
