using System;

[Version("v. 1.0.5")]
class Program
{
    static void Main()
    {
        Type type = typeof(Program);
        object[] attr = type.GetCustomAttributes(false);
        foreach (VersionAttribute item in attr)
        {
            Console.WriteLine(item.Version);
        }
    }
}
