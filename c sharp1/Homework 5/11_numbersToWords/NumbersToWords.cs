using System;

class NumbersToWords
{
    //Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation.
    static void Main()
    {
        Console.Title="Numbers to words";
        int number;
        
        while (true)
        {
            Console.Write("Please enter a number between 0 and 999: ");
            if (int.TryParse(Console.ReadLine(), out number) && number>=0 && number<=999)
                break;
        }

        string words = "";
        string[] unitsMap = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };

        if ((number / 100) > 0)
        {
            words += unitsMap[number / 100];
            words += " hundred ";
            number %= 100;
        }

        if (number > 0)
        {
            if (words != "")
                words += "and ";

            string[] tensMap = { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

            if (number < 20)
                words += unitsMap[number];
            else
            {
                words += tensMap[number / 10];
                if ((number % 10) > 0)
                    words += "-" + unitsMap[number % 10];
            }
        }
        else
            if (words == "")
                words = "zero";
        Console.Write("The number in words: {0}\n",words);
    }
}

