using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Strategy pattern!");
            Navigator navigator = new Navigator(RouteStrategies.Walk);
            navigator.ShowShortestPath(new GeoCoordinate(45.0, 45.456), new GeoCoordinate(51.151, 50.121));
        }
    }
}
