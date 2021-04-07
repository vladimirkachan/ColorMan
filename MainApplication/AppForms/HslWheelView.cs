using System.Windows.Forms;
using ColorMan.ColorSpaces;

namespace ColorMan.AppForms
{
    public partial class HslWheelView : WheelView
    {
        public HslWheelView()
        {
            InitializeComponent();
            var square = wheelSquare1.Square1;
            square.ColorCount = 3;
            SetBrushes();
            square.BrightnessUnderTheCursorFunc = loc => WheelSquare1.Square1.ValsFromLocation(loc).Y;
            square.Paint += Square_Paint;
            square.SelectedColorFunc = () => 
                Hsl.FromHsl((float)(WheelSquare1.Val * 360), (float)square.Val1, (float)square.Val2);
            LayoutPermit = true;
        }
        void SetBrushes()
        {
            WheelSquare1.InitBrush();
            WheelSquare1.BrushFunc = () =>
            {
                float s = WheelSquare1.Square1["One"].Val, l = WheelSquare1.Square1["Two"].Val;
                for (int i = 0; i < WheelSquare1.ColorCount; i++) WheelSquare1.GetSurroundColors()[i] = Hsl.FromHsl(i, s, l);
                WheelSquare1.CenterColor = Hsl.FromHsl(0f, 0f, l);
                return WheelSquare1.UpdatedBrushByColors();
            };
            var square = WheelSquare1.Square1;
            square.InitBrush();
        }
        void Square_Paint(object sender, PaintEventArgs e)
        {
            var square = WheelSquare1.Square1;
            int side = (int)square.WX, indent = square.Indent;
            square.GetColors()[0] = Hsl.Black;
            square.GetColors()[2] = Hsl.White;
            for (int i = 0; i <= side; i++)
            {
                square.GetColors()[1] = Hsl.FromHsl((float)WheelSquare1.Celsius, (float)i / side, 0.5f);
                e.Graphics.FillRectangle(square.UpdatedBrush(), i + indent, indent, 1, side);
            }
        }
        private void wheel_Layout(object sender, LayoutEventArgs e)
        {
            SetBrushes();
        }
    }
}
