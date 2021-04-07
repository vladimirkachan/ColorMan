using System.Drawing;
using System.Windows.Forms;
using ColorMan.ColorSpaces;

namespace ColorMan.AppForms
{
    public partial class HsvWheelView : WheelView
    {
        public HsvWheelView()
        {
            InitializeComponent();
            SetBrushes();
            var square = WheelSquare1.Square1;
            square.BrightnessUnderTheCursorFunc = loc =>
                {
                    PointF v = WheelSquare1.Square1.ValsFromLocation(loc);
                    return Hsv.FromHsv((float)WheelSquare1.Celsius, v.X, v.Y).GetBrightness();
                };
            square.Paint += Square_Paint;
            square.SelectedColorFunc =
                () => Hsv.FromHsv((float)(WheelSquare1.Val * 360), (float)square.Val1, (float)square.Val2);
            WheelSquare1.Layout += WheelSquare1_Layout;
            LayoutPermit = true;
        }

        void SetBrushes()
        {
            WheelSquare1.InitBrush();
            WheelSquare1.BrushFunc = () =>
            {
                float s = WheelSquare1.Square1["One"].Val, v = WheelSquare1.Square1["Two"].Val;
                for (int i = 0; i < WheelSquare1.ColorCount; i++) WheelSquare1.GetSurroundColors()[i] = Hsv.FromHsv(i, s, v);
                WheelSquare1.CenterColor = Hsv.FromHsv(0f, 0f, v);
                return WheelSquare1.UpdatedBrushByColors();
            };
        }
        void Square_Paint(object sender, PaintEventArgs e)
        {
            var square = WheelSquare1.Square1;
            int side = (int)square.WX, indent = square.Indent;
            int colorCount = square.ColorCount;
            for (int i = 0; i <= side; i++)
            {
                for (int j = 0; j < colorCount; j++)
                    square.GetColors()[j] = Hsv.FromHsv((float)WheelSquare1.Celsius, (float)i / side, (float)j / (colorCount - 1));
                e.Graphics.FillRectangle(square.UpdatedBrush(), i + indent, indent, 1, side);
            }
        }
        private void WheelSquare1_Layout(object sender, LayoutEventArgs e)
        {
            SetBrushes();
        }
    }
}
