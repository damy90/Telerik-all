using System;

class Program
{
    static void Main()
    {
        GenericList<int> theWheelReinvented = new GenericList<int>(5);
        var element = 4;
        theWheelReinvented.Add(element);
        element = 5;
        theWheelReinvented.Insert(0, element);
        theWheelReinvented.Insert(theWheelReinvented.Count, element);
        Console.WriteLine(theWheelReinvented[0]);
        Console.WriteLine(theWheelReinvented.Count);
        element = -5;
        theWheelReinvented.Add(element);
        theWheelReinvented.Add(element);
        Console.WriteLine(theWheelReinvented.Capacity);
        theWheelReinvented.RemoveAt(0);
        theWheelReinvented.RemoveAt(theWheelReinvented.Count - 1);
        Console.WriteLine(theWheelReinvented);
        Console.WriteLine(theWheelReinvented.IndexOf(-5));
        Console.WriteLine(theWheelReinvented.Max());
        Console.WriteLine(theWheelReinvented.Min());
        theWheelReinvented.Clear();
        Console.WriteLine(theWheelReinvented);
    }
}
