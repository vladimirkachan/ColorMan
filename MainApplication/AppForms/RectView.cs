using System;
using System.Drawing;
using System.Windows.Forms;
using ColorMan.ControlsLibrary;

namespace ColorMan.AppForms
{
    public partial class RectView : View
    {
        protected int BoundsDefference { get; set; }
        protected bool LayoutPermit { get; set; }

        public RectView()
        {
            InitializeComponent();
            SetLightings(new ILighting[] {wrapN1, wrapN2, wrapN3, wrapT1, wrapT2, wrapT3});
            BoundsDefference = 40;
        }
        protected override void OnLayout(LayoutEventArgs levent)
        {
            if (LayoutPermit)
            {
                int side = (int)Math.Round((Width + Height) / 2d, MidpointRounding.AwayFromZero);
                Size = new Size(side + BoundsDefference, side - BoundsDefference);
            }
            base.OnLayout(levent);
        }
        protected void ItemLastValue(object sender, EventArgs e)
        {
            History.Instance.SetCurrentValue(TwoColorton.Instance.Space1);
        }
    }
}
