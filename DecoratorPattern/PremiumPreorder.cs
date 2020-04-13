using System;

namespace DecoratorPattern
{
    internal class PremiumPreorder : OrderDecorator
    {
        public PremiumPreorder(OrderBase order) : base(order)
        { }

        public override double CalculateTotalOrderPrice()
        {
            Console.WriteLine($"Calculating the total price in the {nameof(PremiumPreorder)} class.");
            Console.WriteLine("Adding additional discount to a preorder price");
            return base.CalculateTotalOrderPrice() * 0.9;
        }
    } 
}