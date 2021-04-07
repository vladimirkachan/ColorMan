using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ColorMan.AppControls;
using ColorMan.ControlsLibrary;

namespace ColorMan.AppForms
{
    partial class HsvWheelTriangleView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HsvWheelTriangleView));
            this.wrap1 = new ColorMan.ControlsLibrary.WrapControl();
            this.picker = new ColorMan.AppControls.HsvWheelTriangleBox();
            this.wrapN3.SuspendLayout();
            this.wrapN2.SuspendLayout();
            this.wrapN1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cnud1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnud2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnud3)).BeginInit();
            this.pnlVals.SuspendLayout();
            this.wrap1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picker)).BeginInit();
            this.SuspendLayout();
            // 
            // lb3
            // 
            this.lb3.Size = new System.Drawing.Size(15, 13);
            this.lb3.Text = "V";
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
            // colorLabel1
            // 
            this.colorLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // colorLabel2
            // 
            this.colorLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // wrap1
            // 
            this.wrap1.ActiveColor = System.Drawing.SystemColors.MenuHighlight;
            this.wrap1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wrap1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.wrap1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("wrap1.BackgroundImage")));
            this.wrap1.ButtonOk = null;
            this.wrap1.Content = this.picker;
            this.wrap1.Controls.Add(this.picker);
            this.wrap1.Form = this;
            this.wrap1.LightingColor = System.Drawing.Color.Gold;
            this.wrap1.Location = new System.Drawing.Point(4, 4);
            this.wrap1.Margin = new System.Windows.Forms.Padding(0);
            this.wrap1.MaximumSize = new System.Drawing.Size(721, 721);
            this.wrap1.MinimumSize = new System.Drawing.Size(152, 152);
            this.wrap1.Name = "wrap1";
            this.wrap1.NoneColor = System.Drawing.SystemColors.WindowFrame;
            this.wrap1.Padding = new System.Windows.Forms.Padding(2);
            this.wrap1.Size = new System.Drawing.Size(304, 304);
            this.wrap1.TabIndex = 0;
            // 
            // picker
            // 
            this.picker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picker.Location = new System.Drawing.Point(2, 2);
            this.picker.Margin = new System.Windows.Forms.Padding(0);
            this.picker.MaximumSize = new System.Drawing.Size(717, 717);
            this.picker.MinimumSize = new System.Drawing.Size(148, 148);
            this.picker.Name = "picker";
            this.picker.Size = new System.Drawing.Size(300, 300);
            this.picker.Space = null;
            this.picker.TabIndex = 52;
            this.picker.TabStop = false;
            this.picker.WheelVal = 0F;
            // 
            // HsvWheelTriangleView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(391, 312);
            this.Controls.Add(this.wrap1);
            this.MaximumSize = new System.Drawing.Size(824, 768);
            this.MinimumSize = new System.Drawing.Size(256, 200);
            this.Name = "HsvWheelTriangleView";
            this.Text = "HSV";
            this.Controls.SetChildIndex(this.pnlVals, 0);
            this.Controls.SetChildIndex(this.colorLabel2, 0);
            this.Controls.SetChildIndex(this.colorLabel1, 0);
            this.Controls.SetChildIndex(this.wrap1, 0);
            this.wrapN3.ResumeLayout(false);
            this.wrapN2.ResumeLayout(false);
            this.wrapN1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cnud1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnud2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnud3)).EndInit();
            this.pnlVals.ResumeLayout(false);
            this.pnlVals.PerformLayout();
            this.wrap1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picker)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private WrapControl wrap1;
        internal HsvWheelTriangleBox picker;
    }
}
