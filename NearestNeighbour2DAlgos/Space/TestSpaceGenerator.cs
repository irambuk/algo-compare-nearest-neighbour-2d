using System;
using System.Collections.Generic;
using System.Text;

namespace NearestNeighbour2DAlgos.Space
{
    public class TestSpaceGenerator : ITestSpaceGenerator
    {
        public List<PointInSpace> GenerateTestSpace(int noOfPoints, int minX, int maxX, int minY, int maxY)
        {
            var points = new List<PointInSpace>();

            var random = new Random();
            for (int i = 0; i < noOfPoints; i++)
            {
                var x = random.Next(minX, maxX);
                var y = random.Next(minY, maxY);

                points.Add(new PointInSpace { X = x, Y = y });
            }

            return points;
        }
    }
}
