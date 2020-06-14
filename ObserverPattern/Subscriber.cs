using System;

namespace ObserverPattern
{
    internal class Subscriber : ISubscriber<object>
    {
        public void Update(object data)
        {
            Console.WriteLine(data);
        }
    }
}
