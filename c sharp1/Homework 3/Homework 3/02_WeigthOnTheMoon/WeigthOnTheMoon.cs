//The gravitational field of the Moon is approximately 17% of that on the Earth.
//Write a program that calculates the weight of a man on the moon by a given weight on the Earth.

using System;

class WeigthOnTheMoon
{
    static void Main()
    {
        float weigthOnEarth;
        Console.Title = "Check if a number is odd or even";
        Console.Write("Please enter your weigt:\t");
        while (true)
        {
            if (float.TryParse(Console.ReadLine(), out weigthOnEarth) && weigthOnEarth >= 0)
            {
                Console.WriteLine("On the moon you would weigh {0} kg", weigthOnEarth * 17 / 100);
                break;
            }
            else
            {
                Console.WriteLine("\nPlease enter a positive number");
            }
        }
    }
}
