using System.ComponentModel;
using System.Drawing;

namespace ColorMan.AppForms
{
    partial class RgbHorizontalView
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
            // cnud1
            // 
            this.cnud1.DecimalPlaces = 0;
            this.cnud1.Divider = new decimal(new int[] {
            275,
            0,
            0,
            131072});
            this.cnud1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // cnud2
            // 
            this.cnud2.DecimalPlaces = 0;
            this.cnud2.Divider = new decimal(new int[] {
            275,
            0,
            0,
            131072});
            this.cnud2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // cnud3
            // 
            this.cnud3.DecimalPlaces = 0;
            this.cnud3.Divider = new decimal(new int[] {
            275,
            0,
            0,
            131072});
            this.cnud3.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // RgbHorizontalView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(484, 153);
            this.Name = "RgbHorizontalView";
            this.Text = "RGB";
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
