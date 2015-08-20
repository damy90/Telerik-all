//12. Write a class GSMCallHistoryTest to test the call history functionality of the GSM class.
//Create an instance of the GSM class.
//Add few calls.
//Display the information about the calls.
//Assuming that the price per minute is 0.37 calculate and print the total price of the calls in the history.
//Remove the longest call from the history and calculate the total price again.
//Finally clear the call history and print it.
using System;
using System.Linq;

public static class GSMCallHistoryTest
{
    public static void StartTest()
    {
        var display = new Display(3, 300);
        var battery = new Battery("S.NO.W3TT543");
        GSM addPhone = new GSM("Hero", "HTC", 100m, "4ovek", battery, display);

        DateTime time = new DateTime(2013, 1, 10, 11, 00, 00);
        string number = "08837656282";
        int duration = 60;
        addPhone.AddCall(time, number, duration);

        DateTime time1 = new DateTime(2013, 1, 10, 12, 00, 00);
        string number1 = "08957656282";
        int duration1 = 135;
        addPhone.AddCall(time1, number1, duration1);

        DateTime time2 = new DateTime(2013, 1, 10, 12, 05, 00);
        string number2 = "08957656282";
        int duration2 = 35;
        addPhone.AddCall(time2, number2, duration2);

        var callHistory = addPhone.CallHistory;
        Console.WriteLine();
        foreach (var call in callHistory)
        {
            Console.WriteLine("Call: {0}\t{1}\t{2} secconds", call.Phone, call.Time, call.Duration);
        }

        Console.WriteLine("The bill is: {0}$", addPhone.Bill(0.37m));

        callHistory = callHistory.OrderByDescending(x => x.Duration).ToList();
        addPhone.DelCall(callHistory[0]);
        Console.WriteLine("After deleting the longest call the bill is: {0}$", addPhone.Bill(0.37m));

        addPhone.ClearCallHistory();
        Console.WriteLine("Printing call history (should be empty)");
        callHistory = addPhone.CallHistory;
        foreach (var call in callHistory)
        {
            Console.WriteLine("Call: {0}\t{1}\t{2} secconds", call.Phone, call.Time, call.Duration);
        }
    }
}
