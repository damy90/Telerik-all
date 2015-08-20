//A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
//Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.

using System;

class bankAccount
{
    static void Main()
    {
        string firstName = "Hristo";
        string midleName = "Hristov";
        string lastName = "Hristoskov";
        float balance = 10000.5f;
        string bankName = "ICABRY (In Capitalist America Bank Robs You)";
        ulong IBAN = 9123456789;
        uint BIC = 123445;
        ulong cardNumber1 = 134567890;
        ulong cardNumber2 = 234567890;
        ulong cardNumber3 = 334567890;
        Console.WriteLine("First name:\t{0}\nMidle name:\t{1}\nLast name:\t{2}\nBalance name:\t{3:0.00}\nBank name:\t{4}\nIBAN name:\t{5}\nBIC name:\t{6}\nFirst credit card number:\t{7}\nSecond credit card number:\t{8}\nThirth credit card number:\t{9}"
            , firstName, midleName, lastName, balance, bankName, IBAN, BIC, cardNumber1, cardNumber2, cardNumber3);
    }
}
