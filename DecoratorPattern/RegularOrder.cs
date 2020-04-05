internal class RegularOrder : OrderBase
{
    public override CalculateTotalOrderPrice(){
        Console.WriteLine("Calculating the total price of a regular order");
        return products.Sum(x => x.Price);
    }
}