namespace Vehicles.Factories.Interfaces
{
    using Vehicles.Models;
    public interface IVehicleFactory
    {
        Vehicle CreateVehicle(string vehicleType, double fuelQuantity, double fuelConsumption);
    }
}
