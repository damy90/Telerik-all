using System;
//Write a method that returns the index of the first element in array that is bigger than its neighbors, or -1, if there’s no such element.
class Program
{
    static void Main(string[] args)
    {
        //int[] numbers = { 1, 3, -5, 9, 3, 8, 8, 1 };
        //false test
        int[] numbers = { 1, 2, 4, 5, 8, 8, 8, 9 };

        if (IsMax(numbers)>0)
            Console.WriteLine(IsMax(numbers));
        else
            Console.WriteLine("there is no such element");
    }

    static int IsMax(int[] numbers)
    {
        for (int position = 1; position < numbers.Length-1; position++)
            if (numbers[position] > numbers[position - 1] && numbers[position] > numbers[position + 1])
                return position;
        return -1;//if no position is returned
    }
}