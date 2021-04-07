namespace ColorMan.ControlsLibrary
{
    partial class ZoomViewer
    {
        /// <summary>
        ///Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
               if (components != null) components.Dispose();
                if (snapshot != null) snapshot.Dispose();
                if (pipetteCur != null) pipetteCur.Dispose();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZoomViewer));
            this.avOff = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.avx3 = new System.Windows.Forms.ToolStripMenuItem();
            this.averageColor1 = new System.Windows.Forms.ToolStripMenuItem();
            this.avx5 = new System.Windows.Forms.ToolStripMenuItem();
            this.avx7 = new System.Windows.Forms.ToolStripMenuItem();
            this.avx9 = new System.Windows.Forms.ToolStripMenuItem();
            this.clear1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cms_ZoomViewer = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copySnapshot1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveSnapshot1 = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.labelPick = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.labelInterpolation = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelDescription = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.cms_ZoomViewer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // avOff
            // 
            this.avOff.Name = "avOff";
            this.avOff.Size = new System.Drawing.Size(92, 22);
            this.avOff.Text = "&Off";
            this.avOff.Click += new System.EventHandler(this.av_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DimGray;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(2, 36);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(152, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.pictureBox1.Size = new System.Drawing.Size(196, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.control_MouseDown);
            // 
            // avx3
            // 
            this.avx3.Name = "avx3";
            this.avx3.Size = new System.Drawing.Size(92, 22);
            this.avx3.Text = "&3x3";
            this.avx3.Click += new System.EventHandler(this.av_Click);
            // 
            // averageColor1
            // 
            this.averageColor1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.avOff,
            this.avx3,
            this.avx5,
            this.avx7,
            this.avx9});
            this.averageColor1.Name = "averageColor1";
            this.averageColor1.Size = new System.Drawing.Size(211, 22);
            this.averageColor1.Text = "&Average color";
            // 
            // avx5
            // 
            this.avx5.Name = "avx5";
            this.avx5.Size = new System.Drawing.Size(92, 22);
            this.avx5.Text = "&5x5";
            this.avx5.Click += new System.EventHandler(this.av_Click);
            // 
            // avx7
            // 
            this.avx7.Name = "avx7";
            this.avx7.Size = new System.Drawing.Size(92, 22);
            this.avx7.Text = "&7x7";
            this.avx7.Click += new System.EventHandler(this.av_Click);
            // 
            // avx9
            // 
            this.avx9.Name = "avx9";
            this.avx9.Size = new System.Drawing.Size(92, 22);
            this.avx9.Text = "&9x9";
            this.avx9.Click += new System.EventHandler(this.av_Click);
            // 
            // clear1
            // 
            this.clear1.Image = global::ColorMan.ControlsLibrary.Properties.Resources.clear;
            this.clear1.Name = "clear1";
            this.clear1.Size = new System.Drawing.Size(211, 22);
            this.clear1.Text = "Cl&ear";
            this.clear1.Click += new System.EventHandler(this.clear1_Click);
            // 
            // cms_ZoomViewer
            // 
            this.cms_ZoomViewer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clear1,
            this.copySnapshot1,
            this.saveSnapshot1,
            this.averageColor1});
            this.cms_ZoomViewer.Name = "cms_ZoomViewer";
            this.cms_ZoomViewer.Size = new System.Drawing.Size(212, 114);
            this.cms_ZoomViewer.Opening += new System.ComponentModel.CancelEventHandler(this.cms_ZoomViewer_Opening);
            // 
            // copySnapshot1
            // 
            this.copySnapshot1.Name = "copySnapshot1";
            this.copySnapshot1.Size = new System.Drawing.Size(211, 22);
            this.copySnapshot1.Text = "&Copy last screen snapshot";
            this.copySnapshot1.Click += new System.EventHandler(this.copySnapshot1_Click);
            // 
            // saveSnapshot1
            // 
            this.saveSnapshot1.Name = "saveSnapshot1";
            this.saveSnapshot1.Size = new System.Drawing.Size(211, 22);
            this.saveSnapshot1.Text = "&Save last screen snapshot";
            this.saveSnapshot1.Click += new System.EventHandler(this.saveSnapshot1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(111, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 14);
            this.label2.TabIndex = 12;
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.control_MouseDown);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(111, 1);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 14);
            this.label1.TabIndex = 11;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.control_MouseDown);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 3000;
            this.toolTip1.InitialDelay = 100;
            this.toolTip1.ReshowDelay = 100;
            this.toolTip1.ShowAlways = true;
            // 
            // labelPick
            // 
            this.labelPick.BackColor = System.Drawing.Color.Silver;
            this.labelPick.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelPick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelPick.Image = global::ColorMan.ControlsLibrary.Properties.Resources.pipetteImg;
            this.labelPick.Location = new System.Drawing.Point(1, 1);
            this.labelPick.Margin = new System.Windows.Forms.Padding(0);
            this.labelPick.Name = "labelPick";
            this.labelPick.Size = new System.Drawing.Size(32, 32);
            this.labelPick.TabIndex = 10;
            this.toolTip1.SetToolTip(this.labelPick, "Press Left Mouse Button\r\nand Move");
            this.labelPick.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelPick_MouseDown);
            this.labelPick.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelPick_MouseMove);
            this.labelPick.MouseUp += new System.Windows.Forms.MouseEventHandler(this.labelPick_MouseUp);
            // 
            // checkBox1
            // 
            this.checkBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.Location = new System.Drawing.Point(33, 1);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(0);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Padding = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.checkBox1.Size = new System.Drawing.Size(40, 32);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.TabStop = false;
            this.checkBox1.Text = "P";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // labelInterpolation
            // 
            this.labelInterpolation.BackColor = System.Drawing.Color.Silver;
            this.labelInterpolation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelInterpolation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelInterpolation.Image = global::ColorMan.ControlsLibrary.Properties.Resources.pixel;
            this.labelInterpolation.Location = new System.Drawing.Point(73, 1);
            this.labelInterpolation.Margin = new System.Windows.Forms.Padding(0);
            this.labelInterpolation.Name = "labelInterpolation";
            this.labelInterpolation.Size = new System.Drawing.Size(32, 32);
            this.labelInterpolation.TabIndex = 9;
            this.labelInterpolation.Click += new System.EventHandler(this.labelInterpolation_Click);
            this.labelInterpolation.MouseDown += new System.Windows.Forms.MouseEventHandler(this.control_MouseDown);
            // 
            // trackBar1
            // 
            this.trackBar1.AutoSize = false;
            this.trackBar1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.trackBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(2, 168);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(0);
            this.trackBar1.Maximum = 9;
            this.trackBar1.MaximumSize = new System.Drawing.Size(1362, 30);
            this.trackBar1.MinimumSize = new System.Drawing.Size(152, 30);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(196, 30);
            this.trackBar1.TabIndex = 6;
            this.trackBar1.TabStop = false;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Controls.Add(this.labelPick);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.labelInterpolation);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.MaximumSize = new System.Drawing.Size(1362, 34);
            this.panel1.MinimumSize = new System.Drawing.Size(152, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(196, 34);
            this.panel1.TabIndex = 13;
            // 
            // labelDescription
            // 
            this.labelDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDescription.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDescription.ForeColor = System.Drawing.Color.LightGray;
            this.labelDescription.Location = new System.Drawing.Point(2, 34);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(196, 134);
            this.labelDescription.TabIndex = 14;
            this.labelDescription.Text = "Magnifier window\r\nto select a color\r\nfrom the screen";
            this.labelDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDescription.MouseDown += new System.Windows.Forms.MouseEventHandler(this.control_MouseDown);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "png";
            this.saveFileDialog1.Filter = "Portable Network Graphics|*.png";
            // 
            // ZoomViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ContextMenuStrip = this.cms_ZoomViewer;
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.trackBar1);
            this.MaximumSize = new System.Drawing.Size(1366, 768);
            this.MinimumSize = new System.Drawing.Size(156, 152);
            this.Name = "ZoomViewer";
            this.Size = new System.Drawing.Size(200, 200);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.cms_ZoomViewer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem avOff;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem avx3;
        private System.Windows.Forms.ToolStripMenuItem averageColor1;
        private System.Windows.Forms.ToolStripMenuItem avx5;
        private System.Windows.Forms.ToolStripMenuItem avx7;
        private System.Windows.Forms.ToolStripMenuItem avx9;
        private System.Windows.Forms.ToolStripMenuItem clear1;
        private System.Windows.Forms.ContextMenuStrip cms_ZoomViewer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label labelPick;
        private System.Windows.Forms.Label labelInterpolation;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.ToolStripMenuItem saveSnapshot1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem copySnapshot1;
    }
}
