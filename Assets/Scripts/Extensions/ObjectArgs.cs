using System;

public class ObjectArgs : EventArgs
{
  public object Object { get; set; }

  public ObjectArgs()
  {
  }

  public ObjectArgs(object _object)
  {
    Object = _object;
  }
}