using System;
using System.Globalization;

namespace ColorMan.ColorSpaces.Converter
{
    public struct Matric : IEquatable<Matric>
    {
        double aItem, bItem, cItem, dItem, eItem, fItem, gItem, hItem, iItem;

        public double AItem { get { return aItem; } }
        public double BItem { get { return bItem; } }
        public double CItem { get { return cItem; } }
        public double DItem { get { return dItem; } }
        public double EItem { get { return eItem; } }
        public double FItem { get { return fItem; } }
        public double GItem { get { return gItem; } }
        public double HItem { get { return hItem; } }
        public double IItem { get { return iItem; } }

        public Matric(double aItem, double bItem, double cItem, double dItem, double eItem, double fItem, double gItem,
                      double hItem, double iItem)
        {
            this.aItem = aItem; //          A   B   C       
            this.bItem = bItem;
            this.cItem = cItem; //          D   E   F
            this.dItem = dItem;
            this.eItem = eItem; //          G   H   I
            this.fItem = fItem;
            this.gItem = gItem;
            this.hItem = hItem;
            this.iItem = iItem;
        }

        public static Matric operator *(Matric arg1, Matric arg2)
        {
            return Multiply(arg1, arg2);
        }
        public static Vector operator *(Matric matric, Vector vector)
        {
            return Multiply(matric, vector);
        }
        public static Vector operator *(Vector vector, Matric matric)
        {
            return Multiply(matric, vector);
        }
        public static Matric Multiply(Matric arg1, Matric arg2)
        {
            Matric z = new Matric();
            z.aItem = arg1.aItem * arg2.aItem + arg1.dItem * arg2.bItem + arg1.gItem * arg2.cItem;
            z.bItem = arg1.bItem * arg2.aItem + arg1.eItem * arg2.bItem + arg1.hItem * arg2.cItem;
            z.cItem = arg1.cItem * arg2.aItem + arg1.fItem * arg2.bItem + arg1.iItem * arg2.cItem;
            z.dItem = arg1.aItem * arg2.dItem + arg1.dItem * arg2.eItem + arg1.gItem * arg2.fItem;
            z.eItem = arg1.bItem * arg2.dItem + arg1.eItem * arg2.eItem + arg1.hItem * arg2.fItem;
            z.fItem = arg1.cItem * arg2.dItem + arg1.fItem * arg2.eItem + arg1.iItem * arg2.fItem;
            z.gItem = arg1.aItem * arg2.gItem + arg1.dItem * arg2.hItem + arg1.gItem * arg2.iItem;
            z.hItem = arg1.bItem * arg2.gItem + arg1.eItem * arg2.hItem + arg1.hItem * arg2.iItem;
            z.iItem = arg1.cItem * arg2.gItem + arg1.fItem * arg2.hItem + arg1.iItem * arg2.iItem;
            return z;
        }
        static Vector Multiply(Matric matric, Vector vector) //       X   Y   Z
        {
            double v1, v2, v3;
            v1 = matric.aItem * vector.CoordinateX + matric.dItem * vector.CoordinateY +
            matric.gItem * vector.CoordinateZ;
            v2 = matric.bItem * vector.CoordinateX + matric.eItem * vector.CoordinateY +
            matric.hItem * vector.CoordinateZ;
            v3 = matric.cItem * vector.CoordinateX + matric.fItem * vector.CoordinateY +
            matric.iItem * vector.CoordinateZ;
            return new Vector(v1, v2, v3);
        }
        public bool Equals(Matric other)
        {
            return aItem.Equals(other.aItem) && bItem.Equals(other.bItem) && cItem.Equals(other.cItem) &&
            dItem.Equals(other.dItem) && eItem.Equals(other.eItem) && fItem.Equals(other.fItem) &&
            gItem.Equals(other.gItem) && hItem.Equals(other.hItem) && iItem.Equals(other.iItem);
        }
        public override bool Equals(object obj)
        {
            IEquatable<Matric> other = obj as IEquatable<Matric>;
            if (other == null) return false;
            return other.Equals(this);
        }
        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture,
                                 "Matric [a={0:0.##}, b={0:0.##}, c={0:0.##}], d={0:0.##}, e={0:0.##}, f={0:0.##}]," +
                                 " g={0:0.##}, h={0:0.##}, i={0:0.##}]");
        }
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
        public static bool operator ==(Matric arg1, Matric arg2)
        {
            return arg1.Equals(arg2);
        }
        public static bool operator !=(Matric arg1, Matric arg2)
        {
            return !arg1.Equals(arg2);
        }
    }
}