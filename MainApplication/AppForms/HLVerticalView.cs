using System.Windows.Forms;
using ColorMan.ColorSpaces;

namespace ColorMan.AppForms
{
    public partial class HLVerticalView : RectColorComponentView
    {
        public HLVerticalView()
        {
            InitializeComponent();
            InitRegion();
            rectangleCB.InitBrush();
            rectangleCB.BrightnessUnderTheCursorFunc = loc => loc.X;
            rectangleCB.SelectedColorFunc =
                () => Hsl.FromHsl((float)(rectangleCB.Val2 * 360), AppSpace["S"].Val, (float)rectangleCB.Val1);
            Packs.Add(new Pack(rectangleCB["Two"]));
            Packs.Add(new Pack(rectangleCB["One"]));
            MouseWheel += @this_MouseWheel;
            rectangleCB.Increment2 = 1d / 360;
        }
        protected override void RectanglePaint(object sender, PaintEventArgs e)
        {
            if (AppSpace == null) return;
            double w = rectangleCB.WX;
            float s = AppSpace["S"].Val;
            for (int i = 0; i <= w; i++)
            {
                int n = rectangleCB.ColorCount;
                for (int j = 0; j < n; j++) rectangleCB.GetColors()[j] = Hsl.FromHsl(j * 60, s, (float)(i / w));
                e.Graphics.FillRectangle(rectangleCB.UpdatedBrush(), i, 0, 1, (int)rectangleCB.HY);
            }
        }
        void @this_MouseWheel(object sender, MouseEventArgs e)
        {
            Keys mod = ModifierKeys & Keys.Modifiers;
            if (mod == Keys.Shift)
            {
                if (e.Delta > 0) rectangleCB.ToUp();
                else rectangleCB.ToDown();
            }
            else
            {
                if (e.Delta > 0) rectangleCB.ToRight();
                else rectangleCB.ToLeft();
            }
        }
    }
}
