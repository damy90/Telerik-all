using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
using System.Diagnostics;

struct Plane
{
    public int x;
    public int y;
    public char[,] c;
    public ConsoleColor color;
}

struct Alphabet
{
    public int x;
    public int y;
    public char symbol;
    public ConsoleColor color;
}

struct Weapon
{
    public int x;
    public int y;
    public char symbol;
    public ConsoleColor color;
}

class Explosion
{
    public Explosion(int x, int y, long time)
    {
        this.x = x;
        this.y = y;
        this.time = time;
    }
    public int x;
    public int y;
    public long time;
}

class ConsoleBuffer
{
    static readonly int width = Console.BufferWidth;
    static readonly int height = Console.BufferHeight;
    static int cursorX = 0, cursorY = 0;
    static readonly StringBuilder forPrint = new StringBuilder(3 * width);
    static readonly char[,] buffer = new char[width, height];
    static readonly ConsoleColor[,] colorBuffer = new ConsoleColor[width, height];

    public static void PrintOnPositoin(int x, int y, char symbol, ConsoleColor color = ConsoleColor.Gray)
    {
        if (x >= 0 && x < width && y >= 0 && y < height)
        {
            buffer[x, y] = symbol;
            colorBuffer[x, y] = color;
        }
        cursorX = x;
        cursorY = y;
    }
    public static void PrintStringOnPosition(int x, int y, string str,
        ConsoleColor color = ConsoleColor.Gray)
    {
        for (int i = 0; i < str.Length; i++)
            PrintOnPositoin(x + i, y, str[i], color);
    }
    public static void PrintArrayOnPosition(int x, int y, char[,] c,
        ConsoleColor color = ConsoleColor.Gray)
    {
        for (int i = 0; i < c.GetLength(0); i++)
        {
            for (int j = 0; j < c.GetLength(1); j++)
            {
                buffer[x+j, y+i] = c[i, j];
                colorBuffer[x+j, y+i] = color;
            }
        }
    }
    public static void SetCursorPosition()
    {
        Console.SetCursorPosition(cursorX+1, cursorY);
    }
    public static void Draw()
    {
        forPrint.Clear();
        Console.SetCursorPosition(0,0);
        ConsoleColor currentColor = colorBuffer[0, 0];
        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                if( (buffer[x,y]!=' ' && colorBuffer[x,y]!=currentColor) || (y==height-1 && x==width-1) )
                {
                    Console.ForegroundColor = currentColor;
                    Console.Write( forPrint );
                    forPrint.Clear();
                    currentColor = colorBuffer[x, y];
                }
                forPrint.Append(buffer[x, y]);
            }
        }
    }
    public static void Clear()
    {
        Console.SetCursorPosition(0, 0);
        for (int y = 0; y < height; y++)
            for (int x = 0; x < width; x++)
            {
                buffer[x, y] = ' ';
                colorBuffer[x, y] = ConsoleColor.Gray;
            }
    }
}

class AlphabetPlane
{
    static string GetSavePath()
    {
        string currentDir = Environment.CurrentDirectory;
        DirectoryInfo directory = new DirectoryInfo(currentDir);
        string fullDirectory = directory.FullName;
        return @fullDirectory + "BestScore.txt";
    }

    static void LoadBestScores(out int bestScore, out string name)
    {
        string path = GetSavePath();
        bestScore = 0;
        name = "";
        try
        {
            StreamReader reader = new StreamReader(path);
            using (reader)
            {
                if (!int.TryParse(reader.ReadLine(), out bestScore))
                    return;
                name = reader.ReadLine();
                if (name == null)
                    name = "";//old file with no name
            }
            return;
        }
        catch
        {
            return;
        }
    }

    static void SaveBestScores(int bestScore, string name)
    {
        string path = GetSavePath();
        try
        {
            StreamWriter writer = new StreamWriter(path);
            using (writer)
            {
                writer.WriteLine(bestScore);
                writer.WriteLine(name);
            }
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("Cannot save new high score!\nThe file {0} is write protected.\nPress Enter co continue", path);
            ConsoleBuffer.SetCursorPosition();
            Console.ReadLine();
        }
        catch
        {
            Console.WriteLine("Cannot save new high score!\nUnexpected error!");
        }
    }

    private static void OnHitPlane(List<Alphabet> attacks, List<Weapon> weapons)
    {
        timeOnHitPlane = time.ElapsedMilliseconds;
        attacks.Clear();
        weapons.Clear();
    }

    private static bool DrawHitEnemy( Explosion bang )
    {
        if (time.ElapsedMilliseconds - bang.time < timeShowHit)
        {
            ConsoleBuffer.PrintOnPositoin( bang.x, bang.y, 'X', ConsoleColor.Red);
            return true;
        }
        else
            return false;
    }

    static void StartPlaying()
    {
        Console.BufferHeight = Console.WindowHeight = ConsoleHeight;
        Console.BufferWidth = Console.WindowWidth = ConsoleWidth;
        ConsoleBuffer.PrintStringOnPosition(34, 3, "Alphabet Plane", ConsoleColor.Green);
        ConsoleBuffer.PrintStringOnPosition(24, 7, "'@' gives you extra 100 points", ConsoleColor.Red);
        ConsoleBuffer.PrintStringOnPosition(24, 8, "'-' slows the game for 10 seconds", ConsoleColor.Red);
        ConsoleBuffer.PrintStringOnPosition(24, 9, "'^' gives you 1 live when collect 3 symbols", ConsoleColor.Red);
        ConsoleBuffer.PrintStringOnPosition(24, 12, "Controls: [<-], [->], [spacebar]", ConsoleColor.Red);
        ConsoleBuffer.PrintStringOnPosition(25, 14, "Press [P] to pause the game", ConsoleColor.Red);
        ConsoleBuffer.PrintStringOnPosition(25, 16, "Press [enter] to start playing", ConsoleColor.Red);
        ConsoleBuffer.Draw();
        ConsoleBuffer.SetCursorPosition();
        Console.ReadLine();
    }

    static void PlayAgain()
    {
        string playAgainText = "Do you want to play again: y/n?";
        ConsoleBuffer.PrintStringOnPosition(25, 21, playAgainText, ConsoleColor.Cyan);
        ConsoleBuffer.PrintStringOnPosition(25 + playAgainText.Length + 2, 21, "", ConsoleColor.Cyan);//tweak: input on next line
        ConsoleBuffer.Draw();
        string playAgain = "";
        do
        {
            ConsoleBuffer.SetCursorPosition();
            playAgain = Console.ReadLine().ToLower().Trim();
        }
        while (!playAgain.Equals("y") && !playAgain.Equals("n"));
        if (playAgain.Equals("y"))
        {
            ConsoleBuffer.Clear();//tweak: clear the screen to draw the start screen
            ConsoleBuffer.PrintStringOnPosition(25, 15, "Press [enter] to restart game", ConsoleColor.Red);
            ConsoleBuffer.Draw();
            ConsoleBuffer.SetCursorPosition();
            Console.ReadLine();
            ConsoleBuffer.Clear();
            score = 0;
            livesCount = 5;
        }
        else if (playAgain.Equals("n"))
        {
            ConsoleBuffer.Clear();
            Environment.Exit(0);
        }

        Console.ForegroundColor = ConsoleColor.White;
    }

    static void SymbolGenerator(List<Alphabet> attacks, char[] symbols)
    {
        Random randomGenerator = new Random();
        Alphabet newLetter = new Alphabet();
        newLetter.color = ConsoleColor.Green;
        newLetter.x = randomGenerator.Next(2, PlayfieldWidth+2);//letters width old-12
        newLetter.y = 0;
        newLetter.symbol = symbols[randomGenerator.Next(symbols.Length)];
        attacks.Add(newLetter);
        return;
    }

    static void InitializeLaser(List<Weapon> weapons, List<Weapon> newWeaponInitialize)
    {
        for (int i = 0; i < weapons.Count; i++)
        {
            Weapon oldWeap = weapons[i];
            Weapon newWeap = new Weapon();
            newWeap.x = oldWeap.x;
            newWeap.y = oldWeap.y - 1;
            newWeap.symbol = oldWeap.symbol;
            newWeap.color = oldWeap.color;

            if (newWeap.y >= 0)
            {
                newWeaponInitialize.Add(newWeap);
            }
        }
    }

    static Plane CreatePlane()
    {
        Plane plane = new Plane();
        plane.x = 5;
        plane.y = Console.WindowHeight - 5;
        plane.c = new char[4, 5]
        {
            { ' ', ' ', '*', ' ', ' ' },
            { '*', '*', '*', '*', '*' },
            { ' ', ' ', '*', ' ', ' ' },
            { ' ', '*', '*', '*', ' ' }
        };
        plane.color = ConsoleColor.Yellow;

        return plane;
    }

    static int GetGameSpeed(int lastGameSpeed)
    {
        if (score > 2000 && score < 5000)
        {
            lastGameSpeed = 140;
        }
        else if (score >= 5000 && score < 8000)
        {
            lastGameSpeed = 130;
        }
        else if (score >= 8000 && score < 15000)
        {
            lastGameSpeed = 120;
        }
        else if (score >= 15000 && score < 30000)
        {
            lastGameSpeed = 110;
        }
        else if (score >= 30000)
        {
            lastGameSpeed = 100;
        }
        return lastGameSpeed;
    }

    private static void GameOver(ref Plane plane)
    {
        elapsedTimeStopwatch.Stop();

        Thread.Sleep(400);
        
        if (score > bestScore)
        {
            bestScore = score;
            ConsoleBuffer.Clear();
            ConsoleBuffer.PrintStringOnPosition(25, 20, "New High Score", ConsoleColor.Cyan);
            ConsoleBuffer.PrintStringOnPosition(25, 22, "Please enter your name: ", ConsoleColor.Cyan);
            ConsoleBuffer.Draw();
            ConsoleBuffer.SetCursorPosition();
            bestScoreName = Console.ReadLine();
            SaveBestScores(bestScore, bestScoreName);
        }

        timeOnHitPlane = -1000;
        ConsoleBuffer.Clear();
        ConsoleBuffer.PrintStringOnPosition(37, 10, "GAME OVER", ConsoleColor.Red);
        ConsoleBuffer.PrintStringOnPosition(35, 16, "BestScore: " + bestScore, ConsoleColor.Green);
        ConsoleBuffer.PrintStringOnPosition(35, 18, "By: " + bestScoreName, ConsoleColor.Green);
        ConsoleBuffer.PrintStringOnPosition(35, 24, "Score: " + score, ConsoleColor.Green);
        ConsoleBuffer.PrintStringOnPosition(33, 27, "Time elapsed: " + elapsedTime, ConsoleColor.Green);
        plane.color = ConsoleColor.Yellow;
        ConsoleBuffer.Draw();
        PlayAgain();
    }

    static void Pause()
    {
        ConsoleBuffer.Clear();
        ConsoleBuffer.PrintStringOnPosition(35, 13, "Paused!", ConsoleColor.Red);
        ConsoleBuffer.PrintStringOnPosition(25, 15, "Press [enter] to start playing", ConsoleColor.Red);
        ConsoleBuffer.Draw();
        ConsoleBuffer.SetCursorPosition();
        Console.ReadLine();
        pause = false;
    }
    static bool pause = false;
    static int score = 0;
    static int livesCount = 5;
    static int bestScore = 0;
    static string bestScoreName = "";
    static long timeOnHitPlane = -1000;

    const int ConsoleHeight = 40;
    const int ConsoleWidth = 80;
    const int PlayfieldWidth = 15;
    const int InitialGameSpeed = 150;
    static string elapsedTime;

    static int count = 4;
    static int slowGame = 0;
    static int lastGameSpeed = 150;
    static int hitX = 0;
    static int hitY = 0;
    static int getNewLive = 0;


    static readonly List<Explosion> enemyHits = new List<Explosion>();
    static readonly int timeShowHit = 100;

    static readonly Stopwatch time = new Stopwatch();
    static readonly Stopwatch elapsedTimeStopwatch = new Stopwatch();

    static void Main()
    {
        Console.Title = "Alphabet Plane";
        StartPlaying();

        elapsedTimeStopwatch.Start();

        LoadBestScores(out bestScore, out bestScoreName);

        int gameSpeed = InitialGameSpeed;

        Plane plane = CreatePlane();

        Random randomGenerator = new Random();

        List<Alphabet> attacks = new List<Alphabet>();

        List<Weapon> weapons = new List<Weapon>();

        char[] code = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', '@', '-', '^' };

        char[] weapSymbols = { '|', '#', '$', '%' };

        time.Start();

        while (true)
        {
            lastGameSpeed = GetGameSpeed(lastGameSpeed);
            List<Weapon> newWeaponInitialize = new List<Weapon>();
            weapons = newWeaponInitialize;
            count++;
            bool hit = false;
            bool isGameOver = false;

            if (pause)
                Pause();

            if (count % 5 == 0)
                SymbolGenerator(attacks, code);

            if (Console.KeyAvailable)
                KeyPressEvents(ref plane, randomGenerator, weapons, weapSymbols);

            List<Alphabet> newAlphabetInitialize = new List<Alphabet>();

            //Move weapon
            InitializeLaser(weapons, newWeaponInitialize);

            for (int i = 0; i < attacks.Count; i++)
                AlphabetMovement(attacks, i, plane, weapons, newAlphabetInitialize, ref hit, ref hitX, ref hitY, ref isGameOver);//Move alphabets

            if (score < 0)
            {
                isGameOver = true;
                newAlphabetInitialize.Clear();
                newWeaponInitialize.Clear();
            }

            ConsoleBuffer.Clear(); // Clear the console
            // Redraw playfield
            attacks = newAlphabetInitialize;
            weapons = newWeaponInitialize;

            List<Alphabet> removeAtt = new List<Alphabet>();

            foreach (var att in attacks)
            {
                HitLetter(weapons, att, gameSpeed, newWeaponInitialize, removeAtt, ref lastGameSpeed, ref slowGame, ref getNewLive);
                weapons = newWeaponInitialize;
            }

            foreach (var item in removeAtt)
            {
                foreach (var num in attacks)
                {
                    if (item.x == num.x && item.y == num.y)
                    {
                        newAlphabetInitialize.Remove(num);
                        break;
                    }
                }
                attacks = newAlphabetInitialize;
            }


            if (isGameOver)
                plane.color = ConsoleColor.Red;

            ConsoleBuffer.PrintArrayOnPosition(plane.x, plane.y, plane.c, plane.color);

            //draw shots
            foreach (Weapon item in weapons)
            {
                ConsoleBuffer.PrintOnPositoin(item.x, item.y, item.symbol, item.color);
            }
            //draw letters
            foreach (Alphabet letter in attacks)
            {
                ConsoleBuffer.PrintOnPositoin(letter.x, letter.y, letter.symbol, letter.color);
            }

            WhenHitPlane(hit, attacks, weapons, hitX, hitY);

            

            if( enemyHits.Count !=0 )
            {
                List<Explosion> toRemove = new List<Explosion>();
                foreach (Explosion bang in enemyHits)
                {
                    if (!DrawHitEnemy(bang))
                        toRemove.Add(bang);     //it is not safe to remoove within the foreach loop
                }
                foreach (Explosion bang in toRemove)
                    enemyHits.Remove(bang);
            }

            // Draw info
            DrawInfo();

            for (int i = 0; i < Console.WindowHeight; i++)
                ConsoleBuffer.PrintStringOnPosition(PlayfieldWidth+4, i, "|", ConsoleColor.Cyan);//game field border (old-14)

            if (count == 128)//Math.Pow(2,7) replaced with value
                count = 0;

            if (slowGame > 0)
            {
                gameSpeed = 200;
                slowGame--;
            }
            else if (slowGame == 0)
                gameSpeed = lastGameSpeed;

            ConsoleBuffer.Draw();

            Thread.Sleep(gameSpeed);
            // Slow down program

            if (isGameOver)
                GameOver(ref plane);

            TimeSpan ts = time.Elapsed;

            // Format and display the TimeSpan value. 
            elapsedTime = String.Format("{0:00}:{1:00}", ts.Minutes, ts.Seconds);
        }
    }

    private static void KeyPressEvents(ref Plane plane, Random randomGenerator, List<Weapon> weapons, char[] weapSymbols)
    {
        ConsoleKeyInfo pressedKey = Console.ReadKey(true);
        while (Console.KeyAvailable)
        {
            Console.ReadKey(true);
        }
        if (pressedKey.Key == ConsoleKey.LeftArrow)
        {
            if (plane.x - 1 >= 0)
            {
                plane.x = plane.x - 1;
            }
        }
        if (pressedKey.Key == ConsoleKey.RightArrow)
        {
            if (plane.x + 1 < PlayfieldWidth)
            {
                plane.x = plane.x + 1;
            }
        }
        if (pressedKey.Key == ConsoleKey.Spacebar)
        {
            Weapon newWeapon = new Weapon();
            newWeapon.color = ConsoleColor.Blue;
            newWeapon.x = plane.x + 2;
            newWeapon.y = plane.y - 1;
            newWeapon.symbol = weapSymbols[randomGenerator.Next(weapSymbols.Length)];
            weapons.Add(newWeapon);
        }
        if (pressedKey.Key == ConsoleKey.P)
        {
            pause = true;
        }
    }

    static void WhenHitPlane(bool hit, List<Alphabet> attacks, List<Weapon> weapons, int hitX, int hitY)
    {
        if (hit)
        {
            OnHitPlane(attacks, weapons);
        }
        //draw hit plane
        if (time.ElapsedMilliseconds - timeOnHitPlane < timeShowHit)
            ConsoleBuffer.PrintOnPositoin(hitX, hitY, 'X', ConsoleColor.Red);
    }
  
    static void DrawInfo()
    {
        // Draw info
        ConsoleBuffer.PrintStringOnPosition(PlayfieldWidth + 15, 16, "High Score: " + bestScore, ConsoleColor.Red);
        ConsoleBuffer.PrintStringOnPosition(PlayfieldWidth + 15, 18, "By: " + bestScoreName, ConsoleColor.Red);
        ConsoleBuffer.PrintStringOnPosition(PlayfieldWidth + 15, 22, "Lives: " + livesCount, ConsoleColor.Red);
        ConsoleBuffer.PrintStringOnPosition(PlayfieldWidth + 15, 24, "Score: " + score, ConsoleColor.Red);
        ConsoleBuffer.PrintStringOnPosition(PlayfieldWidth + 15, 27, "Current Game Speed: " + lastGameSpeed, ConsoleColor.Red);
        ConsoleBuffer.PrintStringOnPosition(PlayfieldWidth + 15, 29, "Live Symbol counter: " + getNewLive, ConsoleColor.Red);
        ConsoleBuffer.PrintStringOnPosition(PlayfieldWidth + 15, 31, "Play Time: " + elapsedTime, ConsoleColor.Red);
    }

    static void HitLetter(List<Weapon> weapons, Alphabet att, int gameSpeed, List<Weapon> newWeaponInitialize, List<Alphabet> removeAtt, ref int lastGameSpeed, ref int slowGame, ref int getNewLive)
    {
        foreach (var weap in weapons)
        {
            //if we hit a letter
            if (weap.x == att.x && weap.y == att.y)
            {
                enemyHits.Add( new Explosion(att.x,att.y,time.ElapsedMilliseconds) );
                if (att.symbol == '@')
                {
                    score += 100;
                }
                else if (att.symbol == '^')
                {
                    getNewLive++;
                    if (getNewLive == 3)
                    {
                        livesCount++;
                        getNewLive = 0;
                    }
                }
                else if (att.symbol == '-')
                {
                    if (slowGame == 0)
                    {
                        lastGameSpeed = gameSpeed;
                    }
                    slowGame += 20;
                }
                else
                {
                    score += att.symbol - 'A' + 1;
                }
                newWeaponInitialize.Remove(weap);
                removeAtt.Add(att);
                break;
            }
        }
    }
  
    static void AlphabetMovement(List<Alphabet> attacks, int i, Plane plane, List<Weapon> weapons, List<Alphabet> newLetterInitialize, ref bool hit, ref int hitX, ref int hitY, ref bool isGameOver)
    {
        // Move alphabets
        Alphabet oldLetter = attacks[i];
        Alphabet newLetter = new Alphabet();
        newLetter.x = oldLetter.x;
        newLetter.y = oldLetter.y + 1;
        newLetter.symbol = oldLetter.symbol;
        newLetter.color = oldLetter.color;
        if (newLetter.x >= plane.x && newLetter.x < plane.x + 5 && newLetter.y >= plane.y && newLetter.y <= plane.y + 2)
        {
            //if the plane is hit
            if (plane.c[(newLetter.y - plane.y), (newLetter.x - plane.x)] == '*')
            {
                livesCount--;
                hit = true;
                hitX = newLetter.x;
                hitY = newLetter.y;
                if (livesCount <= 0)
                {
                    OnHitPlane(attacks, weapons);
                    isGameOver = true;
                }
            }
        }
        //when you miss a letter
        if (newLetter.y < Console.WindowHeight)
        {
            newLetterInitialize.Add(newLetter);
        }
        else
        {
            score -= 25;
        }       
    }
}