using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using ColorMan.ColorSpaces;
using ColorMan.ContractLibrary;
using ColorMan.ControlsLibrary;

namespace ColorMan.AppControls
{
    public class HsvWheelTriangleBox : PictureBox, IDirectedCrement
    {
        const double Pi = Math.PI, IncrementW = 1d / 360;
        static readonly float triangleCenter = (float)((Math.Tan(Pi / 3) - Math.Tan(Pi / 6)) / Math.Tan(Pi / 3));
        readonly Wheel wheel;
        readonly Triangle triangle;
        int side;

        public float WheelVal { get { return (float)wheel.Val; } set { wheel.SetValIn(value); } }
        Item AItem { get { return triangle.AItem; } }
        Item HItem { get { return triangle.HItem; } }
        double R1 { get { return wheel.R1; } }
        double R2 { get { return wheel.R2; } }
        public ILinkedItem<float> IwheelItem { get { return wheel; } }
        public ILinkedItem<float> Iaitem { get { return AItem; } }
        public ILinkedItem<float> Ihitem { get { return HItem; } }
        public IComponentSubscriber Space { get { return triangle.Space; } set { triangle.Space = value; } }
        public override Cursor Cursor
        {
            get
            {
                if (!wheel.IsDowned && !triangle.IsDowned)
                    if (wheel.Inside) return wheel.Cursor;
                    else if (triangle.Inside) return triangle.Cursor;
                return base.Cursor;
            }
            set { base.Cursor = value; }
        }

        public HsvWheelTriangleBox()
        {
            wheel = new Wheel(this);
            triangle = new Triangle(this);
            wheel.InnerValueChanged += wheel_InnerValueChanged;
        }
        public void SetColorBoxesBrushes()
        {
            wheel.InitBrush();
            wheel.BrushFunc = () =>
            {
                float s = (float)AItem.Val, v = (float)HItem.Val;
                for (int i = 0; i < wheel.ColorCount; i++) wheel.GetColors()[i] = Hsv.FromHsv(i, s, v);
                wheel.CenterColor = Hsv.FromHsv(0f, 0f, v);
                return wheel.UpdatedBrush();
            };
            triangle.BrushFunc = () =>
            {
                triangle.CenterColor = Hsv.FromHsv(360 * WheelVal, 0.5f, triangleCenter);
                triangle.GetColors()[0] = Hsv.FromHsv(WheelVal * 360, 1f, 1f);
                triangle.GetColors()[1] = Hsv.White;
                triangle.GetColors()[2] = Hsv.Black;
                return triangle.UpdatedBrush();
            };
            triangle.BrightnessUnderTheCursorFunc = loc =>
            {
                PointF vals = triangle.ValsFromLocation(loc);
                return Hsv.FromHsv(WheelVal * 360, vals.X, vals.Y).GetBrightness();
            };
        }
        void wheel_InnerValueChanged(object sender, EventArgs e)
        {
            triangle.AssignPoints();
        }
        protected override void OnLayout(LayoutEventArgs levent)
        {
            side = Width != side ? Width : Height;
            Size = new Size(side, side);
            wheel.InitBrush();
            triangle.AssignPoints();
            triangle.InitBrush();
            base.OnLayout(levent);
            Invalidate();
        }
        public void ToUp()
        {
            triangle.ToUp();
        }
        public void ToDown()
        {
            triangle.ToDown();
        }
        public void ToLeft()
        {
            triangle.ToLeft();
        }
        public void ToRight()
        {
            triangle.ToRight();
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
            else wheel.Val += Math.Sign(e.Delta) * IncrementW;
            base.OnMouseWheel(e);
        }
        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            History.Instance.SetCurrentValue(TwoColorton.Instance.Space1);
        }

        class Triangle : BaseColorBox
        {
            readonly Item aItem;
            readonly Item hItem;
            readonly HsvWheelTriangleBox picker;
            readonly Point[] vertex = new Point[3];
            const double IncrementH = 0.01, IncrementA = 0.01;

            public IComponentSubscriber Space { get; set; }
            public Item AItem { get { return aItem; } }
            public Item HItem { get { return hItem; } }
            PathGradientBrush Brush { get { return (PathGradientBrush)Brush1; } }
            double R1 { get { return picker.R1; } }
            double R2 { get { return picker.R2; } }
            double Side { get { return 3 * R2 / Math.Sqrt(3); } }

            public Triangle(HsvWheelTriangleBox picker)
            {
                this.picker = picker;
                aItem = new Item(picker);
                hItem = new Item(picker);
                RechangeColorCount(3);
                picker.Paint += PickerTriangle_Paint;
                picker.MouseDown += PickerTriangle_MouseDown;
                picker.MouseMove += PickerTriangle_MouseMove;
                picker.MouseUp += PickerTriangle_MouseUp;
            }

            public virtual void InitBrush()
            {
                Brush1 = new PathGradientBrush(vertex);
            }
            public override Brush UpdatedBrush()
            {
                InitBrush();
                Brush.CenterColor = CenterColor;
                Brush.SurroundColors = GetColors();
                return Brush1;
            }
            public void AssignPoints()
            {
                double g = picker.WheelVal * 2 * Pi - Pi / 2;
                for (int i = 0; i < 3; i++) vertex[i] = VertexByAngle(g + i * 2 * Pi / 3);
            }
            Point VertexByAngle(double rad)
            {
                Func<double, int> round = v => (int)Math.Round(v, MidpointRounding.AwayFromZero);
                int x = round(R1 + R2 * Math.Cos(rad)), y = round(R1 + R2 * Math.Sin(rad));
                return new Point(x, y);
            }
            bool IsInSide()
            {
                GraphicsPath path = new GraphicsPath();
                path.AddPolygon(vertex);
                return path.IsVisible(MouseLocation);
            }
            static double Distance(PointF p1, PointF p2)
            {
                return Math.Sqrt(Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2));
            }
            static PointF Middle(PointF p1, PointF p2)
            {
                return new PointF((p1.X + p2.X) / 2, (p1.Y + p2.Y) / 2);
            }
            static double Semiperimeter(PointF p1, PointF p2, PointF p3)
            {
                return (Distance(p1, p2) + Distance(p2, p3) + Distance(p3, p1)) / 2;
            }
            /// <summary>
            /// Длина высоты, опущенной из точки A
            /// </summary>
            /// <param name="A"></param>
            /// <param name="B"></param>
            /// <param name="C"></param>
            /// <returns></returns>
            static double Height_a(PointF A, PointF B, PointF C)
            {
                double a = Distance(B, C), b = Distance(C, A), c = Distance(A, B);
                double p = Semiperimeter(A, B, C);
                return 2 * Math.Sqrt(p * (p - a) * (p - b) * (p - c)) / a;
            }
            /// <summary>
            /// Возвращает точку C, принадлежащую отрезку AB, где AC / AB = val, val [0.0 - 1.0] 
            /// </summary>
            /// <param name="A"></param>
            /// <param name="B"></param>
            /// <param name="val"></param>
            /// <returns></returns>
            static PointF Between(PointF A, PointF B, double val)
            {
                float x1 = A.X, x2 = B.X, y1 = A.Y, y2 = B.Y;
                double ab = Distance(A, B), ac = ab * val;
                double angle = Math.Atan2(y2 - y1, x2 - x1);
                return new PointF(x1 + (float)(ac * Math.Cos(angle)), y1 + (float)(ac * Math.Sin(angle)));
            }
            PointF GetCursorPosition()
            {
                double hVal = hItem.Val;
                PointF p20 = Between(vertex[2], vertex[0], hVal), p21 = Between(vertex[2], vertex[1], hVal);
                PointF position = Between(p21, p20, aItem.Val);
                return position;
            }
            void DrawCursor(Graphics graphics)
            {
                PointF position = GetCursorPosition();
                int x = (int)Math.Ceiling(position.X), y = (int)Math.Ceiling(position.Y);
                graphics.FillEllipse(Brushes.White, x - 8, y - 8, 16, 16);
                graphics.FillEllipse(Brushes.Black, x - 7, y - 7, 14, 14);
                graphics.FillEllipse(
                new SolidBrush(Hsv.FromHsv(picker.WheelVal * 360, (float)aItem.Val, (float)hItem.Val)), x - 5, y - 5, 10, 10);
            }
            protected override void ValFromPosition()
            {
                double valA, valH;
                CalculateVals(out valA, out valH);
                Space.UnsubscribeNewColor();
                aItem.Val = valA;
                hItem.Val = valH;
                Space.NewColor(null, null);
                Space.SubscribeNewColor();
            }
            /// <summary>
            /// Вычисляет значения A [0.0-1.0] и H [0.0-1.0], соответствующие позиции курсора location,
            /// где PointF.X = A.Val, PointF.Y = H.Val
            /// </summary>
            /// <param name="location">location - текущая позиция курсора мыши</param>
            /// <returns>Возвращает PointF [ x: 0.0-1.0, y: 0.0-1.0 ]</returns>
            public virtual PointF ValsFromLocation(Point location)
            {
                double valA, valH;
                CalculateVals(out valA, out valH);
                return new PointF((float)valA, (float)valH);
            }
            void CalculateVals(out double valA, out double valH)
            {
                PointF M = Middle(vertex[0], vertex[1]);
                double ha = Height_a(MouseLocation, vertex[2], M), hm = Distance(vertex[2], M);
                double b = Distance(MouseLocation, vertex[2]);
                double hv = Math.Sqrt(b * b - ha * ha);
                valH = hv / hm;
                PointF p21 = Between(vertex[2], vertex[1], valH);
                double side2 = Side * valH, ds = Distance(p21, MouseLocation);
                valA = ds / side2;
            }
            private void PickerTriangle_MouseDown(object sender, MouseEventArgs e)
            {
                IsDowned = Inside && e.Button == MouseButtons.Left;
                if (IsDowned) ValFromPosition();
            }
            private void PickerTriangle_MouseMove(object sender, MouseEventArgs e)
            {
                MouseLocation = e.Location;
                Inside = IsInSide();
                if (IsDowned && Inside) ValFromPosition();
            }
            private void PickerTriangle_MouseUp(object sender, MouseEventArgs e)
            {
                IsDowned = false;
                OnLastValue(e);
            }
            private void PickerTriangle_Paint(object sender, PaintEventArgs e)
            {
                if (BrushFunc != null) e.Graphics.FillPolygon(BrushFunc(), vertex);
                DrawCursor(e.Graphics);
            }
            public override void ToUp()
            {
                AItem.Val += IncrementA;
            }
            public override void ToDown()
            {
                AItem.Val -= IncrementA;
            }
            public override void ToLeft()
            {
                HItem.Val -= IncrementH;
            }
            public override void ToRight()
            {
                HItem.Val += IncrementH;
            }
        }

        class Item : BaseColorBox, ILinkedItem<float>
        {
            protected readonly HsvWheelTriangleBox picker;
            double val;
            public event EventHandler<LinkedItemEventArgs<float>> NewValue;
            float ILinkedItem<float>.Val { get { return (float)val; } }
            public virtual double Val
            {
                get { return val; }
                set
                {
                    val = value < 0f ? 0f : value > 1f ? 1f : value;
                    picker.Invalidate();
                    OnValueChanged(null);
                }
            }

            public Item(HsvWheelTriangleBox picker)
            {
                this.picker = picker;
                ValueChanged += Item_ValueChanged;
            }

            private void Item_ValueChanged(object sender, EventArgs e)
            {
                OnNewValue();
            }
            public void SetValIn(float v)
            {
                ValueChanged -= Item_ValueChanged;
                Val = v;
                ValueChanged += Item_ValueChanged;
            }
            void OnNewValue()
            {
                if (NewValue != null) NewValue(this, new LinkedItemEventArgs<float>((float)val));
            }
        }

        class Wheel : Item
        {
            internal event EventHandler InnerValueChanged;
            readonly PointF[] points = new PointF[360];

            PathGradientBrush Brush { get { return (PathGradientBrush)Brush1; } }
            SolidBrush backBrush;
            double S { get { return picker.Width - 1d; } }
            double D { get { return 0.1 * S; } }
            double Gr { get { return 2 * Pi * Val; } set { Val = value / (2 * Pi); } }
            public double R1 { get { return S / 2; } }
            public double R2 { get { return R1 - D - 5; } }
            public override Color CenterColor { set { Brush.CenterColor = value; } }
            public override double Val
            {
                get { return base.Val; }
                set
                {
                    base.Val = value;
                    OnInnerValueChanged(null);
                }
            }

            public Wheel(HsvWheelTriangleBox picker) : base(picker)
            {
                ColorCount = 360;
                SetColors(new Color[360]);
                picker.Paint += PickerWheel_Paint;
                picker.MouseDown += PickerWheel_MouseDown;
                picker.MouseMove += PickerWheel_MouseMove;
                picker.MouseUp += PickerWheel_MouseUp;
            }

            void OnInnerValueChanged(EventArgs e)
            {
                if (InnerValueChanged != null) InnerValueChanged(this, e);
            }
            private void PickerWheel_MouseDown(object sender, MouseEventArgs e)
            {
                MouseLocation = e.Location;
                int x = e.X, y = e.Y;
                IsDowned = Inside && e.Button == MouseButtons.Left;
                if (IsDowned) ValsFromPosition(x, y);
            }
            private void PickerWheel_MouseMove(object sender, MouseEventArgs e)
            {
                MouseLocation = e.Location;
                int x = e.X, y = e.Y;
                Inside = IsInSide(x, y);
                picker.Cursor = Inside ? CircleCursor : Cursors.Default;
                if (IsDowned && Inside) ValsFromPosition(x, y);
            }
            private void PickerWheel_MouseUp(object sender, MouseEventArgs e)
            {
                IsDowned = false;
            }
            private void PickerWheel_Paint(object sender, PaintEventArgs e)
            {
                int s = (int)Math.Round(S, MidpointRounding.AwayFromZero);
                if (BrushFunc != null) e.Graphics.FillEllipse(BrushFunc(), 0, 0, s, s);
                int d = (int)Math.Round(D, MidpointRounding.AwayFromZero),
                    s2 = (int)Math.Round(S - 2 * D, MidpointRounding.AwayFromZero);
                if (backBrush != null) e.Graphics.FillEllipse(backBrush, d, d, s2, s2);
                DrawCursor(e.Graphics);
            }
            public virtual void InitBrush()
            {
                AssignPoints();
                Brush1 = new PathGradientBrush(points);
                backBrush = new SolidBrush(picker.BackColor);
            }
            public override Brush UpdatedBrush()
            {
                Brush.SurroundColors = GetColors();
                return Brush;
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
            void ValsFromPosition(int x, int y)
            {
                Gr = (Math.Atan2(y - R1, x - R1) + 2.5 * Pi) % (2 * Pi);
            }
            bool IsInSide(int x, int y)
            {
                double r = Math.Sqrt(Math.Pow(x - R1, 2) + Math.Pow(y - R1, 2));
                return r <= R1 && r >= R1 - D;
            }
            void DrawCursor(Graphics graphics)
            {
                Func<double, int> round = v => { return (int)Math.Round(v, MidpointRounding.AwayFromZero); };
                double r = R1 - D, g2 = Gr - Pi, h1 = 1.5, h2 = 2.5, s = 1.0, cos2 = Math.Cos(g2), sin2 = Math.Sin(g2),
                       lx1 = X(r + s), ly1 = Y(r + s), lx2 = X(R1 - s), ly2 = Y(R1 - s), mx1 = X(r), my1 = Y(r),
                       mx2 = X(R1), my2 = Y(R1);

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
                return R1 + r * Math.Cos(Gr - Pi / 2);
            }
            double Y(double r)
            {
                return R1 + r * Math.Sin(Gr - Pi / 2);
            }
        }
    }
}
