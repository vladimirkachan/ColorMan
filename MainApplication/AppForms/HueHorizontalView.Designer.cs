using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

using ColorMan.ControlsLibrary;

namespace ColorMan.AppForms
{
    partial class HueHorizontalView
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
            this.colorBox = new HColorBox();
            ((System.ComponentModel.ISupportInitialize)(this.colorBox)).BeginInit();
            this.SuspendLayout();
            // 
            // colorBox
            // 
            this.colorBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.colorBox.CenterColor = System.Drawing.Color.Empty;
            this.colorBox.ColorCount = 7;
            this.colorBox.SetColors(new System.Drawing.Color[] {
                System.Drawing.Color.Empty,
                System.Drawing.Color.Empty,
                System.Drawing.Color.Empty,
                System.Drawing.Color.Empty,
                System.Drawing.Color.Empty,
                System.Drawing.Color.Empty,
                System.Drawing.Color.Empty});
            this.colorBox.BrushFunc = null;
            this.colorBox.Increment = 0.01F;
            this.colorBox.IsRightDowned = false;
            this.colorBox.Location = new System.Drawing.Point(0, 0);
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(360, 20);
            this.colorBox.TabIndex = 42;
            this.colorBox.TabStop = false;
            this.colorBox.Val = 0F;
            this.colorBox.LastValue += new System.EventHandler(this.colorBox_LastValue);
            this.colorBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.colorBox_MouseDown);
            this.colorBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.colorBox_MouseMove);
            // 
            // HueHorizontalView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(360, 30);
            this.Controls.Add(this.colorBox);
            this.Name = "HueHorizontalView";
            this.Controls.SetChildIndex(this.ColorLabel2, 0);
            this.Controls.SetChildIndex(this.ColorLabel1, 0);
            this.Controls.SetChildIndex(this.colorBox, 0);
            ((System.ComponentModel.ISupportInitialize)(this.colorBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private HColorBox colorBox;
    }
}
