using System;
using System.Drawing;
using System.Globalization;
using ColorMan.ExtensionLibrary;

namespace ColorMan.ColorSpaces
{
    public struct Rgb : IVectorSpace, IBaseSpace, IEquatable<IBaseSpace>
    {
        public static readonly Rgb Empty = new Rgb();
        readonly float red, green, blue;
        const float Min = 0f, Max = 255f;
        /// <summary>
        /// [3] 0.0 - 1.0
        /// </summary>
        public float[] GetValues()
        {
            return new[] {R01, G01, B01};
        }
        /// <summary>
        /// Vector [ 0.0-1.0, 0.0-1.0, 0.0-1.0 ]
        /// </summary>
        public Vector Linear { get { return new Vector(R01, G01, B01); } }
        /// <summary>
        /// 0.0 - 255.0
        /// </summary>
        public float Red { get { return red; } }
        /// <summary>
        /// 0.0 - 255.0
        /// </summary>
        public float Green { get { return green; } }
        /// <summary>
        /// 0.0 - 255.0
        /// </summary>
        public float Blue { get { return blue; } }
        /// <summary>
        /// 0.0 - 1.0
        /// </summary>
        public float R01 { get { return red / Max; } }
        /// <summary>
        /// 0.0 - 1.0
        /// </summary>
        public float G01 { get { return green / Max; } }
        /// <summary>
        /// 0.0 - 1.0
        /// </summary>
        public float B01 { get { return blue / Max; } }
        /// <summary>
        /// Rgb(0.0, g, b)
        /// </summary>
        public Color R1
        {
            get
            {
                return Color.FromArgb(0, (int)Math.Round(green, MidpointRounding.AwayFromZero),
                    (int)Math.Round(blue, MidpointRounding.AwayFromZero));
            }
        }
        /// <summary>
        /// Rgb(255.0, g, b)
        /// </summary>
        public Color R2
        {
            get
            {
                return Color.FromArgb(255, (int)Math.Round(green, MidpointRounding.AwayFromZero),
                    (int)Math.Round(blue, MidpointRounding.AwayFromZero));
            }
        }
        /// <summary>
        /// Rgb(r, 0.0, b)
        /// </summary>
        public Color G1
        {
            get
            {
                return Color.FromArgb((int)Math.Round(red, MidpointRounding.AwayFromZero), 0,
                    (int)Math.Round(blue, MidpointRounding.AwayFromZero));
            }
        }
        /// <summary>
        /// Rgb(r, 255.0, b)
        /// </summary>
        public Color G2
        {
            get
            {
                return Color.FromArgb((int)Math.Round(red, MidpointRounding.AwayFromZero), 255,
                    (int)Math.Round(blue, MidpointRounding.AwayFromZero));
            }
        }
        /// <summary>
        /// Rgb(r, g, 0.0)
        /// </summary>
        public Color B1
        {
            get
            {
                return Color.FromArgb((int)Math.Round(red, MidpointRounding.AwayFromZero),
                    (int)Math.Round(green, MidpointRounding.AwayFromZero), 0);
            }
        }
        /// <summary>
        /// Rgb(r, g, 255.0)
        /// </summary>
        public Color B2
        {
            get
            {
                return Color.FromArgb((int)Math.Round(red, MidpointRounding.AwayFromZero),
                    (int)Math.Round(green, MidpointRounding.AwayFromZero), 255);
            }
        }
        public string Hex
        {
            get
            {
                return string.Format(CultureInfo.InvariantCulture, 
                    "{0:x2}{1:x2}{2:x2}", (byte)Math.Round(red, MidpointRounding.AwayFromZero),
                                     (byte)Math.Round(green, MidpointRounding.AwayFromZero),
                                     (byte)Math.Round(blue, MidpointRounding.AwayFromZero));
            }
        }

        public Rgb(Color color)
        {
            red = color.R;
            green = color.G;
            blue = color.B;
        }
        /// <summary>
        /// (0.0 - 255.0, 0.0 - 255.0, 0.0 - 255.0)
        /// </summary>
        /// <param name="red"></param>
        /// <param name="green"></param>
        /// <param name="blue"></param>
        public Rgb(float red, float green, float blue)
        {
            this.red = red < Min ? Min : red > Max ? Max : red;
            this.green = green < Min ? Min : green > Max ? Max : green;
            this.blue = blue < Min ? Min : blue > Max ? Max : blue;
        }
        /// <summary>
        /// [3] 0.0 - 1.0
        /// </summary>
        /// <param name="values"></param>
        public Rgb(float[] values) : this(values[0] * Max, values[1] * Max, values[2] * Max) { }
        /// <summary>
        /// Vector [ 0.0-1.0, 0.0-1.0, 0.0-1.0 ]
        /// </summary>
        /// <param name="linear"></param>
        public Rgb(Vector linear)
        {
            red = Max * linear.CoordinateX;
            green = Max * linear.CoordinateY;
            blue = Max * linear.CoordinateZ;
        }
        public Rgb(string hex)
        {
            int len = hex.Length;
            if (len == 3) hex = hex[0].ToString() + hex[0] + hex[1] + hex[1] + hex[2] + hex[2];
            if (len != 6) throw new ArgumentException(hex);
            red = int.Parse(hex.Substring(0, 2), NumberStyles.AllowHexSpecifier, CultureInfo.InvariantCulture);
            green = int.Parse(hex.Substring(2, 2), NumberStyles.AllowHexSpecifier, CultureInfo.InvariantCulture);
            blue = int.Parse(hex.Substring(4, 2), NumberStyles.AllowHexSpecifier, CultureInfo.InvariantCulture);
        }

        public IBaseSpace Create(Color color)
        {
            return new Rgb(color);
        }
        public IBaseSpace Create(string hex)
        {
            return new Rgb(hex);
        }
        /// <summary>
        /// Vector [ 0.0-1.0, 0.0-1.0, 0.0-1.0 ]
        /// </summary>
        /// <param name="vector"></param>
        /// <returns></returns>
        public IVectorSpace Create(Vector vector)
        {
            return new Rgb(vector);
        }
        public Color ToColor()
        {
            return Color.FromArgb((int)red, (int)green, (int)blue);
        }
        /// <summary>
        /// [3] 0.0 - 1.0
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static Color FromRgb(float[] values)
        {
            return FromRgb(values[0] * 255, values[1] * 255, values[2] * 255);
        }
        /// <summary>
        /// (0.0 - 255.0, 0.0 - 255.0, 0.0 - 255.0)
        /// </summary>
        /// <param name="argR"></param>
        /// <param name="argG"></param>
        /// <param name="argB"></param>
        /// <returns></returns>
        public static Color FromRgb(float argR, float argG, float argB)
        {
            return Color.FromArgb((int)Math.Round(argR, MidpointRounding.AwayFromZero),
                (int)Math.Round(argG, MidpointRounding.AwayFromZero),
                (int)Math.Round(argB, MidpointRounding.AwayFromZero));
        }
        /// <summary>
        /// Vector [ 0.0-1.0, 0.0-1.0, 0.0-1.0 ]
        /// </summary>
        /// <param name="linear"></param>
        /// <returns></returns>
        public static Color FromRgb(Vector linear)
        {
            return FromRgb(linear.CoordinateX.LinearToRange(0, 255), linear.CoordinateY.LinearToRange(0, 255), linear.CoordinateZ.LinearToRange(0, 255));
        }
        /// <summary>
        /// Vector [ 0.0-1.0, 0.0-1.0, 0.0-1.0 ]
        /// </summary>
        /// <param name="linear"></param>
        /// <returns></returns>
        public Color FromSpace(Vector linear)
        {
            return FromRgb(linear);
        }
        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture, "RGB ({0:0}, {1:0}, {2:0})", red, green, blue);
        }
        public bool Equals(IBaseSpace other)
        {
            if (other is Rgb)
            {
                Rgb oth = (Rgb)other;
                return red.Equals(oth.red) && green.Equals(oth.green) && blue.Equals(oth.blue);
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
        public static bool operator ==(Rgb arg1, Rgb arg2)
        {
            return arg1.Equals(arg2);
        }
        public static bool operator !=(Rgb arg1, Rgb arg2)
        {
            return !arg1.Equals(arg2);
        }
    }
}
