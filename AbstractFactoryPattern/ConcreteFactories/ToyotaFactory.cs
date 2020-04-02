using System;

namespace AbstractFactoryPattern
{
    public class ToyotaFactory : ICarFactory
    {
        public ICarEngine GetCarEngine()
        {
            return new V4Engine();
        }

        public ICarHood GetCarHood()
        {
            return new SteelHood();
        }
    }
}
