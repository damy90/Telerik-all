using System;
//Write a method that returns the last digit of given integer as an English word.
//Examples: 512  "two", 1024  "four", 12309  "nine".
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            DidgitToWord(number);
        }

        static void DidgitToWord(int number)
        {
            string[] numbers = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            string word = numbers[number % 10];//the remainder corresponds to an index in the array
            Console.WriteLine(word);
        }
    }
