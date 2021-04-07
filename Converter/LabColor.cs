using System;
using System.Globalization;
using ColorMan.ExtensionLibrary;

namespace ColorMan.ColorSpaces.Converter
{
    public struct LabColor : IEquatable<LabColor>
    {
        const double Epsilon = 216d / 24389d, Kappa = 24389d / 27d;

        readonly double lComponent, aComponent, bComponent;

        public double LComponent { get { return lComponent; } }
        public double AComponent { get { return aComponent; } }
        public double BComponent { get { return bComponent; } }

        public Vector Vector { get { return new Vector(lComponent, aComponent, bComponent); } }

        public LabColor(double lComponent, double aComponent, double bComponent)
        {
            this.lComponent = lComponent;
            this.aComponent = aComponent;
            this.bComponent = bComponent;
        }
        public LabColor(XyzColor input)
        {
            XyzColor source = ChromaticAdaptation(input, LmsColor.Diagonal1);
            double xr = source.XComponent / Illuminants.D50.CoordinateX,
                   yr = source.YComponent / Illuminants.D50.CoordinateY,
                   zr = source.ZComponent / Illuminants.D50.CoordinateZ;
            Func<double, double> f = v => v > Epsilon ? Math.Pow(v, 1 / 3d) : (Kappa * v + 16) / 116d;
            double fx = f(xr);
            double fy = f(yr);
            double fz = f(zr);
            lComponent = 116 * fy - 16;
            aComponent = 500 * (fx - fy);
            bComponent = 200 * (fy - fz);
        }

        public XyzColor ToXyz()
        {
            double fy = (lComponent + 16) / 116d;
            double fx = aComponent / 500d + fy;
            double fz = fy - bComponent / 200d;

            double fx3 = Math.Pow(fx, 3);
            double fz3 = Math.Pow(fz, 3);

            double xr = fx3 > CIEConstants.Epsilon ? fx3 : (116 * fx - 16) / CIEConstants.Kappa;
            double yr = lComponent > CIEConstants.Kappa * CIEConstants.Epsilon
            ? Math.Pow((lComponent + 16) / 116d, 3) : lComponent / CIEConstants.Kappa;
            double zr = fz3 > CIEConstants.Epsilon ? fz3 : (116 * fz - 16) / CIEConstants.Kappa;

            double Xr = Illuminants.D50.CoordinateX, Yr = Illuminants.D50.CoordinateY, Zr = Illuminants.D50.CoordinateZ;

            xr = xr.CutRange(0, 1);
            yr = yr.CutRange(0, 1);
            zr = zr.CutRange(0, 1);

            XyzColor source = new XyzColor(xr * Xr, yr * Yr, zr * Zr);
            return ChromaticAdaptation(source, LmsColor.Diagonal2);
        }

        static XyzColor ChromaticAdaptation(XyzColor source, Vector diagonal)
        {
            LmsColor s = new LmsColor(source.Vector);
            Vector mult = new Vector(s.LComponent * diagonal.CoordinateX, s.MComponent * diagonal.CoordinateY,
                                     s.SComponent * diagonal.CoordinateZ);
            LmsColor t = new LmsColor(mult.CoordinateX, mult.CoordinateY, mult.CoordinateZ);
            return t.ToXyz();
        }
        public bool Equals(LabColor other)
        {
            return lComponent.Equals(other.lComponent) && aComponent.Equals(other.aComponent) &&
            bComponent.Equals(other.bComponent);
        }
        public override bool Equals(object obj)
        {
            IEquatable<LabColor> other = obj as IEquatable<LabColor>;
            if (other == null) return false;
            return other.Equals(this);
        }
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture, "Lab [L={0:0.##}, a={1:0.##}, b={2:0.##}]", lComponent,
                                 aComponent, bComponent);
        }
        public static bool operator ==(LabColor arg1, LabColor arg2)
        {
            return arg1.Equals(arg2);
        }
        public static bool operator !=(LabColor arg1, LabColor arg2)
        {
            return !arg1.Equals(arg2);
        }
    }
}
