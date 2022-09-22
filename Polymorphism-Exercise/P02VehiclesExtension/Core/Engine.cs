namespace VehiclesExtension.Core
{
    using System;
    using VehiclesExtension.Core.Interfaces;
    using VehiclesExtension.Models;

    public class Engine : IEngine
    {
        private readonly Vehicle car;
        private readonly Vehicle truck;
        private readonly Vehicle bus;

        public Engine()
        {

        }
        public Engine(Vehicle car, Vehicle truck, Vehicle bus)
            :base()
        {
            this.car = car;
            this.truck = truck;
            this.bus = bus;
        }
        public void Start()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] cmdArgs = Console.ReadLine().Split();
                string cmdType = cmdArgs[0];
                string vehicleType = cmdArgs[1];
                double cmdParam = double.Parse(cmdArgs[2]);

                if (cmdType == "Drive")
                {
                    if (vehicleType == "Car")
                    {
                        Console.WriteLine(this.car.Drive(cmdParam));
                    }
                    else if (vehicleType == "Truck")
                    {
                        Console.WriteLine(this.truck.Drive(cmdParam));
                    }
                    else if(vehicleType == "Bus")
                    {
                        Console.WriteLine(this.bus.Drive(cmdParam));
                    }
                }
                else if(cmdType == "DriveEmpty")
                {
                    Bus bus1 = bus as Bus;
                    Console.WriteLine(bus1.DriveEmpty(cmdParam));
                }
                else if (cmdType == "Refuel")
                {
                    try
                    {
                        if (vehicleType == "Car")
                        {
                            this.car.Refuel(cmdParam);
                        }
                        else if (vehicleType == "Truck")
                        {
                            this.truck.Refuel(cmdParam);
                        }
                        else if (vehicleType == "Bus")
                        {
                            this.bus.Refuel(cmdParam);
                        }
                    }
                    catch (ArgumentException ae)
                    {

                        Console.WriteLine(ae.Message);
                    }
                   
                }
            }
            Console.WriteLine(this.car);
            Console.WriteLine(this.truck);
            Console.WriteLine(this.bus);
        }
    }
}
