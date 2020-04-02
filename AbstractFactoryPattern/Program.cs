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

        private Dictionary<string, ICarFactory> FactoryDictionaryOfFactoryTypes { get; set; } = new Dictionary<string, ICarFactory>
        {
            { "toyota", new ToyotaFactory()},
            { "bmw", new BMWFactory()}
        };

        public bool IsKnownCreateProcessOfCarType(string carType)
        {
            return this.FactoryDictionaryOfFactoryTypes.Keys.Count(k => string.Equals(k, carType, StringComparison.OrdinalIgnoreCase)) != 0;
        }

        public void CreateCar(string carName)
        {
            vehicleFactory = this.FactoryDictionaryOfFactoryTypes.Single(k => string.Equals(carName, k.Key, StringComparison.OrdinalIgnoreCase)).Value;
            Console.Write($"{carName} uses {vehicleFactory.GetCarEngine().GetEngineSpecification()} with {vehicleFactory.GetCarHood().GetHoodMaterial()} as headlight");
        }
    }
}
