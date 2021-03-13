using System.Collections.Generic;
using System;

namespace FirstTask
{
    public class Triangle
    {
        private readonly Point pointOne;
        private readonly Point pointTwo;
        private readonly Point pointThree;
        private double square;
        private double perimeter;

        public Triangle(Point pointOne, Point pointTwo, Point pointThree)
        {
            Validate(pointOne, pointTwo, pointThree);
            this.pointOne = pointOne;
            this.pointTwo = pointTwo;
            this.pointThree = pointThree;
            doPerimeter();
            doSquare();
        }

        public Triangle(Point[] points)
        {
            if(points.Length != 3)
            {
                throw new ArgumentException("you must need 3 points");
            }
            Validate(points[0], points[1], points[2]);
            pointOne = points[0];
            pointTwo = points[1];
            pointThree = points[2];
            doPerimeter();
            doSquare();
        }

        public double Square { get => square; }
        public double Perimeter { get => perimeter; }

        public static void Validate(Point pointOne, Point pointTwo, Point pointThree)
        {
            if(Point.IsOnOneLine(pointOne, pointTwo, pointThree))
            {
                throw new ArgumentException("Points should not lie on one straight line");
            }
        }

        public override bool Equals(object obj)
        {
            return obj is Triangle triangle &&
                   EqualityComparer<Point>.Default.Equals(pointOne, triangle.pointOne) &&
                   EqualityComparer<Point>.Default.Equals(pointTwo, triangle.pointTwo) &&
                   EqualityComparer<Point>.Default.Equals(pointThree, triangle.pointThree);
        }

        public override int GetHashCode()
        {
            int hashCode = -691195833;
            hashCode = hashCode * -1521134295 + EqualityComparer<Point>.Default.GetHashCode(pointOne);
            hashCode = hashCode * -1521134295 + EqualityComparer<Point>.Default.GetHashCode(pointTwo);
            hashCode = hashCode * -1521134295 + EqualityComparer<Point>.Default.GetHashCode(pointThree);
            return hashCode;
        }

        public override string ToString()
        {
            return "triangle with points: " + pointOne + ", " + pointTwo + ", " + pointThree +
                "\nsquare: " + square +
                "\nperimeter: " + perimeter;
        }

        private void doPerimeter()
        {
            perimeter = Point.Distance(pointOne, pointTwo) +
                Point.Distance(pointOne, pointThree) +
                Point.Distance(pointThree, pointTwo);
        }

        private void doSquare()
        {
            double p = perimeter / 2;
            square = Math.Sqrt(p
                * (p - Point.Distance(pointOne, pointTwo))
                * (p - Point.Distance(pointOne, pointThree))
                * (p - Point.Distance(pointThree, pointTwo)));
        }
    }
}
