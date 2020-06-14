namespace ObserverPattern
{
    public interface ISubscriber<T>
    {
        void Update(T data);
    }
}
