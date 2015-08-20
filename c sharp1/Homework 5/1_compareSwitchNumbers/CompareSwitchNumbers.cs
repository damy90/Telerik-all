using System;

class CompareSwitchNumbers
{
    //Write an if-statement that takes two double variables a and b and exchanges their values if the first one is greater than the second one. As a result prfloat the values a and b, separated by a space.
    static void Main()
    {
        Console.Title = "Sort two numbers";

        Console.Write("Please enter 1-st number:");
        float number1 = float.Parse(Console.ReadLine());
        Console.Write("Please enter 1-st number:");
        float number2 = float.Parse(Console.ReadLine());

        if (number1 > number2)
        {
            float memory = number1;
            number1 = number2;
            number2 = memory;
        }

        Console.WriteLine("{0} {1}", number1, number2);
    }
}
