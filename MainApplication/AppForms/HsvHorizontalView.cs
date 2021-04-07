using System.Drawing;
using System.Drawing.Drawing2D;
using ColorMan.ColorSpaces;

namespace ColorMan.AppForms
{
    public partial class HsvHorizontalView : HorizontalLinearView
    {
        public HsvHorizontalView()
        {
            InitializeComponent();
            SetColorBoxBrushes();
       }
        void SetColorBoxBrushes()
        {
            hcbox1.BrushFunc = () =>
            {
                hcbox1.SetColors(new Hsv(hcbox1.Val * 360, hcbox2.Val, hcbox3.Val).GetHueColors());
                return hcbox1.UpdatedBrush();
            };
            hcbox2.BrushFunc = () =>
            {
                Hsv hsv = new Hsv(hcbox1.Val * 360, hcbox2.Val, hcbox3.Val);
                return new LinearGradientBrush(new PointF(0f, 0f), new PointF(hcbox2.Width, 0f), hsv.S1, hsv.S2);
            };
            hcbox3.BrushFunc = () =>
            {
                Hsv hsv = new Hsv(hcbox1.Val * 360, hcbox2.Val, hcbox3.Val);
                return new LinearGradientBrush(new PointF(0f, 0f), new PointF(hcbox3.Width, 0f), Hsv.V1, hsv.V2);
            };
        }
    }
}
