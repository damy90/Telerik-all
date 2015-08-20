namespace DefiningClasses
{
    using System;
    using System.Collections.Generic;

    public class GSMTest
    {
        public static void GSMTestMethod()
        {
            //GSM[] phoneDevices = new GSM[3];

            //string[] models = { "Samsung", "LG", "HTC" };
            //string[] manufacturers = { "UK", "China", "Japan" };
            //decimal[] prices = { 1200, 1100, 750 };
            //string[] owners = { "Pesho", "Gosho", "Dragan" };
            //Battery[] batteries =
            //{
            //new Battery(), new Battery("Better", 250, 25, BatteryTypes.LiIon),
            //new Battery("Bad", 50, 5, BatteryTypes.NiCd), new Battery("TestModel", 300, 30, BatteryTypes.NiMH)
            //};

            GSM test1 = new GSM("Samsung", "Samsung C&T Corporation", 140000, "HappyOwner",
                    new Battery("Standard", 100.0, 10.0, BatteryTypes.LiIon),
                    new Display(), new List<Call>());

            GSM test2 = new GSM("Nokia", "Microsoft Corporation");

            GSM test3 = new GSM("Sony", "Sony Corporation", 100, "Me&Myself", new Battery(), new Display(), new List<Call>());

            GSM[] allPhones = { test1, test2, test3 };

            foreach (var gsm in allPhones)
            {
                Console.WriteLine(gsm);
            }

            //Display the information about the static property IPhone4S
            Console.WriteLine(GSM.IPhone4S.Model);
            Console.WriteLine(GSM.IPhone4S.Manufacturer);
        }
    }
}
