using System;

namespace StrategyPattern
{
    public class WalkingStrategy : IStrategy
    {
        public GeoCoordinate[] FindShortestPath(GeoCoordinate source, GeoCoordinate target)
        {
            // find shorted path for walk
            Console.WriteLine("Walking to target");
            return new[] { new GeoCoordinate(49.055, 50.165) };
        }
    }
}
