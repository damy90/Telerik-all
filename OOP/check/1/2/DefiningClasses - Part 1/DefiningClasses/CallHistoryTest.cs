namespace DefiningClasses
{
    using System;
    using System.Collections.Generic;

    public class CallHistoryTest
    {
        public static GSM test = new GSM("Nokia", "Microsoft Corporation");

        public static DateTime date1 = DateTime.Parse("10/03/2015 09:25:10");
        public static DateTime date2 = DateTime.Parse("08/03/2015 19:15:30");
        public static DateTime date3 = DateTime.Parse("09/03/2015 14:07:18");
        public static DateTime date4 = DateTime.Parse("10/03/2015 08:15:55");
        public static DateTime date5 = DateTime.Parse("10/03/2015 12:37:03");

        public static Call[] testCalls =
            {
                new Call(date1, "0883391256", 25),
                new Call(date2, "0883123456", 2),
                new Call(date3, "0883654789", 30),
                new Call(date4, "0883645231", 10),
                new Call(date5, "0883147852", 5),

            };

        public static void CreateCallHistory()
        {
            for (int i = 0; i < testCalls.Length; i++)
            {
                test.Add(testCalls[i]);
            }
        }

        public static void DisplayCalltestHistory()
        {
            Console.WriteLine(test.PrintCallHistory());
        }

        public static void CalculateAndPrintTestcallsPrice()
        {
            decimal price = test.CalculateTotalPrice(0.37M);
            Console.WriteLine("Total price of test calls: {0:F2}", price);
        }

        public static void Main()
        {
            CreateCallHistory();
            DisplayCalltestHistory();
            CalculateAndPrintTestcallsPrice();
            GSMTest.GSMTestMethod();
        }
    }
}
