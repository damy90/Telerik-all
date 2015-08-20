using System;
using System.Linq;

public class ConsoleWriter
{
    public static void Main()
    {
        var instance = new ConsoleWriter.BooleanMethods();
        instance.PrintArgument(true);
    }

    public class BooleanMethods
    {
        public void PrintArgument(bool argument)
        {
            string boolToString = argument.ToString();
            Console.WriteLine(boolToString);
        }
    }
}