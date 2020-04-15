namespace MediatorPattern
{
    public abstract class Colleague
    {
        protected Mediator Mediator;

        internal void RegisterMediator(Mediator mediator)
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