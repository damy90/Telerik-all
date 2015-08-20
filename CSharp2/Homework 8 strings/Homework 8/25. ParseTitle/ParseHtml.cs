using System;
using System.Text.RegularExpressions;

class ParseHtml
{
    static void Main()
    {
        string html = @"<html><head><title>News</title></head> <body><p><a href=/""http://academy.telerik.com"">Telerik Academy</a>aims to provide free real-world practical training for young people who want to turn into skillful .NET software engineers.</p></body> </html>";
        
        string title=Title(html);
        string body = Body(html);

        Console.WriteLine(title);
        Console.WriteLine(body);
    }
    static string Title(string html)
    {
        Match m = Regex.Match(html, @"<title>\s*(.+?)\s*</title>");
        if (m.Success)
        {
            return m.Groups[1].Value;
        }
        else
        {
            return "";
        }
    }
    static string Body(string html)
    {
        Match m = Regex.Match(html, @"<body>\s*(.+?)\s*</body>");
        string body = m.Groups[1].Value;
        return Regex.Replace(body, @"<(.|\n)*?>", string.Empty);
    }
}
