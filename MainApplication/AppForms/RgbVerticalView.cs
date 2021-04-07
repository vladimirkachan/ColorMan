using System.Drawing;
using System.Drawing.Drawing2D;
using ColorMan.ColorSpaces;

namespace ColorMan.AppForms
{
    public partial class RgbVerticalView : VerticalLinearView
    {
        public RgbVerticalView()
        {
            InitializeComponent();
            SetColorBoxBrushes();
        }
        void SetColorBoxBrushes()
        {
            vcbox1.BrushFunc = () =>
            {
                Rgb rgb = new Rgb(new Vector(vcbox1.Val, vcbox2.Val, vcbox3.Val));
                return new LinearGradientBrush(new PointF(0f, vcbox1.Height), new PointF(0f, 0f), rgb.R1, rgb.R2);
            };
            vcbox2.BrushFunc = () =>
            {
                Rgb rgb = new Rgb(new Vector(vcbox1.Val, vcbox2.Val, vcbox3.Val));
                return new LinearGradientBrush(new PointF(0f, vcbox2.Height), new PointF(0f, 0f), rgb.G1, rgb.G2);
            };
            vcbox3.BrushFunc = () =>
            {
                Rgb rgb = new Rgb(new Vector(vcbox1.Val, vcbox2.Val, vcbox3.Val));
                return new LinearGradientBrush(new PointF(0f, vcbox3.Height), new PointF(0f, 0f), rgb.B1, rgb.B2);
            };
        }

    }
}
