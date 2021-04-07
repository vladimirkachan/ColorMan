using System;
using System.Drawing;
using System.Windows.Forms;

namespace ColorMan.AppControls
{
    public class SquareColorBox : RectangleColorBox
    {
        int side;

        protected override void OnLayout(LayoutEventArgs levent)
        {
            side = (int)Math.Round((Width + Height) / 2d, MidpointRounding.AwayFromZero);
            Size = new Size(side, side);
            base.OnLayout(levent);
        }
    }
}
