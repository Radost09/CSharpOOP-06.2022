
namespace P02VehiclesExtension
{
    using System;
    using VehiclesExtension.Core;
    using VehiclesExtension.Core.Interfaces;
    using VehiclesExtension.Factories;
    using VehiclesExtension.Factories.Interfaces;
    using VehiclesExtension.Models;

    public class StartUp
    {
        static void Main(string[] args)
        {
            try
            {
                string[] carData = Console.ReadLine().Split();
                string[] truckData = Console.ReadLine().Split();
                string[] busData = Console.ReadLine().Split();

                IVehicleFactory vehicleFactory = new VehicleFactory();

                Vehicle car =vehicleFactory.CreateVehicle(carData[0], double.Parse(carData[1]), double.Parse(carData[2]), double.Parse(carData[3]));
                Vehicle truck =
                    vehicleFactory.CreateVehicle(truckData[0], double.Parse(truckData[1]), double.Parse(truckData[2]), double.Parse(truckData[3]));
                Vehicle bus = vehicleFactory.CreateVehicle(busData[0], double.Parse(busData[1]), double.Parse(busData[2]), double.Parse(busData[3]));

                IEngine engine = new Engine(car, truck, bus);
                engine.Start();
            }
            catch (ArgumentException ae)
            {

                Console.WriteLine(ae.Message);
                
            }

        }
    }
}
