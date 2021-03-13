using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask
{
    public class Point
    {
        private readonly double x;
        private readonly double y;

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public Point(Point point)
        {
            x = point.X;
            y = point.Y;
        }

        public double X { get => x; }
        public double Y { get => y; }

        public static double Distance(Point first, Point second)
        {
            return Math.Sqrt(Math.Pow(second.X - first.X, 2) + Math.Pow(second.Y - first.Y, 2));
        }

        public static bool IsOnOneLine(Point first, Point second, Point third)
        {
            if ((third.X - first.X) / (second.X - first.X) == (third.Y - first.Y) / (second.Y - first.Y))
                return true;
            else
                return false;
        }

        public override string ToString()
        {
            return "(" + x + ", " + y + ")";
        }

        public override bool Equals(object obj)
        {
            return obj is Point point &&
                   x == point.x &&
                   y == point.y &&
                   X == point.X &&
                   Y == point.Y;
        }

        public override int GetHashCode()
        {
            int hashCode = -624234986;
            hashCode = hashCode * -1521134295 + x.GetHashCode();
            hashCode = hashCode * -1521134295 + y.GetHashCode();
            hashCode = hashCode * -1521134295 + X.GetHashCode();
            hashCode = hashCode * -1521134295 + Y.GetHashCode();
            return hashCode;
        }
    }
}
