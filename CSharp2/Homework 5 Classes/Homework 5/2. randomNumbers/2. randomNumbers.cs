﻿using System;
//Write a program that generates and prints to the console 10 random values in the range [100, 200].
class Program
{
    static void Main()
    {
        Random random = new Random();
        for (int i=0; i<10;i++)
            Console.WriteLine("{0}: {1}", i+1, random.Next(100, 201));
    }
}
