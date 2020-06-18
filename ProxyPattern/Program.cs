using System;

namespace ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Proxy pattern!");

            App app = new App();
            Service realService = new Service();
            Proxy proxyService = new Proxy(realService);

            // Calling real service
            app.DoServiceOperation(realService);

            // Calling proxy service
            app.DoServiceOperation(proxyService);
        }
    }
}
