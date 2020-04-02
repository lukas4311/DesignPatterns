using System;
using System.Collections.Generic;
using System.Linq;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            string carName = string.Empty;

            do
            {
                if(!string.IsNullOrEmpty(carName))
                    Console.WriteLine("**** Zadaný typ vozidla je neznámý ****");

                Console.WriteLine("**** Zadejte typ vozidla ****");
                carName = Console.ReadLine();
            } while (!client.IsKnownCreateProcessOfCarType(carName));

            client.CreateCar(carName);
            Console.ReadLine();
        }
    }

    internal class Client
    {
        private ICarFactory vehicleFactory = null;

        public Dictionary<string, Func<ICarFactory>> FactoryDictionaryOfFactoryTypes { get; set; } = new Dictionary<string, Func<ICarFactory>>
        {
            { "toyota", () => new ToyotaFactory()},
            { "bmw", () => new BMWFactory()}
        };

        public bool IsKnownCreateProcessOfCarType(string carType)
        {
            return this.FactoryDictionaryOfFactoryTypes.Keys.Count(k => string.Equals(k, carType, StringComparison.OrdinalIgnoreCase)) != 0;
        }

        public void CreateCar(string carName)
        {
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
