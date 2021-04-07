namespace ColorMan.AppControls
{
    partial class WheelSquareColorBox
    {
        /// <summary> 
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null) components.Dispose();
                if (backBrush != null) backBrush.Dispose();
                if (brush != null) brush.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Обязательный метод для поддержки конструктора - не изменяйте 
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.square = new ColorMan.AppControls.SquareColorBox();
            ((System.ComponentModel.ISupportInitialize)(this.square)).BeginInit();
            this.SuspendLayout();
            // 
            // square
            // 
            this.square.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.square.AutoColorSize = true;
            this.square.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.square.BrightnessUnderTheCursorFunc = null;
            this.square.BrushFunc = null;
            this.square.CenterColor = System.Drawing.Color.Empty;
            this.square.ColorCount = 2;
            this.square.ColorDiameter = 8;
            this.square.Increment1 = 0.01D;
            this.square.Increment2 = 0.01D;
            this.square.IsRightDowned = false;
            this.square.Location = new System.Drawing.Point(70, 70);
            this.square.Margin = new System.Windows.Forms.Padding(0);
            this.square.Name = "square";
            this.square.SelectedColorFunc = null;
            this.square.SelfPaint = false;
            this.square.Size = new System.Drawing.Size(160, 160);
            this.square.Space = null;
            this.square.TabIndex = 0;
            this.square.TabStop = false;
            this.square.UseIndent = true;
            this.square.Val1 = 0D;
            this.square.Val2 = 0D;
            this.square.ValueChanged += new System.EventHandler(this.SquareValueChanged);
            this.square.Layout += new System.Windows.Forms.LayoutEventHandler(this.square_Layout);
            // 
            // WheelSquareColorPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.square);
            this.DoubleBuffered = true;
            this.Name = "WheelSquareColorPicker";
            this.Size = new System.Drawing.Size(300, 300);
            ((System.ComponentModel.ISupportInitialize)(this.square)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        ColorMan.AppControls.SquareColorBox square;
    }
}
