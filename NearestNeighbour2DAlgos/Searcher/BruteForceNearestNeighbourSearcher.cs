using System.Collections.Generic;
using System.Linq;
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

                var distance = currentPoint.CalculateDistance(pointInSpace);

                calculated.Add(new CalculatedResult {Distance= distance, Point = pointInSpace });

            }

            return calculated.OrderBy(c => c.Distance).Select(c => c.Point).Take(noOfNeighboursToFind).ToList();
        } 
    }
}
