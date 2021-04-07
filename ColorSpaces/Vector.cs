
using System;
using System.Globalization;

namespace ColorMan.ColorSpaces
{
    public struct Vector : IEquatable<Vector>
    {
        readonly float coordinateX, coordinateY, coordinateZ;

        public float CoordinateX { get { return coordinateX; } }
        public float CoordinateY { get { return coordinateY; } }
        public float CoordinateZ { get { return coordinateZ; } }

        public Vector(float coordinateX, float coordinateY, float coordinateZ)
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
            if (obj is Vector) return Equals((Vector)obj);
            return false;
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
