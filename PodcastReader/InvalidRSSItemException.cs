// Decompiled with JetBrains decompiler
// Type: SimplePod.InvalidRSSItemException
// Assembly: SimplePod, Version=1.0.5264.34941, Culture=neutral, PublicKeyToken=null
// MVID: C5473E8A-586D-4901-99C0-8F1B8FCE6292
// Assembly location: C:\Users\Manu.DESKTOP-LO7Q3C5\source\repos\PodcastRearder\PodcastRearder\bin\Debug\SimplePod.dll

using System;

namespace PodcastReader
{
  public class InvalidRssItemException : Exception
  {
    public InvalidRssItemException()
      : base("Invalid RSS Feed Item")
    {
    }

    public InvalidRssItemException(string message)
      : base("Invalid RSS Feed Item | " + message)
    {
    }

    public InvalidRssItemException(string message, Exception innerException)
      : base("Invalid RSS Feed Item | " + message, innerException)
    {
    }
  }
}
