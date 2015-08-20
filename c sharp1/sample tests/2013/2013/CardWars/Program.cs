using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int playerScore1 = 0, playerScore2 = 0, gamesWon1 = 0, gamesWon2 = 0;
        string result = "";
        for (int k = 0; k < N; k++)
        {
            string[] card = new string[3];
            for (int i = 0; i < 3; i++)
                card[i] = Console.ReadLine();
            string[] cards = { "A", "10", "9", "8", "7", "6", "5", "4", "3", "2", "J", "Q", "K" };
            int score1 = 0, score2 = 0;
            for (int j = 0; j < 3; j++)
                for (int i = 0; i < 13; i++)
                    if (card[j] == cards[i])
                    {
                        score1 += i + 1;
                        continue;
                    }
            for (int j = 0; j < 3; j++)
            {
                if (card[j] == "Z")
                    playerScore1 *= 2;
                if (card[j] == "Y")
                    playerScore1 -= 200;
                if (card[j] == "X")
                    result += "X1";
            }

            for (int i = 0; i < 3; i++)
                card[i] = Console.ReadLine();
            for (int j = 0; j < 3; j++)
                for (int i = 0; i < 12; i++)
                    if (card[j] == cards[i])
                    {
                        score2 += i + 1;
                        continue;
                    }
            for (int j = 0; j < 3; j++)
            {
                if (card[j] == "Z")
                    playerScore1 *= 2;
                if (card[j] == "Y")
                    playerScore1 -= 200;
                if (card[j] == "X")
                    result += "X2";
            }
            if (result == "X1" && result == "X2" && result == "X1X2")//??
                continue;
            if (score1 > score2)
            {
                score2 = 0;
                gamesWon1 += 1;
            }
            else if (score2 > score1)
            {
                score1 = 0;
                gamesWon2 += 1;
            }
            else if (score2 == score1)
            {
                score1 = 0;
                score2 = 0;
            }

            playerScore1 += score1;
            playerScore2 += score2;

        }
        if (result != "X1" && result != "X2" && result != "X1X2")
        {
            if (playerScore1 > playerScore2)
                Console.WriteLine("First player wins!\nScore: {0}\nGames won: {1}", playerScore1, gamesWon1);
            else if (playerScore1 < playerScore2)
                Console.WriteLine("Second player wins!\nScore: {0}\nGames won: {1}", playerScore2, gamesWon2);
            else if (playerScore1 == playerScore2)
                Console.WriteLine("It's a tie!\nScore: {0}", playerScore2);
        }
        else if (result == "X1")
            Console.WriteLine("X card drawn! Player one wins the match!");
        else if (result == "X2")
            Console.WriteLine("X card drawn! Player two wins the match!");
    }
}