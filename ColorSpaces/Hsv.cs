using System;
using System.Drawing;
using System.Globalization;

namespace ColorMan.ColorSpaces
{
    public struct Hsv : IVectorSpace, IBaseSpace, IEquatable<IBaseSpace>
    {
        public static readonly Hsv Empty = new Hsv();
        const float MinSaturation = 2f / 240f;
        public static readonly Color Black = Color.Black, White = Color.White;
        static readonly Color[] cc = new Color[7];

        readonly float hue, saturation, value;
        /// <summary>
        /// [3] 0.0 - 1.0
        /// </summary>
        public float[] GetValues()
        {
            return new[] {H01, saturation, value};
        }
        /// <summary>
        /// Vector [ 0.0-1.0, 0.0-1.0, 0.0-1.0 ]
        /// </summary>
        public Vector Linear { get { return new Vector(H01, saturation, value); } }
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
        public float Value { get { return value; } }
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
        public float VP { get { return value * 100; } }
        /// <summary>
        /// [7] { (0.0, s, v), (60.0, s, v), (120.0, s, v), (180.0, s, v), (240.0, s, v), (300.0, s, v), (360.0, s, v) } 
        /// </summary>
        public Color[] GetHueColors()
        {
            for (int i = 0; i < 6; i++) cc[i] = FromHsv(i * 60f, saturation, value);
            cc[6] = cc[0];
            return cc;
        }
        /// <summary>
        /// Hsv(h, 0.0, v)
        /// </summary>
        public Color S1 { get { return FromHsv(hue, 0f, value); } }
        /// <summary>
        /// Hsv(h, 1.0, v)
        /// </summary>
        public Color S2 { get { return FromHsv(hue, 1f, value); } }
        /// <summary>
        /// Hsv(h, s, 0.0) Black
        /// </summary>
        public static Color V1 { get { return Color.Black; } }
        /// <summary>
        /// Hsv(h, s, 1.0)
        /// </summary>
        public Color V2 { get { return FromHsv(hue, saturation, 1f); } }
        public string Hex { get { return ToColor().ToHex(); } }

        public Hsv(Color color)
        {
            hue = color.GetHue();
            byte r = color.R, g = color.G, b = color.B;
            float min = Math.Min(r, Math.Min(g, b)), max = Math.Max(r, Math.Max(g, b));
            saturation = max.Equals(0f) ? 0 : 1 - min / max;
            value = max / 255f;
        }
        /// <summary>
        /// (0.0 - 360.0, 0.0 - 1.0, 0.0 - 1.0)
        /// </summary>
        /// <param name="hue"></param>
        /// <param name="saturation"></param>
        /// <param name="value"></param>
        public Hsv(float hue, float saturation, float value)
        {
            hue = hue % 360;
            this.hue = hue < 0f ? 0f : hue;
            this.saturation = saturation < 0f ? 0f : saturation > 1f ? 1f : saturation;
            this.value = value < 0f ? 0f : value > 1f ? 1f : value;
        }
        /// <summary>
        /// [3] 0.0 - 1.0
        /// </summary>
        /// <param name="values"></param>
        public Hsv(float[] values) : this(values[0] * 360, values[1], values[2]) { }
        /// <summary>
        /// Vector [ 0.0-1.0, 0.0-1.0, 0.0-1.0 ]
        /// </summary>
        /// <param name="linear"></param>
        public Hsv(Vector linear) : this(linear.CoordinateX * 360, linear.CoordinateY, linear.CoordinateZ) { }
        public Hsv(string hex) : this(hex.ToColor()) { }

        public static Color FromHsv(float[] values)
        {
            return FromHsv(values[0] * 360, values[1], values[2]);
        }
        /// <summary>
        /// (0.0 - 360.0, 0.0 - 1.0, 0.0 - 1.0)
        /// </summary>
        /// <param name="argH"></param>
        /// <param name="argS"></param>
        /// <param name="argV"></param>
        /// <returns></returns>
        public static Color FromHsv(float argH, float argS, float argV)
        {
            argH = argH % 360;
            argH = argH < 0f ? 0f : argH;
            argS = argS < 0f ? 0f : argS > 1f ? 1f : argS;
            argV = argV < 0f ? 0f : argV > 1f ? 1f : argV;
            float hf = argH / 60;
            int hi = (int)hf;
            if (argS < MinSaturation) argS = MinSaturation;
            float f = hf - hi, p = argV * (1 - argS), q = argV * (1 - f * argS), t = argV * (1 - (1 - f) * argS);
            switch (hi)
            {
                case 0: return Clr(argV, t, p);
                case 1: return Clr(q, argV, p);
                case 2: return Clr(p, argV, t);
                case 3: return Clr(p, q, argV);
                case 4: return Clr(t, p, argV);
                default: return Clr(argV, p, q);
            }
        }
        /// <summary>
        /// Vector [ 0.0-1.0, 0.0-1.0, 0.0-1.0 ]
        /// </summary>
        /// <param name="linear"></param>
        /// <returns></returns>
        public static Color FromHsv(Vector linear)
        {
            return FromHsv(linear.CoordinateX * 360, linear.CoordinateY, linear.CoordinateZ);
        }
        static Color Clr(float r, float g, float b)
        {
            return Color.FromArgb(Vi(r), Vi(g), Vi(b));
        }
        static int Vi(float vf)
        {
            return (int)Math.Round(255 * vf);
        }
        public IBaseSpace Create(Color color)
        {
            return new Hsv(color);
        }
        public IBaseSpace Create(string hex)
        {
            return new Hsv(hex);
        }
        /// <summary>
        /// Vector [ 0.0-1.0, 0.0-1.0, 0.0-1.0 ]
        /// </summary>
        /// <param name="vector"></param>
        /// <returns></returns>
        public IVectorSpace Create(Vector vector)
        {
            return new Hsv(vector);
        }
        public Color ToColor()
        {
            return FromHsv(hue, saturation, value);
        }
        /// <summary>
        /// Vector [ 0.0-1.0, 0.0-1.0, 0.0-1.0 ]
        /// </summary>
        /// <param name="linear"></param>
        /// <returns>Color</returns>
        public Color FromSpace(Vector linear)
        {
            return FromHsv(linear);
        }
        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture, "HSV ({0:0}, {1:0}%, {2:0}%)", hue, SP, VP);
        }
        public bool Equals(IBaseSpace other)
        {
            if (other is Hsv)
            {
                Hsv oth = (Hsv)other;
                return hue.Equals(oth.hue) && saturation.Equals(oth.saturation) && value.Equals(oth.value);
            }
            return false;
        }
        public override bool Equals(object obj)
        {
            IBaseSpace other = obj as IBaseSpace;
            if (other != null) return Equals(other);
            return false;
        }
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
        public static bool operator ==(Hsv arg1, Hsv arg2)
        {
            return arg1.Equals(arg2);
        }
        public static bool operator !=(Hsv arg1, Hsv arg2)
        {
            return !arg1.Equals(arg2);
        }
    }
}
