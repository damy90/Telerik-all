namespace Methods
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Tests
    {
        private static void Main()
		{
			Console.WriteLine(Methods.CalcTriangleArea(3, 4, 5));

			Console.WriteLine(Methods.DigitToString(5));

			Console.WriteLine(Methods.FindMax(5, -1, 3, 2, 14, 2, 3));

			Methods.FormatNumber(1.3, "f");
			Methods.FormatNumber(0.75, "%");
			Methods.FormatNumber(2.30, "r");

			bool horizontal = Methods.IsHoryzontal(3, -1, 3, 2.5);
			bool vertical = Methods.IsVertical(3, -1, 3, 2.5);
			Console.WriteLine(Methods.CalcDistance(3, -1, 3, 2.5));
			Console.WriteLine("Horizontal? " + horizontal);
			Console.WriteLine("Vertical? " + vertical);

			Student peter = new Student("Peter", "Ivanov", "1992-03-17");
			peter.OtherInfo = "From Sofia";

			Student stella = new Student("Stella", "Markova", "1993-03-11");
			stella.OtherInfo = "From Vidin, gamer, high results";

			Console.WriteLine("{0} older than {1} -> {2}", peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
		}
    }
}
