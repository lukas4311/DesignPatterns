using System;

namespace ObserverPattern
{
    internal class MailService : IMailService
    {
        public void SendMail(string message)
        {
            Console.WriteLine($"Sending message: {message}");
        }
    }
}