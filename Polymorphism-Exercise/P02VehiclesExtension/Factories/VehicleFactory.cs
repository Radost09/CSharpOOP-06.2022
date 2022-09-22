namespace VehiclesExtension.Factories
{
    using System;
    using VehiclesExtension.Factories.Interfaces;
    using VehiclesExtension.Models;

    public class VehicleFactory : IVehicleFactory
    {
        public Vehicle CreateVehicle
            (string vehicleType, double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            Vehicle vehicle;

            if (vehicleType == "Car")
            {
                vehicle = new Car(fuelQuantity, fuelConsumption, tankCapacity);
            }
            else if (vehicleType == "Truck")
            {
                vehicle = new Truck(fuelQuantity, fuelConsumption, tankCapacity);
            }
            else if(vehicleType == "Bus")
            {
                vehicle = new Bus(fuelQuantity, fuelConsumption, tankCapacity);
            }
            else
            {
                throw new ArgumentException("Invalid vehicle type!");
            }
            return vehicle;
        }
    }
}
