using System;

namespace MediatorPattern
{
    public class ColleagueTom : Colleague
    {
        public ColleagueTom(Mediator mediator) : base(mediator)
        {}

        public override void HandleNotification(string message)
        {
            Console.WriteLine("Tom recieves message");
        }
    }
}
