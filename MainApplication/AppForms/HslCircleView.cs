using ColorMan.ColorSpaces;

namespace ColorMan.AppForms
{
    public partial class HslCircleView : CircleView
    {
        public HslCircleView()
        {
            InitializeComponent();
            SetColorBoxBrushes();
            CB12.BrightnessUnderTheCursorFunc = loc => cb3.Val;
            CB12.SelectedColorFunc = () => Hsl.FromHsl((float)CB12.Val1 * 360, (float)CB12.Val2, cb3.Val);
            LayoutPermit = true;
        }
        void SetColorBoxBrushes()
        {
            CB12.InitBrush();
            CB12.BrushFunc = () =>
            {
                float l = cb3.Val;
                for (int i = 0; i < CB12.ColorCount; i++) CB12.GetColors()[i] = Hsl.FromHsl(i, 1f, l);
                CB12.CenterColor = Hsl.FromHsl(0f, 0f, l);
                return CB12.UpdatedBrush();
            };
            cb3.GetColors()[0] = Hsl.Black;
            cb3.GetColors()[2] = Hsl.White;
            cb3.BrushFunc = () =>
            {
                cb3.GetColors()[1] = new Hsl((float)CB12.GС, (float)CB12.Val2, cb3.Val).LM;
                return cb3.UpdatedBrush();
            };
        }
    }
}
