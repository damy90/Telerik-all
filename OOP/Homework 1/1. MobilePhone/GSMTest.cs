//7. Write a class GSMTest to test the GSM class:
//Create an array of few instances of the GSM class.
//Display the information about the GSMs in the array.
//Display the information about the static property IPhone4S

using System;

public static class GSMTest
{
    public static void StartTest()
    {
        var display = new Display(3, 300);
        var battery = new Battery("S.NO.W3TT543");
        GSM theFirstPhone = new GSM("Hero", "HTC", 100m, "4ovek", battery, display);
        var phone1 = new GSM("S5230", "ZTE");
        var phone2 = new GSM("S5230", "ZTE", null, null, null, display);
        var phones = new GSM[] { theFirstPhone, phone1, phone2 };

        foreach (var phone in phones)
        {
            Console.WriteLine(phone);
        }

        Console.WriteLine(GSM.GetIPhone());
    }
}
