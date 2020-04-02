namespace AbstractFactoryPattern
{
    public class V8Engine : ICarEngine
    {
        public string GetEngineSpecification()
        {
            return "This is 8 cylinder engine.";
        }
    }
}
