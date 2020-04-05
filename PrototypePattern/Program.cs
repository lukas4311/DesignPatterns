using System;

namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ConcretePrototype concretePrototype = new ConcretePrototype();
            concretePrototype.Name = "Name";
            concretePrototype.Value = 10;

            ConcretePrototype shallowCopy = concretePrototype.DoShallowCopy() as ConcretePrototype;
            ConcretePrototype deepCopy = concretePrototype.DoDeepCopy() as ConcretePrototype;
        }
    }
}
