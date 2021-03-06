using System.ComponentModel;
using System.Drawing;

namespace ColorMan.ControlsLibrary
{
    partial class HPointer
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
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.label1.Size = new System.Drawing.Size(23, 26);
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // HPointer
            // 
            this.Name = "HPointer";
            this.Size = new System.Drawing.Size(150, 26);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
