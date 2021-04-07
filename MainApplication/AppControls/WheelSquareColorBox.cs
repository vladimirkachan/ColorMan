using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using ColorMan.ContractLibrary;
using ColorMan.ControlsLibrary;

namespace ColorMan.AppControls
{
    public partial class WheelSquareColorBox : UserControl, ILinkedItem<float>, IDirectedCrement
    {
        const double Pi = Math.PI;
        double val;
        int side;
        public event EventHandler ValueChanged;
        public event EventHandler LastValue;
        public event EventHandler<LinkedItemEventArgs<float>> NewValue;
        int colorCount = 360;
        PointF[] points = new PointF[360];
        Color[] colors = new Color[360];
        PathGradientBrush brush;
        SolidBrush backBrush;
        float increment = 1f / 360;

        public SquareColorBox Square1 { get { return square; } }
        float ILinkedItem<float>.Val { get { return (float)val; } }
        public double Val
        {
            get { return val; }
            set
            {
                val = value < 0d ? 0d : value > 1d ? 1d : value;
                Invalidate();
                OnValueChanged(null);
            }
        }
        double S { get { return Width - 1d; } }
        double D { get { return 0.1 * S; } }
        public double Celsius { get { return Val * 360; } set { Val = value / 360; } }
        double Radian { get { return 2 * Pi * Val; } set { Val = value / (2 * Pi); } }
        double R1 { get { return S / 2d; } }
        public Func<Brush> BrushFunc { get; set; }
        bool IsDowned { get; set; }
        public bool IsBlackCursor { get; set; }

        public Color CenterColor
        {
            get { return brush == null ? Color.Empty : brush.CenterColor; }
            set { if (brush != null) brush.CenterColor = value; }
        }
        public int ColorCount { get { return colorCount; } set { SetColorCount(value); } }
        public bool Inside { get; set; }
        public Cursor CircleCursor { get; set; }
        public override Cursor Cursor
        {
            get {return IsDowned || !Inside ? base.Cursor : CircleCursor; }
            set { base.Cursor = value; }
        }
        public float Increment { get { return increment; } set { increment = value; } }

        public WheelSquareColorBox()
        {
            InitializeComponent();
            ValueChanged += @this_ValueChanged;
            Square1.InitBrush();
            CircleCursor = new Cursor(GetType(), "DefaultCircle.cur");
        }

        public Color[] GetSurroundColors()
        {
            return colors;
        }
        double Rad(float x, float y)
        {
            return Math.Atan2(y - R1, x - R1);
        }
        public void SetValIn(float value)
        {
            ValueChanged -= @this_ValueChanged;
            Val = value;
            ValueChanged += @this_ValueChanged;
        }
        public void InitBrush()
        {
            AssignPoints();
            brush = new PathGradientBrush(points);
            backBrush = new SolidBrush(BackColor);
        }
        public PathGradientBrush UpdatedBrushByColors()
        {
            brush.SurroundColors = colors;
            return brush;
        }
        void AssignPoints()
        {
            Func<int, double> rd = i => i * Pi / 180;
            Func<double, float> df = x => Convert.ToSingle(Math.Round(x));
            for (int i = 0; i < 360; i++)
            {
                int j = (270 + i) % 360;
                double dx = R1 * Math.Cos(rd(j)), dy = R1 * Math.Sin(rd(j));
                points[i] = new PointF(df(R1 + dx), df(R1 + dy));
            }
        }
        void SetColorCount(int value)
        {
            colorCount = value;
            points = new PointF[colorCount];
            colors = new Color[colorCount];
        }
        void @this_ValueChanged(object sender, EventArgs e)
        {
            OnNewValue();
        }
        void OnValueChanged(EventArgs e)
        {
            if (ValueChanged != null) ValueChanged(this, e);
        }
        void OnNewValue()
        {
            if (NewValue != null) NewValue(this, new LinkedItemEventArgs<float>((float)val));
        }
        void OnLastValue(EventArgs e)
        {
            if (LastValue != null) LastValue(this, e);
        }
        void ValsFromPosition(int x, int y)
        {
            Radian = (Math.Atan2(y - R1, x - R1) + 2.5 * Pi) % (2 * Pi);
        }
        bool IsInside(int x, int y)
        {
            double r = Math.Sqrt(Math.Pow(x - R1, 2) + Math.Pow(y - R1, 2));
            return r <= R1 && r >= R1 - D;
        }
        void DrawCursor(Graphics graphics)
        {
            Func<double, int> round = v => (int)Math.Round(v, MidpointRounding.AwayFromZero);
            double r = R1 - D, g2 = Radian - Pi, h1 = 1.5, h2 = 2.5, s = 1.0, cos2 = Math.Cos(g2), sin2 = Math.Sin(g2),
                   lx1 = X(r + s), ly1 = Y(r + s), lx2 = X(R1 - s), ly2 = Y(R1 - s), mx1 = X(r), my1 = Y(r), mx2 = X(R1),
                   my2 = Y(R1);

            int ax = round(h1 * cos2 + lx1), ay = round(h1 * sin2 + ly1), bx = round(h1 * cos2 + lx2),
                by = round(h1 * sin2 + ly2), cx = round(lx1 - h1 * cos2), cy = round(ly1 - h1 * sin2),
                dx = round(lx2 - h1 * cos2), dy = round(ly2 - h1 * sin2), px = round(h2 * cos2 + mx1),
                py = round(h2 * sin2 + my1), rx = round(h2 * cos2 + mx2), ry = round(h2 * sin2 + my2),
                sx = round(mx1 - h2 * cos2), sy = round(my1 - h2 * sin2), tx = round(mx2 - h2 * cos2),
                ty = round(my2 - h2 * sin2);

            graphics.DrawLine(Pens.Black, ax, ay, bx, by);
            graphics.DrawLine(Pens.Black, cx, cy, dx, dy);
            graphics.DrawLine(Pens.Black, ax, ay, cx, cy);
            graphics.DrawLine(Pens.Black, bx, by, dx, dy);

            graphics.DrawLine(Pens.White, px, py, rx, ry);
            graphics.DrawLine(Pens.White, sx, sy, tx, ty);
            graphics.DrawLine(Pens.White, px, py, sx, sy);
            graphics.DrawLine(Pens.White, rx, ry, tx, ty);
        }
        double X(double r)
        {
            return R1 + r * Math.Cos(Radian - Pi / 2);
        }
        double Y(double r)
        {
            return R1 + r * Math.Sin(Radian - Pi / 2);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            int s = (int)Math.Round(S, MidpointRounding.AwayFromZero);
            if (BrushFunc != null) e.Graphics.FillEllipse(BrushFunc(), 0, 0, s, s);
            int d = (int)Math.Round(D, MidpointRounding.AwayFromZero),
                s2 = (int)Math.Round(S - 2 * D, MidpointRounding.AwayFromZero);
            if (backBrush != null) e.Graphics.FillEllipse(backBrush, d, d, s2, s2);
            DrawCursor(e.Graphics);
        }
        protected override void OnLayout(LayoutEventArgs e)
        {
            side = (int)Math.Round((Width + Height) / 2d, MidpointRounding.AwayFromZero);
            Size = new Size(side, side);
            int side2 = (int)(side * 8 / 15d);
            Square1.Size = new Size(side2, side2);
            int loc2 = (int)(side * 7 / 30d);
            Square1.Location = new Point(loc2, loc2);
            base.OnLayout(e);
            Invalidate();
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            int x = e.X, y = e.Y;
            IsDowned = IsInside(x, y) && e.Button == MouseButtons.Left;
            if (IsDowned) ValsFromPosition(x, y);
            base.OnMouseDown(e);
            OnLastValue(e);
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            int x = e.X, y = e.Y;
            Inside = IsInside(x, y);
            Cursor = Inside ? CircleCursor : Cursors.Default;
            if (IsDowned) ValsFromPosition(x, y);
            base.OnMouseMove(e);
        }
        protected override void OnMouseUp(MouseEventArgs e)
        {
            IsDowned = false;
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
            else if (mod == Keys.Control)
            {
                if (positive) ToRight();
                else ToLeft();
            }
            else Val += Math.Sign(e.Delta) * Increment;
            base.OnMouseWheel(e);
        }
        public void SquareValueChanged(object sender, EventArgs e)
        {
            Invalidate();
        }
        private void square_Layout(object sender, LayoutEventArgs e)
        {
            Square1.InitBrush();
        }
        public void ToUp()
        {
            Square1.ToUp();
        }
        public void ToDown()
        {
            Square1.ToDown();
        }
        public void ToLeft()
        {
            Square1.ToLeft();
        }
        public void ToRight()
        {
            Square1.ToRight();
        }
    }
}
