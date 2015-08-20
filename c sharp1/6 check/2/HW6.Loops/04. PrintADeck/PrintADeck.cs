using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PrintADeck
{
    static void Main()
    {
        int a = 3;
        int b = 4;
        int c = 5;
        int d = 6;
        for (int i = 2; i < 15; i++)
        {
            if (i > 1 && i < 11)
            {
                Console.WriteLine("" + ((char)a) + i + " " + ((char)b) + i + " " + ((char)c) + i + " " + ((char)d) + i);
            }
            else
            {
                for (int j = i; j < i + 1; j++)
                    switch (i)
                    {
                        case 11: Console.WriteLine((char)a + "J " + (char)b + "J " + (char)c + "J " + ((char)d) + "J "); 
                            break;
                        case 12: Console.WriteLine((char)a + "D " + (char)b + "D " + ((char)c) + "D " + ((char)d) + "D "); 
                            break;
                        case 13: Console.WriteLine((char)a + "K " + (char)b + "K " + (char)c + "K " + ((char)d) + "K ");
                            break;
                        case 14: Console.WriteLine((char)a + "A " + (char)b + "A " + (char)c + "A " + ((char)d) + "A ");
                            break;
                        default: Console.WriteLine("Something's wrong!");
                            break;
                    }
            }
        }
    }
}
