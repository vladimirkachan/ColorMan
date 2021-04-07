using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ColorMan.ControlsLibrary
{
    public class VColorBox : LinearColorBox
    {
        public VColorBox()
        {
            CapturedCursor = Cursors.SizeNS;
        }
        public override void ToUp()
        {
            Val += Increment;
        }
        public override void ToDown()
        {
            Val -= Increment;
        }
        protected override void OnPaint(PaintEventArgs pe)
        {
            int w = Width, h = Height, y = (int)(h - Val * h);
            if (BrushFunc != null) pe.Graphics.FillRectangle(BrushFunc(), 0, 0, w, h);
            pe.Graphics.FillRectangle(Brushes.White, 0, y - 1, w, 3);
            pe.Graphics.DrawLine(Pens.Black, 1, y, w - 2, y);
            base.OnPaint(pe);
        }
        protected override void ValFromPosition()
        {
            Val = (Height - (float)MouseLocation.Y) / Height;
        }
        protected override void OnLayout(LayoutEventArgs levent)
        {
            base.OnLayout(levent);
            if (Height <= 0) return;
            Brush1 = new LinearGradientBrush(new Point(0, 0), new Point(0, Height), Color.Empty, Color.Empty);
            Invalidate();
        }
    }
}
