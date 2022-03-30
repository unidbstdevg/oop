using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sam_rab2
{
    class Vector
    {
        double x, y, z;

        public double X { get { return x; } }
        public double Y { get { return y; } }
        public double Z { get { return z; } }

        public Vector() {
            x = y = z = 1;
        }
        public Vector(double X, double Y, double Z) {
            x = X;
            y = Y;
            z = Z;
        }

        public double Abs() {
            return Math.Sqrt(x*x + y*y + z*z);
        }

        // unary minus
        public static Vector operator -(Vector a) {
            return new Vector(-a.x, -a.y, -a.z);
        }

        // operator +
        public static Vector operator +(Vector a, Vector b) {
            return new Vector(a.x + b.x, a.y + b.y, a.z + b.z);
        }
        // scalar product
        public static double operator *(Vector a, Vector b) {
            return a.x * b.x + a.y * b.y + a.z * b.z;
        }
        // vector product
        public static Vector operator &(Vector a, Vector b) {
            double i = a.y * b.z - a.z * b.y;
            double j = a.z * b.x - a.x * b.z;
            double k = a.x * b.y - a.y * b.x;
            return new Vector(i, j, k);
        }

        // product vector by number
        public static Vector operator *(Vector a, double k) {
            return new Vector(a.x * k, a.y * k, a.z * k);
        }
        public static Vector operator *(double k, Vector a) {
            return new Vector(a.x * k, a.y * k, a.z * k);
        }

        // operator ==
        public static bool operator ==(Vector a, Vector b) {
            return a.Abs() == b.Abs();
        }
        // operator !=
        public static bool operator !=(Vector a, Vector b) {
            return a.Abs() != b.Abs();
        }
        // operator >
        public static bool operator >(Vector a, Vector b) {
            return a.Abs() > b.Abs();
        }
        // operator <
        public static bool operator <(Vector a, Vector b) {
            return a.Abs() < b.Abs();
        }
        // operator >=
        public static bool operator >=(Vector a, Vector b) {
            return a.Abs() >= b.Abs();
        }
        // operator <=
        public static bool operator <=(Vector a, Vector b) {
            return a.Abs() <= b.Abs();
        }

        public override string ToString()
        {
            return String.Format("({0}, {1}, {2})", x, y, z);
        }

    }
}
