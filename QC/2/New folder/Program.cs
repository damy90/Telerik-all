using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mini4ki
{
	public class Mines
	{
		public class Score
		{
			string name;
			int score;

			public string Име
			{
				get { return name; }
				set { name = value; }
			}

			public int PlayerScore
			{
				get { return score; }
				set { score = value; }
			}

			public Score() { }

            public Score(string name, int score)
			{
                this.name = name;
                this.score = score;
			}
		}
        //до тук стигнах
		static void Main(string[] arguments)
		{
			string comand = string.Empty;
			char[,] playField = CreatePlayField();
			char[,] mines = CreateMines();
			int broya4 = 0;
			bool grum = false;
			List<Score> highScore = new List<Score>(6);
			int row = 0;
			int col = 0;
			bool flag = true;
			const int maks = 35;
			bool flag2 = false;

			do
			{
				if (flag)
				{
					Console.WriteLine("Hajde da igraem na “Mini4KI”. Probvaj si kasmeta da otkriesh poleteta bez mini4ki." +
					" Komanda 'top' pokazva klasiraneto, 'restart' po4va nova igra, 'exit' izliza i hajde 4ao!");
					dumpp(playField);
					flag = false;
				}
				Console.Write("Daj red i kolona : ");
				comand = Console.ReadLine().Trim();
				if (comand.Length >= 3)
				{
					if (int.TryParse(comand[0].ToString(), out row) &&
					int.TryParse(comand[2].ToString(), out col) &&
						row <= playField.GetLength(0) && col <= playField.GetLength(1))
					{
						comand = "turn";
					}
				}
				switch (comand)
				{
					case "top":
						klasacia(highScore);
						break;
					case "restart":
						playField = CreatePlayField();
						mines = CreateMines();
						dumpp(playField);
						grum = false;
						flag = false;
						break;
					case "exit":
						Console.WriteLine("4a0, 4a0, 4a0!");
						break;
					case "turn":
						if (mines[row, col] != '*')
						{
							if (mines[row, col] == '-')
							{
								tisinahod(playField, mines, row, col);
								broya4++;
							}
							if (maks == broya4)
							{
								flag2 = true;
							}
							else
							{
								dumpp(playField);
							}
						}
						else
						{
							grum = true;
						}
						break;
					default:
						Console.WriteLine("\nGreshka! nevalidna Komanda\n");
						break;
				}
				if (grum)
				{
					dumpp(mines);
					Console.Write("\nHrrrrrr! Umria gerojski s {0} to4ki. " +
						"Daj si niknejm: ", broya4);
					string niknejm = Console.ReadLine();
					Score t = new Score(niknejm, broya4);
					if (highScore.Count < 5)
					{
						highScore.Add(t);
					}
					else
					{
						for (int i = 0; i < highScore.Count; i++)
						{
							if (highScore[i].PlayerScore < t.PlayerScore)
							{
								highScore.Insert(i, t);
								highScore.RemoveAt(highScore.Count - 1);
								break;
							}
						}
					}
					highScore.Sort((Score r1, Score r2) => r2.Име.CompareTo(r1.Име));
					highScore.Sort((Score r1, Score r2) => r2.PlayerScore.CompareTo(r1.PlayerScore));
					klasacia(highScore);

					playField = CreatePlayField();
					mines = CreateMines();
					broya4 = 0;
					grum = false;
					flag = true;
				}
				if (flag2)
				{
					Console.WriteLine("\nBRAVOOOS! Otvri 35 kletki bez kapka kryv.");
					dumpp(mines);
					Console.WriteLine("Daj si imeto, batka: ");
					string imeee = Console.ReadLine();
					Score to4kii = new Score(imeee, broya4);
					highScore.Add(to4kii);
					klasacia(highScore);
					playField = CreatePlayField();
					mines = CreateMines();
					broya4 = 0;
					flag2 = false;
					flag = true;
				}
			}
			while (comand != "exit");
			Console.WriteLine("Made in Bulgaria - Uauahahahahaha!");
			Console.WriteLine("AREEEEEEeeeeeee.");
			Console.Read();
		}

		private static void klasacia(List<Score> to4kii)
		{
			Console.WriteLine("\nTo4KI:");
			if (to4kii.Count > 0)
			{
				for (int i = 0; i < to4kii.Count; i++)
				{
					Console.WriteLine("{0}. {1} --> {2} kutii",
						i + 1, to4kii[i].Име, to4kii[i].PlayerScore);
				}
				Console.WriteLine();
			}
			else
			{
				Console.WriteLine("prazna klasaciq!\n");
			}
		}

		private static void tisinahod(char[,] POLE,
			char[,] BOMBI, int RED, int KOLONA)
		{
			char kolkoBombi = kolko(BOMBI, RED, KOLONA);
			BOMBI[RED, KOLONA] = kolkoBombi;
			POLE[RED, KOLONA] = kolkoBombi;
		}

		private static void dumpp(char[,] board)
		{
			int RRR = board.GetLength(0);
			int KKK = board.GetLength(1);
			Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
			Console.WriteLine("   ---------------------");
			for (int i = 0; i < RRR; i++)
			{
				Console.Write("{0} | ", i);
				for (int j = 0; j < KKK; j++)
				{
					Console.Write(string.Format("{0} ", board[i, j]));
				}
				Console.Write("|");
				Console.WriteLine();
			}
			Console.WriteLine("   ---------------------\n");
		}

		private static char[,] CreatePlayField()
		{
			int boardRows = 5;
			int boardColumns = 10;
			char[,] board = new char[boardRows, boardColumns];
			for (int i = 0; i < boardRows; i++)
			{
				for (int j = 0; j < boardColumns; j++)
				{
					board[i, j] = '?';
				}
			}

			return board;
		}

		private static char[,] CreateMines()
		{
			int Редове = 5;
			int Колони = 10;
			char[,] игрално_поле = new char[Редове, Колони];

			for (int i = 0; i < Редове; i++)
			{
				for (int j = 0; j < Колони; j++)
				{
					игрално_поле[i, j] = '-';
				}
			}

			List<int> r3 = new List<int>();
			while (r3.Count < 15)
			{
				Random random = new Random();
				int asfd = random.Next(50);
				if (!r3.Contains(asfd))
				{
					r3.Add(asfd);
				}
			}

			foreach (int i2 in r3)
			{
				int kol = (i2 / Колони);
				int red = (i2 % Колони);
				if (red == 0 && i2 != 0)
				{
					kol--;
					red = Колони;
				}
				else
				{
					red++;
				}
				игрално_поле[kol, red - 1] = '*';
			}

			return игрално_поле;
		}

		private static void smetki(char[,] pole)
		{
			int kol = pole.GetLength(0);
			int red = pole.GetLength(1);

			for (int i = 0; i < kol; i++)
			{
				for (int j = 0; j < red; j++)
				{
					if (pole[i, j] != '*')
					{
						char kolkoo = kolko(pole, i, j);
						pole[i, j] = kolkoo;
					}
				}
			}
		}

		private static char kolko(char[,] r, int rr, int rrr)
		{
			int brojkata = 0;
			int reds = r.GetLength(0);
			int kols = r.GetLength(1);

			if (rr - 1 >= 0)
			{
				if (r[rr - 1, rrr] == '*')
				{ 
					brojkata++; 
				}
			}
			if (rr + 1 < reds)
			{
				if (r[rr + 1, rrr] == '*')
				{ 
					brojkata++; 
				}
			}
			if (rrr - 1 >= 0)
			{
				if (r[rr, rrr - 1] == '*')
				{ 
					brojkata++;
				}
			}
			if (rrr + 1 < kols)
			{
				if (r[rr, rrr + 1] == '*')
				{ 
					brojkata++;
				}
			}
			if ((rr - 1 >= 0) && (rrr - 1 >= 0))
			{
				if (r[rr - 1, rrr - 1] == '*')
				{ 
					brojkata++; 
				}
			}
			if ((rr - 1 >= 0) && (rrr + 1 < kols))
			{
				if (r[rr - 1, rrr + 1] == '*')
				{ 
					brojkata++; 
				}
			}
			if ((rr + 1 < reds) && (rrr - 1 >= 0))
			{
				if (r[rr + 1, rrr - 1] == '*')
				{ 
					brojkata++; 
				}
			}
			if ((rr + 1 < reds) && (rrr + 1 < kols))
			{
				if (r[rr + 1, rrr + 1] == '*')
				{ 
					brojkata++; 
				}
			}
			return char.Parse(brojkata.ToString());
		}
	}
}
