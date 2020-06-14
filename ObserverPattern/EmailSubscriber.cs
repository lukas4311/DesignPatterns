namespace ObserverPattern
{
    internal class EmailSubscriber : ISubscriber<object>
    {
        private readonly MailService mailService;

        public EmailSubscriber(MailService mailService)
        {
            this.mailService = mailService;
        }

        public void Update(object data)
        {
            this.SendMailNotification(data);
        }

        private void SendMailNotification(object data)
        {
            this.mailService.SendMail(data.ToString());
        }
    }
}
