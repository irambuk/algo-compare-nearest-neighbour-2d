using NearestNeighbour2DAlgos.Space;
using System.Collections.Generic;

namespace NearestNeighbour2DAlgos.Searcher
{
    public interface INearestNeighbourSearcher
    {
        List<PointInSpace> FindNearestNeighbours(PointInSpace currentPoint, int noOfNeighboursToFind, List<PointInSpace> pointsInSpace);
    }
}
