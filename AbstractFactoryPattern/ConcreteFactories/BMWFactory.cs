namespace AbstractFactoryPattern
{
    public class BMWFactory : ICarFactory
    {
        public ICarEngine GetCarEngine()
        {
            return new V8Engine();
        }

        public ICarHood GetCarHood()
        {
            return new CarbonFibreHood();
        }
    }
}
