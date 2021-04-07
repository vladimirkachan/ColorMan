using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ColorMan.AppControls;

namespace ColorMan.AppForms
{
    partial class RectColorComponentView
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
            this.rectangleCB = new ColorMan.AppControls.RectangleColorBox();
            ((System.ComponentModel.ISupportInitialize)(this.rectangleCB)).BeginInit();
            this.SuspendLayout();
            // 
            // rectangleCB
            // 
            this.rectangleCB.AutoColorSize = true;
            this.rectangleCB.BrightnessUnderTheCursorFunc = null;
            this.rectangleCB.BrushFunc = null;
            this.rectangleCB.CenterColor = System.Drawing.Color.Empty;
            this.rectangleCB.ColorCount = 3;
            this.rectangleCB.ColorDiameter = 8;
            this.rectangleCB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rectangleCB.Increment1 = 0.01D;
            this.rectangleCB.Increment2 = 0.01D;
            this.rectangleCB.IsRightDowned = false;
            this.rectangleCB.Location = new System.Drawing.Point(0, 0);
            this.rectangleCB.Name = "rectangleCB";
            this.rectangleCB.SelectedColorFunc = null;
            this.rectangleCB.SelfPaint = false;
            this.rectangleCB.Size = new System.Drawing.Size(284, 261);
            this.rectangleCB.Space = null;
            this.rectangleCB.TabIndex = 42;
            this.rectangleCB.TabStop = false;
            this.rectangleCB.UseIndent = false;
            this.rectangleCB.Val1 = 0D;
            this.rectangleCB.Val2 = 0D;
            this.rectangleCB.LastValue += new System.EventHandler(this.rectangleCB_LastValue);
            this.rectangleCB.Paint += new System.Windows.Forms.PaintEventHandler(this.RectanglePaint);
            this.rectangleCB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rectangleCB_MouseDown);
            this.rectangleCB.MouseMove += new System.Windows.Forms.MouseEventHandler(this.rectangleCB_MouseMove);
            // 
            // RectColorComponentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.rectangleCB);
            this.Name = "RectColorComponentView";
            this.Controls.SetChildIndex(this.colorLabel2, 0);
            this.Controls.SetChildIndex(this.colorLabel1, 0);
            this.Controls.SetChildIndex(this.rectangleCB, 0);
            ((System.ComponentModel.ISupportInitialize)(this.rectangleCB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public RectangleColorBox rectangleCB;

    }
}
