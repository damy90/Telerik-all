//Using delegates write a class Timer that has can execute certain method at each t seconds.
using System;
using System.Threading;

public class Timer
{
    static void TestMethod()
    {
        Console.WriteLine("Execute");
    }

    static void Main()
    {
        int t = 2000;
        Delegate d = new Delegate(TestMethod);
        while (true)
        {
            d();
            Thread.Sleep(t);
        }
    }
}
