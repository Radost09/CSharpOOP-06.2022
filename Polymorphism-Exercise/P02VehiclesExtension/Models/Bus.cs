namespace VehiclesExtension.Models
{
    internal class Bus : Vehicle
    {
        private const double FullBusFuelConsumptionIncrement = 1.4;
        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity) 
            : base(fuelQuantity, fuelConsumption + FullBusFuelConsumptionIncrement, tankCapacity)
        {

        }
        //protected override double FuelConsumptionModifier
        //    => FullBusFuelConsumptionIncrement;

        //public override void Refuel(double liters)
        //{
        //    base.Refuel(liters);
        //}
        public string DriveEmpty(double distance)
        {
            double neededFuel = distance * (this.FuelConsumption - FullBusFuelConsumptionIncrement);
            if(this.FuelQuantity > neededFuel)
            {
                this.FuelQuantity -= neededFuel;
                return $"{this.GetType().Name} travelled {distance} km";
            }
            else
            {
                return $"{this.GetType().Name} needs refueling";
            }
        }
    }
}
