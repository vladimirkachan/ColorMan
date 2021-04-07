namespace ColorMan.MultipleViewer
{
    partial class PictureForm
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
            if (disposing )
            {
                if (components != null) components.Dispose();
                if (moveCur != null) moveCur.Dispose();
                if (overCur != null) overCur.Dispose();
                if (crossCur != null) crossCur.Dispose();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PictureForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.file1 = new System.Windows.Forms.ToolStripMenuItem();
            this.open1 = new System.Windows.Forms.ToolStripMenuItem();
            this.close1 = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAll1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exit1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.zoom1 = new System.Windows.Forms.ToolStripMenuItem();
            this.stretch1 = new System.Windows.Forms.ToolStripMenuItem();
            this.autoSize1 = new System.Windows.Forms.ToolStripMenuItem();
            this.resize1 = new System.Windows.Forms.ToolStripMenuItem();
            this.realSize1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.zoomAll1 = new System.Windows.Forms.ToolStripMenuItem();
            this.stretchAll1 = new System.Windows.Forms.ToolStripMenuItem();
            this.autoSizeAll1 = new System.Windows.Forms.ToolStripMenuItem();
            this.resizeAll1 = new System.Windows.Forms.ToolStripMenuItem();
            this.realSizeAll1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.cms_pc = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copy1 = new System.Windows.Forms.ToolStripMenuItem();
            this.save1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.cms_pc.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // file1
            // 
            this.file1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.open1,
            this.close1,
            this.closeAll1,
            this.exit1,
            this.toolStripMenuItem2,
            this.zoom1,
            this.stretch1,
            this.autoSize1,
            this.resize1,
            this.realSize1,
            this.toolStripMenuItem1,
            this.zoomAll1,
            this.stretchAll1,
            this.autoSizeAll1,
            this.resizeAll1,
            this.realSizeAll1});
            this.file1.MergeAction = System.Windows.Forms.MergeAction.Replace;
            this.file1.Name = "file1";
            this.file1.Size = new System.Drawing.Size(37, 20);
            this.file1.Text = "&File";
            // 
            // open1
            // 
            this.open1.Image = global::ColorMan.MultipleViewer.Properties.Resources.open;
            this.open1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.open1.Name = "open1";
            this.open1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.open1.Size = new System.Drawing.Size(211, 22);
            this.open1.Text = "&Open";
            this.open1.Click += new System.EventHandler(this.open1_Click);
            // 
            // close1
            // 
            this.close1.Image = global::ColorMan.MultipleViewer.Properties.Resources.hide;
            this.close1.Name = "close1";
            this.close1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F4)));
            this.close1.Size = new System.Drawing.Size(211, 22);
            this.close1.Text = "&Close";
            this.close1.Click += new System.EventHandler(this.close1_Click);
            // 
            // closeAll1
            // 
            this.closeAll1.Enabled = false;
            this.closeAll1.Name = "closeAll1";
            this.closeAll1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F6)));
            this.closeAll1.Size = new System.Drawing.Size(211, 22);
            this.closeAll1.Text = "C&lose All";
            this.closeAll1.Click += new System.EventHandler(this.closeAll1_Click);
            // 
            // exit1
            // 
            this.exit1.Image = global::ColorMan.MultipleViewer.Properties.Resources.close;
            this.exit1.ImageTransparentColor = System.Drawing.Color.Black;
            this.exit1.Name = "exit1";
            this.exit1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exit1.Size = new System.Drawing.Size(211, 22);
            this.exit1.Text = "E&xit";
            this.exit1.Click += new System.EventHandler(this.exit1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(208, 6);
            // 
            // zoom1
            // 
            this.zoom1.Image = global::ColorMan.MultipleViewer.Properties.Resources.zoomMode;
            this.zoom1.Name = "zoom1";
            this.zoom1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.zoom1.Size = new System.Drawing.Size(211, 22);
            this.zoom1.Text = "&Zoom";
            this.zoom1.Click += new System.EventHandler(this.SizeModeClick);
            // 
            // stretch1
            // 
            this.stretch1.Image = global::ColorMan.MultipleViewer.Properties.Resources.stretchMode;
            this.stretch1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stretch1.Name = "stretch1";
            this.stretch1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.stretch1.Size = new System.Drawing.Size(211, 22);
            this.stretch1.Text = "&Stretch";
            this.stretch1.Click += new System.EventHandler(this.SizeModeClick);
            // 
            // autoSize1
            // 
            this.autoSize1.Image = global::ColorMan.MultipleViewer.Properties.Resources.autoSizeMode;
            this.autoSize1.Name = "autoSize1";
            this.autoSize1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.autoSize1.Size = new System.Drawing.Size(211, 22);
            this.autoSize1.Text = "&AutoSize";
            this.autoSize1.Click += new System.EventHandler(this.SizeModeClick);
            // 
            // resize1
            // 
            this.resize1.Image = global::ColorMan.MultipleViewer.Properties.Resources.resize;
            this.resize1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.resize1.Name = "resize1";
            this.resize1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.resize1.Size = new System.Drawing.Size(211, 22);
            this.resize1.Text = "&Resize";
            this.resize1.Click += new System.EventHandler(this.Resize1Click);
            // 
            // realSize1
            // 
            this.realSize1.Image = global::ColorMan.MultipleViewer.Properties.Resources.realSizeMode;
            this.realSize1.Name = "realSize1";
            this.realSize1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.realSize1.Size = new System.Drawing.Size(211, 22);
            this.realSize1.Text = "Real S&ize";
            this.realSize1.Click += new System.EventHandler(this.RealSize1Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(208, 6);
            // 
            // zoomAll1
            // 
            this.zoomAll1.Enabled = false;
            this.zoomAll1.Name = "zoomAll1";
            this.zoomAll1.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Z)));
            this.zoomAll1.Size = new System.Drawing.Size(211, 22);
            this.zoomAll1.Text = "Zoom All";
            this.zoomAll1.Click += new System.EventHandler(this.sizeModeAll_Click);
            // 
            // stretchAll1
            // 
            this.stretchAll1.Enabled = false;
            this.stretchAll1.Name = "stretchAll1";
            this.stretchAll1.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.stretchAll1.Size = new System.Drawing.Size(211, 22);
            this.stretchAll1.Text = "Stretch All";
            this.stretchAll1.Click += new System.EventHandler(this.sizeModeAll_Click);
            // 
            // autoSizeAll1
            // 
            this.autoSizeAll1.Enabled = false;
            this.autoSizeAll1.Name = "autoSizeAll1";
            this.autoSizeAll1.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.A)));
            this.autoSizeAll1.Size = new System.Drawing.Size(211, 22);
            this.autoSizeAll1.Text = "AutoSize All";
            this.autoSizeAll1.Click += new System.EventHandler(this.sizeModeAll_Click);
            // 
            // resizeAll1
            // 
            this.resizeAll1.Enabled = false;
            this.resizeAll1.Name = "resizeAll1";
            this.resizeAll1.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.R)));
            this.resizeAll1.Size = new System.Drawing.Size(211, 22);
            this.resizeAll1.Text = "Resize All";
            this.resizeAll1.Click += new System.EventHandler(this.resizeAll1_Click);
            // 
            // realSizeAll1
            // 
            this.realSizeAll1.Enabled = false;
            this.realSizeAll1.Name = "realSizeAll1";
            this.realSizeAll1.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.I)));
            this.realSizeAll1.Size = new System.Drawing.Size(211, 22);
            this.realSizeAll1.Text = "Real Size All";
            this.realSizeAll1.Click += new System.EventHandler(this.realSizeAll1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(16384, 16384);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.SizeModeChanged += new System.EventHandler(this.pictureBox1_SizeModeChanged);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "png";
            this.saveFileDialog1.Filter = "Portable Network Graphics File|*.png";
            // 
            // cms_pc
            // 
            this.cms_pc.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copy1,
            this.save1});
            this.cms_pc.Name = "cms_pc";
            this.cms_pc.Size = new System.Drawing.Size(212, 48);
            this.cms_pc.Opening += new System.ComponentModel.CancelEventHandler(this.cms_pc_Opening);
            // 
            // copy1
            // 
            this.copy1.Name = "copy1";
            this.copy1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copy1.Size = new System.Drawing.Size(211, 22);
            this.copy1.Text = "&Copy to clipboard";
            this.copy1.Click += new System.EventHandler(this.copy1_Click);
            // 
            // save1
            // 
            this.save1.Name = "save1";
            this.save1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.save1.Size = new System.Drawing.Size(211, 22);
            this.save1.Text = "&Save as PNG";
            this.save1.Click += new System.EventHandler(this.save1_Click);
            // 
            // PictureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.ContextMenuStrip = this.cms_pc;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PictureForm";
            this.Text = "PictureForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.cms_pc.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem file1;
        private System.Windows.Forms.ToolStripMenuItem open1;
        private System.Windows.Forms.ToolStripMenuItem close1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exit1;
        internal System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem zoom1;
        private System.Windows.Forms.ToolStripMenuItem stretch1;
        private System.Windows.Forms.ToolStripMenuItem autoSize1;
        private System.Windows.Forms.ToolStripMenuItem resize1;
        private System.Windows.Forms.ToolStripMenuItem realSize1;
        internal System.Windows.Forms.ToolStripMenuItem closeAll1;
        internal System.Windows.Forms.ToolStripMenuItem zoomAll1;
        internal System.Windows.Forms.ToolStripMenuItem stretchAll1;
        internal System.Windows.Forms.ToolStripMenuItem autoSizeAll1;
        internal System.Windows.Forms.ToolStripMenuItem resizeAll1;
        internal System.Windows.Forms.ToolStripMenuItem realSizeAll1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ContextMenuStrip cms_pc;
        private System.Windows.Forms.ToolStripMenuItem copy1;
        private System.Windows.Forms.ToolStripMenuItem save1;
    }
}