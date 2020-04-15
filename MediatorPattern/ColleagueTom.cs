using System;

namespace MediatorPattern
{
    public class ColleagueTom : Colleague
    {
        public override void HandleNotification(string message)
        {
            Console.WriteLine("Tom recieves message");
        }
    }
}
