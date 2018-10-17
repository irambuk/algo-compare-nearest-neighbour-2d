using NearestNeighbour2DAlgos.Executor;
using NearestNeighbour2DAlgos.Searcher;
using NearestNeighbour2DAlgos.Space;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NearestNeighbour2DAlgos
{
    class Program
    {
        static int Main(string[] args)
        {
            var noOfPoints = 4000000;
            var pointsGenerator = new TestSpaceGenerator();
            var points = pointsGenerator.GenerateTestSpace(noOfPoints, -2000, 2000, -2000, 2000);

            var executor = new SearchExecutor();

            WriteDataTableHeader("Iteration", "BruteForce - results", "BruteForce - time", "a - results", "a - time");

            for (int i = 0; i < 10; i++)
            {
                var randomIndex = new Random().Next(0, noOfPoints);
                var point = points[randomIndex];
                var result = executor.ExecuteSearch(new BruteForceNearestNeighbourSearcher(), point, 3, points);

                WriteDataTableRow(ResultsToString(point), ResultsToString(result.NearestNeighbours), result.TimeInMilliseconds, "test", 0);
            }

            Console.WriteLine("Press any key to terminate");
            Console.ReadLine();

            return 0;
        }

        private static string ResultsToString(PointInSpace point)
        {
            return $"({point.X},{point.Y})";
        }

        private static string ResultsToString(List<PointInSpace> points)
        {
            var texts = points.Select(p => $"({p.X},{p.Y})").ToList();

            return String.Join(',', texts.ToArray());
        }

        private static void WriteDataTableHeader(string header1, string header2, string header3, string header4, string header5)
        {
            Console.WriteLine($"|{header1}|{header2}|{header3}|{header4}|{header5}|");
            Console.WriteLine($"|-----------|-----------|-----------|-----------|-----------|");
        }

        private static void WriteDataTableRow(string index, string bruteForceResults, double bruteForceTime, string aResults, double aTime)
        {
            Console.WriteLine($"|{index}|{bruteForceResults}|{bruteForceTime}|{aResults}|{aTime}|");
        }
    }
}
