using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            CarBuilder builder = new CarBuilder();
            Director director = new Director(builder);

            director.BuildLowCostCar();
            Car newCar = builder.GetCar();
            Console.WriteLine(newCar.GetCarConfiguration());
        }
    }
}
