using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Point3D : IComparable<Point3D> , ICloneable
    {
        public double x,y,z;

        public Point3D(double _x, double _y, double _z)
        {
            x = _x;
            y = _y;
            z = _z;
        }
        public Point3D(double value) : this(value, value, value)
        {

        }
        public Point3D() : this(0, 0, 0)
        {

        }

        public override string ToString()
        {
            return $"Point Coordinates ({x}, {y}, {z})";
        }

        public override bool Equals(object? obj)
        {
            if(obj is Point3D other)
                return this.x == other.x && this.y == other.y && this.z == other.z;
            return false;
        }

        public int CompareTo(Point3D? other)
        {
            //if (other == null) return 1; // null is considered less than any instance
            //if (this.x != other.x) 
            //    return this.x.CompareTo(other.x);
            //if (this.y != other.y) 
            //    return this.y.CompareTo(other.y);
            //return this.z.CompareTo(other.z);

            return other == null ? 1 : (x, y, z).CompareTo((other.x, other.y, other.z));
        }

        public object Clone()
        {
            return new Point3D(this.x, this.y, this.z);
        }

        public static bool operator ==(Point3D p1, Point3D p2)
        {
            return p1.Equals(p2);
        }
        public static bool operator !=(Point3D p1, Point3D p2)
        {
            return !p1.Equals(p2);
        }
    }
}

