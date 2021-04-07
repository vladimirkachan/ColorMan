using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using ColorMan.ColorSpaces;

namespace ColorMan.AppForms
{
    public partial class HslVerticalView : VerticalLinearView
    {
        public HslVerticalView()
        {
            InitializeComponent();
            SetColorBoxBrushes();
        }
        void SetColorBoxBrushes()
        {
            vcbox1.BrushFunc = () =>
            {
                Color[] colors = new Hsl(vcbox1.Val * 360, vcbox2.Val, vcbox3.Val).GetHueColors();
                Array.Reverse(colors);
                vcbox1.SetColors(colors);
                return vcbox1.UpdatedBrush();
            };
            vcbox2.BrushFunc = () =>
            {
                Hsl hsl = new Hsl(vcbox1.Val * 360, vcbox2.Val, vcbox3.Val);
                return new LinearGradientBrush(new PointF(0f, vcbox2.Height), new PointF(0f, 0f), hsl.S1, hsl.S2);
            };
            vcbox3.GetColors()[0] = Hsl.White;
            vcbox3.GetColors()[2] = Hsl.Black;
            vcbox3.BrushFunc = () =>
            {
                vcbox3.GetColors()[1] = new Hsl(vcbox1.Val * 360, vcbox2.Val, vcbox3.Val).LM;
                return vcbox3.UpdatedBrush();
            };
        }
    }
}
