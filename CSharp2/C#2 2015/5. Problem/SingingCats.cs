using System;
using System.Linq;
using System.Text.RegularExpressions;

public class SingingCats
{
    // unfinished
    public static void Main()
    {
        int catsCount = int.Parse(Regex.Match(Console.ReadLine(), @"\d+").Value);
        bool[][] cats = new bool[catsCount][];
        int songsCount = int.Parse(Regex.Match(Console.ReadLine(), @"\d+").Value);

        // fill the array of cats with the array of songs they know
        string input = string.Empty;
        while (true)
        {
            input = Console.ReadLine();
            if (input == "Mew!")
            {
                break;
            }

            var catSong = Regex.Matches(input, @"\d+");

            int catIndex = int.Parse(catSong[0].ToString()) - 1;
            int songsIndex = int.Parse(catSong[1].ToString()) - 1;
            if (cats[catIndex] == null)
            {
                cats[catIndex] = new bool[songsCount];
            }

            cats[catIndex][songsIndex] = true;
        }

        // some dumb cat doesn't knows any songs
        for (int i = 0; i < catsCount; i++)
        {
            if (cats[i] == null)
            {
                Console.WriteLine("No concert!");
                return;
            }
        }

        // there's a song everyone knows
        var minSongListAnd = new bool[songsCount];
        for (int i = 0; i < songsCount; i++)
        {
            minSongListAnd[i] = true;
        }

        for (int i = 0; i < catsCount; i++)
        {
            for (int j = 0; j < songsCount; j++)
            {
                minSongListAnd[j] = minSongListAnd[j] && cats[i][j];
            }
        }

        if (minSongListAnd.Count(x => x == true) > 0)
        {
            Console.WriteLine(1);
            return;
        }

        // count all songs known by at least 1 cat
        var minSongListOr = new bool[songsCount];
        for (int i = 0; i < catsCount; i++)
        {
            for (int j = 0; j < songsCount; j++)
            {
                minSongListOr[j] = minSongListOr[j] || cats[i][j];
            }
        }

        Console.WriteLine(minSongListOr.Count(x => x == true));
    }
}