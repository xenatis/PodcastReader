// Decompiled with JetBrains decompiler
// Type: SimplePod.RSSItem
// Assembly: SimplePod, Version=1.0.5264.34941, Culture=neutral, PublicKeyToken=null
// MVID: C5473E8A-586D-4901-99C0-8F1B8FCE6292
// Assembly location: C:\Users\Manu.DESKTOP-LO7Q3C5\source\repos\PodcastRearder\PodcastRearder\bin\Debug\SimplePod.dll

using System;

namespace PodcastReader
{
    public class RssItem
    {
        public string Title { get; set; }

        public readonly string Description;
        public DateTime PubDate;
        public readonly string Url;
        public bool Read { get; set; }
        private int _size;
        public string Data { get; set; }

        public RssItem(string title, string des, string date, string url, string codec, int size, string data)
        {
            this.Title = title;
            this.Description = des;
            if(!String.IsNullOrEmpty(date))
                this.PubDate = DateTime.Parse( date);
            this.Url = url;
            this._size = size;
            this.Read = false;
            this.Data = data;
        }
        public string GetFilename()
        {
            var pos = Url.LastIndexOf("/");
            var pos2 = Url.LastIndexOf(".mp3");

            return Url.Substring(pos + 1, pos2 - pos + 3);
        }

        public override string ToString()
        {
            return (this.Read ? "x " : "") + Title;
        }
    }
}
