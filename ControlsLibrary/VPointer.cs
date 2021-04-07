using System;
using System.Drawing;
using System.Globalization;

namespace ColorMan.ControlsLibrary
{
    public partial class VPointer : Pointer
    {
        public VPointer() : base(13)
        {
            InitializeComponent();
            label1.Size = new Size(Width, Pad);
            int w = 13, lw = label1.Width - 1;
            GetPP1()[0] = new Point(lw, Pad / 2);
            GetPP1()[1] = new Point(lw - w, 0);
            GetPP1()[2] = new Point(lw - w, 11);
            GetPP2()[0] = new Point(lw - 4, Pad / 2);
            GetPP2()[1] = new Point(lw - w + 2, 2);
            GetPP2()[2] = new Point(lw - w + 2, 9);
        }

        public override double Val
        {
            get { return base.Val; }
            set
            {
                base.Val = value;
                label1.Text = string.Format(CultureInfo.InvariantCulture, "{0,4:0}", value * Range + Minimum);
                Invalidate();
            }
        }
        public override int Side { get { return Height - Pad - 1; } set { Height = value + Pad + 1; } }
        protected override void LabelLocate()
        {
            label1.Top = Side - (int)Math.Round(Val * Side, MidpointRounding.AwayFromZero);
        }
    }
}
