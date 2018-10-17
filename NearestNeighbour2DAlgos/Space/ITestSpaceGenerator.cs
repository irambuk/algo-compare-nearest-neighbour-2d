using System;
using System.Collections.Generic;
using System.Text;

namespace NearestNeighbour2DAlgos.Space
{
    public interface ITestSpaceGenerator
    {
        List<PointInSpace> GenerateTestSpace(int noOfPoints, int minX, int maxX, int minY, int maxY);
    }
}
