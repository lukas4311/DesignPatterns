using System;

namespace StrategyPattern
{
    public class Navigator
    {
        private readonly RouteStrategies routeStrategies;

        public Navigator(RouteStrategies routeStrategies)
        {
            this.routeStrategies = routeStrategies;
        }

        public void ShowShortestPath(GeoCoordinate source, GeoCoordinate target)
        {
            IStrategy strategy = this.routeStrategies switch
            {
                RouteStrategies.Road => new RoadStrategy(),
                RouteStrategies.Walk => new WalkingStrategy(),
                _ => throw new NotImplementedException()
            };

            GeoCoordinate[] path = strategy.FindShortestPath(source, target);
            
            foreach (GeoCoordinate pathPoint in path)
            {
                Console.WriteLine(pathPoint);
            }
        }
    }
}
