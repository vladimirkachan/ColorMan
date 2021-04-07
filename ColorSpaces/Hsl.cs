using System;
using System.Drawing;
using System.Globalization;

namespace ColorMan.ColorSpaces
{
    public struct Hsl : IVectorSpace, IBaseSpace, IEquatable<IBaseSpace>
    {
        public static readonly Hsl Empty = new Hsl();
        public static readonly Color Black = Color.Black, White = Color.White, Gray = Color.Gray;
        static readonly Color[] cc = new Color[7];

        readonly float hue, saturation, lightness;
        /// <summary>
        /// [3] 0.0 - 1.0
        /// </summary>
        public float[] GetValues()
        {
            return new[] {H01, saturation, lightness};
        }
        /// <summary>
        /// Vector [ 0.0-1.0, 0.0-1.0, 0.0-1.0 ]
        /// </summary>
        public Vector Linear { get { return new Vector(H01, saturation, lightness); } }
        /// <summary>
        /// 0.0 - 360.0
        /// </summary>
        public float Hue { get { return hue; } }
        /// <summary>
        /// 0.0 - 1.0
        /// </summary>
        public float Saturation { get { return saturation; } }
        /// <summary>
        /// 0.0 - 1.0
        /// </summary>
        public float Lightness { get { return lightness; } }
        /// <summary>
        /// 0.0 - 1.0
        /// </summary>
        public float H01 { get { return hue / 360; } }
        /// <summary>
        /// 0.0 - 100.0
        /// </summary>
        public float HP { get { return hue / 3.6f; } }
        /// <summary>
        /// 0.0 - 100.0
        /// </summary>
        public float SP { get { return saturation * 100; } }
        /// <summary>
        /// 0.0 - 100.0
        /// </summary>
        public float LP { get { return lightness * 100; } }
        /// <summary>
        /// Hsl(h, 0.0, l)
        /// </summary>
        public Color S1 { get { return FromHsl(hue, 0f, lightness); } }
        /// <summary>
        /// Hsl(h, 1.0, l)
        /// </summary>
        public Color S2 { get { return FromHsl(hue, 1f, lightness); } }
        /// <summary>
        /// Hsl(h, s, 0.0) Black
        /// </summary>
        public static Color L1 { get { return Black; } }
        /// <summary>
        /// Hsl(h, s, 0.5)
        /// </summary>
        public Color LM { get { return FromHsl(hue, saturation, .5f); } }
        /// <summary>
        /// Hsl(h, s, 1.0) White
        /// </summary>
        public static Color L2 { get { return White; } }
        /// <summary>
        /// [7] { (0.0, s, l), (60.0, s, l), (120.0, s, l), (180.0, s, l), (240.0, s, l), (300.0, s, l), (360.0, s, l) } 
        /// </summary>
        public Color[] GetHueColors()
        {
            for (int i = 0; i < 6; i++) cc[i] = FromHsl(i * 60f, saturation, lightness);
            cc[6] = cc[0];
            return cc;
        }
        public string Hex { get { return ToColor().ToHex(); } }

        public Hsl(Color color)
        {
            hue = color.GetHue();
            saturation = color.GetSaturation();
            lightness = color.GetBrightness();
        }
        /// <summary>
        /// (0.0 - 360.0, 0.0 - 1.0, 0.0 - 1.0)
        /// </summary>
        /// <param name="hue"></param>
        /// <param name="saturation"></param>
        /// <param name="lightness"></param>
        public Hsl(float hue, float saturation, float lightness)
        {
            this.hue = hue < 0f ? 0f : hue > 360f ? 360f : hue;
            this.saturation = saturation < 0f ? 0f : saturation > 1f ? 1f : saturation;
            this.lightness = lightness < 0f ? 0f : lightness > 1f ? 1f : lightness;
        }
        /// <summary>
        /// [3] 0.0 - 1.0
        /// </summary>
        /// <param name="values"></param>
        public Hsl(float[] values) : this(values[0] * 360, values[1], values[2]) { }
        /// <summary>
        /// Vector [ 0.0-1.0, 0.0-1.0, 0.0-1.0 ]
        /// </summary>
        /// <param name="linear"></param>
        public Hsl(Vector linear) : this(linear.CoordinateX * 360, linear.CoordinateY, linear.CoordinateZ) { }
        public Hsl(string hex) : this(hex.ToColor()) { }
        public static Color FromHsl(float argH, float argS, float argL)
        {
            const double c2 = 1.0 / 3.0;
            double q = argL < 0.5
            ? argL * (1.0 + argS) : argL + argS - argL * argS, p = 2.0 * argL - q,
                   hk = argH / 360.0, tr = C(hk + c2), tg = C(hk), tb = C(hk - c2);
            tr = C(tr, p, q);
            tg = C(tg, p, q);
            tb = C(tb, p, q);
            return Color.FromArgb((int)(tr * 255), (int)(tg * 255), (int)(tb * 255));
        }
        static double C(double tc)
        {
            return tc < 0 ? tc + 1.0 : tc > 1.0 ? tc - 1.0 : tc;
        }
        static double C(double tc, double p, double q)
        {
            const double c1 = 1.0 / 6.0, c3 = 2.0 / 3.0;
            return tc < c1 ? p + (q - p) * 6.0 * tc : tc < 0.5 ? q : tc < c3 ? p + (q - p) * 6.0 * (c3 - tc) : p;
        }
        /// <summary>
        /// [3] 0.0 - 1.0
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static Color FromHsl(float[] values)
        {
            return FromHsl(values[0] * 360, values[1], values[2]);
        }
        /// <summary>
        /// Vector [ 0.0-1.0, 0.0-1.0, 0.0-1.0 ]
        /// </summary>
        /// <param name="linear"></param>
        /// <returns></returns>
        public static Color FromHsl(Vector linear)
        {
            return FromHsl(linear.CoordinateX * 360, linear.CoordinateY, linear.CoordinateZ);
        }

        public IBaseSpace Create(Color color)
        {
            return new Hsl(color);
        }
        public IBaseSpace Create(string hex)
        {
            return new Hsl(hex);
        }
        /// <summary>
        /// Vector [ 0.0-1.0, 0.0-1.0, 0.0-1.0 ]
        /// </summary>
        /// <param name="vector"></param>
        /// <returns></returns>
        public IVectorSpace Create(Vector vector)
        {
            return new Hsl(vector);
        }
        public Color ToColor()
        {
            return FromHsl(hue, saturation, lightness);
        }
        public Color FromSpace(Vector linear)
        {
            return FromHsl(linear);
        }
        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture, "HSL ({0:0}, {1:0}%, {2:0}%)", hue, SP, LP);
        }
        public bool Equals(IBaseSpace other)
        {
            if (other is Hsl)
            {
                Hsl oth = (Hsl)other;
                return hue.Equals(oth.hue) && saturation.Equals(oth.saturation) && lightness.Equals(oth.lightness);
            }
            return false;
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
        public static bool operator ==(Hsl arg1, Hsl arg2)
        {
            return arg1.Equals(arg2);
        }
        public static bool operator !=(Hsl arg1, Hsl arg2)
        {
            return !arg1.Equals(arg2);
        }
    }
}
