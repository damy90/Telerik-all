using System;

//Define a class InvalidRangeException<T> that holds information about an error condition related to invalid range.
//It should hold error message and a range definition [start … end].

public class InvalidRangeException<T> : ApplicationException
{
    public T Start { get; set; }
    public T End { get; set; }
    public InvalidRangeException(string msg, T start, T end)
        : base(msg)
    {
        this.Start = start;
        this.End = end;
    }
}