using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ColorMan.AppForms
{
    partial class HLHorizontalView
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
            ((System.ComponentModel.ISupportInitialize)(this.rectangleCB)).BeginInit();
            this.SuspendLayout();
            // 
            // rectangleCB
            // 
            this.rectangleCB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rectangleCB.BackColor = System.Drawing.Color.Gray;
            this.rectangleCB.Dock = System.Windows.Forms.DockStyle.None;
            this.rectangleCB.Margin = new System.Windows.Forms.Padding(0);
            this.rectangleCB.Size = new System.Drawing.Size(360, 60);
            // 
            // HLHorizontalView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(360, 60);
            this.Name = "HLHorizontalView";
            ((System.ComponentModel.ISupportInitialize)(this.rectangleCB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

    }
}
