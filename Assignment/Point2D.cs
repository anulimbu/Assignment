using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal struct Point2D
    {
        internal float X;
        internal float Y;
    }

    internal class DistanceCalculator
    {
        internal float CalculateDistance(Point2D point1, Point2D point2)
        {
            float deltaX = point2.X - point1.X;
            float deltaY = point2.Y - point1.Y;

            return (float)Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }
    }
}
