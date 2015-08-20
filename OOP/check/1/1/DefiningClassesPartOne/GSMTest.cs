namespace DefiningClassesPartOne
{
    using System;

    public class GSMTest           //problem 7
    {
        private static GSM[] mobilePhones = { new GSM("iPhone 6", "Apple", 1200.00m, "", new Battery("Model A1332",
                                                        250.00, 14.00, BatteryTypes.LiIon), new Display(4.7, 16000000)),
                                              new GSM("Galaxy 7", "Samsung", 1080.00m, "", new Battery("Model A1333",
                                                        230.00, 15.00, BatteryTypes.LiIon), new Display(5.5, 16000000))};

        public static void PrintPhones()
        {
            Console.WriteLine("Your phones characteristics: ");
            Console.WriteLine();

            foreach (GSM phone in mobilePhones)
            {
                Console.WriteLine(phone);
                Console.WriteLine();
            }

            Console.WriteLine(GSM.IPhone4S);
        }
    }
}

        

