using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ColorMan.AppControls
{
    public class CircleColorBox : RectangleColorBox
    {
        PointF[] points = new PointF[360];
        int side;
        public CircleColorBox()
        {
            ColorCount = 360;
            SetColors(new Color[360]);
        }
        double R { get { return Val2 * R1; } set { Val2 = value / R1; } }
        public double GС { get { return Val1 * 360; } set { Val1 = value / 360; } } 
        double Gr1 { get { return 2 * Pi * Val1; } set { Val1 = value / (2 * Pi); } }
        double R1 { get { return WX / 2; } }
        protected override double Xpos { get { return R1 + R * Math.Cos(Gr1 - Pi / 2) + Indent; } }
        protected override double Ypos { get { return R1 + R * Math.Sin(Gr1 - Pi / 2) + Indent; } }
        public override Color CenterColor { set { if (CircleBrush != null) CircleBrush.CenterColor = value; } }
        PathGradientBrush CircleBrush { get { return (PathGradientBrush)Brush1; } }
        protected override void RechangeColorCount(int count)
        {
            points = new PointF[count];
            SetColors(new Color[count]);
        }
        public override void InitBrush()
        {
            AssignPoints();
            Brush1 = new PathGradientBrush(points);
        }
        public override Brush UpdatedBrush()
        {
            CircleBrush.SurroundColors = GetColors();
            return Brush1;
        }
        void AssignPoints()
        {
            Func<int, double> rd = i => i * Pi / 180;
            Func<double, float> df = x => Convert.ToSingle(Math.Round(x));
            for (var i = 0; i < 360; i++)
            {
                var j = (270 + i) % 360;
                double dx = R1 * Math.Cos(rd(j)), dy = R1 * Math.Sin(rd(j));
                points[i] = new PointF(df(R1 + dx) + Indent, df(R1 + dy) + Indent);
            }
        }
        double Rad(float x, float y)
        {
            return Math.Atan2(y - R1, x - R1);
        }
        /// <summary>
        ///     Вычисляет значения угла [0.0-360.0] и радиуса [0.0-1.0], соответствующие позиции location
        /// </summary>
        /// <param name="location">location - текущая позиция курсора мыши</param>
        /// <returns>Возвращает PointF [ x: угол 0.0-360.0, y: радиус 0.0-1.0 ]</returns>
        public override PointF ValsFromLocation(Point location)
        {
            int x = location.X - Indent, y = location.Y - Indent;
            float v1 = (float)(((Rad(x, y) + 2.5 * Pi) % (2 * Pi)) * 180.0 / Pi),
                  v2 = (float)(Math.Sqrt(Math.Pow(x - R1, 2) + Math.Pow(y - R1, 2)) / R1);
            return new PointF(v1, v2);
        }
        protected override bool IsInside(double delta)
        {
            var r = Math.Sqrt(Math.Pow(MouseLocation.X - Indent - R1, 2) + Math.Pow(MouseLocation.Y - Indent - R1, 2));
            return r <= R1 + delta;
        }
        protected override void ValFromPosition()
        {
            int x = MouseLocation.X - Indent, y = MouseLocation.Y - Indent;
            R = Math.Sqrt(Math.Pow(R1 - x, 2) + Math.Pow(R1 - y, 2));
            Gr1 = (Math.Atan2(y - R1, x - R1) + 2.5 * Pi) % (2 * Pi);
            OnValueChanged(null);
        }
        protected override void ScaleBrush()
        {
            side = (int)Math.Round((Width + Height) / 2d, MidpointRounding.AwayFromZero); 
            Size = new Size(side, side);
            InitBrush();
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
    }
}