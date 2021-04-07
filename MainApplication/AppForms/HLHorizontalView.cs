using System;
using System.Windows.Forms;
using ColorMan.ColorSpaces;

namespace ColorMan.AppForms
{
    public partial class HLHorizontalView : RectColorComponentView
    {
        public HLHorizontalView()
        {
            InitializeComponent();
            InitRegion();
            rectangleCB.InitBrush();
            rectangleCB.BrightnessUnderTheCursorFunc = loc =>
                                        {
                                            double h = rectangleCB.HY;
                                            return (float)((h - loc.Y) / h);
                                        };
            Packs.Add(new Pack(rectangleCB["One"]));
            Packs.Add(new Pack(rectangleCB["Two"]));
            rectangleCB.SelectedColorFunc =
                () => Hsl.FromHsl((float)(rectangleCB.Val1 * 360), AppSpace["S"].Val, (float)rectangleCB.Val2);
            MouseWheel += @this_MouseWheel;
            rectangleCB.Increment1 = 1d / 360;
        }
        protected override void RectanglePaint(object sender, PaintEventArgs e)
        {
            if (AppSpace == null) return;
            rectangleCB.GetColors()[0] = Hsl.Black;
            rectangleCB.GetColors()[2] = Hsl.White;
            double w = rectangleCB.WX;
            for (int i = 0; i <= w; i++)
            {
                rectangleCB.GetColors()[1] = Hsl.FromHsl(
                    (float)Math.Round(i * 360 / w, MidpointRounding.AwayFromZero), AppSpace["S"].Val, 0.5f);
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
