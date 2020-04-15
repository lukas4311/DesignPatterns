using System;

namespace MediatorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteMediator concreteMediator = new ConcreteMediator();
            ColleagueLuke colleagueLuke = concreteMediator.CreateColleague<ColleagueLuke>();
            ColleagueTom _ = concreteMediator.CreateColleague<ColleagueTom>();

            colleagueLuke.Send("Ahoj Tome, tady Luke");
        }
    }
}
