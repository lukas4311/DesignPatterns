using System;

namespace MediatorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteMediator concreteMediator = new ConcreteMediator();
            ColleagueLuke colleagueLuke = new ColleagueLuke(concreteMediator);
            ColleagueTom colleagueTom = new ColleagueTom(concreteMediator);
            concreteMediator.ColleagueLuke = colleagueLuke;
            concreteMediator.ColleagueTom = colleagueTom;

            colleagueLuke.Send("Ahoj Tome, tady Luke");
        }
    }
}
