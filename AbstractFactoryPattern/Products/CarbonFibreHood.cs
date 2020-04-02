namespace AbstractFactoryPattern
{
    public class CarbonFibreHood : ICarHood
    {
        public MaterialType GetHoodMaterial()
        {
            return MaterialType.CarbonFibre;
        }
    }
}
