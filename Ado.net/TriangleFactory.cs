using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask
{
    public class TriangleFactory
    {
        private static readonly TriangleValidator triangleValidator = new TriangleValidator();

        public static Triangle CreateTriangle(double firstX, double firstY,
            double secondX, double SecondY,
            double thirdX, double thirdY)
        {
            triangleValidator.Validate(new Point(firstX, firstY),
                new Point(secondX, SecondY),
                new Point(thirdX, thirdY));
            return new Triangle(new Point(firstX, firstY),
                new Point(secondX, SecondY),
                new Point(thirdX, thirdY));
        }

        public static Triangle CreateTriangle(String fileName)
        {
            char[] delimiterChars = { ' ', '\n' };
            string temp;
            Point[] points = new Point[3];
            using (StreamReader input = new StreamReader(fileName))
            {
                temp = input.ReadToEnd();
            }
            string[] info = temp.Split(delimiterChars);
            if(info.Length != 6)
            {
                throw new ArgumentException("The file must have 6 variables");
            }
            for (int i = 0; i < info.Length/2;i++)
            {
                points[i] = new Point(double.Parse(info[i * 2]), double.Parse(info[i * 2 + 1])); 
            }
            triangleValidator.Validate(points[0],points[1], points[2]);
            return new Triangle(points);
        }
    }
}
