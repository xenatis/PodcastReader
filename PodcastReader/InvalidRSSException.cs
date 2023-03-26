// Decompiled with JetBrains decompiler
// Type: SimplePod.InvalidRSSException
// Assembly: SimplePod, Version=1.0.5264.34941, Culture=neutral, PublicKeyToken=null
// MVID: C5473E8A-586D-4901-99C0-8F1B8FCE6292
// Assembly location: C:\Users\Manu.DESKTOP-LO7Q3C5\source\repos\PodcastRearder\PodcastRearder\bin\Debug\SimplePod.dll

using System;

namespace PodcastReader
{
  public class InvalidRssException : Exception
  {
    public InvalidRssException()
      : base("Malformed RSS feed")
    {
    }

    public InvalidRssException(string message)
      : base("Malformed RSS feed | " + message)
    {
    }

    public InvalidRssException(string message, Exception innerException)
      : base("Malformed RSS feed | " + message, innerException)
    {
    }
  }
}
