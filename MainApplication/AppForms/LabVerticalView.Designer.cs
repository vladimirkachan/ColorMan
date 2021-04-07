using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ColorMan.AppForms
{
    partial class LabVerticalView
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
            this.vcbox1.ColorCount = 9;
            this.vcbox1.SetColors(new System.Drawing.Color[] {
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
            // vcbox2
            // 
            this.vcbox2.ColorCount = 9;
            this.vcbox2.SetColors(new System.Drawing.Color[] {
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
            // vcbox3
            // 
            this.vcbox3.ColorCount = 9;
            this.vcbox3.SetColors(new System.Drawing.Color[] {
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
            // ctbox1
            // 
            this.ctbox1.Maximum = 255F;
            // 
            // cnud1
            // 
            this.cnud1.Divider = new decimal(new int[] {
            75,
            0,
            0,
            65536});
            this.cnud1.Margin = new System.Windows.Forms.Padding(0);
            this.cnud1.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // cnud2
            // 
            this.cnud2.Divider = new decimal(new int[] {
            275,
            0,
            0,
            131072});
            this.cnud2.Margin = new System.Windows.Forms.Padding(0);
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
            this.cnud3.Margin = new System.Windows.Forms.Padding(0);
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
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.Text = "L";
            // 
            // label2
            // 
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.Text = "a";
            // 
            // label3
            // 
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.Text = "b";
            // 
            // LabVerticalView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(161, 375);
            this.Name = "LabVerticalView";
            this.Text = "Lab";
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
