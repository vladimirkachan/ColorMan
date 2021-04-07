namespace ColorMan.AppForms
{
    partial class RectView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RectView));
            this.pnlVals = new System.Windows.Forms.Panel();
            this.wrapT1 = new ColorMan.ControlsLibrary.WrapControl();
            this.ctb1 = new ColorMan.ControlsLibrary.NumberTextBox();
            this.wrapT3 = new ColorMan.ControlsLibrary.WrapControl();
            this.ctb3 = new ColorMan.ControlsLibrary.NumberTextBox();
            this.wrapT2 = new ColorMan.ControlsLibrary.WrapControl();
            this.ctb2 = new ColorMan.ControlsLibrary.NumberTextBox();
            this.wrapN3 = new ColorMan.ControlsLibrary.WrapControl();
            this.cnud3 = new ColorMan.ControlsLibrary.CnumericUpDown();
            this.wrapN2 = new ColorMan.ControlsLibrary.WrapControl();
            this.cnud2 = new ColorMan.ControlsLibrary.CnumericUpDown();
            this.wrapN1 = new ColorMan.ControlsLibrary.WrapControl();
            this.cnud1 = new ColorMan.ControlsLibrary.CnumericUpDown();
            this.lb3 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlVals.SuspendLayout();
            this.wrapT1.SuspendLayout();
            this.wrapT3.SuspendLayout();
            this.wrapT2.SuspendLayout();
            this.wrapN3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cnud3)).BeginInit();
            this.wrapN2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cnud2)).BeginInit();
            this.wrapN1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cnud1)).BeginInit();
            this.SuspendLayout();
            // 
            // colorLabel1
            // 
            this.colorLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.colorLabel1.Location = new System.Drawing.Point(311, 4);
            // 
            // colorLabel2
            // 
            this.colorLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.colorLabel2.Location = new System.Drawing.Point(331, 24);
            // 
            // pnlVals
            // 
            this.pnlVals.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlVals.Controls.Add(this.wrapT1);
            this.pnlVals.Controls.Add(this.wrapT3);
            this.pnlVals.Controls.Add(this.wrapT2);
            this.pnlVals.Controls.Add(this.wrapN3);
            this.pnlVals.Controls.Add(this.wrapN2);
            this.pnlVals.Controls.Add(this.wrapN1);
            this.pnlVals.Controls.Add(this.lb3);
            this.pnlVals.Controls.Add(this.lb2);
            this.pnlVals.Controls.Add(this.lb1);
            this.pnlVals.Controls.Add(this.label1);
            this.pnlVals.Controls.Add(this.label2);
            this.pnlVals.Controls.Add(this.label3);
            this.pnlVals.Location = new System.Drawing.Point(268, 184);
            this.pnlVals.Margin = new System.Windows.Forms.Padding(0);
            this.pnlVals.MaximumSize = new System.Drawing.Size(133, 109);
            this.pnlVals.MinimumSize = new System.Drawing.Size(133, 109);
            this.pnlVals.Name = "pnlVals";
            this.pnlVals.Size = new System.Drawing.Size(133, 109);
            this.pnlVals.TabIndex = 50;
            // 
            // wrapT1
            // 
            this.wrapT1.ActiveColor = System.Drawing.SystemColors.MenuHighlight;
            this.wrapT1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.wrapT1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("wrapT1.BackgroundImage")));
            this.wrapT1.ButtonOk = null;
            this.wrapT1.Content = this.ctb1;
            this.wrapT1.Controls.Add(this.ctb1);
            this.wrapT1.Form = this;
            this.wrapT1.LightingColor = System.Drawing.Color.Gold;
            this.wrapT1.Location = new System.Drawing.Point(79, 13);
            this.wrapT1.Margin = new System.Windows.Forms.Padding(0);
            this.wrapT1.Name = "wrapT1";
            this.wrapT1.NoneColor = System.Drawing.Color.Transparent;
            this.wrapT1.Padding = new System.Windows.Forms.Padding(2);
            this.wrapT1.Size = new System.Drawing.Size(48, 24);
            this.wrapT1.TabIndex = 5;
            // 
            // ctb1
            // 
            this.ctb1.ActiveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ctb1.ActiveForeColor = System.Drawing.Color.White;
            this.ctb1.BackColor = System.Drawing.Color.DarkGray;
            this.ctb1.DeactiveBackColor = System.Drawing.Color.DarkGray;
            this.ctb1.DeactiveForeColor = System.Drawing.Color.Black;
            this.ctb1.DecimalPlaces = 1;
            this.ctb1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ctb1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ctb1.Location = new System.Drawing.Point(2, 2);
            this.ctb1.Margin = new System.Windows.Forms.Padding(0);
            this.ctb1.Maximum = 100F;
            this.ctb1.Minimum = 0F;
            this.ctb1.Name = "ctb1";
            this.ctb1.Size = new System.Drawing.Size(44, 20);
            this.ctb1.TabIndex = 3;
            this.ctb1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ctb1.LastValue += new System.EventHandler(this.ItemLastValue);
            // 
            // wrapT3
            // 
            this.wrapT3.ActiveColor = System.Drawing.SystemColors.MenuHighlight;
            this.wrapT3.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.wrapT3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("wrapT3.BackgroundImage")));
            this.wrapT3.ButtonOk = null;
            this.wrapT3.Content = this.ctb3;
            this.wrapT3.Controls.Add(this.ctb3);
            this.wrapT3.Form = this;
            this.wrapT3.LightingColor = System.Drawing.Color.Gold;
            this.wrapT3.Location = new System.Drawing.Point(79, 84);
            this.wrapT3.Margin = new System.Windows.Forms.Padding(0);
            this.wrapT3.Name = "wrapT3";
            this.wrapT3.NoneColor = System.Drawing.Color.Transparent;
            this.wrapT3.Padding = new System.Windows.Forms.Padding(2);
            this.wrapT3.Size = new System.Drawing.Size(48, 24);
            this.wrapT3.TabIndex = 7;
            // 
            // ctb3
            // 
            this.ctb3.ActiveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ctb3.ActiveForeColor = System.Drawing.Color.White;
            this.ctb3.BackColor = System.Drawing.Color.DarkGray;
            this.ctb3.DeactiveBackColor = System.Drawing.Color.DarkGray;
            this.ctb3.DeactiveForeColor = System.Drawing.Color.Black;
            this.ctb3.DecimalPlaces = 1;
            this.ctb3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ctb3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ctb3.Location = new System.Drawing.Point(2, 2);
            this.ctb3.Margin = new System.Windows.Forms.Padding(0);
            this.ctb3.Maximum = 255F;
            this.ctb3.Minimum = 0F;
            this.ctb3.Name = "ctb3";
            this.ctb3.Size = new System.Drawing.Size(44, 20);
            this.ctb3.TabIndex = 5;
            this.ctb3.TabStop = false;
            this.ctb3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ctb3.LastValue += new System.EventHandler(this.ItemLastValue);
            // 
            // wrapT2
            // 
            this.wrapT2.ActiveColor = System.Drawing.SystemColors.MenuHighlight;
            this.wrapT2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.wrapT2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("wrapT2.BackgroundImage")));
            this.wrapT2.ButtonOk = null;
            this.wrapT2.Content = this.ctb2;
            this.wrapT2.Controls.Add(this.ctb2);
            this.wrapT2.Form = this;
            this.wrapT2.LightingColor = System.Drawing.Color.Gold;
            this.wrapT2.Location = new System.Drawing.Point(79, 49);
            this.wrapT2.Margin = new System.Windows.Forms.Padding(0);
            this.wrapT2.Name = "wrapT2";
            this.wrapT2.NoneColor = System.Drawing.Color.Transparent;
            this.wrapT2.Padding = new System.Windows.Forms.Padding(2);
            this.wrapT2.Size = new System.Drawing.Size(48, 24);
            this.wrapT2.TabIndex = 6;
            // 
            // ctb2
            // 
            this.ctb2.ActiveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ctb2.ActiveForeColor = System.Drawing.Color.White;
            this.ctb2.BackColor = System.Drawing.Color.DarkGray;
            this.ctb2.DeactiveBackColor = System.Drawing.Color.DarkGray;
            this.ctb2.DeactiveForeColor = System.Drawing.Color.Black;
            this.ctb2.DecimalPlaces = 1;
            this.ctb2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ctb2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ctb2.Location = new System.Drawing.Point(2, 2);
            this.ctb2.Margin = new System.Windows.Forms.Padding(0);
            this.ctb2.Maximum = 255F;
            this.ctb2.Minimum = 0F;
            this.ctb2.Name = "ctb2";
            this.ctb2.Size = new System.Drawing.Size(44, 20);
            this.ctb2.TabIndex = 4;
            this.ctb2.TabStop = false;
            this.ctb2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ctb2.LastValue += new System.EventHandler(this.ItemLastValue);
            // 
            // wrapN3
            // 
            this.wrapN3.ActiveColor = System.Drawing.SystemColors.MenuHighlight;
            this.wrapN3.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.wrapN3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("wrapN3.BackgroundImage")));
            this.wrapN3.ButtonOk = null;
            this.wrapN3.Content = this.cnud3;
            this.wrapN3.Controls.Add(this.cnud3);
            this.wrapN3.Form = this;
            this.wrapN3.LightingColor = System.Drawing.Color.Gold;
            this.wrapN3.Location = new System.Drawing.Point(22, 84);
            this.wrapN3.Margin = new System.Windows.Forms.Padding(0);
            this.wrapN3.Name = "wrapN3";
            this.wrapN3.NoneColor = System.Drawing.Color.Transparent;
            this.wrapN3.Padding = new System.Windows.Forms.Padding(2);
            this.wrapN3.Size = new System.Drawing.Size(56, 24);
            this.wrapN3.TabIndex = 4;
            // 
            // cnud3
            // 
            this.cnud3.AccelerationIncrement = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.cnud3.AccelerationSeconds = 1;
            this.cnud3.ActiveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cnud3.ActiveForeColor = System.Drawing.Color.White;
            this.cnud3.BackColor = System.Drawing.Color.DarkGray;
            this.cnud3.DeactiveBackColor = System.Drawing.Color.DarkGray;
            this.cnud3.DeactiveForeColor = System.Drawing.Color.Black;
            this.cnud3.DecimalPlaces = 1;
            this.cnud3.Divider = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.cnud3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cnud3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cnud3.Location = new System.Drawing.Point(2, 2);
            this.cnud3.Margin = new System.Windows.Forms.Padding(0);
            this.cnud3.Name = "cnud3";
            this.cnud3.Size = new System.Drawing.Size(52, 20);
            this.cnud3.TabIndex = 2;
            this.cnud3.TabStop = false;
            this.cnud3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cnud3.LastValue += new System.EventHandler(this.ItemLastValue);
            // 
            // wrapN2
            // 
            this.wrapN2.ActiveColor = System.Drawing.SystemColors.MenuHighlight;
            this.wrapN2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.wrapN2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("wrapN2.BackgroundImage")));
            this.wrapN2.ButtonOk = null;
            this.wrapN2.Content = this.cnud2;
            this.wrapN2.Controls.Add(this.cnud2);
            this.wrapN2.Form = this;
            this.wrapN2.LightingColor = System.Drawing.Color.Gold;
            this.wrapN2.Location = new System.Drawing.Point(22, 49);
            this.wrapN2.Margin = new System.Windows.Forms.Padding(0);
            this.wrapN2.Name = "wrapN2";
            this.wrapN2.NoneColor = System.Drawing.Color.Transparent;
            this.wrapN2.Padding = new System.Windows.Forms.Padding(2);
            this.wrapN2.Size = new System.Drawing.Size(56, 24);
            this.wrapN2.TabIndex = 3;
            // 
            // cnud2
            // 
            this.cnud2.AccelerationIncrement = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.cnud2.AccelerationSeconds = 1;
            this.cnud2.ActiveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cnud2.ActiveForeColor = System.Drawing.Color.White;
            this.cnud2.BackColor = System.Drawing.Color.DarkGray;
            this.cnud2.DeactiveBackColor = System.Drawing.Color.DarkGray;
            this.cnud2.DeactiveForeColor = System.Drawing.Color.Black;
            this.cnud2.DecimalPlaces = 1;
            this.cnud2.Divider = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.cnud2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cnud2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cnud2.Location = new System.Drawing.Point(2, 2);
            this.cnud2.Margin = new System.Windows.Forms.Padding(0);
            this.cnud2.Name = "cnud2";
            this.cnud2.Size = new System.Drawing.Size(52, 20);
            this.cnud2.TabIndex = 1;
            this.cnud2.TabStop = false;
            this.cnud2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cnud2.LastValue += new System.EventHandler(this.ItemLastValue);
            // 
            // wrapN1
            // 
            this.wrapN1.ActiveColor = System.Drawing.SystemColors.MenuHighlight;
            this.wrapN1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.wrapN1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("wrapN1.BackgroundImage")));
            this.wrapN1.ButtonOk = null;
            this.wrapN1.Content = this.cnud1;
            this.wrapN1.Controls.Add(this.cnud1);
            this.wrapN1.Form = this;
            this.wrapN1.LightingColor = System.Drawing.Color.Gold;
            this.wrapN1.Location = new System.Drawing.Point(22, 13);
            this.wrapN1.Margin = new System.Windows.Forms.Padding(0);
            this.wrapN1.Name = "wrapN1";
            this.wrapN1.NoneColor = System.Drawing.Color.Transparent;
            this.wrapN1.Padding = new System.Windows.Forms.Padding(2);
            this.wrapN1.Size = new System.Drawing.Size(56, 24);
            this.wrapN1.TabIndex = 2;
            // 
            // cnud1
            // 
            this.cnud1.AccelerationIncrement = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.cnud1.AccelerationSeconds = 1;
            this.cnud1.ActiveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cnud1.ActiveForeColor = System.Drawing.Color.White;
            this.cnud1.BackColor = System.Drawing.Color.DarkGray;
            this.cnud1.DeactiveBackColor = System.Drawing.Color.DarkGray;
            this.cnud1.DeactiveForeColor = System.Drawing.Color.Black;
            this.cnud1.DecimalPlaces = 1;
            this.cnud1.Divider = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.cnud1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cnud1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cnud1.Location = new System.Drawing.Point(2, 2);
            this.cnud1.Margin = new System.Windows.Forms.Padding(0);
            this.cnud1.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.cnud1.Name = "cnud1";
            this.cnud1.Size = new System.Drawing.Size(52, 20);
            this.cnud1.TabIndex = 0;
            this.cnud1.TabStop = false;
            this.cnud1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cnud1.LastValue += new System.EventHandler(this.ItemLastValue);
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb3.ForeColor = System.Drawing.Color.Silver;
            this.lb3.Location = new System.Drawing.Point(4, 89);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(14, 13);
            this.lb3.TabIndex = 36;
            this.lb3.Text = "3";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb2.ForeColor = System.Drawing.Color.Silver;
            this.lb2.Location = new System.Drawing.Point(4, 53);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(14, 13);
            this.lb2.TabIndex = 35;
            this.lb2.Text = "2";
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb1.ForeColor = System.Drawing.Color.Silver;
            this.lb1.Location = new System.Drawing.Point(4, 17);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(14, 13);
            this.lb1.TabIndex = 34;
            this.lb1.Text = "1";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 6.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(83, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 11);
            this.label1.TabIndex = 31;
            this.label1.Text = "0-100";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 6.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(83, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 11);
            this.label2.TabIndex = 32;
            this.label2.Text = "0-255";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 6.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(83, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 11);
            this.label3.TabIndex = 33;
            this.label3.Text = "0-255";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RectView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(399, 296);
            this.Controls.Add(this.pnlVals);
            this.MaximumSize = new System.Drawing.Size(848, 768);
            this.MinimumSize = new System.Drawing.Size(284, 204);
            this.Name = "RectView";
            this.Text = "RectView";
            this.Controls.SetChildIndex(this.colorLabel2, 0);
            this.Controls.SetChildIndex(this.colorLabel1, 0);
            this.Controls.SetChildIndex(this.pnlVals, 0);
            this.pnlVals.ResumeLayout(false);
            this.pnlVals.PerformLayout();
            this.wrapT1.ResumeLayout(false);
            this.wrapT1.PerformLayout();
            this.wrapT3.ResumeLayout(false);
            this.wrapT3.PerformLayout();
            this.wrapT2.ResumeLayout(false);
            this.wrapT2.PerformLayout();
            this.wrapN3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cnud3)).EndInit();
            this.wrapN2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cnud2)).EndInit();
            this.wrapN1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cnud1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Label lb3;
        protected System.Windows.Forms.Label lb2;
        protected System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        protected ColorMan.ControlsLibrary.NumberTextBox ctb3;
        protected ColorMan.ControlsLibrary.CnumericUpDown cnud1;
        private System.Windows.Forms.Label label3;
        protected ColorMan.ControlsLibrary.CnumericUpDown cnud2;
        protected ColorMan.ControlsLibrary.NumberTextBox ctb2;
        protected ColorMan.ControlsLibrary.CnumericUpDown cnud3;
        private ColorMan.ControlsLibrary.WrapControl wrapT3;
        private ColorMan.ControlsLibrary.WrapControl wrapT2;
        private ColorMan.ControlsLibrary.WrapControl wrapN3;
        private ColorMan.ControlsLibrary.WrapControl wrapN2;
        private ColorMan.ControlsLibrary.WrapControl wrapN1;
        protected System.Windows.Forms.Panel pnlVals;
        private ControlsLibrary.WrapControl wrapT1;
        protected ControlsLibrary.NumberTextBox ctb1;
    }
}
