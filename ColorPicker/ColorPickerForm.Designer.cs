
namespace ColorMan.ColorPicker
{
    partial class ColorPickerForm
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
            if (disposing)
            {
                if (components != null) components.Dispose();
                if (graphicalPath != null) graphicalPath.Dispose();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColorPickerForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.wrapHex = new ColorMan.ControlsLibrary.WrapControl();
            this.btnColorMan = new System.Windows.Forms.Button();
            this.tbHex = new ColorMan.ControlsLibrary.HexTextBox();
            this.colorLabel1 = new ColorMan.ControlsLibrary.ColorLabel();
            this.zoomViewer1 = new ColorMan.ControlsLibrary.ZoomViewer();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cms_ColorPicker = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.colorManStart = new System.Windows.Forms.ToolStripMenuItem();
            this.colorManSend = new System.Windows.Forms.ToolStripMenuItem();
            this.unvisibleForm1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ontop1 = new System.Windows.Forms.ToolStripMenuItem();
            this.smooth1 = new System.Windows.Forms.ToolStripMenuItem();
            this.about1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exit1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.wrapHex.SuspendLayout();
            this.cms_ColorPicker.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.wrapHex);
            this.splitContainer1.Panel1.Controls.Add(this.btnColorMan);
            this.splitContainer1.Panel1.Controls.Add(this.colorLabel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.zoomViewer1);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.splitContainer1.Size = new System.Drawing.Size(234, 261);
            this.splitContainer1.SplitterDistance = 36;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.TabStop = false;
            // 
            // wrapHex
            // 
            this.wrapHex.ActiveColor = System.Drawing.SystemColors.MenuHighlight;
            this.wrapHex.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.wrapHex.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("wrapHex.BackgroundImage")));
            this.wrapHex.ButtonOk = this.btnColorMan;
            this.wrapHex.Content = this.tbHex;
            this.wrapHex.Controls.Add(this.tbHex);
            this.wrapHex.Form = this;
            this.wrapHex.LightingColor = System.Drawing.Color.Gold;
            this.wrapHex.Location = new System.Drawing.Point(40, 8);
            this.wrapHex.Margin = new System.Windows.Forms.Padding(5);
            this.wrapHex.Name = "wrapHex";
            this.wrapHex.NoneColor = System.Drawing.SystemColors.WindowFrame;
            this.wrapHex.Padding = new System.Windows.Forms.Padding(2);
            this.wrapHex.Size = new System.Drawing.Size(58, 22);
            this.wrapHex.TabIndex = 3;
            // 
            // btnColorMan
            // 
            this.btnColorMan.BackColor = System.Drawing.Color.LightGray;
            this.btnColorMan.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnColorMan.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnColorMan.FlatAppearance.BorderSize = 2;
            this.btnColorMan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnColorMan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive;
            this.btnColorMan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColorMan.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnColorMan.Location = new System.Drawing.Point(103, 7);
            this.btnColorMan.Margin = new System.Windows.Forms.Padding(0);
            this.btnColorMan.Name = "btnColorMan";
            this.btnColorMan.Size = new System.Drawing.Size(95, 25);
            this.btnColorMan.TabIndex = 1;
            this.btnColorMan.Text = "&ColorMan";
            this.btnColorMan.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnColorMan.UseVisualStyleBackColor = false;
            this.btnColorMan.Click += new System.EventHandler(this.btnColorMan_Click);
            this.btnColorMan.Enter += new System.EventHandler(this.btn_Enter);
            this.btnColorMan.Leave += new System.EventHandler(this.btn_Leave);
            this.btnColorMan.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btnColorMan.MouseHover += new System.EventHandler(this.btn_MouseHover);
            // 
            // tbHex
            // 
            this.tbHex.ActiveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbHex.ActiveForeColor = System.Drawing.Color.White;
            this.tbHex.BackColor = System.Drawing.Color.DarkGray;
            this.tbHex.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbHex.DeactiveBackColor = System.Drawing.Color.DarkGray;
            this.tbHex.DeactiveForeColor = System.Drawing.Color.Black;
            this.tbHex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbHex.Font = new System.Drawing.Font("Verdana", 6.75F);
            this.tbHex.ForeColor = System.Drawing.Color.White;
            this.tbHex.Location = new System.Drawing.Point(2, 2);
            this.tbHex.Margin = new System.Windows.Forms.Padding(0);
            this.tbHex.MaxLength = 6;
            this.tbHex.Name = "tbHex";
            this.tbHex.ReadOnly = true;
            this.tbHex.Size = new System.Drawing.Size(54, 18);
            this.tbHex.TabIndex = 3;
            this.tbHex.TabStop = false;
            this.tbHex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // colorLabel1
            // 
            this.colorLabel1.AllowDrop = true;
            this.colorLabel1.BackColor = System.Drawing.Color.Gray;
            this.colorLabel1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.colorLabel1.LightingColor = System.Drawing.Color.Gold;
            this.colorLabel1.Location = new System.Drawing.Point(5, 5);
            this.colorLabel1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.colorLabel1.Name = "colorLabel1";
            this.colorLabel1.Size = new System.Drawing.Size(30, 30);
            this.colorLabel1.Stroke = 2F;
            this.colorLabel1.TabIndex = 0;
            this.colorLabel1.TabStop = false;
            this.colorLabel1.TypeAndHex = "RGB 808080";
            // 
            // zoomViewer1
            // 
            this.zoomViewer1.ActiveColor = System.Drawing.SystemColors.MenuHighlight;
            this.zoomViewer1.AverageMode = ColorMan.ControlsLibrary.ZoomViewerAverageSize.Off;
            this.zoomViewer1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.zoomViewer1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("zoomViewer1.BackgroundImage")));
            this.zoomViewer1.Checked = false;
            this.zoomViewer1.Coordinate = new System.Drawing.Point(0, 0);
            this.zoomViewer1.CurrentData = ((ColorMan.ControlsLibrary.ZoomViewerData)(resources.GetObject("zoomViewer1.CurrentData")));
            this.zoomViewer1.CurrentSettings = ((ColorMan.ControlsLibrary.ZoomViewerSettings)(resources.GetObject("zoomViewer1.CurrentSettings")));
            this.zoomViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zoomViewer1.Form = this;
            this.zoomViewer1.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            this.zoomViewer1.KeyOn = System.Windows.Forms.Keys.P;
            this.zoomViewer1.LightingColor = System.Drawing.Color.Gold;
            this.zoomViewer1.Location = new System.Drawing.Point(3, 0);
            this.zoomViewer1.MaximumSize = new System.Drawing.Size(1366, 768);
            this.zoomViewer1.MinimumSize = new System.Drawing.Size(156, 152);
            this.zoomViewer1.Name = "zoomViewer1";
            this.zoomViewer1.NoneColor = System.Drawing.SystemColors.WindowFrame;
            this.zoomViewer1.Padding = new System.Windows.Forms.Padding(2);
            this.zoomViewer1.Picture = ((System.Drawing.Image)(resources.GetObject("zoomViewer1.Picture")));
            this.zoomViewer1.Size = new System.Drawing.Size(228, 219);
            this.zoomViewer1.SmoothKey = System.Windows.Forms.Keys.F3;
            this.zoomViewer1.TabIndex = 0;
            this.zoomViewer1.ZoomIndex = 0;
            this.zoomViewer1.ColorPick += new System.EventHandler(this.zoomViewer1_ColorPick);
            this.zoomViewer1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.zoomViewer1_MouseDown);
            this.zoomViewer1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.zoomViewer1_MouseMove);
            this.zoomViewer1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.zoomViewer1_MouseUp);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cms_ColorPicker
            // 
            this.cms_ColorPicker.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorManStart,
            this.colorManSend,
            this.unvisibleForm1,
            this.ontop1,
            this.smooth1,
            this.about1,
            this.exit1});
            this.cms_ColorPicker.Name = "cms_ColorPicker";
            this.cms_ColorPicker.Size = new System.Drawing.Size(206, 180);
            this.cms_ColorPicker.Opening += new System.ComponentModel.CancelEventHandler(this.cms_ColorPicker_Opening);
            // 
            // colorManStart
            // 
            this.colorManStart.Name = "colorManStart";
            this.colorManStart.Size = new System.Drawing.Size(205, 22);
            this.colorManStart.Text = "C&olorMan Start";
            this.colorManStart.Click += new System.EventHandler(this.btnColorMan_Click);
            // 
            // colorManSend
            // 
            this.colorManSend.Name = "colorManSend";
            this.colorManSend.Size = new System.Drawing.Size(205, 22);
            this.colorManSend.Text = "ColorMan &Send";
            this.colorManSend.Click += new System.EventHandler(this.btnColorMan_Click);
            // 
            // unvisibleForm1
            // 
            this.unvisibleForm1.Name = "unvisibleForm1";
            this.unvisibleForm1.ShortcutKeys = System.Windows.Forms.Keys.F10;
            this.unvisibleForm1.Size = new System.Drawing.Size(205, 22);
            this.unvisibleForm1.Text = "&Unvisible Form";
            this.unvisibleForm1.CheckedChanged += new System.EventHandler(this.ChangeRegion);
            // 
            // ontop1
            // 
            this.ontop1.CheckOnClick = true;
            this.ontop1.Name = "ontop1";
            this.ontop1.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.ontop1.Size = new System.Drawing.Size(205, 22);
            this.ontop1.Text = "On&Top";
            this.ontop1.CheckedChanged += new System.EventHandler(this.ontop_CheckedChanged);
            // 
            // smooth1
            // 
            this.smooth1.CheckOnClick = true;
            this.smooth1.Name = "smooth1";
            this.smooth1.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.smooth1.Size = new System.Drawing.Size(205, 22);
            this.smooth1.Text = "S&mooth Picture";
            this.smooth1.CheckedChanged += new System.EventHandler(this.smooth_CheckedChanged);
            // 
            // about1
            // 
            this.about1.Image = global::ColorMan.ColorPicker.Properties.Resources.info16;
            this.about1.Name = "about1";
            this.about1.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.about1.Size = new System.Drawing.Size(205, 22);
            this.about1.Text = "&About Color Picker ...";
            this.about1.Click += new System.EventHandler(this.about1_Click);
            // 
            // exit1
            // 
            this.exit1.Image = global::ColorMan.ColorPicker.Properties.Resources.close;
            this.exit1.ImageTransparentColor = System.Drawing.Color.Black;
            this.exit1.Name = "exit1";
            this.exit1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exit1.Size = new System.Drawing.Size(205, 22);
            this.exit1.Text = "E&xit";
            this.exit1.Click += new System.EventHandler(this.exit1_Click);
            // 
            // ColorPickerForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(234, 261);
            this.ContextMenuStrip = this.cms_ColorPicker;
            this.Controls.Add(this.splitContainer1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(178, 255);
            this.Name = "ColorPickerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ColorPicker";
            this.TopMost = true;
            this.Deactivate += new System.EventHandler(this.ScreenPickerForm_Deactivate);
            this.SizeChanged += new System.EventHandler(this.Form_ChangeRegion);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.wrapHex.ResumeLayout(false);
            this.wrapHex.PerformLayout();
            this.cms_ColorPicker.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private ColorMan.ControlsLibrary.ColorLabel colorLabel1;
        internal ColorMan.ControlsLibrary.HexTextBox tbHex;
        private System.Windows.Forms.Button btnColorMan;
        private ColorMan.ControlsLibrary.WrapControl wrapHex;
        private System.Windows.Forms.Timer timer1;
        internal ColorMan.ControlsLibrary.ZoomViewer zoomViewer1;
        private System.Windows.Forms.ContextMenuStrip cms_ColorPicker;
        private System.Windows.Forms.ToolStripMenuItem about1;
        private System.Windows.Forms.ToolStripMenuItem exit1;
        private System.Windows.Forms.ToolStripMenuItem colorManStart;
        private System.Windows.Forms.ToolStripMenuItem colorManSend;
        private System.Windows.Forms.ToolStripMenuItem ontop1;
        private System.Windows.Forms.ToolStripMenuItem unvisibleForm1;
        private System.Windows.Forms.ToolStripMenuItem smooth1;
    }
}