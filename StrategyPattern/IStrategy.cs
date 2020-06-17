namespace StrategyPattern
{
    public interface IStrategy
    {
        GeoCoordinate[] FindShortestPath(GeoCoordinate source, GeoCoordinate target);
    }
}
