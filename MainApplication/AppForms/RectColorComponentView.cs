using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using ColorMan.ExtensionLibrary;

namespace ColorMan.AppForms
{
    public partial class RectColorComponentView : ColorBoxView
    {
        string OtherColorComponentName { get; set; }

        protected RectColorComponentView()
        {
            InitializeComponent();
            OtherColorComponentName = "S";
        }
        protected void InitRegion()
        {
            GraphicalPath = new GraphicsPath();
            GraphicalPath.AddRectangle(rectangleCB.Bounds);
            Region = new Region(GraphicalPath);
        }
        protected override void SetPairBounds()
        {
            var target = (RectColorComponentView)Pair;
            var value = rectangleCB.Size.Invert();
            target.Size = value;
            target.rectangleCB.Size = value;
            target.InitRegion();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Up: rectangleCB.ToUp(); return true;
                case Keys.Down: rectangleCB.ToDown(); return true;
                case Keys.Right: rectangleCB.ToRight(); return true;
                case Keys.Left: rectangleCB.ToLeft(); return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        protected override void OnLoad(EventArgs e)
        {
            if (AppSpace != null) AppSpace[OtherColorComponentName].ValueChanged += spaceComponent_ValueChanged;
            base.OnLoad(e);
        }
        protected virtual void RectanglePaint(object sender, PaintEventArgs e) { }
        void spaceComponent_ValueChanged(object sender, EventArgs e)
        {
            rectangleCB.Invalidate();
        }
        private void rectangleCB_MouseDown(object sender, MouseEventArgs e)
        {
            Previous = Size;
            Downed = new Size(e.Location);
        }
        private void rectangleCB_MouseMove(object sender, MouseEventArgs e)
        {
            Keys mod = ModifierKeys & Keys.Modifiers;
            Point loc = e.Location;
            if (mod == Keys.Control) SetCursor(loc);
            if (!rectangleCB.IsRightDowned) return;
            if (mod == Keys.Control)
            {
                Cursor = Cursors.NoMove2D;
                Point def = loc - Downed;
                rectangleCB.Size = Size = new Size(Previous.Width + def.X, Previous.Height + def.Y);
                InitRegion();
                Refresh();
            }
            else
            {
                Cursor = Cursors.SizeAll;
                Location += new Size(loc) - Downed;
            }
        }
        private void rectangleCB_LastValue(object sender, EventArgs e)
        {
            History.Instance.SetCurrentValue(TwoColorton.Instance.Space1);
        }
    }
}
