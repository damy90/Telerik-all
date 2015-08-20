using System.Text;

//Implement an extension method Substring for the class StringBuilder that returns new StringBuilder and has the same functionality as Substring in the class String.

public static class Extensions
{
    public static StringBuilder Substring(this StringBuilder input, int startIndex, int endIndex = -1)
    {
        if (endIndex==-1)
            endIndex = input.Length - startIndex;
        StringBuilder result=new StringBuilder(input.ToString().Substring(startIndex, endIndex));
        return result;
    }
}
