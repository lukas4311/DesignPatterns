namespace AbstractFactoryPattern
{
    public class SteelHood : ICarHood
    {
        public MaterialType GetHoodMaterial()
        {
            return MaterialType.Steel;
        }
    }
}
