using System;
class AgeIn10Years
{
    static void Main()
    {
        int age;
        Console.WriteLine("Please enter your age ");
        while (true)//endles cycle (repeated untill break)
        {
            //input and validation
            if (int.TryParse(Console.ReadLine(), out age))//Parses input for integer values and returns true or false
            {
                //valid input condition
                if( age > 0 )
                {
                    Console.WriteLine("\nIn 10 years you will be {0} years old ", age + 10);
                    break;
                }
                else
                {
                    Console.WriteLine("\nYour age canot be less than 0 years old ");
                }
            }
            else
            {
                Console.WriteLine("\nPlease enter an integer number ");
            }
        }   
    }
}
