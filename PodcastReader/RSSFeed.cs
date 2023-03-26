// Decompiled with JetBrains decompiler
// Type: SimplePod.RSSFeed
// Assembly: SimplePod, Version=1.0.5264.34941, Culture=neutral, PublicKeyToken=null
// MVID: C5473E8A-586D-4901-99C0-8F1B8FCE6292
// Assembly location: C:\Users\Manu.DESKTOP-LO7Q3C5\source\repos\PodcastRearder\PodcastRearder\bin\Debug\SimplePod.dll

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;

namespace PodcastReader
{
    public class RssFeed
    {
        public string FeedUrl { get; set; }
        //private string title;
        public string Title { get; set; }
        public string HomeUrl { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string authors { get; set; }
        public List<RssItem> ItemList { get; set; }
        public string Data { get; set; }
        public DateTime LastRefresh { get; set; }
        public RssFeed(string feedUrl)
        {
            this.FeedUrl = feedUrl;
            this.ItemList = new List<RssItem>();

        }

        public void Load()
        {
            //this.itemList.Clear();
            try
            {
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.Load(this.FeedUrl);
                XmlNode xmlNode1 = xmlDocument.SelectSingleNode("rss");
                if (xmlNode1 == null)
                    return;
                XmlNamespaceManager nsmgr = new XmlNamespaceManager(xmlDocument.NameTable);
                nsmgr.AddNamespace("itunes", "http://www.itunes.com/dtds/podcast-1.0.dtd");
                XmlNode xmlNode2 = xmlNode1.SelectSingleNode("channel");
                if (xmlNode2 == null)
                    return;
                try
                {
                    this.Title = xmlNode2.SelectSingleNode("title").InnerText;
                    this.Description = xmlNode2.SelectSingleNode("itunes:summary", nsmgr).InnerText;
                    this.HomeUrl = xmlNode2.SelectSingleNode("link").InnerText;
                    this.ImageUrl = xmlNode2.SelectSingleNode("itunes:image", nsmgr).Attributes["href"].Value;
                    this.authors = xmlNode2.SelectSingleNode("itunes:author", nsmgr).InnerText;
                    this.Data = xmlDocument.InnerXml;
                    this.LastRefresh = DateTime.Now;
                }
                catch (Exception ex)
                {
                    throw new InvalidRssException(ex.StackTrace);
                }
                XmlNodeList xmlNodeList = xmlNode2.SelectNodes("item");
                if (xmlNodeList == null)
                    return;
                int index = 0;
                while (index < xmlNodeList.Count)
                {
                    var curNode = xmlNodeList[index];

                    try
                    {
                        string title = curNode.SelectSingleNode("title").InnerText;
                        string description = curNode.SelectSingleNode("description").InnerText;
                        string pubDate = curNode.SelectSingleNode("pubDate").InnerText;
                        string url = curNode.SelectSingleNode("enclosure").Attributes["url"].Value;
                        string codec = curNode.SelectSingleNode("enclosure").Attributes["type"].Value;
                        int size = 0;
                        try
                        {
                            size = int.Parse(curNode.SelectSingleNode("enclosure").Attributes["length"].Value);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.StackTrace);
                        }

                        RssItem n=null;

                        try
                        {
                            n = this.ItemList.Where(r => r.Title == title).ToArray()[0];
                        }
                        catch (Exception ex)
                        {

                            //throw;
                        }
                        
                        if (n==null)
                        {
                            this.ItemList.Add(new RssItem(title, description, pubDate, url, codec, size, curNode.InnerXml));

                        }
                        else
                        {
                            //if()
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new InvalidRssItemException(ex.StackTrace);
                    }
                    checked { ++index; }
                }
                // This shows calling the Sort(Comparison(T) overload using
                // an anonymous method for the Comparison delegate.
                // This method treats null as the lesser of two values.
                this.ItemList.Sort(delegate (RssItem x, RssItem y)
                {
                    return x.PubDate.CompareTo(y.PubDate);
                    /*if (x.pubDate== null && y.PartName == null) return 0;
                    else if (x.PartName == null) return -1;
                    else if (y.PartName == null) return 1;
                    else return x.PartName.CompareTo(y.PartName);
                    */
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                throw ex;
            }
        }

      
        public override string ToString()
        {
            return Title.Length > 0 ? Title : HomeUrl;
        }
        public string GetDirname(string root)
        {
            string dir = RemoveIllegalCharacters(Title);
            dir = Path.Combine(root, dir);
            return dir;
        }
        private string RemoveIllegalCharacters(string str)
        {
            string invalid = new string(Path.GetInvalidFileNameChars()) + new string(Path.GetInvalidPathChars()) + '.'.ToString();

            foreach (char c in invalid)
            {
                str = str.Replace(c.ToString(), "");
            }
            return str;
        }

    }
}
