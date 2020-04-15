namespace MediatorPattern
{
    public class ConcreteMediator : Mediator
    {
        public ColleagueLuke ColleagueLuke;

        public ColleagueTom ColleagueTom;

        public override void Send(string message, Colleague colleague)
        {
            if (colleague == this.ColleagueLuke)
            {
                this.ColleagueTom.HandleNotification(message);
            }
            else if (colleague == ColleagueTom)
            {
                this.ColleagueLuke.HandleNotification(message);
            }
        }
    }
}
