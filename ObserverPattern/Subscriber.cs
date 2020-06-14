using System;

namespace ObserverPattern
{
    public class Subscriber : ISubscriber<object>
    {
        public void Update(object data)
        {
            Console.WriteLine(data);
        }
    }
}
