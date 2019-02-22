using NearestNeighbour2DAlgos.Space;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NearestNeighbour2DAlgos.Searcher
{
    public class OptimisedBruteForceNearestNeighbourSearcher : INearestNeighbourSearcher
    {
        public List<PointInSpace> FindNearestNeighbours(PointInSpace currentPoint, int noOfNeighboursToFind, List<PointInSpace> pointsInSpace)
        {
            var calculated = new List<CalculatedResult>();
            var lastLength = 0d;

            foreach (var pointInSpace in pointsInSpace)
            {
                if (pointInSpace.X == currentPoint.X && pointInSpace.Y == currentPoint.Y)
                {
                    continue; //same point
                }

                // do a quick check before calcualte distance
                if (lastLength != 0)
                {
                    if(Math.Abs(currentPoint.X - pointInSpace.X) > lastLength || Math.Abs(currentPoint.Y - pointInSpace.Y) > lastLength)
                    {
                        continue;
                    }
                }

                // calcualte distance only for remaining items
                var distance = currentPoint.CalculateDistance(pointInSpace);

                if (calculated.Count() < noOfNeighboursToFind)
                {
                    calculated.Add(new CalculatedResult { Distance = distance, Point = pointInSpace });
                    calculated = calculated.OrderBy(c => c.Distance).Take(noOfNeighboursToFind).ToList();
                    lastLength = calculated.Last().Distance;
                    continue;
                }

                if (distance < lastLength)
                {
                    calculated.Add(new CalculatedResult { Distance = distance, Point = pointInSpace });
                    calculated = calculated.OrderBy(c => c.Distance).Take(noOfNeighboursToFind).ToList();
                    lastLength = calculated.Last().Distance;
                }
            }
            
            return calculated.Select(c => c.Point).ToList();
        }
    }
}
