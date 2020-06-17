using System;

namespace StrategyPattern
{
    public class RoadStrategy
    {
        public GeoCoordinate[] FindShortestPath(GeoCoordinate source, GeoCoordinate target)
        {
            // find shorted path for walk
            Console.WriteLine("By car to target");
            return new[] { new GeoCoordinate(48.145, 48.2546) };
        }
    }
}
