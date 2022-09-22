namespace VehiclesExtension.Factories.Interfaces
{
    using VehiclesExtension.Models;
    public interface IVehicleFactory
    {
        Vehicle CreateVehicle(string vehicleType, double fuelQuantity, double fuelConsumption, double tankCapacity);
    }
}
