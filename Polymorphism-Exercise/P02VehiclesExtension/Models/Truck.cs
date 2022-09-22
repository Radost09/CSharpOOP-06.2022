namespace VehiclesExtension.Models
{
    using System;
    public class Truck : Vehicle
    {
        private const double TruckFuelConsumptionIncrement = 1.6;
        private const double RefuelCoefficent = 0.95;
        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity) 
            : base(fuelQuantity, fuelConsumption + TruckFuelConsumptionIncrement, tankCapacity)
        {

        }
        
        public override void Refuel(double liters)
        {
            if (liters > TankCapacity)
            {
                throw new ArgumentException($"Cannot fit {liters} fuel in the tank");
            }
                base.Refuel(liters * RefuelCoefficent);
            
        }
    }
}
