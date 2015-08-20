using System;
//Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i] contains a digit; the last digit is kept in arr[0]).
//Each of the numbers that will be added could have up to 10 000 digits.
class Program
{
    static void Main()
    {
        int[] number1 = { 9, 9, 9, 9, 9, 9 };
        int[] number2 = { 9, 9, 9, 9 };

        //The shorter array will be added to the longer array
        if (number2.Length > number1.Length)
            Add(number2, number1);
        else
            Add(number1, number2);
    }
    static void Add(int[] number1, int[] number2)
    {
        for (int i = 1; i <= number1.Length; i++)
        {
            //Adition starts from the last element to the first untill there are no more numbers in number2
            if (i <= number2.Length)
                number1[number1.Length - i] += number2[number2.Length - i];

            //carry check (if an element is >9)
            if ((number1[number1.Length - i] > 9) && i < number1.Length)
            {
                number1[number1.Length - i] %= 10;
                number1[number1.Length - i - 1] += 1;
            }
        }

        //Carry check for the first element.
        //Resizes the array if the sum has more didgits than the largest array
        if (number1[0] > 9)
        {
            number1[0] %= 10;
            Array.Resize<int>(ref number1, number1.Length + 1);
            Array.Copy(number1, 0, number1, 1, number1.Length - 1);
            number1[0] = 1;
        }

        //print the result
        foreach (int i in number1)
            Console.Write(i);
        Console.WriteLine();
    }
}
