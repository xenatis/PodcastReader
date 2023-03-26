using Essy.Tools.InputBox;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PodcastReader
{
    public partial class Form1 : Form
    {
        //BindingList<RSSFeed> _rssFeeds = new BindingList<RSSFeed>();
        Settings _settings = Settings.Deserialize();
        Thread _t;
        RssItem _selectedRssItem;
        RssFeed _selectedRssFeed;
        bool _enableSaveSplitterDistance = false;

        public Form1()
        {
            InitializeComponent();
            this.Size = _settings.FormSettings.FormSize;
            splitMain.SplitterDistance = _settings.FormSettings.SplitMainDistance;
            splitFeeds.SplitterDistance = _settings.FormSettings.SplitFeedsDistance;
            splitInfos.SplitterDistance = _settings.FormSettings.SplitInfosDistance;
            this.Icon = PodcastReader.Properties.Resources.radio_23683;
            if (_settings.RssFeeds.Count==0)
            {
                 _settings.RssFeeds.Add(new RssFeed("https://www.rts.ch/docs/histoire-vivante/podcasts/?flux=rss/podcast"));
                _settings.RssFeeds.Add(new RssFeed("http://radiofrance-podcast.net/podcast09/rss_17362.xml"));
                btnRefreshFeeds_Click(null, null);

            }
            //_rssFeeds = _settings.RssFeeds;
            lstRssFeeds.DataSource = _settings.RssFeeds;
            //lstRssFeeds.ValueMember = "title";
            //lstItems.DisplayMember = "title";
            _enableSaveSplitterDistance = true;
        }
        #region Buttons
        private void btnAddRssFeed_Click(object sender, EventArgs e)
        {
            string s;
            s = InputBox.ShowInputBox("Add new rss feed");
            //s = "https://www.rts.ch/docs/histoire-vivante/podcasts/?flux=rss/podcast";
            //http://radiofrance-podcast.net/podcast09/rss_17362.xml
            RssFeed rss = new RssFeed(s);
            rss.Load();
            _settings.RssFeeds.Add(rss);

            lstItems.DataSource = rss.ItemList;
            _settings.Serialize();

        }
        private void btnRemoveRssFeed_Click(object sender, EventArgs e)
        {
            if(lstRssFeeds.SelectedItems.Count==0)
                return;
            
            RssFeed r = (RssFeed)lstRssFeeds.SelectedItem;
            _settings.RssFeeds.Remove(r);
            _settings.Serialize();
        }

        private void btnRefreshFeeds_Click(object sender, EventArgs e)
        {
            AddInfo("Refreshing...");
            foreach (RssFeed feed in _settings.RssFeeds)
            {
                AddInfo(feed.FeedUrl);
                feed.Load();
            }

            var selectedIndex = int.MinValue;
            if(lstRssFeeds.SelectedItems.Count==1)
                selectedIndex= lstRssFeeds.SelectedIndex;
            
            lstRssFeeds.DataSource = null;
            lstRssFeeds.DataSource = _settings.RssFeeds;
            
            if(selectedIndex!=int.MinValue)
                lstRssFeeds.SelectedIndex = selectedIndex;
            
            AddInfo("Feeds refreshed");
            _settings.Serialize();
        }

        private void btnDownloadAudioFiles_Click(object sender, EventArgs e)
        {
            if (_t != null && _t.IsAlive)
            {
                //stop

                _t.Abort();
                btnDownloadAudioFiles.Text = "Download";

            }
            else
            {
                //start
                _t = new Thread(DownloadAudioFiles);
                _t.Start();
                btnDownloadAudioFiles.Text = "Stop DL";

            }
        }
        #endregion

        #region Lists
        private void lstItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstItems.SelectedItems.Count == 1)
            {
                RssItem item = (RssItem)lstItems.SelectedItem;
                txtItemInfos.Text = new StringBuilder()
                    .AppendLine(item.Title)
                    .AppendLine(item.Description)
                    .AppendLine(item.PubDate.ToString())
                    .ToString();
            }
        }

        private void lstRssFeeds_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstRssFeeds.SelectedItems.Count == 1)
            {
                RssFeed r = (RssFeed)lstRssFeeds.SelectedItem;
                lstItems.DataSource = r.ItemList;
                StringBuilder sb = new StringBuilder();
                txtFeedInfos.Text =
                    sb.AppendLine(r.Title)
                    .AppendLine(r.authors)
                    .AppendLine(r.Description)
                    .AppendLine("Last refresh:"+r.LastRefresh.ToString())
                    .ToString();
            }
        }
        private void lstItems_DoubleClick(object sender, EventArgs e)
        {
            if (lstItems.SelectedItems.Count == 1)
            {
                string dir = ((RssFeed)lstRssFeeds.SelectedItem).GetDirname(_settings.SaveFolder);
                var item = (RssItem)lstItems.SelectedItem;
                var file = (item).GetFilename();
                file = Path.Combine(dir, file);
                if (!File.Exists(file))
                {
                    DownloadFile(item.Url, file);
                }
                System.Diagnostics.Process.Start(file);
                //item.title = "x " + item.title;
                item.Read = true;
                _settings.Serialize();
            }
        }
        #endregion

        #region Menu
        private void downloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var feed = lstRssFeeds.SelectedItem as RssFeed;
            string dir = feed.GetDirname(_settings.SaveFolder);
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);


            string file = Path.Combine(dir, _selectedRssItem.GetFilename());
            string[] param = { _selectedRssItem.Url, file };
            Thread t = new Thread(DownloadFile);
            t.Start(param);
        }

        private void lstItems_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;
            var index = lstItems.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                _selectedRssItem = (RssItem)lstItems.Items[index];
            }
        }

        private void toggleunreadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _selectedRssItem.Read = !_selectedRssItem.Read;
            _settings.Serialize();
        }
        private void refreshFeedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddInfo("Refreshing "+ _selectedRssFeed.FeedUrl);
                _selectedRssFeed.Load();
                lstRssFeeds_SelectedIndexChanged(this, null);
            AddInfo("Feed refreshed");
            _settings.Serialize();
        }

        private void lstRssFeeds_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;
            var index = lstRssFeeds.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                _selectedRssFeed = (RssFeed)lstRssFeeds.Items[index];
            }
        }
        #endregion
        private void DownloadAudioFiles()
        {
            try
            {
                foreach (RssFeed feed in _settings.RssFeeds)
                {
                    string dir = feed.GetDirname(_settings.SaveFolder);
                    if (!Directory.Exists(dir))
                        Directory.CreateDirectory(dir);

                    foreach (RssItem item in feed.ItemList)
                    {
                        string file = Path.Combine(dir, item.GetFilename());
                        DownloadFile(item.Url, file);
                        //https://rtsww-a-d.rts.ch/la-1ere/programmes/histoire-vivante/2020/histoire-vivante_20200619_full_histoire-vivante_d19935d5-eed1-4379-b950-bdab253e3e6a-128k.mp3?mediaId=11376653
                        //http://rf.proxycast.org/8fc6968a-5f2a-4b25-a279-a87c11e99145/10267-19.04.2020-ITEMA_22326995-0.mp3
                    }
                    AddInfo("Downloads done");
                }
            }
            catch (ThreadAbortException)
            {
                AddInfo("DL stopped");
                //throw;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        public void DownloadFile(object obj)
        {
            string[] param = (string[])obj;
            DownloadFile(param[0], param[1]);
        }
        public void DownloadFile(string url, string file)
        {
            string dir = Path.GetDirectoryName(file);
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);
            
            if (!File.Exists(file))
            {
                AddInfo("Downloading " + file);
                WebClient wc = new WebClient();
                if (!Directory.Exists(dir))
                    Directory.CreateDirectory(dir);
                wc.DownloadFile(url,  file);
            }
            else
            {
                AddInfo("Files  already exists");
            }
        }

        private void AddInfo(string msg)
        {
            this.InvokeOnUiThreadIfRequired(() => lstInfo.Items.Add(msg));
            this.InvokeOnUiThreadIfRequired(() => lstInfo.SelectedIndex = lstInfo.Items.Count - 1);

        }
        private void splitFeeds_SplitterMoved(object sender, SplitterEventArgs e)
        {
            if (!_enableSaveSplitterDistance)
                return;

            _settings.FormSettings.SplitFeedsDistance = splitFeeds.SplitterDistance;
            _settings.FormSettings.SplitInfosDistance= splitInfos.SplitterDistance;
            _settings.FormSettings.SplitMainDistance= splitMain.SplitterDistance;
            _settings.Serialize();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var f2 = new Form2();
            f2.Show();
        }

        private void btnClearItems_Click(object sender, EventArgs e)
        {
            foreach (RssFeed item in _settings.RssFeeds)
            {
                item.ItemList.Clear();
            }
            _settings.Serialize();
        }

        private void selectFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dlg = new FolderBrowserDialog();
            dlg.SelectedPath = _settings.SaveFolder;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                _settings.SaveFolder = dlg.SelectedPath;
                _settings.Serialize();
            }
        }

        private void openDLFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo("explorer");
            startInfo.Arguments = _settings.SaveFolder;
            Process.Start(startInfo);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    public static class ControlExtensions
    {
        /// <summary>
        /// Executes the Action asynchronously on the UI thread, does not block execution on the calling thread.
        /// </summary>
        /// <param name="control">the control for which the update is required</param>
        /// <param name="action">action to be performed on the control</param>
        public static void InvokeOnUiThreadIfRequired(this Control control, Action action)
        {
            if (control.InvokeRequired)
            {
                control.BeginInvoke(action);
            }
            else
            {
                action.Invoke();
            }
        }
    }
}
