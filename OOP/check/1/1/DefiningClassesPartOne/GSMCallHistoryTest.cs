namespace DefiningClassesPartOne
{
    using System;

    public class GSMCallHistoryTest            //problem 12
    {
        private static GSM gsm = new GSM();

        private static Call[] calls = { new Call(DateTime.Now, "0888888888", 10), 
                                      new Call (DateTime.Now.AddHours(1), "0898777777", 15),
                                      new Call(DateTime.Now.AddHours(2), "0897888777", 20) };
        
        public static void PrintCallsInfo()
        {
            foreach (Call call in calls)
            {
                gsm.AddCalls(call);
            }

            Console.WriteLine("Information for your calls: ");

            foreach (Call call in gsm.CallHistory)
            {
                Console.WriteLine(call);
                Console.WriteLine();
            }

            Console.WriteLine(new string('-', 80));

            Console.WriteLine("Total price of your calls: {0:F2}", gsm.CalculationCallsTotalPrice(0.37d));
           
            Call longestCall = gsm.CallHistory[0];
            for (int i = 1; i < gsm.CallHistory.Count; i++)
            {
                if (gsm.CallHistory[i].Duration > longestCall.Duration)
                {
                    gsm.CallHistory[i] = longestCall;
                }
            }

            gsm.CallHistory.Remove(longestCall);
            Console.WriteLine("Total price after longest call remove: {0:F2}", gsm.CalculationCallsTotalPrice(0.37d));
            Console.WriteLine();

            gsm.ClearHistory();
            Console.WriteLine("Your call history is clear! ");
            Console.WriteLine();
        }
    }
}

           
           

            

        

            

        
        
       
                
           



