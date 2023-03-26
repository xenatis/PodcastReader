namespace PodcastReader
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lstRssFeeds = new System.Windows.Forms.ListBox();
            this.cmsFeeds = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refreshFeedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddRssFeed = new System.Windows.Forms.Button();
            this.btnRemoveRssFeed = new System.Windows.Forms.Button();
            this.lstItems = new System.Windows.Forms.ListBox();
            this.cmsItems = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.downloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toggleunreadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtFeedInfos = new System.Windows.Forms.TextBox();
            this.txtItemInfos = new System.Windows.Forms.TextBox();
            this.btnRefreshAllFeeds = new System.Windows.Forms.Button();
            this.btnDownloadAudioFiles = new System.Windows.Forms.Button();
            this.lstInfo = new System.Windows.Forms.ListBox();
            this.splitFeeds = new System.Windows.Forms.SplitContainer();
            this.splitInfos = new System.Windows.Forms.SplitContainer();
            this.splitMain = new System.Windows.Forms.SplitContainer();
            this.btnClearItems = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.downloadsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openDLFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsFeeds.SuspendLayout();
            this.cmsItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitFeeds)).BeginInit();
            this.splitFeeds.Panel1.SuspendLayout();
            this.splitFeeds.Panel2.SuspendLayout();
            this.splitFeeds.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitInfos)).BeginInit();
            this.splitInfos.Panel1.SuspendLayout();
            this.splitInfos.Panel2.SuspendLayout();
            this.splitInfos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
            this.splitMain.Panel1.SuspendLayout();
            this.splitMain.Panel2.SuspendLayout();
            this.splitMain.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstRssFeeds
            // 
            this.lstRssFeeds.ContextMenuStrip = this.cmsFeeds;
            this.lstRssFeeds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstRssFeeds.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F);
            this.lstRssFeeds.FormattingEnabled = true;
            this.lstRssFeeds.ItemHeight = 16;
            this.lstRssFeeds.Location = new System.Drawing.Point(0, 0);
            this.lstRssFeeds.Margin = new System.Windows.Forms.Padding(2);
            this.lstRssFeeds.Name = "lstRssFeeds";
            this.lstRssFeeds.Size = new System.Drawing.Size(170, 286);
            this.lstRssFeeds.TabIndex = 0;
            this.lstRssFeeds.SelectedIndexChanged += new System.EventHandler(this.lstRssFeeds_SelectedIndexChanged);
            this.lstRssFeeds.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstRssFeeds_MouseDown);
            // 
            // cmsFeeds
            // 
            this.cmsFeeds.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.cmsFeeds.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshFeedToolStripMenuItem});
            this.cmsFeeds.Name = "cmsItems";
            this.cmsFeeds.Size = new System.Drawing.Size(140, 26);
            // 
            // refreshFeedToolStripMenuItem
            // 
            this.refreshFeedToolStripMenuItem.Name = "refreshFeedToolStripMenuItem";
            this.refreshFeedToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.refreshFeedToolStripMenuItem.Text = "Refresh feed";
            this.refreshFeedToolStripMenuItem.Click += new System.EventHandler(this.refreshFeedToolStripMenuItem_Click);
            // 
            // btnAddRssFeed
            // 
            this.btnAddRssFeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddRssFeed.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F);
            this.btnAddRssFeed.Location = new System.Drawing.Point(17, 325);
            this.btnAddRssFeed.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddRssFeed.Name = "btnAddRssFeed";
            this.btnAddRssFeed.Size = new System.Drawing.Size(82, 23);
            this.btnAddRssFeed.TabIndex = 1;
            this.btnAddRssFeed.Text = "Add";
            this.btnAddRssFeed.UseVisualStyleBackColor = true;
            this.btnAddRssFeed.Click += new System.EventHandler(this.btnAddRssFeed_Click);
            // 
            // btnRemoveRssFeed
            // 
            this.btnRemoveRssFeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemoveRssFeed.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F);
            this.btnRemoveRssFeed.Location = new System.Drawing.Point(17, 352);
            this.btnRemoveRssFeed.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveRssFeed.Name = "btnRemoveRssFeed";
            this.btnRemoveRssFeed.Size = new System.Drawing.Size(82, 23);
            this.btnRemoveRssFeed.TabIndex = 2;
            this.btnRemoveRssFeed.Text = "Remove";
            this.btnRemoveRssFeed.UseVisualStyleBackColor = true;
            this.btnRemoveRssFeed.Click += new System.EventHandler(this.btnRemoveRssFeed_Click);
            // 
            // lstItems
            // 
            this.lstItems.ContextMenuStrip = this.cmsItems;
            this.lstItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstItems.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F);
            this.lstItems.FormattingEnabled = true;
            this.lstItems.ItemHeight = 16;
            this.lstItems.Location = new System.Drawing.Point(0, 0);
            this.lstItems.Margin = new System.Windows.Forms.Padding(2);
            this.lstItems.Name = "lstItems";
            this.lstItems.Size = new System.Drawing.Size(312, 286);
            this.lstItems.TabIndex = 3;
            this.lstItems.SelectedIndexChanged += new System.EventHandler(this.lstItems_SelectedIndexChanged);
            this.lstItems.DoubleClick += new System.EventHandler(this.lstItems_DoubleClick);
            this.lstItems.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstItems_MouseDown);
            // 
            // cmsItems
            // 
            this.cmsItems.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.cmsItems.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.downloadToolStripMenuItem,
            this.toggleunreadToolStripMenuItem});
            this.cmsItems.Name = "cmsItems";
            this.cmsItems.Size = new System.Drawing.Size(158, 48);
            // 
            // downloadToolStripMenuItem
            // 
            this.downloadToolStripMenuItem.Name = "downloadToolStripMenuItem";
            this.downloadToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.downloadToolStripMenuItem.Text = "Download";
            this.downloadToolStripMenuItem.Click += new System.EventHandler(this.downloadToolStripMenuItem_Click);
            // 
            // toggleunreadToolStripMenuItem
            // 
            this.toggleunreadToolStripMenuItem.Name = "toggleunreadToolStripMenuItem";
            this.toggleunreadToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.toggleunreadToolStripMenuItem.Text = "Toggle (un)read";
            this.toggleunreadToolStripMenuItem.Click += new System.EventHandler(this.toggleunreadToolStripMenuItem_Click);
            // 
            // txtFeedInfos
            // 
            this.txtFeedInfos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFeedInfos.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F);
            this.txtFeedInfos.Location = new System.Drawing.Point(0, 0);
            this.txtFeedInfos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtFeedInfos.Multiline = true;
            this.txtFeedInfos.Name = "txtFeedInfos";
            this.txtFeedInfos.ReadOnly = true;
            this.txtFeedInfos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtFeedInfos.Size = new System.Drawing.Size(609, 144);
            this.txtFeedInfos.TabIndex = 4;
            // 
            // txtItemInfos
            // 
            this.txtItemInfos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtItemInfos.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F);
            this.txtItemInfos.Location = new System.Drawing.Point(0, 0);
            this.txtItemInfos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtItemInfos.Multiline = true;
            this.txtItemInfos.Name = "txtItemInfos";
            this.txtItemInfos.ReadOnly = true;
            this.txtItemInfos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtItemInfos.Size = new System.Drawing.Size(609, 138);
            this.txtItemInfos.TabIndex = 5;
            // 
            // btnRefreshAllFeeds
            // 
            this.btnRefreshAllFeeds.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRefreshAllFeeds.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F);
            this.btnRefreshAllFeeds.Location = new System.Drawing.Point(121, 325);
            this.btnRefreshAllFeeds.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefreshAllFeeds.Name = "btnRefreshAllFeeds";
            this.btnRefreshAllFeeds.Size = new System.Drawing.Size(82, 23);
            this.btnRefreshAllFeeds.TabIndex = 6;
            this.btnRefreshAllFeeds.Text = "Refresh all";
            this.btnRefreshAllFeeds.UseVisualStyleBackColor = true;
            this.btnRefreshAllFeeds.Click += new System.EventHandler(this.btnRefreshFeeds_Click);
            // 
            // btnDownloadAudioFiles
            // 
            this.btnDownloadAudioFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDownloadAudioFiles.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F);
            this.btnDownloadAudioFiles.Location = new System.Drawing.Point(121, 352);
            this.btnDownloadAudioFiles.Margin = new System.Windows.Forms.Padding(2);
            this.btnDownloadAudioFiles.Name = "btnDownloadAudioFiles";
            this.btnDownloadAudioFiles.Size = new System.Drawing.Size(82, 23);
            this.btnDownloadAudioFiles.TabIndex = 7;
            this.btnDownloadAudioFiles.Text = "Download";
            this.btnDownloadAudioFiles.UseVisualStyleBackColor = true;
            this.btnDownloadAudioFiles.Click += new System.EventHandler(this.btnDownloadAudioFiles_Click);
            // 
            // lstInfo
            // 
            this.lstInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstInfo.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F);
            this.lstInfo.FormattingEnabled = true;
            this.lstInfo.ItemHeight = 16;
            this.lstInfo.Location = new System.Drawing.Point(223, 318);
            this.lstInfo.Margin = new System.Windows.Forms.Padding(2);
            this.lstInfo.Name = "lstInfo";
            this.lstInfo.Size = new System.Drawing.Size(880, 84);
            this.lstInfo.TabIndex = 8;
            // 
            // splitFeeds
            // 
            this.splitFeeds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitFeeds.Location = new System.Drawing.Point(0, 0);
            this.splitFeeds.Name = "splitFeeds";
            // 
            // splitFeeds.Panel1
            // 
            this.splitFeeds.Panel1.Controls.Add(this.lstRssFeeds);
            // 
            // splitFeeds.Panel2
            // 
            this.splitFeeds.Panel2.Controls.Add(this.lstItems);
            this.splitFeeds.Size = new System.Drawing.Size(486, 286);
            this.splitFeeds.SplitterDistance = 170;
            this.splitFeeds.TabIndex = 9;
            this.splitFeeds.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitFeeds_SplitterMoved);
            // 
            // splitInfos
            // 
            this.splitInfos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitInfos.Location = new System.Drawing.Point(0, 0);
            this.splitInfos.Name = "splitInfos";
            this.splitInfos.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitInfos.Panel1
            // 
            this.splitInfos.Panel1.Controls.Add(this.txtFeedInfos);
            // 
            // splitInfos.Panel2
            // 
            this.splitInfos.Panel2.Controls.Add(this.txtItemInfos);
            this.splitInfos.Size = new System.Drawing.Size(609, 286);
            this.splitInfos.SplitterDistance = 144;
            this.splitInfos.TabIndex = 10;
            this.splitInfos.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitFeeds_SplitterMoved);
            // 
            // splitMain
            // 
            this.splitMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitMain.Location = new System.Drawing.Point(3, 27);
            this.splitMain.Name = "splitMain";
            // 
            // splitMain.Panel1
            // 
            this.splitMain.Panel1.Controls.Add(this.splitFeeds);
            // 
            // splitMain.Panel2
            // 
            this.splitMain.Panel2.Controls.Add(this.splitInfos);
            this.splitMain.Size = new System.Drawing.Size(1099, 286);
            this.splitMain.SplitterDistance = 486;
            this.splitMain.TabIndex = 11;
            this.splitMain.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitFeeds_SplitterMoved);
            // 
            // btnClearItems
            // 
            this.btnClearItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClearItems.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F);
            this.btnClearItems.Location = new System.Drawing.Point(121, 379);
            this.btnClearItems.Margin = new System.Windows.Forms.Padding(2);
            this.btnClearItems.Name = "btnClearItems";
            this.btnClearItems.Size = new System.Drawing.Size(82, 23);
            this.btnClearItems.TabIndex = 12;
            this.btnClearItems.Text = "Clear items";
            this.btnClearItems.UseVisualStyleBackColor = true;
            this.btnClearItems.Click += new System.EventHandler(this.btnClearItems_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.downloadsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1114, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // downloadsToolStripMenuItem
            // 
            this.downloadsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openDLFolderToolStripMenuItem,
            this.selectFolderToolStripMenuItem,
            this.FolderToolStripMenuItem});
            this.downloadsToolStripMenuItem.Name = "downloadsToolStripMenuItem";
            this.downloadsToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.downloadsToolStripMenuItem.Text = "&Downloads";
            // 
            // openDLFolderToolStripMenuItem
            // 
            this.openDLFolderToolStripMenuItem.Name = "openDLFolderToolStripMenuItem";
            this.openDLFolderToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.openDLFolderToolStripMenuItem.Text = "&Open folder";
            this.openDLFolderToolStripMenuItem.Click += new System.EventHandler(this.openDLFolderToolStripMenuItem_Click);
            // 
            // selectFolderToolStripMenuItem
            // 
            this.selectFolderToolStripMenuItem.Name = "selectFolderToolStripMenuItem";
            this.selectFolderToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.selectFolderToolStripMenuItem.Text = "&Select folder";
            this.selectFolderToolStripMenuItem.Click += new System.EventHandler(this.selectFolderToolStripMenuItem_Click);
            // 
            // FolderToolStripMenuItem
            // 
            this.FolderToolStripMenuItem.Name = "FolderToolStripMenuItem";
            this.FolderToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.FolderToolStripMenuItem.Text = "_F";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 407);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnClearItems);
            this.Controls.Add(this.splitMain);
            this.Controls.Add(this.lstInfo);
            this.Controls.Add(this.btnDownloadAudioFiles);
            this.Controls.Add(this.btnRefreshAllFeeds);
            this.Controls.Add(this.btnRemoveRssFeed);
            this.Controls.Add(this.btnAddRssFeed);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Podcast reader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.cmsFeeds.ResumeLayout(false);
            this.cmsItems.ResumeLayout(false);
            this.splitFeeds.Panel1.ResumeLayout(false);
            this.splitFeeds.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitFeeds)).EndInit();
            this.splitFeeds.ResumeLayout(false);
            this.splitInfos.Panel1.ResumeLayout(false);
            this.splitInfos.Panel1.PerformLayout();
            this.splitInfos.Panel2.ResumeLayout(false);
            this.splitInfos.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitInfos)).EndInit();
            this.splitInfos.ResumeLayout(false);
            this.splitMain.Panel1.ResumeLayout(false);
            this.splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
            this.splitMain.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstRssFeeds;
        private System.Windows.Forms.Button btnAddRssFeed;
        private System.Windows.Forms.Button btnRemoveRssFeed;
        private System.Windows.Forms.ListBox lstItems;
        private System.Windows.Forms.TextBox txtFeedInfos;
        private System.Windows.Forms.TextBox txtItemInfos;
        private System.Windows.Forms.Button btnRefreshAllFeeds;
        private System.Windows.Forms.Button btnDownloadAudioFiles;
        private System.Windows.Forms.ListBox lstInfo;
        private System.Windows.Forms.SplitContainer splitFeeds;
        private System.Windows.Forms.SplitContainer splitInfos;
        private System.Windows.Forms.ContextMenuStrip cmsItems;
        private System.Windows.Forms.ToolStripMenuItem downloadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toggleunreadToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitMain;
        private System.Windows.Forms.ContextMenuStrip cmsFeeds;
        private System.Windows.Forms.ToolStripMenuItem refreshFeedToolStripMenuItem;
        private System.Windows.Forms.Button btnClearItems;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem downloadsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openDLFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FolderToolStripMenuItem;
    }
}

