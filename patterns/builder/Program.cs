using System;

namespace builder
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractCar car = new Saloon();
            VehicleBuilder builder = new CarBuilder(car);
            VehicleDirector director = new CarDirector();
            IVehicle v = director.Build(builder);
            System.Console.WriteLine(v);
            Console.Read();
        }
    }
}
