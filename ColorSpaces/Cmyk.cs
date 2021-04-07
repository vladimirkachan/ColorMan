using System;
using System.Drawing;
using System.Globalization;
using ColorMan.ExtensionLibrary;

[assembly:CLSCompliant(true)]
namespace ColorMan.ColorSpaces
{
    public struct Cmyk : IBaseSpace, IEquatable<IBaseSpace>
    {
        public static readonly Cmyk Empty = new Cmyk();
        const float N1 = 255f, N2 = 100f;
        readonly float cyan, magenta, yellow, keyBlack;
        /// <summary>
        /// [4] 0.0 - 1.0
        /// </summary>
        public float[] GetValues()
        {
            return new[] {cyan, magenta, yellow, keyBlack};
        }
        /// <summary>
        /// 0.0 - 1.0
        /// </summary>
        public float Cyan { get { return cyan; } }
        /// <summary>
        /// 0.0 - 1.0
        /// </summary>
        public float Magenta { get { return magenta; } }
        /// <summary>
        /// 0.0 - 1.0
        /// </summary>
        public float Yellow { get { return yellow; } }
        /// <summary>
        /// 0.0 - 1.0
        /// </summary>
        public float KeyBlack { get { return keyBlack; } }
        /// <summary>
        /// 0.0 - 100.0
        /// </summary>
        public float CP { get { return cyan * N2; } }
        /// <summary>
        /// 0.0 - 100.0
        /// </summary>
        public float MP { get { return magenta * N2; } }
        /// <summary>
        /// 0.0 - 100.0
        /// </summary>
        public float YP { get { return yellow * N2; } }
        /// <summary>
        /// 0.0 - 100.0
        /// </summary>
        public float KP { get { return keyBlack * N2; } }
        /// <summary>
        /// Cmyk(0.0, m, y, k)
        /// </summary>
        public Color C1 { get { return FromCmyk(0f, magenta, yellow, keyBlack); } }
        /// <summary>
        /// Cmyk(1.0, m, y, k)
        /// </summary>
        public Color C2 { get { return FromCmyk(1f, magenta, yellow, keyBlack); } }
        /// <summary>
        /// Cmyk(c, 0.0, y, k)
        /// </summary>
        public Color M1 { get { return FromCmyk(cyan, 0f, yellow, keyBlack); } }
        /// <summary>
        /// Cmyk(c, 1.0, y, k)
        /// </summary>
        public Color M2 { get { return FromCmyk(cyan, 1f, yellow, keyBlack); } }
        /// <summary>
        /// Cmyk(c, m, 0.0, k)
        /// </summary>
        public Color Y1 { get { return FromCmyk(cyan, magenta, 0f, keyBlack); } }
        /// <summary>
        /// Cmyk(c, m, 1.0, k)
        /// </summary>
        public Color Y2 { get { return FromCmyk(cyan, magenta, 1f, keyBlack); } }
        /// <summary>
        /// Cmyk(c, m, y, 0.0)
        /// </summary>
        public Color K1 { get { return FromCmyk(cyan, magenta, yellow, 0f); } }
        /// <summary>
        /// Cmyk(c, m, y, 1.0) Black
        /// </summary>
        public static Color K2 { get { return Color.Black; } }
        public string Hex { get { return ToColor().ToHex(); } }

        public Cmyk(Color color)
        {
            float r = color.R / N1, g = color.G / N1, b = color.B / N1;
            keyBlack = 1 - Math.Max(r, Math.Max(g, b));
            cyan = (1 - r - keyBlack) / (1 - keyBlack);
            magenta = (1 - g - keyBlack) / (1 - keyBlack);
            yellow = (1 - b - keyBlack) / (1 - keyBlack);
            cyan = cyan.CutRange(0f, 1f);
            magenta = magenta.CutRange(0f, 1f);
            yellow = yellow.CutRange(0f, 1f);
            keyBlack = keyBlack.CutRange(0f, 1f);
        }
        /// <summary>
        /// (c, m, y, k) 0.0 - 1.0
        /// </summary>
        /// <param name="cyan"></param>
        /// <param name="magenta"></param>
        /// <param name="yellow"></param>
        /// <param name="keyBlack"></param>
        public Cmyk(float cyan, float magenta, float yellow, float keyBlack)
        {
            this.cyan = cyan;
            this.magenta = magenta;
            this.yellow = yellow;
            this.keyBlack = keyBlack;
        }
        /// <summary>
        /// [4] 0.0 - 1.0
        /// </summary>
        /// <param name="values"></param>
        public Cmyk(float[] values) : this(values[0], values[1], values[2], values[3]) { }
        public Cmyk(string hex) : this(hex.ToColor()) { }

        public IBaseSpace Create(Color color)
        {
            return new Cmyk(color);
        }
        public IBaseSpace Create(string hex)
        {
            return new Cmyk(hex);
        }
        /// <summary>
        /// (c, m, y, k) 0.0 - 1.0
        /// </summary>
        /// <param name="argC"></param>
        /// <param name="argM"></param>
        /// <param name="argY"></param>
        /// <param name="argK"></param>
        /// <returns></returns>
        public static Color FromCmyk(float argC, float argM, float argY, float argK)
        {
            int r = (int)Math.Round(N1 * (1 - argC) * (1 - argK)), g = (int)Math.Round(N1 * (1 - argM) * (1 - argK)),
                b = (int)Math.Round(N1 * (1 - argY) * (1 - argK));
            return Color.FromArgb(r, g, b);
        }
        public Color ToColor()
        {
            return FromCmyk(cyan, magenta, yellow, keyBlack);
        }
        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture, 
                "CMYK ({0:0}%, {1:0}%, {2:0}%, {3:0}%)", cyan * N2, magenta * N2, yellow * N2, keyBlack * N2);
        }
        public bool Equals(IBaseSpace other)
        {
            if (!(other is Cmyk)) return false;
            Cmyk oth = (Cmyk)other;
            return cyan.Equals(oth.cyan) && magenta.Equals(oth.magenta) && yellow.Equals(oth.yellow) &&
            keyBlack.Equals(oth.keyBlack);
        }
        public override bool Equals(object obj)
        {
            IBaseSpace other = obj as IBaseSpace;
            if (other == null) return false;
            return Equals(other);
        }
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
        public static bool operator ==(Cmyk arg1, Cmyk arg2)
        {
            return arg1.Equals(arg2);
        }
        public static bool operator !=(Cmyk arg1, Cmyk arg2)
        {
            return !arg1.Equals(arg2);
        }
    }
}
