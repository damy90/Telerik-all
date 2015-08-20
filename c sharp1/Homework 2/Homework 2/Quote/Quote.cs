//Declare two string variables and assign them with following value: The "use" of quotations causes difficulties.
//Do the above in two different ways - with and without using quoted strings.
//Print the variables to ensure that their value was correctly defined.

using System;

class Quote
{
    static void Main()
    {
        string quote1 = "The \"use\" of quotations causes difficulties.";
        string noQuote = "The use of quotations causes difficulties.";
        string quote2 = "@The \"use\" of quotations causes difficulties.";
        Console.WriteLine("{0}\n{1}\n{2}", quote1, quote2, noQuote);
    }
}