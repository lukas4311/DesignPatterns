using System;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteBridgeImplementation concreteBridge = new ConcreteBridgeImplementation();
            RefinedAbstraction usedAbstraction = new RefinedAbstraction(concreteBridge);
            usedAbstraction.Operation();
            Console.WriteLine("Hello World!");
        }
    }
}
