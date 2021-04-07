using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using ColorMan.ColorSpaces;

namespace ColorMan.AppForms
{
    public partial class HsvVerticalView : VerticalLinearView
    {
        public HsvVerticalView()
        {
            InitializeComponent();
            SetColorBoxBrushes();
        }
        void SetColorBoxBrushes()
        {
            vcbox1.BrushFunc = () =>
            {
                Color[] colors = new Hsv(vcbox1.Val * 360, vcbox2.Val, vcbox3.Val).GetHueColors();
                Array.Reverse(colors);
                vcbox1.SetColors(colors);
                return vcbox1.UpdatedBrush();
            };
            vcbox2.BrushFunc = () =>
            {
                Hsv hsv = new Hsv(vcbox1.Val * 360, vcbox2.Val, vcbox3.Val);
                return new LinearGradientBrush(new PointF(0f, vcbox2.Height), new PointF(0f, 0f), hsv.S1, hsv.S2);
            };
            vcbox3.BrushFunc = () =>
            {
                Hsv hsv = new Hsv(vcbox1.Val * 360, vcbox2.Val, vcbox3.Val);
                return new LinearGradientBrush(new PointF(0f, vcbox3.Height), new PointF(vcbox3.Width, 0f), Hsv.V1, hsv.V2);
            };
        }
    }
}
