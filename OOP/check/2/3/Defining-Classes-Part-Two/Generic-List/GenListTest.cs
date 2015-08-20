namespace MyCollections.Tests
{
    using System;
    using System.Collections.Generic;
    
    
    public class GenListTest
    {
        static void Main()
        {
            var genList = new GenericList<int>(0);
            genList.Add(1);
            genList.Add(2);
            genList.Add(3);
            genList.Add(4);
            genList.Add(5);
            genList.Add(12);
            genList.Insert(0, 6);
            genList.Insert(0, 6);
            genList.Insert(0, 6);
            genList.Insert(0, 6);
            genList.Insert(0, 6);
            genList.Insert(0, 6);
            Console.WriteLine(genList.ElementAt(1));

            Console.WriteLine(genList.Min());
            Console.WriteLine(genList.Max());

            Console.WriteLine(new string('=', 50));
            genList.RemoveAt(1);
            Console.WriteLine(genList.ToString());

            genList.Insert(1, 2);
            Console.WriteLine(genList.ToString());

            genList.Insert(12, 0);
            Console.WriteLine(genList.ToString());

            var idxof = (genList.IndexOf(2));
            Console.WriteLine(idxof);

            genList.Clear();
            Console.WriteLine(genList.ToString());



            List<int> list = new List<int>();
        }
    }
}
