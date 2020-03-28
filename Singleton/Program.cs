using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test singleton.");
            SingletonClass singletonInstance = SingletonClass.GetInstance();
            SingletonClass sameSingletonIntance = SingletonClass.GetInstance();

            Console.WriteLine(singletonInstance.Equals(sameSingletonIntance));
        }
    }
}
