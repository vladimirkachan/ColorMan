using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using ColorMan.ColorSpaces;
using ColorMan.ContractLibrary;

namespace ColorMan.ControlsLibrary
{
    public enum ColorSortingBy
    {
        Name,
        Hue,
        Saturation,
        Lightness,
        Value
    }

    public sealed class NamedColorBox : ComboBox, ILinkedItem<IBaseSpace>
    {
        public event EventHandler<LinkedItemEventArgs<IBaseSpace>> NewValue;
        public event EventHandler LastValue;
        readonly IComparer<NamedColor> hueComparer = new HueComparer(), saturationComparer = new SaturationComparer(),
                                       lightnessComparer = new LightnessComparer(), nameComparer = new NameComparer(),
                                       valueComparer = new ValueComparer();
        ColorSortingBy colorSortingBy = ColorSortingBy.Name;
        Color activeForeColor = Color.White, activeBackColor = Color.DimGray, deactiveForeColor = Color.Black,
              deactiveBackColor = Color.Silver;
        SolidBrush activeForeBrush = (SolidBrush)Brushes.White, deactiveForeBrush = (SolidBrush)Brushes.Black,
                   activeBackBrush, deactiveBackBrush;

        int currentIndex;

        public IBaseSpace Val { get { return new Rgb((DataSource[SelectedIndex]).Color); } }
        public ColorSortingBy SortBy { get { return colorSortingBy; } }
        new List<NamedColor> DataSource
        {
            get { return (List<NamedColor>)base.DataSource; }
            set { base.DataSource = value; }
        }
        int Count { get { return DataSource.Count; } }
        public Color ActiveForeColor
        {
            get { return activeForeColor; }
            set
            {
                activeForeColor = value;
                activeForeBrush = new SolidBrush(value);
            }
        }
        public Color ActiveBackColor
        {
            get
            {
                return activeBackColor;
            }
            set
            {
                activeBackColor = value;
                activeBackBrush = new SolidBrush(value);
            }
        }
        public Color DeactiveForeColor
        {
            get { return deactiveForeColor; }
            set
            {
                deactiveForeColor = value;
                ForeColor = value;
                deactiveForeBrush = new SolidBrush(value);
            }
        }
        public Color DeactiveBackColor
        {
            get { return deactiveBackColor; }
            set
            {
                deactiveBackColor = value;
                BackColor = value;
                deactiveBackBrush = new SolidBrush(value);
            }
        }

        public NamedColorBox()
        {
            DisplayMember = "Name";
            ValueMember = "Hex";
            DrawMode = DrawMode.OwnerDrawFixed;
            DropDownStyle = ComboBoxStyle.DropDownList;
            SelectedIndexChanged += this_SelectedIndexChanged;
            DrawItem += this_DrawItem;
        }

        public void SetDataSource(Collection<Color> colors)
        {
            List<NamedColor> namedColors = new List<NamedColor>(colors.Count + 1);
            namedColors.Add(NamedColor.Empty);
            foreach (Color c in colors) namedColors.Add(new NamedColor(c.Name, c));
            DataSource = namedColors;
        }
        public void SetValIn(IBaseSpace value)
        {
            SelectedIndexChanged -= this_SelectedIndexChanged;
            NamedColor current = new NamedColor(value.ToColor());
            DataSource[0] = current;
            SelectedIndex = DataSource.LastIndexOf(current);
            SelectedIndexChanged += this_SelectedIndexChanged;
            Invalidate();
        }
        public void GetNearest()
        {
            if (!Val.IsWebColor()) SelectedIndex = DataSource.LastIndexOf(new NamedColor(Val.ToColor().NearestWebColor()));
        }
        public void Sort(ColorSortingBy sortingBy)
        {
            colorSortingBy = sortingBy;
            SelectedIndexChanged -= this_SelectedIndexChanged;
            NamedColor current = DataSource[0];
            int n = Count - 1;
            switch (sortingBy)
            {
                case ColorSortingBy.Name:
                    DataSource.Sort(1, n, nameComparer);
                    break;
                case ColorSortingBy.Hue:
                    DataSource.Sort(1, n, saturationComparer);
                    int j;
                    for (int i = DataSource.Count - 1; ; i--)
                        if (DataSource[i].Color.GetSaturation() < 0.01)
                        {
                            j = i + 1;
                            break;
                        }
                    DataSource.Sort(1, j - 1, lightnessComparer);
                    DataSource.Sort(j, Count - j, hueComparer);
                    break;
                case ColorSortingBy.Saturation:
                    DataSource.Sort(1, n, saturationComparer);
                    break;
                case ColorSortingBy.Lightness:
                    DataSource.Sort(1, n, lightnessComparer);
                    break;
                case ColorSortingBy.Value:
                    DataSource.Sort(1, n, valueComparer);
                    break;
            }
            SelectedIndex = currentIndex = DataSource.LastIndexOf(current);
            SelectedIndexChanged += this_SelectedIndexChanged;
        }
        void this_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (DataSource != null)
            {
                int index = e.Index;
                if (DroppedDown) e.DrawBackground();
                Rectangle bounds = e.Bounds;
                Graphics gr = e.Graphics;
                var item = DataSource[index];
                string name = item.Name.ToUpperInvariant();
                int bx = bounds.X, by = bounds.Y, bw = bounds.Width, bh = bounds.Height;
                if (DroppedDown) gr.FillRectangle(index == 0 ? activeBackBrush : deactiveBackBrush, bounds);
                gr.FillRectangle(new SolidBrush(item.Color), bx, by, Height, bh);
                gr.DrawString(" " + name, Font,
                              name.Equals(DataSource[currentIndex].Name, StringComparison.OrdinalIgnoreCase) && Focused
                              ? activeForeBrush : deactiveForeBrush, new RectangleF(bx + Height, by, bw - Height, bh));
                e.DrawFocusRectangle();
            }
        }
        void this_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentIndex = SelectedIndex;
            DataSource[0] = DataSource[SelectedIndex];
            OnNewValue();
            OnLastValue(e);
            if (SelectedIndex == 0) SetValIn(Val);
            Invalidate();
        }
        void OnLastValue(EventArgs e)
        {
            if (LastValue != null) LastValue(this, e);
        }
        void OnNewValue()
        {
            if (NewValue != null) NewValue(this, new LinkedItemEventArgs<IBaseSpace>(Val));
        }
        protected override void OnEnter(EventArgs e)
        {
            BackColor = activeBackColor;
            base.OnEnter(e);
        }
        protected override void OnLeave(EventArgs e)
        {
            BackColor = deactiveBackColor;
            base.OnLeave(e);
        }

        struct NamedColor : IEquatable<NamedColor>
        {
            public static readonly NamedColor Empty = new NamedColor("", "");
            readonly string name, hex;

            public string Name { get { return name; } }
            public Color Color { get { return string.IsNullOrEmpty(hex) ? Color.Empty : hex.ToColor(); } }
            string Hex { get { return hex; } }

            private NamedColor(string name, string hex)
            {
                this.name = name;
                this.hex = hex;
            }
            public NamedColor(string name, Color color)
            {
                hex = color.ToHex();
                this.name = name.Substring(2) == hex ? "" : name;
            }
            public NamedColor(Color color) : this(ColorTranslator.FromWin32(ColorTranslator.ToWin32(color)).Name, color) { }

            public bool Equals(NamedColor other)
            {
                return hex == other.Hex;
            }
            public static bool operator ==(NamedColor x, NamedColor y)
            {
                return x.Equals(y);
            }
            public static bool operator !=(NamedColor x, NamedColor y)
            {
                return !x.Equals(y);
            }
            public override bool Equals(object obj)
            {
                if (obj is NamedColor)
                {
                    NamedColor other = (NamedColor)obj;
                    return Equals(other);
                }
                return false;
            }
            public override int GetHashCode()
            {
                return hex.GetHashCode();
            }
            public override string ToString()
            {
                return string.Format(CultureInfo.InvariantCulture, "name = {0}, hex = {1}", name, hex);
            }
        }

        class HueComparer : IComparer<NamedColor>
        {
            public int Compare(NamedColor x, NamedColor y)
            {
                Color cx = x.Color, cy = y.Color;
                int sh = Math.Sign(cx.GetHue() - cy.GetHue()), sl = Math.Sign(cx.GetBrightness() - cy.GetBrightness());
                return sh != 0 ? sh : sl != 0 ? sl : string.Compare(x.Name, y.Name, StringComparison.OrdinalIgnoreCase);
            }
        }
        class SaturationComparer : IComparer<NamedColor>
        {
            public int Compare(NamedColor x, NamedColor y)
            {
                Hsv spx = new Hsv(x.Color), spy = new Hsv(y.Color);
                int ss = Math.Sign(spx.Saturation - spy.Saturation), sh = Math.Sign(spx.Hue - spy.Hue),
                    sv = Math.Sign(spx.Value - spy.Value);
                return ss != 0 ? ss : sh != 0 ? sh : sv;
            }
        }
        class LightnessComparer : IComparer<NamedColor>
        {
            public int Compare(NamedColor x, NamedColor y)
            {
                Color cx = x.Color, cy = y.Color;
                int sl = Math.Sign(cx.GetBrightness() - cy.GetBrightness()), sh = Math.Sign(cx.GetHue() - cy.GetHue());
                return sl != 0 ? sl : sh;
            }
        }
        class NameComparer : IComparer<NamedColor>
        {
            public int Compare(NamedColor x, NamedColor y)
            {
                return string.Compare(x.Name, y.Name, StringComparison.OrdinalIgnoreCase);
            }
        }
        class ValueComparer : IComparer<NamedColor>
        {
            public int Compare(NamedColor x, NamedColor y)
            {
                Hsv spx = new Hsv(x.Color), spy = new Hsv(y.Color);
                int sv = Math.Sign(spx.Value - spy.Value), sh = Math.Sign(spx.Hue - spy.Hue),
                    ss = Math.Sign(spx.Saturation - spy.Saturation);
                return sv != 0 ? sv : sh != 0 ? sh : ss;
            }
        }
    }
}
