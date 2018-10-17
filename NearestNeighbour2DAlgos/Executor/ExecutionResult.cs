using NearestNeighbour2DAlgos.Space;
using System;
using System.Collections.Generic;
using System.Text;

namespace NearestNeighbour2DAlgos.Executor
{
    public class ExecutionResult
    {
        public double TimeInMilliseconds { get; set; }

        public List<PointInSpace> NearestNeighbours { get; set; }
    }
}
