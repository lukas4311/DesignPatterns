namespace AbstractFactoryPattern
{
    public interface ICarFactory
    {
        ICarEngine GetCarEngine();

        ICarHood GetCarHood();
    }
}
