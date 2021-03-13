using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask
{
    public class TriangleValidator
    {
        public void Validate(Point pointOne, Point pointTwo, Point pointThree)
        {
            if (Point.IsOnOneLine(pointOne, pointTwo, pointThree))
            {
                throw new ArgumentException("Points should not lie on one straight line");
            }
        }

    }
}
