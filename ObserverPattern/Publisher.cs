using System.Collections.Generic;

namespace ObserverPattern
{
    internal class Publisher<T>
    {
        private readonly List<ISubscriber<T>> Observers = new List<ISubscriber<T>>();
        private T subject;

        public T Subject
        {
            get => subject;
            set
            {
                subject = value;
                this.Notify();
            }
        }

        public void Register(ISubscriber<T> observer)
        {
            Observers.Add(observer);
        }

        public void Unregister(ISubscriber<T> observer)
        {
            Observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (ISubscriber<T> observer in Observers)
            {
                observer.Update(subject);
            }
        }
    }
}
