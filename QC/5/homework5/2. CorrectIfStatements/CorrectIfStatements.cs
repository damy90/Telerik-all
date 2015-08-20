namespace CorrectIfStatements
{
    using System;

    public class CorrectIfStatements
    {
        private static readonly int XMax = int.MaxValue;
        private static readonly int YMin = 0;
        private static readonly int YMax = int.MaxValue;

        public static void Main()
        {
            Potato potato;

            // ... 
            if (potato != null)
            {
                if (potato.isPeeled && !potato.IsRotten)
                {
                    Cook(potato);
                }
            }

            if (IsInRange(x, y) && !shouldNotVisitCell)
            {
                VisitCell();
            }
        }

        private static bool IsInRange(int x, int y)
        {
            bool isInRange = x <= XMax && (YMax >= y && YMin <= y);
            return isInRange;
        }
    }
}
