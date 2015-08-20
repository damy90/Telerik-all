using System;
//Write a program that finds how many times a substring is contained in a given text (perform case insensitive search).

class CountSubstring
{
    static void Main()
    {
        string text = "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        int index = -1;
        int count = 0;

        do
        {
            index = text.IndexOf("in", index + 1, StringComparison.CurrentCultureIgnoreCase);
            if (index >= 0)
                count++;
        }
        while (index >= 0);

        Console.WriteLine(count);
    }
}
