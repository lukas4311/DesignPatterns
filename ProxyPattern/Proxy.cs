using System;

namespace ProxyPattern
{
    public class Proxy : IService
    {
        private readonly Service service;

        public Proxy(Service service)
        {
            this.service = service;
        }

        public void DoOperation()
        {
            this.CheckAccess();
            this.service.DoOperation();
        }

        private void CheckAccess()
        {
            Console.WriteLine("Check access");
        }
    }
}
