namespace ComputersProgram
{
    using System;
    using System.Collections.Generic;
    using ComputersProgram.ComputerProducerFactory;

    public class Computers
    {
        public static Computer Pc { get; set; }

        public static Computer Laptop { get; set; }

        public static Computer Server { get; set; }

        public static void Create()
        {
            string manufacturer = Console.ReadLine();
            SimpleComputerFactory factoryMaker = new SimpleComputerFactory();
            AbstractComputerFactory myFactory = factoryMaker.CreateFactory(manufacturer);
       
            Pc = myFactory.MakePC();
            Laptop = myFactory.MakeLaptop();
           Server = myFactory.MakeServer();
        }
    }
}
