using System;
using System.Net;
using System.IO;
//Write a program that downloads a file from Internet (e.g. http://www.devbg.org/img/Logo-BASD.jpg) and stores it the current directory.
//Find in Google how to download files in C#. Be sure to catch all exceptions and to free any used resources in the finally block.
class DownloadFile
{
    //find the current directory
    static string GetSavePath(string fileName)
    {
        string currentDir = Environment.CurrentDirectory;
        DirectoryInfo directory = new DirectoryInfo(currentDir);
        string fullDirectory = directory.FullName;
        return fullDirectory +@"\"+ fileName;
    }
    static void Main()
    {
        string fileName="news-img01.png";
        string path = GetSavePath(fileName);
        string address = "http://telerikacademy.com/Content/Images/news-img01.png";
        WebClient client = new WebClient();
        try
        {
            client.DownloadFile(address, path);
            Console.WriteLine("File saved in {0}", path);
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("The address can not be null");
        }
        catch (WebException)
        {
            Console.WriteLine("Invalid address or file name.");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("Simultaneous downloads are not supported.");
        }
        finally
        {
            client.Dispose();
        }
    }
}
