using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ColorMan.ControlsLibrary
{
    public class HColorBox : LinearColorBox
    {
        public HColorBox()
        {
            CapturedCursor = Cursors.SizeWE;
        }
        public override void ToLeft()
        {
            Val -= Increment;
        }
        public override void ToRight()
        {
            Val += Increment;
        }
        protected override void OnPaint(PaintEventArgs pe)
        {
            int w = Width, h = Height, x = (int)(Val * w);
            if (BrushFunc != null) pe.Graphics.FillRectangle(BrushFunc(), 0, 0, w, h);
            pe.Graphics.FillRectangle(Brushes.White, x - 1, 0, 3, h);
            pe.Graphics.DrawLine(Pens.Black, x, 1, x, h - 2);
            base.OnPaint(pe);
        }
        protected override void ValFromPosition()
        {
            Val = (float)MouseLocation.X / Width;
        }
        protected override void OnLayout(LayoutEventArgs levent)
        {
            base.OnLayout(levent);
            if (Width <= 0) return;
            Brush1 = new LinearGradientBrush(new Point(0, 0), new Point(Width, 0), Color.Empty, Color.Empty);
            Invalidate();
        }
    }
}
