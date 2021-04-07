using System.ComponentModel;
using System.Windows.Forms;
using ColorMan.ControlsLibrary;

namespace ColorMan.AppForms
{
    partial class View
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;
        internal ColorLabel ColorLabel1 { get { return colorLabel1; } }
        internal ColorLabel ColorLabel2 { get { return colorLabel2; } }
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cms_View = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.rotate1 = new System.Windows.Forms.ToolStripMenuItem();
            this.closeWindow1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gotoMainColorMan1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitColorMan1 = new System.Windows.Forms.ToolStripMenuItem();
            this.colorLabel1 = new ColorMan.ControlsLibrary.ColorLabel();
            this.colorLabel2 = new ColorMan.ControlsLibrary.ColorLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cms_View.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 200;
            this.toolTip1.ReshowDelay = 100;
            this.toolTip1.ShowAlways = true;
            // 
            // cms_View
            // 
            this.cms_View.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rotate1,
            this.closeWindow1,
            this.gotoMainColorMan1,
            this.exitColorMan1});
            this.cms_View.Name = "cms_View";
            this.cms_View.Size = new System.Drawing.Size(277, 92);
            this.cms_View.Opening += new System.ComponentModel.CancelEventHandler(this.CmsViewOpening);
            // 
            // rotate1
            // 
            this.rotate1.Image = global::ColorMan.Properties.Resources.rotate16;
            this.rotate1.Name = "rotate1";
            this.rotate1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.R)));
            this.rotate1.Size = new System.Drawing.Size(276, 22);
            this.rotate1.Text = "&Rotate window";
            this.rotate1.Click += new System.EventHandler(this.rotate1_Click);
            // 
            // closeWindow1
            // 
            this.closeWindow1.Image = global::ColorMan.Properties.Resources.hide;
            this.closeWindow1.Name = "closeWindow1";
            this.closeWindow1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.closeWindow1.Size = new System.Drawing.Size(276, 22);
            this.closeWindow1.Text = "&Close window";
            this.closeWindow1.Click += new System.EventHandler(this.closeWindow1_Click);
            // 
            // gotoMainColorMan1
            // 
            this.gotoMainColorMan1.Image = global::ColorMan.Properties.Resources.colorMan16;
            this.gotoMainColorMan1.Name = "gotoMainColorMan1";
            this.gotoMainColorMan1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F8)));
            this.gotoMainColorMan1.Size = new System.Drawing.Size(276, 22);
            this.gotoMainColorMan1.Text = "&Go to Main ColorMan window";
            this.gotoMainColorMan1.Click += new System.EventHandler(this.gotoMainColorMan1_Click);
            // 
            // exitColorMan1
            // 
            this.exitColorMan1.Image = global::ColorMan.Properties.Resources.close;
            this.exitColorMan1.ImageTransparentColor = System.Drawing.Color.Black;
            this.exitColorMan1.Name = "exitColorMan1";
            this.exitColorMan1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F10)));
            this.exitColorMan1.Size = new System.Drawing.Size(276, 22);
            this.exitColorMan1.Text = "E&xit ColorMan";
            this.exitColorMan1.Click += new System.EventHandler(this.exitColorMan1_Click);
            // 
            // colorLabel1
            // 
            this.colorLabel1.AllowDrop = true;
            this.colorLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.colorLabel1.BackColor = System.Drawing.Color.Gray;
            this.colorLabel1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.colorLabel1.LightingColor = System.Drawing.Color.Gold;
            this.colorLabel1.Location = new System.Drawing.Point(6, 47);
            this.colorLabel1.MaximumSize = new System.Drawing.Size(30, 30);
            this.colorLabel1.MinimumSize = new System.Drawing.Size(30, 30);
            this.colorLabel1.Name = "colorLabel1";
            this.colorLabel1.Size = new System.Drawing.Size(30, 30);
            this.colorLabel1.Stroke = 2F;
            this.colorLabel1.TabIndex = 40;
            this.colorLabel1.TabStop = false;
            this.colorLabel1.TypeAndHex = "RGB 808080";
            this.colorLabel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.colorLabel1_DragDrop);
            this.colorLabel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.colorLabel_MouseDown);
            // 
            // colorLabel2
            // 
            this.colorLabel2.AllowDrop = true;
            this.colorLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.colorLabel2.BackColor = System.Drawing.Color.Gray;
            this.colorLabel2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.colorLabel2.LightingColor = System.Drawing.Color.Gold;
            this.colorLabel2.Location = new System.Drawing.Point(27, 68);
            this.colorLabel2.MaximumSize = new System.Drawing.Size(30, 30);
            this.colorLabel2.MinimumSize = new System.Drawing.Size(30, 30);
            this.colorLabel2.Name = "colorLabel2";
            this.colorLabel2.Size = new System.Drawing.Size(30, 30);
            this.colorLabel2.Stroke = 2F;
            this.colorLabel2.TabIndex = 41;
            this.colorLabel2.TabStop = false;
            this.colorLabel2.TypeAndHex = "RGB 808080";
            this.colorLabel2.DragDrop += new System.Windows.Forms.DragEventHandler(this.colorLabel2_DragDrop);
            this.colorLabel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.colorLabel_MouseDown);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.ContextMenuStrip = this.cms_View;
            this.Controls.Add(this.colorLabel1);
            this.Controls.Add(this.colorLabel2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "View";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "View";
            this.cms_View.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ToolTip toolTip1;
        protected ColorLabel colorLabel1;
        protected ColorLabel colorLabel2;
        private ContextMenuStrip cms_View;
        private ToolStripMenuItem closeWindow1;
        private ToolStripMenuItem gotoMainColorMan1;
        private ToolStripMenuItem exitColorMan1;
        private ToolStripMenuItem rotate1;
        private Timer timer1;
    }
}