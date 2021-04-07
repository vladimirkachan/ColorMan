using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using ColorMan.ContractLibrary;

namespace ColorMan.ControlsLibrary
{
    public class NumberTextBox : TextBox, ILinkedItem<float>, IDirectedCrement
    {
        public event EventHandler<LinkedItemEventArgs<float>> NewValue;
        public event EventHandler LastValue;

        static readonly char separator = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator.Trim()[0];
        bool notCheck;
        float maximum = 100f;
        bool changed;
        int decimalPalces = 1;
        string format = "{0:0.#}";
        Color activeForeColor = Color.White, activeBackColor = Color.FromArgb(64, 64, 64),
            deactiveForeColor = Color.Black, deactiveBackColor = Color.DarkGray;

        public float Val { get; private set; }
        public float Minimum { get; set; }
        public float Maximum { get { return maximum; } set { maximum = value; } }
        float Range { get { return Maximum - Minimum; } }
        float Value { get { return Val * Range + Minimum; } set { Val = (value - Minimum) / Range; } }
        public int DecimalPlaces
        {
            get { return decimalPalces; }
            set
            {
                decimalPalces = value;
                format = "{0:0" + (value > 0 ? "." + new string('#', value) : "") + "}";
            }
        }
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
        public override string Text
        {
            get { return base.Text; }
            set
            {
                base.Text = value;
                Select(TextLength, 0);
            }
        }

        public NumberTextBox()
        {
            TextChanged += ctbox_TextChanged;
        }

        void ctbox_TextChanged(object sender, EventArgs e)
        {
            OnNewValue();
        }
        protected override void OnLeave(EventArgs e)
        {
            if (changed) OnLastValue(e);
            changed = false;
            base.OnLeave(e);
        }
        protected override void OnGotFocus(EventArgs e)
        {
            Select(TextLength, 0);
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
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            notCheck = c == separator || (c == '-' && TextLength == 0);
            e.Handled = !(char.IsDigit(c) || c == 8 || (c == separator && !Text.Contains(separator)) ||
                (c == '-' && Minimum < 0 && SelectionStart == 0 && !Text.Contains('-')) || c == 13);
            base.OnKeyPress(e);
        }
        protected override void OnTextChanged(EventArgs e)
        {
            if (!notCheck)
            {
                float value;
                changed = float.TryParse(Text, out value);
                Value = value < Minimum ? Minimum : value > Maximum ? Maximum : value;
                Text = string.Format(CultureInfo.InvariantCulture, format, Value);
                SelectionStart = TextLength;
            }
            notCheck = false;
            if (changed) base.OnTextChanged(e);
        }
        protected override void OnMouseWheel(MouseEventArgs e)
        {
            Crement(Math.Sign(e.Delta));
            base.OnMouseWheel(e);
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Up: ToUp(); return true;
                case Keys.Down: ToDown(); return true;
                case Keys.Left: ToLeft(); return true;
                case Keys.Right: ToRight(); return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        void OnNewValue()
        {
            if (NewValue != null) NewValue(this, new LinkedItemEventArgs<float>(Val));
        }
        void OnLastValue(EventArgs e)
        {
            if (LastValue != null) LastValue(this, e);
        }
        public void SetValIn(float value)
        {
            TextChanged -= ctbox_TextChanged;
            Val = value;
            Text = string.Format(CultureInfo.InvariantCulture, format, Value);
            TextChanged += ctbox_TextChanged;
        }
        public void ToUp()
        {
            Crement(1);
        }
        public void ToDown()
        {
            Crement(-1);
        }
        public void ToLeft()
        {
            int x = SelectionStart - 1;
            SelectionStart = x < 0 ? 0 : x;
        }
        public void ToRight()
        {
            SelectionStart = SelectionStart + 1;
        }
        void Crement(int delta)
        {
            Text = string.Format(CultureInfo.InvariantCulture, format, Value + delta);
        }
    }
}
