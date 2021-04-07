using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using ColorMan.ContractLibrary;
using ColorMan.ControlsLibrary;
using ColorMan.ExtensionLibrary;

namespace ColorMan.AppControls
{
    public class RectangleColorBox : BaseColorBox
    {
        protected const double Pi = Math.PI;
        public event EventHandler ValueChanged1, ValueChanged2;
        double val1, val2;
        readonly One one;
        readonly Two two;
        double increment1 = 0.01, increment2 = 0.01;
        Image colorImage;
        const int kr = 150;
        int r0, r1, r02;
        bool autoColorSize = true, useIndent = true;

        public double Val1
        {
            get { return val1; }
            set
            {
                val1 = value < 0d ? 0d : value > 1d ? 1d : value;
                OnValueChanged1(null);
            }
        }
        public double Val2
        {
            get { return val2; }
            set
            {
                val2 = value < 0d ? 0d : value > 1d ? 1d : value;
                OnValueChanged2(null);
            }
        }
        public double Increment1 { get { return increment1; } set { increment1 = value; } }
        public double Increment2 { get { return increment2; } set { increment2 = value; } }
        protected virtual double Xpos { get { return val1 * WX + Indent; } }
        protected virtual double Ypos { get { return HY - val2 * HY + Indent; } }
        public IComponentSubscriber Space { get; set; }
        public bool SelfPaint { get; set; }
        public override Cursor Cursor
        {
            get { return Inside ? CircleCursor : base.Cursor; }
            set { base.Cursor = value; }
        }
        public bool AutoColorSize { get { return autoColorSize; } set { autoColorSize = value; } }
        public bool UseIndent { get { return useIndent; } set { useIndent = value; } }
        public int ColorDiameter
        {
            get { return r02; }
            set
            {
                r02 = value;
                SetColorSize();
            }
        }
        public double WX { get { return Width - 2 * Indent; } }
        public double HY { get { return Height - 2 * Indent; } }
        public int Indent { get { return useIndent ? 8 : 0; } }

        public RectangleColorBox()
        {
            one = new One(this);
            two = new Two(this);
            ValueChanged += ColorBox_ValueChanged;
        }
        public virtual void InitBrush()
        {
            Brush1 = new LinearGradientBrush(new Point(0, Height - Indent), new Point(0, Indent - 1), Color.Empty,
                                            Color.Empty);
            SetColors(new Color[ColorCount]);
        }
        void ColorBox_ValueChanged(object sender, EventArgs e)
        {
            if (Space != null)
            {
                Space.UnsubscribeNewColor();
                one.OnNewValue();
                two.OnNewValue();
                Space.NewColor(null, null);
                Space.SubscribeNewColor();
            }
        }
        public void SetValIn(double v1, double v2)
        {
            ValueChanged -= ColorBox_ValueChanged;
            val1 = v1;
            val2 = v2;
            Invalidate();
            ValueChanged += ColorBox_ValueChanged;
        }
        public override void ToLeft()
        {
            Val1 -= increment1;
            Invalidate();
            one.OnNewValue();
        }
        public override void ToRight()
        {
            Val1 += increment1;
            Invalidate();
            one.OnNewValue();
        }
        public override void ToUp()
        {
            Val2 += increment2;
            Invalidate();
            two.OnNewValue();
        }
        public override void ToDown()
        {
            Val2 -= increment2;
            Invalidate();
            two.OnNewValue();
        }
        /// <summary>
        /// Вычисляет значения val1 [0.0-1.0] и val2 [0.0-1.0], соответствующие позиции курсора location
        /// </summary>
        /// <param name="location">location - текущая позиция курсора мыши</param>
        /// <returns>Возвращает PointF [ x: 0.0-1.0, y: 0.0-1.0 ]</returns>
        public virtual PointF ValsFromLocation(Point location)
        {
            return new PointF((float)((location.X - Indent) / WX).CutRange(0d, 1d),
                              (float)((HY - location.Y - Indent) / HY).CutRange(0d, 1d));
        }
        protected override void ValFromPosition()
        {
            Val1 = (MouseLocation.X - Indent) / WX;
            Val2 = (HY - MouseLocation.Y + Indent) / HY;
            OnValueChanged(null);
        }
        protected virtual void ScaleBrush()
        {
            Brush1 = new LinearGradientBrush(new Point(0, (int)HY), Point.Empty, Color.Empty, Color.Empty);

        }
        protected override void OnPaint(PaintEventArgs pe)
        {
            if (SelfPaint)
            {
                if (BrushFunc != null) pe.Graphics.FillRectangle(BrushFunc(), Indent, Indent, (float)WX, (float)HY);
            }
            else base.OnPaint(pe);
            DrawCursor();
            pe.Graphics.DrawImage(colorImage, (int)Math.Round(Xpos - 8, MidpointRounding.AwayFromZero),
                                  (int)Math.Round(Ypos - 8, MidpointRounding.AwayFromZero));
        }
        protected override void OnLayout(LayoutEventArgs levent)
        {
            if (WX <= 0 || HY <= 0) return;
            ScaleBrush();
            if (AutoColorSize) SetColorSize();
            Invalidate();
            base.OnLayout(levent);
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            IsRightDowned = e.Button == MouseButtons.Right;
            IsDowned = e.Button == MouseButtons.Left;
            if (IsDowned)
            {
                ValFromPosition();
                Invalidate();
            }
            base.OnMouseDown(e);
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            MouseLocation = e.Location;
            Inside = IsInside(r0);
            if (IsDowned)
            {
                IsRightDowned = false;
                ValFromPosition();
                Invalidate();
            }
            base.OnMouseMove(e);
        }
        protected override void OnMouseUp(MouseEventArgs e)
        {
            IsDowned = IsRightDowned = false;
            base.OnMouseUp(e);
        }
        protected override void OnMouseWheel(MouseEventArgs e)
        {
            Keys mod = ModifierKeys & Keys.Modifiers;
            bool positive = e.Delta > 0;
            if (mod == Keys.Shift)
            {
                if (positive) ToUp();
                else ToDown();
            }
            else
            {
                if (positive) ToRight();
                else ToLeft();
            }
            base.OnMouseWheel(e);
        }
        protected virtual bool IsInside(double delta)
        {
            int x = MouseLocation.X - Indent, y = MouseLocation.Y - Indent;
            return x > -delta && x < WX + delta && y > -delta && y < HY + delta;
        }
        void SetColorSize()
        {
            r1 = AutoColorSize ? (int)((WX + HY) / kr) : ColorDiameter / 2 - 1;
            r1 = r1 < 3 ? 3 : r1;
            r0 = r1 + 1;
            r02 = r0 << 1;
        }
        void DrawCursor()
        {
            Bitmap bmp = new Bitmap(16, 16);
            using (Graphics gr = Graphics.FromImage(bmp))
            {
                gr.FillEllipse(Brushes.White, 0, 0, 16, 16);
                gr.FillEllipse(Brushes.Black, 1, 1, 14, 14);
                if (SelectedColorFunc != null) gr.FillEllipse(new SolidBrush(SelectedColorFunc()), 3, 3, 10, 10);
            }
            if (colorImage != null) colorImage.Dispose();
            colorImage = bmp;
        }
        void OnValueChanged1(EventArgs e)
        {
            if (ValueChanged1 != null) ValueChanged1(this, e);
        }
        void OnValueChanged2(EventArgs e)
        {
            if (ValueChanged2 != null) ValueChanged2(this, e);
        }
        /// <summary>
        /// предоставляет доступ по предопределённым ключам "One" и "Two"
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public ILinkedItem<float> this[string name]
        {
            get
            {
                switch (name)
                {
                    case "One":
                        return one;
                    case "Two":
                        return two;
                    default:
                        return null;
                }
            }
        }

        class One : ILinkedItem<float>
        {
            readonly RectangleColorBox rectangle;
            public event EventHandler<LinkedItemEventArgs<float>> NewValue;
            public float Val { get { return (float)rectangle.val1; } }
            public One(RectangleColorBox rectangle)
            {
                this.rectangle = rectangle;
            }
            public void OnNewValue()
            {
                if (NewValue != null) NewValue(this, new LinkedItemEventArgs<float>(Val));
            }
            public void SetValIn(float val)
            {
                rectangle.SetValIn(val, rectangle.val2);
            }
        }
        class Two : ILinkedItem<float>
        {
            readonly RectangleColorBox rectangle;
            public event EventHandler<LinkedItemEventArgs<float>> NewValue;
            public float Val { get { return (float)rectangle.val2; } }
            public Two(RectangleColorBox rectangle)
            {
                this.rectangle = rectangle;
            }
            public void OnNewValue()
            {
                if (NewValue != null) NewValue(this, new LinkedItemEventArgs<float>(Val));
            }
            public void SetValIn(float val)
            {
                rectangle.SetValIn(rectangle.val1, val);
            }
        }
    }
}
