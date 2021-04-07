using System;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ColorMan.ColorSpaces;
using ColorMan.ContractLibrary;

namespace ColorMan.ControlsLibrary
{
    public class HexTextBox : TextBox, ILinkedItem<IBaseSpace>, IDirectedCrement
    {
        const string HSL = "HSL", HSV = "HSV", LAB = "LAB", RGB = "RGB", CMYK = "CMYK";
        public event EventHandler<LinkedItemEventArgs<IBaseSpace>> NewValue;
        public event EventHandler LastValue;
        IBaseSpace val = Rgb.Empty;
        bool changed;
        Color activeForeColor = Color.White, activeBackColor = Color.FromArgb(64, 64, 64),
            deactiveForeColor = Color.Black, deactiveBackColor = Color.DarkGray;

        public override int MaxLength { get { return 6; } set { base.MaxLength = value; } }
        public override string Text
        {
            get { return base.Text; }
            set
            {
                base.Text = value;
                Select(TextLength, 0);
            }
        }
        public IBaseSpace Val { get { return val; } }
        public Color Color { get { return HexText.ToColor(); } }
        string HexText
        {
            get
            {
                return TextLength == 3
                    ? Text[0].ToString() + Text[0] + Text[1] + Text[1] + Text[2] + Text[2]
                    : new string('0', 6 - TextLength) + Text;
            }
        }
        Cmyk Cmyk { get { return new Cmyk(HexText); } }
        Hsl Hsl { get { return new Hsl(HexText); } }
        Hsv Hsv { get { return new Hsv(HexText); } }
        Lab Lab { get { return new Lab(HexText); } }
        Rgb Rgb { get { return new Rgb(HexText); } }
        IBaseSpace this[string type]
        {
            get
            {
                switch (type)
                {
                    case CMYK: return Cmyk;
                    case HSL: return Hsl;
                    case HSV: return Hsv;
                    case LAB: return Lab;
                    case RGB: return Rgb;
                    default: return null;
                }
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

        public HexTextBox()
        {
            CharacterCasing = CharacterCasing.Upper;
            TextChanged += HexTextBox_TextChanged;
        }

        public void SwitchSpaceType(string type)
        {
            val = this[type];
        }
        void HexTextBox_TextChanged(object sender, EventArgs e)
        {
            changed = true;
            val = val.Create(HexText);
            OnNewValue();
        }
        void OnNewValue()
        {
            if (NewValue != null) NewValue(this, new LinkedItemEventArgs<IBaseSpace>(Val));
        }
        void OnLastValue(EventArgs e)
        {
            if (LastValue != null) LastValue(this, e);
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
        protected override void OnPreviewKeyDown(PreviewKeyDownEventArgs e)
        {
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("en-US"));
            base.OnPreviewKeyDown(e);
        }
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            int i = c;
            e.Handled = !(char.IsDigit(c) || (i > 64 && i < 71) || (i > 96 && i < 103) || c == (char)Keys.Back);
            base.OnKeyPress(e);
        }
        protected override void OnKeyDown(KeyEventArgs e)
        {
            bool control = e.Control;
            Keys keyCode = e.KeyCode;
            bool allowInsert = !ReadOnly && ((control && keyCode == Keys.V) || (e.Shift && keyCode == Keys.Insert));
            if (allowInsert)
            {
                string hex = Clipboard.GetText();
                const string Pat = @"(?i)^([\dA-F]{0,6})$";
                if (Regex.IsMatch(hex, Pat)) Text = hex;
            }
            if (control && keyCode == Keys.C) Clipboard.SetText(SelectionLength == 0 ? Text : SelectedText);
            base.OnKeyDown(e);
       }

        protected override void OnMouseWheel(MouseEventArgs e)
        {
            Crement(Math.Sign(e.Delta));
            base.OnMouseWheel(e);
        }
        public void SetValIn(IBaseSpace value)
        {
            TextChanged -= HexTextBox_TextChanged;
            val = value;
            Text = value.Hex;
            TextChanged += HexTextBox_TextChanged;
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
            if (ReadOnly) return;
            int pos = SelectionStart - 1;
            StringBuilder sb = new StringBuilder(Text);
            string s = sb[pos].ToString();
            int x = Convert.ToInt32(s, 16);
            s = ((x + delta) % 16).ToString("X", CultureInfo.InvariantCulture);
            sb[pos] = s[0];
            Text = sb.ToString();
            SelectionStart = pos + 1;
        }
    }
}
