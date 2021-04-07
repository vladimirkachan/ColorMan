using System;

namespace ColorMan.AppForms
{
    public partial class CircleView : RectView
    {
        protected CircleView()
        {
            InitializeComponent();
            Packs.Add(new Pack(cnud1, ctb1, cb12["One"]));
            Packs.Add(new Pack(cnud2, ctb2, cb12["Two"]));
            Packs.Add(new Pack(cnud3, ctb3, cb3));
            cb12.Increment1 = 1d / 360;
            cb12.LastValue += ItemLastValue;
            cb3.LastValue += ItemLastValue;
        }

        public void CB12ValueChanged(object sender, EventArgs e)
        {
            cb3.Invalidate();
        }

        public void CB3ValueChanged(object sender, EventArgs e)
        {
            cb12.Invalidate();
        }
    }
}
