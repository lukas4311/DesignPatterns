using System;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Zadejte typ vozidla ****");
            Client client = new Client();
            string carName = Console.ReadLine();
            client.CreateCar(carName);
            Console.ReadLine();
        }
    }

    internal class Client
    {
        private ICarFactory vehicleFactory = null;

        public void CreateCar(string carName)
        {
            if (string.IsNullOrEmpty(carName))
            {
                Console.WriteLine("Název typu vozidla je prázdný");
                return;
            }

            if (string.Equals(carName, "toyota", StringComparison.OrdinalIgnoreCase))
            {
                vehicleFactory = new ToyotaFactory();
            }
            else if (string.Equals(carName, "bmw", StringComparison.OrdinalIgnoreCase))
            {
                vehicleFactory = new BMWFactory();
            }

            Console.Write($"{carName} uses {vehicleFactory.GetCarEngine().GetEngineSpecification()} with {vehicleFactory.GetCarHood().GetHoodMaterial()} as headlight");
        }
    }
}
