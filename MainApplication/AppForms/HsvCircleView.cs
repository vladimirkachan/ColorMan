using System.Drawing;
using System.Drawing.Drawing2D;
using ColorMan.ColorSpaces;

namespace ColorMan.AppForms
{
    public partial class HsvCircleView : CircleView
    {
        public HsvCircleView()
        {
            InitializeComponent();
            SetColorBoxBrushes();
            CB12.BrightnessUnderTheCursorFunc = loc =>
            {
                PointF v = CB12.ValsFromLocation(loc);
                return Hsv.FromHsv(v.X, v.Y, cb3.Val).GetBrightness();
            };
            CB12.SelectedColorFunc = () => Hsv.FromHsv((float)CB12.Val1 * 360, (float)CB12.Val2, cb3.Val);
            LayoutPermit = true;
        }
        void SetColorBoxBrushes()
        {
            CB12.InitBrush();
            CB12.BrushFunc = () =>
            {
                float v = cb3.Val;
                for (int i = 0; i < CB12.ColorCount; i++) CB12.GetColors()[i] = Hsv.FromHsv(i, 1f, v);
                CB12.CenterColor = Hsv.FromHsv(0f, 0f, v);
                return CB12.UpdatedBrush();
            };
            cb3.BrushFunc = () =>
            {
                Hsv hsv = new Hsv((float)CB12.GС, (float)CB12.Val2, cb3.Val);
                return new LinearGradientBrush(new PointF(0f, 0f), new PointF(cb3.Width, 0f), Hsv.V1, hsv.V2);
            };
        }
    }
}
