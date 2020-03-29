public abstract class Product
{
    protected string name;

    protected decimal price;

    public Product(string name, decimal price)
    {
        this.name = name;
        this.price = price;
   }
 
    public abstract decimal GetTotalPrice();
}