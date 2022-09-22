namespace VehiclesExtension.Models
{
    using System;
    using VehiclesExtension.Models.Interfaces;
    public abstract class Vehicle : IVehicle
    {
        private double fuelQuantity;
        private double fuelConsumption;
        private double tankCapacity;
        private Vehicle()
        {
            this.FuelConsumptionModifier = 0;
        }
        public Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
            :this()
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
            this.TankCapacity = tankCapacity;
        }

        public double FuelQuantity
        {
            get 
            { 
                return this.fuelQuantity; 
            }
            protected set 
            { 
                if(value > TankCapacity)
                {
                    this.fuelQuantity = 0;
                }
                this.fuelQuantity = value; 
            }
        }

        public virtual double FuelConsumption
        {
            get 
            { 
                return this.fuelConsumption; 
            }
            protected set 
            { 
                this.fuelConsumption = value + FuelConsumptionModifier; 
            }
        }

        public double TankCapacity
        {
            get 
            { 
                return this.tankCapacity; 
            }
            protected set 
            { 
                this.tankCapacity = value; 
            }
        }
        protected virtual double FuelConsumptionModifier { get; }

        public string Drive(double distance)
        {
            double fuelNeeded = distance * this.FuelConsumption;

            if (this.FuelQuantity > fuelNeeded)
            {
                this.FuelQuantity -= fuelNeeded;
                return $"{this.GetType().Name} travelled {distance} km";
                
            }
            else
            {
                return $"{this.GetType().Name} needs refueling";
            }
            
        }

        public virtual void Refuel(double liters)
        {
            if(liters <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");

            }
            if(liters > TankCapacity)
            {
                throw new ArgumentException($"Cannot fit {liters} fuel in the tank");
            }
            this.FuelQuantity += liters;
            
        }
        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:f2}";
        }
    }
}
