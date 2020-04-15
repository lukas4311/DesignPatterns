namespace MediatorPattern
{
    public abstract class Colleague
    {
        protected Mediator Mediator;

        public Colleague(Mediator mediator)
        {
            this.Mediator = mediator;
        }

        public virtual void Send(string message)
        {
            this.Mediator.Send(message, this);
        }

        public abstract void HandleNotification(string message);
    }
}