
using System;
using System.Globalization;

namespace ColorMan.ColorSpaces.Converter
{
    public struct XyzColor : IEquatable<XyzColor>
    {
        public static readonly Matric RgbToXyzMatrix = GetRgbToXyzMatrix(), XyzToRgbMatrix = RgbToXyzMatrix.Inverse();

        readonly double xComponent, yComponent, zComponent;

        public double XComponent { get { return xComponent; } }
        public double YComponent { get { return yComponent; } }
        public double ZComponent { get { return zComponent; } }

        public Vector Vector { get { return new Vector(xComponent, yComponent, zComponent); } }

        public XyzColor(double xComponent, double yComponent, double zComponent)
        {
            this.xComponent = xComponent;
            this.yComponent = yComponent;
            this.zComponent = zComponent;
        }
        
        static Matric GetRgbToXyzMatrix()
        {
            const double xr = 0.64, xg = 0.3, xb = 0.15, yr = 0.33, yg = 0.6, yb = 0.06;

            const double Xr = xr / yr;
            const double Yr = 1;
            const double Zr = (1 - xr - yr) / yr;

            const double Xg = xg / yg;
            const double Yg = 1;
            const double Zg = (1 - xg - yg) / yg;

            const double Xb = xb / yb;
            const double Yb = 1;
            const double Zb = (1 - xb - yb) / yb;

            Matric S = new Matric(Xr, Yr, Zr, Xg, Yg, Zg, Xb, Yb, Zb).Inverse();
            Vector v = S * Illuminants.D65;
            double Sr = v.CoordinateX, Sg = v.CoordinateY, Sb = v.CoordinateZ;

            return new Matric(Sr * Xr, Sr * Yr, Sr * Zr, Sg * Xg, Sg * Yg, Sg * Zg, Sb * Xb, Sb * Yb, Sb * Zb);
        }
        public bool Equals(XyzColor other)
        {
            return xComponent.Equals(other.xComponent) && yComponent.Equals(other.yComponent) &&
            zComponent.Equals(other.zComponent);
        }
        public override bool Equals(object obj)
        {
            IEquatable<XyzColor> other = obj as IEquatable<XyzColor>;
            if (other == null) return false;
            return other.Equals(this);
        }
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture, "XYZ [x={0:0.##}, y={1:0.##}, z={2:0.##}]", xComponent,
                                 yComponent, zComponent);
        }
        public static bool operator ==(XyzColor arg1, XyzColor arg2)
        {
            return arg1.Equals(arg2);
        }
        public static bool operator !=(XyzColor arg1, XyzColor arg2)
        {
            return !arg1.Equals(arg2);
        }
    }
}
