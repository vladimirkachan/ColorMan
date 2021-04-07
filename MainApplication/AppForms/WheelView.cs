using System;

namespace ColorMan.AppForms
{
    public partial class WheelView : RectView
    {
        public WheelView()
        {
            InitializeComponent();
            Packs.Add(new Pack(wheelSquare1, cnud1, ctb1));
            Packs.Add(new Pack(wheelSquare1.Square1["One"], cnud2, ctb2));
            Packs.Add(new Pack(wheelSquare1.Square1["Two"], cnud3, ctb3));
            wheelSquare1.LastValue += ItemLastValue;
            BoundsDefference = 52;
        }

        public void WheelValueChanged(object sender, EventArgs e)
        {
            wheelSquare1.Square1.Invalidate();
        }
        public void SquareValueChanged(object sender, EventArgs e)
        {
            wheelSquare1.SquareValueChanged(sender, e);
        }
    }
}
