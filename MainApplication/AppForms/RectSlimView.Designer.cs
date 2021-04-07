using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ColorMan.ControlsLibrary;

namespace ColorMan.AppForms
{
    partial class RectSlimView
    {
        /// <summary>
        ///Требуется переменная конструктора.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RectSlimView));
            this.pnlVals = new System.Windows.Forms.Panel();
            this.wrapN3 = new ColorMan.ControlsLibrary.WrapControl();
            this.cnud3 = new ColorMan.ControlsLibrary.CnumericUpDown();
            this.wrapN2 = new ColorMan.ControlsLibrary.WrapControl();
            this.cnud2 = new ColorMan.ControlsLibrary.CnumericUpDown();
            this.wrapN1 = new ColorMan.ControlsLibrary.WrapControl();
            this.cnud1 = new ColorMan.ControlsLibrary.CnumericUpDown();
            this.lb3 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.pnlVals.SuspendLayout();
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
            this.colorLabel1.Location = new System.Drawing.Point(326, 12);
            // 
            // colorLabel2
            // 
            this.colorLabel2.Location = new System.Drawing.Point(344, 28);
            // 
            // pnlVals
            // 
            this.pnlVals.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlVals.Controls.Add(this.wrapN3);
            this.pnlVals.Controls.Add(this.wrapN2);
            this.pnlVals.Controls.Add(this.wrapN1);
            this.pnlVals.Controls.Add(this.lb3);
            this.pnlVals.Controls.Add(this.lb2);
            this.pnlVals.Controls.Add(this.lb1);
            this.pnlVals.Location = new System.Drawing.Point(309, 203);
            this.pnlVals.Margin = new System.Windows.Forms.Padding(0);
            this.pnlVals.Name = "pnlVals";
            this.pnlVals.Size = new System.Drawing.Size(80, 105);
            this.pnlVals.TabIndex = 50;
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
            this.wrapN3.Location = new System.Drawing.Point(22, 80);
            this.wrapN3.Margin = new System.Windows.Forms.Padding(0);
            this.wrapN3.Name = "wrapN3";
            this.wrapN3.NoneColor = System.Drawing.SystemColors.WindowFrame;
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
            this.cnud3.TabIndex = 27;
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
            this.wrapN2.Location = new System.Drawing.Point(22, 46);
            this.wrapN2.Margin = new System.Windows.Forms.Padding(0);
            this.wrapN2.Name = "wrapN2";
            this.wrapN2.NoneColor = System.Drawing.SystemColors.WindowFrame;
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
            this.cnud2.TabIndex = 26;
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
            this.wrapN1.Location = new System.Drawing.Point(22, 12);
            this.wrapN1.Margin = new System.Windows.Forms.Padding(0);
            this.wrapN1.Name = "wrapN1";
            this.wrapN1.NoneColor = System.Drawing.SystemColors.WindowFrame;
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
            this.cnud1.TabIndex = 25;
            this.cnud1.TabStop = false;
            this.cnud1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cnud1.LastValue += new System.EventHandler(this.ItemLastValue);
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb3.ForeColor = System.Drawing.Color.Silver;
            this.lb3.Location = new System.Drawing.Point(5, 84);
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
            this.lb2.Location = new System.Drawing.Point(5, 50);
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
            this.lb1.Location = new System.Drawing.Point(4, 16);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(14, 13);
            this.lb1.TabIndex = 34;
            this.lb1.Text = "1";
            // 
            // RectSlimView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(391, 312);
            this.Controls.Add(this.pnlVals);
            this.Name = "RectSlimView";
            this.Text = "RectSlimView";
            this.Controls.SetChildIndex(this.colorLabel2, 0);
            this.Controls.SetChildIndex(this.pnlVals, 0);
            this.Controls.SetChildIndex(this.colorLabel1, 0);
            this.pnlVals.ResumeLayout(false);
            this.pnlVals.PerformLayout();
            this.wrapN3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cnud3)).EndInit();
            this.wrapN2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cnud2)).EndInit();
            this.wrapN1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cnud1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected Label lb3;
        protected Label lb2;
        protected Label lb1;
        protected WrapControl wrapN3;
        protected WrapControl wrapN2;
        protected WrapControl wrapN1;
        protected CnumericUpDown cnud1;
        protected CnumericUpDown cnud2;
        protected CnumericUpDown cnud3;
        protected Panel pnlVals;
    }
}
