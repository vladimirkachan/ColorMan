namespace ColorMan.AppForms
{
    partial class CircleView
    {
        /// <summary>
        ///Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        internal ColorMan.AppControls.CircleColorBox CB12 { get { return cb12; } }
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CircleView));
            this.wrapS = new ColorMan.ControlsLibrary.WrapControl();
            this.cb12 = new ColorMan.AppControls.CircleColorBox();
            this.wrapL = new ColorMan.ControlsLibrary.WrapControl();
            this.cb3 = new ColorMan.ControlsLibrary.HColorBox();
            ((System.ComponentModel.ISupportInitialize)(this.cnud1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnud2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnud3)).BeginInit();
            this.pnlVals.SuspendLayout();
            this.wrapS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cb12)).BeginInit();
            this.wrapL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cb3)).BeginInit();
            this.SuspendLayout();
            // 
            // wrapS
            // 
            this.wrapS.ActiveColor = System.Drawing.SystemColors.MenuHighlight;
            this.wrapS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wrapS.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.wrapS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("wrapS.BackgroundImage")));
            this.wrapS.ButtonOk = null;
            this.wrapS.Content = this.cb12;
            this.wrapS.Controls.Add(this.cb12);
            this.wrapS.Form = this;
            this.wrapS.LightingColor = System.Drawing.Color.Gold;
            this.wrapS.Location = new System.Drawing.Point(4, 4);
            this.wrapS.MaximumSize = new System.Drawing.Size(691, 691);
            this.wrapS.MinimumSize = new System.Drawing.Size(129, 129);
            this.wrapS.Name = "wrapS";
            this.wrapS.NoneColor = System.Drawing.SystemColors.WindowFrame;
            this.wrapS.Padding = new System.Windows.Forms.Padding(2);
            this.wrapS.Size = new System.Drawing.Size(260, 260);
            this.wrapS.TabIndex = 0;
            // 
            // cb12
            // 
            this.cb12.AutoColorSize = true;
            this.cb12.BrightnessUnderTheCursorFunc = null;
            this.cb12.BrushFunc = null;
            this.cb12.CenterColor = System.Drawing.Color.Empty;
            this.cb12.ColorCount = 360;
            this.cb12.ColorDiameter = 8;
            this.cb12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb12.GС = 0D;
            this.cb12.Increment1 = 0.01D;
            this.cb12.Increment2 = 0.01D;
            this.cb12.IsRightDowned = false;
            this.cb12.Location = new System.Drawing.Point(2, 2);
            this.cb12.Margin = new System.Windows.Forms.Padding(0);
            this.cb12.MaximumSize = new System.Drawing.Size(687, 687);
            this.cb12.MinimumSize = new System.Drawing.Size(125, 125);
            this.cb12.Name = "cb12";
            this.cb12.SelectedColorFunc = null;
            this.cb12.SelfPaint = true;
            this.cb12.Size = new System.Drawing.Size(256, 256);
            this.cb12.Space = null;
            this.cb12.TabIndex = 51;
            this.cb12.TabStop = false;
            this.cb12.UseIndent = true;
            this.cb12.Val1 = 0D;
            this.cb12.Val2 = 0D;
            this.cb12.Click += new System.EventHandler(this.CB12ValueChanged);
            // 
            // wrapL
            // 
            this.wrapL.ActiveColor = System.Drawing.SystemColors.MenuHighlight;
            this.wrapL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wrapL.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.wrapL.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("wrapL.BackgroundImage")));
            this.wrapL.ButtonOk = null;
            this.wrapL.Content = this.cb3;
            this.wrapL.Controls.Add(this.cb3);
            this.wrapL.Form = this;
            this.wrapL.LightingColor = System.Drawing.Color.Gold;
            this.wrapL.Location = new System.Drawing.Point(8, 268);
            this.wrapL.MaximumSize = new System.Drawing.Size(685, 24);
            this.wrapL.MinimumSize = new System.Drawing.Size(126, 24);
            this.wrapL.Name = "wrapL";
            this.wrapL.NoneColor = System.Drawing.SystemColors.WindowFrame;
            this.wrapL.Padding = new System.Windows.Forms.Padding(2);
            this.wrapL.Size = new System.Drawing.Size(252, 24);
            this.wrapL.TabIndex = 1;
            // 
            // cb3
            // 
            this.cb3.BrightnessUnderTheCursorFunc = null;
            this.cb3.BrushFunc = null;
            this.cb3.CenterColor = System.Drawing.Color.Empty;
            this.cb3.ColorCount = 2;
            this.cb3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb3.Increment = 0.01F;
            this.cb3.IsRightDowned = false;
            this.cb3.Location = new System.Drawing.Point(2, 2);
            this.cb3.Margin = new System.Windows.Forms.Padding(0);
            this.cb3.MaximumSize = new System.Drawing.Size(681, 20);
            this.cb3.MinimumSize = new System.Drawing.Size(122, 20);
            this.cb3.Name = "cb3";
            this.cb3.SelectedColorFunc = null;
            this.cb3.Size = new System.Drawing.Size(248, 20);
            this.cb3.TabIndex = 51;
            this.cb3.TabStop = false;
            this.cb3.Val = 0F;
            this.cb3.Click += new System.EventHandler(this.CB3ValueChanged);
            // 
            // CircleView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(399, 296);
            this.Controls.Add(this.wrapL);
            this.Controls.Add(this.wrapS);
            this.Name = "CircleView";
            this.Text = "CircleView";
            this.Controls.SetChildIndex(this.colorLabel2, 0);
            this.Controls.SetChildIndex(this.colorLabel1, 0);
            this.Controls.SetChildIndex(this.pnlVals, 0);
            this.Controls.SetChildIndex(this.wrapS, 0);
            this.Controls.SetChildIndex(this.wrapL, 0);
            ((System.ComponentModel.ISupportInitialize)(this.cnud1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnud2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnud3)).EndInit();
            this.pnlVals.ResumeLayout(false);
            this.pnlVals.PerformLayout();
            this.wrapS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cb12)).EndInit();
            this.wrapL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cb3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ControlsLibrary.WrapControl wrapS;
        private ControlsLibrary.WrapControl wrapL;
        protected AppControls.CircleColorBox cb12;
        protected ControlsLibrary.HColorBox cb3;
    }
}
