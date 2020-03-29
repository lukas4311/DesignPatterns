using System;

public class RefinedAbstraction : Abstraction
{
    public RefinedAbstraction(IBridge bridge) : base(bridge)
    { }

    public override void Operation()
    {
        this.bridge.SomeOperation();
        Console.WriteLine("Refined class and concrete bridge impelementation call");
    }
}