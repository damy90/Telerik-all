using System;

class InputChoice
{
    //ite a program that, depending on the user’s choice, inputs an int, double or string variable.
    //*If the variable is int or double, the program increases it by one.
    //*If the variable is a string, the program appends * at the end.
    //Print the result at the console. Use switch statement.
    static void Main()
    {
        Console.Title = "Choose input type";

        Console.WriteLine("Press a key to choose input type\n1 --> int\n2 --> double\n3 --> string");
        char inputType = Console.ReadKey().KeyChar;

        switch (inputType)
        {
            case '1':
                int intInput;
                Console.Write("\nPlease enter an integer number: ");
                if (int.TryParse(Console.ReadLine(), out intInput))
                    Console.WriteLine("Number incremented by 1: {0}", intInput + 1);
                else
                    Console.WriteLine("Invalid input");
                break;

            case '2':
                double doubleInput;
                Console.Write("Please a double number: ");
                if (double.TryParse(Console.ReadLine(), out doubleInput))
                    Console.WriteLine("Number incremented by 1: {0}", doubleInput + 1);
                else
                    Console.WriteLine("Invalid input");
                break;

            case '3':
                Console.Write("Please enter text: ");
                string stringInput = (Console.ReadLine());
                Console.WriteLine("Appended string: {0}", stringInput + "*");
                break;
            default:
                Console.WriteLine("Invalid choice");
                break;
        }
    }
}
