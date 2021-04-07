using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using ColorMan.ColorSpaces;
using ColorMan.ControlsLibrary;
using ColorMan.ExtensionLibrary;

namespace ColorMan.AppForms
{
    public partial class HueVerticalView : ColorBoxView
    {
        internal VColorBox ColorBox { get { return colorBox; } }

        public HueVerticalView()
        {
            InitializeComponent();
            InitRegion();
            colorBox.BrushFunc = () =>
            {
                Color[] colors = new Hsv(colorBox.Val * 360, AppSpace["S"].Val, AppSpace["V"].Val).GetHueColors();
                Array.Reverse(colors);
                colorBox.SetColors(colors);
                return colorBox.UpdatedBrush();
            };
            Packs.Add(new Pack(colorBox));
            MouseWheel += @this_MouseWheel;
            colorBox.Increment = 1f / 360;
        }
        internal void InitRegion()
        {
            GraphicalPath = new GraphicsPath();
            GraphicalPath.AddRectangle(colorBox.Bounds);
            Region = new Region(GraphicalPath);
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Up: colorBox.ToUp(); return true;
                case Keys.Down: colorBox.ToDown(); return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        protected override void SetPairBounds()
        {
            var target = (HueHorizontalView)Pair;
            var value = colorBox.Size.Invert();
            target.Size = value;
            target.ColorBox.Size = value;
            target.InitRegion();
        }
        protected override void OnLoad(EventArgs e)
        {
            AppSpace["S"].ValueChanged += spaceComponent_ValueChanged;
            AppSpace["V"].ValueChanged += spaceComponent_ValueChanged;
            base.OnLoad(e);
        }
        void @this_MouseWheel(object sender, MouseEventArgs e)
        {
            colorBox.Val += Math.Sign(e.Delta) * colorBox.Increment;
        }
        void spaceComponent_ValueChanged(object sender, EventArgs e)
        {
            colorBox.Invalidate();
        }
        private void colorBox_MouseDown(object sender, MouseEventArgs e)
        {
            Previous = Size;
            Downed = new Size(e.Location);
        }
        private void colorBox_MouseMove(object sender, MouseEventArgs e)
        {
            Keys mod = ModifierKeys & Keys.Modifiers;
            Point loc = e.Location;
            if (mod == Keys.Control) SetCursor(loc);
            if (colorBox.IsDowned) Cursor = Cursors.SizeNS;
            if (!colorBox.IsRightDowned) return;
            if (mod == Keys.Control)
            {
                Cursor = Cursors.NoMove2D;
                Point def = loc - Downed;
                colorBox.Size = Size = new Size(Previous.Width + def.X, Previous.Height + def.Y);
                InitRegion();
                Refresh();
            }
            else
            {
                Cursor = Cursors.SizeAll;
                Location += new Size(loc) - Downed;
            }
        }
        private void colorBox_LastValue(object sender, EventArgs e)
        {
            History.Instance.SetCurrentValue(TwoColorton.Instance.Space1);
        }
    }
}
