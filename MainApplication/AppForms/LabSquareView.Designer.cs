using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ColorMan.AppControls;
using ColorMan.ControlsLibrary;

namespace ColorMan.AppForms
{
    partial class LabSquareView
    {
        /// <summary>
        ///Требуется переменная конструктора.
        /// </summary>
        private IContainer components = null;
        internal SquareColorBox SquareCb { get { return squareCB; } }
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LabSquareView));
            this.wrapS = new ColorMan.ControlsLibrary.WrapControl();
            this.squareCB = new ColorMan.AppControls.SquareColorBox();
            this.wrapL = new ColorMan.ControlsLibrary.WrapControl();
            this.linearCB = new ColorMan.ControlsLibrary.HColorBox();
            this.wrapN3.SuspendLayout();
            this.wrapN2.SuspendLayout();
            this.wrapN1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cnud1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnud2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnud3)).BeginInit();
            this.pnlVals.SuspendLayout();
            this.wrapS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.squareCB)).BeginInit();
            this.wrapL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.linearCB)).BeginInit();
            this.SuspendLayout();
            // 
            // lb3
            // 
            this.lb3.Text = "L";
            // 
            // lb2
            // 
            this.lb2.Text = "b";
            // 
            // lb1
            // 
            this.lb1.Text = "a";
            // 
            // wrapN3
            // 
            this.wrapN3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("wrapN3.BackgroundImage")));
            // 
            // wrapN2
            // 
            this.wrapN2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("wrapN2.BackgroundImage")));
            // 
            // wrapN1
            // 
            this.wrapN1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("wrapN1.BackgroundImage")));
            // 
            // cnud1
            // 
            this.cnud1.AccelerationIncrement = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.cnud1.Divider = new decimal(new int[] {
            275,
            0,
            0,
            131072});
            this.cnud1.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.cnud1.Minimum = new decimal(new int[] {
            128,
            0,
            0,
            -2147483648});
            // 
            // cnud2
            // 
            this.cnud2.AccelerationIncrement = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.cnud2.Divider = new decimal(new int[] {
            275,
            0,
            0,
            131072});
            this.cnud2.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.cnud2.Minimum = new decimal(new int[] {
            128,
            0,
            0,
            -2147483648});
            // 
            // cnud3
            // 
            this.cnud3.Divider = new decimal(new int[] {
            75,
            0,
            0,
            65536});
            // 
            // pnlVals
            // 
            this.pnlVals.Location = new System.Drawing.Point(269, 192);
            // 
            // colorLabel1
            // 
            this.colorLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.colorLabel1.Location = new System.Drawing.Point(284, 4);
            // 
            // colorLabel2
            // 
            this.colorLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.colorLabel2.Location = new System.Drawing.Point(304, 24);
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
            this.wrapS.Content = this.squareCB;
            this.wrapS.Controls.Add(this.squareCB);
            this.wrapS.Form = this;
            this.wrapS.LightingColor = System.Drawing.Color.Gold;
            this.wrapS.Location = new System.Drawing.Point(4, 4);
            this.wrapS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 2);
            this.wrapS.MaximumSize = new System.Drawing.Size(693, 693);
            this.wrapS.MinimumSize = new System.Drawing.Size(124, 124);
            this.wrapS.Name = "wrapS";
            this.wrapS.NoneColor = System.Drawing.SystemColors.WindowFrame;
            this.wrapS.Padding = new System.Windows.Forms.Padding(2);
            this.wrapS.Size = new System.Drawing.Size(264, 264);
            this.wrapS.TabIndex = 0;
            // 
            // squareCB
            // 
            this.squareCB.AutoColorSize = true;
            this.squareCB.BrightnessUnderTheCursorFunc = null;
            this.squareCB.BrushFunc = null;
            this.squareCB.CenterColor = System.Drawing.Color.Empty;
            this.squareCB.ColorCount = 5;
            this.squareCB.ColorDiameter = 8;
            this.squareCB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.squareCB.Increment1 = 0.01D;
            this.squareCB.Increment2 = 0.01D;
            this.squareCB.IsRightDowned = false;
            this.squareCB.Location = new System.Drawing.Point(2, 2);
            this.squareCB.Margin = new System.Windows.Forms.Padding(0);
            this.squareCB.MaximumSize = new System.Drawing.Size(689, 689);
            this.squareCB.MinimumSize = new System.Drawing.Size(120, 120);
            this.squareCB.Name = "squareCB";
            this.squareCB.SelectedColorFunc = null;
            this.squareCB.SelfPaint = false;
            this.squareCB.Size = new System.Drawing.Size(260, 260);
            this.squareCB.Space = null;
            this.squareCB.TabIndex = 51;
            this.squareCB.TabStop = false;
            this.squareCB.UseIndent = true;
            this.squareCB.Val1 = 0D;
            this.squareCB.Val2 = 0D;
            this.squareCB.ValueChanged += new System.EventHandler(this.SquareValueChanged);
            this.squareCB.Paint += new System.Windows.Forms.PaintEventHandler(this.squareCB_Paint);
            this.squareCB.Layout += new System.Windows.Forms.LayoutEventHandler(this.squareCB_Layout);
            // 
            // wrapL
            // 
            this.wrapL.ActiveColor = System.Drawing.SystemColors.MenuHighlight;
            this.wrapL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wrapL.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.wrapL.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("wrapL.BackgroundImage")));
            this.wrapL.ButtonOk = null;
            this.wrapL.Content = this.linearCB;
            this.wrapL.Controls.Add(this.linearCB);
            this.wrapL.Form = this;
            this.wrapL.LightingColor = System.Drawing.Color.Gold;
            this.wrapL.Location = new System.Drawing.Point(8, 272);
            this.wrapL.Margin = new System.Windows.Forms.Padding(4, 2, 4, 4);
            this.wrapL.MaximumSize = new System.Drawing.Size(685, 24);
            this.wrapL.MinimumSize = new System.Drawing.Size(124, 24);
            this.wrapL.Name = "wrapL";
            this.wrapL.NoneColor = System.Drawing.SystemColors.WindowFrame;
            this.wrapL.Padding = new System.Windows.Forms.Padding(2);
            this.wrapL.Size = new System.Drawing.Size(256, 24);
            this.wrapL.TabIndex = 1;
            // 
            // linearCB
            // 
            this.linearCB.BrightnessUnderTheCursorFunc = null;
            this.linearCB.BrushFunc = null;
            this.linearCB.CenterColor = System.Drawing.Color.Empty;
            this.linearCB.ColorCount = 9;
            this.linearCB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linearCB.Increment = 0.01F;
            this.linearCB.IsRightDowned = false;
            this.linearCB.Location = new System.Drawing.Point(2, 2);
            this.linearCB.Margin = new System.Windows.Forms.Padding(0);
            this.linearCB.MaximumSize = new System.Drawing.Size(681, 20);
            this.linearCB.MinimumSize = new System.Drawing.Size(120, 20);
            this.linearCB.Name = "linearCB";
            this.linearCB.SelectedColorFunc = null;
            this.linearCB.Size = new System.Drawing.Size(252, 20);
            this.linearCB.TabIndex = 51;
            this.linearCB.TabStop = false;
            this.linearCB.Val = 0F;
            this.linearCB.ValueChanged += new System.EventHandler(this.LinearValueChanged);
            // 
            // LabSquareView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(351, 300);
            this.Controls.Add(this.wrapL);
            this.Controls.Add(this.wrapS);
            this.MaximumSize = new System.Drawing.Size(800, 768);
            this.MinimumSize = new System.Drawing.Size(231, 199);
            this.Name = "LabSquareView";
            this.Text = "Lab";
            this.Controls.SetChildIndex(this.pnlVals, 0);
            this.Controls.SetChildIndex(this.colorLabel2, 0);
            this.Controls.SetChildIndex(this.colorLabel1, 0);
            this.Controls.SetChildIndex(this.wrapS, 0);
            this.Controls.SetChildIndex(this.wrapL, 0);
            this.wrapN3.ResumeLayout(false);
            this.wrapN2.ResumeLayout(false);
            this.wrapN1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cnud1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnud2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnud3)).EndInit();
            this.pnlVals.ResumeLayout(false);
            this.pnlVals.PerformLayout();
            this.wrapS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.squareCB)).EndInit();
            this.wrapL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.linearCB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private WrapControl wrapS;
        private WrapControl wrapL;
        private HColorBox linearCB;
        SquareColorBox squareCB;
    }
}
