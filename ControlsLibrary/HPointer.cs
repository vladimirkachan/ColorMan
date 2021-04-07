using System;
using System.Drawing;
using System.Globalization;

namespace ColorMan.ControlsLibrary
{
    public partial class HPointer : Pointer
    {
        public HPointer() : base(23)
        {
            InitializeComponent();
            label1.Size = new Size(Pad, Height);
            int h = 14, m = Pad / 2;
            GetPP1()[0] = new Point(m, 0);
            GetPP1()[1] = new Point(m - 5, h);
            GetPP1()[2] = new Point(m + 5, h);
            GetPP2()[0] = new Point(m, 4);
            GetPP2()[1] = new Point(m - 3, h - 2);
            GetPP2()[2] = new Point(m + 3, h - 2);
        }
        public override double Val
        {
            get { return base.Val; }
            set
            {
                base.Val = value;
                label1.Text = string.Format(CultureInfo.InvariantCulture, "{0:0}", value * Range + Minimum);
                Invalidate();
            }
        }
        public override int Side { get { return Width - Pad - 1; } set { Width = value + Pad + 1; } }
        protected override void LabelLocate()
        {
            label1.Left  = (int)Math.Round(Val * Side, MidpointRounding.AwayFromZero);
        }
    }
}
