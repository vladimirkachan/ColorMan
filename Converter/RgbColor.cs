
using System;
using System.Drawing;
using System.Globalization;
using ColorMan.ExtensionLibrary;

namespace ColorMan.ColorSpaces.Converter
{
    public struct RgbColor : IEquatable<RgbColor>
    {
        readonly double rComponent, gComponent, bComponent;

        public double RComponent { get { return rComponent; } }
        public double GComponent { get { return gComponent; } }
        public double BComponent { get { return bComponent; } }
        public Vector Vector { get { return new Vector(rComponent, gComponent, bComponent); } }

        public RgbColor(double rComponent, double gComponent, double bComponent)
        {
            this.rComponent = rComponent;
            this.gComponent = gComponent;
            this.bComponent = bComponent;
        }
        public RgbColor(Color color)
        {
            rComponent = color.R / 255.0;
            gComponent = color.G / 255.0;
            bComponent = color.B / 255.0;
        }

        public RgbColor(XyzColor input)
        {
            Vector v = XyzColor.XyzToRgbMatrix * input.Vector;
            rComponent = SRGBCompanding(v.CoordinateX).CutRange(0, 1);
            gComponent = SRGBCompanding(v.CoordinateY).CutRange(0, 1);
            bComponent = SRGBCompanding(v.CoordinateZ).CutRange(0, 1);
        }
        public XyzColor ToXyz()
        {
            double R = InverseSRGBCompanding(rComponent);
            double G = InverseSRGBCompanding(gComponent);
            double B = InverseSRGBCompanding(bComponent);
            Vector v = XyzColor.RgbToXyzMatrix * new Vector(R, G, B);
            return new XyzColor(v.CoordinateX, v.CoordinateY, v.CoordinateZ);
        }
        public Color ToColor()
        {
            return Color.FromArgb((int)Math.Round(rComponent * 255, MidpointRounding.AwayFromZero),
                (int)Math.Round(gComponent * 255, MidpointRounding.AwayFromZero),
                (int)Math.Round(bComponent * 255, MidpointRounding.AwayFromZero));
        }
        static double SRGBCompanding(double v)
        {
            return v <= 0.0031308 ? 12.92 * v : 1.055 * Math.Pow(v, 1 / 2.4d) - 0.055;
        }
        static double InverseSRGBCompanding(double v)
        {
            return v <= 0.04045 ? v / 12.92 : Math.Pow((v + 0.055) / 1.055, 2.4);
        }
        public bool Equals(RgbColor other)
        {
            return rComponent.Equals(other.rComponent) && gComponent.Equals(other.gComponent) &&
            bComponent.Equals(other.bComponent);
        }
        public override bool Equals(object obj)
        {
            IEquatable<RgbColor> other = obj as IEquatable<RgbColor>;
            if (other == null) return false;
            return other.Equals(this);
        }
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture,
                "RGB [r={0:0.##}, g={1:0.##}, b={2:0.##}]", rComponent, gComponent, bComponent);
        }
        public static bool operator ==(RgbColor arg1, RgbColor arg2)
        {
            return arg1.Equals(arg2);
        }
        public static bool operator !=(RgbColor arg1, RgbColor arg2)
        {
            return !arg1.Equals(arg2);
        }
    }
}
