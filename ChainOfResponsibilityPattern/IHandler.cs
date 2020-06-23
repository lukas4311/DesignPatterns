namespace ChainOfResponsibilityPattern
{
    internal interface IHandler
    {
        IHandler SetNext(IHandler handler);

        object Handle(object request);
    }
}
