using System;

class AllCards
{
    //Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers). The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
    //*The card faces should start from 2 to A.
    //*Print each card face in its four possible suits: clubs, diamonds, hearts and spades. Use 2 nested for-loops and a switch-case statement.
    static void Main()
    {
        Console.Title = "Show all cards in a deck accept Jokers";

        string[] ranks = { "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace" };
        string[] colors = { "Spades", "Clubs", "Hearts", "Diamonds" };

        foreach (string rank in ranks)
            foreach (string color in colors)
                Console.Write("{0} of {1}{2}", rank, color, color != colors[colors.Length - 1] ? ", " : "\n");
    }
}