using System.Collections.Generic;
using System.Linq;

namespace MediatorPattern
{
    public class ConcreteMediator : Mediator
    {
        public List<Colleague> Colleagues = new List<Colleague>();

        public override void Send(string message, Colleague colleague)
        {
            this.Colleagues.Where(c => c != colleague).ToList().ForEach(c => c.HandleNotification(message));
        }

        public T CreateColleague<T>() where T: Colleague, new()
        {
            T colleague = new T();
            colleague.RegisterMediator(this);
            this.Colleagues.Add(colleague);
            return colleague;
        }

        public void Register(Colleague colleague)
        {
            colleague.RegisterMediator(this);
            this.Colleagues.Add(colleague);
        }
    }
}
