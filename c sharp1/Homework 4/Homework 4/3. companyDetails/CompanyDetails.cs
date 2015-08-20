//A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
//Write a program that reads the information about a company and its manager and prints it back on the console.
using System;

class CompanyDetails
{
    //A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
    //Write a program that reads the information about a company and its manager and prints it back on the console.
    /*
     * Example input:
    Company name:	Telerik Academy
    Company address:	31 Al. Malinov, Sofia
    Phone number:	+359 888 55 55 555
    Fax number:	
    Web site:	http://telerikacademy.com/
    Manager first name:	Nikolay
    Manager last name:	Kostov
    Manager age:	25
    Manager phone:	+359 2 981 981
     */

    static void Main()
    {
        Console.Title = "Company database";

        //Hard coded test. You can comment the input block if you're too lazy to type
        string compName = "Roga i kopita LTD";
        string compAddress = "The North Pole";
        string compPhone = "0000-666-666";
        string compFax = "0000-999-999";
        string compWeb = "www.WorldWideWeb.com";
        string managerFirstName = "Hristo";
        string managerLastName = "Hristoskov";
        int managerAge = 62;
        string managerPhone = "0000-333-333";

        //Input
        //Comment this to use the hardcoded test
        Console.WriteLine("Please enter company information.");
        Console.Write("Company name: ");
        compName = Console.ReadLine();
        Console.Write("Company address: ");
        compAddress = Console.ReadLine();
        Console.Write("Phone number: ");
        compPhone = Console.ReadLine();
        Console.Write("Manager first name: ");
        managerFirstName = Console.ReadLine();
        Console.Write("Manager last name: ");
        managerLastName = Console.ReadLine();
        Console.Write("Manager Age: ");
        int.TryParse(Console.ReadLine(), out managerAge);
        Console.Write("Manager phone: ");
        managerPhone = Console.ReadLine();

        //Output
        Console.WriteLine("\nCompany details:\n");
        Console.WriteLine("{0,-15} {1}", "Name:", compName);
        Console.WriteLine("{0,-15} {1}", "Address:", compAddress);
        Console.WriteLine("{0,-15} {1}", "phone:", compPhone);
        Console.WriteLine("{0,-15} {1}", "fax:", compFax);
        Console.WriteLine("{0,-15} {1}", "website:", compWeb);

        Console.WriteLine("\n\nManager details:\n");
        Console.WriteLine("{0,-15} {1}", "First name:", managerFirstName);
        Console.WriteLine("{0,-15} {1}", "Last name:", managerLastName);
        Console.WriteLine("{0,-15} {1}", "Age:", managerAge);
        Console.WriteLine("{0,-15} {1}\n\n", "Phone:", managerPhone);
    }
}

