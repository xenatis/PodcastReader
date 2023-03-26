using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PodcastReader
{
    class Settings
    {
        public BindingList<RssFeed> RssFeeds = new BindingList<RssFeed>();
        public FormSettings FormSettings=new FormSettings();
        const string Filename = "settings.txt";
        const string BackupDir = "settings_backup";
        public string SaveFolder = "file";
        public void Serialize()
        {
            //backup current settings
            if (!Directory.Exists(BackupDir))
                Directory.CreateDirectory(BackupDir);

            int i = 1;
            while (File.Exists(Path.Combine(BackupDir, Filename + i)))
                i++;
            if(File.Exists(Filename)) File.Copy(Filename, Path.Combine(BackupDir, Filename + i));

            string s = Newtonsoft.Json.JsonConvert.SerializeObject(this,Formatting.Indented);
            File.WriteAllText(Filename, s);
        }

        public static Settings Deserialize()
        {
            Settings set = null;
            if (File.Exists(Filename))
            {
                string json = File.ReadAllText(Filename);
                set = Newtonsoft.Json.JsonConvert.DeserializeObject<Settings>(json);
            }
            if (set is null) return new Settings();
            else return set;
        }
    }

    class FormSettings
    {
            
        public System.Drawing.Size FormSize = new System.Drawing.Size(1418, 458);
        public int SplitFeedsDistance=264;
        public int SplitInfosDistance=156;
        public int SplitMainDistance=754;
    }
}
