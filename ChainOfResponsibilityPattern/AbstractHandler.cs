namespace ChainOfResponsibilityPattern
{
    internal abstract class AbstractHandler : IHandler
    {
        private IHandler NextHandler;

        public IHandler SetNext(IHandler handler)
        {
            this.NextHandler = handler;

            return handler;
        }

        public virtual object Handle(object request)
        {
            if (this.NextHandler != null)
            {
                return this.NextHandler.Handle(request);
            }
            else
            {
                return null;
            }
        }
    }
}
