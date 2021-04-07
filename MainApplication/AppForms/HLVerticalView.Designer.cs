using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ColorMan.AppForms
{
    partial class HLVerticalView
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
            this.rectangleCB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rectangleCB.ColorCount = 7;
            this.rectangleCB.Dock = System.Windows.Forms.DockStyle.None;
            this.rectangleCB.Margin = new System.Windows.Forms.Padding(0);
            this.rectangleCB.Size = new System.Drawing.Size(60, 360);
            // 
            // HLVerticalView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(60, 360);
            this.Name = "HLVerticalView";
            ((System.ComponentModel.ISupportInitialize)(this.rectangleCB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
