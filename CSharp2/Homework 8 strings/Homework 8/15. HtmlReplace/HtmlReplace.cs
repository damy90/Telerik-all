using System;
//Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].
class HtmlReplace
{
    static void Main()
    {
        string text = @"<p>Please visit <a href=""http://academy.telerik.com"">our site</a> to choose a training course. Also visit <a href=""www.devbg.org"">our forum</a> to discuss the courses.</p>";

        string output = text.Replace(@"<a href=""", "[URL=");
        output = output.Replace(@"</a>", "[/URL]");
        output = output.Replace(@""">", "]");
        Console.WriteLine(output);
    }
}
