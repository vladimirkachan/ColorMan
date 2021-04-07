namespace ColorMan.ControlsLibrary
{
    partial class PictureControl
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
            if (disposing)
            {
                if (components != null) components.Dispose();
                if (moveCur != null) moveCur.Dispose();
                if (crossCur != null) crossCur.Dispose();
                if (overCur != null) overCur.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Обязательный метод для поддержки конструктора - не изменяйте 
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cms_pc = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copy1 = new System.Windows.Forms.ToolStripMenuItem();
            this.save1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.cms_pc.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(16384, 16384);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.SizeModeChanged += new System.EventHandler(this.pictureBox1_SizeModeChanged);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // cms_pc
            // 
            this.cms_pc.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copy1,
            this.save1});
            this.cms_pc.Name = "cms_pc";
            this.cms_pc.Size = new System.Drawing.Size(212, 48);
            this.cms_pc.Closed += new System.Windows.Forms.ToolStripDropDownClosedEventHandler(this.cms_pc_Closed);
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
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "png";
            this.saveFileDialog1.Filter = "Portable Network Graphics File|*.png";
            // 
            // PictureControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ContextMenuStrip = this.cms_pc;
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Name = "PictureControl";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.cms_pc.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem save1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem copy1;
        private System.Windows.Forms.ContextMenuStrip cms_pc;
    }
}
