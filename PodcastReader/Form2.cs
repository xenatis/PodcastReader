using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PodcastReader
{
    public partial class Form2 : Form
    {
        Settings _settings = Settings.Deserialize();

        public Form2()
        {
            InitializeComponent();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            foreach (var item in _settings.RssFeeds)
            {
                ListViewItem i = new ListViewItem(item.Title);

                //i.SubItems.Add(item.title);
                i.SubItems.Add(item.FeedUrl);
                listView1.Items.Add(i);
            }
        }
    }
}
