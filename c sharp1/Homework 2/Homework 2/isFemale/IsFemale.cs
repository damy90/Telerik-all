//Declare a Boolean variable called isFemale and assign an appropriate value corresponding to your gender.
//Print it on the console.

using System;

class IsFemale
{
    static void Main()
    {
        bool isFemale;
        Console.WriteLine("Waht is your gender? (male or female)");
        string myGender = Console.ReadLine();
        if (myGender == "female")
        {
            isFemale = true;
        }
        else
        {
            isFemale = false;
        }
        Console.WriteLine(isFemale);
    }
}
