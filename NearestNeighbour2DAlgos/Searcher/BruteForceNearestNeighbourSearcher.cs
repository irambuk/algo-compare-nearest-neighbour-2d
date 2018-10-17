using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NearestNeighbour2DAlgos.Space;

namespace NearestNeighbour2DAlgos.Searcher
{
    public class BruteForceNearestNeighbourSearcher : INearestNeighbourSearcher
    {
        public List<PointInSpace> FindNearestNeighbours(PointInSpace currentPoint, int noOfNeighboursToFind, List<PointInSpace> pointsInSpace)
        {
            var calculated = new List<CalculatedResult>();

            foreach (var pointInSpace in pointsInSpace)
            {
                if (pointInSpace.X == currentPoint.X && pointInSpace.Y == currentPoint.Y)
                {
                    continue; //same point
                }

                var distance = CalculateDistance(pointInSpace, currentPoint);

                calculated.Add(new CalculatedResult {Distance= distance, Point = pointInSpace });

            }

            return calculated.OrderBy(c => c.Distance).Select(c => c.Point).Take(noOfNeighboursToFind).ToList();
        }

        private double CalculateDistance(PointInSpace a, PointInSpace b)
        {
            var x2 = Math.Pow((a.X - b.X), 2);
            var y2 = Math.Pow((a.Y - b.Y), 2);
            return Math.Sqrt(x2 + y2);
        }

        private class CalculatedResult
        {
            public double Distance { get; set; }

            public PointInSpace Point { get; set; }
        }
    }
}
