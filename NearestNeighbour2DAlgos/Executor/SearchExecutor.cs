using System;
using System.Collections.Generic;
using System.Text;
using NearestNeighbour2DAlgos.Searcher;
using NearestNeighbour2DAlgos.Space;

namespace NearestNeighbour2DAlgos.Executor
{
    public class SearchExecutor : ISearchExecutor
    {
        public ExecutionResult ExecuteSearch(INearestNeighbourSearcher searcher, PointInSpace currentPoint, int noOfNeighboursToFind, List<PointInSpace> pointsInSpace)
        {
            var now = DateTime.Now;

            var neighbours = searcher.FindNearestNeighbours(currentPoint, noOfNeighboursToFind, pointsInSpace);

            var now2 = DateTime.Now;

            return new ExecutionResult
            {
                TimeInMilliseconds = now2.Subtract(now).TotalMilliseconds,
                NearestNeighbours = neighbours
            };
        }
    }
}
