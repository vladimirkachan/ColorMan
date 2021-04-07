using System.ComponentModel;
using System.Drawing;

namespace ColorMan.AppForms
{
    partial class LabHorizontalView
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
            ((System.ComponentModel.ISupportInitialize)(this.hcbox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hcbox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hcbox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctbar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctbar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctbar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnud1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnud2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnud3)).BeginInit();
            this.SuspendLayout();
            // 
            // hcbox1
            // 
            this.hcbox1.ColorCount = 9;
            this.hcbox1.SetColors(new System.Drawing.Color[] {
                System.Drawing.Color.Empty,
                System.Drawing.Color.Empty,
                System.Drawing.Color.Empty,
                System.Drawing.Color.Empty,
                System.Drawing.Color.Empty,
                System.Drawing.Color.Empty,
                System.Drawing.Color.Empty,
                System.Drawing.Color.Empty,
                System.Drawing.Color.Empty});
            // 
            // hcbox2
            // 
            this.hcbox2.ColorCount = 9;
            this.hcbox2.SetColors(new System.Drawing.Color[] {
                System.Drawing.Color.Empty,
                System.Drawing.Color.Empty,
                System.Drawing.Color.Empty,
                System.Drawing.Color.Empty,
                System.Drawing.Color.Empty,
                System.Drawing.Color.Empty,
                System.Drawing.Color.Empty,
                System.Drawing.Color.Empty,
                System.Drawing.Color.Empty});
            // 
            // hcbox3
            // 
            this.hcbox3.ColorCount = 9;
            this.hcbox3.SetColors(new System.Drawing.Color[] {
                System.Drawing.Color.Empty,
                System.Drawing.Color.Empty,
                System.Drawing.Color.Empty,
                System.Drawing.Color.Empty,
                System.Drawing.Color.Empty,
                System.Drawing.Color.Empty,
                System.Drawing.Color.Empty,
                System.Drawing.Color.Empty,
                System.Drawing.Color.Empty});
            // 
            // ctbar1
            // 
            this.ctbar1.Maximum = 100;
            // 
            // ctbar2
            // 
            this.ctbar2.Maximum = 127;
            this.ctbar2.Minimum = -128;
            // 
            // ctbar3
            // 
            this.ctbar3.Maximum = 127;
            this.ctbar3.Minimum = -128;
            // 
            // cnud1
            // 
            this.cnud1.Divider = new decimal(new int[] {
            75,
            0,
            0,
            65536});
            // 
            // cnud2
            // 
            this.cnud2.Divider = new decimal(new int[] {
            275,
            0,
            0,
            131072});
            this.cnud2.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.cnud2.Minimum = new decimal(new int[] {
            128,
            0,
            0,
            -2147483648});
            // 
            // cnud3
            // 
            this.cnud3.Divider = new decimal(new int[] {
            275,
            0,
            0,
            131072});
            this.cnud3.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.cnud3.Minimum = new decimal(new int[] {
            128,
            0,
            0,
            -2147483648});
            // 
            // ctbox1
            // 
            this.ctbox1.Maximum = 255F;
            // 
            // lbRng1
            // 
            this.lbRng1.Size = new System.Drawing.Size(35, 13);
            this.lbRng1.Text = "0-255";
            // 
            // lb1
            // 
            this.lb1.Size = new System.Drawing.Size(14, 13);
            this.lb1.Text = "L";
            // 
            // lb2
            // 
            this.lb2.Size = new System.Drawing.Size(14, 13);
            this.lb2.Text = "a";
            // 
            // lb3
            // 
            this.lb3.Size = new System.Drawing.Size(14, 13);
            this.lb3.Text = "b";
            // 
            // LabHorizontalView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(484, 153);
            this.Name = "LabHorizontalView";
            this.Text = "Lab";
            ((System.ComponentModel.ISupportInitialize)(this.hcbox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hcbox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hcbox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctbar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctbar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctbar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnud1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnud2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnud3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
