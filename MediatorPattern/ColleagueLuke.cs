using System;

namespace MediatorPattern
{
    public class ColleagueLuke : Colleague
    {
        public ColleagueLuke(Mediator mediator) : base(mediator)
        { }

        public override void HandleNotification(string message)
        {
            Console.WriteLine("Luke recieves message");
        }
    }
}
