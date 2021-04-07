using System;
using System.Windows.Forms;
using ColorMan.ContractLibrary;

namespace ColorMan.ControlsLibrary
{
    public class CtrackBar : TrackBar, ILinkedItem<float>
    {
        public event EventHandler<LinkedItemEventArgs<float>> NewValue;
        public event EventHandler LastValue;
        bool changed;

        public float Val { get { return (Value - Minimum) / Range; } }
        float Range { get { return Maximum - Minimum; } }

        public CtrackBar()
        {
            ValueChanged += bar_ValueChanged;
        }
        void bar_ValueChanged(object sender, EventArgs e)
        {
            OnNewValue();
            changed = true;
        }
        void OnNewValue()
        {
            if (NewValue != null) NewValue(this, new LinkedItemEventArgs<float>(Val));
        }
        void OnLastValue(EventArgs e)
        {
            if (LastValue != null) LastValue(this, e);
        }
        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);
            if (changed) OnLastValue(e);
            changed = false;
        }
        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            OnLastValue(e);
        }
        public void SetValIn(float value)
        {
            ValueChanged -= bar_ValueChanged;
            Value = (int)Math.Round(value * Range + Minimum, MidpointRounding.AwayFromZero);
            ValueChanged += bar_ValueChanged;
        }

    }
}
