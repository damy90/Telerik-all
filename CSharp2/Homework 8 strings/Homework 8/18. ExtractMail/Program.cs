using System;
using System.Text.RegularExpressions;
//Write a program for extracting all email addresses from given text.
//All substrings that match the format <identifier>@<host>…<domain> should be recognized as emails.
class ExtractMail
{
    static void Main()
    {
        string text = "Confidential data: Accounts and passwords s.nakov@telerik.com. The Great And Omnipotent##% , someone@gmail.co.uk,password";

        Regex emailRegex = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", RegexOptions.IgnoreCase);
        var emails = emailRegex.Matches(text);

        foreach (var account in emails)
            Console.WriteLine(account);
    }
}