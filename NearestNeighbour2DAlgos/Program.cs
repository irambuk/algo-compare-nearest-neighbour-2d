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
            var noOfPointsToFind = 3;

            var pointsGenerator = new TestSpaceGenerator();
            var executor = new SearchExecutor();

            var bruteForceSearcher = new BruteForceNearestNeighbourSearcher();
            var optimisedBruteForceSearcher = new OptimisedBruteForceNearestNeighbourSearcher();

            WriteDataTableHeader("No. of Points In the Space", "No. of Neighbours to Find", "Given Point", "BruteForce - results", "BruteForce - time", "Optmised - results", "Optmised - time");
            
            for (int i = 1; i <= 10; i++)
            {
                var currentNoOfPoints = i * 1000000;

                var randomIndex = new Random().Next(0, currentNoOfPoints);

                var points = pointsGenerator.GenerateTestSpace(currentNoOfPoints, -2000, 2000, -2000, 2000);
                var point = points[randomIndex];


                var bruteForceResult = executor.ExecuteSearch(bruteForceSearcher, point, noOfPointsToFind, points);
                var optimisedResult = executor.ExecuteSearch(optimisedBruteForceSearcher, point, noOfPointsToFind, points);

                WriteDataTableRow(currentNoOfPoints, noOfPointsToFind, ResultsToString(point), ResultsToString(bruteForceResult.NearestNeighbours), bruteForceResult.TimeInMilliseconds, ResultsToString(optimisedResult.NearestNeighbours), optimisedResult.TimeInMilliseconds);
            }

            Console.WriteLine("Press enter to terminate");
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

        private static void WriteDataTableHeader(string header1, string header2, string header3, string header4, string header5, string header6, string header7)
        {
            Console.WriteLine($"|{header1}|{header2}|{header3}|{header4}|{header5}|{header6}|{header7}|");
            Console.WriteLine($"|-----------|-----------|-----------|-----------|-----------|-----------|-----------|");
        }

        private static void WriteDataTableRow(int noOfTotalPoints, int noOfPointsToFind, string givenPoint, string bruteForceResults, double bruteForceTime, string optmisedResults, double optmisedTime)
        {
            Console.WriteLine($"|{noOfTotalPoints}|{noOfPointsToFind}|{givenPoint}|{bruteForceResults}|{bruteForceTime}|{optmisedResults}|{optmisedTime}|");
        }
    }
}
