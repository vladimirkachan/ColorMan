using System.ComponentModel;
using System.Drawing;

namespace ColorMan.AppForms
{
    partial class HsvVerticalView
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
            ((System.ComponentModel.ISupportInitialize)(this.vcbox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctbar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vcbox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctbar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vcbox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctbar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnud1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnud2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnud3)).BeginInit();
            this.SuspendLayout();
            // 
            // vcbox1
            // 
            this.vcbox1.ColorCount = 7;
            this.vcbox1.SetColors(new System.Drawing.Color[] {
                System.Drawing.Color.Empty,
                System.Drawing.Color.Empty,
                System.Drawing.Color.Empty,
                System.Drawing.Color.Empty,
                System.Drawing.Color.Empty,
                System.Drawing.Color.Empty,
                System.Drawing.Color.Empty});
            // 
            // cnud1
            // 
            this.cnud1.AccelerationIncrement = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.cnud1.Divider = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.cnud1.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            // 
            // ctbox2
            // 
            this.ctbox2.Maximum = 255F;
            // 
            // cnud2
            // 
            this.cnud2.Divider = new decimal(new int[] {
            75,
            0,
            0,
            65536});
            this.cnud2.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // ctbox3
            // 
            this.ctbox3.Maximum = 255F;
            // 
            // cnud3
            // 
            this.cnud3.Divider = new decimal(new int[] {
            75,
            0,
            0,
            65536});
            this.cnud3.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.Text = "H";
            // 
            // label2
            // 
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.Text = "S";
            // 
            // label3
            // 
            this.label3.Text = "V";
            // 
            // HsvVerticalView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(161, 375);
            this.Name = "HsvVerticalView";
            this.Text = "HSV";
            ((System.ComponentModel.ISupportInitialize)(this.vcbox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctbar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vcbox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctbar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vcbox3)).EndInit();
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
