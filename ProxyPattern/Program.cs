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

        }
    }
}
