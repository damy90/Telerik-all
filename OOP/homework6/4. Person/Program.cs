using System;

class Program
{
    static void Main()
    {
        Person joro = new Person("Joro", null);
        Person go6o = new Person("Go6o", 44);
        Console.WriteLine(joro);
        Console.WriteLine(go6o);
        //exeption tests
        //Person geri = new Person("Geri", -1);
        //Console.WriteLine(geri);
        //Person anonimous = new Person("", null);
        //Console.WriteLine(anonimous);
    }
}
