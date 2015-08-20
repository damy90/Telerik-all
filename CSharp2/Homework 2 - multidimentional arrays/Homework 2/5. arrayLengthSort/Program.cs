using System;

//You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them)

class StringLenSort
{
    static void Main()
    {
        string[] stringArray = { "abcde", "abcdefg", "b", "a", "3a", "abc" };
        Array.Sort(stringArray, delegate(string string1, string string2)
        {
            return string1.Length.CompareTo(string2.Length);
        });

        foreach (var item in stringArray)
            Console.WriteLine(item);
    }
}
