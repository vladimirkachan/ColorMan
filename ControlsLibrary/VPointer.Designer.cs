using System.ComponentModel;
using System.Drawing;

namespace ColorMan.ControlsLibrary
{
    partial class VPointer
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
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // VPointer
            // 
            this.Name = "VPointer";
            this.Size = new System.Drawing.Size(36, 150);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
