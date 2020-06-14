namespace ObserverPattern
{
    internal interface ISubscriber<T>
    {
        void Update(T data);
    }
}
