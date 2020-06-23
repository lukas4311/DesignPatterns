namespace ChainOfResponsibilityPattern
{
    internal class SnakeHandler : AbstractHandler
    {
        public override object Handle(object request)
        {
            if (request is string s && s == "Rat")
            {
                return $"Snake: I'll eat the {request}.\n";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}
