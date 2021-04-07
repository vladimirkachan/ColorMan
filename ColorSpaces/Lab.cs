using System;
using System.Drawing;
using System.Globalization;
using ColorMan.ColorSpaces.Converter;
using ColorMan.ExtensionLibrary;

namespace ColorMan.ColorSpaces
{
    public struct Lab : IVectorSpace, IBaseSpace, IEquatable<IBaseSpace>
    {
        public static readonly Lab Empty = new Lab();
        readonly float lightness, channelA, channelB;
        const float Min_AB = -128f, Max_AB = 127f, Range_AB = 255f, Min_L = 0f, Max_L = 100f;
        /// <summary>
        /// [3] 0.0 - 1.0
        /// </summary>
        public float[] GetValues()
        {
            return new[] {L01, A01, B01};
        }
        /// <summary>
        /// Vector [ 0.0-1.0, 0.0-1.0, 0.0-1.0 ]
        /// </summary>
        public Vector Linear { get { return new Vector(L01, A01, B01); } }
        /// <summary>
        /// 0.0 - 100.0
        /// </summary>
        public float Lightness { get { return lightness; } }
        /// <summary>
        /// -128.0 , 127.0
        /// </summary>
        public float ChannelA { get { return channelA; } }
        /// <summary>
        /// -128.0 , 127.0
        /// </summary>
        public float ChannelB { get { return channelB; } }
        /// <summary>
        /// 0.0 - 1.0
        /// </summary>
        public float L01 { get { return lightness / Max_L; } }
        /// <summary>
        /// 0.0 - 1.0
        /// </summary>
        public float A01 { get { return (channelA - Min_AB) / Range_AB; } }
        /// <summary>
        /// 0.0 - 1.0
        /// </summary>
        public float B01 { get { return (channelB - Min_AB) / Range_AB; } }
        public string Hex { get { return ToColor().ToHex(); } }

        /// <summary>
        /// [3] 0.0 - 1.0
        /// </summary>
        /// <param name="values"></param>
        public Lab(float[] values) : this(values[0] * Max_L, values[1] * Range_AB + Min_AB, values[2] * Range_AB + Min_AB) { }
        /// <summary>
        /// Vector [ 0.0-1.0, 0.0-1.0, 0.0-1.0 ]
        /// </summary>
        /// <param name="vector"></param>
        public Lab(Vector vector)
            : this(vector.CoordinateX.LinearToRange(0f, 100f), vector.CoordinateY.LinearToRange(-128f, 127f), vector.CoordinateZ.LinearToRange(-128f, 127f)) { }
        /// <summary>
        /// (0.0 - 100 , -128.0  127.0 , -128.0  127.0)
        /// </summary>
        /// <param name="lightness"></param>
        /// <param name="channelA"></param>
        /// <param name="channelB"></param>
        public Lab(float lightness, float channelA, float channelB)
        {
            this.lightness = lightness < Min_L ? Min_L : lightness > Max_L ? Max_L : lightness;
            this.channelA = channelA < Min_AB ? Min_AB : channelA > Max_AB ? Max_AB : channelA;
            this.channelB = channelB < Min_AB ? Min_AB : channelB > Max_AB ? Max_AB : channelB;
        }
        public Lab(Color color)
        {
            LabColor lc = new LabColor(new RgbColor(color).ToXyz());
            lightness = (float)lc.LComponent;
            channelA = (float)lc.AComponent;
            channelB = (float)lc.BComponent;
        }
        public Lab(string hex) : this(hex.ToColor()) { }

        public IBaseSpace Create(Color color)
        {
            return new Lab(color);
        }
        public IBaseSpace Create(string hex)
        {
            return new Lab(hex);
        }
        /// <summary>
        /// Vector [ 0.0-1.0, 0.0-1.0, 0.0-1.0 ]
        /// </summary>
        /// <param name="vector"></param>
        /// <returns></returns>
        public IVectorSpace Create(Vector vector)
        {
            return new Lab(vector);
        }
        /// <summary>
        /// (0.0 - 100 , -128.0  127.0 , -128.0  127.0)
        /// </summary>
        /// <param name="argL"></param>
        /// <param name="argA"></param>
        /// <param name="argB"></param>
        /// <returns></returns>
        public static Color FromLab(float argL, float argA, float argB)
        {
            return new RgbColor(new LabColor(argL, argA, argB).ToXyz()).ToColor();
        }
        /// <summary>
        /// [3] 0.0 - 1.0
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static Color FromLab(float[] values)
        {
            return FromLab(values[0].LinearToRange(0f, 100f), values[1].LinearToRange(-128f, 127f), values[2].LinearToRange(-128f, 127f));
        }
        /// <summary>
        /// Vector [ 0.0-1.0, 0.0-1.0, 0.0-1.0 ]
        /// </summary>
        /// <param name="vector"></param>
        /// <returns></returns>
        public static Color FromLab(Vector vector)
        {
            return FromLab(vector.CoordinateX.LinearToRange(0f, 100f), vector.CoordinateY.LinearToRange(-128f, 127f), vector.CoordinateZ.LinearToRange(-128f, 127f));
        }
        public Color ToColor()
        {
            return FromLab(lightness, channelA, channelB);
        }
        /// <summary>
        /// Vector [ 0.0-1.0, 0.0-1.0, 0.0-1.0 ]
        /// </summary>
        /// <param name="linear"></param>
        /// <returns></returns>
        public Color FromSpace(Vector linear)
        {
            return FromLab(linear);
        }
        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture, "LAB ({0:0}, {1:0}, {2:0})", lightness, channelA, channelB);
        }
        public bool Equals(IBaseSpace other)
        {
            if (other is Lab)
            {
                Lab oth = (Lab)other;
                return lightness.Equals(oth.lightness) && channelA.Equals(oth.channelA) && channelB.Equals(oth.channelB);
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
        public static bool operator ==(Lab arg1, Lab arg2)
        {
            return arg1.Equals(arg2);
        }
        public static bool operator !=(Lab arg1, Lab arg2)
        {
            return !arg1.Equals(arg2);
        }
    }
}
