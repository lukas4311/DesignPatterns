using System;

namespace PrototypePattern
{
    internal class ConcretePrototype : IPrototype
    {
        internal int Value { get; set; }

        internal string Name { get; set; }

        public IPrototype DoDeepCopy()
        {
            ConcretePrototype clone = this.MemberwiseClone() as ConcretePrototype;
            clone.Name = new string(Name);
            return clone;
        }

        public IPrototype DoShallowCopy()
        {
            return this.MemberwiseClone() as ConcretePrototype;
        }
    }
}
