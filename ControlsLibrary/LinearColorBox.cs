using System;
using System.Windows.Forms;
using ColorMan.ContractLibrary;

namespace ColorMan.ControlsLibrary
{
    public class LinearColorBox : BaseColorBox, ILinkedItem<float>
    {
        public event EventHandler<LinkedItemEventArgs<float>> NewValue;
        float val;
        float increment = 0.01f;

        protected Cursor CapturedCursor { get; set; }
        Cursor MoveCursor { get; set; }
        Cursor ScaleCursor { get; set; }
        public float Val
        {
            get { return val; }
            set
            {
                val = value < 0f ? 0f : value > 1f ? 1f : value;
                Invalidate();
                OnValueChanged(null);
            }
        }
        public override Cursor Cursor
        {
            get { return IsDowned || IsRightDowned ? base.Cursor : CircleCursor; }
            set { base.Cursor = value; }
        }
        public float Increment { get { return increment; } set { increment = value; } }
        protected LinearColorBox()
        {
            ValueChanged += @this_ValueChanged;
            MoveCursor = Cursors.SizeAll;
            ScaleCursor = Cursors.NoMove2D;
        }
        public void SetValIn(float value)
        {
            ValueChanged -= @this_ValueChanged;
            Val = value;
            ValueChanged += @this_ValueChanged;
        }
        void @this_ValueChanged(object sender, EventArgs e)
        {
            OnNewValue();
        }
        void OnNewValue()
        {
            if (NewValue != null) NewValue(this, new LinkedItemEventArgs<float>(Val));
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            Keys mod = ModifierKeys & Keys.Modifiers;
            IsRightDowned = e.Button == MouseButtons.Right;
            IsDowned = e.Button == MouseButtons.Left;
            if (IsDowned)
            {
                Cursor = CapturedCursor;
                IsRightDowned = false;
                ValFromPosition();
                Invalidate();
            }
            else if (mod == Keys.Control && IsRightDowned) Cursor = ScaleCursor;
            else if (IsRightDowned) Cursor = MoveCursor;
            base.OnMouseDown(e);
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            MouseLocation = e.Location;
            if (IsDowned)
            {
                ValFromPosition();
                Invalidate();
            }
            base.OnMouseMove(e);
        }
        protected override void OnMouseUp(MouseEventArgs e)
        {
            IsRightDowned = IsDowned = false;
            base.OnMouseUp(e);
        }
        protected override void OnMouseWheel(MouseEventArgs e)
        {
            Val += Math.Sign(e.Delta) * increment;
            base.OnMouseWheel(e);
        }
    }
}
