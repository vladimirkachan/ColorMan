using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ColorMan.AppControls;
using ColorMan.ControlsLibrary;

namespace ColorMan.AppForms
{
    partial class WheelView
    {
        /// <summary>
        ///Требуется переменная конструктора.
        /// </summary>
        private IContainer components = null;
        internal WheelSquareColorBox WheelSquare1
        {
            get { return wheelSquare1; }
        }
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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(WheelView));
            this.wrap1 = new WrapControl();
            this.wheelSquare1 = new WheelSquareColorBox();
            ((ISupportInitialize)(this.cnud1)).BeginInit();
            ((ISupportInitialize)(this.cnud2)).BeginInit();
            ((ISupportInitialize)(this.cnud3)).BeginInit();
            this.pnlVals.SuspendLayout();
            this.wrap1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctb1
            // 
            this.ctb1.Visible = true;
            // 
            // pnlVals
            // 
            this.pnlVals.Location = new Point(308, 200);
            // 
            // colorControl1
            // 
            this.ColorLabel1.Location = new Point(349, 4);
            // 
            // colorControl2
            // 
            this.ColorLabel2.Location = new Point(369, 24);
            // 
            // wrap1
            // 
            this.wrap1.ActiveColor = SystemColors.MenuHighlight;
            this.wrap1.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom) 
            | AnchorStyles.Left) 
            | AnchorStyles.Right)));
            this.wrap1.BackColor = SystemColors.WindowFrame;
            this.wrap1.BackgroundImage = ((Image)(resources.GetObject("wrap1.BackgroundImage")));
            this.wrap1.ButtonOk = null;
            this.wrap1.Content = this.wheelSquare1;
            this.wrap1.Controls.Add(this.wheelSquare1);
            this.wrap1.Form = this;
            this.wrap1.LightingColor = Color.Gold;
            this.wrap1.Location = new Point(4, 4);
            this.wrap1.Margin = new Padding(0);
            this.wrap1.MaximumSize = new Size(721, 721);
            this.wrap1.MinimumSize = new Size(156, 156);
            this.wrap1.Name = "wrap1";
            this.wrap1.NoneColor = Color.Transparent;
            this.wrap1.Padding = new Padding(2);
            this.wrap1.Size = new Size(304, 304);
            this.wrap1.TabIndex = 0;
            // 
            // wheelSquare1
            // 
            this.wheelSquare1.BackColor = SystemColors.WindowFrame;
            this.wheelSquare1.ColorCount = 360;
            this.wheelSquare1.Dock = DockStyle.Fill;
            this.wheelSquare1.BrushFunc = null;
            this.wheelSquare1.Celsius = 0D;
            this.wheelSquare1.Increment = 0.002777778F;
            this.wheelSquare1.Inside = false;
            this.wheelSquare1.IsBlackCursor = false;
            this.wheelSquare1.Location = new Point(2, 2);
            this.wheelSquare1.Margin = new Padding(0);
            this.wheelSquare1.MaximumSize = new Size(717, 717);
            this.wheelSquare1.MinimumSize = new Size(152, 152);
            this.wheelSquare1.Name = "wheelSquare1";
            this.wheelSquare1.Size = new Size(300, 300);
            this.wheelSquare1.TabIndex = 52;
            this.wheelSquare1.Val = 0D;
            this.wheelSquare1.ValueChanged += new EventHandler(this.WheelValueChanged);
            // 
            // WheelView
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.ClientSize = new Size(439, 312);
            this.Controls.Add(this.wrap1);
            this.MaximumSize = new Size(872, 768);
            this.MinimumSize = new Size(308, 204);
            this.Name = "WheelView";
            this.Text = "WheelView";
            this.Controls.SetChildIndex(this.ColorLabel2, 0);
            this.Controls.SetChildIndex(this.ColorLabel1, 0);
            this.Controls.SetChildIndex(this.pnlVals, 0);
            this.Controls.SetChildIndex(this.wrap1, 0);
            ((ISupportInitialize)(this.cnud1)).EndInit();
            ((ISupportInitialize)(this.cnud2)).EndInit();
            ((ISupportInitialize)(this.cnud3)).EndInit();
            this.pnlVals.ResumeLayout(false);
            this.pnlVals.PerformLayout();
            this.wrap1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private WrapControl wrap1;
        protected WheelSquareColorBox wheelSquare1;
    }
}
