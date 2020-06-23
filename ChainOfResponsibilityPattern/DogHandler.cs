namespace ChainOfResponsibilityPattern
{
    internal class DogHandler : AbstractHandler
    {
        public override object Handle(object request)
        {
            if (request is string s && s == "Bone")
            {
                return $"Dog: I'll eat the {request}.\n";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}
