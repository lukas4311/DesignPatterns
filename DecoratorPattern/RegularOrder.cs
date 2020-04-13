
using System;
using System.Linq;

namespace DecoratorPattern
{
    internal class RegularOrder : OrderBase
    {
        public override double CalculateTotalOrderPrice()
        {
            Console.WriteLine("Calculating the total price of a regular order");
            return products.Sum(x => x.Price);
        }
    }
}