using System;

public class InvalidDimentionValueException
  : ApplicationException
{
    public InvalidDimentionValueException(string msg)
        : base(msg)
    { }

    public InvalidDimentionValueException(string msg,
      Exception innerEx)
        : base(msg, innerEx)
    { }
}