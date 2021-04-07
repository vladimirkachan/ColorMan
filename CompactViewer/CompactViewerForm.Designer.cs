namespace ColorMan.CompactViewer
{
    partial class CompactViewerForm
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
            if (fileCursor != null) fileCursor.Dispose();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompactViewerForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dirListBox1 = new Microsoft.VisualBasic.Compatibility.VB6.DirListBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.fileListBox1 = new Microsoft.VisualBasic.Compatibility.VB6.FileListBox();
            this.cms_Files = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copy1 = new System.Windows.Forms.ToolStripMenuItem();
            this.paste1 = new System.Windows.Forms.ToolStripMenuItem();
            this.delete1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.explorerF1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureControl1 = new ColorMan.ControlsLibrary.PictureControl();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbSM = new System.Windows.Forms.Label();
            this.driveListBox1 = new Microsoft.VisualBasic.Compatibility.VB6.DriveListBox();
            this.cms_Viewer = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.workingDirectory1 = new System.Windows.Forms.ToolStripMenuItem();
            this.colorMan2 = new System.Windows.Forms.ToolStripMenuItem();
            this.colorPicker2 = new System.Windows.Forms.ToolStripMenuItem();
            this.multipleViewer2 = new System.Windows.Forms.ToolStripMenuItem();
            this.snipping2 = new System.Windows.Forms.ToolStripMenuItem();
            this.explorer2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.about2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.exit1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.colorMan1 = new System.Windows.Forms.ToolStripButton();
            this.colorPicker1 = new System.Windows.Forms.ToolStripButton();
            this.multipleViewer1 = new System.Windows.Forms.ToolStripButton();
            this.snipping1 = new System.Windows.Forms.ToolStripButton();
            this.explorer1 = new System.Windows.Forms.ToolStripButton();
            this.about1 = new System.Windows.Forms.ToolStripButton();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.fswOpen = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.cms_Files.SuspendLayout();
            this.panel1.SuspendLayout();
            this.cms_Viewer.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fswOpen)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dirListBox1);
            this.splitContainer1.Panel1MinSize = 75;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(934, 406);
            this.splitContainer1.SplitterDistance = 175;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.TabStop = false;
            // 
            // dirListBox1
            // 
            this.dirListBox1.BackColor = System.Drawing.Color.LightGray;
            this.dirListBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dirListBox1.FormattingEnabled = true;
            this.dirListBox1.IntegralHeight = false;
            this.dirListBox1.Location = new System.Drawing.Point(0, 0);
            this.dirListBox1.Name = "dirListBox1";
            this.dirListBox1.Size = new System.Drawing.Size(175, 406);
            this.dirListBox1.TabIndex = 0;
            this.dirListBox1.Change += new System.EventHandler(this.dirListBox1_Change);
            this.dirListBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dirListBox1_KeyPress);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.fileListBox1);
            this.splitContainer2.Panel1MinSize = 50;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.AutoScroll = true;
            this.splitContainer2.Panel2.Controls.Add(this.pictureControl1);
            this.splitContainer2.Panel2MinSize = 18;
            this.splitContainer2.Size = new System.Drawing.Size(755, 406);
            this.splitContainer2.SplitterDistance = 125;
            this.splitContainer2.TabIndex = 1;
            this.splitContainer2.TabStop = false;
            // 
            // fileListBox1
            // 
            this.fileListBox1.AllowDrop = true;
            this.fileListBox1.BackColor = System.Drawing.Color.LightGray;
            this.fileListBox1.ContextMenuStrip = this.cms_Files;
            this.fileListBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileListBox1.FormattingEnabled = true;
            this.fileListBox1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.fileListBox1.IntegralHeight = false;
            this.fileListBox1.Location = new System.Drawing.Point(0, 0);
            this.fileListBox1.Name = "fileListBox1";
            this.fileListBox1.Pattern = "*.bmp;*.jpg;*.jpeg;*.png;*.gif;*.ico;*.wmf;*.emf";
            this.fileListBox1.Size = new System.Drawing.Size(125, 406);
            this.fileListBox1.TabIndex = 1;
            this.fileListBox1.SelectedIndexChanged += new System.EventHandler(this.fileListBox1_SelectedIndexChanged);
            this.fileListBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.control_DragDrop);
            this.fileListBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.control_DragEnter);
            this.fileListBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.fileListBox1_MouseMove);
            this.fileListBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.fileListBox1_MouseUp);
            // 
            // cms_Files
            // 
            this.cms_Files.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copy1,
            this.paste1,
            this.delete1,
            this.toolStripMenuItem3,
            this.explorerF1});
            this.cms_Files.Name = "cms_Files";
            this.cms_Files.Size = new System.Drawing.Size(203, 98);
            this.cms_Files.Opening += new System.ComponentModel.CancelEventHandler(this.cms_Files_Opening);
            // 
            // copy1
            // 
            this.copy1.Image = global::ColorMan.CompactViewer.Properties.Resources.copy;
            this.copy1.Name = "copy1";
            this.copy1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copy1.Size = new System.Drawing.Size(202, 22);
            this.copy1.Text = "&Copy";
            this.copy1.Click += new System.EventHandler(this.copy1_Click);
            // 
            // paste1
            // 
            this.paste1.Image = global::ColorMan.CompactViewer.Properties.Resources.paste;
            this.paste1.Name = "paste1";
            this.paste1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.paste1.Size = new System.Drawing.Size(202, 22);
            this.paste1.Text = "&Paste";
            this.paste1.Click += new System.EventHandler(this.paste1_Click);
            // 
            // delete1
            // 
            this.delete1.Image = global::ColorMan.CompactViewer.Properties.Resources.delete;
            this.delete1.Name = "delete1";
            this.delete1.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.delete1.Size = new System.Drawing.Size(202, 22);
            this.delete1.Text = "&Delete";
            this.delete1.Click += new System.EventHandler(this.delete1_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(199, 6);
            // 
            // explorerF1
            // 
            this.explorerF1.Image = global::ColorMan.CompactViewer.Properties.Resources.explorer16;
            this.explorerF1.Name = "explorerF1";
            this.explorerF1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.explorerF1.Size = new System.Drawing.Size(202, 22);
            this.explorerF1.Text = "Open at &Explorer";
            this.explorerF1.Click += new System.EventHandler(this.explorer_Click);
            // 
            // pictureControl1
            // 
            this.pictureControl1.AutoScroll = true;
            this.pictureControl1.BackColor = System.Drawing.Color.White;
            this.pictureControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureControl1.Location = new System.Drawing.Point(0, 0);
            this.pictureControl1.Name = "pictureControl1";
            this.pictureControl1.Picture = null;
            this.pictureControl1.Size = new System.Drawing.Size(626, 406);
            this.pictureControl1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureControl1.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.LightGray;
            this.textBox1.Location = new System.Drawing.Point(199, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(706, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // btnGo
            // 
            this.btnGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGo.BackgroundImage = global::ColorMan.CompactViewer.Properties.Resources.gotoL;
            this.btnGo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGo.FlatAppearance.BorderSize = 0;
            this.btnGo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btnGo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGo.Location = new System.Drawing.Point(910, 6);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(18, 18);
            this.btnGo.TabIndex = 6;
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.Location = new System.Drawing.Point(70, 7);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(78, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "&Size mode:";
            this.checkBox1.ThreeState = true;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckStateChanged += new System.EventHandler(this.checkBox1_CheckStateChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.lbSM);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.btnGo);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.driveListBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 431);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(934, 30);
            this.panel1.TabIndex = 3;
            // 
            // lbSM
            // 
            this.lbSM.Location = new System.Drawing.Point(70, 7);
            this.lbSM.Name = "lbSM";
            this.lbSM.Size = new System.Drawing.Size(16, 16);
            this.lbSM.TabIndex = 1;
            // 
            // driveListBox1
            // 
            this.driveListBox1.BackColor = System.Drawing.Color.LightGray;
            this.driveListBox1.FormattingEnabled = true;
            this.driveListBox1.Location = new System.Drawing.Point(4, 4);
            this.driveListBox1.Name = "driveListBox1";
            this.driveListBox1.Size = new System.Drawing.Size(60, 21);
            this.driveListBox1.TabIndex = 3;
            this.driveListBox1.SelectedIndexChanged += new System.EventHandler(this.driveListBox1_SelectedIndexChanged);
            // 
            // cms_Viewer
            // 
            this.cms_Viewer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.workingDirectory1,
            this.colorMan2,
            this.colorPicker2,
            this.multipleViewer2,
            this.snipping2,
            this.explorer2,
            this.toolStripSeparator1,
            this.about2,
            this.toolStripMenuItem2,
            this.exit1});
            this.cms_Viewer.Name = "cms_Viewer";
            this.cms_Viewer.Size = new System.Drawing.Size(265, 192);
            // 
            // workingDirectory1
            // 
            this.workingDirectory1.Name = "workingDirectory1";
            this.workingDirectory1.Size = new System.Drawing.Size(264, 22);
            this.workingDirectory1.Text = "Set working &folder";
            this.workingDirectory1.Click += new System.EventHandler(this.workingDirectory1_Click);
            // 
            // colorMan2
            // 
            this.colorMan2.Image = global::ColorMan.CompactViewer.Properties.Resources.colorMan16;
            this.colorMan2.Name = "colorMan2";
            this.colorMan2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.O)));
            this.colorMan2.Size = new System.Drawing.Size(264, 22);
            this.colorMan2.Text = "C&olorMan";
            this.colorMan2.Click += new System.EventHandler(this.colorMan_Click);
            // 
            // colorPicker2
            // 
            this.colorPicker2.Image = global::ColorMan.CompactViewer.Properties.Resources.colorPicker16;
            this.colorPicker2.Name = "colorPicker2";
            this.colorPicker2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.colorPicker2.Size = new System.Drawing.Size(264, 22);
            this.colorPicker2.Text = "&ColorPicker";
            this.colorPicker2.Click += new System.EventHandler(this.colorPicker_Click);
            // 
            // multipleViewer2
            // 
            this.multipleViewer2.Image = global::ColorMan.CompactViewer.Properties.Resources.multipleViewer16;
            this.multipleViewer2.Name = "multipleViewer2";
            this.multipleViewer2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.M)));
            this.multipleViewer2.Size = new System.Drawing.Size(264, 22);
            this.multipleViewer2.Text = "&Multiple-Image Viewer";
            this.multipleViewer2.Click += new System.EventHandler(this.multipleViewer_Click);
            // 
            // snipping2
            // 
            this.snipping2.Image = global::ColorMan.CompactViewer.Properties.Resources.snipping16;
            this.snipping2.Name = "snipping2";
            this.snipping2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.snipping2.Size = new System.Drawing.Size(264, 22);
            this.snipping2.Text = "&Snipping";
            this.snipping2.Click += new System.EventHandler(this.snipping_Click);
            // 
            // explorer2
            // 
            this.explorer2.Image = global::ColorMan.CompactViewer.Properties.Resources.explorer16;
            this.explorer2.Name = "explorer2";
            this.explorer2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.explorer2.Size = new System.Drawing.Size(264, 22);
            this.explorer2.Text = "&Explorer";
            this.explorer2.Click += new System.EventHandler(this.explorer_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(261, 6);
            // 
            // about2
            // 
            this.about2.Image = global::ColorMan.CompactViewer.Properties.Resources.info16;
            this.about2.Name = "about2";
            this.about2.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.about2.Size = new System.Drawing.Size(264, 22);
            this.about2.Text = "&About Compact Image Viewer ...";
            this.about2.Click += new System.EventHandler(this.about_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(261, 6);
            // 
            // exit1
            // 
            this.exit1.Image = global::ColorMan.CompactViewer.Properties.Resources.close;
            this.exit1.ImageTransparentColor = System.Drawing.Color.Black;
            this.exit1.Name = "exit1";
            this.exit1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exit1.Size = new System.Drawing.Size(264, 22);
            this.exit1.Text = "E&xit";
            this.exit1.Click += new System.EventHandler(this.exit11_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorMan1,
            this.colorPicker1,
            this.multipleViewer1,
            this.snipping1,
            this.explorer1,
            this.about1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(934, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // colorMan1
            // 
            this.colorMan1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.colorMan1.Image = global::ColorMan.CompactViewer.Properties.Resources.colorMan16;
            this.colorMan1.Name = "colorMan1";
            this.colorMan1.Size = new System.Drawing.Size(23, 22);
            this.colorMan1.Text = "ColorMan";
            this.colorMan1.Click += new System.EventHandler(this.colorMan_Click);
            // 
            // colorPicker1
            // 
            this.colorPicker1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.colorPicker1.Image = global::ColorMan.CompactViewer.Properties.Resources.colorPicker16;
            this.colorPicker1.Name = "colorPicker1";
            this.colorPicker1.Size = new System.Drawing.Size(23, 22);
            this.colorPicker1.Text = "ColorPicker";
            this.colorPicker1.Click += new System.EventHandler(this.colorPicker_Click);
            // 
            // multipleViewer1
            // 
            this.multipleViewer1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.multipleViewer1.Image = global::ColorMan.CompactViewer.Properties.Resources.multipleViewer16;
            this.multipleViewer1.Name = "multipleViewer1";
            this.multipleViewer1.Size = new System.Drawing.Size(23, 22);
            this.multipleViewer1.Text = "Multiple-Image Viewer";
            this.multipleViewer1.Click += new System.EventHandler(this.multipleViewer_Click);
            // 
            // snipping1
            // 
            this.snipping1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.snipping1.Image = global::ColorMan.CompactViewer.Properties.Resources.snipping16;
            this.snipping1.Name = "snipping1";
            this.snipping1.Size = new System.Drawing.Size(23, 22);
            this.snipping1.Text = "Snipping";
            this.snipping1.Click += new System.EventHandler(this.snipping_Click);
            // 
            // explorer1
            // 
            this.explorer1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.explorer1.Image = global::ColorMan.CompactViewer.Properties.Resources.explorer16;
            this.explorer1.Name = "explorer1";
            this.explorer1.Size = new System.Drawing.Size(23, 22);
            this.explorer1.Text = "Explorer";
            this.explorer1.Click += new System.EventHandler(this.explorer_Click);
            // 
            // about1
            // 
            this.about1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.about1.Image = global::ColorMan.CompactViewer.Properties.Resources.info16;
            this.about1.Name = "about1";
            this.about1.Size = new System.Drawing.Size(23, 22);
            this.about1.Text = "About Compact Image Viewer ...";
            this.about1.Click += new System.EventHandler(this.about_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.NotifyFilter = ((System.IO.NotifyFilters)((System.IO.NotifyFilters.FileName | System.IO.NotifyFilters.DirectoryName)));
            this.fileSystemWatcher1.SynchronizingObject = this;
            this.fileSystemWatcher1.Created += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Events);
            this.fileSystemWatcher1.Deleted += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Events);
            this.fileSystemWatcher1.Renamed += new System.IO.RenamedEventHandler(this.fileSystemWatcher1_Renamed);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.ShowNewFolderButton = false;
            // 
            // fswOpen
            // 
            this.fswOpen.EnableRaisingEvents = true;
            this.fswOpen.SynchronizingObject = this;
            this.fswOpen.Changed += new System.IO.FileSystemEventHandler(this.fswOpen_Changed);
            // 
            // CompactViewerForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(934, 461);
            this.ContextMenuStrip = this.cms_Viewer;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "CompactViewerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compact Image Viewer";
            this.Click += new System.EventHandler(this.colorMan_Click);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.control_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.control_DragEnter);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.cms_Files.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.cms_Viewer.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fswOpen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private Microsoft.VisualBasic.Compatibility.VB6.DirListBox dirListBox1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private Microsoft.VisualBasic.Compatibility.VB6.FileListBox fileListBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel panel1;
        private Microsoft.VisualBasic.Compatibility.VB6.DriveListBox driveListBox1;
        private ColorMan.ControlsLibrary.PictureControl pictureControl1;
        private System.Windows.Forms.ContextMenuStrip cms_Viewer;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton colorMan1;
        private System.Windows.Forms.ToolStripButton colorPicker1;
        private System.Windows.Forms.ToolStripButton multipleViewer1;
        private System.Windows.Forms.ToolStripMenuItem colorMan2;
        private System.Windows.Forms.ToolStripMenuItem colorPicker2;
        private System.Windows.Forms.ToolStripMenuItem multipleViewer2;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exit1;
        private System.Windows.Forms.ToolStripButton explorer1;
        private System.Windows.Forms.Label lbSM;
        private System.Windows.Forms.ContextMenuStrip cms_Files;
        private System.Windows.Forms.ToolStripMenuItem copy1;
        private System.Windows.Forms.ToolStripMenuItem paste1;
        private System.Windows.Forms.ToolStripMenuItem delete1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem explorerF1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.ToolStripMenuItem workingDirectory1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ToolStripButton about1;
        private System.Windows.Forms.ToolStripMenuItem about2;
        private System.IO.FileSystemWatcher fswOpen;
        private System.Windows.Forms.ToolStripMenuItem explorer2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton snipping1;
        private System.Windows.Forms.ToolStripMenuItem snipping2;
    }
}