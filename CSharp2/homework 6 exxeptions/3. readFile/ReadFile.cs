using System;
using System.IO;
//Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console.
//Find in MSDN how to use System.IO.File.ReadAllText(…).
//Be sure to catch all possible exceptions and print user-friendly error messages.
class ReadFile
{
    static void Main()
    {
        string path = @"C:\WINDOWS\win.ini";
        string text = "";
        try
        {
            text = File.ReadAllText(path);
            Console.WriteLine(text);
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("Empty path");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Invalid path");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("The directory doesnot exist");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("The file was not found");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("This file is protected or no file name was given");
        }
    }
}
