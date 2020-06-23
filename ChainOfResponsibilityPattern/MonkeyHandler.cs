namespace ChainOfResponsibilityPattern
{
    internal class MonkeyHandler : AbstractHandler
    {
        public override object Handle(object request)
        {
            if (request is string s && s == "Banana")
            {
                return $"Monkey: I'll eat the {request}.\n";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}
