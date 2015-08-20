namespace Methods
{
	using System;

	public class Methods
	{
		public static double CalcTriangleArea(double a, double b, double c)
		{
			if (a <= 0 || b <= 0 || c <= 0)
			{
				throw new ArgumentOutOfRangeException("Sides should be positive.");
			}

			if (a + b < c || a + c < b || b + c < a)
			{
				throw new ArgumentException("Cannot form triangle! One line is longer than the sum of the others.");
			}

			double s = (a + b + c) / 2;
			double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
			return area;
		}

		public static string DigitToString(int digit)
		{
			switch (digit)
			{
				case 0: return "zero";
				case 1: return "one";
				case 2: return "two";
				case 3: return "three";
				case 4: return "four";
				case 5: return "five";
				case 6: return "six";
				case 7: return "seven";
				case 8: return "eight";
				case 9: return "nine";

				default: throw new ArgumentException("Invalid number!");
			}
		}

		public static int FindMax(params int[] elements)
		{
			if (elements == null || elements.Length == 0)
			{
				throw new ArgumentNullException("There should be at least one number");
			}

			int max = 0;
			for (int i = 0; i < elements.Length; i++)
			{
				if (elements[i] > elements[0])
				{
					max = elements[i];
				}
			}

			return max;
		}

		public static void FormatNumber(object number, string format)
		{
			if (format == "f")
			{
				Console.WriteLine("{0:f2}", number);
			}
			else if (format == "%")
			{
				Console.WriteLine("{0:p0}", number);
			}
			else if (format == "r")
			{
				Console.WriteLine("{0,8}", number);
			}
			else
			{
				throw new ArgumentException("invalid format!");
			}
		}

		public static double CalcDistance(double x1, double y1, double x2, double y2)
		{
			double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
			return distance;
		}

		public static bool IsHoryzontal(double x1, double y1, double x2, double y2)
		{
			if (CalcDistance(x1, y1, x2, y2) == 0)
			{
				throw new ArgumentException("Line length cannot be 0!");
			}

			bool isHorizontal = y1 == y2;
			return isHorizontal;
		}

		public static bool IsVertical(double x1, double y1, double x2, double y2)
		{
			if (CalcDistance(x1, y1, x2, y2) == 0)
			{
				throw new ArgumentException("Line length cannot be 0! Points coincide.");
			}

			bool isVertical = x1 == x2;
			return isVertical;
		}

		
	}
}
