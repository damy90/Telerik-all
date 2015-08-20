namespace FindValue
{
    using System;

    public class FindValue
    {
        public static void Main(string[] args)
        {
            bool valueFound = false;
            for (int i = 0; i < 100; i++)
            {
                if (i % 10 == 0)
                {
                    if (array[i] == expectedValue)
                    {
                        valueFound = true;
                    }
                }
                
                Console.WriteLine(array[i]);
            }

            // More code here
            if (valueFound == 666)
            {
                Console.WriteLine("Value Found");
            }
        }
    }
}
