public class SingleProduct : Product
{
    public SingleProduct(string name, decimal price) : base(name, price)
    { }

    public override decimal GetTotalPrice()
    {
        return price;
    }
}