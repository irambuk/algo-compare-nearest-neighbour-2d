using NearestNeighbour2DAlgos.Searcher;
using NearestNeighbour2DAlgos.Space;
using System;
using System.Collections.Generic;
using System.Text;

namespace NearestNeighbour2DAlgos.Executor
{
    public interface ISearchExecutor
    {
        ExecutionResult ExecuteSearch(INearestNeighbourSearcher searcher, PointInSpace currentPoint, int noOfNeighboursToFind, List<PointInSpace> pointsInSpace);
    }
}
