using System;

namespace MediatorPattern
{
    public class ColleagueLuke : Colleague
    {
        public override void HandleNotification(string message)
        {
            Console.WriteLine("Luke recieves message");
        }
    }
}
