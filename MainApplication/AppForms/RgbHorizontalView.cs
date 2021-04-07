using System.Drawing;
using System.Drawing.Drawing2D;
using ColorMan.ColorSpaces;

namespace ColorMan.AppForms
{
    public partial class RgbHorizontalView : HorizontalLinearView
    {
        public RgbHorizontalView()
        {
            InitializeComponent();
            SetColorBoxBrushes();
        }
        void SetColorBoxBrushes()
        {
            hcbox1.BrushFunc = () =>
            {
                Rgb rgb = new Rgb(new Vector(hcbox1.Val, hcbox2.Val, hcbox3.Val));
                return new LinearGradientBrush(new PointF(0f, 0f), new PointF(hcbox1.Width, 0f), rgb.R1, rgb.R2);
            };
            hcbox2.BrushFunc = () =>
            {
                Rgb rgb = new Rgb(new Vector(hcbox1.Val, hcbox2.Val, hcbox3.Val));
                return new LinearGradientBrush(new PointF(0f, 0f), new PointF(hcbox2.Width, 0f), rgb.G1, rgb.G2);
            };
            hcbox3.BrushFunc = () =>
            {
                Rgb rgb = new Rgb(new Vector(hcbox1.Val, hcbox2.Val, hcbox3.Val));
                return new LinearGradientBrush(new PointF(0f, 0f), new PointF(hcbox3.Width, 0f), rgb.B1, rgb.B2);
            };
        }
    }
}
