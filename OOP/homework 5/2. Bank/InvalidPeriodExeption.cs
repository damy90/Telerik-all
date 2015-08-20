using System;

public class InvalidPeriodException
  : ApplicationException
{
    public InvalidPeriodException(string msg)
        : base(msg)
    { }

    public InvalidPeriodException(string msg,
      Exception innerEx)
        : base(msg, innerEx)
    { }
}