namespace ColorMan.MultipleViewer
{
    partial class MultipleViewerForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MultipleViewerForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.file1 = new System.Windows.Forms.ToolStripMenuItem();
            this.open1 = new System.Windows.Forms.ToolStripMenuItem();
            this.about1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exit1 = new System.Windows.Forms.ToolStripMenuItem();
            this.window1 = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontal1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vertical1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cascade1 = new System.Windows.Forms.ToolStripMenuItem();
            this.arrange1 = new System.Windows.Forms.ToolStripMenuItem();
            this.applicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorMan1 = new System.Windows.Forms.ToolStripMenuItem();
            this.colorPicker1 = new System.Windows.Forms.ToolStripMenuItem();
            this.snipping1 = new System.Windows.Forms.ToolStripMenuItem();
            this.compact1 = new System.Windows.Forms.ToolStripMenuItem();
            this.explorer1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.open2 = new System.Windows.Forms.ToolStripButton();
            this.close2 = new System.Windows.Forms.ToolStripSplitButton();
            this.closeAll2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.zoom2 = new System.Windows.Forms.ToolStripSplitButton();
            this.zoomAll2 = new System.Windows.Forms.ToolStripMenuItem();
            this.stretch2 = new System.Windows.Forms.ToolStripSplitButton();
            this.stretchAll2 = new System.Windows.Forms.ToolStripMenuItem();
            this.autoSize2 = new System.Windows.Forms.ToolStripSplitButton();
            this.autoSizeAll2 = new System.Windows.Forms.ToolStripMenuItem();
            this.resize2 = new System.Windows.Forms.ToolStripSplitButton();
            this.resizeAll2 = new System.Windows.Forms.ToolStripMenuItem();
            this.realSize2 = new System.Windows.Forms.ToolStripSplitButton();
            this.realSizeAll2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.colorPicker2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.about2 = new System.Windows.Forms.ToolStripButton();
            this.fswOpen = new System.IO.FileSystemWatcher();
            this.cmsMultiple = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.open3 = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAll1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.colorMan2 = new System.Windows.Forms.ToolStripMenuItem();
            this.colorPicker3 = new System.Windows.Forms.ToolStripMenuItem();
            this.compact2 = new System.Windows.Forms.ToolStripMenuItem();
            this.snipping2 = new System.Windows.Forms.ToolStripMenuItem();
            this.explorer2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.about3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.exit2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fswOpen)).BeginInit();
            this.cmsMultiple.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file1,
            this.window1,
            this.applicationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.window1;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // file1
            // 
            this.file1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.open1,
            this.about1,
            this.toolStripMenuItem1,
            this.exit1});
            this.file1.Name = "file1";
            this.file1.Size = new System.Drawing.Size(37, 20);
            this.file1.Text = "&File";
            // 
            // open1
            // 
            this.open1.Name = "open1";
            this.open1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.open1.Size = new System.Drawing.Size(259, 22);
            this.open1.Text = "&Open";
            this.open1.Click += new System.EventHandler(this.OpenClick);
            // 
            // about1
            // 
            this.about1.Image = global::ColorMan.MultipleViewer.Properties.Resources.info16;
            this.about1.Name = "about1";
            this.about1.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.about1.Size = new System.Drawing.Size(259, 22);
            this.about1.Text = "&About Multiple Image Viewer ...";
            this.about1.Click += new System.EventHandler(this.about_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(256, 6);
            // 
            // exit1
            // 
            this.exit1.Name = "exit1";
            this.exit1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exit1.Size = new System.Drawing.Size(259, 22);
            this.exit1.Text = "E&xit";
            this.exit1.Click += new System.EventHandler(this.exit_Click);
            // 
            // window1
            // 
            this.window1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.horizontal1,
            this.vertical1,
            this.cascade1,
            this.arrange1});
            this.window1.Name = "window1";
            this.window1.Size = new System.Drawing.Size(63, 20);
            this.window1.Text = "&Window";
            this.window1.Visible = false;
            // 
            // horizontal1
            // 
            this.horizontal1.Name = "horizontal1";
            this.horizontal1.Size = new System.Drawing.Size(151, 22);
            this.horizontal1.Text = "&Horizontal Tile";
            this.horizontal1.Click += new System.EventHandler(this.windowItem_Click);
            // 
            // vertical1
            // 
            this.vertical1.Name = "vertical1";
            this.vertical1.Size = new System.Drawing.Size(151, 22);
            this.vertical1.Text = "&Vertical Tile";
            this.vertical1.Click += new System.EventHandler(this.windowItem_Click);
            // 
            // cascade1
            // 
            this.cascade1.Name = "cascade1";
            this.cascade1.Size = new System.Drawing.Size(151, 22);
            this.cascade1.Text = "&Cascade";
            this.cascade1.Click += new System.EventHandler(this.windowItem_Click);
            // 
            // arrange1
            // 
            this.arrange1.Name = "arrange1";
            this.arrange1.Size = new System.Drawing.Size(151, 22);
            this.arrange1.Text = "&Arrange Icons";
            this.arrange1.Click += new System.EventHandler(this.windowItem_Click);
            // 
            // applicationToolStripMenuItem
            // 
            this.applicationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorMan1,
            this.colorPicker1,
            this.snipping1,
            this.compact1,
            this.explorer1});
            this.applicationToolStripMenuItem.Name = "applicationToolStripMenuItem";
            this.applicationToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.applicationToolStripMenuItem.Text = "&Application";
            // 
            // colorMan1
            // 
            this.colorMan1.Image = global::ColorMan.MultipleViewer.Properties.Resources.colorMan16;
            this.colorMan1.Name = "colorMan1";
            this.colorMan1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.O)));
            this.colorMan1.Size = new System.Drawing.Size(230, 22);
            this.colorMan1.Text = "C&olorMan";
            this.colorMan1.Click += new System.EventHandler(this.colorMan_Click);
            // 
            // colorPicker1
            // 
            this.colorPicker1.Image = ((System.Drawing.Image)(resources.GetObject("colorPicker1.Image")));
            this.colorPicker1.Name = "colorPicker1";
            this.colorPicker1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.colorPicker1.Size = new System.Drawing.Size(230, 22);
            this.colorPicker1.Text = "&Color Screen Picker";
            this.colorPicker1.Click += new System.EventHandler(this.colorPicker_Click);
            // 
            // snipping1
            // 
            this.snipping1.Image = global::ColorMan.MultipleViewer.Properties.Resources.snipping16;
            this.snipping1.Name = "snipping1";
            this.snipping1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.snipping1.Size = new System.Drawing.Size(230, 22);
            this.snipping1.Text = "&Snipping";
            this.snipping1.Click += new System.EventHandler(this.snipping_Click);
            // 
            // compact1
            // 
            this.compact1.Image = global::ColorMan.MultipleViewer.Properties.Resources.compactViewer16;
            this.compact1.Name = "compact1";
            this.compact1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.I)));
            this.compact1.Size = new System.Drawing.Size(230, 22);
            this.compact1.Text = "Compact &Image Viewer";
            this.compact1.Click += new System.EventHandler(this.compactViewer_Click);
            // 
            // explorer1
            // 
            this.explorer1.Image = global::ColorMan.MultipleViewer.Properties.Resources.explorer16;
            this.explorer1.Name = "explorer1";
            this.explorer1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.explorer1.Size = new System.Drawing.Size(230, 22);
            this.explorer1.Text = "&Explorer";
            this.explorer1.Click += new System.EventHandler(this.explorer_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Image Files (*.bmp, *.jpg, *.jpeg, *.png, *.gif, *.ico, *.wmf, *.emf)|*.bmp;*.jpg" +
    ";*.jpeg;*.png;*.gif;*.ico;*.wmf;*.emf";
            this.openFileDialog1.Multiselect = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.open2,
            this.close2,
            this.toolStripSeparator1,
            this.zoom2,
            this.stretch2,
            this.autoSize2,
            this.resize2,
            this.realSize2,
            this.toolStripSeparator3,
            this.colorPicker2,
            this.toolStripSeparator2,
            this.about2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(984, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // open2
            // 
            this.open2.Image = global::ColorMan.MultipleViewer.Properties.Resources.open;
            this.open2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.open2.Name = "open2";
            this.open2.Size = new System.Drawing.Size(56, 22);
            this.open2.Text = "Open";
            this.open2.ToolTipText = "Ctrl+O";
            this.open2.Click += new System.EventHandler(this.OpenClick);
            // 
            // close2
            // 
            this.close2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeAll2});
            this.close2.Enabled = false;
            this.close2.Image = global::ColorMan.MultipleViewer.Properties.Resources.hide;
            this.close2.ImageTransparentColor = System.Drawing.Color.Black;
            this.close2.Name = "close2";
            this.close2.Size = new System.Drawing.Size(68, 22);
            this.close2.Text = "Close";
            this.close2.ToolTipText = "Ctrl+F4";
            this.close2.ButtonClick += new System.EventHandler(this.close2_ButtonClick);
            // 
            // closeAll2
            // 
            this.closeAll2.Enabled = false;
            this.closeAll2.Name = "closeAll2";
            this.closeAll2.Size = new System.Drawing.Size(120, 22);
            this.closeAll2.Text = "Close All";
            this.closeAll2.ToolTipText = "Ctrl+Shift+I";
            this.closeAll2.Click += new System.EventHandler(this.closeAll2_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // zoom2
            // 
            this.zoom2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomAll2});
            this.zoom2.Enabled = false;
            this.zoom2.Image = global::ColorMan.MultipleViewer.Properties.Resources.zoomMode;
            this.zoom2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.zoom2.Name = "zoom2";
            this.zoom2.Size = new System.Drawing.Size(71, 22);
            this.zoom2.Text = "Zoom";
            this.zoom2.ToolTipText = "Ctrl+Z";
            this.zoom2.ButtonClick += new System.EventHandler(this.sizeMode_ButtonClick);
            // 
            // zoomAll2
            // 
            this.zoomAll2.Enabled = false;
            this.zoomAll2.Name = "zoomAll2";
            this.zoomAll2.Size = new System.Drawing.Size(123, 22);
            this.zoomAll2.Text = "Zoom All";
            this.zoomAll2.ToolTipText = "Ctrl+Shift+Z";
            this.zoomAll2.Click += new System.EventHandler(this.sizeModeAll_Click);
            // 
            // stretch2
            // 
            this.stretch2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stretchAll2});
            this.stretch2.Enabled = false;
            this.stretch2.Image = global::ColorMan.MultipleViewer.Properties.Resources.stretchMode;
            this.stretch2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stretch2.Name = "stretch2";
            this.stretch2.Size = new System.Drawing.Size(76, 22);
            this.stretch2.Text = "Stretch";
            this.stretch2.ToolTipText = "Ctrl+Z";
            this.stretch2.ButtonClick += new System.EventHandler(this.sizeMode_ButtonClick);
            // 
            // stretchAll2
            // 
            this.stretchAll2.Enabled = false;
            this.stretchAll2.Name = "stretchAll2";
            this.stretchAll2.Size = new System.Drawing.Size(128, 22);
            this.stretchAll2.Text = "Stretch All";
            this.stretchAll2.ToolTipText = "Ctrl+Shift+S";
            this.stretchAll2.Click += new System.EventHandler(this.sizeModeAll_Click);
            // 
            // autoSize2
            // 
            this.autoSize2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autoSizeAll2});
            this.autoSize2.Enabled = false;
            this.autoSize2.Image = global::ColorMan.MultipleViewer.Properties.Resources.autoSizeMode;
            this.autoSize2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.autoSize2.Name = "autoSize2";
            this.autoSize2.Size = new System.Drawing.Size(85, 22);
            this.autoSize2.Text = "AutoSize";
            this.autoSize2.ToolTipText = "Ctrl+A";
            this.autoSize2.ButtonClick += new System.EventHandler(this.sizeMode_ButtonClick);
            // 
            // autoSizeAll2
            // 
            this.autoSizeAll2.Enabled = false;
            this.autoSizeAll2.Name = "autoSizeAll2";
            this.autoSizeAll2.Size = new System.Drawing.Size(137, 22);
            this.autoSizeAll2.Text = "AutoSize All";
            this.autoSizeAll2.ToolTipText = "Ctrl+Shift+A";
            this.autoSizeAll2.Click += new System.EventHandler(this.sizeModeAll_Click);
            // 
            // resize2
            // 
            this.resize2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resizeAll2});
            this.resize2.Enabled = false;
            this.resize2.Image = global::ColorMan.MultipleViewer.Properties.Resources.resize;
            this.resize2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.resize2.Name = "resize2";
            this.resize2.Size = new System.Drawing.Size(71, 22);
            this.resize2.Text = "Resize";
            this.resize2.ToolTipText = "Ctrl+R";
            this.resize2.ButtonClick += new System.EventHandler(this.resize2_ButtonClick);
            // 
            // resizeAll2
            // 
            this.resizeAll2.Enabled = false;
            this.resizeAll2.Name = "resizeAll2";
            this.resizeAll2.Size = new System.Drawing.Size(123, 22);
            this.resizeAll2.Text = "Resize All";
            this.resizeAll2.ToolTipText = "Ctrl+Shift+R";
            this.resizeAll2.Click += new System.EventHandler(this.resizeAll2_Click);
            // 
            // realSize2
            // 
            this.realSize2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.realSizeAll2});
            this.realSize2.Enabled = false;
            this.realSize2.Image = global::ColorMan.MultipleViewer.Properties.Resources.realSizeMode;
            this.realSize2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.realSize2.Name = "realSize2";
            this.realSize2.Size = new System.Drawing.Size(84, 22);
            this.realSize2.Text = "Real Size";
            this.realSize2.ToolTipText = "Ctrl+I";
            this.realSize2.ButtonClick += new System.EventHandler(this.realSize2_ButtonClick);
            // 
            // realSizeAll2
            // 
            this.realSizeAll2.Enabled = false;
            this.realSizeAll2.Name = "realSizeAll2";
            this.realSizeAll2.Size = new System.Drawing.Size(136, 22);
            this.realSizeAll2.Text = "Real Size All";
            this.realSizeAll2.ToolTipText = "Ctrl+Shift+I";
            this.realSizeAll2.Click += new System.EventHandler(this.realSizeAll2_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // colorPicker2
            // 
            this.colorPicker2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.colorPicker2.Image = ((System.Drawing.Image)(resources.GetObject("colorPicker2.Image")));
            this.colorPicker2.Name = "colorPicker2";
            this.colorPicker2.Size = new System.Drawing.Size(23, 22);
            this.colorPicker2.Text = "Color Screen Picker";
            this.colorPicker2.Click += new System.EventHandler(this.colorPicker_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // about2
            // 
            this.about2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.about2.Image = global::ColorMan.MultipleViewer.Properties.Resources.info16;
            this.about2.Name = "about2";
            this.about2.Size = new System.Drawing.Size(23, 22);
            this.about2.Text = "About Multiple-Image Viewer";
            this.about2.Click += new System.EventHandler(this.about_Click);
            // 
            // fswOpen
            // 
            this.fswOpen.EnableRaisingEvents = true;
            this.fswOpen.SynchronizingObject = this;
            this.fswOpen.Changed += new System.IO.FileSystemEventHandler(this.fswOpen_Changed);
            // 
            // cmsMultiple
            // 
            this.cmsMultiple.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.open3,
            this.closeAll1,
            this.toolStripMenuItem3,
            this.colorMan2,
            this.colorPicker3,
            this.compact2,
            this.snipping2,
            this.explorer2,
            this.toolStripMenuItem2,
            this.about3,
            this.toolStripMenuItem4,
            this.exit2});
            this.cmsMultiple.Name = "cmsMultiple";
            this.cmsMultiple.Size = new System.Drawing.Size(262, 220);
            // 
            // open3
            // 
            this.open3.Image = global::ColorMan.MultipleViewer.Properties.Resources.open;
            this.open3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.open3.Name = "open3";
            this.open3.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.open3.Size = new System.Drawing.Size(261, 22);
            this.open3.Text = "&Open";
            this.open3.Click += new System.EventHandler(this.OpenClick);
            // 
            // closeAll1
            // 
            this.closeAll1.Image = global::ColorMan.MultipleViewer.Properties.Resources.hatch16;
            this.closeAll1.Name = "closeAll1";
            this.closeAll1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.closeAll1.Size = new System.Drawing.Size(261, 22);
            this.closeAll1.Text = "Clo&se All";
            this.closeAll1.Click += new System.EventHandler(this.closeAll2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(258, 6);
            // 
            // colorMan2
            // 
            this.colorMan2.Image = global::ColorMan.MultipleViewer.Properties.Resources.colorMan16;
            this.colorMan2.Name = "colorMan2";
            this.colorMan2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.O)));
            this.colorMan2.Size = new System.Drawing.Size(261, 22);
            this.colorMan2.Text = "C&olorMan";
            this.colorMan2.Click += new System.EventHandler(this.colorMan_Click);
            // 
            // colorPicker3
            // 
            this.colorPicker3.Image = global::ColorMan.MultipleViewer.Properties.Resources.colorPicker16;
            this.colorPicker3.Name = "colorPicker3";
            this.colorPicker3.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.colorPicker3.Size = new System.Drawing.Size(261, 22);
            this.colorPicker3.Text = "&Color Screen Picker";
            this.colorPicker3.Click += new System.EventHandler(this.colorPicker_Click);
            // 
            // compact2
            // 
            this.compact2.Image = global::ColorMan.MultipleViewer.Properties.Resources.compactViewer16;
            this.compact2.Name = "compact2";
            this.compact2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.I)));
            this.compact2.Size = new System.Drawing.Size(261, 22);
            this.compact2.Text = "Compact &Image Viewer";
            this.compact2.Click += new System.EventHandler(this.compactViewer_Click);
            // 
            // snipping2
            // 
            this.snipping2.Image = global::ColorMan.MultipleViewer.Properties.Resources.snipping16;
            this.snipping2.Name = "snipping2";
            this.snipping2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.snipping2.Size = new System.Drawing.Size(261, 22);
            this.snipping2.Text = "&Snipping";
            this.snipping2.Click += new System.EventHandler(this.snipping_Click);
            // 
            // explorer2
            // 
            this.explorer2.Image = global::ColorMan.MultipleViewer.Properties.Resources.explorer16;
            this.explorer2.Name = "explorer2";
            this.explorer2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.explorer2.Size = new System.Drawing.Size(261, 22);
            this.explorer2.Text = "&Explorer";
            this.explorer2.Click += new System.EventHandler(this.explorer_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(258, 6);
            // 
            // about3
            // 
            this.about3.Image = global::ColorMan.MultipleViewer.Properties.Resources.info16;
            this.about3.Name = "about3";
            this.about3.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.about3.Size = new System.Drawing.Size(261, 22);
            this.about3.Text = "&About Multiple-Image Viewer ...";
            this.about3.Click += new System.EventHandler(this.about_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(258, 6);
            // 
            // exit2
            // 
            this.exit2.Image = global::ColorMan.MultipleViewer.Properties.Resources.close;
            this.exit2.ImageTransparentColor = System.Drawing.Color.Black;
            this.exit2.Name = "exit2";
            this.exit2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exit2.Size = new System.Drawing.Size(261, 22);
            this.exit2.Text = "E&xit";
            this.exit2.Click += new System.EventHandler(this.exit_Click);
            // 
            // MultipleViewerForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.ContextMenuStrip = this.cmsMultiple;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MultipleViewerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Multiple-Image Viewer";
            this.SizeChanged += new System.EventHandler(this.MultipleImageViewer_SizeChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fswOpen)).EndInit();
            this.cmsMultiple.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem file1;
        private System.Windows.Forms.ToolStripMenuItem open1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exit1;
        private System.Windows.Forms.ToolStripMenuItem horizontal1;
        private System.Windows.Forms.ToolStripMenuItem vertical1;
        private System.Windows.Forms.ToolStripMenuItem cascade1;
        private System.Windows.Forms.ToolStripMenuItem arrange1;
        internal System.Windows.Forms.ToolStripMenuItem window1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton open2;
        internal System.Windows.Forms.ToolStripSplitButton zoom2;
        internal System.Windows.Forms.ToolStripMenuItem zoomAll2;
        internal System.Windows.Forms.ToolStripSplitButton stretch2;
        internal System.Windows.Forms.ToolStripMenuItem stretchAll2;
        internal System.Windows.Forms.ToolStripSplitButton autoSize2;
        internal System.Windows.Forms.ToolStripMenuItem autoSizeAll2;
        internal System.Windows.Forms.ToolStripSplitButton resize2;
        internal System.Windows.Forms.ToolStripMenuItem resizeAll2;
        internal System.Windows.Forms.ToolStripSplitButton realSize2;
        internal System.Windows.Forms.ToolStripMenuItem realSizeAll2;
        internal System.Windows.Forms.ToolStripSplitButton close2;
        internal System.Windows.Forms.ToolStripMenuItem closeAll2;
        private System.IO.FileSystemWatcher fswOpen;
        private System.Windows.Forms.ToolStripMenuItem about1;
        private System.Windows.Forms.ToolStripButton about2;
        private System.Windows.Forms.ToolStripMenuItem applicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorMan1;
        private System.Windows.Forms.ToolStripMenuItem colorPicker1;
        private System.Windows.Forms.ToolStripMenuItem compact1;
        private System.Windows.Forms.ToolStripMenuItem explorer1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton colorPicker2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ContextMenuStrip cmsMultiple;
        private System.Windows.Forms.ToolStripMenuItem open3;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem colorMan2;
        private System.Windows.Forms.ToolStripMenuItem colorPicker3;
        private System.Windows.Forms.ToolStripMenuItem compact2;
        private System.Windows.Forms.ToolStripMenuItem explorer2;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem about3;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem exit2;
        private System.Windows.Forms.ToolStripMenuItem closeAll1;
        private System.Windows.Forms.ToolStripMenuItem snipping1;
        private System.Windows.Forms.ToolStripMenuItem snipping2;
    }
}

