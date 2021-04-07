
using System;
using System.Globalization;

namespace ColorMan.ColorSpaces.Converter
{
    public struct LmsColor : IEquatable<LmsColor>
    {
        static readonly Matric toLmsMatrix = new Matric(0.8951, -0.7502, 0.0389, 0.2664, 1.7135, -0.0685, -0.1614,
                                                        0.0367, 1.0296);
        static readonly Matric fromLmsMatrix = toLmsMatrix.Inverse();
        public static readonly Vector Diagonal1 = GetDiagonal(Illuminants.D65, Illuminants.D50),
                             Diagonal2 = GetDiagonal(Illuminants.D50, Illuminants.D65);

        readonly double lComponent, mComponent, sComponent;

        public double LComponent { get { return lComponent; } }
        public double MComponent { get { return mComponent; } }
        public double SComponent { get { return sComponent; } }
        public Vector Vector { get { return new Vector(lComponent, mComponent, sComponent); } }

        public LmsColor(double lComponent, double mComponent, double sComponent)
        {
            this.lComponent = lComponent;
            this.mComponent = mComponent;
            this.sComponent = sComponent;
        }

        public LmsColor(Vector input)
        {
            Vector v = toLmsMatrix * input;
            lComponent = v.CoordinateX;
            mComponent = v.CoordinateY;
            sComponent = v.CoordinateZ;
        }

        static Vector GetDiagonal(Vector source, Vector target)
        {
            LmsColor s = new LmsColor(source), t = new LmsColor(target);
            return new Vector(t.LComponent / s.LComponent, t.MComponent / s.MComponent, t.SComponent / s.SComponent);
        }

        public XyzColor ToXyz()
        {
            Vector v = fromLmsMatrix * Vector;
            return new XyzColor(v.CoordinateX, v.CoordinateY, v.CoordinateZ);
        }
        public bool Equals(LmsColor other)
        {
            return lComponent.Equals(other.lComponent) && mComponent.Equals(other.mComponent) &&
            sComponent.Equals(other.sComponent);
        }
        public override bool Equals(object obj)
        {
            IEquatable<LmsColor> other = obj as IEquatable<LmsColor>;
            if (other == null) return false;
            return other.Equals(this);
        }
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture, "LmsColor [l={0:0.##}, m={0:0.##}, s={0:0.##}]");
        }
        public static bool operator ==(LmsColor arg1, LmsColor arg2)
        {
            return arg1.Equals(arg2);
        }
        public static bool operator !=(LmsColor arg1, LmsColor arg2)
        {
            return !arg1.Equals(arg2);
        }
    }
}
