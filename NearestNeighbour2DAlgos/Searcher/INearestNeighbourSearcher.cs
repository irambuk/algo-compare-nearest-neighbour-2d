using NearestNeighbour2DAlgos.Space;
using System;
using System.Collections.Generic;
using System.Text;

namespace NearestNeighbour2DAlgos.Searcher
{
    public interface INearestNeighbourSearcher
    {
        List<PointInSpace> FindNearestNeighbours(PointInSpace currentPoint, int noOfNeighboursToFind, List<PointInSpace> pointsInSpace);
    }
}
