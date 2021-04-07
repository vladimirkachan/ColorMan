using System.ComponentModel;
using System.Drawing;

namespace ColorMan.AppForms
{
    partial class HslHorizontalView
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
            this.hcbox1.ColorCount = 7;
            this.hcbox1.SetColors(new System.Drawing.Color[] {
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
            this.hcbox3.ColorCount = 3;
            this.hcbox3.SetColors(new System.Drawing.Color[] {
                System.Drawing.Color.Empty,
                System.Drawing.Color.Empty,
                System.Drawing.Color.Empty});
            // 
            // ctbar1
            // 
            this.ctbar1.Maximum = 360;
            // 
            // ctbar2
            // 
            this.ctbar2.Maximum = 100;
            // 
            // ctbar3
            // 
            this.ctbar3.Maximum = 100;
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
            // cnud2
            // 
            this.cnud2.Divider = new decimal(new int[] {
            75,
            0,
            0,
            65536});
            // 
            // cnud3
            // 
            this.cnud3.Divider = new decimal(new int[] {
            75,
            0,
            0,
            65536});
            // 
            // ctbox2
            // 
            this.ctbox2.Maximum = 255F;
            // 
            // ctbox3
            // 
            this.ctbox3.Maximum = 255F;
            // 
            // lbRng2
            // 
            this.lbRng2.Size = new System.Drawing.Size(35, 13);
            this.lbRng2.Text = "0-255";
            // 
            // lbRng3
            // 
            this.lbRng3.Size = new System.Drawing.Size(35, 13);
            this.lbRng3.Text = "0-255";
            // 
            // lb1
            // 
            this.lb1.Text = "H";
            // 
            // lb2
            // 
            this.lb2.Size = new System.Drawing.Size(15, 13);
            this.lb2.Text = "S";
            // 
            // lb3
            // 
            this.lb3.Size = new System.Drawing.Size(14, 13);
            this.lb3.Text = "L";
            // 
            // HslHorizontalView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(484, 153);
            this.Name = "HslHorizontalView";
            this.Text = "HSL";
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
