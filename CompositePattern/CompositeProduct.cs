using System.Collections.Generic;

public class CompositeProduct : Product, ICompositeOperations
{
    private List<Product> products = new List<Product>();

    public CompositeProduct(string name, decimal price) : base(name, price)
    { }

    public void Add(Product product)
    {
        this.products.Add(product);
    }

    public void Remove(Product product)
    {
        this.products.Remove(product);
    }

    public override decimal GetTotalPrice()
    {
        decimal total = 0;

        foreach (Product product in this.products)
        {
            total += product.GetTotalPrice();
        }

        return total;
    }
}