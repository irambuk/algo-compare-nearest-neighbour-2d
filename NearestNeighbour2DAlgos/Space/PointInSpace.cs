using System;

namespace NearestNeighbour2DAlgos.Space
{
    public class PointInSpace
    {
        public int X { get; set; }

        public int Y { get; set; }

        public double CalculateDistance(PointInSpace a)
        {
            var x2 = Math.Pow((a.X - X), 2);
            var y2 = Math.Pow((a.Y - Y), 2);
            return Math.Sqrt(x2 + y2);
        }
    }
}
