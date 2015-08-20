using System;
//Write a program to check if in a given expression the brackets are put correctly.

class ExpressionBracketsCheck
{
    static void Main()
    {
        string expression = "((a+b)/5-d)";

        int count = 0;
        char[] elements = expression.ToCharArray();
        foreach (char element in elements)
        {
            if (element == ')')
                count--;
            else if (element == '(')
                count++;
            if (count < 0)
                break;
        }
        Console.WriteLine("The expression is {0}", count == 0 ? "correct" : "incorrect");

    }
}
