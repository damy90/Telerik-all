using System;   //не работи с отрицателни

class Program
{
    static void Main()
    {
        int number;
        Console.Title = "Check if 3-th didgit is 7";
        Console.WriteLine("Please enter a number");
        while (true)//endles cycle (repeated untill break)
        {
            if (int.TryParse(Console.ReadLine(), out number))//Parses input for integer values and returns true or false
            {
                int removeDidgits = number / 100;
                int result = removeDidgits % 10;

                bool check = (Math.Abs(result) == 7);
                Console.WriteLine(check);
                break;
            }
            else
            {
                Console.WriteLine("\nPlease enter an integer number");
            }
        }   
    }
}
