using System;
using System.Drawing;
using System.Windows.Forms;
using ColorMan.ColorSpaces;

namespace ColorMan.AppForms
{
    public partial class LabSquareView : RectSlimView
    {
        public LabSquareView()
        {
            InitializeComponent();
            Packs.Add(new Pack(cnud3, linearCB));
            Packs.Add(new Pack(cnud1, squareCB["One"]));
            Packs.Add(new Pack(cnud2, squareCB["Two"]));
            SetColorBoxBrushes();
            squareCB.BrightnessUnderTheCursorFunc = loc =>
            {
                PointF v = squareCB.ValsFromLocation(loc);
                return Lab.FromLab(new Vector(linearCB.Val, v.X, v.Y)).GetBrightness();
            };
            squareCB.Increment1 = squareCB.Increment2 = 1.0 / 255.0;
            linearCB.Increment = 0.01f;
            squareCB.SelectedColorFunc =
                () => Lab.FromLab(new Vector(linearCB.Val, (float)squareCB.Val1, (float)squareCB.Val2));
            linearCB.LastValue += ItemLastValue;
            squareCB.LastValue += ItemLastValue;
            BoundsDefference = 14;
            LayoutPermit = true;
        }

        void SetColorBoxBrushes()
        {
            squareCB.InitBrush();
            linearCB.BrushFunc = () =>
            {
                int n = linearCB.ColorCount;
                for (int i = 0; i < n; i++) linearCB.GetColors()[i] =
                    Lab.FromLab(new Vector((float)i / (n - 1), (float)squareCB.Val1, (float)squareCB.Val2));
                return linearCB.UpdatedBrush();
            };
        }
        public void SquareValueChanged(object sender, EventArgs e)
        {
            linearCB.Invalidate();
        }
        public void LinearValueChanged(object sender, EventArgs e)
        {
            squareCB.Invalidate();
        }
        private void squareCB_Paint(object sender, PaintEventArgs e)
        {
            int side = (int)squareCB.WX, indent = squareCB.Indent;
            for (int i = 0; i <= side; i++)
            {
                for (int j = 0; j < squareCB.ColorCount; j++)
                    squareCB.GetColors()[j] = Lab.FromLab(new Vector(linearCB.Val, (float)i / side, squareCB.GetPositions()[j]));
                e.Graphics.FillRectangle(squareCB.UpdatedBrush(), i + indent, indent, 1, side);
            }
        }
        private void squareCB_Layout(object sender, LayoutEventArgs e)
        {
            squareCB.InitBrush();
        }
    }
}
