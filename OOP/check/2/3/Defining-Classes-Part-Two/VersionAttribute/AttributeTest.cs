namespace MyAttributes
{
    using System;
    

    [VersionAttribute("v. 2.11")]

    class AttributeTest
    {
        static void Main()
        {
            Type type = typeof(AttributeTest);
            object[] allAttributes = type.GetCustomAttributes(false);
            foreach (VersionAttribute attr in allAttributes)
            {
                Console.WriteLine(
                  "This class is version: {0}. ", attr.Version );

            }
        }
    }
}
