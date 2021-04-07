using System;
using System.Globalization;

namespace ColorMan.ColorSpaces.Converter
{
    public struct Vector : IEquatable<Vector>
    {
        readonly double coordinateX, coordinateY, coordinateZ;

        public double CoordinateX { get { return coordinateX; } }
        public double CoordinateY { get { return coordinateY; } }
        public double CoordinateZ { get { return coordinateZ; } }

        public Vector(double coordinateX, double coordinateY, double coordinateZ)
        {
            this.coordinateX = coordinateX;
            this.coordinateY = coordinateY;
            this.coordinateZ = coordinateZ;
        }
        public Vector(Vector vector)
        {
            coordinateX = vector.coordinateX;
            coordinateY = vector.coordinateY;
            coordinateZ = vector.coordinateZ;
        }
        public bool Equals(Vector other)
        {
            return coordinateX.Equals(other.coordinateX) && coordinateY.Equals(other.coordinateY) &&
            coordinateZ.Equals(other.coordinateZ);
        }
        public override bool Equals(object obj)
        {
            IEquatable<Vector> other = obj as IEquatable<Vector>;
            if (other == null) return false;
            return other.Equals(this);
        }
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture, "Vector [x={0:0.##}, y={0:0.##}, z={0:0.##}]");
        }
        public static bool operator ==(Vector arg1, Vector arg2)
        {
            return arg1.Equals(arg2);
        }
        public static bool operator !=(Vector arg1, Vector arg2)
        {
            return !arg1.Equals(arg2);
        }
    }
}
