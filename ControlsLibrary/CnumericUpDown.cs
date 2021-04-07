using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using ColorMan.ContractLibrary;

namespace ColorMan.ControlsLibrary
{
    public class CnumericUpDown : NumericUpDown, ILinkedItem<float>
    {
        bool downed, changed;
        decimal y0, divider = 5;
        readonly NumericUpDownAcceleration acceleration = new NumericUpDownAcceleration(1, 5);
        public event EventHandler<LinkedItemEventArgs<float>> NewValue;
        public event EventHandler LastValue;
        Color activeForeColor = Color.White, activeBackColor = Color.FromArgb(64, 64, 64),
            deactiveForeColor = Color.Black, deactiveBackColor = Color.DarkGray;

        public float Val { get { return (float)((Value - Minimum) / Range); } }
        decimal Range { get { return Maximum - Minimum; } }
        public decimal Divider { get { return divider; } set { divider = value; } }
        public int AccelerationSeconds { get { return acceleration.Seconds; } set { acceleration.Seconds = value; } }
        public decimal AccelerationIncrement { get { return acceleration.Increment; } set { acceleration.Increment = value; } }
        public Color ActiveForeColor { get { return activeForeColor; } set { activeForeColor = value; } }
        public Color ActiveBackColor { get { return activeBackColor; } set { activeBackColor = value; } }
        public Color DeactiveForeColor
        {
            get { return deactiveForeColor; }
            set
            {
                deactiveForeColor = value;
                ForeColor = value;
            }
        }
        public Color DeactiveBackColor
        {
            get { return deactiveBackColor; }
            set
            {
                deactiveBackColor = value;
                BackColor = value;
            }
        }

        public CnumericUpDown()
        {
            ValueChanged += nud_ValueChanged;
            Accelerations.Add(acceleration);
            Select(Text.Length, 0);
        }

        public void SetValIn(float value)
        {
            ValueChanged -= nud_ValueChanged;
            Value = (decimal)value * Range + Minimum;
            ValueChanged += nud_ValueChanged;
        }
        void nud_ValueChanged(object sender, EventArgs e)
        {
            OnNewValue();
            if (!downed) OnLastValue(e);
        }
        void OnNewValue()
        {
            if (NewValue != null) NewValue(this, new LinkedItemEventArgs<float>(Val));
        }
        void OnLastValue(EventArgs e)
        {
            if (LastValue != null) LastValue(this, e);
        }
        protected override void OnEnter(EventArgs e)
        {
            Select(Text.Length, 0);
            base.OnEnter(e);
        }
        protected override void OnLeave(EventArgs e)
        {
            changed = false;
            base.OnLeave(e);
        }
        protected override void OnGotFocus(EventArgs e)
        {
            BackColor = activeBackColor;
            ForeColor = activeForeColor;
            base.OnGotFocus(e);
        }
        protected override void OnLostFocus(EventArgs e)
        {
            BackColor = deactiveBackColor;
            ForeColor = deactiveForeColor;
            base.OnLostFocus(e);
        }
        protected override void OnTextChanged(EventArgs e)
        {
            int len = Text.Length, sp = 0, n;
            for (int i = len - 1; i >= 0; i--) if (!char.IsDigit(Text[i])) { sp = i; break; }
            int max = (int)Maximum, lenmax = max.ToString(CultureInfo.InvariantCulture).Length;
            n = len - 1 - sp;
            if (n > DecimalPlaces || sp > lenmax) Value.ToString(CultureInfo.InvariantCulture);
            changed = true;
            base.OnTextChanged(e);
        }
        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (e.KeyCode == Keys.Return) e.SuppressKeyPress = true;
            if (e.KeyCode == Keys.Enter && changed) OnLastValue(e);
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (Width - e.X < 19)
            {
                if (e.Button == MouseButtons.Right) Value = default(decimal);
                else if (e.Button == MouseButtons.Left)
                {
                    downed = true;
                    Cursor = Cursors.SizeNS;
                    y0 = e.Y;
                }
            }
            base.OnMouseDown(e);
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (downed)
            {
                int y = e.Y;
                decimal dy = (y0 - y) / Divider;
                y0 = y;
                decimal value = Value + dy;
                Value = value < Minimum ? Minimum : value > Maximum ? Maximum : value;
            }
            base.OnMouseMove(e);
        }
        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            downed = false;
            Cursor = Cursors.Default;
            base.OnMouseUp(mevent);
        }
    }
}
