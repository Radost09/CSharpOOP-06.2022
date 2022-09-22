namespace Vehicles.Models
{
    public class Truck : Vehicle
    {
        private const double TruckFuelConsumptionIncrement = 1.6;
        private const double RefuelCoefficent = 0.95;
        public Truck(double fuelQuantity, double fuelConsumption) 
            : base(fuelQuantity, fuelConsumption)
        {

        }
        public override double FuelConsumption 
        { 
            get
            {
                return base.FuelConsumption;
            }
            protected set
            {
                base.FuelConsumption = value + TruckFuelConsumptionIncrement;
            }
        }
        public override void Refuel(double liters)
        {
            base.Refuel(liters * RefuelCoefficent);
        }
    }
}
