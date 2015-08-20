using System;
using System.IO;

namespace TradeAndTravel
{
    class Program
    {
        static void Main(string[] args)
        {
            //StreamWriter sw = new StreamWriter(new FileStream("../../output.txt", FileMode.Create));
            //Console.SetOut(sw);  //пренасочва към sw
            
            var engine = new Engine(new ExtendedInteractionManager());
            engine.Start();
 
            //sw.Close();  
            
        }
    }
}
