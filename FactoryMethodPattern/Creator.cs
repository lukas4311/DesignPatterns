namespace FactoryMethodPattern
{
    public abstract class Creator
    {
        public abstract IProduct FactoryMethod();

        public string SomeOperation()
        {
            IProduct product = FactoryMethod();
            return "Creator: The same creator's code has just worked with " + product.Operation();
        }
    }
}
