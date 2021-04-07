using System.ComponentModel;
using System.Drawing;

namespace ColorMan.AppForms
{
    partial class HslCircleView
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
            ((System.ComponentModel.ISupportInitialize)(this.cb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CB12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnud1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnud2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnud3)).BeginInit();
            this.pnlVals.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb3
            // 
            this.cb3.ColorCount = 3;
            this.cb3.SetColors(new System.Drawing.Color[] {
                System.Drawing.Color.Empty,
                System.Drawing.Color.Empty,
                System.Drawing.Color.Empty});
            // 
            // lb3
            // 
            this.lb3.Text = "L";
            // 
            // lb2
            // 
            this.lb2.Size = new System.Drawing.Size(15, 13);
            this.lb2.Text = "S";
            // 
            // lb1
            // 
            this.lb1.Size = new System.Drawing.Size(16, 13);
            this.lb1.Text = "H";
            // 
            // cnud1
            // 
            this.cnud1.Divider = new decimal(new int[] {
            2,
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
            // HslCircleView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(399, 296);
            this.Name = "HslCircleView";
            this.Text = "HSL";
            ((System.ComponentModel.ISupportInitialize)(this.cb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CB12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnud1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnud2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnud3)).EndInit();
            this.pnlVals.ResumeLayout(false);
            this.pnlVals.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
