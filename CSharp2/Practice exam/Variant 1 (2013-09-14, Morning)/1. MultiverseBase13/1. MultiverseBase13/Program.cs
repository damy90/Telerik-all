using System;
//using System.Linq;

class Program
{
    static void Main()
    {
        string imput = Console.ReadLine();
        int didgitLength = 3;
        int fromBase = 13;
        var words2 = new string[imput.Length / didgitLength];
        //Sanest split
        for (int i = 0; i < imput.Length / didgitLength; i++)
        {
            words2[i] = imput.Substring(i * didgitLength, didgitLength);
        }

        string[] hexMap = { "CHU", "TEL", "OFT", "IVA", "EMY", "VNB", "POQ", "ERI", "CAD", "K-A", "IIA", "YLO", "PLA" };

        //Console.WriteLine(hexMap.Length);
        ulong intNumber = 0;
        for (int j = 0; j < words2.Length; j++)
        {
            intNumber += (ulong)(Array.IndexOf(hexMap, words2[j]) * Math.Pow(fromBase, words2.Length - 1 - j));
        }

        Console.WriteLine(intNumber);
    }
}
