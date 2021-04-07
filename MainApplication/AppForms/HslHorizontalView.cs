using System.Drawing;
using System.Drawing.Drawing2D;
using ColorMan.ColorSpaces;

namespace ColorMan.AppForms
{
    public partial class HslHorizontalView : HorizontalLinearView
    {
        public HslHorizontalView()
        {
            InitializeComponent();
            SetColorBoxBrushes();
        }
        void SetColorBoxBrushes()
        {
            hcbox1.BrushFunc = () =>
            {
                hcbox1.SetColors(new Hsl(hcbox1.Val * 360, hcbox2.Val, hcbox3.Val).GetHueColors());
                return hcbox1.UpdatedBrush();
            };
            hcbox2.BrushFunc = () =>
            {
                Hsl hsl = new Hsl(hcbox1.Val * 360,hcbox2.Val, hcbox3.Val);
                return new LinearGradientBrush(new PointF(0f, 0f), new PointF(hcbox2.Width, 0f), hsl.S1, hsl.S2);
            };
            hcbox3.GetColors()[0] = Hsl.Black;
            hcbox3.GetColors()[2] = Hsl.White;
            hcbox3.BrushFunc = () =>
            {
                hcbox3.GetColors()[1] = new Hsl(hcbox1.Val * 360,hcbox2.Val, hcbox3.Val).LM;
                return hcbox3.UpdatedBrush();
            };
        }
    }
}
