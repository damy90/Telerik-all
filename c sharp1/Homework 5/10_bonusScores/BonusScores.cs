using System;

class BonusScores
{
    //Write a program that applies bonus score to given score in the range [1…9] by the following rules:
    //If the score is between 1 and 3, the program multiplies it by 10.
    //If the score is between 4 and 6, the program multiplies it by 100.
    //If the score is between 7 and 9, the program multiplies it by 1000.
    //If the score is 0 or more than 9, the program prints “invalid score”.

    static void Main()
    {
        Console.Title = "Bonus score";

        int value;
        int score;

        while (true)
        {
            Console.Write("Please enter value between 1 and 9: ");
            char character = Console.ReadKey().KeyChar;
            value = (int)character - (int)'0';
            if (value > 0 && value < 10)
                break;
            Console.WriteLine("Invalid value");
        }

        switch (value)
        {
            case 1:
            case 2:
            case 3:
                score = value * 10;
                break;
            case 4:
            case 5:
            case 6:
                score = value * 100;
                break;
            default:
                score = value * 1000;
                break;
        }
        Console.WriteLine("The result is: {0}", score);
    }
}
